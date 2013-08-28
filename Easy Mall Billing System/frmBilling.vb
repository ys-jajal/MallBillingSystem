Imports System.Net
Imports System.IO
Imports PCComm

Public Class frmBilling
    Dim cmdcn As SqlClient.SqlCommand
    Private comm As New CommManager()
    Private transType As String = String.Empty
    Private Sub frmBilling_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EasymallbillingDataSet.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.EasymallbillingDataSet.Product)

        comm.PortName = "COM1"
        comm.Parity = "None"
        comm.StopBits = "One"
        comm.DataBits = "8"
        comm.BaudRate = "4800"
        comm.DisplayWindow = RichTextBox1
        comm.OpenPort()
        Me.MdiParent = MainMDI
        Me.Location = New System.Drawing.Point(240, 130)

        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        Button2.Enabled = False
        dpdate.Text = Now
        'TextBox1.Text = 1

        cmdcn = New SqlClient.SqlCommand("select FNAME, LNAME from Cust_Info", con)
        con.Open()
        Dim dr As SqlClient.SqlDataReader = cmdcn.ExecuteReader
        While dr.Read
            cbcname.Items.Add(dr(0))
        End While


        dr.Close()
        con.Close()


        Call setg()
        Call billnumb()

    End Sub
    Private Sub cbcname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbcname.SelectedIndexChanged
        If cbcname.Text = "" Then
            Exit Sub
        End If
        Dim dr As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand("select * from Cust_Info where FNAME='" & cbcname.Text & "' ", con)
        con.Open()
        dr = cmd.ExecuteReader
        dr.Read()
        txtcno.Text = dr(0)
        dr.Close()
        con.Close()
    End Sub


    Public Sub billnumb()
        Dim cmdno As New SqlClient.SqlCommand("Select * From Bill_Info", con)
        con.Open()
        Dim drno As SqlClient.SqlDataReader = cmdno.ExecuteReader

        While drno.Read
            txtbilno.Text = drno(0)
        End While
        txtbilno.Text = Val(txtbilno.Text) + 1
        con.Close()
        drno.Close()
    End Sub

    Public Sub setg()
        Dim da As New SqlClient.SqlDataAdapter("select * from Product", con)
        con.Open()
        Dim ds As New DataSet
        da.Fill(ds, "Product")

        dgitem.DataSource = ds.Tables("Product").DefaultView
        dgitem.Columns(0).Visible = False
        con.Close()
    End Sub
    Private Sub txtname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtname.TextChanged
        If txtname.Text = "" Then
            Call setg()
        Else
            Dim dano As New SqlClient.SqlDataAdapter("select * from Product where PNAME LIKE '" & txtname.Text & "%' ", con)
            con.Open()
            Dim dsno As New DataSet
            dano.Fill(dsno, "Product")
            dgitem.DataSource = dsno.Tables("Product").DefaultView

            con.Close()
        End If
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub txtqty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtqty.TextChanged
        If txtqty.Text = "" Then
            txttp.Text = ""
            Exit Sub
        End If
        If IsNumeric(txtqty.Text) Then
            txttp.Text = Val(txtuprice.Text) * Val(txtqty.Text)
        Else
            txtqty.Text = ""
            MsgBox("Enter numeric value", MsgBoxStyle.Information, Me.Text)
        End If
    End Sub

    Private Sub cmdadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdadd.Click
        If txtqty.Text = Nothing Then
            MsgBox("Please enter quantity")
            Exit Sub
        End If
        If txttp.Text = Nothing Or txttp.Text = 0 Then
            MsgBox("Please select product")
            Exit Sub
        End If
        Dim temp As Integer
        temp = ListView1.Items.Count()
        Dim lst As New ListViewItem(txtpno.Text)

        lst.SubItems.Add(txtproduct.Text)
        lst.SubItems.Add(txtbrand.Text)
        lst.SubItems.Add(txtuprice.Text)
        lst.SubItems.Add(txtqty.Text)
        lst.SubItems.Add(txttp.Text)
        lst.SubItems.Add(txtpno.Text)
        ListView1.Items.Add(lst)
        txtsubtot.Text = subtot()

        'TextBox1.Text = TextBox1.Text + 1
        txtpno.Text = Nothing
        txtproduct.Text = Nothing
        txtbrand.Text = Nothing
        txtuprice.Text = Nothing
        txtqty.Text = Nothing
        txttp.Text = Nothing
    End Sub


    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        If txtbilno.Text = Nothing Or ListView1.Items.Count = 0 Or txttotal.Text = Nothing Then
            MsgBox("Cant save incomplete information", MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End If

        Dim i As Integer = 0
        Dim rs1, rs2 As String
        ' Try
        rs1 = "INSERT INTO Bill_Info VALUES(@Bill_No,@Cust_No,@Bill_Date,@Prod_No,@Sub_total,@Tax_Per,@Tax,@Total)"
        Dim cmdbill As New SqlClient.SqlCommand(rs1, con)
        cmdbill.Parameters.AddWithValue("Bill_No", Val(txtbilno.Text))
        cmdbill.Parameters.AddWithValue("Cust_No", Val(txtcno.Text))

        cmdbill.Parameters.AddWithValue("Bill_Date", dpdate.Text)
        cmdbill.Parameters.AddWithValue("Prod_No", Val(txtpno.Text))

        cmdbill.Parameters.AddWithValue("Sub_total", Val(txtsubtot.Text))
        cmdbill.Parameters.AddWithValue("Tax_per", Val(txtper.Text))
        cmdbill.Parameters.AddWithValue("Tax", Val(txttax.Text))
        cmdbill.Parameters.AddWithValue("Total", Val(txttotal.Text))
        con.Open()
        'Dim str As String = "INSERT INTO Bill_Info (Bill_No,Cust_No,Bill_Date,Prod_No,Sub_total,Tax_Per,Tax,Total) VALUES ('" & txtbilno.Text & "',)"
        Dim x As Integer = cmdbill.ExecuteNonQuery
        con.Close()
        Try
            Dim s1 As String = "Data Source=.\SQLEXPRESS;Initial Catalog=Easymallbilling;Integrated Security=True"
            con = New SqlClient.SqlConnection(s1)
            con.Open()

            Dim Sql As String = "select * from Cust_Info where Cust_No='" & txtcno.Text & "'"
            Dim r1 As SqlClient.SqlDataReader
            ' Dim cmd As New SqlCommand(Sql, con)
            Dim cmd As New SqlClient.SqlCommand(Sql, con)
            Dim cno As Long
            'cmd.ExecuteReader()
            r1 = cmd.ExecuteReader()
            If r1.Read Then
                'MsgBox(r1("MOB"))
                cno = r1("MOB")
            End If
            Dim strUrl As String
            Dim strResp As String
            '(VB.NET COMMENT:-STRURL me teri khud ki API string daal)
            'strUrl = "http://api.mVaayoo.com/mvaayooapi/MessageCompose?user=yogesh.jajal@gmail.com:likethis91&senderID=TEST SMS&receipientno=" & cno & "&msgtxt= EasyMall Always Welcomes You! Thank you for visiting. Your current bill is RS." & txttotal.Text & "&state=4"
            'strUrl = "http://api.mVaayoo.com/mvaayooapi/MessageCompose?user=(vipulalhat762@gmail.com):(likethis91)&senderID=TEST SMS&receipientno= " & TextBox1.Text & "  &dcs=0&msgtxt=" & TextBox2.Text & "  &state=2"
            strUrl = "http://api.mVaayoo.com/mvaayooapi/MessageCompose?user=psjajal.91@gmail.com:likethis91&senderID=TEST SMS&receipientno=" & cno & "&msgtxt= EasyMall Always Welcomes You! Thank you for visiting. Your current bill is RS." & txttotal.Text & "&state=4"
            strResp = DoWebrequest(strUrl)
            con.Close()
            MsgBox(strResp)
            'MsgBox("msg")
        Catch

        End Try
        con.Close()
        For i = 0 To ListView1.Items.Count - 1
            rs2 = "INSERT INTO prod_s VALUES(@Bill_No,@Prod_No,@P_Name,@P_Brand,@P_Price,@P_Qty,@Total)"
            Dim cmdsale As New SqlClient.SqlCommand(rs2, con)
            cmdsale.Parameters.AddWithValue("Bill_No", Val(txtbilno.Text))
            cmdsale.Parameters.AddWithValue("Prod_No", ListView1.Items(i).SubItems(6).Text)
            cmdsale.Parameters.AddWithValue("P_Name", ListView1.Items(i).SubItems(1).Text)
            cmdsale.Parameters.AddWithValue("P_Brand", ListView1.Items(i).SubItems(2).Text)
            cmdsale.Parameters.AddWithValue("P_Price", Val(ListView1.Items(i).SubItems(3).Text))
            cmdsale.Parameters.AddWithValue("P_Qty", Val(ListView1.Items(i).SubItems(4).Text))
            cmdsale.Parameters.AddWithValue("Total", Val(ListView1.Items(i).SubItems(5).Text))
            'cmdsale.Parameters.AddWithValue("Prod_No", ListView1.Items(i).SubItems(6).Text)
            con.Open()
            cmdsale.ExecuteNonQuery()
            'Dim s1 As String = "Data Source=.\SQLEXPRESS;Initial Catalog=Easymallbilling;Integrated Security=True"
            'con = New SqlClient.SqlConnection(s1)
            'con.Open()
            'Dim Sql As String = "select PQty from Product where Prod_No='" & Val(ListView1.Items(i).SubItems(4).Text) & "'"
            'Dim r1 As SqlClient.SqlDataReader
            '' Dim cmd As New SqlCommand(Sql, con)
            'Dim cmd As New SqlClient.SqlCommand(Sql, con)
            ''cmd.ExecuteReader()
            'r1 = cmd.ExecuteReader()
            ''  MsgBox("reaading")
            'If r1.Read Then
            '    'MsgBox(r1("PName"))
            '    Dim temp As Integer
            '    temp = ListView1.Items.Count()
            '    Dim lst As New ListViewItem()

            '    lst.SubItems.Add(r1("PName"))
            '    lst.SubItems.Add(r1("PBrand"))
            '    lst.SubItems.Add(r1("PPrice"))
            '    lst.SubItems.Add(r1("PQty"))
            '    lst.SubItems.Add(r1("PPrice"))
            'End If
            con.Close()
        Next
        MessageBox.Show(" Saved Successfully....")
        Button2.Enabled = True
        ' If cbcname.SelectedIndex = True Then

        '  MsgBox("reaading")
        ' If r1.Read Then
        'MsgBox(r1("PName"))

        'End If
        ' End If
        'Catch ex As Exception
        ' MsgBox(ex.Message)
        'End Try




    End Sub
    Private Function DoWebrequest(ByVal strUrl As String) As String
        Dim request As WebRequest = HttpWebRequest.Create(strUrl)
        Dim response As HttpWebResponse = request.GetResponse()
        Dim s As Stream = response.GetResponseStream()
        Dim readStream As StreamReader = New StreamReader(s)
        Dim dataString As String = readStream.ReadToEnd()
        response.Close()
        s.Close()
        readStream.Close()
        Return dataString

    End Function

    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub cmddel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddel.Click
        Try
            If ListView1.Items.Count = 0 Then
                MsgBox("No items to remove", MsgBoxStyle.Critical, "Error")
            Else
                Dim itmCnt, i, t As Integer

                ListView1.FocusedItem.Remove()
                itmCnt = ListView1.Items.Count
                t = 1
                For i = 1 To itmCnt + 1

                    'Dim lst1 As New ListViewItem(i)
                    'ListView1.Items(i).SubItems(0).Text = t
                    t = t + 1
                    'MsgBox(i)
                Next
                txtsubtot.Text = subtot()
            End If
        Catch ex As Exception
            MsgBox("No items is Selected", MsgBoxStyle.Question, "Error")
        End Try


    End Sub

    Public Function subtot() As Double
        Dim i, j, k As Integer
        i = 0
        j = 0
        k = 0

        Try
            j = ListView1.Items.Count
            For i = 0 To j - 1
                k = k + CInt(ListView1.Items(i).SubItems(5).Text)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return k
    End Function

    Private Sub txtper_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtper.TextChanged
        If txtper.Text = "" Then
            Label20.Visible = False
            txttax.Text = ""
            txttotal.Text = ""
            Exit Sub
        End If
        If IsNumeric(txtper.Text) Then
            If txtper.Text = CStr(1) Then
                Label20.Visible = True
            Else
                Label20.Visible = False
            End If
        Else
            MsgBox("Please enter numeric value", MsgBoxStyle.Information, Me.Text)
            txtper.Text = ""
        End If

        If txtsubtot.Text = "" Then
            MsgBox("Please Add Elements", MsgBoxStyle.Information, "Error")
            txtper.Text = ""
        Else
            Dim a, b, tot As Double
            a = Val(txtper.Text)
            b = a * txtsubtot.Text / 100
            txttax.Text = b

            tot = Val(txtsubtot.Text) + Val(txttax.Text)
            txttotal.Text = tot
        End If
    End Sub

    Private Sub cmdnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnew.Click
        'TextBox1.Text = Nothing
        txtbilno.Text = Nothing
        txtpno.Text = Nothing
        txtproduct.Text = Nothing
        txtuprice.Text = Nothing
        txtqty.Text = Nothing
        txttp.Text = Nothing
        ListView1.Items.Clear()
        txtsubtot.Text = Nothing
        txtper.Text = Nothing
        txttax.Text = Nothing
        txttotal.Text = Nothing
        txtcno.Text = Nothing

        Button2.Enabled = False

        Call billnumb()
    End Sub

    Private Sub dgitem_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgitem.RowHeaderMouseClick
        Dim i As Integer
        i = dgitem.CurrentRow.Index
        txtpno.Text = dgitem.Item(0, i).Value
        txtproduct.Text = dgitem.Item(1, i).Value
        txtbrand.Text = dgitem.Item(2, i).Value
        txtuprice.Text = dgitem.Item(3, i).Value
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        rpt = "bill"
        dts = txtbilno.Text
        Dim obj As New Report
        obj.MdiParent = MainMDI
        obj.Show()
        'BillReport.Show()

    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        'If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
        '    'Get a handle to the selected row
        '    ' Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
        '    MsgBox("Clear")
        '    'Clear the ListView
        '    ListView1.Clear()
        '    'For each cell in the DGV create a corresponding ListViewItem cell
        '    For Each c As DataGridViewCell In selectedRow.Cells
        '        'Make sure that the cell has a value
        '        MsgBox("For")
        '        If Not c.Value Is Nothing Then
        '            MsgBox("IF")
        '            'Add the value of the cell from the DGV to the ListViewItem
        '            ListView1.Items.Add(c.Value)
        '        End If
        '    Next
        'End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then

        'Get a handle to the selected row
        'Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

        ''Clear the ListView
        'ListView1.Clear()
        ''For each cell in the DGV create a corresponding ListViewItem cell
        'For Each c As DataGridViewCell In selectedRow.Cells
        '    'Make sure that the cell has a value

        '    If Not c.Value Is Nothing Then

        '        'Add the value of the cell from the DGV to the ListViewItem
        '        ListView1.Items.Add(c.Value)
        '    End If
        'Next
        'End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub dgitem_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgitem.CellContentClick

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class