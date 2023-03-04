

Module Module1

    Sub Main()

        Dim obj As New Glass


        Dim bucle As String = "si"

        While bucle = "si" Or bucle = "SI" Or bucle = "Si" Or bucle = "sI"

            Console.WriteLine("Encrypt / Decrypt - Program")
            Console.WriteLine("Selecciona una opción")
            Console.WriteLine("1. Encriptar un texto")
            Console.WriteLine("2. Desencriptar un texto")
            Console.WriteLine("Ingresa una opcion")
            Dim opcion As Integer = Console.ReadLine()
            Console.Clear()

            Console.WriteLine("Ingresa el texto")
            Dim cadena As String = Console.ReadLine
            Console.Clear()

            If (opcion = 1) Then
                Console.WriteLine("Encrypt: " + obj.Encrypt(cadena))
            Else
                Console.WriteLine("Decrypt: " + obj.Decrypt(cadena))
            End If

            'Entrada: GitHub is the best
            'Salida: HjuIvc!jt!uif!cftu

            Console.WriteLine("¿Seguir?")
            Console.WriteLine("- Si")
            Console.WriteLine("- No")
            Console.WriteLine("Ingrese su opcion")
            bucle = Console.ReadLine()
            Console.Clear()

        End While

        Console.WriteLine("Pulsa cualquier tecla para salir")
        Console.ReadKey()

    End Sub

End Module
