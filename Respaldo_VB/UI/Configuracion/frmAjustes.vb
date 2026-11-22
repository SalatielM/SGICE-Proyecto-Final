Imports BBL
Imports MODELOS
Imports System.Text.Json

Public Class frmAjustes

    Private _iddirectorseleccionado As Integer = 0
    Private _latitud As Double
    Private _longitud As Double

    Public Sub New()
        InitializeComponent()

    End Sub

    Private Async Sub frmAjustes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDirectorCentro()
        CargarDirector()
        CargarEstado()
        DesactivarCampos()

        Await wvMapa.EnsureCoreWebView2Async()

        AddHandler wvMapa.CoreWebView2.WebMessageReceived, AddressOf RecibirCoordenadas

        AddHandler wvMapa.CoreWebView2.NavigationCompleted,
            Async Sub(s, args)
                CargarCentro()
                Await EnviarUbicacionAlMapa()
            End Sub

        Dim ruta As String = IO.Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            "Recursos",
            "Mapa",
            "mapa.html")

        wvMapa.Source = New Uri(ruta)
    End Sub

    Private Sub CargarDirectorCentro()
        Dim servicio As New DirectorServicios()
        Dim listaa = servicio.ObtenerTodos().
            Where(Function(d) d.EstadoId = CInt(EstadoGenerico.Activo)).
                Select(Function(d) New With {
                .IdDirector = d.IdDirector,
                .NombreCompleto = $"{d.Nombre} {d.Apellido}"
            }).ToList()

        cmbDirector.DataSource = listaa
        cmbDirector.DisplayMember = "NombreCompleto"
        cmbDirector.ValueMember = "IdDirector"

        cmbDirector.SelectedIndex = -1
    End Sub

    Private Sub LimpiarCampos()
        txtNombre.Clear()
        txtApellido.Clear()
        txtCedula.Clear()
        txtCodigoCentro.Clear()
        txtTelefono.Clear()
        picFotoDirector.Image = Nothing
        cmbEstado.SelectedIndex = -1
    End Sub

    Private Sub btnGuardarActualizar_Click(sender As Object, e As EventArgs) Handles btnGuardarActualizar.Click
        Try
            Dim centro As New CentroEducativo With {
                .CodCentro = txtCodigoCentro.Text,
                .Nombre = txtNombreCentro.Text,
                .Modalidad = txtModalidad.Text,
                .Jornada = txtJornada.Text,
                .DirectorId = CInt(cmbDirector.SelectedValue),
                .Telefono = txtTelefono.Text,
                .Correo = txtCorreo.Text,
                .Direccion = txtDireccion.Text,
                .DistritoEducativo = txtDistritoEducativo.Text,
                .RegionalEducativo = txtRegionaleducativo.Text,
                .Foto = ManejoDeFotos.ImagenABytes(picFotoEscuela.Image),
                .Latitud = _latitud,
                .Longitud = _longitud
            }

            Dim servicio As New CentroEducativoServicios()
            servicio.Guardarcentro(centro)

            MessageBox.Show("Informacion del centro guardada correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As ExcepcionesdeNegocio
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Async Sub CargarCentro()
        Dim servicio As New CentroEducativoServicios()
        Dim centro = servicio.ObtenerInfoCentro()

        If centro Is Nothing OrElse centro.IdCentroEducativo = 0 Then Exit Sub

        txtCodigoCentro.Text = centro.CodCentro
        txtNombreCentro.Text = centro.Nombre
        txtModalidad.Text = centro.Modalidad
        txtJornada.Text = centro.Jornada
        cmbDirector.SelectedValue = centro.DirectorId
        txtTelefono.Text = centro.Telefono
        txtCorreo.Text = centro.Correo
        txtDireccion.Text = centro.Direccion
        txtDistritoEducativo.Text = centro.DistritoEducativo
        txtRegionaleducativo.Text = centro.RegionalEducativo

        If centro.Foto IsNot Nothing Then
            picFotoEscuela.Image = ManejoDeFotos.BytesAImagen(centro.Foto)
        End If

        _latitud = centro.Latitud
        _longitud = centro.Longitud

        Await EnviarUbicacionAlMapa()
    End Sub

    Private Sub RecibirCoordenadas(sender As Object, e As Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs)
        Dim json As String = e.WebMessageAsJson
        Dim datos = JsonSerializer.Deserialize(Of Dictionary(Of String, Double))(json)
        _latitud = datos("latitud")
        _longitud = datos("longitud")
    End Sub

    Private Async Function EnviarUbicacionAlMapa() As Task
        If _latitud = 0 OrElse _longitud = 0 Then Return

        Await wvMapa.CoreWebView2.ExecuteScriptAsync(
            $"setUbicacion({_latitud.ToString(System.Globalization.CultureInfo.InvariantCulture)}, {_longitud.ToString(System.Globalization.CultureInfo.InvariantCulture)});")
    End Function

    Private Sub btnAgregarFoto_Click(sender As Object, e As EventArgs) Handles btnAgregarFoto.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim ruta As String = OpenFileDialog1.FileName
            picFotoEscuela.Image = Image.FromFile(ruta)
            picFotoEscuela.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub

    '___________________________________________________________________________________________________________________________________________________________________________________________________

    Private Sub CargarDirector()
        Dim servicio As New DirectorServicios()
        dgvDirector.AutoGenerateColumns = False
        dgvDirector.DataSource = servicio.Listar()
    End Sub

    Private Sub CargarEstado()
        Dim servicio As New EstadoServicios()
        cmbEstado.DataSource = servicio.ObtenerPorTipo(TipoEstadoEnum.EstadoGenerico)
        cmbEstado.DisplayMember = "Nombre"
        cmbEstado.ValueMember = "IdEstado"
        cmbEstado.SelectedIndex = -1
    End Sub

    Private Sub LimpiarCamposDirector()
        txtNombre.Clear()
        txtApellido.Clear()
        txtCedula.Clear()
        txtCorreoDirector.Clear()
        txtTelefonoDirector.Clear()
        cmbEstado.SelectedIndex = -1
    End Sub

    Private Sub ActivarCampos()
        txtNombre.ReadOnly = False
        txtApellido.ReadOnly = False
        txtCedula.ReadOnly = False
        txtCorreoDirector.ReadOnly = False
        txtTelefonoDirector.ReadOnly = False
        cmbEstado.Enabled = True
        btnActualizarGuardar.Enabled = True
    End Sub

    Private Sub DesactivarCampos()
        txtNombre.ReadOnly = True
        txtNombre.BackColor = Color.White
        txtNombre.ForeColor = Color.Black
        txtApellido.ReadOnly = True
        txtApellido.BackColor = Color.White
        txtApellido.ForeColor = Color.Black
        txtCedula.ReadOnly = True
        txtCedula.BackColor = Color.White
        txtCedula.ForeColor = Color.Black
        txtCorreoDirector.ReadOnly = True
        txtCorreoDirector.BackColor = Color.White
        txtCorreoDirector.ForeColor = Color.Black
        txtTelefonoDirector.ReadOnly = True
        txtTelefonoDirector.BackColor = Color.White
        txtTelefonoDirector.ForeColor = Color.Black

        cmbEstado.Enabled = False
        btnActualizarGuardar.Enabled = False
        LimpiarCamposDirector()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        dgvDirector.ClearSelection()
        ActivarCampos()
        btnActualizarGuardar.Text = "Guardar"
        btnActivarDesactivar.Enabled = False
        btnNuevo.Enabled = False
        LimpiarCamposDirector()
    End Sub

    Private Sub dgvDirector_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDirector.SelectionChanged
        If dgvDirector.SelectedRows.Count = 0 Then Exit Sub

        Dim fila As DataGridViewRow = dgvDirector.SelectedRows(0)
        If fila.DataBoundItem Is Nothing Then Exit Sub

        LimpiarCamposDirector()
        ActivarCampos()

        Dim director As DirectorDTO = CType(fila.DataBoundItem, DirectorDTO)
        picFotoDirector.Image = ManejoDeFotos.BytesAImagen(director.Foto)

        _iddirectorseleccionado = CInt(fila.Cells("IdDirector").Value)

        txtNombre.Text = fila.Cells("Nombre").Value.ToString()
        txtApellido.Text = fila.Cells("Apellido").Value.ToString()
        txtCedula.Text = fila.Cells("Cedula").Value.ToString()
        txtCorreoDirector.Text = fila.Cells("Correo").Value.ToString()
        txtTelefonoDirector.Text = fila.Cells("Telefono").Value.ToString()

        cmbEstado.SelectedValue = fila.Cells("EstadoId").Value
        If CInt(fila.Cells("EstadoId").Value) = CInt(EstadoGenerico.Activo) Then
            btnActivarDesactivar.Text = "Desactivar"
        Else
            btnActivarDesactivar.Text = "Activar"
        End If

        btnActualizarGuardar.Text = "Actualizar"
        btnActivarDesactivar.Enabled = True
        btnNuevo.Enabled = True
    End Sub

    Private Sub btnActualizarGuardar_Click(sender As Object, e As EventArgs) Handles btnActualizarGuardar.Click
        Try
            Dim director As New Director With {
                .Nombre = txtNombre.Text,
                .Apellido = txtApellido.Text,
                .Cedula = txtCedula.Text,
                .Telefono = txtTelefonoDirector.Text,
                .Correo = txtCorreoDirector.Text,
                .EstadoId = cmbEstado.SelectedValue,
                .Foto = ManejoDeFotos.ImagenABytes(picFotoDirector.Image)
            }

            Dim servicio As New DirectorServicios()

            If _iddirectorseleccionado = 0 Then
                servicio.Agregar(director)
                MessageBox.Show("Director registrado Correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                director.IdDirector = _iddirectorseleccionado
                servicio.Actualizar(director)
                MessageBox.Show("Director actualizado Correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            CargarDirectorCentro()
            CargarDirector()
            DesactivarCampos()
            btnActualizarGuardar.Text = "Guardar"
            btnNuevo.Enabled = True
            _iddirectorseleccionado = 0

        Catch ex As ExcepcionesdeNegocio
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnActivarDesactivar_Click(sender As Object, e As EventArgs) Handles btnActivarDesactivar.Click
        Try
            If _iddirectorseleccionado = 0 Then
                MessageBox.Show("Debe seleccionar un director", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim servicio As New DirectorServicios()
            Dim director = servicio.ObtenerPorId(_iddirectorseleccionado)
            Dim nuevoEstado As Integer
            Dim accion As String

            If director.EstadoId = EstadoGenerico.Activo Then
                nuevoEstado = EstadoGenerico.Inactivo
                accion = "Desactivar"
            Else
                nuevoEstado = EstadoGenerico.Activo
                accion = "activar"
            End If

            Dim respuesta = MessageBox.Show($"Desea {accion} este director?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If respuesta = DialogResult.No Then Exit Sub

            servicio.CambiarEstado(director.IdDirector, nuevoEstado)
            MessageBox.Show($"Director {accion}do correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)

            CargarDirector()
            CargarDirectorCentro()
            DesactivarCampos()

            btnActualizarGuardar.Text = "Guardar"
            btnNuevo.Enabled = True
            _iddirectorseleccionado = 0

        Catch ex As ExcepcionesdeNegocio
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnAnadirFoto_Click(sender As Object, e As EventArgs) Handles btnAnadirFoto.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png"
            If ofd.ShowDialog() = DialogResult.OK Then
                picFotoDirector.Image = Image.FromFile(ofd.FileName)
            End If
        End Using
    End Sub

End Class