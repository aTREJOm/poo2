Imports System

Module Program
    Sub Main(args As String())
        Dim x As Double
        Dim tao As Double
        Dim b As Double
        Dim dt As Double
        Dim tiempo As Double


        x = 0.1
        tao = 10
        b = 1
        dt = 0.1
        tiempo = 0


        Do While tiempo < 60

            x = (tao / b * dt) + x

            Console.WriteLine(x)

            tiempo = tiempo + dt

        Loop

        Console.WriteLine("Hello World!")
    End Sub
End Module
