



Module RandomNumberInator
    Sub Main()
        Dim randomNumbers(5) As Integer
        Dim someArrayOfThings(4, 8) As Boolean
        Dim fudge As Integer
        'load random numbers into array
        For i = 0 To 10000
            randomNumbers(GetRandomNumber(5)) += 1
        Next
        'Show header info
        fudge = CInt((42 - 14) / 2)
        Console.WriteLine(StrDup(fudge, " ") & "Random Numbers" & StrDup(fudge, " "))
        Console.WriteLine(StrDup(42, "-"))
        'show column headers
        For i = 0 To 5 Step 1
            Console.Write(Str(i).PadLeft(6) & "|")
        Next
        Console.WriteLine()
        Console.WriteLine(StrDup(42, "-"))
        'show hit count of random numbers in columns
        For i = 0 To UBound(randomNumbers)
            Console.Write(CStr(randomNumbers(i)).PadLeft(6) & "|")
        Next
        Console.Read()

    End Sub

    Function GetRandomNumber(maxNumber As Integer) As Integer
        Randomize(DateTime.Now.Millisecond)
        Return CInt(Math.Floor(Rnd() * (maxNumber + 1)))
    End Function
End Module
