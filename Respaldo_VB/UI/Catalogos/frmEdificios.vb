Imports BBL
Imports MODELOS

Public Class frmEdificios

    Private _idEdificioSeleccionado As Integer = 0

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub CargarEdificios()
        dgvedificio.AutoGenerateColumns = False
        Dim servicio As New EdificioServicios()
        dgvedificio.DataSource = servicio.Listar()
    End Sub

    Public Sub CargarEstados()
        Dim servicio As New EstadoServicios()
        cmbEstado.DataSource = servicio.ObtenerPorTipo(TipoEstadoEnum.EstadoGenerico)
        cmbEstado.DisplayMember = "Nombre"
        cmbEstado.ValueMember = "IdEstado"
    End Sub

    Private Sub LimpiarCampos()
        txtEdificio.Clear()
        txtCodigo.Clear()
        txtCantidaDePisos.Clear()
        rtxtdescripcion.Clear()
        dtpFechaConstruccion.Value = DateTime.Now
        cmbEstado.SelectedIndex = -1
    End Sub

    Private Sub ActivarCampos()
        txtEdificio.ReadOnly = False
        txtCodigo.ReadOnly = False
        txtCantidaDePisos.ReadOnly = False
        rtxtdescripcion.ReadOnly = False
        dtpFechaConstruccion.Enabled = True
        cmbEstado.Enabled = True
        btnGuardarActualizar.Enabled = True
    End Sub

    Private Sub DesactivarCampos()
        txtEdificio.ReadOnly = True
        txtEdificio.BackColor = Color.White
        txtEdificio.ForeColor = Color.Black
        txtCodigo.ReadOnly = True
        txtCodigo.BackColor = Color.White
        txtCodigo.ForeColor = Color.Black
        txtCantidaDePisos.ReadOnly = True
        txtCantidaDePisos.BackColor = Color.White
        txtCantidaDePisos.ForeColor = Color.Black
        rtxtdescripcion.ReadOnly = True
        rtxtdescripcion.BackColor = Color.White
        rtxtdescripcion.ForeColor = Color.Black

        dtpFechaConstruccion.Enabled = False
        cmbEstado.Enabled = False

        btnGuardarActualizar.Enabled = False
        btnActivarDesactivar.Enabled = False
        btnActivarDesactivar.Text = ""
        btnGuardarActualizar.Text = ""
        LimpiarCampos()
    End Sub

    Private Sub frmEdificios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarEstados()
        CargarEdificios()
        DesactivarCampos()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        dgvedificio.ClearSelection()
        _idEdificioSeleccionado = 0
        ActivarCampos()
        btnGuardarActualizar.Text = "Guardar"
        btnActivarDesactivar.Enabled = False
        btnNuevo.Enabled = False
        _idEdificioSeleccionado = 0
        btnNuevo.Text = ""
        btnActivarDesactivar.Text = ""
        LimpiarCampos()
    End Sub

    Private Sub btnGuardarActualizar_Click(sender As Object, e As EventArgs) Handles btnGuardarActualizar.Click
        Try
            Dim edif As New Edificio With {
                .Nombre = txtEdificio.Text,
                .CodEdificio = txtCodigo.Text,
                .CantidadPisos = txtCantidaDePisos.Text,
                .Descripcion = rtxtdescripcion.Text,
                .FechaConstruccion = dtpFechaConstruccion.Value,
                .EstadoId = CInt(cmbEstado.SelectedValue)
             }

            Dim servicio As New EdificioServicios()
            If _idEdificioSeleccionado = 0 Then
                servicio.Agregar(edif)
                MessageBox.Show("Edificio registrado correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                edif.IdEdificio = _idEdificioSeleccionado
                servicio.Actualizar(edif)
                MessageBox.Show("Edificio actualizado correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            CargarEdificios()
            DesactivarCampos()
            btnNuevo.Text = "Nuevo"
            btnNuevo.Enabled = True
            _idEdificioSeleccionado = 0
        Catch ex As ExcepcionesdeNegocio
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub dgvedificio_SelectionChanged(sender As Object, e As EventArgs) Handles dgvedificio.SelectionChanged
        If dgvedificio.SelectedRows.Count = 0 Then Exit Sub
        ActivarCampos()

        Dim Fila = dgvedificio.SelectedRows(0)
        _idEdificioSeleccionado = CInt(Fila.Cells("IdEdificio").Value)

        txtEdificio.Text = Fila.Cells("Nombre").Value.ToString
        txtCodigo.Text = Fila.Cells("CodEdificio").Value.ToString
        txtCantidaDePisos.Text = Fila.Cells("CantidadPisos").Value.ToString
        rtxtdescripcion.Text = Fila.Cells("Descripcion").Value.ToString
        Dim fechaValor = Fila.Cells("FechaConstruccion").Value

        If fechaValor IsNot Nothing AndAlso Not IsDBNull(fechaValor) AndAlso CDate(fechaValor) > #1/1/1900# Then
            dtpFechaConstruccion.Value = CDate(fechaValor)
        Else
            dtpFechaConstruccion.Value = DateTime.Now
        End If

        Dim estadoId = Fila.Cells("EstadoId").Value
        If estadoId IsNot Nothing AndAlso Not IsDBNull(estadoId) Then
            cmbEstado.SelectedValue = estadoId
        Else
            cmbEstado.SelectedIndex = -1
        End If

        btnActivarDesactivar.Text = If(CInt(Fila.Cells("EstadoId").Value) = EstadoGenerico.Activo, "Desactivar", "Activar")
        btnGuardarActualizar.Text = "Actualizar"
        btnActivarDesactivar.Enabled = True
        btnNuevo.Enabled = True
    End Sub

    Private Sub btnActivarDesactivar_Click(sender As Object, e As EventArgs) Handles btnActivarDesactivar.Click
        Try
            Dim servicio As New EdificioServicios()
            Dim entidad = servicio.ObtenerPorId(_idEdificioSeleccionado)
            Dim nuevoEstado = If(entidad.EstadoId = CInt(EstadoGenerico.Activo), CInt(EstadoGenerico.Inactivo), CInt(EstadoGenerico.Activo))
            Dim accion = If(nuevoEstado = CInt(EstadoGenerico.Activo), "activar", "desactivar")

            If MessageBox.Show($"¿Desea {accion} este edificio?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                servicio.CambiarEstado(entidad.IdEdificio, nuevoEstado)
                CargarEdificios()
                DesactivarCampos()
            End If
        Catch ex As ExcepcionesdeNegocio
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnBusqueda_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim servicio As New EdificioServicios()
        If String.IsNullOrWhiteSpace(txtBarraBusqueda.Text) Then
            CargarEdificios()
        Else
            dgvedificio.DataSource = servicio.BuscarPorNombre(txtBarraBusqueda.Text)
        End If
    End Sub

    Private Sub txtBarraBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBarraBusqueda.TextChanged
        Dim servicio As New EdificioServicios()
        If String.IsNullOrWhiteSpace(txtBarraBusqueda.Text) Then
            CargarEdificios()
        Else
            dgvedificio.DataSource = servicio.BuscarPorNombre(txtBarraBusqueda.Text)
        End If
    End Sub

End Class