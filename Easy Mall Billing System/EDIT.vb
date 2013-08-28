Imports System.Data.SqlClient
Public Class EDIT
    Dim ds, ds1 As New DataSet
    Dim da, da1 As New SqlDataAdapter

    Private Sub EDIT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MainMDI
        Me.Location = New System.Drawing.Point(260, 130)
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
       
        Call setg()
    End Sub

    Public Sub setg()
        con.Open()
        da = New SqlDataAdapter("select * from Cust_Info", con)
        da.Fill(ds, "Cust_Info")
        dgcust.DataSource = ds.Tables("Cust_Info").DefaultView

        da1 = New SqlDataAdapter("select * from Product", con)
        da1.Fill(ds1, "Product")
        dgitem.DataSource = ds1.Tables("Product").DefaultView
        con.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ADD.MdiParent = MainMDI
        ADD.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ADD.MdiParent = MainMDI
        ADD.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        If txtecno.Text = "" Then
            MsgBox("Please select element to update....", MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End If

        Try
            Dim cmdcust As New SqlClient.SqlCommand("UPDATE Cust_Info set FNAME='" & txtefname.Text & "', LNAME='" & txtelname.Text & "',ADDR='" & txteaddr.Text & "',MOB='" & txtemob.Text & "',EMAILID='" & txteeid.Text & "'where Cust_no=" & txtecno.Text, con)
            con.Open()
            cmdcust.ExecuteNonQuery()
            MsgBox("updated successfully", MsgBoxStyle.Information, Me.Text)
            con.Close()

            Dim reda As New SqlDataAdapter("select * from Cust_Info", con)
            con.Open()
            Dim reds As New DataSet
            reda.Fill(reds, "Cust_Info")
            dgcust.DataSource = reds.Tables(0)
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        If txteino.Text = "" Then
            MsgBox("Please select an item to update", MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End If

        Try
            Dim cmditem As New SqlClient.SqlCommand("Update Product set PName='" & txteiname.Text & "',PBrand='" & txtebrand.Text & "',PPrice='" & txteiprice.Text & "',PQty='" & txteqnty.Text & "' where Prod_No=" & txteino.Text, con)
            con.Open()
            cmditem.ExecuteNonQuery()
            MsgBox("updated successfully", MsgBoxStyle.Information, Me.Text)
            con.Close()

            Dim reda As New SqlDataAdapter("select * from Product", con)
            con.Open()
            Dim reds As New DataSet
            reda.Fill(reds, "Product")
            dgitem.DataSource = reds.Tables(0)
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


 

    Private Sub dgcust_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgcust.RowHeaderMouseClick
        Dim i As Integer
        i = dgcust.CurrentRow.Index
        txtecno.Text = dgcust.Item(0, i).Value
        txtefname.Text = dgcust.Item(1, i).Value
        txtelname.Text = dgcust.Item(2, i).Value
        txteaddr.Text = dgcust.Item(3, i).Value
        txtemob.Text = dgcust.Item(4, i).Value
        txteeid.Text = dgcust.Item(5, i).Value
    End Sub

    Private Sub dgitem_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgitem.RowHeaderMouseClick
        Dim j As Integer
        j = dgitem.CurrentRow.Index

        txteino.Text = dgitem.Item(0, j).Value
        txteiname.Text = dgitem.Item(1, j).Value
        txtebrand.Text = dgitem.Item(2, j).Value
        txteiprice.Text = dgitem.Item(3, j).Value
        txteqnty.Text = dgitem.Item(4, j).Value
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        If txtecno.Text = "" Then
            MsgBox("Please select element to delete....", MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End If

        Try
            Dim cmddcust As New SqlClient.SqlCommand("delete * from Cust_Info where Cust_No =" & txtecno.Text, con)
            con.Open()
            cmddcust.ExecuteNonQuery()
            MsgBox("deleted successfully", MsgBoxStyle.Information, Me.Text)
            clr()
            con.Close()

            Dim reda As New SqlDataAdapter("select * from Cust_Info", con)
            con.Open()
            Dim reds As New DataSet
            reda.Fill(reds, "Cust_Info")
            dgcust.DataSource = reds.Tables(0)
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub clr()
        txtecno.Clear()
        txtefname.Clear()
        txtelname.Clear()
        txteaddr.Clear()
        txtemob.Clear()
        txteeid.Clear()

        txteino.Clear()
        txteiname.Clear()
        txtebrand.Clear()
        txteiprice.Clear()
        txteqnty.Clear()
        
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        If txteino.Text = "" Then
            MsgBox("Please select an item to delete", MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End If

        Try
            Dim cmditem As New SqlClient.SqlCommand("delete * from Product where Prod_No =" & txteino.Text, con)
            con.Open()
            cmditem.ExecuteNonQuery()
            MsgBox("deleted successfully", MsgBoxStyle.Information, Me.Text)
            clr()
            con.Close()

            Dim reda As New SqlDataAdapter("select * from Product", con)
            con.Open()
            Dim reds As New DataSet
            reda.Fill(reds, "Product")
            dgitem.DataSource = reds.Tables(0)
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class