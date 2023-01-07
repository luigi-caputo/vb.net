<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.lnshRiga = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lblTAB = New System.Windows.Forms.Label()
        Me.picA2 = New System.Windows.Forms.PictureBox()
        Me.picA1 = New System.Windows.Forms.PictureBox()
        Me.lblMInfo = New System.Windows.Forms.Label()
        Me.picA3 = New System.Windows.Forms.PictureBox()
        Me.picA4 = New System.Windows.Forms.PictureBox()
        CType(Me.picA2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picA1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picA3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picA4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.lnshRiga})
        Me.ShapeContainer1.Size = New System.Drawing.Size(376, 254)
        Me.ShapeContainer1.TabIndex = 3
        Me.ShapeContainer1.TabStop = False
        '
        'lnshRiga
        '
        Me.lnshRiga.Name = "lnshRiga"
        Me.lnshRiga.X1 = 318
        Me.lnshRiga.X2 = 56
        Me.lnshRiga.Y1 = 25
        Me.lnshRiga.Y2 = 25
        '
        'lblTAB
        '
        Me.lblTAB.AutoSize = True
        Me.lblTAB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTAB.ForeColor = System.Drawing.Color.Blue
        Me.lblTAB.Location = New System.Drawing.Point(49, 0)
        Me.lblTAB.Name = "lblTAB"
        Me.lblTAB.Size = New System.Drawing.Size(277, 25)
        Me.lblTAB.TabIndex = 4
        Me.lblTAB.Text = "Sniper RAT Info Software"
        '
        'picA2
        '
        Me.picA2.Image = Global.Sniper.My.Resources.Resources.mirino
        Me.picA2.Location = New System.Drawing.Point(332, 35)
        Me.picA2.Name = "picA2"
        Me.picA2.Size = New System.Drawing.Size(35, 37)
        Me.picA2.TabIndex = 5
        Me.picA2.TabStop = False
        '
        'picA1
        '
        Me.picA1.Image = Global.Sniper.My.Resources.Resources.mirino
        Me.picA1.Location = New System.Drawing.Point(13, 35)
        Me.picA1.Name = "picA1"
        Me.picA1.Size = New System.Drawing.Size(35, 37)
        Me.picA1.TabIndex = 6
        Me.picA1.TabStop = False
        '
        'lblMInfo
        '
        Me.lblMInfo.BackColor = System.Drawing.Color.Black
        Me.lblMInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMInfo.ForeColor = System.Drawing.Color.White
        Me.lblMInfo.Location = New System.Drawing.Point(54, 35)
        Me.lblMInfo.Name = "lblMInfo"
        Me.lblMInfo.Size = New System.Drawing.Size(272, 208)
        Me.lblMInfo.TabIndex = 7
        Me.lblMInfo.Text = resources.GetString("lblMInfo.Text")
        '
        'picA3
        '
        Me.picA3.Image = Global.Sniper.My.Resources.Resources.mirino
        Me.picA3.Location = New System.Drawing.Point(13, 206)
        Me.picA3.Name = "picA3"
        Me.picA3.Size = New System.Drawing.Size(35, 37)
        Me.picA3.TabIndex = 8
        Me.picA3.TabStop = False
        '
        'picA4
        '
        Me.picA4.Image = Global.Sniper.My.Resources.Resources.mirino
        Me.picA4.Location = New System.Drawing.Point(332, 206)
        Me.picA4.Name = "picA4"
        Me.picA4.Size = New System.Drawing.Size(35, 37)
        Me.picA4.TabIndex = 9
        Me.picA4.TabStop = False
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(376, 254)
        Me.Controls.Add(Me.picA4)
        Me.Controls.Add(Me.picA3)
        Me.Controls.Add(Me.lblMInfo)
        Me.Controls.Add(Me.picA1)
        Me.Controls.Add(Me.picA2)
        Me.Controls.Add(Me.lblTAB)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAbout"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Software info"
        Me.TransparencyKey = System.Drawing.Color.White
        CType(Me.picA2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picA1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picA3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picA4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents lnshRiga As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lblTAB As System.Windows.Forms.Label
    Friend WithEvents picA2 As System.Windows.Forms.PictureBox
    Friend WithEvents picA1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblMInfo As System.Windows.Forms.Label
    Friend WithEvents picA3 As System.Windows.Forms.PictureBox
    Friend WithEvents picA4 As System.Windows.Forms.PictureBox
End Class
