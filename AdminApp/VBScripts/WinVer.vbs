
' http://blogs.msdn.com/b/nevermet/archive/2008/07/15/how-to-identify-windows-version-and-edition-with-vbs.aspx


' strComputer = "tigers.esri.com"

strComputer = InputBox("Enter Machine Name : ")


Set objWMIService = GetObject("winmgmts:" _
& "{impersonationLevel=impersonate}!\\" & strComputer & "\root\cimv2")

Set colOperatingSystems = objWMIService.ExecQuery _
("Select * from Win32_OperatingSystem")

For Each objOperatingSystem in colOperatingSystems
  Msgbox "Machine Name : " & UCase(strComputer) & vbLf & _
  objOperatingSystem.Caption & " " & _ 
  objOperatingSystem.Version, 0 + 32,"Windows Version Info" 

Next