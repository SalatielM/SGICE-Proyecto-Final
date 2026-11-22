Imports BBL
Imports MODELOS

Public Class frmDevoluciones

    Private _detalle As New List(Of DetalleDevolucionDTO)
    Private _prestamoSeleccionado As Integer = 0

    Public Sub New()
        InitializeComponent()

    End Sub

    Private Sub frmDevoluciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim servicioEstado As New EstadoServicios()
        Dim estatdos = servicioEstado.ObtenerPorTipo(TipoEstadoEnum.DetalleDevolucion)
        Dim combo = CType(dgvDetallePrestamo.Columns("Estadoo"), DataGridViewComboBoxColumn)

        combo.DisplayMember = "Nombre"
        combo.ValueMember = "IdEstado"
        combo.DataSource = estatdos
    End Sub

    Private Sub CargarPrestamosPorUsuario()
        Dim servicioPersonal As New PersonalServicios()
        Dim servicioPrestamo As New PrestamoServicios()

        Dim personal As Personal
        personal = servicioPersonal.ObtenerPorCodigo(txtBarraBusqueda.Text)

        Dim prestamo = servicioPrestamo.ObtenerPrestamosPendientes(personal.IdPersonal)

        dgvPrestamosSolicitante.AutoGenerateColumns = False
        dgvPrestamosSolicitante.DataSource = prestamo

        If prestamo Is Nothing OrElse prestamo.Count = 0 Then
            dgvDetallePrestamo.DataSource = Nothing
            _detalle.Clear()
            _prestamoSeleccionado = 0
        End If
    End Sub

    Private Function ObtenerPrestamosPorUsuarioSeguro() As List(Of PrestamoDTO)
        Dim servicioPersonal As New PersonalServicios()
        Dim servicioPrestamo As New PrestamoServicios()

        Dim personal = servicioPersonal.ObtenerPorCodigo(txtBarraBusqueda.Text)

        Try
            Return servicioPrestamo.ObtenerPrestamosPendientes(personal.IdPersonal)
        Catch ex As ExcepcionesdeNegocio
            Return New List(Of PrestamoDTO)
        End Try
    End Function

    Private Sub btnCargarBusqueda_Click(sender As Object, e As EventArgs) Handles btnCargarBusqueda.Click
        Try
            CargarPrestamosPorUsuario()
        Catch ex As ExcepcionesdeNegocio
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub CargarDetallePrestamo(prestamoId As Integer)
        dgvDetallePrestamo.AutoGenerateColumns = False
        Dim servicioDevolucion As New DevolucionServicios()
        _detalle = servicioDevolucion.ObtenerDetallePrestamo(prestamoId)
        dgvDetallePrestamo.DataSource = Nothing
        dgvDetallePrestamo.DataSource = _detalle
    End Sub

    Private Sub dgvPrestamosSolicitante_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPrestamosSolicitante.CellContentClick
        If e.RowIndex < 0 Then Return

        If dgvPrestamosSolicitante.Columns(e.ColumnIndex).Name <> "btnSeleccionar" Then
            Return
        End If

        Try
            _prestamoSeleccionado = CInt(dgvPrestamosSolicitante.Rows(e.RowIndex).Cells("IdPrestamo").Value)
            CargarDetallePrestamo(_prestamoSeleccionado)
        Catch ex As ExcepcionesdeNegocio
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnRegistrarDevolucion_Click(sender As Object, e As EventArgs) Handles btnRegistrarDevolucion.Click
        Try
            If _prestamoSeleccionado <= 0 Then
                MessageBox.Show("Por favor, seleccione un préstamo de la lista superior.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            dgvDetallePrestamo.EndEdit()

            Dim detalleSeleccionado As New List(Of DetalleDevolucionDTO)

            For Each row As DataGridViewRow In dgvDetallePrestamo.Rows
                If row.IsNewRow Then Continue For
                Dim seleccionado As Boolean = False

                If row.Cells("selected").Value IsNot Nothing AndAlso row.Cells("selected").Value IsNot DBNull.Value Then
                    seleccionado = Convert.ToBoolean(row.Cells("selected").Value)
                End If

                If seleccionado Then
                    Dim valorEstado = row.Cells("Estadoo").Value

                    If valorEstado Is Nothing OrElse valorEstado Is DBNull.Value OrElse String.IsNullOrWhiteSpace(valorEstado.ToString()) Then
                        MessageBox.Show("Debe seleccionar un estado para cada activo seleccionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        dgvDetallePrestamo.CurrentCell = row.Cells("Estadoo")
                        dgvDetallePrestamo.Focus()
                        Return
                    End If

                    Dim estadoIdVal As Integer
                    If Not Integer.TryParse(valorEstado.ToString(), estadoIdVal) OrElse estadoIdVal <= 0 Then
                        MessageBox.Show("Debe seleccionar un estado válido para cada activo seleccionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        dgvDetallePrestamo.CurrentCell = row.Cells("Estadoo")
                        dgvDetallePrestamo.Focus()
                        Return
                    End If
                End If
            Next

            For Each row As DataGridViewRow In dgvDetallePrestamo.Rows
                If row.IsNewRow Then Continue For

                Dim seleccionado As Boolean = False

                If row.Cells("selected").Value IsNot Nothing AndAlso row.Cells("selected").Value IsNot DBNull.Value Then
                    seleccionado = Convert.ToBoolean(row.Cells("selected").Value)
                End If

                If seleccionado Then
                    Dim itemDto = CType(row.DataBoundItem, DetalleDevolucionDTO)
                    Dim estadoIdVal As Integer = Convert.ToInt32(row.Cells("Estadoo").Value)
                    Dim observacionVal As String = If(row.Cells("Observacion").Value Is Nothing, String.Empty, row.Cells("Observacion").Value.ToString())

                    itemDto.EstadoDevolucionId = estadoIdVal
                    itemDto.Obervacion = observacionVal

                    detalleSeleccionado.Add(itemDto)
                End If
            Next

            If detalleSeleccionado.Count = 0 Then
                MessageBox.Show("Debe seleccionar al menos un activo para realizar la devolución.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim nuevaDevolucion As New Devolucion With {
                .PrestamoId = _prestamoSeleccionado,
                .FechaDevolucion = DateTime.Now
            }

            Dim servicioDevolucion As New DevolucionServicios()
            servicioDevolucion.RegistrarDevolucion(nuevaDevolucion, detalleSeleccionado)

            MessageBox.Show("Devolución registrada exitosamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim prestamos = ObtenerPrestamosPorUsuarioSeguro()

            dgvPrestamosSolicitante.DataSource = prestamos

            If prestamos.Any(Function(p) p.IdPrestamo = _prestamoSeleccionado) Then
                CargarDetallePrestamo(_prestamoSeleccionado)
            Else
                dgvDetallePrestamo.DataSource = Nothing
                _detalle.Clear()
                _prestamoSeleccionado = 0
            End If

        Catch ex As Exception
            MessageBox.Show("Ocurrió un error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnLimpiarCampos_Click(sender As Object, e As EventArgs) Handles btnLimpiarCampos.Click
        Dim respuesta = MessageBox.Show("¿Está seguro de que desea limpiar todos los campos? Se perderán los datos anteriores.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If respuesta = DialogResult.Yes Then
            LimpiarFormulario()
        End If
    End Sub

    Private Sub LimpiarFormulario()
        txtBarraBusqueda.Clear()
        dgvPrestamosSolicitante.DataSource = Nothing
        dgvDetallePrestamo.DataSource = Nothing

        _prestamoSeleccionado = 0
        _detalle.Clear()

        txtBarraBusqueda.Focus()
    End Sub

End Class