title REST.API
net stop ListViewItem: {iMP.ServiceHost}
net stop ListViewItem: {iMP.APSPlatformService}
"C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\MSBuild\15.0\Bin\msbuild.exe" C:\Code\iMP\126\trunk.126\REST.API.sln /p:Configuration=Debug /p:Platform="Any CPU" /t:build /maxcpucount:4 /fl /flp:logfile=REST.API636727801618450158.log;verbosity=normal /clp:ErrorsOnly;ShowEventId;verbosity=normal
Timeout /T 30