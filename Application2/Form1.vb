Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Principal As Double
        Dim Roi As Double
        Dim Years As Double
        Dim Result As Double

        Principal = Val(TextBox1.Text)
        Roi = Val(TextBox2.Text)
        Years = Val(TextBox1.Text)

        Result = (Principal * Roi * Years) \ 100
        MsgBox("Intrest is " & Result)

    End Sub
End Class
