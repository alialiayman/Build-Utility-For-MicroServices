title MML.Services.Workflow
net stop ListViewItem: {iMP.ServiceHost}
net stop ListViewItem: {iMP.APSPlatformService}
net stop ListViewItem: {iMP.WorkflowService}
"C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\MSBuild\15.0\Bin\msbuild.exe" C:\Code\iMP\126\trunk.126\MML.Services\General\Workflow\MML.Services.Workflow.sln /p:Configuration=Debug /p:Platform="Any CPU" /t:build /maxcpucount:4 /fl /flp:logfile=MML.Services.Workflow636727793952872676.log;verbosity=normal /clp:ErrorsOnly;ShowEventId;verbosity=normal
Timeout /T 30