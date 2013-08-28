Public Class frmProduct

    Private Sub frmProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New System.Drawing.Point(310, 200)
    End Sub

    Private Sub btnpExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpExit.Click
        Me.Hide()
    End Sub
End Class