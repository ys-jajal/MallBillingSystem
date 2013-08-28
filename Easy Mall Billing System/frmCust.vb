Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmCust

    Private Sub frmCust_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New System.Drawing.Point(280, 200)
    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Hide()
    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        Dim rs As String

        If txtfname.Text = "" And txtlname.Text = "" Then
            MsgBox("Enter Customer name")
            Exit Sub
        End If
        Try
            rs = "INSERT INTO customer VALUES(@Cust_fname,@Cust_lname,@Cust_addr,@Cust_cno,@Cust_eid)"
            Dim cmd As sqlCommand = New sqlCommand(rs, con)
            cmd.Parameters.AddWithValue("Cust_no", txtcno.Text)
            cmd.Parameters.AddWithValue("Cust_fname", txtfname.Text)
            cmd.Parameters.AddWithValue("Cust_lname", txtlname.Text)
            cmd.Parameters.AddWithValue("Cust_addr", txtaddr.Text)
            cmd.Parameters.AddWithValue("Cust_cno", txtmob.Text)
            cmd.Parameters.AddWithValue("Cust_eid", txteid.Text)

            con.Open()
            Dim x As Integer = cmd.ExecuteNonQuery
            MessageBox.Show(x.ToString & "record added succesfully.........")
            con.Close()
            'clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class