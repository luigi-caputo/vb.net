
Public Class Poppi
    Dim Clo As Boolean = True

    Private Sub tmrOp_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrOp.Tick
        Try
            If Me.Width <= 30 Then
                Clo = False
                Me.Close()
            Else
                Clo = True
                Me.Width = Me.Width - 3
            End If
        Catch ex As Exception
            Me.Close()
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Poppi_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If Clo = True Then
                e.Cancel = True
            Else
                e.Cancel = False
            End If
        Catch ex As Exception
            Me.Close()
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Poppi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            My.Computer.Audio.Play(Application.StartupPath & "\^^.wav")
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

End Class