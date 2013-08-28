Public Class BillPrint

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        Dim rno As String = frmBilling.txtbilno.Text
        CrystalReportViewer1.SelectionFormula = ("{Bill_Info.Bill_No}=" & Val(rno) & "")
        CrystalReportViewer1.SelectionFormula = ("{prod_s.Bill_No}=" & Val(rno) & "")
        CrystalReportViewer1.Visible = True
        CrystalReportViewer1.RefreshReport()
    End Sub

    Private Sub BillPrint_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim str As String = "Data Source=.\SQLEXPRESS;Initial Catalog=Easymallbilling;Integrated Security=True"
        con = New SqlClient.SqlConnection(str)
        con.Open()
        Dim txticode As New TextBox
        Dim strReportPath As String
        strReportPath = "C:\Users\SpecialGift\Desktop\Easy Mall Billing System\Easy Mall Billing System\CrystalReport4.rpt"
        Dim rptDocument As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptDocument.Load(strReportPath)
    End Sub
End Class