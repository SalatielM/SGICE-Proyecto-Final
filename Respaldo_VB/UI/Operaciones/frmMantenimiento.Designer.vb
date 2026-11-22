<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantenimiento
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        label1 = New Label()
        GroupBox2 = New GroupBox()
        dgvSolicitudesPendientes = New DataGridView()
        IdSolicitudMantenimiento = New DataGridViewTextBoxColumn()
        NumSolicitud = New DataGridViewTextBoxColumn()
        FechaSolicitud = New DataGridViewTextBoxColumn()
        EstadoId = New DataGridViewTextBoxColumn()
        Estado = New DataGridViewTextBoxColumn()
        GroupBox4 = New GroupBox()
        dgvMantenimiento = New DataGridView()
        btnAplicarDetalle = New Button()
        GroupBox5 = New GroupBox()
        btnLimpiarCampos = New Button()
        btnRegistrarMatenimiento = New Button()
        GroupBox1 = New GroupBox()
        cmbPersonalTecnico = New ComboBox()
        Label2 = New Label()
        btnRechazar = New Button()
        ActivoId = New DataGridViewTextBoxColumn()
        Activo = New DataGridViewTextBoxColumn()
        ActivoFisicoId = New DataGridViewTextBoxColumn()
        CodEtiquetaQR = New DataGridViewTextBoxColumn()
        NumSerie = New DataGridViewTextBoxColumn()
        MarcaId = New DataGridViewTextBoxColumn()
        Marca = New DataGridViewTextBoxColumn()
        CategoriaId = New DataGridViewTextBoxColumn()
        Categoria = New DataGridViewTextBoxColumn()
        SubCategoriaId = New DataGridViewTextBoxColumn()
        SubCategoria = New DataGridViewTextBoxColumn()
        ProblemaReportado = New DataGridViewTextBoxColumn()
        EstadoIdd = New DataGridViewTextBoxColumn()
        Solucion = New DataGridViewTextBoxColumn()
        EstadoDetalleId = New DataGridViewComboBoxColumn()
        GroupBox2.SuspendLayout()
        CType(dgvSolicitudesPendientes, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox4.SuspendLayout()
        CType(dgvMantenimiento, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox5.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' label1
        ' 
        label1.BackColor = SystemColors.ActiveCaption
        label1.BorderStyle = BorderStyle.Fixed3D
        label1.Dock = DockStyle.Top
        label1.Font = New Font("Bookman Old Style", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label1.Location = New Point(0, 0)
        label1.Name = "label1"
        label1.Size = New Size(1400, 37)
        label1.TabIndex = 7
        label1.Text = "MANTENIMIENTO DE ACTIVOS"
        label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox2.Controls.Add(dgvSolicitudesPendientes)
        GroupBox2.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(28, 50)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1345, 295)
        GroupBox2.TabIndex = 10
        GroupBox2.TabStop = False
        GroupBox2.Text = "Lista de Solicitudes Pendientes"
        ' 
        ' dgvSolicitudesPendientes
        ' 
        dgvSolicitudesPendientes.AllowUserToAddRows = False
        dgvSolicitudesPendientes.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvSolicitudesPendientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvSolicitudesPendientes.BackgroundColor = SystemColors.ButtonHighlight
        dgvSolicitudesPendientes.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvSolicitudesPendientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvSolicitudesPendientes.ColumnHeadersHeight = 35
        dgvSolicitudesPendientes.Columns.AddRange(New DataGridViewColumn() {IdSolicitudMantenimiento, NumSolicitud, FechaSolicitud, EstadoId, Estado})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvSolicitudesPendientes.DefaultCellStyle = DataGridViewCellStyle2
        dgvSolicitudesPendientes.GridColor = SystemColors.InactiveCaptionText
        dgvSolicitudesPendientes.Location = New Point(17, 40)
        dgvSolicitudesPendientes.Name = "dgvSolicitudesPendientes"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvSolicitudesPendientes.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvSolicitudesPendientes.RowHeadersWidth = 62
        dgvSolicitudesPendientes.Size = New Size(1312, 240)
        dgvSolicitudesPendientes.TabIndex = 34
        ' 
        ' IdSolicitudMantenimiento
        ' 
        IdSolicitudMantenimiento.DataPropertyName = "IdSolicitudMantenimiento"
        IdSolicitudMantenimiento.HeaderText = "IdSolicitudMantenimiento"
        IdSolicitudMantenimiento.MinimumWidth = 8
        IdSolicitudMantenimiento.Name = "IdSolicitudMantenimiento"
        IdSolicitudMantenimiento.Visible = False
        ' 
        ' NumSolicitud
        ' 
        NumSolicitud.DataPropertyName = "IdSolicitudMantenimiento"
        NumSolicitud.HeaderText = "No. Solicitud"
        NumSolicitud.MinimumWidth = 8
        NumSolicitud.Name = "NumSolicitud"
        ' 
        ' FechaSolicitud
        ' 
        FechaSolicitud.DataPropertyName = "FechaSolicitud"
        FechaSolicitud.HeaderText = "Fecha de la Solicitud"
        FechaSolicitud.MinimumWidth = 8
        FechaSolicitud.Name = "FechaSolicitud"
        ' 
        ' EstadoId
        ' 
        EstadoId.DataPropertyName = "EstadoId"
        EstadoId.HeaderText = "EstadoId"
        EstadoId.MinimumWidth = 8
        EstadoId.Name = "EstadoId"
        EstadoId.Visible = False
        ' 
        ' Estado
        ' 
        Estado.DataPropertyName = "Estado"
        Estado.HeaderText = "Estado"
        Estado.MinimumWidth = 8
        Estado.Name = "Estado"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox4.Controls.Add(dgvMantenimiento)
        GroupBox4.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox4.Location = New Point(28, 413)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(1345, 422)
        GroupBox4.TabIndex = 26
        GroupBox4.TabStop = False
        GroupBox4.Text = "Detalle De Mantenimiento"
        ' 
        ' dgvMantenimiento
        ' 
        dgvMantenimiento.AllowUserToAddRows = False
        dgvMantenimiento.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvMantenimiento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMantenimiento.BackgroundColor = SystemColors.ButtonHighlight
        dgvMantenimiento.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgvMantenimiento.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgvMantenimiento.ColumnHeadersHeight = 35
        dgvMantenimiento.Columns.AddRange(New DataGridViewColumn() {ActivoId, Activo, ActivoFisicoId, CodEtiquetaQR, NumSerie, MarcaId, Marca, CategoriaId, Categoria, SubCategoriaId, SubCategoria, ProblemaReportado, EstadoIdd, Solucion, EstadoDetalleId})
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = SystemColors.Window
        DataGridViewCellStyle5.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        dgvMantenimiento.DefaultCellStyle = DataGridViewCellStyle5
        dgvMantenimiento.GridColor = SystemColors.InactiveCaptionText
        dgvMantenimiento.Location = New Point(17, 58)
        dgvMantenimiento.Name = "dgvMantenimiento"
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = SystemColors.ControlLightLight
        DataGridViewCellStyle6.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        dgvMantenimiento.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        dgvMantenimiento.RowHeadersVisible = False
        dgvMantenimiento.RowHeadersWidth = 62
        dgvMantenimiento.Size = New Size(1312, 358)
        dgvMantenimiento.TabIndex = 32
        ' 
        ' btnAplicarDetalle
        ' 
        btnAplicarDetalle.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnAplicarDetalle.BackColor = Color.Honeydew
        btnAplicarDetalle.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAplicarDetalle.Location = New Point(1107, 22)
        btnAplicarDetalle.Name = "btnAplicarDetalle"
        btnAplicarDetalle.Size = New Size(222, 33)
        btnAplicarDetalle.TabIndex = 35
        btnAplicarDetalle.Text = "Aplicar al Detalle"
        btnAplicarDetalle.UseVisualStyleBackColor = False
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox5.Controls.Add(btnLimpiarCampos)
        GroupBox5.Controls.Add(btnRegistrarMatenimiento)
        GroupBox5.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox5.Location = New Point(28, 837)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(1345, 67)
        GroupBox5.TabIndex = 27
        GroupBox5.TabStop = False
        ' 
        ' btnLimpiarCampos
        ' 
        btnLimpiarCampos.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnLimpiarCampos.BackColor = Color.LightCyan
        btnLimpiarCampos.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLimpiarCampos.Location = New Point(811, 26)
        btnLimpiarCampos.Name = "btnLimpiarCampos"
        btnLimpiarCampos.Size = New Size(208, 33)
        btnLimpiarCampos.TabIndex = 37
        btnLimpiarCampos.Text = "Limpiar Campos"
        btnLimpiarCampos.UseVisualStyleBackColor = False
        ' 
        ' btnRegistrarMatenimiento
        ' 
        btnRegistrarMatenimiento.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnRegistrarMatenimiento.BackColor = Color.Honeydew
        btnRegistrarMatenimiento.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRegistrarMatenimiento.Location = New Point(1024, 26)
        btnRegistrarMatenimiento.Name = "btnRegistrarMatenimiento"
        btnRegistrarMatenimiento.Size = New Size(294, 33)
        btnRegistrarMatenimiento.TabIndex = 36
        btnRegistrarMatenimiento.Text = "Registrar Mantenimiento"
        btnRegistrarMatenimiento.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.Controls.Add(cmbPersonalTecnico)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(btnRechazar)
        GroupBox1.Controls.Add(btnAplicarDetalle)
        GroupBox1.Location = New Point(28, 346)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1345, 65)
        GroupBox1.TabIndex = 36
        GroupBox1.TabStop = False
        ' 
        ' cmbPersonalTecnico
        ' 
        cmbPersonalTecnico.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        cmbPersonalTecnico.FormattingEnabled = True
        cmbPersonalTecnico.Location = New Point(206, 26)
        cmbPersonalTecnico.Name = "cmbPersonalTecnico"
        cmbPersonalTecnico.Size = New Size(332, 30)
        cmbPersonalTecnico.TabIndex = 40
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(6, 27)
        Label2.Name = "Label2"
        Label2.Size = New Size(194, 24)
        Label2.TabIndex = 39
        Label2.Text = "Personal Tecnico:"
        ' 
        ' btnRechazar
        ' 
        btnRechazar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnRechazar.BackColor = Color.MistyRose
        btnRechazar.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRechazar.Location = New Point(859, 22)
        btnRechazar.Name = "btnRechazar"
        btnRechazar.Size = New Size(242, 33)
        btnRechazar.TabIndex = 38
        btnRechazar.Text = "Rechazar Solicitud"
        btnRechazar.UseVisualStyleBackColor = False
        ' 
        ' ActivoId
        ' 
        ActivoId.DataPropertyName = "ActivoId"
        ActivoId.HeaderText = "ActivoId"
        ActivoId.MinimumWidth = 8
        ActivoId.Name = "ActivoId"
        ActivoId.Visible = False
        ' 
        ' Activo
        ' 
        Activo.DataPropertyName = "Activo"
        Activo.HeaderText = "Activo"
        Activo.MinimumWidth = 8
        Activo.Name = "Activo"
        ' 
        ' ActivoFisicoId
        ' 
        ActivoFisicoId.DataPropertyName = "ActivoFisicoId"
        ActivoFisicoId.HeaderText = "ActivoFisicoId"
        ActivoFisicoId.MinimumWidth = 8
        ActivoFisicoId.Name = "ActivoFisicoId"
        ActivoFisicoId.Visible = False
        ' 
        ' CodEtiquetaQR
        ' 
        CodEtiquetaQR.DataPropertyName = "CodEtiquetaQR"
        CodEtiquetaQR.HeaderText = "Etiqueta"
        CodEtiquetaQR.MinimumWidth = 8
        CodEtiquetaQR.Name = "CodEtiquetaQR"
        ' 
        ' NumSerie
        ' 
        NumSerie.DataPropertyName = "NumSerie"
        NumSerie.HeaderText = "No. Serie"
        NumSerie.MinimumWidth = 8
        NumSerie.Name = "NumSerie"
        ' 
        ' MarcaId
        ' 
        MarcaId.DataPropertyName = "MarcaId"
        MarcaId.HeaderText = "MarcaId"
        MarcaId.MinimumWidth = 8
        MarcaId.Name = "MarcaId"
        MarcaId.Visible = False
        ' 
        ' Marca
        ' 
        Marca.DataPropertyName = "Marca"
        Marca.HeaderText = "Marca"
        Marca.MinimumWidth = 8
        Marca.Name = "Marca"
        ' 
        ' CategoriaId
        ' 
        CategoriaId.DataPropertyName = "CategoriaId"
        CategoriaId.HeaderText = "CategoriaId"
        CategoriaId.MinimumWidth = 8
        CategoriaId.Name = "CategoriaId"
        CategoriaId.Visible = False
        ' 
        ' Categoria
        ' 
        Categoria.DataPropertyName = "Categoria"
        Categoria.HeaderText = "Categoria"
        Categoria.MinimumWidth = 8
        Categoria.Name = "Categoria"
        ' 
        ' SubCategoriaId
        ' 
        SubCategoriaId.DataPropertyName = "SubCategoriaId"
        SubCategoriaId.HeaderText = "SubCategoriaId"
        SubCategoriaId.MinimumWidth = 8
        SubCategoriaId.Name = "SubCategoriaId"
        SubCategoriaId.Visible = False
        ' 
        ' SubCategoria
        ' 
        SubCategoria.DataPropertyName = "SubCategoria"
        SubCategoria.HeaderText = "SubCategoria"
        SubCategoria.MinimumWidth = 8
        SubCategoria.Name = "SubCategoria"
        ' 
        ' ProblemaReportado
        ' 
        ProblemaReportado.DataPropertyName = "ProblemaReportado"
        ProblemaReportado.HeaderText = "ProblemaReportado"
        ProblemaReportado.MinimumWidth = 8
        ProblemaReportado.Name = "ProblemaReportado"
        ' 
        ' EstadoIdd
        ' 
        EstadoIdd.DataPropertyName = "EstadoId"
        EstadoIdd.HeaderText = "EstadoId"
        EstadoIdd.MinimumWidth = 8
        EstadoIdd.Name = "EstadoIdd"
        EstadoIdd.Visible = False
        ' 
        ' Solucion
        ' 
        Solucion.DataPropertyName = "Solucion"
        Solucion.HeaderText = "Solucion"
        Solucion.MinimumWidth = 8
        Solucion.Name = "Solucion"
        ' 
        ' EstadoDetalleId
        ' 
        EstadoDetalleId.DataPropertyName = "Estado"
        EstadoDetalleId.HeaderText = "Estado"
        EstadoDetalleId.MinimumWidth = 8
        EstadoDetalleId.Name = "EstadoDetalleId"
        EstadoDetalleId.Resizable = DataGridViewTriState.True
        EstadoDetalleId.SortMode = DataGridViewColumnSortMode.Automatic
        ' 
        ' frmMantenimiento
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1400, 916)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox5)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox2)
        Controls.Add(label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmMantenimiento"
        Text = "frmMantenimiento"
        GroupBox2.ResumeLayout(False)
        CType(dgvSolicitudesPendientes, ComponentModel.ISupportInitialize).EndInit()
        GroupBox4.ResumeLayout(False)
        CType(dgvMantenimiento, ComponentModel.ISupportInitialize).EndInit()
        GroupBox5.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Private WithEvents label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dgvMantenimiento As DataGridView
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnLimpiarCampos As Button
    Friend WithEvents btnRegistrarMatenimiento As Button
    Friend WithEvents btnAplicarDetalle As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnRechazar As Button
    Friend WithEvents cmbPersonalTecnico As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvSolicitudesPendientes As DataGridView
    Friend WithEvents IdSolicitudMantenimiento As DataGridViewTextBoxColumn
    Friend WithEvents NumSolicitud As DataGridViewTextBoxColumn
    Friend WithEvents FechaSolicitud As DataGridViewTextBoxColumn
    Friend WithEvents EstadoId As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents ActivoId As DataGridViewTextBoxColumn
    Friend WithEvents Activo As DataGridViewTextBoxColumn
    Friend WithEvents ActivoFisicoId As DataGridViewTextBoxColumn
    Friend WithEvents CodEtiquetaQR As DataGridViewTextBoxColumn
    Friend WithEvents NumSerie As DataGridViewTextBoxColumn
    Friend WithEvents MarcaId As DataGridViewTextBoxColumn
    Friend WithEvents Marca As DataGridViewTextBoxColumn
    Friend WithEvents CategoriaId As DataGridViewTextBoxColumn
    Friend WithEvents Categoria As DataGridViewTextBoxColumn
    Friend WithEvents SubCategoriaId As DataGridViewTextBoxColumn
    Friend WithEvents SubCategoria As DataGridViewTextBoxColumn
    Friend WithEvents ProblemaReportado As DataGridViewTextBoxColumn
    Friend WithEvents EstadoIdd As DataGridViewTextBoxColumn
    Friend WithEvents Solucion As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDetalleId As DataGridViewComboBoxColumn
End Class
