Option Strict On
Option Explicit On
Option Compare Text



Module multiplicationTable

    Sub Main()
        Dim number, column, row As Integer
        Dim multiplicationTable(12, 12) As Integer
        Dim goodData As Boolean
        Dim userinput, endInput As String
        Do
            Do
                Console.WriteLine($"Please Enter a Number.")
                Try
                    userinput = Console.ReadLine()
                    number = CInt(userinput)
                    If number < 13 And number > 0 Then
                        goodData = True
                    ElseIf number >= 13 Or number <= 0 Then
                        Console.WriteLine($"There is a max number of 12")
                        goodData = False
                    End If

                Catch
                    Console.WriteLine($"There is a max number of 12")
                    goodData = False
                    If userinput = "q" Then
                        Exit Sub
                    End If
                End Try
        Loop Until goodData = True








            Console.WriteLine($"Enjoy your {number} x {number} Multiplication Table")
            For column = 1 To number
                For row = 1 To number
                    multiplicationTable(row, column) = row * column
                    Console.Write(multiplicationTable(row, column) & vbTab)
                Next
                Console.WriteLine()
            Next
            Console.WriteLine("Please press enter to continue. Press q to quit.")

            endInput = Console.ReadLine
            If endInput = "q" Then
                Exit Sub

            End If
            Console.Clear()

        Loop
    End Sub

End Module
