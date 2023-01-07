Imports System.Text.UTF8Encoding 'Importo il namespace System.Text.UTF8Encoding per la codifica dei dati
Public Class frmTahc

    Private Sub cmdSendMR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSendMR.Click
        If Not txtScrR.Text = "" Then
            If frmMain.isconn = True Then
                frmMain.tmrLusso.Enabled = False
                frmMain.netstream.Write(UTF8.GetBytes(txtScrR.Text & "_<\2/"), 0, UTF8.GetBytes(txtScrR.Text & "_<\2/").Length) 'invio il comando al server
                txtChatR.Text = txtChatR.Text & frmMain.Na2 & ": " & txtScrR.Text & vbCrLf
                txtScrR.Text = ""
            Else
                frmMain.tmrDati.Enabled = False 'Chiudo il timer per la ricezione di dati
                frmMain.tmrDatiSchermo.Enabled = False
                frmMain.tmrDatiDow.Enabled = False
                frmMain.tmrDatiUp.Enabled = False
                frmMain.tmrDatiWeb.Enabled = False
                frmMain.tmrDatiKey.Enabled = False
                frmMain.tmrDatiSD.Enabled = False

                frmMain.tmrSchermoCl.Enabled = False
                frmMain.tmrUpCl.Enabled = False
                frmMain.tmrDowCl.Enabled = False
                frmMain.tmrWebCl.Enabled = False
                frmMain.tmrKeyCl.Enabled = False
                frmMain.tmrSDCl.Enabled = False
                mdMacBew.SendMessage(frmMain.HPazzo, WM_CAP_DRIVER_DISCONNECT, frmMain.Dev3, 0)
                DestroyWindow(frmMain.HPazzo)
                frmMain.mciSendString("close recsound", "", 0, 0)
            End If
        End If
    End Sub

    Private Sub frmTahc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmMain.tmrLusso.Enabled = False
    End Sub
End Class