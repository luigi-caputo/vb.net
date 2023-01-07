<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmScreen))
        Me.prgImmR = New System.Windows.Forms.ProgressBar()
        Me.cxmstrScreen = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TakeShotToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopItToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoteControlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MouseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeyboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TakeOneFrameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetImageSizeAsFormSizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestoreOriginalImageSizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideRestoreProgressBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblCl = New System.Windows.Forms.Label()
        Me.lblIDC = New System.Windows.Forms.Label()
        Me.ToolStriptxtScrii = New System.Windows.Forms.TextBox()
        Me.picImm = New System.Windows.Forms.PictureBox()
        Me.cxmstrScreen.SuspendLayout()
        CType(Me.picImm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'prgImmR
        '
        Me.prgImmR.Location = New System.Drawing.Point(15, 519)
        Me.prgImmR.Name = "prgImmR"
        Me.prgImmR.Size = New System.Drawing.Size(481, 23)
        Me.prgImmR.TabIndex = 1
        '
        'cxmstrScreen
        '
        Me.cxmstrScreen.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TakeShotToolStripMenuItem, Me.StopItToolStripMenuItem, Me.RemoteControlToolStripMenuItem, Me.TakeOneFrameToolStripMenuItem, Me.SetImageSizeAsFormSizeToolStripMenuItem, Me.RestoreOriginalImageSizeToolStripMenuItem, Me.HideRestoreProgressBarToolStripMenuItem})
        Me.cxmstrScreen.Name = "cxmstrScreen"
        Me.cxmstrScreen.Size = New System.Drawing.Size(230, 158)
        '
        'TakeShotToolStripMenuItem
        '
        Me.TakeShotToolStripMenuItem.Image = Global.Sniper.My.Resources.Resources._1297459169_xine
        Me.TakeShotToolStripMenuItem.Name = "TakeShotToolStripMenuItem"
        Me.TakeShotToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.TakeShotToolStripMenuItem.Text = "Start screen capture"
        '
        'StopItToolStripMenuItem
        '
        Me.StopItToolStripMenuItem.Image = Global.Sniper.My.Resources.Resources._1297459224_Symbol_Stop
        Me.StopItToolStripMenuItem.Name = "StopItToolStripMenuItem"
        Me.StopItToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.StopItToolStripMenuItem.Text = "Stop it"
        '
        'RemoteControlToolStripMenuItem
        '
        Me.RemoteControlToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MouseToolStripMenuItem, Me.KeyboardToolStripMenuItem})
        Me.RemoteControlToolStripMenuItem.Image = Global.Sniper.My.Resources.Resources._1297459329_remote
        Me.RemoteControlToolStripMenuItem.Name = "RemoteControlToolStripMenuItem"
        Me.RemoteControlToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.RemoteControlToolStripMenuItem.Text = "Remote control"
        '
        'MouseToolStripMenuItem
        '
        Me.MouseToolStripMenuItem.CheckOnClick = True
        Me.MouseToolStripMenuItem.Name = "MouseToolStripMenuItem"
        Me.MouseToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.MouseToolStripMenuItem.Text = "Mouse"
        '
        'KeyboardToolStripMenuItem
        '
        Me.KeyboardToolStripMenuItem.CheckOnClick = True
        Me.KeyboardToolStripMenuItem.Name = "KeyboardToolStripMenuItem"
        Me.KeyboardToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.KeyboardToolStripMenuItem.Text = "Keyboard"
        '
        'TakeOneFrameToolStripMenuItem
        '
        Me.TakeOneFrameToolStripMenuItem.Image = Global.Sniper.My.Resources.Resources._1296847899_Connections
        Me.TakeOneFrameToolStripMenuItem.Name = "TakeOneFrameToolStripMenuItem"
        Me.TakeOneFrameToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.TakeOneFrameToolStripMenuItem.Text = "Take one frame"
        '
        'SetImageSizeAsFormSizeToolStripMenuItem
        '
        Me.SetImageSizeAsFormSizeToolStripMenuItem.Image = Global.Sniper.My.Resources.Resources._1298063917_resize_diag_2
        Me.SetImageSizeAsFormSizeToolStripMenuItem.Name = "SetImageSizeAsFormSizeToolStripMenuItem"
        Me.SetImageSizeAsFormSizeToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.SetImageSizeAsFormSizeToolStripMenuItem.Text = "Set image size as window size"
        '
        'RestoreOriginalImageSizeToolStripMenuItem
        '
        Me.RestoreOriginalImageSizeToolStripMenuItem.Image = Global.Sniper.My.Resources.Resources._1298063983_backup_restore
        Me.RestoreOriginalImageSizeToolStripMenuItem.Name = "RestoreOriginalImageSizeToolStripMenuItem"
        Me.RestoreOriginalImageSizeToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.RestoreOriginalImageSizeToolStripMenuItem.Text = "Restore original image size"
        '
        'HideRestoreProgressBarToolStripMenuItem
        '
        Me.HideRestoreProgressBarToolStripMenuItem.Image = Global.Sniper.My.Resources.Resources._1298149176_progressbar
        Me.HideRestoreProgressBarToolStripMenuItem.Name = "HideRestoreProgressBarToolStripMenuItem"
        Me.HideRestoreProgressBarToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.HideRestoreProgressBarToolStripMenuItem.Text = "Hide/Restore progress bar"
        '
        'lblCl
        '
        Me.lblCl.AutoSize = True
        Me.lblCl.BackColor = System.Drawing.Color.Transparent
        Me.lblCl.Location = New System.Drawing.Point(12, 7)
        Me.lblCl.Name = "lblCl"
        Me.lblCl.Size = New System.Drawing.Size(36, 13)
        Me.lblCl.TabIndex = 2
        Me.lblCl.Text = "Client:"
        '
        'lblIDC
        '
        Me.lblIDC.AutoSize = True
        Me.lblIDC.BackColor = System.Drawing.Color.Transparent
        Me.lblIDC.Location = New System.Drawing.Point(54, 7)
        Me.lblIDC.Name = "lblIDC"
        Me.lblIDC.Size = New System.Drawing.Size(13, 13)
        Me.lblIDC.TabIndex = 3
        Me.lblIDC.Text = "0"
        '
        'ToolStriptxtScrii
        '
        Me.ToolStriptxtScrii.Enabled = False
        Me.ToolStriptxtScrii.Location = New System.Drawing.Point(379, 4)
        Me.ToolStriptxtScrii.Name = "ToolStriptxtScrii"
        Me.ToolStriptxtScrii.Size = New System.Drawing.Size(117, 20)
        Me.ToolStriptxtScrii.TabIndex = 4
        '
        'picImm
        '
        Me.picImm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picImm.Location = New System.Drawing.Point(15, 23)
        Me.picImm.Name = "picImm"
        Me.picImm.Size = New System.Drawing.Size(481, 490)
        Me.picImm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picImm.TabIndex = 0
        Me.picImm.TabStop = False
        '
        'frmScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 550)
        Me.Controls.Add(Me.lblIDC)
        Me.Controls.Add(Me.ToolStriptxtScrii)
        Me.Controls.Add(Me.prgImmR)
        Me.Controls.Add(Me.lblCl)
        Me.Controls.Add(Me.picImm)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Screen viewer"
        Me.cxmstrScreen.ResumeLayout(False)
        CType(Me.picImm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picImm As System.Windows.Forms.PictureBox
    Friend WithEvents prgImmR As System.Windows.Forms.ProgressBar
    Friend WithEvents cxmstrScreen As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TakeShotToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopItToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoteControlToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MouseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeyboardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblCl As System.Windows.Forms.Label
    Friend WithEvents lblIDC As System.Windows.Forms.Label
    Friend WithEvents TakeOneFrameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetImageSizeAsFormSizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestoreOriginalImageSizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HideRestoreProgressBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStriptxtScrii As System.Windows.Forms.TextBox
End Class
