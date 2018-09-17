using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.ServiceProcess;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CVBuild
{
    public partial class Form1 : Form
    {
        List<string> allSolutions = new List<string>();
        List<string> solutionsToBuild = new List<string>();
        List<string> allimpServices = new List<string>();
        IMPServices impServicesManager = new IMPServices();
        List<string> logFiles = new List<string>();
        public Form1()
        {
            InitializeComponent();
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            lstRestartServices.Columns.Add("Name",-2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!IsUserAdministrator())
            {
                MessageBox.Show(
                    "You must start this program as an administrator because.\nPlease restart as administrator.\nThe application will now shutdown",
                    "Run as administrator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            allimpServices = impServicesManager.GetImpServices();
            lstiMPServices.DataSource = allimpServices;
            DeleteTempFiles();
            //lblimpServices.Text = "iMP Services " + lstiMPServices.Items.Count;
            if (!string.IsNullOrEmpty(ltnSolutionFolder.Text) && ltnSolutionFolder.Text.Contains("\\"))
            {
                LoadAllSolutions();
                if (File.Exists("Services.txt"))
                {
                    foreach (var svcName in File.ReadAllLines("Services.txt"))
                    {
                        var itm = new ListViewItem();
                        itm.Text = svcName;
                        if (impServicesManager.IsRunning(svcName)) itm.BackColor = Color.LightGreen; else itm.BackColor = Color.White; 
                        lstRestartServices.Items.Add(itm);
                        impServicesManager.Services.Add(svcName);
                    }

                }
                 
                if (File.Exists("Solutions.txt"))
                {
                    foreach (var slnName in File.ReadAllLines("Solutions.txt"))
                    {
                        lstSolutionsToBuild.Items.Add(slnName);
                    }

                }
            }
        }

        private void DeleteTempFiles()
        {
            var tempFiles = Directory.GetFiles(".","*.*").ToList();
            
            foreach (var file in tempFiles)
            {
                if (file.ToLower().EndsWith(".log") || file.ToLower().EndsWith(".bat"))
                File.Delete(file);
            }
        }

        private void LoadAllSolutions()
        {
            if (!ltnSolutionFolder.Text.Contains("\\")) return;
            try
            {
                var solutions = Directory.GetFiles(ltnSolutionFolder.Text, "*.sln", SearchOption.AllDirectories);
                foreach (var item in solutions)
                {
                    allSolutions.Add(item);
                    var index = lstSolutions.Items.Add(item);
                }
            }
            catch { }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void StopSelectedServices()
        {
            tmrServices.Start();
            var servicesToStop = new List<string>();
            foreach (ListViewItem item in lstRestartServices.Items)
            {
                servicesToStop.Add(item.Text);
            }
            impServicesManager.StopServices(servicesToStop);


        }


        public bool IsUserAdministrator()
        {
            try
            {
                var user = WindowsIdentity.GetCurrent();
                var principal = new WindowsPrincipal(user);
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            catch
            {
                return false;
            }
        }


        private void DisplayMessage(string message)
        {
            this.Invoke((MethodInvoker)delegate
            {
                sbMessage.Text = message;
            });

        }

        private void StartSelectedServices()
        {
            tmrServices.Start();
            var servicesToStart = new List<string>();
            foreach (ListViewItem item in lstRestartServices.Items)
            {
                servicesToStart.Add(item.Text);
            }
            impServicesManager.StartServices(servicesToStart);

        }


        private void btnBuild_Click(object sender, EventArgs e)
        {


        }

        private void dfsSearch_TextChanged(object sender, EventArgs e)
        {
            lstSolutions.DataSource = allSolutions.Where(x => x.ToLower().Contains(dfsSearch.Text.ToLower())).ToList();

        }

        private void tmrServices_Tick(object sender, EventArgs e)
        {
            
            foreach (ListViewItem item in lstRestartServices.Items)
            {
                if (impServicesManager.IsRunning(item.Text))
                    item.BackColor = Color.LightGreen;
                else
                    item.BackColor = Color.White;

            }
        }

        private void btnAddToSolutionsToBuild_Click(object sender, EventArgs e)
        {
            foreach (var item in lstSolutions.SelectedItems)
            {
                lstSolutionsToBuild.Items.Add(item);
            }

            File.WriteAllLines("Solutions.txt", lstSolutionsToBuild.Items.Cast<string>());
        }

        private void btnRemoveFromSolutionsToBuild_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSolutionsToBuild.SelectedItems.Count; i++)
            {
                lstSolutionsToBuild.Items.Remove(lstSolutionsToBuild.SelectedItems[i]);
            }
            File.WriteAllLines("Solutions.txt", lstSolutionsToBuild.Items.Cast<string>());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in lstiMPServices.SelectedItems)
            {
                lstRestartServices.Items.Add(new ListViewItem(new [] { item.ToString() }));
            }

            File.WriteAllLines("Services.txt",lstRestartServices.Items.Cast<ListViewItem>().ToList().Select(x=> x.Text));
        }

        private void btnRemoveService_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstRestartServices.SelectedItems.Count; i++)
            {
                lstRestartServices.Items.Remove(lstRestartServices.SelectedItems[i]);
            }
            File.WriteAllLines("Services.txt", lstRestartServices.Items.Cast<ListViewItem>().ToList().Select(x => x.Text));
        }

        private void dfsServicesFilter_TextChanged(object sender, EventArgs e)
        {
            lstiMPServices.DataSource = allimpServices.Where(x => x.ToLower().Contains(dfsServicesFilter.Text.ToLower())).ToList();
        }

        string buildId;
        private void button2_Click(object sender, EventArgs e)
        {
            Build();
            
        }

        private void Build()
        {
            StopSelectedServices();
            buildId = DateTime.Now.Ticks.ToString();
            solutionsToBuild.Clear();
            if (lstSolutionsToBuild.SelectedItems.Count == 0)
            {
                foreach (var sln in lstSolutionsToBuild.Items)
                {
                    solutionsToBuild.Add(sln.ToString());
                }
            }
            else
            {
                foreach (var sln in lstSolutionsToBuild.SelectedItems)
                {
                    solutionsToBuild.Add(sln.ToString());
                }
            }


            foreach (var sln in solutionsToBuild)
            {
                var slnName = Path.GetFileNameWithoutExtension(sln.ToString());
                var batchCommand = "title " + slnName + Environment.NewLine;
                foreach (var svcName in lstRestartServices.Items)
                {
                    batchCommand += "net stop " + svcName.ToString() + Environment.NewLine;
                }
                batchCommand += "\"C:\\Program Files (x86)\\Microsoft Visual Studio\\2017\\Community\\MSBuild\\15.0\\Bin\\msbuild.exe\" ";
                batchCommand += sln.ToString() + " /p:Configuration=Debug /p:Platform=\"Any CPU\" /t:build /maxcpucount:4 /fl /flp:logfile=" + slnName + buildId + ".log;verbosity=normal /clp:ErrorsOnly;ShowEventId;verbosity=normal";
                batchCommand += Environment.NewLine + "Timeout /T 30";
                var batchFileName = slnName + ".bat";
                File.WriteAllText(batchFileName, batchCommand);
                Process.Start(batchFileName);
            }
            MonitorBuild();
        }

        private void MonitorBuild()
        {
            tmrBuildMonitor.Start();
        }

        private void btnStartSelectedServices_Click(object sender, EventArgs e)
        {
            StartSelectedServices();
        }

        private void btnStopSelected_Click(object sender, EventArgs e)
        {
            StopSelectedServices();
        }

        private void lstSolutionsToBuild_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSolutionsToBuild.SelectedItems.Count == 1)
            {
                Clipboard.SetText(lstSolutionsToBuild.SelectedItem.ToString());
                sbMessage.Text = "Copied " + lstSolutionsToBuild.SelectedItem.ToString();
            }
        }

        private void ltnSolutionFolder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\Code\imp\126";
            ofd.Filter = "Solutions|*.sln";
            ofd.ShowDialog();
            if (!string.IsNullOrEmpty(ofd.FileName))
            {
                ltnSolutionFolder.Text = Path.GetDirectoryName(ofd.FileName);
                LoadAllSolutions();
            }
        }

        private void Form1_ResizeBegin(object sender, EventArgs e)
        {

        }

        private void tmrBuildMonitor_Tick(object sender, EventArgs e)
        {
            tmrBuildMonitor.Stop();
            var logsRemaining = new List<string>();
            solutionsToBuild.ForEach(x => logsRemaining.Add(x));
            foreach (var sln in solutionsToBuild)
            {
                var logFile = Path.GetFileNameWithoutExtension(sln) + buildId + ".log";

                if (File.Exists(logFile))
                {
                    try
                    {
                        var contents = File.ReadAllText(logFile);

                        var errors = Regex.Match(contents, @"(\d+) Error\(s\)");
                        if (errors.Success)
                        {
                            if (errors.Groups[1].ToString() == "0")
                            {
                                logsRemaining.Remove(sln);
                            }
                            else //There are errors
                            {
                                //Build Failed
                                return; //Do not start the timer again

                            }
                        }
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
            solutionsToBuild =  logsRemaining;
            if (solutionsToBuild.Count() == 0)
            {
                StartSelectedServices();
                return;
            }
            tmrBuildMonitor.Start();
        }

        private void tsBuild_ButtonClick(object sender, EventArgs e)
        {
            this.Width = grpServicesToRestart.Width + 100;
            this.Top = Screen.PrimaryScreen.WorkingArea.Bottom - this.Height;
            this.Left = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            Build();
        }
    }
}
