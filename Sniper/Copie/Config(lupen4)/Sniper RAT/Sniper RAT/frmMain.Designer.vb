<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lstwIpReverse = New System.Windows.Forms.ListView()
        Me.grpRac = New System.Windows.Forms.GroupBox()
        Me.cmdPChkOp = New System.Windows.Forms.Button()
        Me.picBoxStart = New System.Windows.Forms.PictureBox()
        Me.cmdChiuSock = New System.Windows.Forms.Button()
        Me.nudPorta = New System.Windows.Forms.NumericUpDown()
        Me.cmdAttivaP = New System.Windows.Forms.Button()
        Me.cmdUn = New System.Windows.Forms.Button()
        Me.cmdClo = New System.Windows.Forms.Button()
        Me.cmdRes = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.cmdAbout = New System.Windows.Forms.Button()
        Me.cmdClientSett = New System.Windows.Forms.Button()
        Me.cmdSniperSett = New System.Windows.Forms.Button()
        Me.mstr = New System.Windows.Forms.MenuStrip()
        Me.SniperMainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TopMostFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveIPListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecentConnectionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblCC = New System.Windows.Forms.Label()
        Me.lblSC = New System.Windows.Forms.Label()
        Me.lblBan = New System.Windows.Forms.Label()
        Me.cmdFuckNoIp = New System.Windows.Forms.Button()
        Me.tmrPen = New System.Windows.Forms.Timer(Me.components)
        Me.tmrDati = New System.Windows.Forms.Timer(Me.components)
        Me.cxmsrToolBox = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Settings = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComputerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShutdownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetInfosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TakeNotesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PortToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.UninstalClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.nudLimCl = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdSetLimit = New System.Windows.Forms.Button()
        Me.imlstIP = New System.Windows.Forms.ImageList(Me.components)
        Me.bkwIp = New System.ComponentModel.BackgroundWorker()
        Me.picFulmine = New System.Windows.Forms.PictureBox()
        Me.bkwFNI = New System.ComponentModel.BackgroundWorker()
        Me.grpRac.SuspendLayout()
        CType(Me.picBoxStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPorta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.mstr.SuspendLayout()
        Me.cxmsrToolBox.SuspendLayout()
        CType(Me.nudLimCl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFulmine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstwIpReverse
        '
        Me.lstwIpReverse.FullRowSelect = True
        Me.lstwIpReverse.GridLines = True
        Me.lstwIpReverse.LabelEdit = True
        Me.lstwIpReverse.Location = New System.Drawing.Point(95, 77)
        Me.lstwIpReverse.MultiSelect = False
        Me.lstwIpReverse.Name = "lstwIpReverse"
        Me.lstwIpReverse.Size = New System.Drawing.Size(464, 364)
        Me.lstwIpReverse.TabIndex = 0
        Me.lstwIpReverse.UseCompatibleStateImageBehavior = False
        Me.lstwIpReverse.View = System.Windows.Forms.View.Details
        '
        'grpRac
        '
        Me.grpRac.Controls.Add(Me.cmdPChkOp)
        Me.grpRac.Controls.Add(Me.picBoxStart)
        Me.grpRac.Controls.Add(Me.cmdChiuSock)
        Me.grpRac.Controls.Add(Me.nudPorta)
        Me.grpRac.Controls.Add(Me.cmdAttivaP)
        Me.grpRac.Controls.Add(Me.cmdUn)
        Me.grpRac.Controls.Add(Me.cmdClo)
        Me.grpRac.Controls.Add(Me.cmdRes)
        Me.grpRac.Location = New System.Drawing.Point(5, 106)
        Me.grpRac.Name = "grpRac"
        Me.grpRac.Size = New System.Drawing.Size(84, 335)
        Me.grpRac.TabIndex = 5
        Me.grpRac.TabStop = False
        Me.grpRac.Text = "Clients"
        '
        'cmdPChkOp
        '
        Me.cmdPChkOp.Location = New System.Drawing.Point(5, 134)
        Me.cmdPChkOp.Name = "cmdPChkOp"
        Me.cmdPChkOp.Size = New System.Drawing.Size(73, 23)
        Me.cmdPChkOp.TabIndex = 13
        Me.cmdPChkOp.Text = "Port mapper"
        Me.cmdPChkOp.UseVisualStyleBackColor = True
        '
        'picBoxStart
        '
        Me.picBoxStart.Image = Global.Sniper.My.Resources.Resources._1295814102_satelite
        Me.picBoxStart.Location = New System.Drawing.Point(6, 163)
        Me.picBoxStart.Name = "picBoxStart"
        Me.picBoxStart.Size = New System.Drawing.Size(72, 73)
        Me.picBoxStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxStart.TabIndex = 12
        Me.picBoxStart.TabStop = False
        '
        'cmdChiuSock
        '
        Me.cmdChiuSock.Location = New System.Drawing.Point(6, 308)
        Me.cmdChiuSock.Name = "cmdChiuSock"
        Me.cmdChiuSock.Size = New System.Drawing.Size(73, 21)
        Me.cmdChiuSock.TabIndex = 11
        Me.cmdChiuSock.Text = "Close sock"
        Me.cmdChiuSock.UseVisualStyleBackColor = True
        '
        'nudPorta
        '
        Me.nudPorta.Location = New System.Drawing.Point(6, 242)
        Me.nudPorta.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.nudPorta.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudPorta.Name = "nudPorta"
        Me.nudPorta.Size = New System.Drawing.Size(72, 20)
        Me.nudPorta.TabIndex = 10
        Me.nudPorta.Value = New Decimal(New Integer() {6551, 0, 0, 0})
        '
        'cmdAttivaP
        '
        Me.cmdAttivaP.Location = New System.Drawing.Point(6, 268)
        Me.cmdAttivaP.Name = "cmdAttivaP"
        Me.cmdAttivaP.Size = New System.Drawing.Size(73, 40)
        Me.cmdAttivaP.TabIndex = 9
        Me.cmdAttivaP.Text = "Start listening"
        Me.cmdAttivaP.UseVisualStyleBackColor = True
        '
        'cmdUn
        '
        Me.cmdUn.Location = New System.Drawing.Point(6, 74)
        Me.cmdUn.Name = "cmdUn"
        Me.cmdUn.Size = New System.Drawing.Size(73, 54)
        Me.cmdUn.TabIndex = 7
        Me.cmdUn.Text = "Uninstall and delete client"
        Me.cmdUn.UseVisualStyleBackColor = True
        '
        'cmdClo
        '
        Me.cmdClo.Location = New System.Drawing.Point(6, 48)
        Me.cmdClo.Name = "cmdClo"
        Me.cmdClo.Size = New System.Drawing.Size(73, 23)
        Me.cmdClo.TabIndex = 6
        Me.cmdClo.Text = "Close"
        Me.cmdClo.UseVisualStyleBackColor = True
        '
        'cmdRes
        '
        Me.cmdRes.Location = New System.Drawing.Point(6, 19)
        Me.cmdRes.Name = "cmdRes"
        Me.cmdRes.Size = New System.Drawing.Size(73, 23)
        Me.cmdRes.TabIndex = 5
        Me.cmdRes.Text = "Restart"
        Me.cmdRes.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdHelp)
        Me.GroupBox1.Controls.Add(Me.cmdAbout)
        Me.GroupBox1.Controls.Add(Me.cmdClientSett)
        Me.GroupBox1.Controls.Add(Me.cmdSniperSett)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 447)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(554, 46)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Client and server settings"
        '
        'cmdHelp
        '
        Me.cmdHelp.Location = New System.Drawing.Point(428, 17)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(120, 23)
        Me.cmdHelp.TabIndex = 9
        Me.cmdHelp.Text = "Help"
        Me.cmdHelp.UseVisualStyleBackColor = True
        '
        'cmdAbout
        '
        Me.cmdAbout.Location = New System.Drawing.Point(258, 17)
        Me.cmdAbout.Name = "cmdAbout"
        Me.cmdAbout.Size = New System.Drawing.Size(120, 23)
        Me.cmdAbout.TabIndex = 8
        Me.cmdAbout.Text = "About"
        Me.cmdAbout.UseVisualStyleBackColor = True
        '
        'cmdClientSett
        '
        Me.cmdClientSett.Location = New System.Drawing.Point(132, 17)
        Me.cmdClientSett.Name = "cmdClientSett"
        Me.cmdClientSett.Size = New System.Drawing.Size(120, 23)
        Me.cmdClientSett.TabIndex = 7
        Me.cmdClientSett.Text = "Client editor"
        Me.cmdClientSett.UseVisualStyleBackColor = True
        '
        'cmdSniperSett
        '
        Me.cmdSniperSett.Location = New System.Drawing.Point(6, 17)
        Me.cmdSniperSett.Name = "cmdSniperSett"
        Me.cmdSniperSett.Size = New System.Drawing.Size(120, 23)
        Me.cmdSniperSett.TabIndex = 6
        Me.cmdSniperSett.Text = "Sniper settings"
        Me.cmdSniperSett.UseVisualStyleBackColor = True
        '
        'mstr
        '
        Me.mstr.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.mstr.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SniperMainToolStripMenuItem})
        Me.mstr.Location = New System.Drawing.Point(0, 0)
        Me.mstr.Name = "mstr"
        Me.mstr.Size = New System.Drawing.Size(565, 24)
        Me.mstr.TabIndex = 7
        '
        'SniperMainToolStripMenuItem
        '
        Me.SniperMainToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TopMostFormToolStripMenuItem, Me.HelpToolStripMenuItem, Me.SaveIPListToolStripMenuItem, Me.RecentConnectionsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.SniperMainToolStripMenuItem.Name = "SniperMainToolStripMenuItem"
        Me.SniperMainToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.SniperMainToolStripMenuItem.Text = "Sniper main"
        '
        'TopMostFormToolStripMenuItem
        '
        Me.TopMostFormToolStripMenuItem.Image = CType(resources.GetObject("TopMostFormToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TopMostFormToolStripMenuItem.Name = "TopMostFormToolStripMenuItem"
        Me.TopMostFormToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.TopMostFormToolStripMenuItem.Text = "Top most form"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Image = CType(resources.GetObject("HelpToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'SaveIPListToolStripMenuItem
        '
        Me.SaveIPListToolStripMenuItem.Image = CType(resources.GetObject("SaveIPListToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveIPListToolStripMenuItem.Name = "SaveIPListToolStripMenuItem"
        Me.SaveIPListToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.SaveIPListToolStripMenuItem.Text = "Save IP List"
        '
        'RecentConnectionsToolStripMenuItem
        '
        Me.RecentConnectionsToolStripMenuItem.Image = CType(resources.GetObject("RecentConnectionsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RecentConnectionsToolStripMenuItem.Name = "RecentConnectionsToolStripMenuItem"
        Me.RecentConnectionsToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.RecentConnectionsToolStripMenuItem.Text = "Recent connections"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.Sniper.My.Resources.Resources._1296671525_exit
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'lblCC
        '
        Me.lblCC.AutoSize = True
        Me.lblCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCC.Location = New System.Drawing.Point(92, 61)
        Me.lblCC.Name = "lblCC"
        Me.lblCC.Size = New System.Drawing.Size(133, 13)
        Me.lblCC.TabIndex = 8
        Me.lblCC.Text = "Connected Client(s): 0"
        '
        'lblSC
        '
        Me.lblSC.AutoSize = True
        Me.lblSC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSC.Location = New System.Drawing.Point(293, 61)
        Me.lblSC.Name = "lblSC"
        Me.lblSC.Size = New System.Drawing.Size(131, 13)
        Me.lblSC.TabIndex = 9
        Me.lblSC.Text = "Selected Client: None"
        '
        'lblBan
        '
        Me.lblBan.AutoSize = True
        Me.lblBan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBan.ForeColor = System.Drawing.Color.Red
        Me.lblBan.Location = New System.Drawing.Point(12, 30)
        Me.lblBan.Name = "lblBan"
        Me.lblBan.Size = New System.Drawing.Size(360, 20)
        Me.lblBan.TabIndex = 10
        Me.lblBan.Text = "Sniper Remote Administration And Spy Tool"
        '
        'cmdFuckNoIp
        '
        Me.cmdFuckNoIp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdFuckNoIp.Location = New System.Drawing.Point(13, 61)
        Me.cmdFuckNoIp.Name = "cmdFuckNoIp"
        Me.cmdFuckNoIp.Size = New System.Drawing.Size(73, 39)
        Me.cmdFuckNoIp.TabIndex = 11
        Me.cmdFuckNoIp.Text = "Fuck No-Ip Mode"
        Me.cmdFuckNoIp.UseVisualStyleBackColor = True
        '
        'tmrPen
        '
        Me.tmrPen.Interval = 1
        '
        'tmrDati
        '
        Me.tmrDati.Interval = 1
        '
        'cxmsrToolBox
        '
        Me.cxmsrToolBox.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Settings, Me.ComputerToolStripMenuItem, Me.TakeNotesToolStripMenuItem, Me.PortToolStripMenuItem, Me.ToolStripSeparator1, Me.UninstalClientToolStripMenuItem})
        Me.cxmsrToolBox.Name = "cxmsrToolBox"
        Me.cxmsrToolBox.Size = New System.Drawing.Size(177, 120)
        '
        'Settings
        '
        Me.Settings.Image = Global.Sniper.My.Resources.Resources._1296499042_Control_Panel
        Me.Settings.Name = "Settings"
        Me.Settings.Size = New System.Drawing.Size(176, 22)
        Me.Settings.Text = "Open control panel"
        '
        'ComputerToolStripMenuItem
        '
        Me.ComputerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SystemToolStripMenuItem, Me.GetInfosToolStripMenuItem})
        Me.ComputerToolStripMenuItem.Image = Global.Sniper.My.Resources.Resources._1296499123_mycomputer
        Me.ComputerToolStripMenuItem.Name = "ComputerToolStripMenuItem"
        Me.ComputerToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ComputerToolStripMenuItem.Text = "Computer"
        '
        'SystemToolStripMenuItem
        '
        Me.SystemToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShutdownToolStripMenuItem, Me.RestartToolStripMenuItem, Me.LogOffToolStripMenuItem})
        Me.SystemToolStripMenuItem.Image = Global.Sniper.My.Resources.Resources._1296499257_application_x_desktop
        Me.SystemToolStripMenuItem.Name = "SystemToolStripMenuItem"
        Me.SystemToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.SystemToolStripMenuItem.Text = "System"
        '
        'ShutdownToolStripMenuItem
        '
        Me.ShutdownToolStripMenuItem.Image = Global.Sniper.My.Resources.Resources._1296499311_exit
        Me.ShutdownToolStripMenuItem.Name = "ShutdownToolStripMenuItem"
        Me.ShutdownToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.ShutdownToolStripMenuItem.Text = "Shutdown"
        '
        'RestartToolStripMenuItem
        '
        Me.RestartToolStripMenuItem.Image = Global.Sniper.My.Resources.Resources._1296499332_button_blue_repeat
        Me.RestartToolStripMenuItem.Name = "RestartToolStripMenuItem"
        Me.RestartToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.RestartToolStripMenuItem.Text = "Restart"
        '
        'LogOffToolStripMenuItem
        '
        Me.LogOffToolStripMenuItem.Image = Global.Sniper.My.Resources.Resources._1296499354_Windows_Log_Off
        Me.LogOffToolStripMenuItem.Name = "LogOffToolStripMenuItem"
        Me.LogOffToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.LogOffToolStripMenuItem.Text = "Log-Off"
        '
        'GetInfosToolStripMenuItem
        '
        Me.GetInfosToolStripMenuItem.Image = Global.Sniper.My.Resources.Resources._1296499579_info
        Me.GetInfosToolStripMenuItem.Name = "GetInfosToolStripMenuItem"
        Me.GetInfosToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.GetInfosToolStripMenuItem.Text = "Get infos"
        '
        'TakeNotesToolStripMenuItem
        '
        Me.TakeNotesToolStripMenuItem.Image = Global.Sniper.My.Resources.Resources._1300126724_notebook_boy
        Me.TakeNotesToolStripMenuItem.Name = "TakeNotesToolStripMenuItem"
        Me.TakeNotesToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.TakeNotesToolStripMenuItem.Text = "Take notes"
        '
        'PortToolStripMenuItem
        '
        Me.PortToolStripMenuItem.Image = Global.Sniper.My.Resources.Resources._1307457878_tester
        Me.PortToolStripMenuItem.Name = "PortToolStripMenuItem"
        Me.PortToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.PortToolStripMenuItem.Text = "Port mapper"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(173, 6)
        '
        'UninstalClientToolStripMenuItem
        '
        Me.UninstalClientToolStripMenuItem.Image = Global.Sniper.My.Resources.Resources._1308057262_monotone_arrow_right
        Me.UninstalClientToolStripMenuItem.Name = "UninstalClientToolStripMenuItem"
        Me.UninstalClientToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.UninstalClientToolStripMenuItem.Text = "Uninstall client"
        '
        'nudLimCl
        '
        Me.nudLimCl.Location = New System.Drawing.Point(441, 33)
        Me.nudLimCl.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.nudLimCl.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudLimCl.Name = "nudLimCl"
        Me.nudLimCl.Size = New System.Drawing.Size(78, 20)
        Me.nudLimCl.TabIndex = 14
        Me.nudLimCl.Value = New Decimal(New Integer() {200, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(383, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Limit to:"
        '
        'cmdSetLimit
        '
        Me.cmdSetLimit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSetLimit.Location = New System.Drawing.Point(525, 30)
        Me.cmdSetLimit.Name = "cmdSetLimit"
        Me.cmdSetLimit.Size = New System.Drawing.Size(34, 23)
        Me.cmdSetLimit.TabIndex = 16
        Me.cmdSetLimit.Text = "Set"
        Me.cmdSetLimit.UseVisualStyleBackColor = True
        '
        'imlstIP
        '
        Me.imlstIP.ImageStream = CType(resources.GetObject("imlstIP.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlstIP.TransparentColor = System.Drawing.Color.Transparent
        Me.imlstIP.Images.SetKeyName(0, "1296848089_Italy-Flag.png")
        Me.imlstIP.Images.SetKeyName(1, "1296499257_application-x-desktop.ico")
        Me.imlstIP.Images.SetKeyName(2, "1296996380_window_new.ico")
        Me.imlstIP.Images.SetKeyName(3, "1298582808_cd_driver.png")
        Me.imlstIP.Images.SetKeyName(4, "1298662878_Folder.png")
        Me.imlstIP.Images.SetKeyName(5, "1298663150_document_pencil.png")
        Me.imlstIP.Images.SetKeyName(6, "1299786608_10.png")
        Me.imlstIP.Images.SetKeyName(7, "1299786658_parcel.png")
        Me.imlstIP.Images.SetKeyName(8, "1300106922_close.png")
        Me.imlstIP.Images.SetKeyName(9, "1306590392_edit.ico")
        Me.imlstIP.Images.SetKeyName(10, "1307361859_Folder-2.ico")
        Me.imlstIP.Images.SetKeyName(11, "1308221452_system-help.png")
        '
        'bkwIp
        '
        '
        'picFulmine
        '
        Me.picFulmine.Image = CType(resources.GetObject("picFulmine.Image"), System.Drawing.Image)
        Me.picFulmine.Location = New System.Drawing.Point(525, 53)
        Me.picFulmine.Name = "picFulmine"
        Me.picFulmine.Size = New System.Drawing.Size(34, 23)
        Me.picFulmine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFulmine.TabIndex = 13
        Me.picFulmine.TabStop = False
        '
        'bkwFNI
        '
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 498)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nudLimCl)
        Me.Controls.Add(Me.cmdSetLimit)
        Me.Controls.Add(Me.picFulmine)
        Me.Controls.Add(Me.cmdFuckNoIp)
        Me.Controls.Add(Me.lblSC)
        Me.Controls.Add(Me.lblBan)
        Me.Controls.Add(Me.lblCC)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpRac)
        Me.Controls.Add(Me.lstwIpReverse)
        Me.Controls.Add(Me.mstr)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mstr
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sniper Remote Administration Tool"
        Me.grpRac.ResumeLayout(False)
        CType(Me.picBoxStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPorta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.mstr.ResumeLayout(False)
        Me.mstr.PerformLayout()
        Me.cxmsrToolBox.ResumeLayout(False)
        CType(Me.nudLimCl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFulmine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstwIpReverse As System.Windows.Forms.ListView
    Friend WithEvents grpRac As System.Windows.Forms.GroupBox
    Friend WithEvents cmdChiuSock As System.Windows.Forms.Button
    Friend WithEvents nudPorta As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmdAttivaP As System.Windows.Forms.Button
    Friend WithEvents cmdUn As System.Windows.Forms.Button
    Friend WithEvents cmdClo As System.Windows.Forms.Button
    Friend WithEvents cmdRes As System.Windows.Forms.Button
    Friend WithEvents picBoxStart As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdHelp As System.Windows.Forms.Button
    Friend WithEvents cmdAbout As System.Windows.Forms.Button
    Friend WithEvents cmdClientSett As System.Windows.Forms.Button
    Friend WithEvents cmdSniperSett As System.Windows.Forms.Button
    Friend WithEvents mstr As System.Windows.Forms.MenuStrip
    Friend WithEvents SniperMainToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TopMostFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveIPListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecentConnectionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblCC As System.Windows.Forms.Label
    Friend WithEvents lblSC As System.Windows.Forms.Label
    Friend WithEvents lblBan As System.Windows.Forms.Label
    Friend WithEvents cmdFuckNoIp As System.Windows.Forms.Button
    Friend WithEvents picFulmine As System.Windows.Forms.PictureBox
    Friend WithEvents tmrPen As System.Windows.Forms.Timer
    Friend WithEvents tmrDati As System.Windows.Forms.Timer
    Friend WithEvents cxmsrToolBox As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Settings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComputerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SystemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShutdownToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GetInfosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents nudLimCl As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdSetLimit As System.Windows.Forms.Button
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents imlstIP As System.Windows.Forms.ImageList
    Friend WithEvents TakeNotesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PortToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bkwIp As System.ComponentModel.BackgroundWorker
    Friend WithEvents cmdPChkOp As System.Windows.Forms.Button
    Friend WithEvents bkwFNI As System.ComponentModel.BackgroundWorker
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UninstalClientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
