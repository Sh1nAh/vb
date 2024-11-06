<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class summary
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
        Me.lblsform = New System.Windows.Forms.Label()
        Me.txtmark = New System.Windows.Forms.TextBox()
        Me.btnshow = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnbtmain = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblsform
        '
        Me.lblsform.AutoSize = True
        Me.lblsform.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lblsform.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsform.Location = New System.Drawing.Point(101, 30)
        Me.lblsform.Name = "lblsform"
        Me.lblsform.Size = New System.Drawing.Size(115, 17)
        Me.lblsform.TabIndex = 0
        Me.lblsform.Text = "Summary Form"
        '
        'txtmark
        '
        Me.txtmark.Location = New System.Drawing.Point(97, 84)
        Me.txtmark.Name = "txtmark"
        Me.txtmark.Size = New System.Drawing.Size(119, 20)
        Me.txtmark.TabIndex = 2
        '
        'btnshow
        '
        Me.btnshow.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnshow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshow.Location = New System.Drawing.Point(115, 154)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(75, 23)
        Me.btnshow.TabIndex = 3
        Me.btnshow.Text = "Show"
        Me.btnshow.UseVisualStyleBackColor = False
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Location = New System.Drawing.Point(210, 153)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(75, 23)
        Me.btnclear.TabIndex = 4
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'btnbtmain
        '
        Me.btnbtmain.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnbtmain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbtmain.Location = New System.Drawing.Point(97, 212)
        Me.btnbtmain.Name = "btnbtmain"
        Me.btnbtmain.Size = New System.Drawing.Size(119, 23)
        Me.btnbtmain.TabIndex = 5
        Me.btnbtmain.Text = "Back To Main"
        Me.btnbtmain.UseVisualStyleBackColor = False
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(21, 154)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 23)
        Me.btnadd.TabIndex = 6
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'summary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(309, 280)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.btnbtmain)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnshow)
        Me.Controls.Add(Me.txtmark)
        Me.Controls.Add(Me.lblsform)
        Me.Name = "summary"
        Me.Text = "summary"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblsform As System.Windows.Forms.Label
    Friend WithEvents txtmark As System.Windows.Forms.TextBox
    Friend WithEvents btnshow As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btnbtmain As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
End Class
