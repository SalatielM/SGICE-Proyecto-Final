Imports System.Data
Imports DAO
Imports MODELOS

Public Class ReporteServicios

    Private ReadOnly _repo As New RepositorioReportes()

    Public Function ObtenerReporte(tipo As TipoReporte, filtros As ReporteFiltroDTO) As DataTable
        Return _repo.ObtenerReporte(tipo, filtros)
    End Function

End Class
