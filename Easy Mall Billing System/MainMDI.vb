

Public Class MainMDI

    Private Sub btnBilling_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBilling.Click

        frmBilling.Show()
        ADD.Close()
        EDIT.Close()
        frmView.Close()
        frmReport.Close()
        frmMessage.Close()
        frmSalesperDay.Close()
        frmSearchBill.Close()
        frmSearchCust.Close()
        frmSearchProduct.Close()

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
        End
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        frmBilling.Close()
        ADD.Close()
        EDIT.Close()
        frmView.Show()
        frmReport.Close()
        frmMessage.Close()
        frmSalesperDay.Close()
        frmSearchBill.Close()
        frmSearchCust.Close()
        frmSearchProduct.Close()
    End Sub

    Private Sub btnRpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRpt.Click
        frmBilling.Close()
        ADD.Close()
        EDIT.Close()
        frmView.Close()
        frmReport.Show()
        frmMessage.Close()
        frmSalesperDay.Close()
        frmSearchBill.Close()
        frmSearchCust.Close()
        frmSearchProduct.Close()

    End Sub

    Private Sub btnMem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMem.Click
        frmBilling.Close()
        ADD.Show()
        EDIT.Close()
        frmView.Close()
        frmReport.Close()
        frmMessage.Close()
        frmSalesperDay.Close()
        frmSearchBill.Close()
        frmSearchCust.Close()
        frmSearchProduct.Close()

    End Sub

    Private Sub btnProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProduct.Click
        frmBilling.Close()
        ADD.Close()
        EDIT.Show()
        frmView.Close()
        frmReport.Close()
        frmMessage.Close()
        frmSalesperDay.Close()
        frmSearchBill.Close()
        frmSearchCust.Close()
        frmSearchProduct.Close()

    End Sub

    Private Sub btnMsg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMsg.Click
        frmBilling.Close()
        ADD.Close()
        EDIT.Close()
        frmView.Close()
        frmReport.Close()
        frmMessage.Show()
        frmSalesperDay.Close()
        frmSearchBill.Close()
        frmSearchCust.Close()
        frmSearchProduct.Close()
    End Sub

    Private Sub MainMDI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Try
            Me.Show()
            Me.WindowState = FormWindowState.Maximized
            NotifyIcon1.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MainMDI_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Try
            If Me.WindowState = FormWindowState.Minimized Then
                Me.WindowState = FormWindowState.Minimized
                NotifyIcon1.Visible = True
                Me.Hide()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
