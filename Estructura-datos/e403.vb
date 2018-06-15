Imports Microsoft.VisualBasic
Imports System
'Crear un algoritmo que utilice arrays para almacenar las notas (0 a 10) de una serie de alumnos.
' Primero ingresar la cantidad de alumnos y la cantidad de notas que tiene cada uno con un
'máximo de 40 alumnos y 4 notas.
' Iterativamente ingresar el nombre de un alumno y sus notas y validar que tenga un nombre
'y que no sea repetido y el rango de la nota.
' Al completar la iteración informar por cada alumno el promedio, si aprobó o desaprobó
'teniendo en cuenta que aprueba con 6 o más.
' También informar quien es el mejor alumno (puede haber más de uno).
' Implementar procedimientos para resolver al menos las siguientes tareas:
' Uno para validad el nombre no sea vacío
' uno que valide la inexistencia de un nombre igual
' uno que valide el rango de la nota
' uno que determine el promedio
' uno que escriba si el alumno aprobó o no
' uno que devuelva la lista de mejores alumnos

Module e403
    Public alumnos(39) As String
    Public notas(39, 4) As Decimal
    Public cantidad As Int16
    Public cantnota As Int16
    Public alumno As String

    Sub Main()

        Console.WriteLine("Ingrese la Cantidad de alumnos")
        cantidad = Console.ReadLine
        cantidad = cantidad - 1
        Console.WriteLine("Ingrese la Cantidad de notas")
        cantnota = Console.ReadLine
        cantnota = cantnota - 1

        For c = 0 To cantidad
            Console.WriteLine("Ingrese el Nombre del alumno")
            Do
                alumno = Console.ReadLine
            Loop Until NombreVacio(alumno) = True And NombreRepe(alumno, c) = True
            alumnos(c) = alumno
            For cn = 0 To cantnota
                Console.WriteLine("Ingrese la notas ")
                Do
                    notas(c, cn) = Console.ReadLine
                Loop Until validarNota(notas(c, cn)) = True
            Next
        Next
        Promedio()
        MejorAlumno()
    End Sub

    Private Function NombreVacio(nombre As String) As Boolean
        If nombre = "" Then
            Console.WriteLine("Nombre en blanco, ingrese un nombre de alumno")
            Return False
        Else
            Return True
        End If
    End Function
    Private Function NombreRepe(nombre As String, b As Int16) As Boolean
        Dim x As Int16 = 0
        Do
            If nombre = alumnos(x) And nombre <> "" Then
                Console.WriteLine("Nombre repetido, ingrese un nombre de alumno")
                Return False
            End If
            x += 1
        Loop Until nombre = alumnos(x) Or x >= b
        Return True
    End Function
    Private Function validarNota(nota As Decimal) As Boolean
        If nota > 0 And nota <= 10 Then
            Return True
        Else
            Console.WriteLine("Nota fuera de rango, ingrese una nota de 1 a 10")
            Return False
        End If
    End Function
    Private Function Estado(a As Decimal) As String
        If a >= 6 Then
            Return "Aprobado"
        ElseIf a < 6 Then
            Return "Desaprobado"
        End If
    End Function
    Sub Promedio()
        Dim sumatoria As Decimal
        Dim divisor As Int16
        For estu = 0 To cantidad
            sumatoria = 0
            divisor = 0
            For index = 0 To cantnota
                sumatoria += notas(estu, cantnota)
                divisor += 1
            Next
            notas(estu, 4) = sumatoria / divisor
            Console.WriteLine("Alunmo {0}   Promedio = {1}  Estado = {2}", alumnos(estu), notas(estu, 4), Estado(notas(estu, 4)))
        Next
    End Sub
    Sub MejorAlumno()
        Dim mejornota As Decimal
        Dim mejoralumno As Int16
        For estu = 0 To cantidad
            If notas(estu, 4) > mejornota Then
                mejornota = notas(estu, 4)
                mejoralumno = estu
            End If
        Next
        Console.WriteLine("------------------------------------------------------------")
        Console.WriteLine("Mejor Alunmo {0}  Mejor Promedio = {1} ", alumnos(mejoralumno), mejornota)
        Console.WriteLine("------------------------------------------------------------")
    End Sub
End Module
