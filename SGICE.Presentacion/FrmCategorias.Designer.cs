namespace SGICE.Presentacion;

partial class FrmCategorias
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
        errorProvider = new ErrorProvider(components);
        pnlTop = new Panel();
        pictureBox1 = new PictureBox();
        lblTitulo = new Label();
        pnlFiltro = new Panel();
        lblBuscar = new Label();
        txtBuscar = new TextBox();
        btnBuscar = new Button();
        pnlDatos = new Panel();
        lblNombre = new Label();
        txtNombre = new TextBox();
        lblVidaUtil = new Label();
        txtVidaUtil = new TextBox();
        lblDescripcion = new Label();
        txtDescripcion = new TextBox();
        btnNuevo = new Button();
        btnGuardar = new Button();
        btnCancelar = new Button();
        dgvCategorias = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
        pnlTop.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        pnlFiltro.SuspendLayout();
        pnlDatos.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
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
        pnlTop.Size = new Size(644, 73);
        pnlTop.TabIndex = 0;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = Properties.Resources.lista_en_linea;
        pictureBox1.Location = new Point(36, 3);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(77, 64);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 1;
        pictureBox1.TabStop = false;
        // 
        // lblTitulo
        // 
        lblTitulo.AutoSize = true;
        lblTitulo.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.White;
        lblTitulo.Location = new Point(201, 18);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(288, 31);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "Catálogo de Categorías";
        // 
        // pnlFiltro
        // 
        pnlFiltro.BackColor = Color.FromArgb(248, 250, 252);
        pnlFiltro.Controls.Add(lblBuscar);
        pnlFiltro.Controls.Add(txtBuscar);
        pnlFiltro.Controls.Add(btnBuscar);
        pnlFiltro.Dock = DockStyle.Top;
        pnlFiltro.Location = new Point(0, 73);
        pnlFiltro.Name = "pnlFiltro";
        pnlFiltro.Padding = new Padding(16, 10, 16, 10);
        pnlFiltro.Size = new Size(644, 46);
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
        pnlDatos.Controls.Add(lblVidaUtil);
        pnlDatos.Controls.Add(txtVidaUtil);
        pnlDatos.Controls.Add(lblDescripcion);
        pnlDatos.Controls.Add(txtDescripcion);
        pnlDatos.Controls.Add(btnNuevo);
        pnlDatos.Controls.Add(btnGuardar);
        pnlDatos.Controls.Add(btnCancelar);
        pnlDatos.Dock = DockStyle.Right;
        pnlDatos.Location = new Point(324, 119);
        pnlDatos.Name = "pnlDatos";
        pnlDatos.Padding = new Padding(16);
        pnlDatos.Size = new Size(320, 442);
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
        // lblVidaUtil
        // 
        lblVidaUtil.AutoSize = true;
        lblVidaUtil.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblVidaUtil.ForeColor = Color.FromArgb(51, 65, 85);
        lblVidaUtil.Location = new Point(16, 80);
        lblVidaUtil.Name = "lblVidaUtil";
        lblVidaUtil.Size = new Size(93, 15);
        lblVidaUtil.TabIndex = 2;
        lblVidaUtil.Text = "Vida Útil (Años):";
        // 
        // txtVidaUtil
        // 
        txtVidaUtil.Font = new Font("Segoe UI", 9.5F);
        txtVidaUtil.Location = new Point(16, 100);
        txtVidaUtil.Name = "txtVidaUtil";
        txtVidaUtil.Size = new Size(280, 24);
        txtVidaUtil.TabIndex = 3;
        txtVidaUtil.TextChanged += txtVidaUtil_TextChanged;
        // 
        // lblDescripcion
        // 
        lblDescripcion.AutoSize = true;
        lblDescripcion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblDescripcion.ForeColor = Color.FromArgb(51, 65, 85);
        lblDescripcion.Location = new Point(16, 140);
        lblDescripcion.Name = "lblDescripcion";
        lblDescripcion.Size = new Size(73, 15);
        lblDescripcion.TabIndex = 4;
        lblDescripcion.Text = "Descripción:";
        // 
        // txtDescripcion
        // 
        txtDescripcion.Font = new Font("Segoe UI", 9.5F);
        txtDescripcion.Location = new Point(16, 160);
        txtDescripcion.Multiline = true;
        txtDescripcion.Name = "txtDescripcion";
        txtDescripcion.Size = new Size(280, 70);
        txtDescripcion.TabIndex = 5;
        // 
        // btnNuevo
        // 
        btnNuevo.BackColor = SystemColors.ActiveBorder;
        btnNuevo.Location = new Point(16, 250);
        btnNuevo.Name = "btnNuevo";
        btnNuevo.Size = new Size(85, 34);
        btnNuevo.TabIndex = 6;
        btnNuevo.Text = "Nuevo";
        btnNuevo.UseVisualStyleBackColor = false;
        btnNuevo.Click += BtnNuevo_Click;
        // 
        // btnGuardar
        // 
        btnGuardar.BackColor = Color.MediumSpringGreen;
        btnGuardar.Location = new Point(107, 250);
        btnGuardar.Name = "btnGuardar";
        btnGuardar.Size = new Size(95, 34);
        btnGuardar.TabIndex = 7;
        btnGuardar.Text = "Guardar";
        btnGuardar.UseVisualStyleBackColor = false;
        btnGuardar.Click += BtnGuardar_Click;
        // 
        // btnCancelar
        // 
        btnCancelar.Location = new Point(208, 250);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new Size(88, 34);
        btnCancelar.TabIndex = 8;
        btnCancelar.Text = "Limpiar";
        btnCancelar.UseVisualStyleBackColor = true;
        btnCancelar.Click += BtnCancelar_Click;
        // 
        // dgvCategorias
        // 
        dgvCategorias.Dock = DockStyle.Fill;
        dgvCategorias.Location = new Point(0, 119);
        dgvCategorias.Name = "dgvCategorias";
        dgvCategorias.Size = new Size(324, 442);
        dgvCategorias.TabIndex = 3;
        dgvCategorias.SelectionChanged += DgvCategorias_SelectionChanged;
        // 
        // FrmCategorias
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(644, 561);
        Controls.Add(dgvCategorias);
        Controls.Add(pnlDatos);
        Controls.Add(pnlFiltro);
        Controls.Add(pnlTop);
        Name = "FrmCategorias";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Gestión de Categorías";
        Load += FrmCategorias_Load;
        ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
        pnlTop.ResumeLayout(false);
        pnlTop.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        pnlFiltro.ResumeLayout(false);
        pnlFiltro.PerformLayout();
        pnlDatos.ResumeLayout(false);
        pnlDatos.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
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
    private Label lblVidaUtil;
    private TextBox txtVidaUtil;
    private Label lblDescripcion;
    private TextBox txtDescripcion;
    private Button btnNuevo;
    private Button btnGuardar;
    private Button btnCancelar;
    private DataGridView dgvCategorias;
    private PictureBox pictureBox1;
}
