



'David Harmon
'RCET0265
'Fall 2020
'Multiplication Table
'https://github.com/harmdavi/multiplicationTable.git

'This code was made possible by Lane Coleman who helped me



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
                'Try Catch is here to make sure that only numbers can be accepted.
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
                    'these quit if/then statement must be here so that the user can quit at the begining 
                    'as well as the end 
                    If userinput = "q" Then
                        Exit Sub
                    End If
                End Try
        Loop Until goodData = True








            Console.WriteLine($"Enjoy your {number} x {number} Multiplication Table")
            For column = 1 To number
                For row = 1 To number
                    'The rows and the columns reffer to the multiplication table rows and columns 
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
            'Clear at the end of the program to reset so another multiplication table may be generated. 
            Console.Clear()

        Loop
    End Sub

End Module
