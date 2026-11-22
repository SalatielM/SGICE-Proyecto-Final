Imports BBL
Imports MODELOS

Public Class frmActivos

    Private _idactivoseleccionado As Integer = 0

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub ActualizarDGV()
        Dim servicio As New ActivoServicios()
        dgvActivos.DataSource = servicio.ObtenerTodos()
    End Sub

    Private Sub CargarActivos()
        dgvActivos.AutoGenerateColumns = False
        Dim servicio As New ActivoServicios()
        dgvActivos.DataSource = servicio.Listar()
    End Sub

    Private Sub CargarCategorias()
        Dim servicio As New CategoriaServicios()
        cmbCategoria.DataSource = servicio.ObtenerTodos()
        cmbCategoria.DisplayMember = "Nombre"
        cmbCategoria.ValueMember = "IdCategoria"
        cmbCategoria.SelectedIndex = -1
    End Sub

    Private Sub CargarSubCategoria(categoriaId As Integer)
        Dim servicio As New SubCategoriaServicios()
        Dim subcategorias = servicio.ObtenerPorCategorias(categoriaId)

        cmbSubCategoria.DataSource = subcategorias
        cmbSubCategoria.DisplayMember = "Nombre"
        cmbSubCategoria.ValueMember = "IdSubCategoria"
        cmbSubCategoria.SelectedIndex = -1
    End Sub

    Private Sub CargarEstados()
        Dim servicio As New EstadoServicios()
        cmbEstado.DataSource = servicio.ObtenerPorTipo(TipoEstadoEnum.EstadoGenerico)
        cmbEstado.DisplayMember = "Nombre"
        cmbEstado.ValueMember = "IdEstado"
        cmbEstado.SelectedIndex = -1
    End Sub

    Private Sub CargarMarcas()
        Dim servicio As New MarcaServicios()
        cmbMarca.DataSource = servicio.ObtenerTodo()
        cmbMarca.DisplayMember = "Nombre"
        cmbMarca.ValueMember = "IdMarca"
        cmbMarca.SelectedIndex = -1
    End Sub

    Private Sub CargarPersonal(puestoId)
        Dim servicio As New PersonalServicios()
        Dim personal = servicio.ObtenerPorPuestos(puestoId).
            Where(Function(d) d.EstadoId = CInt(EstadoGenerico.Activo)).
            Select(Function(d) New With {
                .IdPersonal = d.IdPersonal,
                .NombreCompleto = $"{d.Nombre} {d.Apellido}"
            }).ToList()

        cmbEncargado.DataSource = personal
        cmbEncargado.DisplayMember = "NombreCompleto"
        cmbEncargado.ValueMember = "IdPersonal"
        cmbEncargado.SelectedIndex = -1
    End Sub

    Private Sub CargarPuestoPersonal()
        Dim servicio As New PuestoServicios()
        Dim puesto = servicio.ObtenerTodos()

        cmbTipoPersonal.DataSource = puesto
        cmbTipoPersonal.ValueMember = "IdPuesto"
        cmbTipoPersonal.DisplayMember = "Nombre"
        cmbTipoPersonal.SelectedIndex = -1

    End Sub

    Private Sub CagarProveedores()
        Dim servicio As New ProveedorServicios()
        cmbProveedor.DataSource = servicio.ObtenerTodos()
        cmbProveedor.DisplayMember = "Nombre"
        cmbProveedor.ValueMember = "IdProveedor"
        cmbProveedor.SelectedIndex = -1
    End Sub

    Private Sub LimpiarCampos()
        txtNombre.Clear()
        rtxtDescipcion.Clear()

        cmbCategoria.SelectedIndex = -1
        cmbSubCategoria.SelectedIndex = -1
        cmbEncargado.SelectedIndex = -1
        cmbEstado.SelectedIndex = -1
        cmbMarca.SelectedIndex = -1
        cmbProveedor.SelectedIndex = -1
        cmbTipoPersonal.SelectedIndex = -1
    End Sub

    Private Sub ActivarCampos()
        txtNombre.ReadOnly = False
        rtxtDescipcion.ReadOnly = False

        cmbCategoria.Enabled = True
        cmbSubCategoria.Enabled = True
        cmbEncargado.Enabled = True
        cmbEstado.Enabled = True
        cmbMarca.Enabled = True
        cmbProveedor.Enabled = True
        cmbTipoPersonal.Enabled = True

        btnGuardarActualizar.Enabled = True
    End Sub

    Private Sub DesactivarCampos()
        txtNombre.ReadOnly = True
        txtNombre.BackColor = Color.White
        txtNombre.ForeColor = Color.Black
        rtxtDescipcion.ReadOnly = True
        rtxtDescipcion.BackColor = Color.White
        rtxtDescipcion.ForeColor = Color.Black

        cmbCategoria.Enabled = False
        cmbSubCategoria.Enabled = False
        cmbEncargado.Enabled = False
        cmbEstado.Enabled = False
        cmbMarca.Enabled = False
        cmbProveedor.Enabled = False
        cmbTipoPersonal.Enabled = False

        btnGuardarActualizar.Enabled = False
        btnActivarDesactivar.Enabled = False
        btnActivarDesactivar.Text = ""
        btnGuardarActualizar.Text = ""

        LimpiarCampos()
    End Sub

    Private Sub frmActivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarActivos()
        CargarMarcas()
        CargarPuestoPersonal()
        CargarEstados()
        CagarProveedores()
        DesactivarCampos()
        CargarCategorias()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        dgvActivos.ClearSelection()
        _idactivoseleccionado = 0
        ActivarCampos()
        btnActivarDesactivar.Enabled = True
        btnGuardarActualizar.Text = "Guardar"
        btnNuevo.Enabled = False
        btnGuardarActualizar.Enabled = True
        btnNuevo.Text = ""
        btnActivarDesactivar.Text = ""

        LimpiarCampos()
    End Sub

    Private Sub dgvActivos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvActivos.SelectionChanged
        LimpiarCampos()
        If dgvActivos.SelectedRows.Count = 0 Then Exit Sub
        ActivarCampos()

        Dim Fila As DataGridViewRow = dgvActivos.SelectedRows(0)
        _idactivoseleccionado = CInt(Fila.Cells("IdActivo").Value)

        txtNombre.Text = Fila.Cells("Nombre").Value.ToString()
        rtxtDescipcion.Text = Fila.Cells("Descripcion").Value.ToString()

        Dim categoriaId As Integer = CInt(Fila.Cells("CategoriaId").Value)
        Dim subCategoriaId As Integer = CInt(Fila.Cells("SubCategoriaId").Value)

        cmbCategoria.SelectedValue = categoriaId
        CargarSubCategoria(categoriaId)

        cmbSubCategoria.SelectedValue = subCategoriaId
        cmbEncargado.SelectedValue = Fila.Cells("PersonalId").Value
        cmbEstado.SelectedValue = Fila.Cells("EstadoId").Value
        cmbMarca.SelectedValue = Fila.Cells("MarcaId").Value
        cmbProveedor.SelectedValue = Fila.Cells("ProveedorId").Value

        If CInt(Fila.Cells("EstadoId").Value) = CInt(EstadoGenerico.Activo) Then
            btnActivarDesactivar.Text = "Desactivar"
        Else
            btnActivarDesactivar.Text = "Activar"
        End If

        btnGuardarActualizar.Text = "Actualizar"
        btnGuardarActualizar.Enabled = True
        btnActivarDesactivar.Enabled = True
        btnNuevo.Enabled = True
    End Sub

    Private Sub btnGuardarActualizar_Click(sender As Object, e As EventArgs) Handles btnGuardarActualizar.Click
        Try
            Dim activo As New Activo With {
                .Nombre = txtNombre.Text,
                .Descripcion = rtxtDescipcion.Text,
                .SubCategoriaId = CInt(cmbSubCategoria.SelectedValue),
                .PersonalEncargadoId = CInt(cmbEncargado.SelectedValue),
                .EstadoId = CInt(cmbEstado.SelectedValue),
                .MarcaId = CInt(cmbMarca.SelectedValue),
                .ProveedorId = CInt(cmbProveedor.SelectedValue)
             }

            Dim servicio As New ActivoServicios()
            If _idactivoseleccionado = 0 Then
                servicio.Agregar(activo)
                MessageBox.Show("Activo registrado correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                activo.IdActivo = _idactivoseleccionado
                servicio.Actualizar(activo)
                MessageBox.Show("Activo actualizado correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            CargarActivos()
            DesactivarCampos()
            btnNuevo.Enabled = True
            btnNuevo.Text = "Nuevo"
            _idactivoseleccionado = 0

        Catch ex As ExcepcionesdeNegocio
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnActivarDesactivar_Click(sender As Object, e As EventArgs) Handles btnActivarDesactivar.Click
        Try
            If _idactivoseleccionado = 0 Then
                MessageBox.Show("Debe seleccionar un activo.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim servicio As New ActivoServicios()
            Dim activo = servicio.ObtenerPorId(_idactivoseleccionado)
            Dim nuevoEstado As Integer
            Dim accion As String

            If activo.EstadoId = CInt(EstadoGenerico.Activo) Then
                nuevoEstado = CInt(EstadoGenerico.Inactivo)
                accion = "desactivar"
            Else
                nuevoEstado = CInt(EstadoGenerico.Activo)
                accion = "activar"
            End If

            Dim respuesta = MessageBox.Show($"¿Desea {accion} este activo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If respuesta = DialogResult.No Then Exit Sub

            servicio.CambiarEstado(activo.IdActivo, nuevoEstado)
            MessageBox.Show($"Activo {accion}do correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)

            CargarActivos()
            DesactivarCampos()

            btnGuardarActualizar.Text = "Guardar"
            btnNuevo.Enabled = True
            _idactivoseleccionado = 0

        Catch ex As ExcepcionesdeNegocio
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub cmbCategoria_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbCategoria.SelectionChangeCommitted
        If cmbCategoria.SelectedIndex = -1 Then
            cmbSubCategoria.DataSource = Nothing
            Exit Sub
        End If

        Dim categoriaId As Integer = CInt(cmbCategoria.SelectedValue)
        CargarSubCategoria(categoriaId)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim servicio As New ActivoServicios()
        If String.IsNullOrWhiteSpace(txtBarraBusqueda.Text) Then
            CargarActivos()
        Else
            dgvActivos.DataSource = servicio.BuscarPorNombre(txtBarraBusqueda.Text)
        End If
    End Sub

    Private Sub txtBarraBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBarraBusqueda.TextChanged
        Dim servicio As New ActivoServicios()
        If String.IsNullOrWhiteSpace(txtBarraBusqueda.Text) Then
            CargarActivos()
        Else
            dgvActivos.DataSource = servicio.BuscarPorNombre(txtBarraBusqueda.Text)
        End If
    End Sub

    Private Sub txtTipoPersonal_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbTipoPersonal.SelectionChangeCommitted
        If cmbTipoPersonal.SelectedIndex = -1 Then
            cmbEncargado.DataSource = Nothing
            Exit Sub
        End If

        Dim personalId As Integer = CInt(cmbTipoPersonal.SelectedValue)
        CargarPersonal(personalId)
    End Sub
End Class