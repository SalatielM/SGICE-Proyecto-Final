Imports System.Security.Cryptography
Imports System.Text
Public Class SeguridadServicios
    Public Function GenerarHash(texto As String) As String

        ValidarCLave(texto)

        Dim bytes = Encoding.UTF8.GetBytes(texto)

        Dim sha = SHA256.Create()

        Dim hasHBytes = sha.ComputeHash(bytes)

        Return Convert.ToHexString(hasHBytes)

    End Function

    Public Function VerificarHas(clave As String, hash As String) As Boolean

        Dim hashgenerado = GenerarHash(clave)
        Return hashgenerado = hash

    End Function

    Private Sub ValidarCLave(clave As String)
        If String.IsNullOrWhiteSpace(clave) Then
            Throw New ExcepcionesdeNegocio("Debe escribir una contraseña")
        End If
        clave = clave.Trim()

        If clave.Length < 6 Then
            Throw New ExcepcionesdeNegocio("La contraseña debe tener minimo 6 caracteres")
        End If
        If clave.Length > 10 Then
            Throw New ExcepcionesdeNegocio("La contraseña debe tener maximo 10 caracteres")
        End If
    End Sub

End Class
