Imports Microsoft.VisualBasic
Imports System
'Se tiene tres arrays cargados programáticamente con una lista de productos: el primero tiene el
'código, el segundo el nombre y el tercero el precio unitario. Repetitivamente se ingresa un
'código de producto y el programa muestra su descripción y precio, luego el usuario ingresa la
'cantidad con lo que el programa responde calculando el total del producto y el total general
'(acumulando los productos anteriores). Esto sucede hasta que el código sea cero.

Module e402
    Sub Main()
        Dim codigos = New Integer() {1, 2, 3, 4}
        Dim productos = New String() {"fafa", "frula", "albaca", "papota"}
        Dim precios = New Decimal() {50, 10, 30, 40}
        Dim cod As Int16
        Dim index As Int16
        Dim cantidad As Int16
        Dim total As Decimal
        Dim subtotal As Decimal
        Console.WriteLine("Ingrese el Codigo de Producto deseado (0 - para terminar): ")
        For x = 0 To codigos.Length - 1
            Console.WriteLine("Codigo: {0} - Producto: {1} ", codigos(x), productos(x))
        Next
        Do
            cod = Console.ReadLine
            If cod <> 0 Then
                index = cod - 1
                Console.WriteLine("Descripcion la {0} es buena, Precio Unitario {1}", productos(index), precios(index))
                Console.WriteLine("Ingrese la cantidasd deseada: ")
                cantidad = Console.ReadLine
                subtotal = cantidad * precios(index)
                Console.WriteLine("Subtotal: {0}", subtotal)
                total += subtotal
                Console.WriteLine("total de la compra: {0}", total)
                Console.WriteLine("Ingrese el Codigo de Producto deseado (0 - para terminar): ")
            End If
        Loop Until cod = 0
    End Sub
End Module
