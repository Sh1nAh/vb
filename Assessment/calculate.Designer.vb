<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class calculate
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
        Me.lblcform = New System.Windows.Forms.Label()
        Me.lblnmark = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.lblavg = New System.Windows.Forms.Label()
        Me.lblhighest = New System.Windows.Forms.Label()
        Me.lbllowest = New System.Windows.Forms.Label()
        Me.txtnmark = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txtavg = New System.Windows.Forms.TextBox()
        Me.txthighest = New System.Windows.Forms.TextBox()
        Me.txtlowest = New System.Windows.Forms.TextBox()
        Me.btnbtmain = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblcform
        '
        Me.lblcform.AutoSize = True
        Me.lblcform.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lblcform.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcform.Location = New System.Drawing.Point(77, 20)
        Me.lblcform.Name = "lblcform"
        Me.lblcform.Size = New System.Drawing.Size(116, 17)
        Me.lblcform.TabIndex = 0
        Me.lblcform.Text = "Calculate Form"
        '
        'lblnmark
        '
        Me.lblnmark.AutoSize = True
        Me.lblnmark.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnmark.Location = New System.Drawing.Point(22, 66)
        Me.lblnmark.Name = "lblnmark"
        Me.lblnmark.Size = New System.Drawing.Size(65, 15)
        Me.lblnmark.TabIndex = 1
        Me.lblnmark.Text = "Num Mark"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(22, 112)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(34, 15)
        Me.lbltotal.TabIndex = 2
        Me.lbltotal.Text = "Total"
        '
        'lblavg
        '
        Me.lblavg.AutoSize = True
        Me.lblavg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblavg.Location = New System.Drawing.Point(22, 156)
        Me.lblavg.Name = "lblavg"
        Me.lblavg.Size = New System.Drawing.Size(26, 15)
        Me.lblavg.TabIndex = 3
        Me.lblavg.Text = "Avg"
        '
        'lblhighest
        '
        Me.lblhighest.AutoSize = True
        Me.lblhighest.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhighest.Location = New System.Drawing.Point(22, 209)
        Me.lblhighest.Name = "lblhighest"
        Me.lblhighest.Size = New System.Drawing.Size(49, 15)
        Me.lblhighest.TabIndex = 4
        Me.lblhighest.Text = "Highest"
        '
        'lbllowest
        '
        Me.lbllowest.AutoSize = True
        Me.lbllowest.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllowest.Location = New System.Drawing.Point(22, 263)
        Me.lbllowest.Name = "lbllowest"
        Me.lbllowest.Size = New System.Drawing.Size(46, 15)
        Me.lbllowest.TabIndex = 5
        Me.lbllowest.Text = "Lowest"
        '
        'txtnmark
        '
        Me.txtnmark.Location = New System.Drawing.Point(93, 65)
        Me.txtnmark.Name = "txtnmark"
        Me.txtnmark.Size = New System.Drawing.Size(100, 20)
        Me.txtnmark.TabIndex = 6
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(93, 109)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(100, 20)
        Me.txttotal.TabIndex = 7
        '
        'txtavg
        '
        Me.txtavg.Location = New System.Drawing.Point(93, 153)
        Me.txtavg.Name = "txtavg"
        Me.txtavg.Size = New System.Drawing.Size(100, 20)
        Me.txtavg.TabIndex = 8
        '
        'txthighest
        '
        Me.txthighest.Location = New System.Drawing.Point(93, 206)
        Me.txthighest.Name = "txthighest"
        Me.txthighest.Size = New System.Drawing.Size(100, 20)
        Me.txthighest.TabIndex = 9
        '
        'txtlowest
        '
        Me.txtlowest.Location = New System.Drawing.Point(93, 260)
        Me.txtlowest.Name = "txtlowest"
        Me.txtlowest.Size = New System.Drawing.Size(100, 20)
        Me.txtlowest.TabIndex = 10
        '
        'btnbtmain
        '
        Me.btnbtmain.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnbtmain.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbtmain.Location = New System.Drawing.Point(68, 318)
        Me.btnbtmain.Name = "btnbtmain"
        Me.btnbtmain.Size = New System.Drawing.Size(139, 23)
        Me.btnbtmain.TabIndex = 11
        Me.btnbtmain.Text = "Back To Main"
        Me.btnbtmain.UseVisualStyleBackColor = False
        '
        'calculate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(277, 392)
        Me.Controls.Add(Me.btnbtmain)
        Me.Controls.Add(Me.txtlowest)
        Me.Controls.Add(Me.txthighest)
        Me.Controls.Add(Me.txtavg)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtnmark)
        Me.Controls.Add(Me.lbllowest)
        Me.Controls.Add(Me.lblhighest)
        Me.Controls.Add(Me.lblavg)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.lblnmark)
        Me.Controls.Add(Me.lblcform)
        Me.Name = "calculate"
        Me.Text = "calculate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblcform As System.Windows.Forms.Label
    Friend WithEvents lblnmark As System.Windows.Forms.Label
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents lblavg As System.Windows.Forms.Label
    Friend WithEvents lblhighest As System.Windows.Forms.Label
    Friend WithEvents lbllowest As System.Windows.Forms.Label
    Friend WithEvents txtnmark As System.Windows.Forms.TextBox
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents txtavg As System.Windows.Forms.TextBox
    Friend WithEvents txthighest As System.Windows.Forms.TextBox
    Friend WithEvents txtlowest As System.Windows.Forms.TextBox
    Friend WithEvents btnbtmain As System.Windows.Forms.Button
End Class
