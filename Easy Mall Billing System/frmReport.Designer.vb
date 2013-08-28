<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport
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
        Me.Button4 = New System.Windows.Forms.Button
        Me.btnSrchBill = New System.Windows.Forms.Button
        Me.btnsalesperday = New System.Windows.Forms.Button
        Me.btnallcust = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(376, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(42, 33)
        Me.Button4.TabIndex = 39
        Me.Button4.Text = "X"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnSrchBill
        '
        Me.btnSrchBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSrchBill.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSrchBill.Location = New System.Drawing.Point(83, 188)
        Me.btnSrchBill.Name = "btnSrchBill"
        Me.btnSrchBill.Size = New System.Drawing.Size(233, 41)
        Me.btnSrchBill.TabIndex = 38
        Me.btnSrchBill.Text = "Sales Per Day"
        Me.btnSrchBill.UseVisualStyleBackColor = True
        '
        'btnsalesperday
        '
        Me.btnsalesperday.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsalesperday.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalesperday.Location = New System.Drawing.Point(83, 136)
        Me.btnsalesperday.Name = "btnsalesperday"
        Me.btnsalesperday.Size = New System.Drawing.Size(233, 41)
        Me.btnsalesperday.TabIndex = 37
        Me.btnsalesperday.Text = "All Product"
        Me.btnsalesperday.UseVisualStyleBackColor = True
        '
        'btnallcust
        '
        Me.btnallcust.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnallcust.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnallcust.Location = New System.Drawing.Point(83, 89)
        Me.btnallcust.Name = "btnallcust"
        Me.btnallcust.Size = New System.Drawing.Size(233, 41)
        Me.btnallcust.TabIndex = 36
        Me.btnallcust.Text = "All Customer"
        Me.btnallcust.UseVisualStyleBackColor = True
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 315)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnSrchBill)
        Me.Controls.Add(Me.btnsalesperday)
        Me.Controls.Add(Me.btnallcust)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReport"
        Me.Text = "frmReport"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btnSrchBill As System.Windows.Forms.Button
    Friend WithEvents btnsalesperday As System.Windows.Forms.Button
    Friend WithEvents btnallcust As System.Windows.Forms.Button
End Class
