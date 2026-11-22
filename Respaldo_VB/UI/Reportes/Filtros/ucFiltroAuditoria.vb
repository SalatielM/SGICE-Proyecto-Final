Imports BBL
Imports MODELOS

Public Class ucFiltroAuditoria
    Implements IFiltroReportes

    Private ReadOnly _usuarioServicios As New UsuarioServicios

    Public Sub CargarCombos() Implements IFiltroReportes.CargarCombos

        Dim usuarios = _usuarioServicios.ObtenerTodos()

        cmbUsuario.DataSource = usuarios
        cmbUsuario.DisplayMember = "Nombre"
        cmbUsuario.ValueMember = "IdUsuario"
        cmbUsuario.SelectedIndex = -1

        cmbAccion.DataSource = [Enum].GetValues(GetType(TipoAccionAuditoria))
        cmbAccion.SelectedIndex = -1

        Dim tablas As New List(Of String) From {
        "Activo",
        "Activo Fisico",
        "Auditoria",
        "Backup",
        "Categoria",
        "Centro Educativo",
        "Devolucion",
        "Director",
        "Entrada",
        "Mantenimiento",
        "Marca",
        "Personal",
        "Prestamo",
        "Puesto",
        "Salida",
        "Solicitud Mantenimiento",
        "Traslado",
        "Ubicacion",
        "Usuario"
         }

        cmbTablaAfectada.DataSource = tablas
        cmbTablaAfectada.SelectedIndex = -1

    End Sub

    Public Sub Limpiar() Implements IFiltroReportes.Limpiar

        cmbUsuario.SelectedIndex = -1
        cmbAccion.SelectedIndex = -1
        cmbTablaAfectada.SelectedIndex = -1

    End Sub

    Public Function ObtenerFiltros() As ReporteFiltroDTO Implements IFiltroReportes.ObtenerFiltros

        Dim dto As New ReporteFiltroDTO()

        dto.FechaDesde = dtpFechaDesde.Value.Date
        dto.FechaHasta = dtpFechaHasta.Value.Date

        If cmbUsuario.SelectedIndex <> -1 Then
            dto.UsuarioAuditoriaId = CInt(cmbUsuario.SelectedValue)
        End If

        If cmbAccion.SelectedIndex <> -1 Then
            dto.AccionAuditoria = CType(cmbAccion.SelectedItem, TipoAccionAuditoria)
        End If

        If cmbTablaAfectada.SelectedIndex <> -1 Then
            dto.NombreTabla = cmbTablaAfectada.Text
        End If

        Return dto

    End Function

End Class
