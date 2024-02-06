Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim stCountry As String
        stCountry = TextBox1.Text
        If stCountry = "India" Then MsgBox("Indian Citizen")


    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class