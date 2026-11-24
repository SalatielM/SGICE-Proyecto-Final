namespace SGICE.Presentacion;

partial class FrmMarcas
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMarcas));
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
        lblDescripcion = new Label();
        txtDescripcion = new TextBox();
        btnNuevo = new Button();
        btnGuardar = new Button();
        btnCancelar = new Button();
        dgvMarcas = new DataGridView();
        pictureBox1 = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
        pnlTop.SuspendLayout();
        pnlFiltro.SuspendLayout();
        pnlDatos.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvMarcas).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // errorProvider
        // 
        errorProvider.ContainerControl = this;
        // 
        // pnlTop
        // 
        pnlTop.BackColor = Color.FromArgb(192, 0, 192);
        pnlTop.Controls.Add(pictureBox1);
        pnlTop.Controls.Add(lblTitulo);
        pnlTop.Dock = DockStyle.Top;
        pnlTop.Location = new Point(0, 0);
        pnlTop.Name = "pnlTop";
        pnlTop.Size = new Size(860, 80);
        pnlTop.TabIndex = 0;
        // 
        // lblTitulo
        // 
        lblTitulo.AutoSize = true;
        lblTitulo.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblTitulo.ForeColor = Color.White;
        lblTitulo.Location = new Point(353, 25);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(249, 31);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "Catálogo de Marcas";
        // 
        // pnlFiltro
        // 
        pnlFiltro.BackColor = Color.FromArgb(248, 250, 252);
        pnlFiltro.Controls.Add(lblBuscar);
        pnlFiltro.Controls.Add(txtBuscar);
        pnlFiltro.Controls.Add(btnBuscar);
        pnlFiltro.Dock = DockStyle.Top;
        pnlFiltro.Location = new Point(0, 80);
        pnlFiltro.Name = "pnlFiltro";
        pnlFiltro.Padding = new Padding(16, 10, 16, 10);
        pnlFiltro.Size = new Size(860, 46);
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
        txtBuscar.PlaceholderText = "Nombre";
        txtBuscar.Size = new Size(280, 24);
        txtBuscar.TabIndex = 1;
        txtBuscar.TextChanged += TxtBuscar_TextChanged;
        // 
        // btnBuscar
        // 
        btnBuscar.BackColor = SystemColors.ActiveBorder;
        btnBuscar.Location = new Point(353, 10);
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
        pnlDatos.Controls.Add(lblDescripcion);
        pnlDatos.Controls.Add(txtDescripcion);
        pnlDatos.Controls.Add(btnNuevo);
        pnlDatos.Controls.Add(btnGuardar);
        pnlDatos.Controls.Add(btnCancelar);
        pnlDatos.Dock = DockStyle.Right;
        pnlDatos.Location = new Point(540, 126);
        pnlDatos.Name = "pnlDatos";
        pnlDatos.Padding = new Padding(16);
        pnlDatos.Size = new Size(320, 435);
        pnlDatos.TabIndex = 2;
        // 
        // lblNombre
        // 
        lblNombre.AutoSize = true;
        lblNombre.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblNombre.ForeColor = Color.FromArgb(51, 65, 85);
        lblNombre.Location = new Point(16, 20);
        lblNombre.Name = "lblNombre";
        lblNombre.Size = new Size(54, 15);
        lblNombre.TabIndex = 0;
        lblNombre.Text = "Nombre:";
        // 
        // txtNombre
        // 
        txtNombre.Font = new Font("Segoe UI", 9.5F);
        txtNombre.Location = new Point(16, 40);
        txtNombre.Name = "txtNombre";
        txtNombre.Size = new Size(280, 24);
        txtNombre.TabIndex = 1;
        // 
        // lblDescripcion
        // 
        lblDescripcion.AutoSize = true;
        lblDescripcion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblDescripcion.ForeColor = Color.FromArgb(51, 65, 85);
        lblDescripcion.Location = new Point(16, 80);
        lblDescripcion.Name = "lblDescripcion";
        lblDescripcion.Size = new Size(73, 15);
        lblDescripcion.TabIndex = 2;
        lblDescripcion.Text = "Descripción:";
        // 
        // txtDescripcion
        // 
        txtDescripcion.Font = new Font("Segoe UI", 9.5F);
        txtDescripcion.Location = new Point(16, 100);
        txtDescripcion.Multiline = true;
        txtDescripcion.Name = "txtDescripcion";
        txtDescripcion.Size = new Size(280, 80);
        txtDescripcion.TabIndex = 3;
        // 
        // btnNuevo
        // 
        btnNuevo.BackColor = SystemColors.ActiveBorder;
        btnNuevo.Location = new Point(16, 200);
        btnNuevo.Name = "btnNuevo";
        btnNuevo.Size = new Size(85, 34);
        btnNuevo.TabIndex = 4;
        btnNuevo.Text = "Nuevo";
        btnNuevo.UseVisualStyleBackColor = false;
        btnNuevo.Click += BtnNuevo_Click;
        // 
        // btnGuardar
        // 
        btnGuardar.BackColor = Color.MediumSpringGreen;
        btnGuardar.Location = new Point(107, 200);
        btnGuardar.Name = "btnGuardar";
        btnGuardar.Size = new Size(95, 34);
        btnGuardar.TabIndex = 5;
        btnGuardar.Text = "Guardar";
        btnGuardar.UseVisualStyleBackColor = false;
        btnGuardar.Click += BtnGuardar_Click;
        // 
        // btnCancelar
        // 
        btnCancelar.BackColor = SystemColors.ActiveBorder;
        btnCancelar.Location = new Point(208, 200);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new Size(88, 34);
        btnCancelar.TabIndex = 6;
        btnCancelar.Text = "Limpiar";
        btnCancelar.UseVisualStyleBackColor = false;
        btnCancelar.Click += BtnCancelar_Click;
        // 
        // dgvMarcas
        // 
        dgvMarcas.Dock = DockStyle.Fill;
        dgvMarcas.Location = new Point(0, 126);
        dgvMarcas.Name = "dgvMarcas";
        dgvMarcas.Size = new Size(540, 435);
        dgvMarcas.TabIndex = 3;
        dgvMarcas.SelectionChanged += DgvMarcas_SelectionChanged;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(57, 9);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(85, 68);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 1;
        pictureBox1.TabStop = false;
        // 
        // FrmMarcas
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(860, 561);
        Controls.Add(dgvMarcas);
        Controls.Add(pnlDatos);
        Controls.Add(pnlFiltro);
        Controls.Add(pnlTop);
        Name = "FrmMarcas";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Gestión de Marcas";
        Load += FrmMarcas_Load;
        ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
        pnlTop.ResumeLayout(false);
        pnlTop.PerformLayout();
        pnlFiltro.ResumeLayout(false);
        pnlFiltro.PerformLayout();
        pnlDatos.ResumeLayout(false);
        pnlDatos.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvMarcas).EndInit();
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
    private Label lblDescripcion;
    private TextBox txtDescripcion;
    private Button btnNuevo;
    private Button btnGuardar;
    private Button btnCancelar;
    private DataGridView dgvMarcas;
    private PictureBox pictureBox1;
}
