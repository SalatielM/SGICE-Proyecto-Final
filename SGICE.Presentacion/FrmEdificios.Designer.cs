namespace SGICE.Presentacion;

partial class FrmEdificios
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
        lblCodigo = new Label();
        txtCodigo = new TextBox();
        lblNombre = new Label();
        txtNombre = new TextBox();
        lblPisos = new Label();
        txtPisos = new TextBox();
        lblDescripcion = new Label();
        txtDescripcion = new TextBox();
        btnNuevo = new Button();
        btnGuardar = new Button();
        btnCancelar = new Button();
        dgvEdificios = new DataGridView();
        pictureBox1 = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
        pnlTop.SuspendLayout();
        pnlFiltro.SuspendLayout();
        pnlDatos.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvEdificios).BeginInit();
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
        pnlTop.Size = new Size(900, 80);
        pnlTop.TabIndex = 0;
        // 
        // lblTitulo
        // 
        lblTitulo.AutoSize = true;
        lblTitulo.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblTitulo.ForeColor = Color.White;
        lblTitulo.Location = new Point(292, 24);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(242, 31);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "Gestion de edificios";
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
        pnlFiltro.Size = new Size(900, 46);
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
        txtBuscar.PlaceholderText = "Código o nombre del edificio...";
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
        pnlDatos.Controls.Add(lblCodigo);
        pnlDatos.Controls.Add(txtCodigo);
        pnlDatos.Controls.Add(lblNombre);
        pnlDatos.Controls.Add(txtNombre);
        pnlDatos.Controls.Add(lblPisos);
        pnlDatos.Controls.Add(txtPisos);
        pnlDatos.Controls.Add(lblDescripcion);
        pnlDatos.Controls.Add(txtDescripcion);
        pnlDatos.Controls.Add(btnNuevo);
        pnlDatos.Controls.Add(btnGuardar);
        pnlDatos.Controls.Add(btnCancelar);
        pnlDatos.Dock = DockStyle.Right;
        pnlDatos.Location = new Point(570, 126);
        pnlDatos.Name = "pnlDatos";
        pnlDatos.Padding = new Padding(16);
        pnlDatos.Size = new Size(330, 435);
        pnlDatos.TabIndex = 2;
        // 
        // lblCodigo
        // 
        lblCodigo.AutoSize = true;
        lblCodigo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblCodigo.ForeColor = Color.FromArgb(51, 65, 85);
        lblCodigo.Location = new Point(16, 15);
        lblCodigo.Name = "lblCodigo";
        lblCodigo.Size = new Size(90, 15);
        lblCodigo.TabIndex = 0;
        lblCodigo.Text = "Código Edificio:";
        // 
        // txtCodigo
        // 
        txtCodigo.Font = new Font("Segoe UI", 9.5F);
        txtCodigo.Location = new Point(16, 35);
        txtCodigo.Name = "txtCodigo";
        txtCodigo.PlaceholderText = "EDIF-01";
        txtCodigo.Size = new Size(290, 24);
        txtCodigo.TabIndex = 1;
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
        txtNombre.Size = new Size(290, 24);
        txtNombre.TabIndex = 3;
        // 
        // lblPisos
        // 
        lblPisos.AutoSize = true;
        lblPisos.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblPisos.ForeColor = Color.FromArgb(51, 65, 85);
        lblPisos.Location = new Point(16, 135);
        lblPisos.Name = "lblPisos";
        lblPisos.Size = new Size(103, 15);
        lblPisos.TabIndex = 4;
        lblPisos.Text = "Cantidad de Pisos:";
        // 
        // txtPisos
        // 
        txtPisos.Font = new Font("Segoe UI", 9.5F);
        txtPisos.Location = new Point(16, 155);
        txtPisos.Name = "txtPisos";
        txtPisos.Size = new Size(290, 24);
        txtPisos.TabIndex = 5;
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
        txtDescripcion.Size = new Size(290, 60);
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
        btnNuevo.Click += BtnNuevo_Click;
        // 
        // btnGuardar
        // 
        btnGuardar.BackColor = Color.MediumSpringGreen;
        btnGuardar.Location = new Point(112, 290);
        btnGuardar.Name = "btnGuardar";
        btnGuardar.Size = new Size(95, 34);
        btnGuardar.TabIndex = 9;
        btnGuardar.Text = "Guardar";
        btnGuardar.UseVisualStyleBackColor = false;
        btnGuardar.Click += BtnGuardar_Click;
        // 
        // btnCancelar
        // 
        btnCancelar.Location = new Point(213, 290);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new Size(93, 34);
        btnCancelar.TabIndex = 10;
        btnCancelar.Text = "Limpiar";
        btnCancelar.UseVisualStyleBackColor = true;
        btnCancelar.Click += BtnCancelar_Click;
        // 
        // dgvEdificios
        // 
        dgvEdificios.Dock = DockStyle.Fill;
        dgvEdificios.Location = new Point(0, 126);
        dgvEdificios.Name = "dgvEdificios";
        dgvEdificios.Size = new Size(570, 435);
        dgvEdificios.TabIndex = 3;
        dgvEdificios.SelectionChanged += DgvEdificios_SelectionChanged;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = Properties.Resources.gestion_de_pedidos;
        pictureBox1.Location = new Point(33, 9);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(94, 65);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 1;
        pictureBox1.TabStop = false;
        // 
        // FrmEdificios
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(900, 561);
        Controls.Add(dgvEdificios);
        Controls.Add(pnlDatos);
        Controls.Add(pnlFiltro);
        Controls.Add(pnlTop);
        Name = "FrmEdificios";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Gestión de Edificios";
        Load += FrmEdificios_Load;
        ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
        pnlTop.ResumeLayout(false);
        pnlTop.PerformLayout();
        pnlFiltro.ResumeLayout(false);
        pnlFiltro.PerformLayout();
        pnlDatos.ResumeLayout(false);
        pnlDatos.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvEdificios).EndInit();
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
    private Label lblCodigo;
    private TextBox txtCodigo;
    private Label lblNombre;
    private TextBox txtNombre;
    private Label lblPisos;
    private TextBox txtPisos;
    private Label lblDescripcion;
    private TextBox txtDescripcion;
    private Button btnNuevo;
    private Button btnGuardar;
    private Button btnCancelar;
    private DataGridView dgvEdificios;
    private PictureBox pictureBox1;
}
