namespace CVBuild
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstSolutions = new System.Windows.Forms.ListBox();
            this.dfsSearch = new System.Windows.Forms.TextBox();
            this.lstiMPServices = new System.Windows.Forms.ListBox();
            this.tmrServices = new System.Windows.Forms.Timer(this.components);
            this.lstSolutionsToBuild = new System.Windows.Forms.ListBox();
            this.dfsServicesFilter = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sbMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsBuild = new System.Windows.Forms.ToolStripSplitButton();
            this.tbBuild = new System.Windows.Forms.TabControl();
            this.tbBuildControl = new System.Windows.Forms.TabPage();
            this.grpServicesToRestart = new System.Windows.Forms.GroupBox();
            this.lstRestartServices = new System.Windows.Forms.ListView();
            this.btnRemoveService = new System.Windows.Forms.Button();
            this.btnStopSelected = new System.Windows.Forms.Button();
            this.btnStartSelectedServices = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRemoveFromSolutionsToBuild = new System.Windows.Forms.Button();
            this.btnBuildAllSolutionsToBuild = new System.Windows.Forms.Button();
            this.tbSettings = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddService = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ltnSolutionFolder = new System.Windows.Forms.LinkLabel();
            this.btnAddToSolutionsToBuild = new System.Windows.Forms.Button();
            this.tmrBuildMonitor = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.tbBuild.SuspendLayout();
            this.tbBuildControl.SuspendLayout();
            this.grpServicesToRestart.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tbSettings.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstSolutions
            // 
            this.lstSolutions.FormattingEnabled = true;
            this.lstSolutions.Location = new System.Drawing.Point(13, 45);
            this.lstSolutions.Name = "lstSolutions";
            this.lstSolutions.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstSolutions.Size = new System.Drawing.Size(530, 173);
            this.lstSolutions.TabIndex = 7;
            // 
            // dfsSearch
            // 
            this.dfsSearch.Location = new System.Drawing.Point(413, 20);
            this.dfsSearch.Name = "dfsSearch";
            this.dfsSearch.Size = new System.Drawing.Size(89, 20);
            this.dfsSearch.TabIndex = 8;
            this.dfsSearch.TextChanged += new System.EventHandler(this.dfsSearch_TextChanged);
            // 
            // lstiMPServices
            // 
            this.lstiMPServices.FormattingEnabled = true;
            this.lstiMPServices.Location = new System.Drawing.Point(6, 45);
            this.lstiMPServices.Name = "lstiMPServices";
            this.lstiMPServices.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstiMPServices.Size = new System.Drawing.Size(240, 173);
            this.lstiMPServices.TabIndex = 10;
            // 
            // tmrServices
            // 
            this.tmrServices.Interval = 2000;
            this.tmrServices.Tick += new System.EventHandler(this.tmrServices_Tick);
            // 
            // lstSolutionsToBuild
            // 
            this.lstSolutionsToBuild.FormattingEnabled = true;
            this.lstSolutionsToBuild.Location = new System.Drawing.Point(6, 45);
            this.lstSolutionsToBuild.Name = "lstSolutionsToBuild";
            this.lstSolutionsToBuild.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstSolutionsToBuild.Size = new System.Drawing.Size(554, 173);
            this.lstSolutionsToBuild.TabIndex = 14;
            this.lstSolutionsToBuild.SelectedIndexChanged += new System.EventHandler(this.lstSolutionsToBuild_SelectedIndexChanged);
            // 
            // dfsServicesFilter
            // 
            this.dfsServicesFilter.Location = new System.Drawing.Point(41, 20);
            this.dfsServicesFilter.Name = "dfsServicesFilter";
            this.dfsServicesFilter.Size = new System.Drawing.Size(67, 20);
            this.dfsServicesFilter.TabIndex = 20;
            this.dfsServicesFilter.TextChanged += new System.EventHandler(this.dfsServicesFilter_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbMessage,
            this.tsBuild});
            this.statusStrip1.Location = new System.Drawing.Point(0, 258);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(834, 22);
            this.statusStrip1.TabIndex = 25;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sbMessage
            // 
            this.sbMessage.Name = "sbMessage";
            this.sbMessage.Size = new System.Drawing.Size(787, 17);
            this.sbMessage.Spring = true;
            this.sbMessage.Text = "Ready...";
            // 
            // tsBuild
            // 
            this.tsBuild.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBuild.Image = global::CVBuild.Properties.Resources.Build;
            this.tsBuild.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBuild.Name = "tsBuild";
            this.tsBuild.Size = new System.Drawing.Size(32, 20);
            this.tsBuild.Text = "Build";
            this.tsBuild.ButtonClick += new System.EventHandler(this.tsBuild_ButtonClick);
            // 
            // tbBuild
            // 
            this.tbBuild.Controls.Add(this.tbBuildControl);
            this.tbBuild.Controls.Add(this.tbSettings);
            this.tbBuild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBuild.Location = new System.Drawing.Point(0, 0);
            this.tbBuild.Name = "tbBuild";
            this.tbBuild.SelectedIndex = 0;
            this.tbBuild.Size = new System.Drawing.Size(834, 258);
            this.tbBuild.TabIndex = 27;
            // 
            // tbBuildControl
            // 
            this.tbBuildControl.Controls.Add(this.grpServicesToRestart);
            this.tbBuildControl.Controls.Add(this.groupBox4);
            this.tbBuildControl.Location = new System.Drawing.Point(4, 22);
            this.tbBuildControl.Name = "tbBuildControl";
            this.tbBuildControl.Padding = new System.Windows.Forms.Padding(3);
            this.tbBuildControl.Size = new System.Drawing.Size(826, 232);
            this.tbBuildControl.TabIndex = 0;
            this.tbBuildControl.Text = "Build Control";
            this.tbBuildControl.UseVisualStyleBackColor = true;
            // 
            // grpServicesToRestart
            // 
            this.grpServicesToRestart.Controls.Add(this.lstRestartServices);
            this.grpServicesToRestart.Controls.Add(this.btnRemoveService);
            this.grpServicesToRestart.Controls.Add(this.btnStopSelected);
            this.grpServicesToRestart.Controls.Add(this.btnStartSelectedServices);
            this.grpServicesToRestart.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpServicesToRestart.Location = new System.Drawing.Point(576, 3);
            this.grpServicesToRestart.Name = "grpServicesToRestart";
            this.grpServicesToRestart.Size = new System.Drawing.Size(247, 226);
            this.grpServicesToRestart.TabIndex = 27;
            this.grpServicesToRestart.TabStop = false;
            this.grpServicesToRestart.Text = "iMP Services";
            // 
            // lstRestartServices
            // 
            this.lstRestartServices.Location = new System.Drawing.Point(6, 45);
            this.lstRestartServices.Name = "lstRestartServices";
            this.lstRestartServices.Size = new System.Drawing.Size(228, 173);
            this.lstRestartServices.TabIndex = 23;
            this.lstRestartServices.UseCompatibleStateImageBehavior = false;
            this.lstRestartServices.View = System.Windows.Forms.View.List;
            // 
            // btnRemoveService
            // 
            this.btnRemoveService.BackgroundImage = global::CVBuild.Properties.Resources.minus;
            this.btnRemoveService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemoveService.Location = new System.Drawing.Point(209, 18);
            this.btnRemoveService.Name = "btnRemoveService";
            this.btnRemoveService.Size = new System.Drawing.Size(25, 23);
            this.btnRemoveService.TabIndex = 23;
            this.btnRemoveService.UseVisualStyleBackColor = true;
            this.btnRemoveService.Click += new System.EventHandler(this.btnRemoveService_Click);
            // 
            // btnStopSelected
            // 
            this.btnStopSelected.BackgroundImage = global::CVBuild.Properties.Resources.stop;
            this.btnStopSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStopSelected.Location = new System.Drawing.Point(6, 18);
            this.btnStopSelected.Name = "btnStopSelected";
            this.btnStopSelected.Size = new System.Drawing.Size(25, 23);
            this.btnStopSelected.TabIndex = 26;
            this.btnStopSelected.UseVisualStyleBackColor = true;
            this.btnStopSelected.Click += new System.EventHandler(this.btnStopSelected_Click);
            // 
            // btnStartSelectedServices
            // 
            this.btnStartSelectedServices.BackgroundImage = global::CVBuild.Properties.Resources.Play;
            this.btnStartSelectedServices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStartSelectedServices.Location = new System.Drawing.Point(37, 18);
            this.btnStartSelectedServices.Name = "btnStartSelectedServices";
            this.btnStartSelectedServices.Size = new System.Drawing.Size(25, 23);
            this.btnStartSelectedServices.TabIndex = 24;
            this.btnStartSelectedServices.UseVisualStyleBackColor = true;
            this.btnStartSelectedServices.Click += new System.EventHandler(this.btnStartSelectedServices_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lstSolutionsToBuild);
            this.groupBox4.Controls.Add(this.btnRemoveFromSolutionsToBuild);
            this.groupBox4.Controls.Add(this.btnBuildAllSolutionsToBuild);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(566, 226);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "iMP Solutions";
            // 
            // btnRemoveFromSolutionsToBuild
            // 
            this.btnRemoveFromSolutionsToBuild.BackgroundImage = global::CVBuild.Properties.Resources.minus;
            this.btnRemoveFromSolutionsToBuild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemoveFromSolutionsToBuild.Location = new System.Drawing.Point(533, 18);
            this.btnRemoveFromSolutionsToBuild.Name = "btnRemoveFromSolutionsToBuild";
            this.btnRemoveFromSolutionsToBuild.Size = new System.Drawing.Size(27, 23);
            this.btnRemoveFromSolutionsToBuild.TabIndex = 22;
            this.btnRemoveFromSolutionsToBuild.UseVisualStyleBackColor = true;
            this.btnRemoveFromSolutionsToBuild.Click += new System.EventHandler(this.btnRemoveFromSolutionsToBuild_Click);
            // 
            // btnBuildAllSolutionsToBuild
            // 
            this.btnBuildAllSolutionsToBuild.BackgroundImage = global::CVBuild.Properties.Resources.Build;
            this.btnBuildAllSolutionsToBuild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuildAllSolutionsToBuild.Location = new System.Drawing.Point(452, 13);
            this.btnBuildAllSolutionsToBuild.Name = "btnBuildAllSolutionsToBuild";
            this.btnBuildAllSolutionsToBuild.Size = new System.Drawing.Size(40, 29);
            this.btnBuildAllSolutionsToBuild.TabIndex = 18;
            this.btnBuildAllSolutionsToBuild.UseVisualStyleBackColor = false;
            this.btnBuildAllSolutionsToBuild.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbSettings
            // 
            this.tbSettings.Controls.Add(this.groupBox2);
            this.tbSettings.Controls.Add(this.groupBox1);
            this.tbSettings.Location = new System.Drawing.Point(4, 22);
            this.tbSettings.Name = "tbSettings";
            this.tbSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tbSettings.Size = new System.Drawing.Size(826, 232);
            this.tbSettings.TabIndex = 1;
            this.tbSettings.Text = "Settings";
            this.tbSettings.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dfsServicesFilter);
            this.groupBox2.Controls.Add(this.lstiMPServices);
            this.groupBox2.Controls.Add(this.btnAddService);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(571, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 226);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "iMP Services";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Filter";
            // 
            // btnAddService
            // 
            this.btnAddService.BackgroundImage = global::CVBuild.Properties.Resources.Add;
            this.btnAddService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddService.Location = new System.Drawing.Point(219, 19);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(27, 23);
            this.btnAddService.TabIndex = 17;
            this.btnAddService.UseVisualStyleBackColor = false;
            this.btnAddService.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ltnSolutionFolder);
            this.groupBox1.Controls.Add(this.btnAddToSolutionsToBuild);
            this.groupBox1.Controls.Add(this.lstSolutions);
            this.groupBox1.Controls.Add(this.dfsSearch);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "iMP Solutions";
            // 
            // ltnSolutionFolder
            // 
            this.ltnSolutionFolder.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::CVBuild.Properties.Settings.Default, "dfsBranch", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ltnSolutionFolder.Location = new System.Drawing.Point(12, 15);
            this.ltnSolutionFolder.Name = "ltnSolutionFolder";
            this.ltnSolutionFolder.Size = new System.Drawing.Size(395, 25);
            this.ltnSolutionFolder.TabIndex = 22;
            this.ltnSolutionFolder.Text = global::CVBuild.Properties.Settings.Default.dfsBranch;
            this.ltnSolutionFolder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ltnSolutionFolder_LinkClicked);
            // 
            // btnAddToSolutionsToBuild
            // 
            this.btnAddToSolutionsToBuild.BackgroundImage = global::CVBuild.Properties.Resources.Add;
            this.btnAddToSolutionsToBuild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddToSolutionsToBuild.Location = new System.Drawing.Point(508, 19);
            this.btnAddToSolutionsToBuild.Name = "btnAddToSolutionsToBuild";
            this.btnAddToSolutionsToBuild.Size = new System.Drawing.Size(27, 23);
            this.btnAddToSolutionsToBuild.TabIndex = 15;
            this.btnAddToSolutionsToBuild.UseVisualStyleBackColor = false;
            this.btnAddToSolutionsToBuild.Click += new System.EventHandler(this.btnAddToSolutionsToBuild_Click);
            // 
            // tmrBuildMonitor
            // 
            this.tmrBuildMonitor.Interval = 2000;
            this.tmrBuildMonitor.Tick += new System.EventHandler(this.tmrBuildMonitor_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 280);
            this.Controls.Add(this.tbBuild);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "iMP Build";
            this.ResizeBegin += new System.EventHandler(this.Form1_ResizeBegin);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tbBuild.ResumeLayout(false);
            this.tbBuildControl.ResumeLayout(false);
            this.grpServicesToRestart.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tbSettings.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstSolutions;
        private System.Windows.Forms.TextBox dfsSearch;
        private System.Windows.Forms.ListBox lstiMPServices;
        private System.Windows.Forms.Timer tmrServices;
        private System.Windows.Forms.ListBox lstSolutionsToBuild;
        private System.Windows.Forms.Button btnAddToSolutionsToBuild;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Button btnBuildAllSolutionsToBuild;
        private System.Windows.Forms.TextBox dfsServicesFilter;
        private System.Windows.Forms.Button btnRemoveFromSolutionsToBuild;
        private System.Windows.Forms.Button btnRemoveService;
        private System.Windows.Forms.Button btnStartSelectedServices;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sbMessage;
        private System.Windows.Forms.Button btnStopSelected;
        private System.Windows.Forms.TabControl tbBuild;
        private System.Windows.Forms.TabPage tbBuildControl;
        private System.Windows.Forms.TabPage tbSettings;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpServicesToRestart;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView lstRestartServices;
        private System.Windows.Forms.LinkLabel ltnSolutionFolder;
        private System.Windows.Forms.Timer tmrBuildMonitor;
        private System.Windows.Forms.ToolStripSplitButton tsBuild;
    }
}

