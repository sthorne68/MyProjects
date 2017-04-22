' Service.vbs
' Sample script to List services N-Z
' www.computerperformance.co.uk/
' Author Guy Thomas http://computerperformance.co.uk/
' Version 1.5 December 2005
' -------------------------------------------------------' 
' Modified for use on multiple computers and to return the result into an HTML list
' by Robert Rader 8/10/2005
Option Explicit
Dim objWMIService, objItem, objService, strServiceList
Dim colListOfServices, strComputer, strService, arrayComputers, comp
Dim objFS, objNewFile, fileHTMLName, Sh

fileHTMLName = "ServicesList.html"

Set objFS = CreateObject("Scripting.FileSystemObject")
Set objNewFile = objFS.CreateTextFile(fileHTMLName)

objNewFile.WriteLine "<HTML><BODY><H3>Date: " & Now() &"</H3>"


'arrayComputers=Array("arunloan.esri.com","canuck.esri.com","halifax.esri.com","loan221777.esri.com","pepper.esri.com","sansoo.esri.com","tigers.esri.com","truenorth.esri.com","zap8.esri.com","zap09.esri.com","zap10.esri.com","zap11.esri.com","zap12.esri.com","zap13.esri.com","zap14.esri.com","zap15.esri.com","upsserver.esri.com","dev000960.esri.com","dev06906.esri.com","dev001417.esri.com", "deeboo.esri.com")

' arrayComputers=Array("arunloan","canuck","halifax")

'strComputer = "tigers"

strComputer = InputBox("Enter Machine Name : ")

arrayComputers=Array(UCase(strComputer))


For each comp in arrayComputers
   Set objWMIService = GetObject("winmgmts:" _
   & "{impersonationLevel=impersonate}!\\" _
   & comp & "\root\cimv2")

   Set colListOfServices = objWMIService.ExecQuery _
   ("Select * from Win32_Service where caption like 'ArcSde%' "_
    & "or caption like '%ArcGIS%'")
   
   ' WMI and VBScript loop
   strServiceList = strServiceList & "<h1>" & comp &"</h1><table>" _
   & "<TR><TD>Service Name</TD><TD>Running</TD><TD>Location</TD></TR>"

   For Each objService in colListOfServices
      ' If UCase(Left(objService.name,1)) >"N" then
          strServiceList = strServiceList & "<TR>" _
          & "<TD>" & objService.name & "</TD><TD>" & objService.Started _
          & "</TD><TD>" & objService.PathName & "</TD></TR>"    
      ' End if

   Next

   strServiceList = strServiceList &"</table>"

Next

objNewFile.WriteLine strServiceList
objNewFile.WriteLine "</BODY></HTML>"

' End of Example WMI script to list services
objNewFile.Close

Set Sh = WScript.CreateObject("WScript.Shell")

Sh.Run fileHTMLName, 3 

' WScript.Echo("Searching Machines for Services")


