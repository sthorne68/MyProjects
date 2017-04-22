

'--------------------------------------------------------------- 
'                                                                              
'  ..::AdamWorkingHard@EvilBytes.com (c) 2006::..      
'                                                                              
'    Name:  RemoteAddUser.vbs            
'    Desc:  Add users to Admin group from a remote PC  
' Require:  Must be admin of the remote PC. 
'            http://evilbytes.com/forums/viewtopic.php?p=536&sid=6b2e18b41e55e9c3d71513a017dd1c91           
'---------------------------------------------------------------  

Option Explicit 

Dim strComputer 
Dim strDomain 
Dim strGroup 
Dim strUser 
Dim strMsg 
Dim objGroup 
Dim objUser 

'----- Settings ----- 
strComputer = "." 
strDomain = "AVWORLD" 
strGroup = "Administrators" 
'-------------------- 

'----- Input target PC ----- 
strComputer = InputBox _ 
(vbLf & "Please enter Computer Name or IP Address" & vbLf & _ 
"to add to local admin group","IT Support REMOTE admin - Add user to admin group","") 
If strComputer = "" Then 
   strMsg = "Please enter a computer name/IP address" 
   MsgBox strMsg, 48, "IT Support - Error" 
   wscript.quit 
End If 
'--------------------------- 

'----- Input Username ----- 
strUser = InputBox(vbLf & vbLf & "Enter username: " & vbLf & _ 
vbLf & vbLf & vbLf & vbLf & "DO NOT specify the domain", "IT Support REMOTE admin - Add user to admin group","") 
If strUser = "" Then 
   strMsg = "Please enter a login name" 
   MsgBox strMsg, 48, "IT Support - Error" 
   wscript.quit 
End If    
'-------------------------- 

'----- Local Comp/UserName check ----- 
Set objGroup = GetObject("WinNT://" & strComputer & "/" & strGroup & ",group") 
   If Err <> 0 Then 
      strMsg = "Cannot find Computer Name or IP address entered" 
      MsgBox strMsg, 16, "IT Support - Error" 
      wscript.quit 
   End If 
    
'Username / check 
On Error Resume Next 
Set objUser = GetObject("WinNT://" & strDomain & "/" & strUser & ",user") 
objGroup.add(objUser.ADsPath) 
    'Error trap 
   If Err <> 0 Then 
      strMsg = "Cannot find username OR username already in admin group" 
      MsgBox strMsg, 16, "IT Support - Error" 
      wscript.quit 
   End If 
'---------------------------------------- 

'---- Success msg ----- 
strMsg = "Added username:      " & strUser & _ 
vbLf & "To computer / IP:     " & strComputer 
MsgBox strMsg, 0, "IT Support REMOTE admin - Successfully added" 
wscript.quit 
'---------------------- 