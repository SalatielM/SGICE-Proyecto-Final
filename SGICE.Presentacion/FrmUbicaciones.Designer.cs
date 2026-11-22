namespace SGICE.Presentacion;

partial class FrmUbicaciones
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
        lblEdificio = new Label();
        cmbEdificio = new ComboBox();
        lblNombre = new Label();
        txtNombre = new TextBox();
        lblPiso = new Label();
        txtPiso = new TextBox();
        lblDimension = new Label();
        txtDimension = new TextBox();
        lblDescripcion = new Label();
        txtDescripcion = new TextBox();
        btnNuevo = new Button();
        btnGuardar = new Button();
        btnCancelar = new Button();
        dgvUbicaciones = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
        pnlTop.SuspendLayout();
        pnlFiltro.SuspendLayout();
        pnlDatos.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvUbicaciones).BeginInit();
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
        pnlTop.Size = new Size(940, 50);
        pnlTop.TabIndex = 0;
        // 
        // lblTitulo
        // 
        lblTitulo.AutoSize = true;
        lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.White;
        lblTitulo.Location = new Point(16, 12);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(331, 25);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "Catálogo de Ubicaciones y Espacios";
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
        pnlFiltro.Size = new Size(940, 46);
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
        txtBuscar.PlaceholderText = "Nombre o edificio...";
        txtBuscar.Size = new Size(280, 24);
        txtBuscar.TabIndex = 1;
        txtBuscar.TextChanged += TxtBuscar_TextChanged;
        // 
        // btnBuscar
        // 
        btnBuscar.Location = new Point(353, 10);
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
        pnlDatos.Controls.Add(lblEdificio);
        pnlDatos.Controls.Add(cmbEdificio);
        pnlDatos.Controls.Add(lblNombre);
        pnlDatos.Controls.Add(txtNombre);
        pnlDatos.Controls.Add(lblPiso);
        pnlDatos.Controls.Add(txtPiso);
        pnlDatos.Controls.Add(lblDimension);
        pnlDatos.Controls.Add(txtDimension);
        pnlDatos.Controls.Add(lblDescripcion);
        pnlDatos.Controls.Add(txtDescripcion);
        pnlDatos.Controls.Add(btnNuevo);
        pnlDatos.Controls.Add(btnGuardar);
        pnlDatos.Controls.Add(btnCancelar);
        pnlDatos.Dock = DockStyle.Right;
        pnlDatos.Location = new Point(600, 96);
        pnlDatos.Name = "pnlDatos";
        pnlDatos.Padding = new Padding(16);
        pnlDatos.Size = new Size(340, 485);
        pnlDatos.TabIndex = 2;
        // 
        // lblEdificio
        // 
        lblEdificio.AutoSize = true;
        lblEdificio.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblEdificio.ForeColor = Color.FromArgb(51, 65, 85);
        lblEdificio.Location = new Point(16, 15);
        lblEdificio.Name = "lblEdificio";
        lblEdificio.Size = new Size(49, 15);
        lblEdificio.TabIndex = 0;
        lblEdificio.Text = "Edificio:";
        // 
        // cmbEdificio
        // 
        cmbEdificio.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbEdificio.Font = new Font("Segoe UI", 9.5F);
        cmbEdificio.FormattingEnabled = true;
        cmbEdificio.Location = new Point(16, 35);
        cmbEdificio.Name = "cmbEdificio";
        cmbEdificio.Size = new Size(300, 24);
        cmbEdificio.TabIndex = 1;
        // 
        // lblNombre
        // 
        lblNombre.AutoSize = true;
        lblNombre.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblNombre.ForeColor = Color.FromArgb(51, 65, 85);
        lblNombre.Location = new Point(16, 75);
        lblNombre.Name = "lblNombre";
        lblNombre.Size = new Size(130, 15);
        lblNombre.TabIndex = 2;
        lblNombre.Text = "Nombre de Ubicación:";
        // 
        // txtNombre
        // 
        txtNombre.Font = new Font("Segoe UI", 9.5F);
        txtNombre.Location = new Point(16, 95);
        txtNombre.Name = "txtNombre";
        txtNombre.PlaceholderText = "Aula 101, Laboratorio 2...";
        txtNombre.Size = new Size(300, 24);
        txtNombre.TabIndex = 3;
        // 
        // lblPiso
        // 
        lblPiso.AutoSize = true;
        lblPiso.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblPiso.ForeColor = Color.FromArgb(51, 65, 85);
        lblPiso.Location = new Point(16, 135);
        lblPiso.Name = "lblPiso";
        lblPiso.Size = new Size(32, 15);
        lblPiso.TabIndex = 4;
        lblPiso.Text = "Piso:";
        // 
        // txtPiso
        // 
        txtPiso.Font = new Font("Segoe UI", 9.5F);
        txtPiso.Location = new Point(16, 155);
        txtPiso.Name = "txtPiso";
        txtPiso.Size = new Size(135, 24);
        txtPiso.TabIndex = 5;
        // 
        // lblDimension
        // 
        lblDimension.AutoSize = true;
        lblDimension.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblDimension.ForeColor = Color.FromArgb(51, 65, 85);
        lblDimension.Location = new Point(165, 135);
        lblDimension.Name = "lblDimension";
        lblDimension.Size = new Size(67, 15);
        lblDimension.TabIndex = 6;
        lblDimension.Text = "Dimensión:";
        // 
        // txtDimension
        // 
        txtDimension.Font = new Font("Segoe UI", 9.5F);
        txtDimension.Location = new Point(165, 155);
        txtDimension.Name = "txtDimension";
        txtDimension.PlaceholderText = "6x8 m";
        txtDimension.Size = new Size(151, 24);
        txtDimension.TabIndex = 7;
        // 
        // lblDescripcion
        // 
        lblDescripcion.AutoSize = true;
        lblDescripcion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblDescripcion.ForeColor = Color.FromArgb(51, 65, 85);
        lblDescripcion.Location = new Point(16, 195);
        lblDescripcion.Name = "lblDescripcion";
        lblDescripcion.Size = new Size(73, 15);
        lblDescripcion.TabIndex = 8;
        lblDescripcion.Text = "Descripción:";
        // 
        // txtDescripcion
        // 
        txtDescripcion.Font = new Font("Segoe UI", 9.5F);
        txtDescripcion.Location = new Point(16, 215);
        txtDescripcion.Multiline = true;
        txtDescripcion.Name = "txtDescripcion";
        txtDescripcion.Size = new Size(300, 60);
        txtDescripcion.TabIndex = 9;
        // 
        // btnNuevo
        // 
        btnNuevo.Location = new Point(16, 290);
        btnNuevo.Name = "btnNuevo";
        btnNuevo.Size = new Size(90, 34);
        btnNuevo.TabIndex = 10;
        btnNuevo.Text = "Nuevo";
        btnNuevo.UseVisualStyleBackColor = true;
        btnNuevo.Click += BtnNuevo_Click;
        // 
        // btnGuardar
        // 
        btnGuardar.Location = new Point(112, 290);
        btnGuardar.Name = "btnGuardar";
        btnGuardar.Size = new Size(100, 34);
        btnGuardar.TabIndex = 11;
        btnGuardar.Text = "Guardar";
        btnGuardar.UseVisualStyleBackColor = true;
        btnGuardar.Click += BtnGuardar_Click;
        // 
        // btnCancelar
        // 
        btnCancelar.Location = new Point(218, 290);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new Size(98, 34);
        btnCancelar.TabIndex = 12;
        btnCancelar.Text = "Limpiar";
        btnCancelar.UseVisualStyleBackColor = true;
        btnCancelar.Click += BtnCancelar_Click;
        // 
        // dgvUbicaciones
        // 
        dgvUbicaciones.Dock = DockStyle.Fill;
        dgvUbicaciones.Location = new Point(0, 96);
        dgvUbicaciones.Name = "dgvUbicaciones";
        dgvUbicaciones.Size = new Size(600, 485);
        dgvUbicaciones.TabIndex = 3;
        dgvUbicaciones.SelectionChanged += DgvUbicaciones_SelectionChanged;
        // 
        // FrmUbicaciones
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(940, 581);
        Controls.Add(dgvUbicaciones);
        Controls.Add(pnlDatos);
        Controls.Add(pnlFiltro);
        Controls.Add(pnlTop);
        Name = "FrmUbicaciones";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Gestión de Ubicaciones";
        Load += FrmUbicaciones_Load;
        ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
        pnlTop.ResumeLayout(false);
        pnlTop.PerformLayout();
        pnlFiltro.ResumeLayout(false);
        pnlFiltro.PerformLayout();
        pnlDatos.ResumeLayout(false);
        pnlDatos.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvUbicaciones).EndInit();
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
    private Label lblEdificio;
    private ComboBox cmbEdificio;
    private Label lblNombre;
    private TextBox txtNombre;
    private Label lblPiso;
    private TextBox txtPiso;
    private Label lblDimension;
    private TextBox txtDimension;
    private Label lblDescripcion;
    private TextBox txtDescripcion;
    private Button btnNuevo;
    private Button btnGuardar;
    private Button btnCancelar;
    private DataGridView dgvUbicaciones;
}
