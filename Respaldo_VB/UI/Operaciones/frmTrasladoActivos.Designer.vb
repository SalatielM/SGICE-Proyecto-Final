<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrasladoActivos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTrasladoActivos))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        label1 = New Label()
        GroupBox1 = New GroupBox()
        btnCargarBusqueda = New Button()
        txtBarraBusqueda = New TextBox()
        GroupBox3 = New GroupBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        cmbDocAutorizacion = New ComboBox()
        Label5 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        cmbQuienAutoriza = New ComboBox()
        txtNoDocAutorizacion = New TextBox()
        rtxtMotivoTraslado = New RichTextBox()
        Label2 = New Label()
        dgvTrasladoActivo = New DataGridView()
        IdActivoFisicoId = New DataGridViewTextBoxColumn()
        ActivoId = New DataGridViewTextBoxColumn()
        NombreActivo = New DataGridViewTextBoxColumn()
        CodigoEtiqueta = New DataGridViewTextBoxColumn()
        CategoriaId = New DataGridViewTextBoxColumn()
        Categoria = New DataGridViewTextBoxColumn()
        MarcaId = New DataGridViewTextBoxColumn()
        Marca = New DataGridViewTextBoxColumn()
        NumSerie = New DataGridViewTextBoxColumn()
        UbicacioActualId = New DataGridViewTextBoxColumn()
        UbicacionActual = New DataGridViewTextBoxColumn()
        UbicacionFinalId = New DataGridViewTextBoxColumn()
        UbicacionDestino = New DataGridViewComboBoxColumn()
        btnRegistrarTraslado = New Button()
        GroupBox2 = New GroupBox()
        btnEliminarFila = New Button()
        GroupBox1.SuspendLayout()
        GroupBox3.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        CType(dgvTrasladoActivo, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
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
        label1.TabIndex = 5
        label1.Text = "TRASLADO DE ACTIVOS"
        label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.Controls.Add(btnCargarBusqueda)
        GroupBox1.Controls.Add(txtBarraBusqueda)
        GroupBox1.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(23, 36)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1200, 80)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        ' 
        ' btnCargarBusqueda
        ' 
        btnCargarBusqueda.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCargarBusqueda.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnCargarBusqueda.Image = CType(resources.GetObject("btnCargarBusqueda.Image"), Image)
        btnCargarBusqueda.Location = New Point(1135, 22)
        btnCargarBusqueda.Name = "btnCargarBusqueda"
        btnCargarBusqueda.Size = New Size(50, 49)
        btnCargarBusqueda.TabIndex = 6
        btnCargarBusqueda.UseVisualStyleBackColor = True
        ' 
        ' txtBarraBusqueda
        ' 
        txtBarraBusqueda.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtBarraBusqueda.Font = New Font("Bookman Old Style", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txtBarraBusqueda.Location = New Point(15, 29)
        txtBarraBusqueda.Name = "txtBarraBusqueda"
        txtBarraBusqueda.Size = New Size(1113, 36)
        txtBarraBusqueda.TabIndex = 5
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox3.Controls.Add(TableLayoutPanel1)
        GroupBox3.Controls.Add(rtxtMotivoTraslado)
        GroupBox3.Controls.Add(Label2)
        GroupBox3.Controls.Add(dgvTrasladoActivo)
        GroupBox3.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox3.Location = New Point(23, 122)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(1200, 569)
        GroupBox3.TabIndex = 10
        GroupBox3.TabStop = False
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(cmbDocAutorizacion, 1, 1)
        TableLayoutPanel1.Controls.Add(Label5, 0, 2)
        TableLayoutPanel1.Controls.Add(Label3, 0, 0)
        TableLayoutPanel1.Controls.Add(Label4, 0, 1)
        TableLayoutPanel1.Controls.Add(cmbQuienAutoriza, 1, 0)
        TableLayoutPanel1.Controls.Add(txtNoDocAutorizacion, 1, 2)
        TableLayoutPanel1.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TableLayoutPanel1.Location = New Point(745, 439)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.Size = New Size(440, 118)
        TableLayoutPanel1.TabIndex = 23
        ' 
        ' cmbDocAutorizacion
        ' 
        cmbDocAutorizacion.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbDocAutorizacion.FormattingEnabled = True
        cmbDocAutorizacion.Location = New Point(206, 44)
        cmbDocAutorizacion.Margin = New Padding(5)
        cmbDocAutorizacion.Name = "cmbDocAutorizacion"
        cmbDocAutorizacion.Size = New Size(229, 30)
        cmbDocAutorizacion.TabIndex = 29
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label5.Location = New Point(5, 83)
        Label5.Margin = New Padding(5)
        Label5.Name = "Label5"
        Label5.Size = New Size(191, 24)
        Label5.TabIndex = 28
        Label5.Text = "No. Doc:"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label3.Location = New Point(5, 5)
        Label3.Margin = New Padding(5)
        Label3.Name = "Label3"
        Label3.Size = New Size(191, 24)
        Label3.TabIndex = 24
        Label3.Text = "Autoriza:"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label4.Location = New Point(5, 44)
        Label4.Margin = New Padding(5)
        Label4.Name = "Label4"
        Label4.Size = New Size(191, 24)
        Label4.TabIndex = 25
        Label4.Text = "Do. Autorizacion:"
        ' 
        ' cmbQuienAutoriza
        ' 
        cmbQuienAutoriza.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbQuienAutoriza.FormattingEnabled = True
        cmbQuienAutoriza.Location = New Point(206, 5)
        cmbQuienAutoriza.Margin = New Padding(5)
        cmbQuienAutoriza.Name = "cmbQuienAutoriza"
        cmbQuienAutoriza.Size = New Size(229, 30)
        cmbQuienAutoriza.TabIndex = 26
        ' 
        ' txtNoDocAutorizacion
        ' 
        txtNoDocAutorizacion.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtNoDocAutorizacion.Location = New Point(206, 83)
        txtNoDocAutorizacion.Margin = New Padding(5)
        txtNoDocAutorizacion.Name = "txtNoDocAutorizacion"
        txtNoDocAutorizacion.Size = New Size(229, 31)
        txtNoDocAutorizacion.TabIndex = 27
        ' 
        ' rtxtMotivoTraslado
        ' 
        rtxtMotivoTraslado.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        rtxtMotivoTraslado.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        rtxtMotivoTraslado.Location = New Point(15, 473)
        rtxtMotivoTraslado.Name = "rtxtMotivoTraslado"
        rtxtMotivoTraslado.Size = New Size(724, 84)
        rtxtMotivoTraslado.TabIndex = 22
        rtxtMotivoTraslado.Text = ""
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(20, 443)
        Label2.Margin = New Padding(3, 5, 3, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(239, 25)
        Label2.TabIndex = 8
        Label2.Text = "Motivo del Traslado"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' dgvTrasladoActivo
        ' 
        dgvTrasladoActivo.AllowUserToAddRows = False
        dgvTrasladoActivo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvTrasladoActivo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvTrasladoActivo.BackgroundColor = SystemColors.ButtonHighlight
        dgvTrasladoActivo.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvTrasladoActivo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvTrasladoActivo.ColumnHeadersHeight = 35
        dgvTrasladoActivo.Columns.AddRange(New DataGridViewColumn() {IdActivoFisicoId, ActivoId, NombreActivo, CodigoEtiqueta, CategoriaId, Categoria, MarcaId, Marca, NumSerie, UbicacioActualId, UbicacionActual, UbicacionFinalId, UbicacionDestino})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvTrasladoActivo.DefaultCellStyle = DataGridViewCellStyle2
        dgvTrasladoActivo.GridColor = SystemColors.InactiveCaptionText
        dgvTrasladoActivo.Location = New Point(15, 27)
        dgvTrasladoActivo.Name = "dgvTrasladoActivo"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvTrasladoActivo.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvTrasladoActivo.RowHeadersWidth = 62
        dgvTrasladoActivo.Size = New Size(1170, 406)
        dgvTrasladoActivo.TabIndex = 1
        ' 
        ' IdActivoFisicoId
        ' 
        IdActivoFisicoId.DataPropertyName = "ActivoFisicoId"
        IdActivoFisicoId.HeaderText = "ActivoFisicoId"
        IdActivoFisicoId.MinimumWidth = 8
        IdActivoFisicoId.Name = "IdActivoFisicoId"
        IdActivoFisicoId.Visible = False
        ' 
        ' ActivoId
        ' 
        ActivoId.DataPropertyName = "ActivoId"
        ActivoId.HeaderText = "ActivoId"
        ActivoId.MinimumWidth = 8
        ActivoId.Name = "ActivoId"
        ActivoId.Visible = False
        ' 
        ' NombreActivo
        ' 
        NombreActivo.DataPropertyName = "NombreActivo"
        NombreActivo.HeaderText = "Activo"
        NombreActivo.MinimumWidth = 8
        NombreActivo.Name = "NombreActivo"
        ' 
        ' CodigoEtiqueta
        ' 
        CodigoEtiqueta.DataPropertyName = "CodigoEtiqueta"
        CodigoEtiqueta.HeaderText = "Etiqueta"
        CodigoEtiqueta.MinimumWidth = 8
        CodigoEtiqueta.Name = "CodigoEtiqueta"
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
        ' NumSerie
        ' 
        NumSerie.DataPropertyName = "NumSerie"
        NumSerie.HeaderText = "No. Serie"
        NumSerie.MinimumWidth = 8
        NumSerie.Name = "NumSerie"
        ' 
        ' UbicacioActualId
        ' 
        UbicacioActualId.DataPropertyName = "UbicacioActualId"
        UbicacioActualId.HeaderText = "UbicacioActualId"
        UbicacioActualId.MinimumWidth = 8
        UbicacioActualId.Name = "UbicacioActualId"
        UbicacioActualId.Visible = False
        ' 
        ' UbicacionActual
        ' 
        UbicacionActual.DataPropertyName = "UbicacionActual"
        UbicacionActual.HeaderText = "Ubicacion Actual"
        UbicacionActual.MinimumWidth = 8
        UbicacionActual.Name = "UbicacionActual"
        ' 
        ' UbicacionFinalId
        ' 
        UbicacionFinalId.DataPropertyName = "UbicacionFinalId"
        UbicacionFinalId.HeaderText = "UbicacionFinalId"
        UbicacionFinalId.MinimumWidth = 8
        UbicacionFinalId.Name = "UbicacionFinalId"
        UbicacionFinalId.Visible = False
        ' 
        ' UbicacionDestino
        ' 
        UbicacionDestino.DataPropertyName = "UbicacionDestino"
        UbicacionDestino.HeaderText = "Destino"
        UbicacionDestino.MinimumWidth = 8
        UbicacionDestino.Name = "UbicacionDestino"
        ' 
        ' btnRegistrarTraslado
        ' 
        btnRegistrarTraslado.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnRegistrarTraslado.BackColor = Color.Honeydew
        btnRegistrarTraslado.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        btnRegistrarTraslado.Location = New Point(930, 20)
        btnRegistrarTraslado.Name = "btnRegistrarTraslado"
        btnRegistrarTraslado.Size = New Size(255, 34)
        btnRegistrarTraslado.TabIndex = 11
        btnRegistrarTraslado.Text = "Regsitrar Traslado "
        btnRegistrarTraslado.UseVisualStyleBackColor = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox2.Controls.Add(btnEliminarFila)
        GroupBox2.Controls.Add(btnRegistrarTraslado)
        GroupBox2.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(23, 697)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1200, 62)
        GroupBox2.TabIndex = 11
        GroupBox2.TabStop = False
        ' 
        ' btnEliminarFila
        ' 
        btnEliminarFila.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnEliminarFila.BackColor = Color.MistyRose
        btnEliminarFila.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        btnEliminarFila.Location = New Point(729, 20)
        btnEliminarFila.Name = "btnEliminarFila"
        btnEliminarFila.Size = New Size(192, 34)
        btnEliminarFila.TabIndex = 12
        btnEliminarFila.Text = "Eliminar Fila"
        btnEliminarFila.UseVisualStyleBackColor = False
        ' 
        ' frmTrasladoActivos
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1247, 765)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox1)
        Controls.Add(label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmTrasladoActivos"
        Text = "frmTrasladoActivos"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(dgvTrasladoActivo, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Private WithEvents label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCargarBusqueda As Button
    Friend WithEvents txtBarraBusqueda As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgvTrasladoActivo As DataGridView
    Friend WithEvents btnRegistrarTraslado As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents rtxtMotivoTraslado As RichTextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnEliminarFila As Button
    Friend WithEvents IdActivoFisicoId As DataGridViewTextBoxColumn
    Friend WithEvents ActivoId As DataGridViewTextBoxColumn
    Friend WithEvents NombreActivo As DataGridViewTextBoxColumn
    Friend WithEvents CodigoEtiqueta As DataGridViewTextBoxColumn
    Friend WithEvents CategoriaId As DataGridViewTextBoxColumn
    Friend WithEvents Categoria As DataGridViewTextBoxColumn
    Friend WithEvents MarcaId As DataGridViewTextBoxColumn
    Friend WithEvents Marca As DataGridViewTextBoxColumn
    Friend WithEvents NumSerie As DataGridViewTextBoxColumn
    Friend WithEvents UbicacioActualId As DataGridViewTextBoxColumn
    Friend WithEvents UbicacionActual As DataGridViewTextBoxColumn
    Friend WithEvents UbicacionFinalId As DataGridViewTextBoxColumn
    Friend WithEvents UbicacionDestino As DataGridViewComboBoxColumn
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbQuienAutoriza As ComboBox
    Friend WithEvents txtNoDocAutorizacion As TextBox
    Friend WithEvents cmbDocAutorizacion As ComboBox
    Friend WithEvents Label5 As Label
End Class
