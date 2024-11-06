<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class freehand_drawing
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
        Me.picbox = New System.Windows.Forms.PictureBox()
        Me.cbosize = New System.Windows.Forms.ComboBox()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnbtmain = New System.Windows.Forms.Button()
        Me.gbpensize = New System.Windows.Forms.GroupBox()
        Me.btncolor = New System.Windows.Forms.Button()
        Me.rdoeraser = New System.Windows.Forms.RadioButton()
        Me.btnexit = New System.Windows.Forms.Button()
        CType(Me.picbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbpensize.SuspendLayout()
        Me.SuspendLayout()
        '
        'picbox
        '
        Me.picbox.BackColor = System.Drawing.SystemColors.Window
        Me.picbox.Location = New System.Drawing.Point(23, 107)
        Me.picbox.Name = "picbox"
        Me.picbox.Size = New System.Drawing.Size(516, 289)
        Me.picbox.TabIndex = 0
        Me.picbox.TabStop = False
        '
        'cbosize
        '
        Me.cbosize.BackColor = System.Drawing.SystemColors.Window
        Me.cbosize.FormattingEnabled = True
        Me.cbosize.Items.AddRange(New Object() {"5", "10", "15", "20", "25"})
        Me.cbosize.Location = New System.Drawing.Point(6, 19)
        Me.cbosize.Name = "cbosize"
        Me.cbosize.Size = New System.Drawing.Size(121, 21)
        Me.cbosize.TabIndex = 1
        Me.cbosize.Text = "Choose Size"
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Location = New System.Drawing.Point(75, 417)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(75, 23)
        Me.btnclear.TabIndex = 3
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'btnbtmain
        '
        Me.btnbtmain.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnbtmain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbtmain.Location = New System.Drawing.Point(233, 418)
        Me.btnbtmain.Name = "btnbtmain"
        Me.btnbtmain.Size = New System.Drawing.Size(95, 23)
        Me.btnbtmain.TabIndex = 4
        Me.btnbtmain.Text = "Back To Main"
        Me.btnbtmain.UseVisualStyleBackColor = False
        '
        'gbpensize
        '
        Me.gbpensize.Controls.Add(Me.cbosize)
        Me.gbpensize.Location = New System.Drawing.Point(23, 35)
        Me.gbpensize.Name = "gbpensize"
        Me.gbpensize.Size = New System.Drawing.Size(150, 50)
        Me.gbpensize.TabIndex = 5
        Me.gbpensize.TabStop = False
        Me.gbpensize.Text = "PenSize"
        '
        'btncolor
        '
        Me.btncolor.Location = New System.Drawing.Point(180, 51)
        Me.btncolor.Name = "btncolor"
        Me.btncolor.Size = New System.Drawing.Size(75, 23)
        Me.btncolor.TabIndex = 6
        Me.btncolor.Text = "Color"
        Me.btncolor.UseVisualStyleBackColor = True
        '
        'rdoeraser
        '
        Me.rdoeraser.AutoSize = True
        Me.rdoeraser.Location = New System.Drawing.Point(262, 54)
        Me.rdoeraser.Name = "rdoeraser"
        Me.rdoeraser.Size = New System.Drawing.Size(55, 17)
        Me.rdoeraser.TabIndex = 7
        Me.rdoeraser.TabStop = True
        Me.rdoeraser.Text = "Eraser"
        Me.rdoeraser.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(404, 418)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 23)
        Me.btnexit.TabIndex = 8
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'freehand_drawing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(565, 462)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.rdoeraser)
        Me.Controls.Add(Me.btncolor)
        Me.Controls.Add(Me.gbpensize)
        Me.Controls.Add(Me.btnbtmain)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.picbox)
        Me.Name = "freehand_drawing"
        Me.Text = "freehand_drawings"
        CType(Me.picbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbpensize.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picbox As System.Windows.Forms.PictureBox
    Friend WithEvents cbosize As System.Windows.Forms.ComboBox
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btnbtmain As System.Windows.Forms.Button
    Friend WithEvents gbpensize As System.Windows.Forms.GroupBox
    Friend WithEvents btncolor As System.Windows.Forms.Button
    Friend WithEvents rdoeraser As System.Windows.Forms.RadioButton
    Friend WithEvents btnexit As System.Windows.Forms.Button
End Class
