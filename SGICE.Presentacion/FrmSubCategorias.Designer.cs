namespace SGICE.Presentacion;

partial class FrmSubCategorias
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
        lblTitulo = new Label();
        pnlFiltro = new Panel();
        lblBuscar = new Label();
        txtBuscar = new TextBox();
        btnBuscar = new Button();
        pnlDatos = new Panel();
        lblCategoria = new Label();
        cmbCategoria = new ComboBox();
        lblNombre = new Label();
        txtNombre = new TextBox();
        lblVidaUtil = new Label();
        txtVidaUtil = new TextBox();
        lblDescripcion = new Label();
        txtDescripcion = new TextBox();
        btnNuevo = new Button();
        btnGuardar = new Button();
        btnCancelar = new Button();
        dgvSubCategorias = new DataGridView();
        pictureBox1 = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
        pnlTop.SuspendLayout();
        pnlFiltro.SuspendLayout();
        pnlDatos.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvSubCategorias).BeginInit();
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
        pnlTop.Size = new Size(920, 88);
        pnlTop.TabIndex = 0;
        pnlTop.Paint += pnlTop_Paint;
        // 
        // lblTitulo
        // 
        lblTitulo.AutoSize = true;
        lblTitulo.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblTitulo.ForeColor = Color.White;
        lblTitulo.Location = new Point(330, 35);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(325, 31);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "Catálogo de Subcategorías";
        // 
        // pnlFiltro
        // 
        pnlFiltro.BackColor = Color.FromArgb(248, 250, 252);
        pnlFiltro.Controls.Add(lblBuscar);
        pnlFiltro.Controls.Add(txtBuscar);
        pnlFiltro.Controls.Add(btnBuscar);
        pnlFiltro.Dock = DockStyle.Top;
        pnlFiltro.Location = new Point(0, 88);
        pnlFiltro.Name = "pnlFiltro";
        pnlFiltro.Padding = new Padding(16, 10, 16, 10);
        pnlFiltro.Size = new Size(920, 46);
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
        txtBuscar.PlaceholderText = "Nombre o categoría...";
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
        pnlDatos.Controls.Add(lblCategoria);
        pnlDatos.Controls.Add(cmbCategoria);
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
        pnlDatos.Location = new Point(580, 134);
        pnlDatos.Name = "pnlDatos";
        pnlDatos.Padding = new Padding(16);
        pnlDatos.Size = new Size(340, 427);
        pnlDatos.TabIndex = 2;
        // 
        // lblCategoria
        // 
        lblCategoria.AutoSize = true;
        lblCategoria.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblCategoria.ForeColor = Color.FromArgb(51, 65, 85);
        lblCategoria.Location = new Point(16, 15);
        lblCategoria.Name = "lblCategoria";
        lblCategoria.Size = new Size(109, 15);
        lblCategoria.TabIndex = 0;
        lblCategoria.Text = "Categoría Principal:";
        // 
        // cmbCategoria
        // 
        cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbCategoria.Font = new Font("Segoe UI", 9.5F);
        cmbCategoria.FormattingEnabled = true;
        cmbCategoria.Location = new Point(16, 35);
        cmbCategoria.Name = "cmbCategoria";
        cmbCategoria.Size = new Size(300, 25);
        cmbCategoria.TabIndex = 1;
        // 
        // lblNombre
        // 
        lblNombre.AutoSize = true;
        lblNombre.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblNombre.ForeColor = Color.FromArgb(51, 65, 85);
        lblNombre.Location = new Point(16, 75);
        lblNombre.Name = "lblNombre";
        lblNombre.Size = new Size(54, 15);
        lblNombre.TabIndex = 2;
        lblNombre.Text = "Nombre:";
        // 
        // txtNombre
        // 
        txtNombre.Font = new Font("Segoe UI", 9.5F);
        txtNombre.Location = new Point(16, 95);
        txtNombre.Name = "txtNombre";
        txtNombre.Size = new Size(300, 24);
        txtNombre.TabIndex = 3;
        // 
        // lblVidaUtil
        // 
        lblVidaUtil.AutoSize = true;
        lblVidaUtil.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblVidaUtil.ForeColor = Color.FromArgb(51, 65, 85);
        lblVidaUtil.Location = new Point(16, 135);
        lblVidaUtil.Name = "lblVidaUtil";
        lblVidaUtil.Size = new Size(93, 15);
        lblVidaUtil.TabIndex = 4;
        lblVidaUtil.Text = "Vida Útil (Años):";
        // 
        // txtVidaUtil
        // 
        txtVidaUtil.Font = new Font("Segoe UI", 9.5F);
        txtVidaUtil.Location = new Point(16, 155);
        txtVidaUtil.Name = "txtVidaUtil";
        txtVidaUtil.Size = new Size(300, 24);
        txtVidaUtil.TabIndex = 5;
        // 
        // lblDescripcion
        // 
        lblDescripcion.AutoSize = true;
        lblDescripcion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblDescripcion.ForeColor = Color.FromArgb(51, 65, 85);
        lblDescripcion.Location = new Point(16, 195);
        lblDescripcion.Name = "lblDescripcion";
        lblDescripcion.Size = new Size(73, 15);
        lblDescripcion.TabIndex = 6;
        lblDescripcion.Text = "Descripción:";
        // 
        // txtDescripcion
        // 
        txtDescripcion.Font = new Font("Segoe UI", 9.5F);
        txtDescripcion.Location = new Point(16, 215);
        txtDescripcion.Multiline = true;
        txtDescripcion.Name = "txtDescripcion";
        txtDescripcion.Size = new Size(300, 60);
        txtDescripcion.TabIndex = 7;
        // 
        // btnNuevo
        // 
        btnNuevo.BackColor = SystemColors.ActiveBorder;
        btnNuevo.Location = new Point(16, 290);
        btnNuevo.Name = "btnNuevo";
        btnNuevo.Size = new Size(90, 34);
        btnNuevo.TabIndex = 8;
        btnNuevo.Text = "Nuevo";
        btnNuevo.UseVisualStyleBackColor = false;
        btnNuevo.BackgroundImageChanged += btnNuevo_BackgroundImageChanged;
        btnNuevo.Click += BtnNuevo_Click;
        // 
        // btnGuardar
        // 
        btnGuardar.BackColor = Color.MediumSpringGreen;
        btnGuardar.Location = new Point(112, 290);
        btnGuardar.Name = "btnGuardar";
        btnGuardar.Size = new Size(100, 34);
        btnGuardar.TabIndex = 9;
        btnGuardar.Text = "Guardar";
        btnGuardar.UseVisualStyleBackColor = false;
        btnGuardar.Click += BtnGuardar_Click;
        // 
        // btnCancelar
        // 
        btnCancelar.Location = new Point(218, 290);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new Size(98, 34);
        btnCancelar.TabIndex = 10;
        btnCancelar.Text = "Limpiar";
        btnCancelar.UseVisualStyleBackColor = true;
        btnCancelar.Click += BtnCancelar_Click;
        // 
        // dgvSubCategorias
        // 
        dgvSubCategorias.Dock = DockStyle.Fill;
        dgvSubCategorias.Location = new Point(0, 134);
        dgvSubCategorias.Name = "dgvSubCategorias";
        dgvSubCategorias.Size = new Size(580, 427);
        dgvSubCategorias.TabIndex = 3;
        dgvSubCategorias.SelectionChanged += DgvSubCategorias_SelectionChanged;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = Properties.Resources.papel;
        pictureBox1.Location = new Point(53, 3);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(86, 76);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 1;
        pictureBox1.TabStop = false;
        // 
        // FrmSubCategorias
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(920, 561);
        Controls.Add(dgvSubCategorias);
        Controls.Add(pnlDatos);
        Controls.Add(pnlFiltro);
        Controls.Add(pnlTop);
        Name = "FrmSubCategorias";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Gestión de Subcategorías";
        Load += FrmSubCategorias_Load;
        ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
        pnlTop.ResumeLayout(false);
        pnlTop.PerformLayout();
        pnlFiltro.ResumeLayout(false);
        pnlFiltro.PerformLayout();
        pnlDatos.ResumeLayout(false);
        pnlDatos.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvSubCategorias).EndInit();
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
    private Label lblCategoria;
    private ComboBox cmbCategoria;
    private Label lblNombre;
    private TextBox txtNombre;
    private Label lblVidaUtil;
    private TextBox txtVidaUtil;
    private Label lblDescripcion;
    private TextBox txtDescripcion;
    private Button btnNuevo;
    private Button btnGuardar;
    private Button btnCancelar;
    private DataGridView dgvSubCategorias;
    private PictureBox pictureBox1;
}
