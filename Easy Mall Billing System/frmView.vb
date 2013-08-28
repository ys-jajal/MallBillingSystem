Public Class frmView

    Private Sub frmView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MainMDI
        Me.Location = New System.Drawing.Point(460, 290)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Me.Close()
    End Sub
    Private Sub btnSrchCust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSrchCust.Click
        frmSearchCust.Show()
        Me.Hide()
    End Sub

    Private Sub btnSrchPrdt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSrchPrdt.Click
        frmSearchProduct.Show()
        Me.Hide()
    End Sub

    Private Sub btnSrchBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSrchBill.Click
        frmSearchBill.Show()
        Me.Hide()
    End Sub
End Class