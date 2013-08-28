Module Module1
    Public rpt, dts As String
    'Public con As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\DataBase\BILLING_SYSTEM.mdb")
    'Public con As New SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Database\EasyMallBilling.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
    Public con As New SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Easymallbilling;Integrated Security=True")


    Public Sub numbCust()
        Dim cmdcno As New SqlClient.SqlCommand("select * from Cust_Info", con)
        con.Open()
        Dim drcno As SqlClient.SqlDataReader = cmdcno.ExecuteReader
        While drcno.Read
            ADD.txtcno.Text = drcno(0)
        End While
        ADD.txtcno.Text = Val(ADD.txtcno.Text) + 1
        drcno.Close()
        con.Close()
    End Sub
End Module
