<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchCust
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
        Me.txtname = New System.Windows.Forms.TextBox
        Me.txtno = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnscEdit = New System.Windows.Forms.Button
        Me.btnscAdd = New System.Windows.Forms.Button
        Me.btnscExit = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.dgsearch_cust = New System.Windows.Forms.DataGridView
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgsearch_cust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtname
        '
        Me.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtname.Location = New System.Drawing.Point(454, 85)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(255, 20)
        Me.txtname.TabIndex = 2
        '
        'txtno
        '
        Me.txtno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtno.Location = New System.Drawing.Point(194, 85)
        Me.txtno.Name = "txtno"
        Me.txtno.Size = New System.Drawing.Size(100, 20)
        Me.txtno.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(313, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Search by first name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(58, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Search by number"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnscEdit)
        Me.Panel2.Controls.Add(Me.btnscAdd)
        Me.Panel2.Controls.Add(Me.btnscExit)
        Me.Panel2.Location = New System.Drawing.Point(16, 431)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(709, 39)
        Me.Panel2.TabIndex = 9
        '
        'btnscEdit
        '
        Me.btnscEdit.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnscEdit.Location = New System.Drawing.Point(476, 3)
        Me.btnscEdit.Name = "btnscEdit"
        Me.btnscEdit.Size = New System.Drawing.Size(75, 33)
        Me.btnscEdit.TabIndex = 4
        Me.btnscEdit.Text = "EDIT"
        Me.btnscEdit.UseVisualStyleBackColor = True
        '
        'btnscAdd
        '
        Me.btnscAdd.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnscAdd.Location = New System.Drawing.Point(314, 3)
        Me.btnscAdd.Name = "btnscAdd"
        Me.btnscAdd.Size = New System.Drawing.Size(75, 33)
        Me.btnscAdd.TabIndex = 3
        Me.btnscAdd.Text = "ADD"
        Me.btnscAdd.UseVisualStyleBackColor = True
        '
        'btnscExit
        '
        Me.btnscExit.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnscExit.Location = New System.Drawing.Point(621, 3)
        Me.btnscExit.Name = "btnscExit"
        Me.btnscExit.Size = New System.Drawing.Size(75, 33)
        Me.btnscExit.TabIndex = 5
        Me.btnscExit.Text = "EXIT"
        Me.btnscExit.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.dgsearch_cust)
        Me.Panel1.Location = New System.Drawing.Point(13, 133)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(696, 278)
        Me.Panel1.TabIndex = 8
        '
        'dgsearch_cust
        '
        Me.dgsearch_cust.AllowUserToAddRows = False
        Me.dgsearch_cust.AllowUserToDeleteRows = False
        Me.dgsearch_cust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgsearch_cust.Location = New System.Drawing.Point(3, 3)
        Me.dgsearch_cust.Name = "dgsearch_cust"
        Me.dgsearch_cust.ReadOnly = True
        Me.dgsearch_cust.Size = New System.Drawing.Size(709, 273)
        Me.dgsearch_cust.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Easy_Mall_Billing_System.My.Resources.Resources.search_customer
        Me.PictureBox1.Location = New System.Drawing.Point(177, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(391, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'frmSearchCust
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(737, 482)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSearchCust"
        Me.Text = "frmSearchCust"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgsearch_cust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtno As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnscEdit As System.Windows.Forms.Button
    Friend WithEvents btnscAdd As System.Windows.Forms.Button
    Friend WithEvents btnscExit As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgsearch_cust As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
