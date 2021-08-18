<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Change_Pin
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtoldpin = New System.Windows.Forms.TextBox()
        Me.txtnewpin = New System.Windows.Forms.TextBox()
        Me.txtcnew = New System.Windows.Forms.TextBox()
        Me.btnchange = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(104, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Old Pin :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(104, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "New Pin :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(77, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Confirm Pin :"
        '
        'txtoldpin
        '
        Me.txtoldpin.Location = New System.Drawing.Point(202, 99)
        Me.txtoldpin.Name = "txtoldpin"
        Me.txtoldpin.Size = New System.Drawing.Size(128, 22)
        Me.txtoldpin.TabIndex = 3
        '
        'txtnewpin
        '
        Me.txtnewpin.Location = New System.Drawing.Point(202, 147)
        Me.txtnewpin.Name = "txtnewpin"
        Me.txtnewpin.Size = New System.Drawing.Size(128, 22)
        Me.txtnewpin.TabIndex = 4
        '
        'txtcnew
        '
        Me.txtcnew.Location = New System.Drawing.Point(202, 204)
        Me.txtcnew.Name = "txtcnew"
        Me.txtcnew.Size = New System.Drawing.Size(128, 22)
        Me.txtcnew.TabIndex = 5
        '
        'btnchange
        '
        Me.btnchange.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnchange.Location = New System.Drawing.Point(107, 275)
        Me.btnchange.Name = "btnchange"
        Me.btnchange.Size = New System.Drawing.Size(113, 41)
        Me.btnchange.TabIndex = 6
        Me.btnchange.Text = "Change Pin"
        Me.btnchange.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(273, 275)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(83, 41)
        Me.btnclose.TabIndex = 7
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'Change_Pin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 378)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnchange)
        Me.Controls.Add(Me.txtcnew)
        Me.Controls.Add(Me.txtnewpin)
        Me.Controls.Add(Me.txtoldpin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Change_Pin"
        Me.Text = "Change_Pin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtoldpin As System.Windows.Forms.TextBox
    Friend WithEvents txtnewpin As System.Windows.Forms.TextBox
    Friend WithEvents txtcnew As System.Windows.Forms.TextBox
    Friend WithEvents btnchange As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
End Class
