Module RandomNumberInator

    Sub Main()
        Dim currentNumber As Integer
        Dim randomNumbers(5) As Integer

        For i = 0 To 10000
            currentNumber = GetRandomNumber(5)
            Select Case currentNumber
                Case 0
                    randomNumbers(0) += 1
                Case 1
                    randomNumbers(1) += 1
                Case 2
                    randomNumbers(2) += 1
                Case 3
                    randomNumbers(3) += 1
                Case 4
                    randomNumbers(4) += 1
                Case 5
                    randomNumbers(5) += 1
                Case Else
                    MsgBox($"Hold on now.. got a {currentNumber}!", vbCritical)
            End Select
        Next

        Console.WriteLine(StrDup(39, "-"))

        For i = 0 To UBound(randomNumbers)
            Console.Write(CStr(randomNumbers(i)).PadLeft(6))
        Next

        Console.Read()

    End Sub

    Function GetRandomNumber(maxNumber As Integer) As Integer
        Randomize(DateTime.Now.Millisecond)
        Return CInt(Math.Floor(Rnd() * (maxNumber + 1)))
    End Function

End Module
