Module Module1
    '. Write a Vb.net program to find Spy Numbers between 100 to 500'
    Sub Main()

        For i As Integer = 100 To 500
            If spyNumbers(i) Then
                Console.WriteLine(i)
            End If
        Next


    End Sub

    Function spyNumbers(num As Integer) As Boolean
        Dim Digits() As Integer = getDigits(num)
        Dim sumOfDigits() As Integer = GetSumOfDigits(digits)
        Dim productofDigits() As Integer = GetProductOfDigits(Digits)

        Return sumOfDigits = productofDigits
    End Function

    Function GetProductOfDigits(As Integer) As Integer()
    End Function

    Function GetSumOfDigits(digits() As Integer) As Integer()
    End Function

    Function getDigits(num As Integer) As Integer()
        Dim digits() As Integer = New Integer(num.ToString().Length - 1) {}
        Dim index As Integer = 0

        While num > 0

        End While

    End Function
End Module
