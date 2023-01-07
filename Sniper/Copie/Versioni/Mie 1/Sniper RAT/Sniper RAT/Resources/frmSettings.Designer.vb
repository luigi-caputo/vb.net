<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.chkSound = New System.Windows.Forms.CheckBox()
        Me.cmdDone = New System.Windows.Forms.Button()
        Me.grpFuck = New System.Windows.Forms.GroupBox()
        Me.lblFTP1 = New System.Windows.Forms.Label()
        Me.txtFTPURL = New System.Windows.Forms.TextBox()
        Me.txtFTPUs = New System.Windows.Forms.TextBox()
        Me.lblFTP2 = New System.Windows.Forms.Label()
        Me.txtFTPP = New System.Windows.Forms.TextBox()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.grpFuck.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkSound
        '
        Me.chkSound.AutoSize = True
        Me.chkSound.Location = New System.Drawing.Point(12, 12)
        Me.chkSound.Name = "chkSound"
        Me.chkSound.Size = New System.Drawing.Size(145, 17)
        Me.chkSound.TabIndex = 0
        Me.chkSound.Text = "Enable sound notification"
        Me.chkSound.UseVisualStyleBackColor = True
        '
        'cmdDone
        '
        Me.cmdDone.Image = Global.Sniper.My.Resources.Resources._1303247350_tick_circle
        Me.cmdDone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDone.Location = New System.Drawing.Point(12, 167)
        Me.cmdDone.Name = "cmdDone"
        Me.cmdDone.Size = New System.Drawing.Size(88, 25)
        Me.cmdDone.TabIndex = 1
        Me.cmdDone.Text = "Done"
        Me.cmdDone.UseVisualStyleBackColor = True
        '
        'grpFuck
        '
        Me.grpFuck.Controls.Add(Me.txtFTPP)
        Me.grpFuck.Controls.Add(Me.lblPass)
        Me.grpFuck.Controls.Add(Me.txtFTPUs)
        Me.grpFuck.Controls.Add(Me.lblFTP2)
        Me.grpFuck.Controls.Add(Me.txtFTPURL)
        Me.grpFuck.Controls.Add(Me.lblFTP1)
        Me.grpFuck.Location = New System.Drawing.Point(12, 35)
        Me.grpFuck.Name = "grpFuck"
        Me.grpFuck.Size = New System.Drawing.Size(225, 126)
        Me.grpFuck.TabIndex = 2
        Me.grpFuck.TabStop = False
        Me.grpFuck.Text = "Fuck No-Ip Settings"
        '
        'lblFTP1
        '
        Me.lblFTP1.AutoSize = True
        Me.lblFTP1.Location = New System.Drawing.Point(6, 25)
        Me.lblFTP1.Name = "lblFTP1"
        Me.lblFTP1.Size = New System.Drawing.Size(55, 13)
        Me.lblFTP1.TabIndex = 0
        Me.lblFTP1.Text = "FTP URL:"
        '
        'txtFTPURL
        '
        Me.txtFTPURL.Location = New System.Drawing.Point(67, 22)
        Me.txtFTPURL.Name = "txtFTPURL"
        Me.txtFTPURL.Size = New System.Drawing.Size(152, 20)
        Me.txtFTPURL.TabIndex = 1
        '
        'txtFTPUs
        '
        Me.txtFTPUs.Location = New System.Drawing.Point(67, 50)
        Me.txtFTPUs.Name = "txtFTPUs"
        Me.txtFTPUs.Size = New System.Drawing.Size(152, 20)
        Me.txtFTPUs.TabIndex = 3
        '
        'lblFTP2
        '
        Me.lblFTP2.AutoSize = True
        Me.lblFTP2.Location = New System.Drawing.Point(6, 53)
        Me.lblFTP2.Name = "lblFTP2"
        Me.lblFTP2.Size = New System.Drawing.Size(55, 13)
        Me.lblFTP2.TabIndex = 2
        Me.lblFTP2.Text = "FTP User:"
        '
        'txtFTPP
        '
        Me.txtFTPP.Location = New System.Drawing.Point(9, 95)
        Me.txtFTPP.Name = "txtFTPP"
        Me.txtFTPP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtFTPP.Size = New System.Drawing.Size(210, 20)
        Me.txtFTPP.TabIndex = 5
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(6, 79)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(79, 13)
        Me.lblPass.TabIndex = 4
        Me.lblPass.Text = "FTP Password:"
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(251, 204)
        Me.Controls.Add(Me.grpFuck)
        Me.Controls.Add(Me.cmdDone)
        Me.Controls.Add(Me.chkSound)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sniper Settings"
        Me.grpFuck.ResumeLayout(False)
        Me.grpFuck.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkSound As System.Windows.Forms.CheckBox
    Friend WithEvents cmdDone As System.Windows.Forms.Button
    Friend WithEvents grpFuck As System.Windows.Forms.GroupBox
    Friend WithEvents txtFTPP As System.Windows.Forms.TextBox
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents txtFTPUs As System.Windows.Forms.TextBox
    Friend WithEvents lblFTP2 As System.Windows.Forms.Label
    Friend WithEvents txtFTPURL As System.Windows.Forms.TextBox
    Friend WithEvents lblFTP1 As System.Windows.Forms.Label
End Class
