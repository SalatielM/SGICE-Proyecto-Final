Imports BBL
Imports MODELOS

Public Class frmDashBoard

    Private ReadOnly _activoFisicoServicios As New ActivoFisicoServicios()
    Private ReadOnly _prestamoServicios As New PrestamoServicios()
    Private ReadOnly _solicitudMantenimientoServicios As New SolicitudMantenimientoServicios()
    Private ReadOnly _personalServicios As New PersonalServicios()
    Private ReadOnly _usuarioServicios As New UsuarioServicios()
    Private ReadOnly _ubicacionServicios As New UbicacionServicios()
    Private ReadOnly _sesionActual As New SesionActual()

    Private Sub frmDashBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarResumen()
        Timer1.Start()
    End Sub

    Private Sub CargarResumen()

        lblTotalActivos.Text = _activoFisicoServicios.Contar().ToString()
        lblActivosDisponibles.Text = _activoFisicoServicios.ContarPorEstado(CInt(EstadoActivoFisico.Disponible)).ToString()
        lblActivosDanados.Text = _activoFisicoServicios.ContarPorEstado(CInt(EstadoActivoFisico.Dañado)).ToString()
        lblActivosPerdidos.Text = _activoFisicoServicios.ContarPorEstado(CInt(EstadoActivoFisico.Extraviado)).ToString()

        lblPrestamoPendiente.Text = _prestamoServicios.ContarPorEstado(CInt(EstadoPrestamo.Vigente)).ToString()
        lblPrestamoVencido.Text = _prestamoServicios.ContarPorEstado(CInt(EstadoPrestamo.Vencido)).ToString()

        lblSolicitudPendiente.Text = _solicitudMantenimientoServicios.ContarPorEstado(CInt(EstadoSolicitudMantenimiento.Pendiente)).ToString()

        lblTotalUbicaciones.Text = _ubicacionServicios.Contar().ToString()
        lblTotalUsuario.Text = _usuarioServicios.ContarPorEstado(CInt(EstadoGenerico.Activo)).ToString
        lblTotalPersonal.Text = _personalServicios.ContarPorEstado(CInt(EstadoGenerico.Activo)).ToString
        lblUsuarioLoguaado.Text = SesionActual.Usuario.Nombre & " " & SesionActual.Usuario.Apellido
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblFecha.Text = Date.Today.ToString("dd/MM/yyyy")
        lblHora.Text = Date.Now.ToString("hh:mm tt")
    End Sub

End Class