namespace SGICE.Presentacion;

partial class FrmEntradas
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        DataGridViewCellStyle dgvHeaderStyle = new DataGridViewCellStyle();
        DataGridViewCellStyle dgvCellStyle = new DataGridViewCellStyle();
        errorProvider = new ErrorProvider(components);
        pnlTop = new Panel();
        lblTitulo = new Label();
        pnlCabeceraContainer = new Panel();
        grpCabecera = new GroupBox();
        lblTipoDoc = new Label();
        cmbTipoDoc = new ComboBox();
        lblNoDoc = new Label();
        txtNoDoc = new TextBox();
        lblObservacion = new Label();
        txtObservacion = new TextBox();
        pnlGeneracionContainer = new Panel();
        grpGeneracion = new GroupBox();
        lblActivo = new Label();
        cmbActivo = new ComboBox();
        lblCantidad = new Label();
        txtCantidad = new TextBox();
        btnGenerar = new Button();
        pnlDetalleContainer = new Panel();
        grpDetalle = new GroupBox();
        dgvActivosFisicos = new DataGridView();
        pnlDetalleFooter = new Panel();
        lblTotalActivos = new Label();
        btnQuitar = new Button();
        pnlAcciones = new Panel();
        btnLimpiar = new Button();
        btnProcesar = new Button();
        ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
        pnlTop.SuspendLayout();
        pnlCabeceraContainer.SuspendLayout();
        grpCabecera.SuspendLayout();
        pnlGeneracionContainer.SuspendLayout();
        grpGeneracion.SuspendLayout();
        pnlDetalleContainer.SuspendLayout();
        grpDetalle.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvActivosFisicos).BeginInit();
        pnlDetalleFooter.SuspendLayout();
        pnlAcciones.SuspendLayout();
        SuspendLayout();
        // 
        // errorProvider
        // 
        errorProvider.ContainerControl = this;
        // 
        // pnlTop
        // 
        pnlTop.BackColor = Color.FromArgb(142, 177, 209);
        pnlTop.Controls.Add(lblTitulo);
        pnlTop.Dock = DockStyle.Top;
        pnlTop.Location = new Point(0, 0);
        pnlTop.Name = "pnlTop";
        pnlTop.Size = new Size(1060, 32);
        pnlTop.TabIndex = 0;
        // 
        // lblTitulo
        // 
        lblTitulo.Dock = DockStyle.Fill;
        lblTitulo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.Black;
        lblTitulo.Location = new Point(0, 0);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(1060, 32);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "ENTRADA DE ACTIVOS A INVENTARIO";
        lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // pnlCabeceraContainer
        // 
        pnlCabeceraContainer.BackColor = SystemColors.Control;
        pnlCabeceraContainer.Controls.Add(grpCabecera);
        pnlCabeceraContainer.Dock = DockStyle.Top;
        pnlCabeceraContainer.Location = new Point(0, 32);
        pnlCabeceraContainer.Name = "pnlCabeceraContainer";
        pnlCabeceraContainer.Padding = new Padding(8, 6, 8, 2);
        pnlCabeceraContainer.Size = new Size(1060, 124);
        pnlCabeceraContainer.TabIndex = 1;
        // 
        // grpCabecera
        // 
        grpCabecera.BackColor = SystemColors.Control;
        grpCabecera.Controls.Add(lblTipoDoc);
        grpCabecera.Controls.Add(cmbTipoDoc);
        grpCabecera.Controls.Add(lblNoDoc);
        grpCabecera.Controls.Add(txtNoDoc);
        grpCabecera.Controls.Add(lblObservacion);
        grpCabecera.Controls.Add(txtObservacion);
        grpCabecera.Dock = DockStyle.Fill;
        grpCabecera.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        grpCabecera.ForeColor = Color.Black;
        grpCabecera.Location = new Point(8, 6);
        grpCabecera.Name = "grpCabecera";
        grpCabecera.Size = new Size(1044, 116);
        grpCabecera.TabIndex = 0;
        grpCabecera.TabStop = false;
        grpCabecera.Text = "Datos Generales de la Entrada";
        // 
        // lblTipoDoc
        // 
        lblTipoDoc.AutoSize = true;
        lblTipoDoc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblTipoDoc.ForeColor = Color.Black;
        lblTipoDoc.Location = new Point(12, 26);
        lblTipoDoc.Name = "lblTipoDoc";
        lblTipoDoc.Size = new Size(134, 15);
        lblTipoDoc.TabIndex = 0;
        lblTipoDoc.Text = "Documento de Origen:";
        // 
        // cmbTipoDoc
        // 
        cmbTipoDoc.BackColor = SystemColors.Window;
        cmbTipoDoc.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbTipoDoc.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        cmbTipoDoc.FormattingEnabled = true;
        cmbTipoDoc.Location = new Point(152, 23);
        cmbTipoDoc.Name = "cmbTipoDoc";
        cmbTipoDoc.Size = new Size(220, 23);
        cmbTipoDoc.TabIndex = 1;
        // 
        // lblNoDoc
        // 
        lblNoDoc.AutoSize = true;
        lblNoDoc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblNoDoc.ForeColor = Color.Black;
        lblNoDoc.Location = new Point(390, 26);
        lblNoDoc.Name = "lblNoDoc";
        lblNoDoc.Size = new Size(100, 15);
        lblNoDoc.TabIndex = 2;
        lblNoDoc.Text = "No. Documento:";
        // 
        // txtNoDoc
        // 
        txtNoDoc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtNoDoc.BackColor = SystemColors.Window;
        txtNoDoc.BorderStyle = BorderStyle.FixedSingle;
        txtNoDoc.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        txtNoDoc.Location = new Point(496, 23);
        txtNoDoc.Name = "txtNoDoc";
        txtNoDoc.PlaceholderText = "FAC-98432";
        txtNoDoc.Size = new Size(534, 23);
        txtNoDoc.TabIndex = 3;
        // 
        // lblObservacion
        // 
        lblObservacion.AutoSize = true;
        lblObservacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblObservacion.ForeColor = Color.Black;
        lblObservacion.Location = new Point(12, 62);
        lblObservacion.Name = "lblObservacion";
        lblObservacion.Size = new Size(92, 15);
        lblObservacion.TabIndex = 4;
        lblObservacion.Text = "Observaciones:";
        // 
        // txtObservacion
        // 
        txtObservacion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtObservacion.BackColor = SystemColors.Window;
        txtObservacion.BorderStyle = BorderStyle.FixedSingle;
        txtObservacion.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        txtObservacion.Location = new Point(152, 58);
        txtObservacion.Multiline = true;
        txtObservacion.Name = "txtObservacion";
        txtObservacion.Size = new Size(878, 45);
        txtObservacion.TabIndex = 5;
        // 
        // pnlGeneracionContainer
        // 
        pnlGeneracionContainer.BackColor = SystemColors.Control;
        pnlGeneracionContainer.Controls.Add(grpGeneracion);
        pnlGeneracionContainer.Dock = DockStyle.Top;
        pnlGeneracionContainer.Location = new Point(0, 156);
        pnlGeneracionContainer.Name = "pnlGeneracionContainer";
        pnlGeneracionContainer.Padding = new Padding(8, 2, 8, 2);
        pnlGeneracionContainer.Size = new Size(1060, 66);
        pnlGeneracionContainer.TabIndex = 2;
        // 
        // grpGeneracion
        // 
        grpGeneracion.BackColor = SystemColors.Control;
        grpGeneracion.Controls.Add(lblActivo);
        grpGeneracion.Controls.Add(cmbActivo);
        grpGeneracion.Controls.Add(lblCantidad);
        grpGeneracion.Controls.Add(txtCantidad);
        grpGeneracion.Controls.Add(btnGenerar);
        grpGeneracion.Dock = DockStyle.Fill;
        grpGeneracion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        grpGeneracion.ForeColor = Color.Black;
        grpGeneracion.Location = new Point(8, 2);
        grpGeneracion.Name = "grpGeneracion";
        grpGeneracion.Size = new Size(1044, 62);
        grpGeneracion.TabIndex = 0;
        grpGeneracion.TabStop = false;
        grpGeneracion.Text = "Selección de Activo y Cantidad";
        // 
        // lblActivo
        // 
        lblActivo.AutoSize = true;
        lblActivo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblActivo.ForeColor = Color.Black;
        lblActivo.Location = new Point(12, 26);
        lblActivo.Name = "lblActivo";
        lblActivo.Size = new Size(46, 15);
        lblActivo.TabIndex = 0;
        lblActivo.Text = "Activo:";
        // 
        // cmbActivo
        // 
        cmbActivo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        cmbActivo.BackColor = SystemColors.Window;
        cmbActivo.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbActivo.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        cmbActivo.FormattingEnabled = true;
        cmbActivo.Location = new Point(68, 23);
        cmbActivo.Name = "cmbActivo";
        cmbActivo.Size = new Size(650, 23);
        cmbActivo.TabIndex = 1;
        // 
        // lblCantidad
        // 
        lblCantidad.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblCantidad.AutoSize = true;
        lblCantidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblCantidad.ForeColor = Color.Black;
        lblCantidad.Location = new Point(734, 26);
        lblCantidad.Name = "lblCantidad";
        lblCantidad.Size = new Size(61, 15);
        lblCantidad.TabIndex = 2;
        lblCantidad.Text = "Cantidad:";
        // 
        // txtCantidad
        // 
        txtCantidad.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        txtCantidad.BackColor = SystemColors.Window;
        txtCantidad.BorderStyle = BorderStyle.FixedSingle;
        txtCantidad.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        txtCantidad.Location = new Point(801, 23);
        txtCantidad.Name = "txtCantidad";
        txtCantidad.PlaceholderText = "1";
        txtCantidad.Size = new Size(100, 23);
        txtCantidad.TabIndex = 3;
        // 
        // btnGenerar
        // 
        btnGenerar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnGenerar.BackColor = Color.FromArgb(232, 245, 233);
        btnGenerar.FlatStyle = FlatStyle.Standard;
        btnGenerar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnGenerar.ForeColor = Color.Black;
        btnGenerar.Location = new Point(915, 20);
        btnGenerar.Name = "btnGenerar";
        btnGenerar.Size = new Size(115, 28);
        btnGenerar.TabIndex = 4;
        btnGenerar.Text = "Agregar";
        btnGenerar.UseVisualStyleBackColor = false;
        btnGenerar.Click += BtnGenerar_Click;
        // 
        // pnlDetalleContainer
        // 
        pnlDetalleContainer.BackColor = SystemColors.Control;
        pnlDetalleContainer.Controls.Add(grpDetalle);
        pnlDetalleContainer.Dock = DockStyle.Fill;
        pnlDetalleContainer.Location = new Point(0, 222);
        pnlDetalleContainer.Name = "pnlDetalleContainer";
        pnlDetalleContainer.Padding = new Padding(8, 2, 8, 2);
        pnlDetalleContainer.Size = new Size(1060, 356);
        pnlDetalleContainer.TabIndex = 3;
        // 
        // grpDetalle
        // 
        grpDetalle.BackColor = SystemColors.Control;
        grpDetalle.Controls.Add(dgvActivosFisicos);
        grpDetalle.Controls.Add(pnlDetalleFooter);
        grpDetalle.Dock = DockStyle.Fill;
        grpDetalle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        grpDetalle.ForeColor = Color.Black;
        grpDetalle.Location = new Point(8, 2);
        grpDetalle.Name = "grpDetalle";
        grpDetalle.Padding = new Padding(8);
        grpDetalle.Size = new Size(1044, 352);
        grpDetalle.TabIndex = 0;
        grpDetalle.TabStop = false;
        grpDetalle.Text = "Activos Físicos Generados (Etiquetas QR)";
        // 
        // dgvActivosFisicos
        // 
        dgvActivosFisicos.AllowUserToAddRows = false;
        dgvActivosFisicos.AllowUserToDeleteRows = false;
        dgvActivosFisicos.AllowUserToResizeRows = false;
        dgvActivosFisicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvActivosFisicos.BackgroundColor = Color.White;
        dgvActivosFisicos.BorderStyle = BorderStyle.FixedSingle;
        dgvHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dgvHeaderStyle.BackColor = SystemColors.Control;
        dgvHeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        dgvHeaderStyle.ForeColor = Color.Black;
        dgvHeaderStyle.SelectionBackColor = SystemColors.Highlight;
        dgvHeaderStyle.SelectionForeColor = SystemColors.HighlightText;
        dgvHeaderStyle.WrapMode = DataGridViewTriState.True;
        dgvActivosFisicos.ColumnHeadersDefaultCellStyle = dgvHeaderStyle;
        dgvActivosFisicos.ColumnHeadersHeight = 26;
        dgvCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dgvCellStyle.BackColor = SystemColors.Window;
        dgvCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        dgvCellStyle.ForeColor = Color.Black;
        dgvCellStyle.SelectionBackColor = SystemColors.Highlight;
        dgvCellStyle.SelectionForeColor = SystemColors.HighlightText;
        dgvCellStyle.WrapMode = DataGridViewTriState.False;
        dgvActivosFisicos.DefaultCellStyle = dgvCellStyle;
        dgvActivosFisicos.Dock = DockStyle.Fill;
        dgvActivosFisicos.EnableHeadersVisualStyles = true;
        dgvActivosFisicos.Location = new Point(8, 22);
        dgvActivosFisicos.MultiSelect = false;
        dgvActivosFisicos.Name = "dgvActivosFisicos";
        dgvActivosFisicos.ReadOnly = true;
        dgvActivosFisicos.RowHeadersVisible = true;
        dgvActivosFisicos.RowHeadersWidth = 25;
        dgvActivosFisicos.RowTemplate.Height = 24;
        dgvActivosFisicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvActivosFisicos.Size = new Size(1028, 286);
        dgvActivosFisicos.TabIndex = 0;
        // 
        // pnlDetalleFooter
        // 
        pnlDetalleFooter.BackColor = SystemColors.Control;
        pnlDetalleFooter.Controls.Add(lblTotalActivos);
        pnlDetalleFooter.Controls.Add(btnQuitar);
        pnlDetalleFooter.Dock = DockStyle.Bottom;
        pnlDetalleFooter.Location = new Point(8, 308);
        pnlDetalleFooter.Name = "pnlDetalleFooter";
        pnlDetalleFooter.Size = new Size(1028, 36);
        pnlDetalleFooter.TabIndex = 1;
        // 
        // lblTotalActivos
        // 
        lblTotalActivos.AutoSize = true;
        lblTotalActivos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblTotalActivos.ForeColor = Color.Black;
        lblTotalActivos.Location = new Point(2, 10);
        lblTotalActivos.Name = "lblTotalActivos";
        lblTotalActivos.Size = new Size(241, 15);
        lblTotalActivos.TabIndex = 0;
        lblTotalActivos.Text = "Total de activos físicos generados (AF): 0";
        // 
        // btnQuitar
        // 
        btnQuitar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnQuitar.BackColor = Color.FromArgb(255, 235, 238);
        btnQuitar.FlatStyle = FlatStyle.Standard;
        btnQuitar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnQuitar.ForeColor = Color.Black;
        btnQuitar.Location = new Point(913, 5);
        btnQuitar.Name = "btnQuitar";
        btnQuitar.Size = new Size(115, 28);
        btnQuitar.TabIndex = 1;
        btnQuitar.Text = "Eliminar Fila";
        btnQuitar.UseVisualStyleBackColor = false;
        btnQuitar.Click += BtnQuitar_Click;
        // 
        // pnlAcciones
        // 
        pnlAcciones.BackColor = SystemColors.Control;
        pnlAcciones.Controls.Add(btnLimpiar);
        pnlAcciones.Controls.Add(btnProcesar);
        pnlAcciones.Dock = DockStyle.Bottom;
        pnlAcciones.Location = new Point(0, 578);
        pnlAcciones.Name = "pnlAcciones";
        pnlAcciones.Size = new Size(1060, 42);
        pnlAcciones.TabIndex = 4;
        // 
        // btnLimpiar
        // 
        btnLimpiar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnLimpiar.BackColor = Color.FromArgb(224, 247, 250);
        btnLimpiar.FlatStyle = FlatStyle.Standard;
        btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnLimpiar.ForeColor = Color.Black;
        btnLimpiar.Location = new Point(780, 7);
        btnLimpiar.Name = "btnLimpiar";
        btnLimpiar.Size = new Size(125, 28);
        btnLimpiar.TabIndex = 0;
        btnLimpiar.Text = "Limpiar Campos";
        btnLimpiar.UseVisualStyleBackColor = false;
        btnLimpiar.Click += BtnLimpiar_Click;
        // 
        // btnProcesar
        // 
        btnProcesar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnProcesar.BackColor = Color.FromArgb(232, 245, 233);
        btnProcesar.FlatStyle = FlatStyle.Standard;
        btnProcesar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnProcesar.ForeColor = Color.Black;
        btnProcesar.Location = new Point(912, 7);
        btnProcesar.Name = "btnProcesar";
        btnProcesar.Size = new Size(140, 28);
        btnProcesar.TabIndex = 1;
        btnProcesar.Text = "Guardar Entrada";
        btnProcesar.UseVisualStyleBackColor = false;
        btnProcesar.Click += BtnProcesar_Click;
        // 
        // FrmEntradas
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        ClientSize = new Size(1060, 620);
        Controls.Add(pnlDetalleContainer);
        Controls.Add(pnlAcciones);
        Controls.Add(pnlGeneracionContainer);
        Controls.Add(pnlCabeceraContainer);
        Controls.Add(pnlTop);
        Name = "FrmEntradas";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Recepción y Entrada de Activos";
        Load += FrmEntradas_Load;
        ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
        pnlTop.ResumeLayout(false);
        pnlCabeceraContainer.ResumeLayout(false);
        grpCabecera.ResumeLayout(false);
        grpCabecera.PerformLayout();
        pnlGeneracionContainer.ResumeLayout(false);
        grpGeneracion.ResumeLayout(false);
        grpGeneracion.PerformLayout();
        pnlDetalleContainer.ResumeLayout(false);
        grpDetalle.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvActivosFisicos).EndInit();
        pnlDetalleFooter.ResumeLayout(false);
        pnlDetalleFooter.PerformLayout();
        pnlAcciones.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private ErrorProvider errorProvider;
    private Panel pnlTop;
    private Label lblTitulo;
    private Panel pnlCabeceraContainer;
    private GroupBox grpCabecera;
    private Label lblTipoDoc;
    private ComboBox cmbTipoDoc;
    private Label lblNoDoc;
    private TextBox txtNoDoc;
    private Label lblObservacion;
    private TextBox txtObservacion;
    private Panel pnlGeneracionContainer;
    private GroupBox grpGeneracion;
    private Label lblActivo;
    private ComboBox cmbActivo;
    private Label lblCantidad;
    private TextBox txtCantidad;
    private Button btnGenerar;
    private Panel pnlDetalleContainer;
    private GroupBox grpDetalle;
    private DataGridView dgvActivosFisicos;
    private Panel pnlDetalleFooter;
    private Label lblTotalActivos;
    private Button btnQuitar;
    private Panel pnlAcciones;
    private Button btnProcesar;
    private Button btnLimpiar;
}
