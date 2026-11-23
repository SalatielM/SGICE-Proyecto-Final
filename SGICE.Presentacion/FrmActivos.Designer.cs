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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmActivos));
        errorProvider = new ErrorProvider(components);
        pnlTop = new Panel();
        lblTitulo = new Label();
        pnlFiltro = new Panel();
        lblBuscar = new Label();
        txtBuscar = new TextBox();
        btnBuscar = new Button();
        pnlDatos = new Panel();
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
        btnNuevo = new Button();
        btnGuardar = new Button();
        btnCancelar = new Button();
        dgvActivos = new DataGridView();
        pictureBox1 = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
        pnlTop.SuspendLayout();
        pnlFiltro.SuspendLayout();
        pnlDatos.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvActivos).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // errorProvider
        // 
        errorProvider.ContainerControl = this;
        // 
        // pnlTop
        // 
        pnlTop.BackColor = Color.Purple;
        pnlTop.Controls.Add(pictureBox1);
        pnlTop.Controls.Add(lblTitulo);
        pnlTop.Dock = DockStyle.Top;
        pnlTop.Location = new Point(0, 0);
        pnlTop.Name = "pnlTop";
        pnlTop.Size = new Size(667, 74);
        pnlTop.TabIndex = 0;
        // 
        // lblTitulo
        // 
        lblTitulo.AutoSize = true;
        lblTitulo.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.White;
        lblTitulo.Location = new Point(217, 23);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(247, 31);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "Catálogo de Activos";
        // 
        // pnlFiltro
        // 
        pnlFiltro.BackColor = Color.FromArgb(248, 250, 252);
        pnlFiltro.Controls.Add(lblBuscar);
        pnlFiltro.Controls.Add(txtBuscar);
        pnlFiltro.Controls.Add(btnBuscar);
        pnlFiltro.Dock = DockStyle.Top;
        pnlFiltro.Location = new Point(0, 74);
        pnlFiltro.Name = "pnlFiltro";
        pnlFiltro.Padding = new Padding(16, 10, 16, 10);
        pnlFiltro.Size = new Size(667, 46);
        pnlFiltro.TabIndex = 1;
        // 
        // lblBuscar
        // 
        lblBuscar.AutoSize = true;
        lblBuscar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblBuscar.ForeColor = Color.FromArgb(51, 65, 85);
        lblBuscar.Location = new Point(16, 15);
        lblBuscar.Name = "lblBuscar";
        lblBuscar.Size = new Size(45, 15);
        lblBuscar.TabIndex = 0;
        lblBuscar.Text = "Buscar:";
        // 
        // txtBuscar
        // 
        txtBuscar.Font = new Font("Segoe UI", 9.5F);
        txtBuscar.Location = new Point(67, 10);
        txtBuscar.Name = "txtBuscar";
        txtBuscar.PlaceholderText = "Nombre del activo, marca o subcategoría...";
        txtBuscar.Size = new Size(300, 24);
        txtBuscar.TabIndex = 1;
        txtBuscar.TextChanged += TxtBuscar_TextChanged;
        // 
        // btnBuscar
        // 
        btnBuscar.BackColor = SystemColors.ActiveBorder;
        btnBuscar.Location = new Point(375, 10);
        btnBuscar.Name = "btnBuscar";
        btnBuscar.Size = new Size(80, 26);
        btnBuscar.TabIndex = 2;
        btnBuscar.Text = "Buscar";
        btnBuscar.UseVisualStyleBackColor = false;
        btnBuscar.Click += BtnBuscar_Click;
        // 
        // pnlDatos
        // 
        pnlDatos.BackColor = Color.White;
        pnlDatos.Controls.Add(lblNombre);
        pnlDatos.Controls.Add(txtNombre);
        pnlDatos.Controls.Add(lblSubCategoria);
        pnlDatos.Controls.Add(cmbSubCategoria);
        pnlDatos.Controls.Add(lblMarca);
        pnlDatos.Controls.Add(cmbMarca);
        pnlDatos.Controls.Add(lblProveedor);
        pnlDatos.Controls.Add(cmbProveedor);
        pnlDatos.Controls.Add(lblPersonal);
        pnlDatos.Controls.Add(cmbPersonal);
        pnlDatos.Controls.Add(lblDescripcion);
        pnlDatos.Controls.Add(txtDescripcion);
        pnlDatos.Controls.Add(btnNuevo);
        pnlDatos.Controls.Add(btnGuardar);
        pnlDatos.Controls.Add(btnCancelar);
        pnlDatos.Dock = DockStyle.Right;
        pnlDatos.Location = new Point(307, 120);
        pnlDatos.Name = "pnlDatos";
        pnlDatos.Padding = new Padding(16);
        pnlDatos.Size = new Size(360, 501);
        pnlDatos.TabIndex = 2;
        // 
        // lblNombre
        // 
        lblNombre.AutoSize = true;
        lblNombre.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblNombre.ForeColor = Color.FromArgb(51, 65, 85);
        lblNombre.Location = new Point(16, 10);
        lblNombre.Name = "lblNombre";
        lblNombre.Size = new Size(110, 15);
        lblNombre.TabIndex = 0;
        lblNombre.Text = "Nombre del Activo:";
        // 
        // txtNombre
        // 
        txtNombre.Font = new Font("Segoe UI", 9.5F);
        txtNombre.Location = new Point(16, 28);
        txtNombre.Name = "txtNombre";
        txtNombre.PlaceholderText = "Laptop Lenovo Core i5, Escritorio...";
        txtNombre.Size = new Size(320, 24);
        txtNombre.TabIndex = 1;
        // 
        // lblSubCategoria
        // 
        lblSubCategoria.AutoSize = true;
        lblSubCategoria.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblSubCategoria.ForeColor = Color.FromArgb(51, 65, 85);
        lblSubCategoria.Location = new Point(16, 60);
        lblSubCategoria.Name = "lblSubCategoria";
        lblSubCategoria.Size = new Size(80, 15);
        lblSubCategoria.TabIndex = 2;
        lblSubCategoria.Text = "Subcategoría:";
        // 
        // cmbSubCategoria
        // 
        cmbSubCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbSubCategoria.Font = new Font("Segoe UI", 9.5F);
        cmbSubCategoria.FormattingEnabled = true;
        cmbSubCategoria.Items.AddRange(new object[] { "Laptop", "Escritorio", "Impresora", "Monitor" });
        cmbSubCategoria.Location = new Point(16, 78);
        cmbSubCategoria.Name = "cmbSubCategoria";
        cmbSubCategoria.Size = new Size(320, 25);
        cmbSubCategoria.TabIndex = 3;
        // 
        // lblMarca
        // 
        lblMarca.AutoSize = true;
        lblMarca.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblMarca.ForeColor = Color.FromArgb(51, 65, 85);
        lblMarca.Location = new Point(16, 110);
        lblMarca.Name = "lblMarca";
        lblMarca.Size = new Size(43, 15);
        lblMarca.TabIndex = 4;
        lblMarca.Text = "Marca:";
        // 
        // cmbMarca
        // 
        cmbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbMarca.Font = new Font("Segoe UI", 9.5F);
        cmbMarca.FormattingEnabled = true;
        cmbMarca.Items.AddRange(new object[] { "Lenovo", "HP", "DELL", "Asus" });
        cmbMarca.Location = new Point(16, 128);
        cmbMarca.Name = "cmbMarca";
        cmbMarca.Size = new Size(320, 25);
        cmbMarca.TabIndex = 5;
        // 
        // lblProveedor
        // 
        lblProveedor.AutoSize = true;
        lblProveedor.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblProveedor.ForeColor = Color.FromArgb(51, 65, 85);
        lblProveedor.Location = new Point(16, 160);
        lblProveedor.Name = "lblProveedor";
        lblProveedor.Size = new Size(64, 15);
        lblProveedor.TabIndex = 6;
        lblProveedor.Text = "Proveedor:";
        // 
        // cmbProveedor
        // 
        cmbProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbProveedor.Font = new Font("Segoe UI", 9.5F);
        cmbProveedor.FormattingEnabled = true;
        cmbProveedor.Items.AddRange(new object[] { "Tech Solution", "Shadday", "Exatech" });
        cmbProveedor.Location = new Point(16, 178);
        cmbProveedor.Name = "cmbProveedor";
        cmbProveedor.Size = new Size(320, 25);
        cmbProveedor.TabIndex = 7;
        // 
        // lblPersonal
        // 
        lblPersonal.AutoSize = true;
        lblPersonal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblPersonal.ForeColor = Color.FromArgb(51, 65, 85);
        lblPersonal.Location = new Point(16, 210);
        lblPersonal.Name = "lblPersonal";
        lblPersonal.Size = new Size(114, 15);
        lblPersonal.TabIndex = 8;
        lblPersonal.Text = "Personal Encargado:";
        // 
        // cmbPersonal
        // 
        cmbPersonal.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbPersonal.Font = new Font("Segoe UI", 9.5F);
        cmbPersonal.FormattingEnabled = true;
        cmbPersonal.Items.AddRange(new object[] { "Luis", "Salatiel", "Wander", "Axel", "Kevin" });
        cmbPersonal.Location = new Point(16, 228);
        cmbPersonal.Name = "cmbPersonal";
        cmbPersonal.Size = new Size(320, 25);
        cmbPersonal.TabIndex = 9;
        // 
        // lblDescripcion
        // 
        lblDescripcion.AutoSize = true;
        lblDescripcion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblDescripcion.ForeColor = Color.FromArgb(51, 65, 85);
        lblDescripcion.Location = new Point(16, 260);
        lblDescripcion.Name = "lblDescripcion";
        lblDescripcion.Size = new Size(159, 15);
        lblDescripcion.TabIndex = 10;
        lblDescripcion.Text = "Descripción / Especificación:";
        // 
        // txtDescripcion
        // 
        txtDescripcion.Font = new Font("Segoe UI", 9.5F);
        txtDescripcion.Location = new Point(16, 278);
        txtDescripcion.Multiline = true;
        txtDescripcion.Name = "txtDescripcion";
        txtDescripcion.Size = new Size(320, 50);
        txtDescripcion.TabIndex = 11;
        // 
        // btnNuevo
        // 
        btnNuevo.BackColor = SystemColors.ActiveBorder;
        btnNuevo.Location = new Point(16, 345);
        btnNuevo.Name = "btnNuevo";
        btnNuevo.Size = new Size(95, 34);
        btnNuevo.TabIndex = 12;
        btnNuevo.Text = "Nuevo";
        btnNuevo.UseVisualStyleBackColor = false;
        btnNuevo.Click += BtnNuevo_Click;
        // 
        // btnGuardar
        // 
        btnGuardar.BackColor = Color.MediumSpringGreen;
        btnGuardar.Location = new Point(122, 345);
        btnGuardar.Name = "btnGuardar";
        btnGuardar.Size = new Size(105, 34);
        btnGuardar.TabIndex = 13;
        btnGuardar.Text = "Guardar";
        btnGuardar.UseVisualStyleBackColor = false;
        btnGuardar.Click += BtnGuardar_Click;
        // 
        // btnCancelar
        // 
        btnCancelar.Location = new Point(238, 345);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new Size(98, 34);
        btnCancelar.TabIndex = 14;
        btnCancelar.Text = "Limpiar";
        btnCancelar.UseVisualStyleBackColor = true;
        btnCancelar.Click += BtnCancelar_Click;
        // 
        // dgvActivos
        // 
        dgvActivos.Dock = DockStyle.Fill;
        dgvActivos.Location = new Point(0, 120);
        dgvActivos.Name = "dgvActivos";
        dgvActivos.Size = new Size(307, 501);
        dgvActivos.TabIndex = 3;
        dgvActivos.CellContentClick += dgvActivos_CellContentClick;
        dgvActivos.SelectionChanged += DgvActivos_SelectionChanged;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(16, 12);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(58, 56);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 1;
        pictureBox1.TabStop = false;
        // 
        // FrmActivos
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(667, 621);
        Controls.Add(dgvActivos);
        Controls.Add(pnlDatos);
        Controls.Add(pnlFiltro);
        Controls.Add(pnlTop);
        Name = "FrmActivos";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Catálogo de Activos";
        Load += FrmActivos_Load;
        ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
        pnlTop.ResumeLayout(false);
        pnlTop.PerformLayout();
        pnlFiltro.ResumeLayout(false);
        pnlFiltro.PerformLayout();
        pnlDatos.ResumeLayout(false);
        pnlDatos.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvActivos).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private ErrorProvider errorProvider;
    private Panel pnlTop;
    private Label lblTitulo;
    private Panel pnlFiltro;
    private Label lblBuscar;
    private TextBox txtBuscar;
    private Button btnBuscar;
    private Panel pnlDatos;
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
    private Button btnNuevo;
    private Button btnGuardar;
    private Button btnCancelar;
    private DataGridView dgvActivos;
    private PictureBox pictureBox1;
}
