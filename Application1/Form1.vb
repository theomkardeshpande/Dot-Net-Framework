Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim newString As String
        Dim newinteger As Integer
        Dim newBoolen As Boolean
        Dim newDecimal As Decimal
        Dim newDate As Date

        newString = "Omkar Deshpande"
        newinteger = 21
        newBoolen = True
        newDecimal = 8.815
        newDate = #01/23/2024#

        MsgBox("My Name is " & newString & Environment.NewLine & "Age is " & newinteger & Environment.NewLine &
               "Average SGPA is " & newDecimal & Environment.NewLine & "And Today Date is " & newDate)
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Dim First As Integer
        Dim Second As Integer
        Dim Result As Integer

        First = TextBox1.Text
        Second = TextBox2.Text

        Result = First + Second
        MsgBox("Addition:" & Result)

        Result = First - Second
        MsgBox("Subtraction:" & Result)

        Result = First * Second
        MsgBox("Multiplication:" & Result)

        Result = First / Second
        MsgBox("Division:" & Result)

        Result = First ^ Second
        MsgBox("Power:" & Result)

        Result = First Mod Second
        MsgBox("Modulas:" & Result)

        'Dim stCourse As String
        'stCourse = ListBox1.SelectedItem


        'MsgBox("First Name is " & stFirst & stLast & Environment.NewLine &
        '" And I am in " & stCourse)


    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class
