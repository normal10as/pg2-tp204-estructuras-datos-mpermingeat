Imports Microsoft.VisualBasic
Imports System

Module e401

    Sub Main()
        Dim numeros(4) As Int16
        Dim sumatoria As Int16 = 0
        Dim medias As Double
        For x = 0 To numeros.Length - 1
            Console.WriteLine("Ingrese un numero: ")
            numeros(x) = Console.ReadLine
            sumatoria += numeros(x)
        Next
        medias = Media(sumatoria, numeros.Length)
        Console.WriteLine("Media = {0}", medias)

        For Each numero As Int16 In numeros
            Console.WriteLine("El numero es {0}", numero)
            Console.WriteLine("La desviacion es {0}", numero - medias)
        Next
    End Sub

    Private Function Media(ByVal a As Int16, ByVal b As Int16) As Double
        Return a / b
    End Function
End Module
