<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class entrada
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(entrada))
        Me.btnp = New System.Windows.Forms.Button()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.txt4 = New System.Windows.Forms.TextBox()
        Me.txt5 = New System.Windows.Forms.TextBox()
        Me.txt6 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnp
        '
        Me.btnp.BackColor = System.Drawing.Color.Gold
        Me.btnp.Font = New System.Drawing.Font("Franklin Gothic Medium", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnp.ForeColor = System.Drawing.Color.White
        Me.btnp.Location = New System.Drawing.Point(468, 579)
        Me.btnp.Name = "btnp"
        Me.btnp.Size = New System.Drawing.Size(262, 94)
        Me.btnp.TabIndex = 0
        Me.btnp.Text = "Jogar"
        Me.btnp.UseVisualStyleBackColor = False
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(89, 188)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(149, 22)
        Me.txt1.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(482, 190)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(0, 22)
        Me.TextBox3.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.No
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(450, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(324, 130)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Players"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(266, 188)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(149, 22)
        Me.txt2.TabIndex = 11
        '
        'txt3
        '
        Me.txt3.Location = New System.Drawing.Point(446, 188)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(149, 22)
        Me.txt3.TabIndex = 12
        '
        'txt4
        '
        Me.txt4.Location = New System.Drawing.Point(621, 188)
        Me.txt4.Name = "txt4"
        Me.txt4.Size = New System.Drawing.Size(149, 22)
        Me.txt4.TabIndex = 13
        '
        'txt5
        '
        Me.txt5.Location = New System.Drawing.Point(794, 188)
        Me.txt5.Name = "txt5"
        Me.txt5.Size = New System.Drawing.Size(149, 22)
        Me.txt5.TabIndex = 14
        '
        'txt6
        '
        Me.txt6.Location = New System.Drawing.Point(975, 188)
        Me.txt6.Name = "txt6"
        Me.txt6.Size = New System.Drawing.Size(149, 22)
        Me.txt6.TabIndex = 15
        '
        'entrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.tpt1.My.Resources.Resources.thumbnail_servlet
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1217, 727)
        Me.Controls.Add(Me.txt6)
        Me.Controls.Add(Me.txt5)
        Me.Controls.Add(Me.txt4)
        Me.Controls.Add(Me.txt3)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.btnp)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "entrada"
        Me.Text = "jogo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnp As Button
    Friend WithEvents txt1 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt2 As TextBox
    Friend WithEvents txt3 As TextBox
    Friend WithEvents txt4 As TextBox
    Friend WithEvents txt5 As TextBox
    Friend WithEvents txt6 As TextBox
End Class
