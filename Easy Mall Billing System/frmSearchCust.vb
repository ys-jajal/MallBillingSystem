Public Class frmSearchCust
    Dim da As SqlClient.SqlDataAdapter
    Dim ds As DataSet
    Private Sub frmSearchCust_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MainMDI


        Me.Location = New System.Drawing.Point(270, 200)

        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        Call setg()
    End Sub

    Private Sub btnscExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnscExit.Click
        Me.Close()
        frmView.Show()
        frmView.Location = New System.Drawing.Point(460, 290)
    End Sub

    Public Sub setg()
        da = New SqlClient.SqlDataAdapter("select * from Cust_Info", con)
        con.Open()
        ds = New DataSet
        da.Fill(ds, "Cust_Info")
        dgsearch_cust.DataSource = ds.Tables("Cust_Info").DefaultView
        con.Close()
    End Sub
    Private Sub btnscAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnscAdd.Click
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
                Dim dano As New SqlClient.SqlDataAdapter("select * from Cust_Info where Cust_No=" & txtno.Text, con)
                con.Open()
                Dim dsno As New DataSet
                dano.Fill(dsno, "Cust_Info")
                dgsearch_cust.DataSource = dsno.Tables("Cust_Info").DefaultView
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
            Dim dano As New SqlClient.SqlDataAdapter("select * from Cust_Info where FNAME LIKE '" & txtname.Text & "%' ", con)
            con.Open()
            Dim dsno As New DataSet
            dano.Fill(dsno, "Cust_Info")
            dgsearch_cust.DataSource = dsno.Tables("Cust_Info").DefaultView
            con.Close()
        End If
    End Sub

    Private Sub btnscEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnscEdit.Click
        EDIT.MdiParent = MainMDI
        EDIT.Show()
        Me.Close()
    End Sub
End Class