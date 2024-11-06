<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main_page
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
        Me.lblappform = New System.Windows.Forms.Label()
        Me.rdobda = New System.Windows.Forms.RadioButton()
        Me.btngo = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.rdogsa = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblappform
        '
        Me.lblappform.AutoSize = True
        Me.lblappform.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lblappform.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblappform.Location = New System.Drawing.Point(67, 42)
        Me.lblappform.Name = "lblappform"
        Me.lblappform.Size = New System.Drawing.Size(133, 17)
        Me.lblappform.TabIndex = 0
        Me.lblappform.Text = "Application Form"
        '
        'rdobda
        '
        Me.rdobda.AutoSize = True
        Me.rdobda.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdobda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdobda.Location = New System.Drawing.Point(6, 65)
        Me.rdobda.Name = "rdobda"
        Me.rdobda.Size = New System.Drawing.Size(142, 19)
        Me.rdobda.TabIndex = 2
        Me.rdobda.TabStop = True
        Me.rdobda.Text = "To BasicDrawing App"
        Me.rdobda.UseVisualStyleBackColor = False
        '
        'btngo
        '
        Me.btngo.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btngo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngo.ForeColor = System.Drawing.Color.Black
        Me.btngo.Location = New System.Drawing.Point(34, 225)
        Me.btngo.Name = "btngo"
        Me.btngo.Size = New System.Drawing.Size(75, 23)
        Me.btngo.TabIndex = 3
        Me.btngo.Text = "Go"
        Me.btngo.UseVisualStyleBackColor = False
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(160, 225)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 23)
        Me.btnexit.TabIndex = 4
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'rdogsa
        '
        Me.rdogsa.AutoSize = True
        Me.rdogsa.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdogsa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdogsa.Location = New System.Drawing.Point(6, 30)
        Me.rdogsa.Name = "rdogsa"
        Me.rdogsa.Size = New System.Drawing.Size(142, 19)
        Me.rdogsa.TabIndex = 1
        Me.rdogsa.TabStop = True
        Me.rdogsa.Text = "To GradeSumary App"
        Me.rdogsa.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdogsa)
        Me.GroupBox1.Controls.Add(Me.rdobda)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'main_page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(268, 286)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btngo)
        Me.Controls.Add(Me.lblappform)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "main_page"
        Me.Text = "main_page"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblappform As System.Windows.Forms.Label
    Friend WithEvents rdobda As System.Windows.Forms.RadioButton
    Friend WithEvents btngo As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents rdogsa As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

End Class
