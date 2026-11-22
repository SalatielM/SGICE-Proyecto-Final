Imports MODELOS

Public NotInheritable Class SesionActual

    Private Shared _usuario As Usuario
    Public Shared Property ReiniciarSesion As Boolean = False

    Public Shared ReadOnly Property Usuario As Usuario

        Get
            Return _usuario
        End Get

    End Property

    Public Shared ReadOnly Property ExisteSesion As Boolean

        Get
            Return _usuario IsNot Nothing
        End Get

    End Property

    Public Shared Sub IniciarSesion(usuario As Usuario)

        If usuario Is Nothing Then
            Throw New ArgumentNullException(NameOf(usuario))
        End If

        If ExisteSesion Then
            Throw New ExcepcionesdeNegocio("Ya existe una sesion iniciada")
        End If

        _usuario = usuario

    End Sub

    Public Shared Sub CerrarSesion()

        _usuario = Nothing

    End Sub

End Class
