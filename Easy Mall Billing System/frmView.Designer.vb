<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmView
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
        Me.btnSrchCust = New System.Windows.Forms.Button
        Me.btnSrchPrdt = New System.Windows.Forms.Button
        Me.btnSrchBill = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnSrchCust
        '
        Me.btnSrchCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSrchCust.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSrchCust.Location = New System.Drawing.Point(91, 81)
        Me.btnSrchCust.Name = "btnSrchCust"
        Me.btnSrchCust.Size = New System.Drawing.Size(233, 41)
        Me.btnSrchCust.TabIndex = 0
        Me.btnSrchCust.Text = "Search Customer"
        Me.btnSrchCust.UseVisualStyleBackColor = True
        '
        'btnSrchPrdt
        '
        Me.btnSrchPrdt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSrchPrdt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSrchPrdt.Location = New System.Drawing.Point(91, 134)
        Me.btnSrchPrdt.Name = "btnSrchPrdt"
        Me.btnSrchPrdt.Size = New System.Drawing.Size(233, 41)
        Me.btnSrchPrdt.TabIndex = 1
        Me.btnSrchPrdt.Text = "Search Product"
        Me.btnSrchPrdt.UseVisualStyleBackColor = True
        '
        'btnSrchBill
        '
        Me.btnSrchBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSrchBill.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSrchBill.Location = New System.Drawing.Point(91, 186)
        Me.btnSrchBill.Name = "btnSrchBill"
        Me.btnSrchBill.Size = New System.Drawing.Size(233, 41)
        Me.btnSrchBill.TabIndex = 2
        Me.btnSrchBill.Text = "Search Bill"
        Me.btnSrchBill.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(384, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(42, 33)
        Me.Button4.TabIndex = 35
        Me.Button4.Text = "X"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'frmView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 325)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnSrchBill)
        Me.Controls.Add(Me.btnSrchPrdt)
        Me.Controls.Add(Me.btnSrchCust)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmView"
        Me.Text = "frmView"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSrchCust As System.Windows.Forms.Button
    Friend WithEvents btnSrchPrdt As System.Windows.Forms.Button
    Friend WithEvents btnSrchBill As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
