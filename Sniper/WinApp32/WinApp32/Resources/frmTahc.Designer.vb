<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTahc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTahc))
        Me.txtChatR = New System.Windows.Forms.TextBox()
        Me.txtScrR = New System.Windows.Forms.TextBox()
        Me.cmdSendMR = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtChatR
        '
        Me.txtChatR.BackColor = System.Drawing.Color.White
        Me.txtChatR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChatR.Location = New System.Drawing.Point(13, 13)
        Me.txtChatR.Multiline = True
        Me.txtChatR.Name = "txtChatR"
        Me.txtChatR.ReadOnly = True
        Me.txtChatR.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtChatR.Size = New System.Drawing.Size(342, 247)
        Me.txtChatR.TabIndex = 0
        '
        'txtScrR
        '
        Me.txtScrR.Location = New System.Drawing.Point(13, 266)
        Me.txtScrR.Multiline = True
        Me.txtScrR.Name = "txtScrR"
        Me.txtScrR.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtScrR.Size = New System.Drawing.Size(264, 51)
        Me.txtScrR.TabIndex = 1
        '
        'cmdSendMR
        '
        Me.cmdSendMR.Location = New System.Drawing.Point(284, 266)
        Me.cmdSendMR.Name = "cmdSendMR"
        Me.cmdSendMR.Size = New System.Drawing.Size(71, 51)
        Me.cmdSendMR.TabIndex = 2
        Me.cmdSendMR.Text = "SEND"
        Me.cmdSendMR.UseVisualStyleBackColor = True
        '
        'frmTahc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(367, 329)
        Me.Controls.Add(Me.cmdSendMR)
        Me.Controls.Add(Me.txtScrR)
        Me.Controls.Add(Me.txtChatR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTahc"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTahc"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtScrR As System.Windows.Forms.TextBox
    Friend WithEvents cmdSendMR As System.Windows.Forms.Button
    Friend WithEvents txtChatR As System.Windows.Forms.TextBox
End Class
