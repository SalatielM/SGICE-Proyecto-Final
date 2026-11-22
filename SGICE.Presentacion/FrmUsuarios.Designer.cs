namespace SGICE.Presentacion;

partial class FrmUsuarios
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
        lblNombreUsuario = new Label();
        txtNombreUsuario = new TextBox();
        lblClave = new Label();
        txtClave = new TextBox();
        lblNombre = new Label();
        txtNombre = new TextBox();
        lblApellido = new Label();
        txtApellido = new TextBox();
        lblCedula = new Label();
        txtCedula = new TextBox();
        lblTelefono = new Label();
        txtTelefono = new TextBox();
        lblCorreo = new Label();
        txtCorreo = new TextBox();
        lblRol = new Label();
        cmbRol = new ComboBox();
        btnNuevo = new Button();
        btnGuardar = new Button();
        btnCancelar = new Button();
        dgvUsuarios = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
        pnlTop.SuspendLayout();
        pnlFiltro.SuspendLayout();
        pnlDatos.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
        SuspendLayout();
        // 
        // errorProvider
        // 
        errorProvider.ContainerControl = this;
        // 
        // pnlTop
        // 
        pnlTop.BackColor = Color.FromArgb(30, 41, 59);
        pnlTop.Controls.Add(lblTitulo);
        pnlTop.Dock = DockStyle.Top;
        pnlTop.Location = new Point(0, 0);
        pnlTop.Name = "pnlTop";
        pnlTop.Size = new Size(1020, 50);
        pnlTop.TabIndex = 0;
        // 
        // lblTitulo
        // 
        lblTitulo.AutoSize = true;
        lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.White;
        lblTitulo.Location = new Point(16, 12);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(318, 25);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "Gestión de Usuarios y Seguridad";
        // 
        // pnlFiltro
        // 
        pnlFiltro.BackColor = Color.FromArgb(248, 250, 252);
        pnlFiltro.Controls.Add(lblBuscar);
        pnlFiltro.Controls.Add(txtBuscar);
        pnlFiltro.Controls.Add(btnBuscar);
        pnlFiltro.Dock = DockStyle.Top;
        pnlFiltro.Location = new Point(0, 50);
        pnlFiltro.Name = "pnlFiltro";
        pnlFiltro.Padding = new Padding(16, 10, 16, 10);
        pnlFiltro.Size = new Size(1020, 46);
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
        txtBuscar.PlaceholderText = "Usuario, nombre o cédula...";
        txtBuscar.Size = new Size(300, 24);
        txtBuscar.TabIndex = 1;
        txtBuscar.TextChanged += TxtBuscar_TextChanged;
        // 
        // btnBuscar
        // 
        btnBuscar.Location = new Point(375, 10);
        btnBuscar.Name = "btnBuscar";
        btnBuscar.Size = new Size(80, 26);
        btnBuscar.TabIndex = 2;
        btnBuscar.Text = "Refrescar";
        btnBuscar.UseVisualStyleBackColor = true;
        btnBuscar.Click += BtnBuscar_Click;
        // 
        // pnlDatos
        // 
        pnlDatos.BackColor = Color.White;
        pnlDatos.Controls.Add(lblNombreUsuario);
        pnlDatos.Controls.Add(txtNombreUsuario);
        pnlDatos.Controls.Add(lblClave);
        pnlDatos.Controls.Add(txtClave);
        pnlDatos.Controls.Add(lblNombre);
        pnlDatos.Controls.Add(txtNombre);
        pnlDatos.Controls.Add(lblApellido);
        pnlDatos.Controls.Add(txtApellido);
        pnlDatos.Controls.Add(lblCedula);
        pnlDatos.Controls.Add(txtCedula);
        pnlDatos.Controls.Add(lblTelefono);
        pnlDatos.Controls.Add(txtTelefono);
        pnlDatos.Controls.Add(lblCorreo);
        pnlDatos.Controls.Add(txtCorreo);
        pnlDatos.Controls.Add(lblRol);
        pnlDatos.Controls.Add(cmbRol);
        pnlDatos.Controls.Add(btnNuevo);
        pnlDatos.Controls.Add(btnGuardar);
        pnlDatos.Controls.Add(btnCancelar);
        pnlDatos.Dock = DockStyle.Right;
        pnlDatos.Location = new Point(660, 96);
        pnlDatos.Name = "pnlDatos";
        pnlDatos.Padding = new Padding(16);
        pnlDatos.Size = new Size(360, 545);
        pnlDatos.TabIndex = 2;
        // 
        // lblNombreUsuario
        // 
        lblNombreUsuario.AutoSize = true;
        lblNombreUsuario.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblNombreUsuario.ForeColor = Color.FromArgb(51, 65, 85);
        lblNombreUsuario.Location = new Point(16, 10);
        lblNombreUsuario.Name = "lblNombreUsuario";
        lblNombreUsuario.Size = new Size(51, 15);
        lblNombreUsuario.TabIndex = 0;
        lblNombreUsuario.Text = "Usuario:";
        // 
        // txtNombreUsuario
        // 
        txtNombreUsuario.Font = new Font("Segoe UI", 9.5F);
        txtNombreUsuario.Location = new Point(16, 28);
        txtNombreUsuario.Name = "txtNombreUsuario";
        txtNombreUsuario.PlaceholderText = "jlopez";
        txtNombreUsuario.Size = new Size(320, 24);
        txtNombreUsuario.TabIndex = 1;
        // 
        // lblClave
        // 
        lblClave.AutoSize = true;
        lblClave.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblClave.ForeColor = Color.FromArgb(51, 65, 85);
        lblClave.Location = new Point(16, 60);
        lblClave.Name = "lblClave";
        lblClave.Size = new Size(70, 15);
        lblClave.TabIndex = 2;
        lblClave.Text = "Contraseña:";
        // 
        // txtClave
        // 
        txtClave.Font = new Font("Segoe UI", 9.5F);
        txtClave.Location = new Point(16, 78);
        txtClave.Name = "txtClave";
        txtClave.PlaceholderText = "(Dejar vacío para no cambiar)";
        txtClave.Size = new Size(320, 24);
        txtClave.TabIndex = 3;
        txtClave.UseSystemPasswordChar = true;
        // 
        // lblNombre
        // 
        lblNombre.AutoSize = true;
        lblNombre.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblNombre.ForeColor = Color.FromArgb(51, 65, 85);
        lblNombre.Location = new Point(16, 110);
        lblNombre.Name = "lblNombre";
        lblNombre.Size = new Size(54, 15);
        lblNombre.TabIndex = 4;
        lblNombre.Text = "Nombre:";
        // 
        // txtNombre
        // 
        txtNombre.Font = new Font("Segoe UI", 9.5F);
        txtNombre.Location = new Point(16, 128);
        txtNombre.Name = "txtNombre";
        txtNombre.Size = new Size(320, 24);
        txtNombre.TabIndex = 5;
        // 
        // lblApellido
        // 
        lblApellido.AutoSize = true;
        lblApellido.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblApellido.ForeColor = Color.FromArgb(51, 65, 85);
        lblApellido.Location = new Point(16, 160);
        lblApellido.Name = "lblApellido";
        lblApellido.Size = new Size(54, 15);
        lblApellido.TabIndex = 6;
        lblApellido.Text = "Apellido:";
        // 
        // txtApellido
        // 
        txtApellido.Font = new Font("Segoe UI", 9.5F);
        txtApellido.Location = new Point(16, 178);
        txtApellido.Name = "txtApellido";
        txtApellido.Size = new Size(320, 24);
        txtApellido.TabIndex = 7;
        // 
        // lblCedula
        // 
        lblCedula.AutoSize = true;
        lblCedula.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblCedula.ForeColor = Color.FromArgb(51, 65, 85);
        lblCedula.Location = new Point(16, 210);
        lblCedula.Name = "lblCedula";
        lblCedula.Size = new Size(47, 15);
        lblCedula.TabIndex = 8;
        lblCedula.Text = "Cédula:";
        // 
        // txtCedula
        // 
        txtCedula.Font = new Font("Segoe UI", 9.5F);
        txtCedula.Location = new Point(16, 228);
        txtCedula.Name = "txtCedula";
        txtCedula.PlaceholderText = "001-0000000-0";
        txtCedula.Size = new Size(320, 24);
        txtCedula.TabIndex = 9;
        // 
        // lblTelefono
        // 
        lblTelefono.AutoSize = true;
        lblTelefono.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblTelefono.ForeColor = Color.FromArgb(51, 65, 85);
        lblTelefono.Location = new Point(16, 260);
        lblTelefono.Name = "lblTelefono";
        lblTelefono.Size = new Size(56, 15);
        lblTelefono.TabIndex = 10;
        lblTelefono.Text = "Teléfono:";
        // 
        // txtTelefono
        // 
        txtTelefono.Font = new Font("Segoe UI", 9.5F);
        txtTelefono.Location = new Point(16, 278);
        txtTelefono.Name = "txtTelefono";
        txtTelefono.PlaceholderText = "809-555-0100";
        txtTelefono.Size = new Size(320, 24);
        txtTelefono.TabIndex = 11;
        // 
        // lblCorreo
        // 
        lblCorreo.AutoSize = true;
        lblCorreo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblCorreo.ForeColor = Color.FromArgb(51, 65, 85);
        lblCorreo.Location = new Point(16, 310);
        lblCorreo.Name = "lblCorreo";
        lblCorreo.Size = new Size(46, 15);
        lblCorreo.TabIndex = 12;
        lblCorreo.Text = "Correo:";
        // 
        // txtCorreo
        // 
        txtCorreo.Font = new Font("Segoe UI", 9.5F);
        txtCorreo.Location = new Point(16, 328);
        txtCorreo.Name = "txtCorreo";
        txtCorreo.PlaceholderText = "usuario@escuela.edu.do";
        txtCorreo.Size = new Size(320, 24);
        txtCorreo.TabIndex = 13;
        // 
        // lblRol
        // 
        lblRol.AutoSize = true;
        lblRol.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblRol.ForeColor = Color.FromArgb(51, 65, 85);
        lblRol.Location = new Point(16, 360);
        lblRol.Name = "lblRol";
        lblRol.Size = new Size(89, 15);
        lblRol.TabIndex = 14;
        lblRol.Text = "Rol del Sistema:";
        // 
        // cmbRol
        // 
        cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbRol.Font = new Font("Segoe UI", 9.5F);
        cmbRol.FormattingEnabled = true;
        cmbRol.Location = new Point(16, 378);
        cmbRol.Name = "cmbRol";
        cmbRol.Size = new Size(320, 24);
        cmbRol.TabIndex = 15;
        // 
        // btnNuevo
        // 
        btnNuevo.Location = new Point(16, 420);
        btnNuevo.Name = "btnNuevo";
        btnNuevo.Size = new Size(95, 34);
        btnNuevo.TabIndex = 16;
        btnNuevo.Text = "Nuevo";
        btnNuevo.UseVisualStyleBackColor = true;
        btnNuevo.Click += BtnNuevo_Click;
        // 
        // btnGuardar
        // 
        btnGuardar.Location = new Point(122, 420);
        btnGuardar.Name = "btnGuardar";
        btnGuardar.Size = new Size(105, 34);
        btnGuardar.TabIndex = 17;
        btnGuardar.Text = "Guardar";
        btnGuardar.UseVisualStyleBackColor = true;
        btnGuardar.Click += BtnGuardar_Click;
        // 
        // btnCancelar
        // 
        btnCancelar.Location = new Point(238, 420);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new Size(98, 34);
        btnCancelar.TabIndex = 18;
        btnCancelar.Text = "Limpiar";
        btnCancelar.UseVisualStyleBackColor = true;
        btnCancelar.Click += BtnCancelar_Click;
        // 
        // dgvUsuarios
        // 
        dgvUsuarios.Dock = DockStyle.Fill;
        dgvUsuarios.Location = new Point(0, 96);
        dgvUsuarios.Name = "dgvUsuarios";
        dgvUsuarios.Size = new Size(660, 545);
        dgvUsuarios.TabIndex = 3;
        dgvUsuarios.SelectionChanged += DgvUsuarios_SelectionChanged;
        // 
        // FrmUsuarios
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1020, 641);
        Controls.Add(dgvUsuarios);
        Controls.Add(pnlDatos);
        Controls.Add(pnlFiltro);
        Controls.Add(pnlTop);
        Name = "FrmUsuarios";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Gestión de Usuarios del Sistema";
        Load += FrmUsuarios_Load;
        ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
        pnlTop.ResumeLayout(false);
        pnlTop.PerformLayout();
        pnlFiltro.ResumeLayout(false);
        pnlFiltro.PerformLayout();
        pnlDatos.ResumeLayout(false);
        pnlDatos.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
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
    private Label lblNombreUsuario;
    private TextBox txtNombreUsuario;
    private Label lblClave;
    private TextBox txtClave;
    private Label lblNombre;
    private TextBox txtNombre;
    private Label lblApellido;
    private TextBox txtApellido;
    private Label lblCedula;
    private TextBox txtCedula;
    private Label lblTelefono;
    private TextBox txtTelefono;
    private Label lblCorreo;
    private TextBox txtCorreo;
    private Label lblRol;
    private ComboBox cmbRol;
    private Button btnNuevo;
    private Button btnGuardar;
    private Button btnCancelar;
    private DataGridView dgvUsuarios;
}
