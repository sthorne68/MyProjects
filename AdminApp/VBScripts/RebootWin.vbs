
ComputerName = InputBox("Enter the name of the computer you want to Reboot")

Set OpSysSet = GetObject("winmgmts:{(RemoteShutdown)}//" & ComputerName & "/root/cimv2").ExecQuery("select * from Win32_OperatingSystem where Primary=true")

for each OpSys in OpSysSet
  OpSys.Reboot()
next