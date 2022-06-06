Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Text.Json.Serialization

Public Class Form1
    Private Async Sub GetValue_Click(sender As Object, e As EventArgs) Handles GetValue.Click
        '宣告HttpClient
        Dim client As New HttpClient()

        '宣告ResponseMessage來承接回傳的內容
        Dim rspn As HttpResponseMessage

        '設定Author
        Dim strUser As String = "test1"
        Dim strPassword As String = "1test"

        '轉換為Base64編碼
        Dim strBase64 As String = Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes($"{strUser}:{strPassword}"))
        client.DefaultRequestHeaders.Authorization = New AuthenticationHeaderValue("Basic", strBase64)
        'WebAPI的Uri
        Dim uriWebApi As New Uri("http://localhost:9000/api/Values/GetValue")

        '透過GetAsync非同步呼叫WebAPI，結果傳給ResponseMessage
        rspn = Await client.GetAsync(uriWebApi)
        '確認成功
        rspn.EnsureSuccessStatusCode()

        '讀取回傳的內容
        Dim Content As String = Await rspn.Content.ReadAsStringAsync()
        '顯示回傳的內容
        Me.responce.Text = Content
    End Sub

    Private Async Sub PostValue_Click(sender As Object, e As EventArgs) Handles PostValue.Click

        Try

            '宣告HttpClient
            Dim client As New HttpClient()

            '宣告ResponseMessage來承接回傳的內容
            Dim rspn As HttpResponseMessage

            '設定Author
            Dim strUser As String = "test1"
            Dim strPassword As String = "1test"

            '轉換為Base64編碼
            Dim strBase64 As String = Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes($"{strUser}:{strPassword}"))
            client.DefaultRequestHeaders.Authorization = New AuthenticationHeaderValue("Basic", strBase64)

            Dim formData = New MultipartFormDataContent()


            '宣告要送出的Body內容
            Dim strBody As String = ""
            Dim hContent As New MultipartFormDataContent

            '設定Body內容的格式
            hContent.Headers.ContentType = New MediaTypeHeaderValue("application/json")
            hContent.Add(New StringContent("wer"), "valueType")

            Dim strObject As New PostValues With {
            .ValueType = "wer"
            }

            Dim strContent As StringContent
            strContent = New StringContent(Json.Net.JsonNet.Serialize(strObject), System.Text.Encoding.UTF8, "application/json")

            'WebAPI的Uri
            Dim uriWebApi As New Uri("http://localhost:9000/api/Values/PostValue")

            '透過GetAsync非同步呼叫WebAPI，結果傳給ResponseMessage
            rspn = Await client.PostAsync(uriWebApi, strContent)
            'rspn = Await client.PostAsJsonAsync()

            '確認成功
            rspn.EnsureSuccessStatusCode()

            '讀取回傳的內容
            Dim Content As String = Await rspn.Content.ReadAsStringAsync()

            '顯示回傳的內容
            Me.responce.Text = Content
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class
