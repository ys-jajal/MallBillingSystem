Imports System.Data.SqlClient


Public Class Class1
    Dim str As String
    Dim con As SqlConnection

    Sub New()
        'Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Database\EasyMallBilling.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        'Dim con As New SqlConnection("Data Source=.\SQLExpress;Integrated Security=true;Initial Catalog=Easymallbilling;User Instance=true;")
        Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Easymallbilling;Integrated Security=True")


        con.Open()

    End Sub

    
    Function gettablevalue(ByVal dt As String) As DataSet
        ' str = "Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Pravin\Desktop\EasyMallBilling.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"
        'str = "Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Database\EasyMallBilling.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"
        str = "Data Source=.\SQLEXPRESS;Initial Catalog=Easymallbilling;Integrated Security=True"
        con = New SqlConnection(str)
        con.Open()

        Dim da As SqlDataAdapter = New SqlDataAdapter("Select * from Product where Prod_No= '" & dt & "'", con)
        'Dim da As OleDbDataAdapter = New OleDbDataAdapter("Select * from product where ID= '0000001'", con)
        Dim ds As DataSet = New DataSet()
        da.Fill(ds, "Product")


        Return (ds)


    End Function
    Function getdata(ByVal oledb As String) As SqlDataReader
        Dim cmd As New SqlCommand(oledb, con)
        Return (cmd.ExecuteReader)
    End Function
End Class
