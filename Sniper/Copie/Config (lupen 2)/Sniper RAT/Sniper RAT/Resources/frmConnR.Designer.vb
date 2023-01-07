<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConnR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConnR))
        Me.txtRC = New System.Windows.Forms.TextBox()
        Me.cmdRefRec = New System.Windows.Forms.Button()
        Me.cmdCCRC = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtRC
        '
        Me.txtRC.BackColor = System.Drawing.Color.White
        Me.txtRC.Location = New System.Drawing.Point(13, 13)
        Me.txtRC.Multiline = True
        Me.txtRC.Name = "txtRC"
        Me.txtRC.ReadOnly = True
        Me.txtRC.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtRC.Size = New System.Drawing.Size(288, 191)
        Me.txtRC.TabIndex = 0
        '
        'cmdRefRec
        '
        Me.cmdRefRec.Location = New System.Drawing.Point(225, 204)
        Me.cmdRefRec.Name = "cmdRefRec"
        Me.cmdRefRec.Size = New System.Drawing.Size(75, 23)
        Me.cmdRefRec.TabIndex = 1
        Me.cmdRefRec.Text = "Refresh"
        Me.cmdRefRec.UseVisualStyleBackColor = True
        '
        'cmdCCRC
        '
        Me.cmdCCRC.Location = New System.Drawing.Point(13, 204)
        Me.cmdCCRC.Name = "cmdCCRC"
        Me.cmdCCRC.Size = New System.Drawing.Size(75, 23)
        Me.cmdCCRC.TabIndex = 2
        Me.cmdCCRC.Text = "Clear"
        Me.cmdCCRC.UseVisualStyleBackColor = True
        '
        'frmConnR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 231)
        Me.Controls.Add(Me.cmdCCRC)
        Me.Controls.Add(Me.cmdRefRec)
        Me.Controls.Add(Me.txtRC)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConnR"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recent connections"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtRC As System.Windows.Forms.TextBox
    Friend WithEvents cmdRefRec As System.Windows.Forms.Button
    Friend WithEvents cmdCCRC As System.Windows.Forms.Button
End Class
