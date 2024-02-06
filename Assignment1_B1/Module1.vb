Module Module1
    '1. Write a Vb.net program to find Prime Numbers between 1 to 500.

    Sub Main()
        Console.WriteLine("Prime Numbers Priting..!")
        For i As Integer = 2 To 500
            If isPrimeNumber(i) Then
                Console.WriteLine("Prime Number: " & i)
            End If
        Next
        Console.ReadLine()
    End Sub

    Function isPrimeNumber(num As Integer) As Boolean
        If num < 2 Then
            Return False
        End If

        For i As Integer = 2 To Math.Sqrt(num)
            If num Mod i = 0 Then
                Return False
            End If
        Next

        Return True
    End Function
End Module
