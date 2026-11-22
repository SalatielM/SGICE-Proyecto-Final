Imports BBL
Imports MODELOS
Imports QuestPDF.Infrastructure

Public Class frmMenuPrincipal

    Private PanelActual As FlowLayoutPanel = Nothing
    Private PanelAbierto As FlowLayoutPanel = Nothing
    Private PanelPendiente As FlowLayoutPanel = Nothing
    Private FormularioActivo As Form = Nothing
    Private BarraLateralExpandida As Boolean = True

    Private Expandiendo As Boolean = False
    Private AlturaMaxima As Integer = 0
    Private AlturaMinima As Integer = 65
    Private Const AnchoLateralAbierto = 250
    Private Const AnchoLateralCerrado = 60

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub MenuBarraLateral()

        If BarraLateralExpandida Then

            flpBarraLateralMenu.Width = AnchoLateralCerrado
            BarraLateralExpandida = False
        Else
            flpBarraLateralMenu.Width = AnchoLateralAbierto
            BarraLateralExpandida = True

        End If

    End Sub

    Private Sub ControlMenu(Panel As FlowLayoutPanel)

        If PanelAbierto Is Panel Then
            PanelActual = Panel
            AlturaMaxima = ObtenerAlturaPanel(Panel)
            Expandiendo = False
            PanelPendiente = Nothing
            tmrMenu.Start()
            Exit Sub
        End If

        If PanelAbierto IsNot Nothing Then
            PanelPendiente = Panel
            PanelActual = PanelAbierto
            Expandiendo = False
            tmrMenu.Start()
            Exit Sub
        End If

        PanelActual = Panel
        AlturaMaxima = ObtenerAlturaPanel(Panel)
        Expandiendo = True
        tmrMenu.Start()

    End Sub

    Private Sub tmrMenu_Tick(sender As Object, e As EventArgs) Handles tmrMenu.Tick

        If PanelActual Is Nothing Then
            tmrMenu.Stop()
            Exit Sub
        End If

        If Expandiendo Then
            PanelActual.Height += 10

            If PanelActual.Height >= AlturaMaxima Then
                PanelActual.Height = AlturaMaxima
                tmrMenu.Stop()
                PanelAbierto = PanelActual
                PanelActual = Nothing
            End If

        Else
            PanelActual.Height -= 10

            If PanelActual.Height <= AlturaMinima Then
                PanelActual.Height = AlturaMinima
                tmrMenu.Stop()

                If PanelAbierto Is PanelActual Then
                    PanelAbierto = Nothing
                End If

                PanelActual = Nothing

                If PanelPendiente IsNot Nothing Then
                    Dim NuevoPanel As FlowLayoutPanel = PanelPendiente
                    PanelPendiente = Nothing

                    PanelActual = NuevoPanel
                    Expandiendo = True

                    AlturaMaxima = ObtenerAlturaPanel(NuevoPanel)

                    tmrMenu.Start()
                End If
            End If
        End If
    End Sub

    Private Sub CerrarTodosLosMenus()

        flpMenuInventario.Height = AlturaMinima
        flpMenuMovimiento.Height = AlturaMinima
        flpMenuPrestamo.Height = AlturaMinima
        flpMenuMantenimiento.Height = AlturaMinima
        flpMenuReportes.Height = AlturaMinima
        flpMenuAdministracion.Height = AlturaMinima

        PanelActual = Nothing
        PanelAbierto = Nothing
        PanelPendiente = Nothing
        Expandiendo = False

        tmrMenu.Stop()

    End Sub

    Private Sub AbrirFormularios(formHijo As Form)
        If FormularioActivo IsNot Nothing Then
            FormularioActivo.Close()
            FormularioActivo.Dispose()
        End If

        FormularioActivo = formHijo
        formHijo.TopLevel = False
        formHijo.FormBorderStyle = FormBorderStyle.None
        formHijo.Dock = DockStyle.Fill

        pnlPanelContenedor.Controls.Clear()
        pnlPanelContenedor.Controls.Add(formHijo)
        pnlPanelContenedor.Tag = formHijo

        formHijo.Show()
    End Sub

    Private Function ObtenerAlturaPanel(panel As FlowLayoutPanel) As Integer

        Dim altura As Integer = AlturaMinima

        For i As Integer = 1 To panel.Controls.Count - 1

            Dim ctrl = panel.Controls(i)

            If ctrl.Visible Then
                altura += ctrl.Height + ctrl.Margin.Top + ctrl.Margin.Bottom
            End If

        Next

        Return altura

    End Function

    Private Sub btnMenuDespliegue_Click(sender As Object, e As EventArgs) Handles btnMenuDespliegue.Click
        MenuBarraLateral()
    End Sub

    Private Sub btnMenuInventario_Click(sender As Object, e As EventArgs) Handles btnMenuInventario.Click
        ControlMenu(flpMenuInventario)
    End Sub

    Private Sub btnMenuMovimientos_Click(sender As Object, e As EventArgs) Handles btnMenuMovimientos.Click
        ControlMenu(flpMenuMovimiento)
    End Sub

    Private Sub btnMenuPrestamo_Click(sender As Object, e As EventArgs) Handles btnMenuPrestamo.Click
        ControlMenu(flpMenuPrestamo)
    End Sub

    Private Sub btnMenuMantenimiento_Click(sender As Object, e As EventArgs) Handles btnMenuMantenimiento.Click
        ControlMenu(flpMenuMantenimiento)
    End Sub

    Private Sub btnMenuAdministracion_Click(sender As Object, e As EventArgs) Handles btnMenuAdministracion.Click
        ControlMenu(flpMenuAdministracion)
    End Sub

    Private Sub CerrarBarraLateral()
        flpBarraLateralMenu.Width = AnchoLateralCerrado
        BarraLateralExpandida = False
    End Sub

    Private Sub btnActivos_Click(sender As Object, e As EventArgs) Handles btnActivos.Click
        CerrarTodosLosMenus()
        CerrarBarraLateral()
        AbrirFormularios(New frmActivos())
    End Sub

    Private Sub btnCategoria_Click(sender As Object, e As EventArgs) Handles btnCategoria.Click
        CerrarTodosLosMenus()
        CerrarBarraLateral()
        AbrirFormularios(New frmCategorias())
    End Sub

    Private Sub btnMarca_Click(sender As Object, e As EventArgs) Handles btnMarca.Click
        CerrarTodosLosMenus()
        CerrarBarraLateral()
        AbrirFormularios(New frmMarcas())
    End Sub

    Private Sub btnAreas_Click(sender As Object, e As EventArgs) Handles btnAreas.Click
        CerrarTodosLosMenus()
        CerrarBarraLateral()
        AbrirFormularios(New frmAreas())
    End Sub

    Private Sub btnEntradas_Click(sender As Object, e As EventArgs) Handles btnEntradas.Click
        CerrarTodosLosMenus()
        CerrarBarraLateral()
        AbrirFormularios(New frmEntradaActivos())
    End Sub

    Private Sub btnSalidas_Click(sender As Object, e As EventArgs) Handles btnSalidas.Click
        CerrarTodosLosMenus()
        CerrarBarraLateral()
        AbrirFormularios(New frmSalidaActivos())
    End Sub

    Private Sub btnControlActivos_Click(sender As Object, e As EventArgs) Handles btnControlActivos.Click
        CerrarTodosLosMenus()
        CerrarBarraLateral()
        AbrirFormularios(New frmActivosFisicos())
    End Sub

    Private Sub btnTraslado_Click(sender As Object, e As EventArgs) Handles btnTraslado.Click
        CerrarTodosLosMenus()
        CerrarBarraLateral()
        AbrirFormularios(New frmTrasladoActivos())
    End Sub

    Private Sub btnPrestamo_Click(sender As Object, e As EventArgs) Handles btnPrestamo.Click
        CerrarTodosLosMenus()
        CerrarBarraLateral()
        AbrirFormularios(New frmPrestamos())
    End Sub

    Private Sub btnDevolucion_Click(sender As Object, e As EventArgs) Handles btnDevolucion.Click
        CerrarTodosLosMenus()
        CerrarBarraLateral()
        AbrirFormularios(New frmDevoluciones())
    End Sub

    Private Sub btnSolicitudes_Click(sender As Object, e As EventArgs) Handles btnSolicitudes.Click
        CerrarTodosLosMenus()
        CerrarBarraLateral()
        AbrirFormularios(New frmSolicitudesMantenimiento())
    End Sub

    Private Sub btnReparaciones_Click(sender As Object, e As EventArgs) Handles btnReparaciones.Click
        CerrarTodosLosMenus()
        CerrarBarraLateral()
        AbrirFormularios(New frmMantenimiento())
    End Sub

    Private Sub btnUsuario_Click(sender As Object, e As EventArgs) Handles btnUsuario.Click
        CerrarTodosLosMenus()
        CerrarBarraLateral()
        AbrirFormularios(New frmUsuario())
    End Sub

    Private Sub btnPersonal_Click(sender As Object, e As EventArgs) Handles btnPersonal.Click
        CerrarTodosLosMenus()
        CerrarBarraLateral()
        AbrirFormularios(New frmPersonal)
    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        CerrarTodosLosMenus()
        CerrarBarraLateral()
        AbrirFormularios(New frmBackup())
    End Sub

    Private Sub btnAjustes_Click(sender As Object, e As EventArgs) Handles btnAjustes.Click
        CerrarTodosLosMenus()
        CerrarBarraLateral()
        AbrirFormularios(New frmAjustes())
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CerrarTodosLosMenus()
        CerrarBarraLateral()
        AbrirFormularios(New frmPuestos())
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        CerrarTodosLosMenus()
        CerrarBarraLateral()
        AbrirFormularios(New frmDashBoard)
    End Sub

    Private Sub frmMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirFormularios(New frmDashBoard)
        CerrarBarraLateral()
        QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community
        ConfigurarMenuPorRol()
    End Sub

    Private Sub btnMenuReportes_Click(sender As Object, e As EventArgs) Handles btnMenuReportes.Click
        CerrarTodosLosMenus()
        CerrarBarraLateral()
        AbrirFormularios(New frmReportes)
    End Sub

    Private Sub btnSubCategoria_Click(sender As Object, e As EventArgs) Handles btnSubCategoria.Click
        CerrarTodosLosMenus()
        CerrarBarraLateral()
        AbrirFormularios(New frmSubCategorias)
    End Sub

    Private Sub btnEdificios_Click(sender As Object, e As EventArgs) Handles btnEdificios.Click
        CerrarTodosLosMenus()
        CerrarBarraLateral()
        AbrirFormularios(New frmEdificios)
    End Sub

    Private Sub btnProveedores_Click(sender As Object, e As EventArgs) Handles btnProveedores.Click
        CerrarTodosLosMenus()
        CerrarBarraLateral()
        AbrirFormularios(New frmProveedores)
    End Sub

    Private Sub btnAcercaDe_Click(sender As Object, e As EventArgs) Handles btnAcercaDe.Click
        CerrarTodosLosMenus()
        CerrarBarraLateral()
        AbrirFormularios(New frmAcercaDe)
    End Sub

    Private Sub ConfigurarMenuPorRol()

        flpMenuInventario.Visible = True
        flpMenuMovimiento.Visible = True
        flpMenuPrestamo.Visible = True
        flpMenuMantenimiento.Visible = True
        flpMenuAdministracion.Visible = True
        btnMenuReportes.Visible = True

        btnEntradas.Visible = True
        btnSalidas.Visible = True
        btnControlActivos.Visible = True
        btnTraslado.Visible = True

        btnPrestamo.Visible = True
        btnDevolucion.Visible = True

        btnSolicitudes.Visible = True
        btnReparaciones.Visible = True

        btnUsuario.Visible = True
        btnPersonal.Visible = True
        btnBackup.Visible = True
        btnAjustes.Visible = True
        Button2.Visible = True

        Select Case CType(SesionActual.Usuario.RolId, EnumRol)

            Case EnumRol.Administrador

            Case EnumRol.EncargadoGeneralActivos

                flpMenuAdministracion.Visible = False

            Case EnumRol.EncargadoTraslados

                flpMenuInventario.Visible = False
                flpMenuPrestamo.Visible = False
                flpMenuMantenimiento.Visible = False
                flpMenuAdministracion.Visible = False
                flpMenuReportes.Visible = False

                btnEntradas.Visible = False
                btnSalidas.Visible = False
                btnControlActivos.Visible = False

            Case EnumRol.EncargadoMantenimiento

                flpMenuInventario.Visible = False
                flpMenuMovimiento.Visible = False
                flpMenuPrestamo.Visible = False
                flpMenuAdministracion.Visible = False
                btnMenuReportes.Visible = False

            Case EnumRol.EncargadoConsulta

                flpMenuInventario.Visible = False
                flpMenuMovimiento.Visible = False
                flpMenuPrestamo.Visible = False
                flpMenuMantenimiento.Visible = False
                flpMenuAdministracion.Visible = False

        End Select

    End Sub

    Private Sub frmMenuPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then

            Dim respuesta = MessageBox.Show("¿Desea cerrar la sesión?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If respuesta = DialogResult.No Then
                e.Cancel = True
            End If

        End If
    End Sub

End Class