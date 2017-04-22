
MachineName = InputBox("Enter name of the computer to connect to : ")

set oShell = CreateObject("WScript.Shell").Exec("mstsc -v:" & MachineName)
