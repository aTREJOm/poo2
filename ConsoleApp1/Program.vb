Imports System

Module Program
    Public Class animales
        Private numpatas As Double
        Private numojos As Double
        Private dientes As Double
        Private pelo As Boolean
        Private nombre As String
        Private comestible As Boolean
        Private vida As Integer


        Public Sub inicializar()
            Console.WriteLine("cuantas patas tiene?")
            numpatas = Console.ReadLine()
            Console.WriteLine("cuantos ojos tiene?")
            numojos = Console.ReadLine()
            Console.WriteLine("cuantos dientes tiene?")
            dientes = Console.ReadLine()
            Console.WriteLine("tiene pelo?")
            pelo = Console.ReadLine()
            Console.WriteLine("como se llama?")
            nombre = Console.ReadLine()
            Console.WriteLine("es comestible?")
            comestible = Console.ReadLine()
            Console.WriteLine("este animal tiene 100 de vida")
            vida = 100

        End Sub


        Public Sub imprimir()
            Console.WriteLine("patas: ")
            Console.WriteLine(numpatas)
            Console.WriteLine("ojos: ")
            Console.WriteLine(numojos)
            Console.WriteLine("dientes: ")
            Console.WriteLine(dientes)
            Console.WriteLine("pelo:")
            Console.WriteLine(pelo)
            Console.WriteLine("como se llama?")
            Console.WriteLine(nombre)
            Console.WriteLine("comestible: ")
            Console.WriteLine(comestible)
        End Sub

        Public Sub golpe()
            vida = vida - 10
            Console.WriteLine("le queda de vida:")
            Console.WriteLine(vida)


        End Sub

        Public Sub posion()
            vida = vida + 50
            Console.WriteLine("le queda de vida:")
            Console.WriteLine(vida)


        End Sub
    End Class

    Sub Main(args As String())

        Dim kanguro As New animales()
        Dim araña As New animales()
        Dim gato As New animales()

        kanguro.inicializar()
        kanguro.imprimir()
        kanguro.golpe()
        kanguro.golpe()
        kanguro.golpe()
        kanguro.golpe()
        kanguro.golpe()
        kanguro.golpe()
        kanguro.golpe()
        kanguro.posion()


        araña.inicializar()
        araña.imprimir()
        araña.golpe()
        araña.golpe()
        araña.golpe()
        araña.golpe()
        araña.golpe()
        araña.golpe()
        araña.golpe()
        araña.posion()


        gato.inicializar()
        gato.imprimir()
        gato.golpe()
        gato.golpe()
        gato.golpe()
        gato.golpe()
        gato.golpe()
        gato.golpe()
        gato.golpe()
        gato.golpe()
        gato.posion()





    End Sub


End Module
