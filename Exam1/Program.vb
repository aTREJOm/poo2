Imports System

Module Program

    Sub Main(args As String())
        Console.WriteLine("Nombre: TREJO MENDEZ ARON")
        Console.WriteLine("Fecha: 21/03/2024")
        Console.WriteLine("grupo: 6TV65")
        Console.WriteLine("Examen poo")
        Console.WriteLine("titulo De hilo")
        Console.WriteLine("clase prenda")

        Dim titulo = 10
        Dim lon = 5
        Dim peso = 5

        Do While titulo = 10


            Console.WriteLine("cuanto pesa tu hilo")
            peso = Console.ReadLine()
            Console.WriteLine("cuanto mide tu hilo")
            lon = Console.ReadLine()
            Console.WriteLine(peso * lon)
            titulo = (peso * lon)


        Loop


    End Sub



    Public Class prendas

        Private numpantalones As Double
        Private numcamisas As Double
        Private numvestidos As Double
        Private numplayeras As Double
        Private numbermudas As Double
        Private haycalcetines As Boolean

        Public Sub inicializar()
            Console.WriteLine("cuantos pantalones hay?")
            numpantalones = Console.ReadLine()
            Console.WriteLine("cuantas camisas hay?")
            numcamisas = Console.ReadLine()
            Console.WriteLine("cuantos vesatidos hay?")
            numvestidos = Console.ReadLine()
            Console.WriteLine("cuantas playeras hay?")
            numplayeras = Console.ReadLine()
            Console.WriteLine("cuantas bermudas hay?")
            numbermudas = Console.ReadLine()
            Console.WriteLine("tambien tienes calcetines?")
            haycalcetines = Console.ReadLine()


        End Sub


        Public Sub imprimir()
            Console.WriteLine("pantalones: ")
            Console.WriteLine(numpantalones)
            Console.WriteLine("camisas: ")
            Console.WriteLine(numcamisas)
            Console.WriteLine("vestidos: ")
            Console.WriteLine(numvestidos)
            Console.WriteLine("playeras:")
            Console.WriteLine(numplayeras)
            Console.WriteLine("bermudas")
            Console.WriteLine(numbermudas)
            Console.WriteLine("calcetines: ")
            Console.WriteLine(haycalcetines)
        End Sub




    End Class


End Module

