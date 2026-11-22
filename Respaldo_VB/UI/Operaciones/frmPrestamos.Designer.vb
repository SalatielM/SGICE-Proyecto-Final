<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrestamos
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
        GroupBox1 = New GroupBox()
        btnEliminarFila = New Button()
        btnRegistrarPrestamo = New Button()
        dgvDetallePrestamos = New DataGridView()
        TableLayoutPanel2 = New TableLayoutPanel()
        cmbActivosDisponibles = New ComboBox()
        cmbTipoActivo = New ComboBox()
        Label4 = New Label()
        Label6 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        dtpFechaFinalizacion = New DateTimePicker()
        cmbPersonalSolicitante = New ComboBox()
        dtpFechaPrestamo = New DateTimePicker()
        Label3 = New Label()
        Label5 = New Label()
        Label2 = New Label()
        GroupBox2 = New GroupBox()
        dgvListaPrestamos = New DataGridView()
        PrestamoId = New DataGridViewTextBoxColumn()
        PersonalSolicitante = New DataGridViewTextBoxColumn()
        CodPersonal = New DataGridViewTextBoxColumn()
        Activoo = New DataGridViewTextBoxColumn()
        FechaPrestamo = New DataGridViewTextBoxColumn()
        FechaFinalizacion = New DataGridViewTextBoxColumn()
        Estadoo = New DataGridViewTextBoxColumn()
        IdActivoFisico = New DataGridViewTextBoxColumn()
        IdActivo = New DataGridViewTextBoxColumn()
        Activo = New DataGridViewTextBoxColumn()
        CodEtiquetaQR = New DataGridViewTextBoxColumn()
        NumSerie = New DataGridViewTextBoxColumn()
        SubCategoriaId = New DataGridViewTextBoxColumn()
        SubCategoria = New DataGridViewTextBoxColumn()
        MarcaId = New DataGridViewTextBoxColumn()
        Marca = New DataGridViewTextBoxColumn()
        EstadoId = New DataGridViewTextBoxColumn()
        Estado = New DataGridViewTextBoxColumn()
        GroupBox1.SuspendLayout()
        CType(dgvDetallePrestamos, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(dgvListaPrestamos, ComponentModel.ISupportInitialize).BeginInit()
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
        label1.Size = New Size(1247, 37)
        label1.TabIndex = 6
        label1.Text = "PRESTAMO DE ACTIVOS"
        label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.Controls.Add(btnEliminarFila)
        GroupBox1.Controls.Add(btnRegistrarPrestamo)
        GroupBox1.Controls.Add(dgvDetallePrestamos)
        GroupBox1.Controls.Add(TableLayoutPanel2)
        GroupBox1.Controls.Add(TableLayoutPanel1)
        GroupBox1.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(24, 53)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1196, 426)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        GroupBox1.Text = "Info. del Prestamo"
        ' 
        ' btnEliminarFila
        ' 
        btnEliminarFila.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnEliminarFila.BackColor = Color.MistyRose
        btnEliminarFila.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEliminarFila.Location = New Point(751, 385)
        btnEliminarFila.Name = "btnEliminarFila"
        btnEliminarFila.Size = New Size(186, 32)
        btnEliminarFila.TabIndex = 26
        btnEliminarFila.Text = "Eliminar Fila"
        btnEliminarFila.TextAlign = ContentAlignment.TopCenter
        btnEliminarFila.UseVisualStyleBackColor = False
        ' 
        ' btnRegistrarPrestamo
        ' 
        btnRegistrarPrestamo.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnRegistrarPrestamo.BackColor = Color.Honeydew
        btnRegistrarPrestamo.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRegistrarPrestamo.Location = New Point(943, 385)
        btnRegistrarPrestamo.Name = "btnRegistrarPrestamo"
        btnRegistrarPrestamo.Size = New Size(227, 32)
        btnRegistrarPrestamo.TabIndex = 25
        btnRegistrarPrestamo.Text = "Registrar Prestamo"
        btnRegistrarPrestamo.TextAlign = ContentAlignment.TopCenter
        btnRegistrarPrestamo.UseVisualStyleBackColor = False
        ' 
        ' dgvDetallePrestamos
        ' 
        dgvDetallePrestamos.AllowUserToAddRows = False
        dgvDetallePrestamos.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvDetallePrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvDetallePrestamos.BackgroundColor = SystemColors.ButtonHighlight
        dgvDetallePrestamos.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvDetallePrestamos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvDetallePrestamos.ColumnHeadersHeight = 35
        dgvDetallePrestamos.Columns.AddRange(New DataGridViewColumn() {IdActivoFisico, IdActivo, Activo, CodEtiquetaQR, NumSerie, SubCategoriaId, SubCategoria, MarcaId, Marca, EstadoId, Estado})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvDetallePrestamos.DefaultCellStyle = DataGridViewCellStyle2
        dgvDetallePrestamos.GridColor = SystemColors.InactiveCaptionText
        dgvDetallePrestamos.Location = New Point(15, 145)
        dgvDetallePrestamos.Name = "dgvDetallePrestamos"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvDetallePrestamos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvDetallePrestamos.RowHeadersWidth = 62
        dgvDetallePrestamos.Size = New Size(1164, 232)
        dgvDetallePrestamos.TabIndex = 24
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel2.ColumnCount = 5
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel2.Controls.Add(cmbActivosDisponibles, 3, 0)
        TableLayoutPanel2.Controls.Add(cmbTipoActivo, 1, 0)
        TableLayoutPanel2.Controls.Add(Label4, 2, 0)
        TableLayoutPanel2.Controls.Add(Label6, 0, 0)
        TableLayoutPanel2.Location = New Point(15, 95)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Size = New Size(1164, 36)
        TableLayoutPanel2.TabIndex = 23
        ' 
        ' cmbActivosDisponibles
        ' 
        cmbActivosDisponibles.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbActivosDisponibles.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        cmbActivosDisponibles.FormattingEnabled = True
        cmbActivosDisponibles.Location = New Point(827, 3)
        cmbActivosDisponibles.Name = "cmbActivosDisponibles"
        cmbActivosDisponibles.Size = New Size(333, 30)
        cmbActivosDisponibles.TabIndex = 17
        ' 
        ' cmbTipoActivo
        ' 
        cmbTipoActivo.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbTipoActivo.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        cmbTipoActivo.FormattingEnabled = True
        cmbTipoActivo.Location = New Point(174, 3)
        cmbTipoActivo.Name = "cmbTipoActivo"
        cmbTipoActivo.Size = New Size(333, 30)
        cmbTipoActivo.TabIndex = 16
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label4.Location = New Point(513, 5)
        Label4.Margin = New Padding(3, 5, 3, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(308, 24)
        Label4.TabIndex = 11
        Label4.Text = "    Disponible para Prestamo:"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label6.Location = New Point(3, 5)
        Label6.Margin = New Padding(3, 5, 3, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(165, 24)
        Label6.TabIndex = 7
        Label6.Text = "Tipo de Activo:"
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.ColumnCount = 6
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.Controls.Add(dtpFechaFinalizacion, 5, 0)
        TableLayoutPanel1.Controls.Add(cmbPersonalSolicitante, 1, 0)
        TableLayoutPanel1.Controls.Add(dtpFechaPrestamo, 3, 0)
        TableLayoutPanel1.Controls.Add(Label3, 4, 0)
        TableLayoutPanel1.Controls.Add(Label5, 2, 0)
        TableLayoutPanel1.Controls.Add(Label2, 0, 0)
        TableLayoutPanel1.Location = New Point(15, 44)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(1164, 36)
        TableLayoutPanel1.TabIndex = 22
        ' 
        ' dtpFechaFinalizacion
        ' 
        dtpFechaFinalizacion.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        dtpFechaFinalizacion.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        dtpFechaFinalizacion.Location = New Point(980, 3)
        dtpFechaFinalizacion.Name = "dtpFechaFinalizacion"
        dtpFechaFinalizacion.Size = New Size(181, 31)
        dtpFechaFinalizacion.TabIndex = 16
        ' 
        ' cmbPersonalSolicitante
        ' 
        cmbPersonalSolicitante.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbPersonalSolicitante.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        cmbPersonalSolicitante.FormattingEnabled = True
        cmbPersonalSolicitante.Location = New Point(139, 3)
        cmbPersonalSolicitante.Name = "cmbPersonalSolicitante"
        cmbPersonalSolicitante.Size = New Size(181, 30)
        cmbPersonalSolicitante.TabIndex = 15
        ' 
        ' dtpFechaPrestamo
        ' 
        dtpFechaPrestamo.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        dtpFechaPrestamo.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        dtpFechaPrestamo.Location = New Point(543, 3)
        dtpFechaPrestamo.Name = "dtpFechaPrestamo"
        dtpFechaPrestamo.Size = New Size(181, 31)
        dtpFechaPrestamo.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label3.Location = New Point(730, 5)
        Label3.Margin = New Padding(3, 5, 3, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(244, 24)
        Label3.TabIndex = 13
        Label3.Text = "    Fecha Finalizacion:"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label5.Location = New Point(326, 5)
        Label5.Margin = New Padding(3, 5, 3, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(211, 24)
        Label5.TabIndex = 11
        Label5.Text = "    Fecha Prestamo:"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label2.Location = New Point(3, 5)
        Label2.Margin = New Padding(3, 5, 3, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(130, 24)
        Label2.TabIndex = 7
        Label2.Text = "Solicitante:"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox2.Controls.Add(dgvListaPrestamos)
        GroupBox2.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(24, 485)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1196, 268)
        GroupBox2.TabIndex = 8
        GroupBox2.TabStop = False
        GroupBox2.Text = "Lista de Prestamos"
        ' 
        ' dgvListaPrestamos
        ' 
        dgvListaPrestamos.AllowUserToAddRows = False
        dgvListaPrestamos.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvListaPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvListaPrestamos.BackgroundColor = SystemColors.ButtonHighlight
        dgvListaPrestamos.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgvListaPrestamos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgvListaPrestamos.ColumnHeadersHeight = 35
        dgvListaPrestamos.Columns.AddRange(New DataGridViewColumn() {PrestamoId, PersonalSolicitante, CodPersonal, Activoo, FechaPrestamo, FechaFinalizacion, Estadoo})
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = SystemColors.Window
        DataGridViewCellStyle5.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        dgvListaPrestamos.DefaultCellStyle = DataGridViewCellStyle5
        dgvListaPrestamos.GridColor = SystemColors.InactiveCaptionText
        dgvListaPrestamos.Location = New Point(15, 38)
        dgvListaPrestamos.Name = "dgvListaPrestamos"
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = SystemColors.Control
        DataGridViewCellStyle6.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        dgvListaPrestamos.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        dgvListaPrestamos.RowHeadersVisible = False
        dgvListaPrestamos.RowHeadersWidth = 62
        dgvListaPrestamos.Size = New Size(1164, 215)
        dgvListaPrestamos.TabIndex = 25
        ' 
        ' PrestamoId
        ' 
        PrestamoId.DataPropertyName = "PrestamoId"
        PrestamoId.HeaderText = "PrestamoId"
        PrestamoId.MinimumWidth = 8
        PrestamoId.Name = "PrestamoId"
        PrestamoId.Visible = False
        ' 
        ' PersonalSolicitante
        ' 
        PersonalSolicitante.DataPropertyName = "Solicitante"
        PersonalSolicitante.HeaderText = "Solicitante"
        PersonalSolicitante.MinimumWidth = 8
        PersonalSolicitante.Name = "PersonalSolicitante"
        ' 
        ' CodPersonal
        ' 
        CodPersonal.DataPropertyName = "CodPersonal"
        CodPersonal.HeaderText = "CodPersonal"
        CodPersonal.MinimumWidth = 8
        CodPersonal.Name = "CodPersonal"
        ' 
        ' Activoo
        ' 
        Activoo.DataPropertyName = "Activo"
        Activoo.HeaderText = "Activo"
        Activoo.MinimumWidth = 8
        Activoo.Name = "Activoo"
        ' 
        ' FechaPrestamo
        ' 
        FechaPrestamo.DataPropertyName = "FechaPrestamo"
        FechaPrestamo.HeaderText = "Fecha Prestamo"
        FechaPrestamo.MinimumWidth = 8
        FechaPrestamo.Name = "FechaPrestamo"
        ' 
        ' FechaFinalizacion
        ' 
        FechaFinalizacion.DataPropertyName = "FechaFinalizacion"
        FechaFinalizacion.HeaderText = "Fecha Finalicacion"
        FechaFinalizacion.MinimumWidth = 8
        FechaFinalizacion.Name = "FechaFinalizacion"
        ' 
        ' Estadoo
        ' 
        Estadoo.DataPropertyName = "Estado"
        Estadoo.HeaderText = "Estado"
        Estadoo.MinimumWidth = 8
        Estadoo.Name = "Estadoo"
        ' 
        ' IdActivoFisico
        ' 
        IdActivoFisico.DataPropertyName = "IdActivoFisico"
        IdActivoFisico.HeaderText = "IdActivoFisico"
        IdActivoFisico.MinimumWidth = 8
        IdActivoFisico.Name = "IdActivoFisico"
        IdActivoFisico.Visible = False
        ' 
        ' IdActivo
        ' 
        IdActivo.DataPropertyName = "IdActivo"
        IdActivo.HeaderText = "IdActivo"
        IdActivo.MinimumWidth = 8
        IdActivo.Name = "IdActivo"
        IdActivo.Visible = False
        ' 
        ' Activo
        ' 
        Activo.DataPropertyName = "Activo"
        Activo.HeaderText = "Activo"
        Activo.MinimumWidth = 8
        Activo.Name = "Activo"
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
        ' frmPrestamos
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1247, 765)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmPrestamos"
        Text = "frmPrestamos"
        GroupBox1.ResumeLayout(False)
        CType(dgvDetallePrestamos, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        CType(dgvListaPrestamos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Private WithEvents label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents dtpFechaPrestamo As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpFechaFinalizacion As DateTimePicker
    Friend WithEvents cmbPersonalSolicitante As ComboBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents cmbActivosDisponibles As ComboBox
    Friend WithEvents cmbTipoActivo As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dgvDetallePrestamos As DataGridView
    Friend WithEvents btnEliminarFila As Button
    Friend WithEvents btnRegistrarPrestamo As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvListaPrestamos As DataGridView
    Friend WithEvents PrestamoId As DataGridViewTextBoxColumn
    Friend WithEvents PersonalSolicitante As DataGridViewTextBoxColumn
    Friend WithEvents CodPersonal As DataGridViewTextBoxColumn
    Friend WithEvents Activoo As DataGridViewTextBoxColumn
    Friend WithEvents FechaPrestamo As DataGridViewTextBoxColumn
    Friend WithEvents FechaFinalizacion As DataGridViewTextBoxColumn
    Friend WithEvents Estadoo As DataGridViewTextBoxColumn
    Friend WithEvents IdActivoFisico As DataGridViewTextBoxColumn
    Friend WithEvents IdActivo As DataGridViewTextBoxColumn
    Friend WithEvents Activo As DataGridViewTextBoxColumn
    Friend WithEvents CodEtiquetaQR As DataGridViewTextBoxColumn
    Friend WithEvents NumSerie As DataGridViewTextBoxColumn
    Friend WithEvents SubCategoriaId As DataGridViewTextBoxColumn
    Friend WithEvents SubCategoria As DataGridViewTextBoxColumn
    Friend WithEvents MarcaId As DataGridViewTextBoxColumn
    Friend WithEvents Marca As DataGridViewTextBoxColumn
    Friend WithEvents EstadoId As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
End Class
