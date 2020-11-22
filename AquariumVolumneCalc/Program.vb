Imports System

Module Program
    Sub Main(args As String())
        'Declare the vars vor the calculation
        Dim Width As Decimal = 0
        Dim Height As Decimal = 0
        Dim Depth As Decimal = 0
        Dim Volumne As Decimal = 0
        Dim Litres As Integer = 1000

        'Ask user for input
        Console.WriteLine("Enter the valuse for the calculation in centimeter!")
        Console.WriteLine("Width: ")
        Width = Console.ReadLine()
        Console.WriteLine("Height: ")
        Height = Console.ReadLine()
        Console.WriteLine("Depth: ")
        Depth = Console.ReadLine()

        'Perform the calculation
        Volumne = (Width * Height * Depth) / Litres

        'Output the volumne to the console
        Console.WriteLine("The aquarium has a volumne of " & Volumne & " litres.")

        'ReadKey to pause the console output
        Console.ReadKey()
    End Sub
End Module
