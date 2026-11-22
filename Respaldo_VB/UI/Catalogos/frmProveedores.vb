Imports BBL
Imports MODELOS

Public Class frmProveedores

    Private _idProveedorSeleccionado As Integer = 0

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargarProveedores()
            CargarEstados()
            DesactivarCampos()
        Catch ex As Exception
            MessageBox.Show("Error al cargar proveedores: " & ex.Message)
        End Try
    End Sub

    Private Sub CargarProveedores()
        Try
            dgvProveedor.AutoGenerateColumns = False
            Dim servicio As New ProveedorServicios()
            dgvProveedor.DataSource = servicio.Listar()
        Catch ex As Exception
            MessageBox.Show("Error en CargarGrid: " & ex.ToString())
        End Try
    End Sub

    Private Sub CargarEstados()
        Dim servicio As New EstadoServicios()
        cmbEstado.DataSource = servicio.ObtenerPorTipo(TipoEstadoEnum.EstadoGenerico)
        cmbEstado.DisplayMember = "Nombre"
        cmbEstado.ValueMember = "IdEstado"
    End Sub

    Private Sub LimpiarCampos()
        txtNombre.Clear()
        txtRNC.Clear()
        txtTelefono.Clear()
        txtCorreo.Clear()
        txtDireccion.Clear()
        txtPersonaDeContacto.Clear()
        txtTelefonoContacto.Clear()
        cmbEstado.SelectedIndex = -1
    End Sub

    Private Sub ActivarCampos()
        txtNombre.ReadOnly = False
        txtRNC.ReadOnly = False
        txtTelefono.ReadOnly = False
        txtCorreo.ReadOnly = False
        txtDireccion.ReadOnly = False
        txtPersonaDeContacto.ReadOnly = False
        cmbEstado.Enabled = True
        btnGuardarActualizar.Enabled = True
    End Sub

    Private Sub DesactivarCampos()
        txtNombre.ReadOnly = True
        txtNombre.BackColor = Color.White
        txtNombre.ForeColor = Color.Black
        txtRNC.ReadOnly = True
        txtRNC.BackColor = Color.White
        txtRNC.ForeColor = Color.Black
        txtTelefono.ReadOnly = True
        txtTelefono.ForeColor = Color.Black
        txtTelefono.BackColor = Color.White
        txtCorreo.ReadOnly = True
        txtCorreo.BackColor = Color.White
        txtCorreo.ForeColor = Color.Black
        txtDireccion.ReadOnly = True
        txtDireccion.BackColor = Color.White
        txtDireccion.ForeColor = Color.Black
        txtPersonaDeContacto.ReadOnly = True
        txtPersonaDeContacto.BackColor = Color.White
        txtPersonaDeContacto.ForeColor = Color.Black

        cmbEstado.Enabled = False
        btnGuardarActualizar.Enabled = False
        btnActivarDesactivar.Enabled = False
        btnActivarDesactivar.Text = ""
        btnGuardarActualizar.Text = ""
        LimpiarCampos()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        dgvProveedor.ClearSelection()
        _idProveedorSeleccionado = 0
        ActivarCampos()
        btnGuardarActualizar.Text = "Guardar"
        btnNuevo.Text = ""
        btnActivarDesactivar.Text = ""
        btnNuevo.Enabled = False
    End Sub

    Private Sub btnGuardarActualizar_Click(sender As Object, e As EventArgs) Handles btnGuardarActualizar.Click
        Try
            Dim prov As New Proveedor With {
                .Nombre = txtNombre.Text,
                .RNC = txtRNC.Text,
                .Telefono = txtTelefono.Text,
                .Correo = txtCorreo.Text,
                .Direccion = txtDireccion.Text,
                .PersonalContacto = txtPersonaDeContacto.Text,
                .TelefonoContacto = txtTelefonoContacto.Text,
                .EstadoId = CInt(cmbEstado.SelectedValue)
            }

            Dim servicio As New ProveedorServicios()
            If _idProveedorSeleccionado = 0 Then
                servicio.Agregar(prov)
                MessageBox.Show("Proveedor registrado correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                prov.IdProveedor = _idProveedorSeleccionado
                servicio.Actualizar(prov)
                MessageBox.Show("Proveedor actualizado correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            CargarProveedores()
            DesactivarCampos()
            btnNuevo.Enabled = True
            btnNuevo.Text = "Nuevo"
        Catch ex As ExcepcionesdeNegocio
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " & ex.Message)
        End Try
    End Sub

    Private Sub dgvProveedor_SelectionChanged(sender As Object, e As EventArgs) Handles dgvProveedor.SelectionChanged
        If dgvProveedor.SelectedRows.Count = 0 Then Exit Sub

        Dim fila = dgvProveedor.SelectedRows(0)
        _idProveedorSeleccionado = CInt(fila.Cells("IdProveedor").Value)

        txtNombre.Text = If(fila.Cells("Nombre").Value, "").ToString()
        txtRNC.Text = If(fila.Cells("RNC").Value, "").ToString()
        txtTelefono.Text = If(fila.Cells("Telefono").Value, "").ToString()
        txtCorreo.Text = If(fila.Cells("Correo").Value, "").ToString()
        txtDireccion.Text = If(fila.Cells("Direccion").Value, "").ToString()
        txtTelefonoContacto.Text = If(fila.Cells("TelefonoContacto").Value, "").ToString()
        txtPersonaDeContacto.Text = If(fila.Cells("PersonalContacto").Value, "").ToString()

        If fila.Cells("EstadoId").Value IsNot Nothing Then
            cmbEstado.SelectedValue = fila.Cells("EstadoId").Value
        Else
            cmbEstado.SelectedIndex = -1
        End If

        ActivarCampos()
        btnGuardarActualizar.Text = "Actualizar"
        btnActivarDesactivar.Enabled = True
        btnNuevo.Enabled = True
    End Sub

    Private Sub btnActivarDesactivar_Click(sender As Object, e As EventArgs) Handles btnActivarDesactivar.Click
        Try
            Dim servicio As New ProveedorServicios()
            Dim proveedor = servicio.ObtenerPorId(_idProveedorSeleccionado)
            Dim nuevoEstado = If(proveedor.EstadoId = EstadoGenerico.Activo, EstadoGenerico.Inactivo, EstadoGenerico.Activo)
            Dim accion = If(proveedor.EstadoId = EstadoGenerico.Activo, "desactivar", "activar")

            If MessageBox.Show($"¿Desea {accion} esta proveedor?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                servicio.CambiarEstado(proveedor.IdProveedor, CInt(nuevoEstado))
                CargarProveedores()
                DesactivarCampos()
            End If
        Catch ex As ExcepcionesdeNegocio
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim servicio As New ProveedorServicios()
        If String.IsNullOrWhiteSpace(txtBarraBusqueda.Text) Then
            CargarProveedores()
        Else
            dgvProveedor.DataSource = servicio.BuscarPorNombre(txtBarraBusqueda.Text)
        End If
    End Sub

    Private Sub txtBarraBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBarraBusqueda.TextChanged
        Dim servicio As New ProveedorServicios()
        If String.IsNullOrWhiteSpace(txtBarraBusqueda.Text) Then
            CargarProveedores()
        Else
            dgvProveedor.DataSource = servicio.BuscarPorNombre(txtBarraBusqueda.Text)
        End If
    End Sub

End Class