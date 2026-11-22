<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDevoluciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDevoluciones))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        label1 = New Label()
        GroupBox1 = New GroupBox()
        btnCargarBusqueda = New Button()
        txtBarraBusqueda = New TextBox()
        GroupBox2 = New GroupBox()
        dgvPrestamosSolicitante = New DataGridView()
        IdPrestamo = New DataGridViewTextBoxColumn()
        PersonalSolicitanteId = New DataGridViewTextBoxColumn()
        PersonalSolicitante = New DataGridViewTextBoxColumn()
        CodPersonal = New DataGridViewTextBoxColumn()
        FechaPrestamo = New DataGridViewTextBoxColumn()
        FechaLimite = New DataGridViewTextBoxColumn()
        EstadoId = New DataGridViewTextBoxColumn()
        Estado = New DataGridViewTextBoxColumn()
        btnSeleccionar = New DataGridViewButtonColumn()
        dgvDetallePrestamo = New DataGridView()
        GroupBox3 = New GroupBox()
        btnLimpiarCampos = New Button()
        btnRegistrarDevolucion = New Button()
        selected = New DataGridViewCheckBoxColumn()
        ActivoFisicoId = New DataGridViewTextBoxColumn()
        ActivoId = New DataGridViewTextBoxColumn()
        Activo = New DataGridViewTextBoxColumn()
        CodEtiquetaQR = New DataGridViewTextBoxColumn()
        NumSerie = New DataGridViewTextBoxColumn()
        MarcaId = New DataGridViewTextBoxColumn()
        Marca = New DataGridViewTextBoxColumn()
        SubCategoriaId = New DataGridViewTextBoxColumn()
        SubCategoria = New DataGridViewTextBoxColumn()
        Observacion = New DataGridViewTextBoxColumn()
        Estadoo = New DataGridViewComboBoxColumn()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(dgvPrestamosSolicitante, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvDetallePrestamo, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
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
        label1.Text = "DEVOLUCION DE ACTIVOS"
        label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.Controls.Add(btnCargarBusqueda)
        GroupBox1.Controls.Add(txtBarraBusqueda)
        GroupBox1.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(22, 47)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1202, 91)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        ' 
        ' btnCargarBusqueda
        ' 
        btnCargarBusqueda.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCargarBusqueda.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnCargarBusqueda.Image = CType(resources.GetObject("btnCargarBusqueda.Image"), Image)
        btnCargarBusqueda.Location = New Point(1126, 28)
        btnCargarBusqueda.Name = "btnCargarBusqueda"
        btnCargarBusqueda.Size = New Size(50, 49)
        btnCargarBusqueda.TabIndex = 8
        btnCargarBusqueda.UseVisualStyleBackColor = True
        ' 
        ' txtBarraBusqueda
        ' 
        txtBarraBusqueda.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtBarraBusqueda.Font = New Font("Bookman Old Style", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txtBarraBusqueda.Location = New Point(27, 35)
        txtBarraBusqueda.Name = "txtBarraBusqueda"
        txtBarraBusqueda.Size = New Size(1092, 36)
        txtBarraBusqueda.TabIndex = 7
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox2.Controls.Add(dgvPrestamosSolicitante)
        GroupBox2.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(22, 150)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1202, 251)
        GroupBox2.TabIndex = 9
        GroupBox2.TabStop = False
        GroupBox2.Text = "Prestamos del Solicitante"
        ' 
        ' dgvPrestamosSolicitante
        ' 
        dgvPrestamosSolicitante.AllowUserToAddRows = False
        dgvPrestamosSolicitante.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvPrestamosSolicitante.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPrestamosSolicitante.BackgroundColor = SystemColors.ButtonHighlight
        dgvPrestamosSolicitante.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvPrestamosSolicitante.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvPrestamosSolicitante.ColumnHeadersHeight = 35
        dgvPrestamosSolicitante.Columns.AddRange(New DataGridViewColumn() {IdPrestamo, PersonalSolicitanteId, PersonalSolicitante, CodPersonal, FechaPrestamo, FechaLimite, EstadoId, Estado, btnSeleccionar})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvPrestamosSolicitante.DefaultCellStyle = DataGridViewCellStyle2
        dgvPrestamosSolicitante.GridColor = SystemColors.InactiveCaptionText
        dgvPrestamosSolicitante.Location = New Point(16, 36)
        dgvPrestamosSolicitante.Name = "dgvPrestamosSolicitante"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvPrestamosSolicitante.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvPrestamosSolicitante.RowHeadersVisible = False
        dgvPrestamosSolicitante.RowHeadersWidth = 62
        dgvPrestamosSolicitante.Size = New Size(1169, 197)
        dgvPrestamosSolicitante.TabIndex = 25
        ' 
        ' IdPrestamo
        ' 
        IdPrestamo.DataPropertyName = "IdPrestamo"
        IdPrestamo.HeaderText = "No. Prestamo"
        IdPrestamo.MinimumWidth = 8
        IdPrestamo.Name = "IdPrestamo"
        IdPrestamo.ReadOnly = True
        ' 
        ' PersonalSolicitanteId
        ' 
        PersonalSolicitanteId.DataPropertyName = "PersonalSolicitanteId"
        PersonalSolicitanteId.HeaderText = "PersonalId"
        PersonalSolicitanteId.MinimumWidth = 8
        PersonalSolicitanteId.Name = "PersonalSolicitanteId"
        PersonalSolicitanteId.ReadOnly = True
        PersonalSolicitanteId.Visible = False
        ' 
        ' PersonalSolicitante
        ' 
        PersonalSolicitante.DataPropertyName = "PersonalSolicitante"
        PersonalSolicitante.HeaderText = "Solicitante"
        PersonalSolicitante.MinimumWidth = 8
        PersonalSolicitante.Name = "PersonalSolicitante"
        PersonalSolicitante.ReadOnly = True
        ' 
        ' CodPersonal
        ' 
        CodPersonal.DataPropertyName = "CodPersonal"
        CodPersonal.HeaderText = "CodPersonal"
        CodPersonal.MinimumWidth = 8
        CodPersonal.Name = "CodPersonal"
        CodPersonal.ReadOnly = True
        ' 
        ' FechaPrestamo
        ' 
        FechaPrestamo.DataPropertyName = "FechaPrestamo"
        FechaPrestamo.HeaderText = "Fecha Prestamo"
        FechaPrestamo.MinimumWidth = 8
        FechaPrestamo.Name = "FechaPrestamo"
        FechaPrestamo.ReadOnly = True
        ' 
        ' FechaLimite
        ' 
        FechaLimite.DataPropertyName = "FechaLimite"
        FechaLimite.HeaderText = "Fecha Limite"
        FechaLimite.MinimumWidth = 8
        FechaLimite.Name = "FechaLimite"
        FechaLimite.ReadOnly = True
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
        Estado.ReadOnly = True
        ' 
        ' btnSeleccionar
        ' 
        btnSeleccionar.DataPropertyName = "btnSeleccionar"
        btnSeleccionar.HeaderText = "Selec"
        btnSeleccionar.MinimumWidth = 8
        btnSeleccionar.Name = "btnSeleccionar"
        btnSeleccionar.Resizable = DataGridViewTriState.True
        btnSeleccionar.Text = "Abrir"
        btnSeleccionar.UseColumnTextForButtonValue = True
        ' 
        ' dgvDetallePrestamo
        ' 
        dgvDetallePrestamo.AllowUserToAddRows = False
        dgvDetallePrestamo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvDetallePrestamo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvDetallePrestamo.BackgroundColor = SystemColors.ButtonHighlight
        dgvDetallePrestamo.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgvDetallePrestamo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgvDetallePrestamo.ColumnHeadersHeight = 35
        dgvDetallePrestamo.Columns.AddRange(New DataGridViewColumn() {selected, ActivoFisicoId, ActivoId, Activo, CodEtiquetaQR, NumSerie, MarcaId, Marca, SubCategoriaId, SubCategoria, Observacion, Estadoo})
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = SystemColors.Window
        DataGridViewCellStyle5.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        dgvDetallePrestamo.DefaultCellStyle = DataGridViewCellStyle5
        dgvDetallePrestamo.GridColor = SystemColors.InactiveCaptionText
        dgvDetallePrestamo.Location = New Point(16, 46)
        dgvDetallePrestamo.Name = "dgvDetallePrestamo"
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = SystemColors.Control
        DataGridViewCellStyle6.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        dgvDetallePrestamo.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        dgvDetallePrestamo.RowHeadersVisible = False
        dgvDetallePrestamo.RowHeadersWidth = 62
        dgvDetallePrestamo.Size = New Size(1169, 246)
        dgvDetallePrestamo.TabIndex = 26
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox3.Controls.Add(btnLimpiarCampos)
        GroupBox3.Controls.Add(btnRegistrarDevolucion)
        GroupBox3.Controls.Add(dgvDetallePrestamo)
        GroupBox3.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox3.Location = New Point(22, 407)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(1202, 346)
        GroupBox3.TabIndex = 27
        GroupBox3.TabStop = False
        GroupBox3.Text = "Activos del Prestamo"
        ' 
        ' btnLimpiarCampos
        ' 
        btnLimpiarCampos.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnLimpiarCampos.BackColor = Color.MistyRose
        btnLimpiarCampos.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLimpiarCampos.Location = New Point(736, 303)
        btnLimpiarCampos.Name = "btnLimpiarCampos"
        btnLimpiarCampos.Size = New Size(193, 32)
        btnLimpiarCampos.TabIndex = 28
        btnLimpiarCampos.Text = "Limpiar Campos"
        btnLimpiarCampos.TextAlign = ContentAlignment.TopCenter
        btnLimpiarCampos.UseVisualStyleBackColor = False
        ' 
        ' btnRegistrarDevolucion
        ' 
        btnRegistrarDevolucion.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnRegistrarDevolucion.BackColor = Color.Honeydew
        btnRegistrarDevolucion.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRegistrarDevolucion.Location = New Point(935, 303)
        btnRegistrarDevolucion.Name = "btnRegistrarDevolucion"
        btnRegistrarDevolucion.Size = New Size(241, 32)
        btnRegistrarDevolucion.TabIndex = 27
        btnRegistrarDevolucion.Text = "Registrar Devoluvion"
        btnRegistrarDevolucion.TextAlign = ContentAlignment.TopCenter
        btnRegistrarDevolucion.UseVisualStyleBackColor = False
        ' 
        ' selected
        ' 
        selected.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        selected.DataPropertyName = "Select"
        selected.HeaderText = "Sel."
        selected.MinimumWidth = 8
        selected.Name = "selected"
        selected.Width = 54
        ' 
        ' ActivoFisicoId
        ' 
        ActivoFisicoId.DataPropertyName = "ActivoFisicoId"
        ActivoFisicoId.HeaderText = "ActivoFisicoId"
        ActivoFisicoId.MinimumWidth = 8
        ActivoFisicoId.Name = "ActivoFisicoId"
        ActivoFisicoId.Visible = False
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
        Activo.ReadOnly = True
        ' 
        ' CodEtiquetaQR
        ' 
        CodEtiquetaQR.DataPropertyName = "CodEtiquetaQR"
        CodEtiquetaQR.HeaderText = "Etiqueta"
        CodEtiquetaQR.MinimumWidth = 8
        CodEtiquetaQR.Name = "CodEtiquetaQR"
        CodEtiquetaQR.ReadOnly = True
        ' 
        ' NumSerie
        ' 
        NumSerie.DataPropertyName = "NumSerie"
        NumSerie.HeaderText = "No. Serie"
        NumSerie.MinimumWidth = 8
        NumSerie.Name = "NumSerie"
        NumSerie.ReadOnly = True
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
        ' Observacion
        ' 
        Observacion.DataPropertyName = "Observacion"
        Observacion.HeaderText = "Observacion"
        Observacion.MinimumWidth = 8
        Observacion.Name = "Observacion"
        ' 
        ' Estadoo
        ' 
        Estadoo.HeaderText = "Estado"
        Estadoo.MinimumWidth = 8
        Estadoo.Name = "Estadoo"
        ' 
        ' frmDevoluciones
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1247, 765)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmDevoluciones"
        Text = "frmDevoluciones"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        CType(dgvPrestamosSolicitante, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvDetallePrestamo, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Private WithEvents label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCargarBusqueda As Button
    Friend WithEvents txtBarraBusqueda As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvPrestamosSolicitante As DataGridView
    Friend WithEvents dgvDetallePrestamo As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnLimpiarCampos As Button
    Friend WithEvents btnRegistrarDevolucion As Button
    Friend WithEvents IdPrestamo As DataGridViewTextBoxColumn
    Friend WithEvents PersonalSolicitanteId As DataGridViewTextBoxColumn
    Friend WithEvents PersonalSolicitante As DataGridViewTextBoxColumn
    Friend WithEvents CodPersonal As DataGridViewTextBoxColumn
    Friend WithEvents FechaPrestamo As DataGridViewTextBoxColumn
    Friend WithEvents FechaLimite As DataGridViewTextBoxColumn
    Friend WithEvents EstadoId As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents btnSeleccionar As DataGridViewButtonColumn
    Friend WithEvents selected As DataGridViewCheckBoxColumn
    Friend WithEvents ActivoFisicoId As DataGridViewTextBoxColumn
    Friend WithEvents ActivoId As DataGridViewTextBoxColumn
    Friend WithEvents Activo As DataGridViewTextBoxColumn
    Friend WithEvents CodEtiquetaQR As DataGridViewTextBoxColumn
    Friend WithEvents NumSerie As DataGridViewTextBoxColumn
    Friend WithEvents MarcaId As DataGridViewTextBoxColumn
    Friend WithEvents Marca As DataGridViewTextBoxColumn
    Friend WithEvents SubCategoriaId As DataGridViewTextBoxColumn
    Friend WithEvents SubCategoria As DataGridViewTextBoxColumn
    Friend WithEvents Observacion As DataGridViewTextBoxColumn
    Friend WithEvents Estadoo As DataGridViewComboBoxColumn
End Class