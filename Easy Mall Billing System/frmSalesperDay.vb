Public Class frmSalesperDay
    Dim dt As String
   
    Private Sub btnspdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnspdCancel.Click
        Me.Close()

    End Sub

    Private Sub frmSalesperDay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MainMDI
        Me.Location = New System.Drawing.Point(500, 300)
        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        Dim cmd As New SqlClient.SqlCommand("select Distinct Bill_Date from Bill_Info", con)
        Dim dr As SqlClient.SqlDataReader
        con.Open()
        dr = cmd.ExecuteReader

        While dr.Read
            cbdate.Items.Add(dr(0))
        End While

        dr.Close()
        con.Close()
    End Sub

    Private Sub btnspdShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnspdShow.Click
        If cbdate.Text = "" Then
            MsgBox("Please Select Date", MsgBoxStyle.Information, Me.Text)
        Else
            rpt = "sale"
            dts = cbdate.Text
            Dim obj As New Report
            obj.Show()
        End If
    End Sub
End Class