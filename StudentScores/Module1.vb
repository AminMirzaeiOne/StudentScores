Imports System

Module Module1

    Sub Main()

        ' Definition of the number of students variable
        Dim numberStudents As Integer = 10

        System.Console.ForegroundColor = ConsoleColor.Cyan
        ' Get the number of students and store it in number Students
        System.Console.Write("Enter Number Of Students : ")
        System.Console.ForegroundColor = ConsoleColor.Yellow
        numberStudents = System.Convert.ToInt32(System.Console.ReadLine())
        System.Console.ResetColor()
        ' Declare an array to store (numberStudents) grades
        Dim grades(numberStudents - 1) As Integer
        ' Declare variables for sum of grades, highest grade, lowest grade, and count of grades below 12
        Dim sumOfGrades As Integer
        Dim highestGrade As Integer = Integer.MinValue
        Dim lowestGrade As Integer = Integer.MaxValue
        Dim countBelow12 As Integer
        System.Console.ForegroundColor = ConsoleColor.Gray
        System.Console.WriteLine("-----------------------")

        ' Get grades from the user
        For i As Integer = 0 To numberStudents - 1
            System.Console.ForegroundColor = ConsoleColor.Green
            System.Console.Write("Enter the grade for student {0}: ", i + 1)
            System.Console.ForegroundColor = ConsoleColor.DarkMagenta
            grades(i) = System.Convert.ToInt32(System.Console.ReadLine())
        Next
        System.Console.ResetColor()
        ' Calculate the sum of grades
        For Each grade As Integer In grades
            sumOfGrades += grade
        Next

        ' Calculate the average
        Dim average As Double = sumOfGrades / grades.Length

        ' Find the highest and lowest grades, and count grades below 12
        For Each grade As Integer In grades
            If grade > highestGrade Then
                highestGrade = grade
            End If
            If grade < lowestGrade Then
                lowestGrade = grade
            End If
            If grade < 12 Then
                countBelow12 += 1
            End If
        Next

        System.Console.ForegroundColor = ConsoleColor.Gray
        System.Console.WriteLine("-----------------------")
        System.Console.ResetColor()

        ' Print the results
        System.Console.WriteLine("Average grade: " & average)
        System.Console.WriteLine("Highest grade: " & highestGrade)
        System.Console.WriteLine("Lowest grade: " & lowestGrade)
        System.Console.WriteLine("Number of students with grades below 12: " & countBelow12)

        System.Console.ReadLine() ' Pause the console
    End Sub
End Module
