Public Class Glass

    Function Encrypt(texto As String) As String

        Dim arreglo() As Char = texto.ToCharArray()
            Dim string_completo As String = ""

            For contador As Integer = 0 To (arreglo.Length - 1)

                Dim caracter As Integer
                caracter = Asc(arreglo(contador))
            Dim nuevo_caracter = caracter + 1

            Dim caracter2 As String
                caracter2 = Chr(nuevo_caracter)
                string_completo &= caracter2

            Next

        Return string_completo

    End Function


    Function Decrypt(texto As String) As String

        Dim arreglo() As Char = texto.ToCharArray()
        Dim string_completo As String = ""

        For contador As Integer = 0 To (arreglo.Length - 1)

            Dim caracter As Integer
            caracter = Asc(arreglo(contador))
            Dim nuevo_caracter = caracter - 1
            Dim caracter2 As String
            caracter2 = Chr(nuevo_caracter)

            string_completo &= caracter2

        Next

        Return string_completo
    End Function


End Class
