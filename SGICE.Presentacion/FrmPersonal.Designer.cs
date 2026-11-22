namespace SGICE.Presentacion;

partial class FrmPersonal
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
        lblApellido = new Label();
        txtApellido = new TextBox();
        lblCedula = new Label();
        txtCedula = new TextBox();
        lblTelefono = new Label();
        txtTelefono = new TextBox();
        lblCorreo = new Label();
        txtCorreo = new TextBox();
        lblPuesto = new Label();
        cmbPuesto = new ComboBox();
        btnNuevo = new Button();
        btnGuardar = new Button();
        btnCancelar = new Button();
        dgvPersonal = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
        pnlTop.SuspendLayout();
        pnlFiltro.SuspendLayout();
        pnlDatos.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvPersonal).BeginInit();
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
        pnlTop.Size = new Size(1000, 50);
        pnlTop.TabIndex = 0;
        // 
        // lblTitulo
        // 
        lblTitulo.AutoSize = true;
        lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.White;
        lblTitulo.Location = new Point(16, 12);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(244, 25);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "Gestión de Personal Escolar";
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
        pnlFiltro.Size = new Size(1000, 46);
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
        txtBuscar.PlaceholderText = "Nombre, apellido o cédula...";
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
        pnlDatos.Controls.Add(lblCodigo);
        pnlDatos.Controls.Add(txtCodigo);
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
        pnlDatos.Controls.Add(lblPuesto);
        pnlDatos.Controls.Add(cmbPuesto);
        pnlDatos.Controls.Add(btnNuevo);
        pnlDatos.Controls.Add(btnGuardar);
        pnlDatos.Controls.Add(btnCancelar);
        pnlDatos.Dock = DockStyle.Right;
        pnlDatos.Location = new Point(650, 96);
        pnlDatos.Name = "pnlDatos";
        pnlDatos.Padding = new Padding(16);
        pnlDatos.Size = new Size(350, 525);
        pnlDatos.TabIndex = 2;
        // 
        // lblCodigo
        // 
        lblCodigo.AutoSize = true;
        lblCodigo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblCodigo.ForeColor = Color.FromArgb(51, 65, 85);
        lblCodigo.Location = new Point(16, 10);
        lblCodigo.Name = "lblCodigo";
        lblCodigo.Size = new Size(92, 15);
        lblCodigo.TabIndex = 0;
        lblCodigo.Text = "Código Personal:";
        // 
        // txtCodigo
        // 
        txtCodigo.Font = new Font("Segoe UI", 9.5F);
        txtCodigo.Location = new Point(16, 28);
        txtCodigo.Name = "txtCodigo";
        txtCodigo.PlaceholderText = "EMP-001";
        txtCodigo.Size = new Size(310, 24);
        txtCodigo.TabIndex = 1;
        // 
        // lblNombre
        // 
        lblNombre.AutoSize = true;
        lblNombre.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblNombre.ForeColor = Color.FromArgb(51, 65, 85);
        lblNombre.Location = new Point(16, 60);
        lblNombre.Name = "lblNombre";
        lblNombre.Size = new Size(54, 15);
        lblNombre.TabIndex = 2;
        lblNombre.Text = "Nombre:";
        // 
        // txtNombre
        // 
        txtNombre.Font = new Font("Segoe UI", 9.5F);
        txtNombre.Location = new Point(16, 78);
        txtNombre.Name = "txtNombre";
        txtNombre.Size = new Size(310, 24);
        txtNombre.TabIndex = 3;
        // 
        // lblApellido
        // 
        lblApellido.AutoSize = true;
        lblApellido.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblApellido.ForeColor = Color.FromArgb(51, 65, 85);
        lblApellido.Location = new Point(16, 110);
        lblApellido.Name = "lblApellido";
        lblApellido.Size = new Size(54, 15);
        lblApellido.TabIndex = 4;
        lblApellido.Text = "Apellido:";
        // 
        // txtApellido
        // 
        txtApellido.Font = new Font("Segoe UI", 9.5F);
        txtApellido.Location = new Point(16, 128);
        txtApellido.Name = "txtApellido";
        txtApellido.Size = new Size(310, 24);
        txtApellido.TabIndex = 5;
        // 
        // lblCedula
        // 
        lblCedula.AutoSize = true;
        lblCedula.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblCedula.ForeColor = Color.FromArgb(51, 65, 85);
        lblCedula.Location = new Point(16, 160);
        lblCedula.Name = "lblCedula";
        lblCedula.Size = new Size(47, 15);
        lblCedula.TabIndex = 6;
        lblCedula.Text = "Cédula:";
        // 
        // txtCedula
        // 
        txtCedula.Font = new Font("Segoe UI", 9.5F);
        txtCedula.Location = new Point(16, 178);
        txtCedula.Name = "txtCedula";
        txtCedula.PlaceholderText = "001-0000000-0";
        txtCedula.Size = new Size(310, 24);
        txtCedula.TabIndex = 7;
        // 
        // lblTelefono
        // 
        lblTelefono.AutoSize = true;
        lblTelefono.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblTelefono.ForeColor = Color.FromArgb(51, 65, 85);
        lblTelefono.Location = new Point(16, 210);
        lblTelefono.Name = "lblTelefono";
        lblTelefono.Size = new Size(56, 15);
        lblTelefono.TabIndex = 8;
        lblTelefono.Text = "Teléfono:";
        // 
        // txtTelefono
        // 
        txtTelefono.Font = new Font("Segoe UI", 9.5F);
        txtTelefono.Location = new Point(16, 228);
        txtTelefono.Name = "txtTelefono";
        txtTelefono.PlaceholderText = "809-555-0100";
        txtTelefono.Size = new Size(310, 24);
        txtTelefono.TabIndex = 9;
        // 
        // lblCorreo
        // 
        lblCorreo.AutoSize = true;
        lblCorreo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblCorreo.ForeColor = Color.FromArgb(51, 65, 85);
        lblCorreo.Location = new Point(16, 260);
        lblCorreo.Name = "lblCorreo";
        lblCorreo.Size = new Size(46, 15);
        lblCorreo.TabIndex = 10;
        lblCorreo.Text = "Correo:";
        // 
        // txtCorreo
        // 
        txtCorreo.Font = new Font("Segoe UI", 9.5F);
        txtCorreo.Location = new Point(16, 278);
        txtCorreo.Name = "txtCorreo";
        txtCorreo.PlaceholderText = "docente@escuela.edu.do";
        txtCorreo.Size = new Size(310, 24);
        txtCorreo.TabIndex = 11;
        // 
        // lblPuesto
        // 
        lblPuesto.AutoSize = true;
        lblPuesto.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblPuesto.ForeColor = Color.FromArgb(51, 65, 85);
        lblPuesto.Location = new Point(16, 310);
        lblPuesto.Name = "lblPuesto";
        lblPuesto.Size = new Size(46, 15);
        lblPuesto.TabIndex = 12;
        lblPuesto.Text = "Puesto:";
        // 
        // cmbPuesto
        // 
        cmbPuesto.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbPuesto.Font = new Font("Segoe UI", 9.5F);
        cmbPuesto.FormattingEnabled = true;
        cmbPuesto.Location = new Point(16, 328);
        cmbPuesto.Name = "cmbPuesto";
        cmbPuesto.Size = new Size(310, 24);
        cmbPuesto.TabIndex = 13;
        // 
        // btnNuevo
        // 
        btnNuevo.Location = new Point(16, 370);
        btnNuevo.Name = "btnNuevo";
        btnNuevo.Size = new Size(90, 34);
        btnNuevo.TabIndex = 14;
        btnNuevo.Text = "Nuevo";
        btnNuevo.UseVisualStyleBackColor = true;
        btnNuevo.Click += BtnNuevo_Click;
        // 
        // btnGuardar
        // 
        btnGuardar.Location = new Point(115, 370);
        btnGuardar.Name = "btnGuardar";
        btnGuardar.Size = new Size(100, 34);
        btnGuardar.TabIndex = 15;
        btnGuardar.Text = "Guardar";
        btnGuardar.UseVisualStyleBackColor = true;
        btnGuardar.Click += BtnGuardar_Click;
        // 
        // btnCancelar
        // 
        btnCancelar.Location = new Point(226, 370);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new Size(100, 34);
        btnCancelar.TabIndex = 16;
        btnCancelar.Text = "Limpiar";
        btnCancelar.UseVisualStyleBackColor = true;
        btnCancelar.Click += BtnCancelar_Click;
        // 
        // dgvPersonal
        // 
        dgvPersonal.Dock = DockStyle.Fill;
        dgvPersonal.Location = new Point(0, 96);
        dgvPersonal.Name = "dgvPersonal";
        dgvPersonal.Size = new Size(650, 525);
        dgvPersonal.TabIndex = 3;
        dgvPersonal.SelectionChanged += DgvPersonal_SelectionChanged;
        // 
        // FrmPersonal
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1000, 621);
        Controls.Add(dgvPersonal);
        Controls.Add(pnlDatos);
        Controls.Add(pnlFiltro);
        Controls.Add(pnlTop);
        Name = "FrmPersonal";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Gestión de Personal Escolar";
        Load += FrmPersonal_Load;
        ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
        pnlTop.ResumeLayout(false);
        pnlTop.PerformLayout();
        pnlFiltro.ResumeLayout(false);
        pnlFiltro.PerformLayout();
        pnlDatos.ResumeLayout(false);
        pnlDatos.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvPersonal).EndInit();
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
    private Label lblApellido;
    private TextBox txtApellido;
    private Label lblCedula;
    private TextBox txtCedula;
    private Label lblTelefono;
    private TextBox txtTelefono;
    private Label lblCorreo;
    private TextBox txtCorreo;
    private Label lblPuesto;
    private ComboBox cmbPuesto;
    private Button btnNuevo;
    private Button btnGuardar;
    private Button btnCancelar;
    private DataGridView dgvPersonal;
}
