Imports System.Windows.Forms
Public Class frmReport

    Private Sub btnSrchBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSrchBill.Click
        frmSalesperDay.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub frmReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MainMDI
        Me.Location = New System.Drawing.Point(460, 290)
    End Sub

    Private Sub btnallcust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnallcust.Click
        rpt = "cust"
        Dim obj As New Report
        'obj.MdiParent = Me
        obj.Show()
    End Sub

    Private Sub btnsalesperday_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalesperday.Click
        rpt = "item"
        Dim obj As New Report
        'obj.MdiParent = Me
        obj.Show()
    End Sub
End Class