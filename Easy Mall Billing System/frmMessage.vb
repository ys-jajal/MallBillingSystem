Imports System.Net
Imports System.IO

Public Class frmMessage

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmsg.TextChanged

    End Sub

    Private Sub frmMessage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MainMDI


        Me.Location = New System.Drawing.Point(520, 290)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim strUrl As String
        Dim strResp As String
        '(VB.NET COMMENT:-STRURL me teri khud ki API string daal)
        ' strUrl = "http://api.mVaayoo.com/mvaayooapi/MessageCompose?user=yogesh.jajal@gmail.com:likethis91&senderID=TEST SMS&receipientno=" & txtto.Text & "&msgtxt=" & txtmsg.Text & "&state=4"
        strUrl = "http://api.mVaayoo.com/mvaayooapi/MessageCompose?user=psjajal.91@gmail.com:likethis91&senderID=TEST SMS&receipientno=" & txtto.Text & "&msgtxt=" & txtmsg.Text & "&state=4"
        'strUrl = "http://api.mVaayoo.com/mvaayooapi/MessageCompose?user=vipulalhat762@gmail.com:likethis91&senderID=TEST SMS&receipientno=" & txtto.Text & "&msgtxt=" & txtmsg.Text & "&state=2"
        strResp = DoWebrequest(strUrl)

        MsgBox(strResp)
    End Sub
    Private Function DoWebrequest(ByVal strUrl As String) As String
        Try

      
            Dim request As WebRequest = HttpWebRequest.Create(strUrl)
            Dim response As HttpWebResponse = request.GetResponse()
            Dim s As Stream = response.GetResponseStream()
            Dim readStream As StreamReader = New StreamReader(s)
            Dim dataString As String = readStream.ReadToEnd()
            response.Close()
            s.Close()
            readStream.Close()
            Return dataString
        Catch ex As Exception

        End Try
    End Function

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()

    End Sub
End Class