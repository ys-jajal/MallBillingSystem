Public Class frmSearchProduct
    Dim da As SqlClient.SqlDataAdapter
    Dim ds As DataSet

    Public Sub setg()
        da = New SqlClient.SqlDataAdapter("select * from Product", con)
        con.Open()
        ds = New DataSet
        da.Fill(ds, "Product")
        dgsearchitem.DataSource = ds.Tables("Product").DefaultView
        con.Close()
    End Sub

    Private Sub txtsiExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsiExit.Click
        Me.Close()
        frmView.Show()
        frmView.Location = New System.Drawing.Point(460, 290)
    End Sub

    Private Sub frmSearchProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MainMDI
        Me.Location = New System.Drawing.Point(340, 250)

        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        Call setg()
    End Sub

    Private Sub txtsiEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsiEdit.Click
        EDIT.MdiParent = MainMDI
        EDIT.Show()
        Me.Close()
    End Sub

    Private Sub txtsiAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsiAdd.Click
        ADD.MdiParent = MainMDI
        ADD.Show()
        Me.Close()

    End Sub

    Private Sub txtno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtno.TextChanged
        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        If txtno.Text = "" Then
            GoTo aa
        End If
        If IsNumeric(txtno.Text) Then
aa:         If txtno.Text = "" Then
                Call setg()
            Else
                Dim dano As New SqlClient.SqlDataAdapter("select * from Product where Prod_No=" & txtno.Text, con)
                con.Open()
                Dim dsno As New DataSet
                dano.Fill(dsno, "Product")
                dgsearchitem.DataSource = dsno.Tables("Product").DefaultView
                con.Close()
            End If
        Else
            txtno.Text = ""
            MsgBox("Enter numeric values only", MsgBoxStyle.Information, Me.Text)
            Call setg()
        End If
    End Sub

    Private Sub txtname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtname.TextChanged
        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        If txtname.Text = "" Then
            Call setg()
        Else
            Dim dano As New SqlClient.SqlDataAdapter("select * from Product where PName LIKE '" & txtname.Text & "%' ", con)
            con.Open()
            Dim dsno As New DataSet
            dano.Fill(dsno, "Product")
            dgsearchitem.DataSource = dsno.Tables("Product").DefaultView
            con.Close()
        End If
    End Sub


End Class