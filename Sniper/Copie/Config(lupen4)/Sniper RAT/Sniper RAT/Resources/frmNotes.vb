Imports System.IO
Public Class frmNotes

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            If Not Directory.Exists(Application.StartupPath & "\Computers") = True Then
                MkDir(Application.StartupPath & "\Computers")
                If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblCl.Text) = True Then
                    MkDir(Application.StartupPath & "\Computers\N" & Me.lblCl.Text)

                    If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblCl.Text & "\ScreenShot") = True Then
                        MkDir(Application.StartupPath & "\Computers\N" & Me.lblCl.Text & "\ScreenShot")
                    End If

                    If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblCl.Text & "\Downloads") = True Then
                        MkDir(Application.StartupPath & "\Computers\N" & Me.lblCl.Text & "\Downloads")
                    End If
                End If
            Else
                If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblCl.Text) = True Then
                    MkDir(Application.StartupPath & "\Computers\N" & Me.lblCl.Text)

                    If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblCl.Text & "\ScreenShot") = True Then
                        MkDir(Application.StartupPath & "\Computers\N" & Me.lblCl.Text & "\ScreenShot")
                    End If

                    If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblCl.Text & "\Downloads") = True Then
                        MkDir(Application.StartupPath & "\Computers\N" & Me.lblCl.Text & "\Downloads")
                    End If
                Else

                    If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblCl.Text & "\ScreenShot") = True Then
                        MkDir(Application.StartupPath & "\Computers\N" & Me.lblCl.Text & "\ScreenShot")
                    End If

                    If Not Directory.Exists(Application.StartupPath & "\Computers\N" & Me.lblCl.Text & "\Downloads") = True Then
                        MkDir(Application.StartupPath & "\Computers\N" & Me.lblCl.Text & "\Downloads")
                    End If
                End If
            End If


            Dim wr2 As StreamWriter
            wr2 = New StreamWriter(Application.StartupPath & "\Computers\N" & Me.lblCl.Text & "\Notes.txt", False)
            wr2.Write(txtNotes.Text)
            wr2.Flush()
            wr2.Close()

            MsgBox("The text has been saved successfully in the special folder", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        txtNotes.Text = ""
    End Sub

End Class