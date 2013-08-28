Public Class frmSearchBill

    Private Sub frmSearchBill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MainMDI
        Me.Location = New System.Drawing.Point(500, 300)

        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        Dim cmd As New SqlClient.SqlCommand("select Bill_No from Bill_Info", con)
        Dim dr As SqlClient.SqlDataReader
        con.Open()
        dr = cmd.ExecuteReader

        While dr.Read
            cbbill.Items.Add(dr(0))
        End While

        dr.Close()
        con.Close()

    End Sub

    Private Sub btnsbCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsbCancel.Click
        Me.Close()
        frmView.Show()
        frmView.Location = New System.Drawing.Point(460, 290)
    End Sub

    Private Sub btnsbShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsbShow.Click
        rpt = "bill1"
        dts = cbbill.Text
        Dim obj As New Report
        obj.MdiParent = MainMDI

        obj.Show()

    End Sub
End Class