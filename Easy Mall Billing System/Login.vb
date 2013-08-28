Imports System.Data.SqlClient
Public Class Login
    Dim cb As SqlCommand
    Dim dr As SqlDataReader

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        con.Open()
        cb = New sqlCommand("select * from Login", con)
        dr = cb.ExecuteReader
        Dim u, p As String
        While dr.Read
            u = dr(0)
            p = dr(1)
        End While
        If (txtUsername.Text.Equals(u) And txtPwd.Text.Equals(p)) Then
            Me.Hide()
            SplashScreen1.Show()
            'MDIParent1.Show()
            'MsgBox("Welcome To Billing System")
        Else
            MsgBox("Invalid Username or Password")
        End If
        con.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        End
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If con.State = ConnectionState.Open Then
            con.Close()
        End If

    End Sub
End Class
