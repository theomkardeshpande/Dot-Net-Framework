Module Module1

    Sub Main()
        'Dim arr() As Integer = {10, 5, 8, 9, 15}
        Dim arr As Integer() = New Integer(5) {}
        Dim Size As Integer

        Console.WriteLine("Enter Size of Array:")
        Size = Integer.Parse(Console.ReadLine())

        For i As Integer = 0 To Size - 1
            Console.WriteLine("Enter Integers:")
            'arr(i) = Convert.ToInt32(Console.ReadLine())
            arr(i) = Integer.Parse(Console.ReadLine())
        Next
        Dim SecondHighest As Integer = FindSecond(arr)
        'Dim Sum As Integer = ArraySum(arr)
        Console.WriteLine("Second Highest In Array: " & SecondHighest)
        Console.ReadLine()

    End Sub
    Function FindSecond(arr() As Integer) As Integer
        Array.Sort(arr)
        Array.Reverse(arr)
        Return (arr(1))
    End Function
End Module
