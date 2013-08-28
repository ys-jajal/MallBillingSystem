Imports System.Data.SqlClient
Public Class ADD

    Public Sub clear1()
        txtiprice.Clear()
        txtiname.Clear()
        txtbrand.Clear()
        txtqnty.Clear()
        txtcno.Clear()

    End Sub

    Public Sub clear()
        txtaddr.Clear()
        txtfname.Clear()
        txtlname.Clear()
        txteid.Clear()
        txtmob.Clear()
        numbCust()


    End Sub
    Private Sub cmdexit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        MainMDI.Show()
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
            rs = "INSERT INTO Cust_Info VALUES(@Cust_No,@FNAME,@LNAME,@ADDR,@MOB,@EMAILID)"
            Dim cmd As sqlCommand = New sqlCommand(rs, con)
            cmd.Parameters.AddWithValue("Cust_no", txtcno.Text)
            cmd.Parameters.AddWithValue("FNAME", txtfname.Text)
            cmd.Parameters.AddWithValue("LNAME", txtlname.Text)
            cmd.Parameters.AddWithValue("ADDR", txtaddr.Text)
            cmd.Parameters.AddWithValue("MOB", txtmob.Text)
            cmd.Parameters.AddWithValue("EMAILID", txteid.Text)

            con.Open()
            Dim x As Integer = cmd.ExecuteNonQuery
            MessageBox.Show(x.ToString & "record added succesfully.........")
            con.Close()
            'txtaddr.Clear()
            'txtfname.Clear()
            'txtlname.Clear()
            'txteid.Clear()
            'txtmob.Clear()
            clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdclr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclr.Click
        clear()
    End Sub

    Private Sub cmdexit1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit1.Click
        Me.Close()
    End Sub

    Private Sub cmdclr1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclr1.Click
        clear1()
    End Sub

    Private Sub cmdsave1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave1.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        Dim rs As String
        If txtiname.Text = "" Then
            MsgBox("Enter Item name")
            Exit Sub
        ElseIf txtiprice.Text = "" Then
            MsgBox("Enter Item Price")
            Exit Sub
        ElseIf txtqnty.Text = "" Then
            MsgBox("Enter Quantity")
            Exit Sub
        ElseIf txtbrand.Text = "" Then
            MsgBox("Enter Item Brand")
            Exit Sub
        ElseIf txtino.Text = "" Then
            MsgBox("Enter Item Barcode number")
            Exit Sub
        End If
        Try
            rs = "INSERT INTO Product VALUES(@Prod_No,@PName,@PBrand,@PPrice,@PQty)"
            Dim cmd As SqlCommand = New SqlCommand(rs, con)
            cmd.Parameters.AddWithValue("Prod_No", txtino.Text)
            cmd.Parameters.AddWithValue("PName", txtiname.Text)
            cmd.Parameters.AddWithValue("PBrand", txtbrand.Text)
            cmd.Parameters.AddWithValue("PPrice", txtiprice.Text)
            cmd.Parameters.AddWithValue("PQTY", txtqnty.Text)
            con.Open()
            Dim x As Integer = cmd.ExecuteNonQuery
            MessageBox.Show(x.ToString & "record added succesfully.........")
            con.Close()
            clear1()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub

    Private Sub cmdedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdedit.Click
        EDIT.MdiParent = MainMDI
        EDIT.Show()
    End Sub

    Private Sub cmdedit1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdedit1.Click
        EDIT.MdiParent = MainMDI
        EDIT.Show()
    End Sub

    Private Sub ADD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MainMDI
        Me.Location = New System.Drawing.Point(280, 180)
        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        Call numbCust()
    End Sub
   

    Private Sub txtiprice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If IsNumeric(txtiprice.Text) Or txtiprice.Text = "" Then
        Else
            MsgBox("Enter numeric value")
            txtiprice.Text = ""
            txtiprice.Focus()
        End If
    End Sub

    Private Sub txtmob_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If IsNumeric(txtmob.Text) Or txtmob.Text = "" Then
        Else
            MsgBox("Enter numeric value")
            txtmob.Text = ""
            txtmob.Focus()
        End If
    End Sub
End Class