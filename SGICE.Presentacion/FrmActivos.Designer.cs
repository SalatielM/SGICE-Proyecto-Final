namespace SGICE.Presentacion;

partial class FrmActivos
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
        pnlFiltro = new Panel();
        txtBuscar = new TextBox();
        btnBuscar = new Button();
        pnlDatosContainer = new Panel();
        grpDatos = new GroupBox();
        lblNombre = new Label();
        txtNombre = new TextBox();
        lblSubCategoria = new Label();
        cmbSubCategoria = new ComboBox();
        lblMarca = new Label();
        cmbMarca = new ComboBox();
        lblProveedor = new Label();
        cmbProveedor = new ComboBox();
        lblPersonal = new Label();
        cmbPersonal = new ComboBox();
        lblDescripcion = new Label();
        txtDescripcion = new TextBox();
        pnlAcciones = new Panel();
        btnNuevo = new Button();
        btnGuardar = new Button();
        btnCancelar = new Button();
        pnlListaContainer = new Panel();
        grpLista = new GroupBox();
        dgvActivos = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
        pnlTop.SuspendLayout();
        pnlFiltro.SuspendLayout();
        pnlDatosContainer.SuspendLayout();
        grpDatos.SuspendLayout();
        pnlAcciones.SuspendLayout();
        pnlListaContainer.SuspendLayout();
        grpLista.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvActivos).BeginInit();
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
        pnlTop.Size = new Size(980, 32);
        pnlTop.TabIndex = 0;
        // 
        // lblTitulo
        // 
        lblTitulo.Dock = DockStyle.Fill;
        lblTitulo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.Black;
        lblTitulo.Location = new Point(0, 0);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(980, 32);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "CATÁLOGO DE ACTIVOS Y MOBILIARIO";
        lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // pnlFiltro
        // 
        pnlFiltro.BackColor = SystemColors.Control;
        pnlFiltro.Controls.Add(txtBuscar);
        pnlFiltro.Controls.Add(btnBuscar);
        pnlFiltro.Dock = DockStyle.Top;
        pnlFiltro.Location = new Point(0, 32);
        pnlFiltro.Name = "pnlFiltro";
        pnlFiltro.Padding = new Padding(8, 6, 8, 4);
        pnlFiltro.Size = new Size(980, 36);
        pnlFiltro.TabIndex = 1;
        // 
        // txtBuscar
        // 
        txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtBuscar.BackColor = SystemColors.Window;
        txtBuscar.BorderStyle = BorderStyle.FixedSingle;
        txtBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        txtBuscar.Location = new Point(8, 7);
        txtBuscar.Name = "txtBuscar";
        txtBuscar.PlaceholderText = "Buscar...";
        txtBuscar.Size = new Size(928, 23);
        txtBuscar.TabIndex = 0;
        txtBuscar.TextChanged += TxtBuscar_TextChanged;
        // 
        // btnBuscar
        // 
        btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnBuscar.BackColor = SystemColors.Control;
        btnBuscar.FlatStyle = FlatStyle.Standard;
        btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnBuscar.ForeColor = Color.Black;
        btnBuscar.Location = new Point(942, 6);
        btnBuscar.Name = "btnBuscar";
        btnBuscar.Size = new Size(30, 24);
        btnBuscar.TabIndex = 1;
        btnBuscar.Text = "🔍";
        btnBuscar.UseVisualStyleBackColor = true;
        btnBuscar.Click += BtnBuscar_Click;
        // 
        // pnlDatosContainer
        // 
        pnlDatosContainer.BackColor = SystemColors.Control;
        pnlDatosContainer.Controls.Add(grpDatos);
        pnlDatosContainer.Dock = DockStyle.Top;
        pnlDatosContainer.Location = new Point(0, 68);
        pnlDatosContainer.Name = "pnlDatosContainer";
        pnlDatosContainer.Padding = new Padding(8, 2, 8, 2);
        pnlDatosContainer.Size = new Size(980, 156);
        pnlDatosContainer.TabIndex = 2;
        // 
        // grpDatos
        // 
        grpDatos.BackColor = SystemColors.Control;
        grpDatos.Controls.Add(lblNombre);
        grpDatos.Controls.Add(txtNombre);
        grpDatos.Controls.Add(lblSubCategoria);
        grpDatos.Controls.Add(cmbSubCategoria);
        grpDatos.Controls.Add(lblMarca);
        grpDatos.Controls.Add(cmbMarca);
        grpDatos.Controls.Add(lblProveedor);
        grpDatos.Controls.Add(cmbProveedor);
        grpDatos.Controls.Add(lblPersonal);
        grpDatos.Controls.Add(cmbPersonal);
        grpDatos.Controls.Add(lblDescripcion);
        grpDatos.Controls.Add(txtDescripcion);
        grpDatos.Dock = DockStyle.Fill;
        grpDatos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        grpDatos.ForeColor = Color.Black;
        grpDatos.Location = new Point(8, 2);
        grpDatos.Name = "grpDatos";
        grpDatos.Size = new Size(964, 152);
        grpDatos.TabIndex = 0;
        grpDatos.TabStop = false;
        grpDatos.Text = "Datos del Activo o Mobiliario";
        // 
        // lblNombre
        // 
        lblNombre.AutoSize = true;
        lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblNombre.ForeColor = Color.Black;
        lblNombre.Location = new Point(12, 26);
        lblNombre.Name = "lblNombre";
        lblNombre.Size = new Size(57, 15);
        lblNombre.TabIndex = 0;
        lblNombre.Text = "Nombre:";
        // 
        // txtNombre
        // 
        txtNombre.BackColor = SystemColors.Window;
        txtNombre.BorderStyle = BorderStyle.FixedSingle;
        txtNombre.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        txtNombre.Location = new Point(98, 23);
        txtNombre.Name = "txtNombre";
        txtNombre.PlaceholderText = "Laptop Lenovo Core i5, Escritorio...";
        txtNombre.Size = new Size(260, 23);
        txtNombre.TabIndex = 1;
        // 
        // lblSubCategoria
        // 
        lblSubCategoria.AutoSize = true;
        lblSubCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblSubCategoria.ForeColor = Color.Black;
        lblSubCategoria.Location = new Point(374, 26);
        lblSubCategoria.Name = "lblSubCategoria";
        lblSubCategoria.Size = new Size(88, 15);
        lblSubCategoria.TabIndex = 2;
        lblSubCategoria.Text = "Subcategoría:";
        // 
        // cmbSubCategoria
        // 
        cmbSubCategoria.BackColor = SystemColors.Window;
        cmbSubCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbSubCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        cmbSubCategoria.FormattingEnabled = true;
        cmbSubCategoria.Location = new Point(468, 23);
        cmbSubCategoria.Name = "cmbSubCategoria";
        cmbSubCategoria.Size = new Size(200, 23);
        cmbSubCategoria.TabIndex = 3;
        // 
        // lblMarca
        // 
        lblMarca.AutoSize = true;
        lblMarca.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblMarca.ForeColor = Color.Black;
        lblMarca.Location = new Point(682, 26);
        lblMarca.Name = "lblMarca";
        lblMarca.Size = new Size(46, 15);
        lblMarca.TabIndex = 4;
        lblMarca.Text = "Marca:";
        // 
        // cmbMarca
        // 
        cmbMarca.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        cmbMarca.BackColor = SystemColors.Window;
        cmbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbMarca.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        cmbMarca.FormattingEnabled = true;
        cmbMarca.Location = new Point(734, 23);
        cmbMarca.Name = "cmbMarca";
        cmbMarca.Size = new Size(216, 23);
        cmbMarca.TabIndex = 5;
        // 
        // lblProveedor
        // 
        lblProveedor.AutoSize = true;
        lblProveedor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblProveedor.ForeColor = Color.Black;
        lblProveedor.Location = new Point(12, 58);
        lblProveedor.Name = "lblProveedor";
        lblProveedor.Size = new Size(69, 15);
        lblProveedor.TabIndex = 6;
        lblProveedor.Text = "Proveedor:";
        // 
        // cmbProveedor
        // 
        cmbProveedor.BackColor = SystemColors.Window;
        cmbProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbProveedor.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        cmbProveedor.FormattingEnabled = true;
        cmbProveedor.Location = new Point(98, 55);
        cmbProveedor.Name = "cmbProveedor";
        cmbProveedor.Size = new Size(260, 23);
        cmbProveedor.TabIndex = 7;
        // 
        // lblPersonal
        // 
        lblPersonal.AutoSize = true;
        lblPersonal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblPersonal.ForeColor = Color.Black;
        lblPersonal.Location = new Point(374, 58);
        lblPersonal.Name = "lblPersonal";
        lblPersonal.Size = new Size(71, 15);
        lblPersonal.TabIndex = 8;
        lblPersonal.Text = "Encargado:";
        // 
        // cmbPersonal
        // 
        cmbPersonal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        cmbPersonal.BackColor = SystemColors.Window;
        cmbPersonal.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbPersonal.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        cmbPersonal.FormattingEnabled = true;
        cmbPersonal.Location = new Point(468, 55);
        cmbPersonal.Name = "cmbPersonal";
        cmbPersonal.Size = new Size(482, 23);
        cmbPersonal.TabIndex = 9;
        // 
        // lblDescripcion
        // 
        lblDescripcion.AutoSize = true;
        lblDescripcion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblDescripcion.ForeColor = Color.Black;
        lblDescripcion.Location = new Point(12, 92);
        lblDescripcion.Name = "lblDescripcion";
        lblDescripcion.Size = new Size(76, 15);
        lblDescripcion.TabIndex = 10;
        lblDescripcion.Text = "Descripción:";
        // 
        // txtDescripcion
        // 
        txtDescripcion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtDescripcion.BackColor = SystemColors.Window;
        txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
        txtDescripcion.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        txtDescripcion.Location = new Point(98, 90);
        txtDescripcion.Multiline = true;
        txtDescripcion.Name = "txtDescripcion";
        txtDescripcion.Size = new Size(852, 45);
        txtDescripcion.TabIndex = 11;
        txtDescripcion.TextChanged += txtDescripcion_TextChanged;
        // 
        // pnlAcciones
        // 
        pnlAcciones.BackColor = SystemColors.Control;
        pnlAcciones.Controls.Add(btnNuevo);
        pnlAcciones.Controls.Add(btnGuardar);
        pnlAcciones.Controls.Add(btnCancelar);
        pnlAcciones.Dock = DockStyle.Top;
        pnlAcciones.Location = new Point(0, 224);
        pnlAcciones.Name = "pnlAcciones";
        pnlAcciones.Size = new Size(980, 38);
        pnlAcciones.TabIndex = 3;
        // 
        // btnNuevo
        // 
        btnNuevo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnNuevo.BackColor = Color.FromArgb(224, 247, 250);
        btnNuevo.FlatStyle = FlatStyle.Standard;
        btnNuevo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnNuevo.ForeColor = Color.Black;
        btnNuevo.Location = new Point(645, 5);
        btnNuevo.Name = "btnNuevo";
        btnNuevo.Size = new Size(105, 28);
        btnNuevo.TabIndex = 0;
        btnNuevo.Text = "Nuevo";
        btnNuevo.UseVisualStyleBackColor = false;
        btnNuevo.Click += BtnNuevo_Click;
        // 
        // btnGuardar
        // 
        btnGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnGuardar.BackColor = Color.FromArgb(232, 245, 233);
        btnGuardar.FlatStyle = FlatStyle.Standard;
        btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnGuardar.ForeColor = Color.Black;
        btnGuardar.Location = new Point(756, 5);
        btnGuardar.Name = "btnGuardar";
        btnGuardar.Size = new Size(105, 28);
        btnGuardar.TabIndex = 1;
        btnGuardar.Text = "Guardar";
        btnGuardar.UseVisualStyleBackColor = false;
        btnGuardar.Click += BtnGuardar_Click;
        // 
        // btnCancelar
        // 
        btnCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnCancelar.BackColor = Color.FromArgb(255, 235, 238);
        btnCancelar.FlatStyle = FlatStyle.Standard;
        btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnCancelar.ForeColor = Color.Black;
        btnCancelar.Location = new Point(867, 5);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new Size(105, 28);
        btnCancelar.TabIndex = 2;
        btnCancelar.Text = "Cancelar";
        btnCancelar.UseVisualStyleBackColor = false;
        btnCancelar.Click += BtnCancelar_Click;
        // 
        // pnlListaContainer
        // 
        pnlListaContainer.BackColor = SystemColors.Control;
        pnlListaContainer.Controls.Add(grpLista);
        pnlListaContainer.Dock = DockStyle.Fill;
        pnlListaContainer.Location = new Point(0, 262);
        pnlListaContainer.Name = "pnlListaContainer";
        pnlListaContainer.Padding = new Padding(8, 2, 8, 8);
        pnlListaContainer.Size = new Size(980, 338);
        pnlListaContainer.TabIndex = 4;
        // 
        // grpLista
        // 
        grpLista.BackColor = SystemColors.Control;
        grpLista.Controls.Add(dgvActivos);
        grpLista.Dock = DockStyle.Fill;
        grpLista.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        grpLista.ForeColor = Color.Black;
        grpLista.Location = new Point(8, 2);
        grpLista.Name = "grpLista";
        grpLista.Padding = new Padding(8);
        grpLista.Size = new Size(964, 328);
        grpLista.TabIndex = 0;
        grpLista.TabStop = false;
        grpLista.Text = "Lista de Activos";
        // 
        // dgvActivos
        // 
        dgvActivos.AllowUserToAddRows = false;
        dgvActivos.AllowUserToDeleteRows = false;
        dgvActivos.AllowUserToResizeRows = false;
        dgvActivos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvActivos.BackgroundColor = Color.White;
        dgvActivos.BorderStyle = BorderStyle.FixedSingle;
        dgvHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dgvHeaderStyle.BackColor = SystemColors.Control;
        dgvHeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        dgvHeaderStyle.ForeColor = Color.Black;
        dgvHeaderStyle.SelectionBackColor = SystemColors.Highlight;
        dgvHeaderStyle.SelectionForeColor = SystemColors.HighlightText;
        dgvHeaderStyle.WrapMode = DataGridViewTriState.True;
        dgvActivos.ColumnHeadersDefaultCellStyle = dgvHeaderStyle;
        dgvActivos.ColumnHeadersHeight = 26;
        dgvCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dgvCellStyle.BackColor = SystemColors.Window;
        dgvCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        dgvCellStyle.ForeColor = Color.Black;
        dgvCellStyle.SelectionBackColor = SystemColors.Highlight;
        dgvCellStyle.SelectionForeColor = SystemColors.HighlightText;
        dgvCellStyle.WrapMode = DataGridViewTriState.False;
        dgvActivos.DefaultCellStyle = dgvCellStyle;
        dgvActivos.Dock = DockStyle.Fill;
        dgvActivos.EnableHeadersVisualStyles = true;
        dgvActivos.Location = new Point(8, 22);
        dgvActivos.MultiSelect = false;
        dgvActivos.Name = "dgvActivos";
        dgvActivos.ReadOnly = true;
        dgvActivos.RowHeadersVisible = true;
        dgvActivos.RowHeadersWidth = 25;
        dgvActivos.RowTemplate.Height = 24;
        dgvActivos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvActivos.Size = new Size(948, 298);
        dgvActivos.TabIndex = 0;
        dgvActivos.CellContentClick += dgvActivos_CellContentClick;
        dgvActivos.SelectionChanged += DgvActivos_SelectionChanged;
        // 
        // FrmActivos
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        ClientSize = new Size(980, 600);
        Controls.Add(pnlListaContainer);
        Controls.Add(pnlAcciones);
        Controls.Add(pnlDatosContainer);
        Controls.Add(pnlFiltro);
        Controls.Add(pnlTop);
        Name = "FrmActivos";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Catálogo de Activos";
        Load += FrmActivos_Load;
        ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
        pnlTop.ResumeLayout(false);
        pnlFiltro.ResumeLayout(false);
        pnlFiltro.PerformLayout();
        pnlDatosContainer.ResumeLayout(false);
        grpDatos.ResumeLayout(false);
        grpDatos.PerformLayout();
        pnlAcciones.ResumeLayout(false);
        pnlListaContainer.ResumeLayout(false);
        grpLista.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvActivos).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private ErrorProvider errorProvider;
    private Panel pnlTop;
    private Label lblTitulo;
    private Panel pnlFiltro;
    private TextBox txtBuscar;
    private Button btnBuscar;
    private Panel pnlDatosContainer;
    private GroupBox grpDatos;
    private Label lblNombre;
    private TextBox txtNombre;
    private Label lblSubCategoria;
    private ComboBox cmbSubCategoria;
    private Label lblMarca;
    private ComboBox cmbMarca;
    private Label lblProveedor;
    private ComboBox cmbProveedor;
    private Label lblPersonal;
    private ComboBox cmbPersonal;
    private Label lblDescripcion;
    private TextBox txtDescripcion;
    private Panel pnlAcciones;
    private Button btnNuevo;
    private Button btnGuardar;
    private Button btnCancelar;
    private Panel pnlListaContainer;
    private GroupBox grpLista;
    private DataGridView dgvActivos;
}
