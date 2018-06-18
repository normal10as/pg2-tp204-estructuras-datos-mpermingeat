Imports Microsoft.VisualBasic
Imports System
' Al ejercicio anterior agregarle las funcionalidades que permita interactivamente agregar, editar,
'eliminar y mostrar el nombre de país y su dominio. También informar la cantidad de países
'cargados.
Module e405
    Public dominio As String
    Public paises As New Collection
    Public casos As Int16
    Sub Main()

        paises.Add("Argentina", "ar")
        paises.Add("Paraguay", "py")
        paises.Add("Brasil", "br")
        paises.Add("Inglatera", "uk")
        paises.Add("Mexico", "mx")



        Select Case casos
            Case 1
                Agregar()
            Case 2
            Case 3
            Case 4
                Mostrar()
        End Select
    End Sub
    Sub Agregar()
        Dim pais As String
        Dim domin As String

        Do
            Console.WriteLine("Ingrese el pais")
            pais = Console.ReadLine
            If pais <> "" Then
                Console.WriteLine("Dominio")
                domin = Console.ReadLine
                paises.Add(pais, domin)
            End If
        Loop Until (pais = "")
        Main()
    End Sub
    Sub Mostrar()
        For Each pais In paises
            Console.WriteLine("{0}, {1}", pais)
        Next
    End Sub
End Module
