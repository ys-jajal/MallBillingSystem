<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduct
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
        Me.txtqnty = New System.Windows.Forms.TextBox
        Me.txtiprice = New System.Windows.Forms.TextBox
        Me.txtbrand = New System.Windows.Forms.TextBox
        Me.txtiname = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtino = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnpExit = New System.Windows.Forms.Button
        Me.btnpClear = New System.Windows.Forms.Button
        Me.btnpSave = New System.Windows.Forms.Button
        Me.btnpEdit = New System.Windows.Forms.Button
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtqnty
        '
        Me.txtqnty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtqnty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqnty.Location = New System.Drawing.Point(188, 222)
        Me.txtqnty.Name = "txtqnty"
        Me.txtqnty.Size = New System.Drawing.Size(337, 22)
        Me.txtqnty.TabIndex = 136
        '
        'txtiprice
        '
        Me.txtiprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtiprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtiprice.Location = New System.Drawing.Point(188, 188)
        Me.txtiprice.Name = "txtiprice"
        Me.txtiprice.Size = New System.Drawing.Size(337, 22)
        Me.txtiprice.TabIndex = 135
        '
        'txtbrand
        '
        Me.txtbrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbrand.Location = New System.Drawing.Point(188, 150)
        Me.txtbrand.Name = "txtbrand"
        Me.txtbrand.Size = New System.Drawing.Size(488, 22)
        Me.txtbrand.TabIndex = 134
        '
        'txtiname
        '
        Me.txtiname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtiname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtiname.Location = New System.Drawing.Point(187, 111)
        Me.txtiname.Name = "txtiname"
        Me.txtiname.Size = New System.Drawing.Size(488, 22)
        Me.txtiname.TabIndex = 133
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(69, 216)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 28)
        Me.Label15.TabIndex = 131
        Me.Label15.Text = "Quantity"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(58, 182)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(106, 28)
        Me.Label16.TabIndex = 130
        Me.Label16.Text = "Item Price"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(95, 145)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 28)
        Me.Label17.TabIndex = 129
        Me.Label17.Text = "Brand"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label18.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(47, 109)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(113, 28)
        Me.Label18.TabIndex = 128
        Me.Label18.Text = "Item Name"
        '
        'txtino
        '
        Me.txtino.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtino.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtino.Location = New System.Drawing.Point(188, 75)
        Me.txtino.Name = "txtino"
        Me.txtino.ReadOnly = True
        Me.txtino.Size = New System.Drawing.Size(133, 22)
        Me.txtino.TabIndex = 127
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label19.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(28, 69)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(133, 28)
        Me.Label19.TabIndex = 126
        Me.Label19.Text = "Item Number"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(244, 8)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(266, 42)
        Me.Label13.TabIndex = 125
        Me.Label13.Text = "Product Detail"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnpExit)
        Me.Panel2.Controls.Add(Me.btnpClear)
        Me.Panel2.Controls.Add(Me.btnpSave)
        Me.Panel2.Controls.Add(Me.btnpEdit)
        Me.Panel2.Location = New System.Drawing.Point(9, 307)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(745, 48)
        Me.Panel2.TabIndex = 138
        '
        'btnpExit
        '
        Me.btnpExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpExit.Location = New System.Drawing.Point(602, 3)
        Me.btnpExit.Name = "btnpExit"
        Me.btnpExit.Size = New System.Drawing.Size(122, 38)
        Me.btnpExit.TabIndex = 126
        Me.btnpExit.Text = "EXIT"
        Me.btnpExit.UseVisualStyleBackColor = True
        '
        'btnpClear
        '
        Me.btnpClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpClear.Location = New System.Drawing.Point(391, 3)
        Me.btnpClear.Name = "btnpClear"
        Me.btnpClear.Size = New System.Drawing.Size(124, 38)
        Me.btnpClear.TabIndex = 125
        Me.btnpClear.Text = "CLEAR"
        Me.btnpClear.UseVisualStyleBackColor = True
        '
        'btnpSave
        '
        Me.btnpSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpSave.Location = New System.Drawing.Point(9, 3)
        Me.btnpSave.Name = "btnpSave"
        Me.btnpSave.Size = New System.Drawing.Size(123, 38)
        Me.btnpSave.TabIndex = 124
        Me.btnpSave.Text = "SAVE"
        Me.btnpSave.UseVisualStyleBackColor = True
        '
        'btnpEdit
        '
        Me.btnpEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpEdit.Location = New System.Drawing.Point(187, 3)
        Me.btnpEdit.Name = "btnpEdit"
        Me.btnpEdit.Size = New System.Drawing.Size(124, 38)
        Me.btnpEdit.TabIndex = 123
        Me.btnpEdit.Text = "EDIT"
        Me.btnpEdit.UseVisualStyleBackColor = True
        '
        'frmProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(764, 389)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtqnty)
        Me.Controls.Add(Me.txtiprice)
        Me.Controls.Add(Me.txtbrand)
        Me.Controls.Add(Me.txtiname)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtino)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label13)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProduct"
        Me.Text = "frmProduct"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtqnty As System.Windows.Forms.TextBox
    Friend WithEvents txtiprice As System.Windows.Forms.TextBox
    Friend WithEvents txtbrand As System.Windows.Forms.TextBox
    Friend WithEvents txtiname As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtino As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnpExit As System.Windows.Forms.Button
    Friend WithEvents btnpClear As System.Windows.Forms.Button
    Friend WithEvents btnpSave As System.Windows.Forms.Button
    Friend WithEvents btnpEdit As System.Windows.Forms.Button
End Class
