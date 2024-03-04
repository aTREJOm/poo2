Imports System

Module Program
    Sub Main(args As String())

        Dim ph As Integer


        Console.WriteLine("Cual es el valor de ph?")
        ph = Console.ReadLine()

        If ph < 7 Then
            Console.WriteLine("es acido!!")

            If ph > 0 And ph <= 3 Then
                Console.WriteLine("añadir 2 tasas de NaHCO3")

            End If

        End If

        If ph < 7 And ph >= 4 Then
            Console.WriteLine("añadir 1 tasa de NaHCO3")

        End If



        If ph > 7 Then
            Console.WriteLine("es una base!!")


            If ph >= 8 And ph <= 10 Then
                Console.WriteLine("añadir 50 ml de H2SO4")

            End If

            If ph >= 11 And ph <= 14 Then
                Console.WriteLine("añadir 100 ml de H2SO4")

            End If


        End If



        If ph = 7 Then
            Console.WriteLine("es neutro")
        End If

        If ph > 14 Then
            Console.WriteLine("fuera de rango")
        End If

        If ph < 0 Then
            Console.WriteLine("fuera de rango")
        End If
    End Sub
End Module
