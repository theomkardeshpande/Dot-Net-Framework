Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim stCountry As String
        stCountry = TextBox1.Text
        stCountry = stCountry.ToUpper

        If stCountry = "INDIA" Then
            MsgBox("Indian Citizen")
        ElseIf stCountry = "USA" Then
            MsgBox("American Citizen")
        ElseIf stCountry = "CANADA" Then
            MsgBox("Canadian Citizen")
        ElseIf stCountry = "ITALY" Then
            MsgBox("Italian Citizen")
        Else
            MsgBox("Invalid Input")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim intNumber As Integer
        intNumber = TextBox2.Text
        If intNumber > 0 And intNumber < 100 Then
            MsgBox("Within 100")
        ElseIf intNumber > 100 Or intNumber < 200 Then
            MsgBox("Within 200")
        Else
            MsgBox("Invalid Input")
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim intTemp As Integer
        intTemp = CInt(TextBox3.Text)

        Select Case intTemp
            Case Is = 0
                MsgBox("Its Zero Degree")
            Case 1 To 10
                MsgBox("Its Between  1 to 10")
            Case 11 To 20
                MsgBox("Its Between 11 to 20")
            Case > 20
                MsgBox("Its Too Hot")
        End Select
    End Sub
End Class
