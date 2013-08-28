<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchProduct
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
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txtsiEdit = New System.Windows.Forms.Button
        Me.txtsiExit = New System.Windows.Forms.Button
        Me.txtsiAdd = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.dgsearchitem = New System.Windows.Forms.DataGridView
        Me.txtname = New System.Windows.Forms.TextBox
        Me.txtno = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgsearchitem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel2.Controls.Add(Me.txtsiEdit)
        Me.Panel2.Controls.Add(Me.txtsiExit)
        Me.Panel2.Controls.Add(Me.txtsiAdd)
        Me.Panel2.Location = New System.Drawing.Point(26, 330)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(572, 38)
        Me.Panel2.TabIndex = 19
        '
        'txtsiEdit
        '
        Me.txtsiEdit.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsiEdit.Location = New System.Drawing.Point(334, 3)
        Me.txtsiEdit.Name = "txtsiEdit"
        Me.txtsiEdit.Size = New System.Drawing.Size(75, 33)
        Me.txtsiEdit.TabIndex = 4
        Me.txtsiEdit.Text = "EDIT"
        Me.txtsiEdit.UseVisualStyleBackColor = True
        '
        'txtsiExit
        '
        Me.txtsiExit.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsiExit.Location = New System.Drawing.Point(494, 3)
        Me.txtsiExit.Name = "txtsiExit"
        Me.txtsiExit.Size = New System.Drawing.Size(75, 33)
        Me.txtsiExit.TabIndex = 5
        Me.txtsiExit.Text = "EXIT"
        Me.txtsiExit.UseVisualStyleBackColor = True
        '
        'txtsiAdd
        '
        Me.txtsiAdd.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsiAdd.Location = New System.Drawing.Point(173, 3)
        Me.txtsiAdd.Name = "txtsiAdd"
        Me.txtsiAdd.Size = New System.Drawing.Size(75, 33)
        Me.txtsiAdd.TabIndex = 3
        Me.txtsiAdd.Text = "ADD"
        Me.txtsiAdd.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.dgsearchitem)
        Me.Panel1.Location = New System.Drawing.Point(52, 109)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(546, 215)
        Me.Panel1.TabIndex = 18
        '
        'dgsearchitem
        '
        Me.dgsearchitem.AllowUserToAddRows = False
        Me.dgsearchitem.AllowUserToDeleteRows = False
        Me.dgsearchitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgsearchitem.Location = New System.Drawing.Point(3, 3)
        Me.dgsearchitem.Name = "dgsearchitem"
        Me.dgsearchitem.ReadOnly = True
        Me.dgsearchitem.Size = New System.Drawing.Size(565, 209)
        Me.dgsearchitem.TabIndex = 0
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(412, 83)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(196, 20)
        Me.txtname.TabIndex = 2
        '
        'txtno
        '
        Me.txtno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtno.Location = New System.Drawing.Point(168, 83)
        Me.txtno.Name = "txtno"
        Me.txtno.Size = New System.Drawing.Size(100, 20)
        Me.txtno.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(302, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Search by name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Search by number"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Easy_Mall_Billing_System.My.Resources.Resources.search_product
        Me.PictureBox1.Location = New System.Drawing.Point(116, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(373, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'frmSearchProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(627, 399)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSearchProduct"
        Me.Text = "frmSearchProduct"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgsearchitem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtsiEdit As System.Windows.Forms.Button
    Friend WithEvents txtsiExit As System.Windows.Forms.Button
    Friend WithEvents txtsiAdd As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgsearchitem As System.Windows.Forms.DataGridView
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtno As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
