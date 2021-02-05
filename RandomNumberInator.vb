Module RandomNumberInator

    Sub Main()
        For i = 0 To 10
            Console.WriteLine(GetRandomNumber(5))
        Next
    End Sub

    Function GetRandomNumber(maxNumber As Integer) As Integer
        Dim randomNumber As Integer

        Randomize(DateTime.Now.Millisecond)

        randomNumber = CInt(Rnd() * maxNumber)

        Return randomNumber

    End Function

End Module
