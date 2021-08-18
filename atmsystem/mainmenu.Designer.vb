<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainmenu
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btntra = New System.Windows.Forms.Button()
        Me.btndep = New System.Windows.Forms.Button()
        Me.btnwith = New System.Windows.Forms.Button()
        Me.btnbal = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblaccno = New System.Windows.Forms.Label()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.lblname = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btntra)
        Me.GroupBox1.Controls.Add(Me.btndep)
        Me.GroupBox1.Controls.Add(Me.btnwith)
        Me.GroupBox1.Controls.Add(Me.btnbal)
        Me.GroupBox1.Location = New System.Drawing.Point(139, 302)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(536, 252)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transaction"
        '
        'btntra
        '
        Me.btntra.BackColor = System.Drawing.Color.Silver
        Me.btntra.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntra.Location = New System.Drawing.Point(320, 159)
        Me.btntra.Margin = New System.Windows.Forms.Padding(4)
        Me.btntra.Name = "btntra"
        Me.btntra.Size = New System.Drawing.Size(177, 71)
        Me.btntra.TabIndex = 12
        Me.btntra.Text = "Change Pin"
        Me.btntra.UseVisualStyleBackColor = False
        '
        'btndep
        '
        Me.btndep.BackColor = System.Drawing.Color.Silver
        Me.btndep.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndep.Location = New System.Drawing.Point(320, 37)
        Me.btndep.Margin = New System.Windows.Forms.Padding(4)
        Me.btndep.Name = "btndep"
        Me.btndep.Size = New System.Drawing.Size(177, 71)
        Me.btndep.TabIndex = 2
        Me.btndep.Text = "Deposit"
        Me.btndep.UseVisualStyleBackColor = False
        '
        'btnwith
        '
        Me.btnwith.BackColor = System.Drawing.Color.Silver
        Me.btnwith.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnwith.Location = New System.Drawing.Point(35, 159)
        Me.btnwith.Margin = New System.Windows.Forms.Padding(4)
        Me.btnwith.Name = "btnwith"
        Me.btnwith.Size = New System.Drawing.Size(177, 71)
        Me.btnwith.TabIndex = 1
        Me.btnwith.Text = "Withdraw"
        Me.btnwith.UseVisualStyleBackColor = False
        '
        'btnbal
        '
        Me.btnbal.BackColor = System.Drawing.Color.Silver
        Me.btnbal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbal.Location = New System.Drawing.Point(35, 37)
        Me.btnbal.Margin = New System.Windows.Forms.Padding(4)
        Me.btnbal.Name = "btnbal"
        Me.btnbal.Size = New System.Drawing.Size(177, 71)
        Me.btnbal.TabIndex = 0
        Me.btnbal.Text = "Balance Inq."
        Me.btnbal.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(134, 193)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 25)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Account No.:"
        '
        'lblaccno
        '
        Me.lblaccno.AutoSize = True
        Me.lblaccno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblaccno.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblaccno.Location = New System.Drawing.Point(311, 194)
        Me.lblaccno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblaccno.Name = "lblaccno"
        Me.lblaccno.Size = New System.Drawing.Size(51, 24)
        Me.lblaccno.TabIndex = 12
        Me.lblaccno.Text = "num"
        '
        'btnlogout
        '
        Me.btnlogout.BackColor = System.Drawing.Color.Silver
        Me.btnlogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogout.Location = New System.Drawing.Point(459, 194)
        Me.btnlogout.Margin = New System.Windows.Forms.Padding(4)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(177, 33)
        Me.btnlogout.TabIndex = 13
        Me.btnlogout.Text = "Logout"
        Me.btnlogout.UseVisualStyleBackColor = False
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblname.Location = New System.Drawing.Point(289, 110)
        Me.lblname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(62, 24)
        Me.lblname.TabIndex = 14
        Me.lblname.Text = "name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(134, 110)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 25)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Hello!! "
        '
        'mainmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 651)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.btnlogout)
        Me.Controls.Add(Me.lblaccno)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "mainmenu"
        Me.Text = "mainmenu"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btntra As System.Windows.Forms.Button
    Friend WithEvents btndep As System.Windows.Forms.Button
    Friend WithEvents btnwith As System.Windows.Forms.Button
    Friend WithEvents btnbal As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnlogout As System.Windows.Forms.Button
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents lblaccno As System.Windows.Forms.Label
End Class
