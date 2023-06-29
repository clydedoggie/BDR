Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        ' Declaration
        Public Sub Me_Startup(ByVal sender As Object, ByVal e As StartupEventArgs) Handles Me.Startup
            Dim sStartupArgs As String = ""
#If DEBUG Then
            If My.Application.CommandLineArgs.Count > 0 Then sStartupArgs = My.Application.CommandLineArgs(0)
#Else
            If my.application.commandlineargs.count>0 then  sstartupargs=my.application.commandlineargs(0)
#End If
            StartupBDR(sStartupArgs, True)
        End Sub
        Public Sub Me_StartupAgain(ByVal sender As Object, ByVal e As StartupNextInstanceEventArgs) Handles Me.StartupNextInstance
            Dim sStartupArgs As String = ""

            If My.Application.CommandLineArgs.Count > 0 Then sStartupArgs = My.Application.CommandLineArgs(0)
            StartupBDR(sStartupArgs, False)
        End Sub

    End Class
End Namespace
