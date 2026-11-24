namespace SGICE.Presentacion;

partial class FrmProveedores
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
        lblRNC = new Label();
        txtRNC = new TextBox();
        lblNombre = new Label();
        txtNombre = new TextBox();
        lblTelefono = new Label();
        txtTelefono = new TextBox();
        lblCorreo = new Label();
        txtCorreo = new TextBox();
        lblContacto = new Label();
        txtContacto = new TextBox();
        lblDireccion = new Label();
        txtDireccion = new TextBox();
        btnNuevo = new Button();
        btnGuardar = new Button();
        btnCancelar = new Button();
        dgvProveedores = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
        pnlTop.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        pnlFiltro.SuspendLayout();
        pnlDatos.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
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
        pnlTop.Size = new Size(960, 66);
        pnlTop.TabIndex = 0;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = Properties.Resources.proveedor;
        pictureBox1.Location = new Point(30, 3);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(79, 60);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 1;
        pictureBox1.TabStop = false;
        // 
        // lblTitulo
        // 
        lblTitulo.AutoSize = true;
        lblTitulo.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblTitulo.ForeColor = Color.White;
        lblTitulo.Location = new Point(322, 20);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(306, 31);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "Catálogo de Proveedores";
        // 
        // pnlFiltro
        // 
        pnlFiltro.BackColor = Color.FromArgb(248, 250, 252);
        pnlFiltro.Controls.Add(lblBuscar);
        pnlFiltro.Controls.Add(txtBuscar);
        pnlFiltro.Controls.Add(btnBuscar);
        pnlFiltro.Dock = DockStyle.Top;
        pnlFiltro.Location = new Point(0, 66);
        pnlFiltro.Name = "pnlFiltro";
        pnlFiltro.Padding = new Padding(16, 10, 16, 10);
        pnlFiltro.Size = new Size(960, 46);
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
        txtBuscar.PlaceholderText = "RNC o nombre del proveedor...";
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
        pnlDatos.Controls.Add(lblRNC);
        pnlDatos.Controls.Add(txtRNC);
        pnlDatos.Controls.Add(lblNombre);
        pnlDatos.Controls.Add(txtNombre);
        pnlDatos.Controls.Add(lblTelefono);
        pnlDatos.Controls.Add(txtTelefono);
        pnlDatos.Controls.Add(lblCorreo);
        pnlDatos.Controls.Add(txtCorreo);
        pnlDatos.Controls.Add(lblContacto);
        pnlDatos.Controls.Add(txtContacto);
        pnlDatos.Controls.Add(lblDireccion);
        pnlDatos.Controls.Add(txtDireccion);
        pnlDatos.Controls.Add(btnNuevo);
        pnlDatos.Controls.Add(btnGuardar);
        pnlDatos.Controls.Add(btnCancelar);
        pnlDatos.Dock = DockStyle.Right;
        pnlDatos.Location = new Point(610, 112);
        pnlDatos.Name = "pnlDatos";
        pnlDatos.Padding = new Padding(16);
        pnlDatos.Size = new Size(350, 469);
        pnlDatos.TabIndex = 2;
        // 
        // lblRNC
        // 
        lblRNC.AutoSize = true;
        lblRNC.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblRNC.ForeColor = Color.FromArgb(51, 65, 85);
        lblRNC.Location = new Point(16, 10);
        lblRNC.Name = "lblRNC";
        lblRNC.Size = new Size(33, 15);
        lblRNC.TabIndex = 0;
        lblRNC.Text = "RNC:";
        // 
        // txtRNC
        // 
        txtRNC.Font = new Font("Segoe UI", 9.5F);
        txtRNC.Location = new Point(16, 28);
        txtRNC.Name = "txtRNC";
        txtRNC.PlaceholderText = "101-12345-6";
        txtRNC.Size = new Size(310, 24);
        txtRNC.TabIndex = 1;
        // 
        // lblNombre
        // 
        lblNombre.AutoSize = true;
        lblNombre.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblNombre.ForeColor = Color.FromArgb(51, 65, 85);
        lblNombre.Location = new Point(16, 60);
        lblNombre.Name = "lblNombre";
        lblNombre.Size = new Size(57, 15);
        lblNombre.TabIndex = 2;
        lblNombre.Text = " Nombre:";
        lblNombre.Click += lblNombre_Click;
        // 
        // txtNombre
        // 
        txtNombre.Font = new Font("Segoe UI", 9.5F);
        txtNombre.Location = new Point(16, 78);
        txtNombre.Name = "txtNombre";
        txtNombre.Size = new Size(310, 24);
        txtNombre.TabIndex = 3;
        // 
        // lblTelefono
        // 
        lblTelefono.AutoSize = true;
        lblTelefono.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblTelefono.ForeColor = Color.FromArgb(51, 65, 85);
        lblTelefono.Location = new Point(16, 110);
        lblTelefono.Name = "lblTelefono";
        lblTelefono.Size = new Size(56, 15);
        lblTelefono.TabIndex = 4;
        lblTelefono.Text = "Teléfono:";
        // 
        // txtTelefono
        // 
        txtTelefono.Font = new Font("Segoe UI", 9.5F);
        txtTelefono.Location = new Point(16, 128);
        txtTelefono.Name = "txtTelefono";
        txtTelefono.PlaceholderText = "809-555-0100";
        txtTelefono.Size = new Size(310, 24);
        txtTelefono.TabIndex = 5;
        // 
        // lblCorreo
        // 
        lblCorreo.AutoSize = true;
        lblCorreo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblCorreo.ForeColor = Color.FromArgb(51, 65, 85);
        lblCorreo.Location = new Point(16, 160);
        lblCorreo.Name = "lblCorreo";
        lblCorreo.Size = new Size(107, 15);
        lblCorreo.TabIndex = 6;
        lblCorreo.Text = "Correo Electrónico:";
        // 
        // txtCorreo
        // 
        txtCorreo.Font = new Font("Segoe UI", 9.5F);
        txtCorreo.Location = new Point(16, 178);
        txtCorreo.Name = "txtCorreo";
        txtCorreo.PlaceholderText = "ventas@proveedor.com";
        txtCorreo.Size = new Size(310, 24);
        txtCorreo.TabIndex = 7;
        // 
        // lblContacto
        // 
        lblContacto.AutoSize = true;
        lblContacto.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblContacto.ForeColor = Color.FromArgb(51, 65, 85);
        lblContacto.Location = new Point(16, 210);
        lblContacto.Name = "lblContacto";
        lblContacto.Size = new Size(103, 15);
        lblContacto.TabIndex = 8;
        lblContacto.Text = "Persona Contacto:";
        // 
        // txtContacto
        // 
        txtContacto.Font = new Font("Segoe UI", 9.5F);
        txtContacto.Location = new Point(16, 228);
        txtContacto.Name = "txtContacto";
        txtContacto.Size = new Size(310, 24);
        txtContacto.TabIndex = 9;
        // 
        // lblDireccion
        // 
        lblDireccion.AutoSize = true;
        lblDireccion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblDireccion.ForeColor = Color.FromArgb(51, 65, 85);
        lblDireccion.Location = new Point(16, 260);
        lblDireccion.Name = "lblDireccion";
        lblDireccion.Size = new Size(61, 15);
        lblDireccion.TabIndex = 10;
        lblDireccion.Text = "Dirección:";
        // 
        // txtDireccion
        // 
        txtDireccion.Font = new Font("Segoe UI", 9.5F);
        txtDireccion.Location = new Point(16, 278);
        txtDireccion.Multiline = true;
        txtDireccion.Name = "txtDireccion";
        txtDireccion.Size = new Size(310, 50);
        txtDireccion.TabIndex = 11;
        // 
        // btnNuevo
        // 
        btnNuevo.BackColor = SystemColors.ActiveCaption;
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
        btnGuardar.Location = new Point(119, 345);
        btnGuardar.Name = "btnGuardar";
        btnGuardar.Size = new Size(105, 34);
        btnGuardar.TabIndex = 13;
        btnGuardar.Text = "Guardar";
        btnGuardar.UseVisualStyleBackColor = false;
        btnGuardar.Click += BtnGuardar_Click;
        // 
        // btnCancelar
        // 
        btnCancelar.Location = new Point(232, 345);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new Size(94, 34);
        btnCancelar.TabIndex = 14;
        btnCancelar.Text = "Limpiar";
        btnCancelar.UseVisualStyleBackColor = true;
        btnCancelar.Click += BtnCancelar_Click;
        // 
        // dgvProveedores
        // 
        dgvProveedores.Dock = DockStyle.Fill;
        dgvProveedores.Location = new Point(0, 112);
        dgvProveedores.Name = "dgvProveedores";
        dgvProveedores.Size = new Size(610, 469);
        dgvProveedores.TabIndex = 3;
        dgvProveedores.SelectionChanged += DgvProveedores_SelectionChanged;
        // 
        // FrmProveedores
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(960, 581);
        Controls.Add(dgvProveedores);
        Controls.Add(pnlDatos);
        Controls.Add(pnlFiltro);
        Controls.Add(pnlTop);
        Name = "FrmProveedores";
        StartPosition = FormStartPosition.CenterScreen;
        Text = " ";
        Load += FrmProveedores_Load;
        ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
        pnlTop.ResumeLayout(false);
        pnlTop.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        pnlFiltro.ResumeLayout(false);
        pnlFiltro.PerformLayout();
        pnlDatos.ResumeLayout(false);
        pnlDatos.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
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
    private Label lblRNC;
    private TextBox txtRNC;
    private Label lblNombre;
    private TextBox txtNombre;
    private Label lblTelefono;
    private TextBox txtTelefono;
    private Label lblCorreo;
    private TextBox txtCorreo;
    private Label lblContacto;
    private TextBox txtContacto;
    private Label lblDireccion;
    private TextBox txtDireccion;
    private Button btnNuevo;
    private Button btnGuardar;
    private Button btnCancelar;
    private DataGridView dgvProveedores;
    private PictureBox pictureBox1;
}
