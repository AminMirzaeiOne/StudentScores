Imports System

Module Module1


    Sub Main()


        System.Console.Write("Light Or Dark Mode (Light : l - Dark : d) : ")
        Dim theme As Char = System.Console.ReadLine()
        Dim themeColor As ConsoleColor = ConsoleColor.Black
        Dim foregroundTheme As ConsoleColor = ConsoleColor.Yellow
        If theme = "l" Then
            System.Console.BackgroundColor = ConsoleColor.White
            System.Console.Clear()
            foregroundTheme = ConsoleColor.Black
            themeColor = ConsoleColor.White
        ElseIf theme = "d" Then
            System.Console.BackgroundColor = ConsoleColor.Black
            System.Console.Clear()
            foregroundTheme = ConsoleColor.Yellow
            themeColor = ConsoleColor.Black
        End If

        ' Definition of the number of students variable
        Dim numberStudents As Integer = 10

        System.Console.ForegroundColor = ConsoleColor.Cyan
        ' Get the number of students and store it in number Students
        System.Console.Write("Enter Number Of Students : ")
        System.Console.ForegroundColor = foregroundTheme
        numberStudents = System.Convert.ToInt32(System.Console.ReadLine())
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
            System.Console.ForegroundColor = ConsoleColor.DarkGreen
            System.Console.Write("Enter the grade for student {0}: ", i + 1)
            System.Console.ForegroundColor = foregroundTheme
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
        System.Console.BackgroundColor = themeColor
        System.Console.WriteLine("-----------------------")

        System.Console.ForegroundColor = ConsoleColor.DarkYellow
        ' Print the results
        System.Console.Write("Average grade : ")
        System.Console.ForegroundColor = ConsoleColor.White
        System.Console.BackgroundColor = ConsoleColor.DarkYellow
        System.Console.WriteLine(average.ToString())
        System.Console.BackgroundColor = themeColor
        System.Console.ForegroundColor = ConsoleColor.DarkCyan
        System.Console.Write("Highest grade : ")
        System.Console.ForegroundColor = ConsoleColor.White
        System.Console.BackgroundColor = ConsoleColor.DarkCyan
        System.Console.WriteLine(highestGrade.ToString())
        System.Console.BackgroundColor = themeColor
        System.Console.ForegroundColor = ConsoleColor.Blue
        System.Console.Write("Lowest grade : ")
        System.Console.ForegroundColor = ConsoleColor.White
        System.Console.BackgroundColor = ConsoleColor.Blue
        System.Console.WriteLine(lowestGrade.ToString())
        System.Console.BackgroundColor = themeColor
        System.Console.ForegroundColor = ConsoleColor.Magenta
        System.Console.Write("Number of students with grades below 12 : ")
        System.Console.ForegroundColor = ConsoleColor.White
        System.Console.BackgroundColor = ConsoleColor.Magenta
        System.Console.WriteLine(countBelow12.ToString())
        System.Console.BackgroundColor = themeColor

        ' Programmer Information and GitHub ID
        System.Console.ForegroundColor = ConsoleColor.Gray
        System.Console.WriteLine("-----------------------")
        System.Console.ForegroundColor = ConsoleColor.Red
        System.Console.WriteLine("Programmer : Amin Mirzaei - Github(UserName) : AminMirzaeiOne")

        System.Console.ReadLine() ' Pause the console
    End Sub



End Module
