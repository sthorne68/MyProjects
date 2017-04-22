
' http://msdn.microsoft.com/en-us/library/aa394378(VS.85).aspx#windows_installer_provider


' strComputer = "tigers.esri.com"

strComputer = InputBox("Enter Machine Name : ")


' Message Box that times out
'   https://technet.microsoft.com/en-us/library/ee156593.aspx

Const TIMEOUT = 5
Set objShell = WScript.CreateObject("WScript.Shell")
objShell.Popup "The results may take a few moments to appear.  Please be patient.", TIMEOUT



Set objWMIService = GetObject("winmgmts:" & _
    "{impersonationLevel=impersonate}!\\" & _
    strComputer & _
    "\root\cimv2")

Set colSoftware = objWMIService.ExecQuery ("SELECT * FROM Win32_Product where Caption like '%ArcGIS%'")  
'("SELECT * FROM Win32_Product where Caption like '%Oracle%' or caption like '%SQL%'") 


If colSoftware.Count > 0 Then

    Set objFSO = CreateObject("Scripting.FileSystemObject")
    Set objTextFile = objFSO.CreateTextFile("C:\TEMP\Installed_ArcGIS_Software_on_" & strComputer & ".txt", True)


    For Each objSoftware in colSoftware
       'print to console
       'Wscript.Echo "Server : & vbTab & strComputer
       'Wscript.Echo "Product : & vbTab & objSoftware.Caption
       'Wscript.Echo "Version : & vbTab & objSoftware.Version 

        objTextFile.WriteLine _
	strComputer & vbtab & _
	objSoftware.Caption & vbtab & _
        objSoftware.Version
    Next

    objTextFile.Close

Else
    WScript.Echo "Cannot retrieve software from this computer."

End If

'filename = "C:\TEMP\Installed_ArcGIS_Software_on_" & strComputer & ".txt"

'MsgBox("Software List complete.  To view results, open file : C:\TEMP\Installed_ArcGIS_Software_on_" & strComputer & ".txt")

'MsgBox("Software List complete.  To view results, open file : " & filename)


' Open the file
Dim oShell
Set oShell = WScript.CreateObject ("WScript.Shell")
oShell.run "notepad.exe C:\TEMP\Installed_ArcGIS_Software_on_" & strComputer & ".txt"
Set oShell = Nothing

