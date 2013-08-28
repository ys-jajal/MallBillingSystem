Public Class Report

    Private Sub Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MainMDI
        Me.Location = New System.Drawing.Point(190, 130)
        Me.Height = 600
        Me.Width = 900

        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        If rpt = "cust" Then
            Dim ds As New DataSet
            Dim da As New SqlClient.SqlDataAdapter("select * from Cust_Info", con)
            con.Open()
            da.Fill(ds, "Cust_Info")

            Dim obj As New CrystalReport1
            obj.Database.Tables(0).SetDataSource(ds.Tables("Cust_Info"))
            CrystalReportViewer1.ReportSource = obj
            con.Close()
        ElseIf rpt = "item" Then
            Dim ds As New DataSet
            Dim da As New SqlClient.SqlDataAdapter("select * from Product", con)
            con.Open()
            da.Fill(ds, "Product")

            Dim obj As New CrystalReport2
            obj.Database.Tables(0).SetDataSource(ds.Tables("Product"))
            CrystalReportViewer1.ReportSource = obj
            con.Close()
        ElseIf rpt = "sale" Then
            Dim ds As New DataSet
            Dim da As New SqlClient.SqlDataAdapter("select * from Bill_Info where Bill_Date='" & dts & "'", con)
            con.Open()
            da.Fill(ds, "Bill_Info")

            Dim obj As New SALE_REPT
            obj.Database.Tables(0).SetDataSource(ds.Tables("Bill_Info"))
            CrystalReportViewer1.ReportSource = obj
            con.Close()
        ElseIf rpt = "bill" Then
            Dim ds As New DataSet
            Dim da As New SqlClient.SqlDataAdapter("select * from Bill_Info b, prod_s i where b.Bill_No=i.Bill_No and b.Bill_No = " & dts, con)
            con.Open()

            da.Fill(ds, "Bill_Info, prod_s")

            Dim obj As New CrystalReport5
            obj.Database.Tables(0).SetDataSource(ds.Tables("Bill_Info, prod_s"))
            CrystalReportViewer1.ReportSource = obj

            'Dim bno As String = frmSearchBill.cbbill.Text

            Dim bno As String = frmBilling.txtbilno.Text
            CrystalReportViewer1.SelectionFormula = ("{Bill_Info.Bill_No}=" & Val(bno) & "")
            'CrystalReportViewer1.SelectionFormula = ("{prod_s.Bill_No}=" & Val(bno) & "")
            CrystalReportViewer1.Visible = True
            CrystalReportViewer1.RefreshReport()
            con.Close()
        ElseIf rpt = "bill1" Then
            Dim ds As New DataSet
            Dim da As New SqlClient.SqlDataAdapter("select * from Bill_Info b, prod_s i where b.Bill_No=i.Bill_No and b.Bill_No = " & dts, con)
            con.Open()

            da.Fill(ds, "Bill_Info, prod_s")

            Dim obj As New CrystalReport5
            obj.Database.Tables(0).SetDataSource(ds.Tables("Bill_Info, prod_s"))
            CrystalReportViewer1.ReportSource = obj

            Dim bno As String = frmSearchBill.cbbill.Text

            'Dim bno As String = frmBilling.txtbilno.Text
            CrystalReportViewer1.SelectionFormula = ("{Bill_Info.Bill_No}=" & Val(bno) & "")
            'CrystalReportViewer1.SelectionFormula = ("{prod_s.Bill_No}=" & Val(bno) & "")
            CrystalReportViewer1.Visible = True
            CrystalReportViewer1.RefreshReport()
            con.Close()

        End If

    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class