Imports Microsoft.VisualBasic
Imports System
'Elaborar un algoritmo que cargue programáticamente nombre de países y su dominio de país en
'una Collection. A continuación, debe permitir realizar consultas: se introduce el nombre del
'dominio y se deberá mostrar el nombre del país. Salir cuando el valor ingresado es vacío.

Module e404
    Sub Main()
        Dim dominio As String
        Dim paises As New Collection
        paises.Add("Argentina", "ar")
        paises.Add("Paraguay", "py")
        paises.Add("Brasil", "br")
        paises.Add("Inglatera", "uk")
        paises.Add("Mexico", "mx")

        Do

            Console.WriteLine("Ingrese un dominio")
            dominio = Console.ReadLine
            If dominio <> "" Then
                Console.WriteLine(paises.Item(dominio))
            End If
        Loop Until (dominio = "")

    End Sub
End Module
