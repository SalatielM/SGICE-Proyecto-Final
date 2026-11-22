namespace SGICE.Presentacion;

partial class FrmCentrosEducativos
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
        pnlContenedor = new Panel();
        lblNombre = new Label();
        txtNombre = new TextBox();
        lblCodigo = new Label();
        txtCodigo = new TextBox();
        lblTelefono = new Label();
        txtTelefono = new TextBox();
        lblCorreo = new Label();
        txtCorreo = new TextBox();
        lblDireccion = new Label();
        txtDireccion = new TextBox();
        lblDistrito = new Label();
        txtDistrito = new TextBox();
        lblRegional = new Label();
        txtRegional = new TextBox();
        lblDirector = new Label();
        cmbDirector = new ComboBox();
        btnGuardar = new Button();
        btnRecargar = new Button();
        ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
        pnlTop.SuspendLayout();
        pnlContenedor.SuspendLayout();
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
        pnlTop.Size = new Size(720, 50);
        pnlTop.TabIndex = 0;
        // 
        // lblTitulo
        // 
        lblTitulo.AutoSize = true;
        lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.White;
        lblTitulo.Location = new Point(16, 12);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(322, 25);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "Información del Centro Educativo";
        // 
        // pnlContenedor
        // 
        pnlContenedor.BackColor = Color.White;
        pnlContenedor.Controls.Add(lblNombre);
        pnlContenedor.Controls.Add(txtNombre);
        pnlContenedor.Controls.Add(lblCodigo);
        pnlContenedor.Controls.Add(txtCodigo);
        pnlContenedor.Controls.Add(lblTelefono);
        pnlContenedor.Controls.Add(txtTelefono);
        pnlContenedor.Controls.Add(lblCorreo);
        pnlContenedor.Controls.Add(txtCorreo);
        pnlContenedor.Controls.Add(lblDireccion);
        pnlContenedor.Controls.Add(txtDireccion);
        pnlContenedor.Controls.Add(lblDistrito);
        pnlContenedor.Controls.Add(txtDistrito);
        pnlContenedor.Controls.Add(lblRegional);
        pnlContenedor.Controls.Add(txtRegional);
        pnlContenedor.Controls.Add(lblDirector);
        pnlContenedor.Controls.Add(cmbDirector);
        pnlContenedor.Controls.Add(btnGuardar);
        pnlContenedor.Controls.Add(btnRecargar);
        pnlContenedor.Dock = DockStyle.Fill;
        pnlContenedor.Location = new Point(0, 50);
        pnlContenedor.Name = "pnlContenedor";
        pnlContenedor.Padding = new Padding(30, 20, 30, 20);
        pnlContenedor.Size = new Size(720, 480);
        pnlContenedor.TabIndex = 1;
        // 
        // lblNombre
        // 
        lblNombre.AutoSize = true;
        lblNombre.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblNombre.ForeColor = Color.FromArgb(51, 65, 85);
        lblNombre.Location = new Point(30, 20);
        lblNombre.Name = "lblNombre";
        lblNombre.Size = new Size(116, 15);
        lblNombre.TabIndex = 0;
        lblNombre.Text = "Nombre del Centro:";
        // 
        // txtNombre
        // 
        txtNombre.Font = new Font("Segoe UI", 9.5F);
        txtNombre.Location = new Point(30, 38);
        txtNombre.Name = "txtNombre";
        txtNombre.Size = new Size(650, 24);
        txtNombre.TabIndex = 1;
        // 
        // lblCodigo
        // 
        lblCodigo.AutoSize = true;
        lblCodigo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblCodigo.ForeColor = Color.FromArgb(51, 65, 85);
        lblCodigo.Location = new Point(30, 75);
        lblCodigo.Name = "lblCodigo";
        lblCodigo.Size = new Size(86, 15);
        lblCodigo.TabIndex = 2;
        lblCodigo.Text = "Código Centro:";
        // 
        // txtCodigo
        // 
        txtCodigo.Font = new Font("Segoe UI", 9.5F);
        txtCodigo.Location = new Point(30, 93);
        txtCodigo.Name = "txtCodigo";
        txtCodigo.Size = new Size(310, 24);
        txtCodigo.TabIndex = 3;
        // 
        // lblTelefono
        // 
        lblTelefono.AutoSize = true;
        lblTelefono.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblTelefono.ForeColor = Color.FromArgb(51, 65, 85);
        lblTelefono.Location = new Point(370, 75);
        lblTelefono.Name = "lblTelefono";
        lblTelefono.Size = new Size(56, 15);
        lblTelefono.TabIndex = 4;
        lblTelefono.Text = "Teléfono:";
        // 
        // txtTelefono
        // 
        txtTelefono.Font = new Font("Segoe UI", 9.5F);
        txtTelefono.Location = new Point(370, 93);
        txtTelefono.Name = "txtTelefono";
        txtTelefono.Size = new Size(310, 24);
        txtTelefono.TabIndex = 5;
        // 
        // lblCorreo
        // 
        lblCorreo.AutoSize = true;
        lblCorreo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblCorreo.ForeColor = Color.FromArgb(51, 65, 85);
        lblCorreo.Location = new Point(30, 130);
        lblCorreo.Name = "lblCorreo";
        lblCorreo.Size = new Size(108, 15);
        lblCorreo.TabIndex = 6;
        lblCorreo.Text = "Correo Electrónico:";
        // 
        // txtCorreo
        // 
        txtCorreo.Font = new Font("Segoe UI", 9.5F);
        txtCorreo.Location = new Point(30, 148);
        txtCorreo.Name = "txtCorreo";
        txtCorreo.Size = new Size(310, 24);
        txtCorreo.TabIndex = 7;
        // 
        // lblDirector
        // 
        lblDirector.AutoSize = true;
        lblDirector.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblDirector.ForeColor = Color.FromArgb(51, 65, 85);
        lblDirector.Location = new Point(370, 130);
        lblDirector.Name = "lblDirector";
        lblDirector.Size = new Size(53, 15);
        lblDirector.TabIndex = 8;
        lblDirector.Text = "Director:";
        // 
        // cmbDirector
        // 
        cmbDirector.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbDirector.Font = new Font("Segoe UI", 9.5F);
        cmbDirector.FormattingEnabled = true;
        cmbDirector.Location = new Point(370, 148);
        cmbDirector.Name = "cmbDirector";
        cmbDirector.Size = new Size(310, 24);
        cmbDirector.TabIndex = 9;
        // 
        // lblDistrito
        // 
        lblDistrito.AutoSize = true;
        lblDistrito.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblDistrito.ForeColor = Color.FromArgb(51, 65, 85);
        lblDistrito.Location = new Point(30, 185);
        lblDistrito.Name = "lblDistrito";
        lblDistrito.Size = new Size(106, 15);
        lblDistrito.TabIndex = 10;
        lblDistrito.Text = "Distrito Educativo:";
        // 
        // txtDistrito
        // 
        txtDistrito.Font = new Font("Segoe UI", 9.5F);
        txtDistrito.Location = new Point(30, 203);
        txtDistrito.Name = "txtDistrito";
        txtDistrito.Size = new Size(310, 24);
        txtDistrito.TabIndex = 11;
        // 
        // lblRegional
        // 
        lblRegional.AutoSize = true;
        lblRegional.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblRegional.ForeColor = Color.FromArgb(51, 65, 85);
        lblRegional.Location = new Point(370, 185);
        lblRegional.Name = "lblRegional";
        lblRegional.Size = new Size(113, 15);
        lblRegional.TabIndex = 12;
        lblRegional.Text = "Regional Educativo:";
        // 
        // txtRegional
        // 
        txtRegional.Font = new Font("Segoe UI", 9.5F);
        txtRegional.Location = new Point(370, 203);
        txtRegional.Name = "txtRegional";
        txtRegional.Size = new Size(310, 24);
        txtRegional.TabIndex = 13;
        // 
        // lblDireccion
        // 
        lblDireccion.AutoSize = true;
        lblDireccion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblDireccion.ForeColor = Color.FromArgb(51, 65, 85);
        lblDireccion.Location = new Point(30, 240);
        lblDireccion.Name = "lblDireccion";
        lblDireccion.Size = new Size(60, 15);
        lblDireccion.TabIndex = 14;
        lblDireccion.Text = "Dirección:";
        // 
        // txtDireccion
        // 
        txtDireccion.Font = new Font("Segoe UI", 9.5F);
        txtDireccion.Location = new Point(30, 258);
        txtDireccion.Multiline = true;
        txtDireccion.Name = "txtDireccion";
        txtDireccion.Size = new Size(650, 60);
        txtDireccion.TabIndex = 15;
        // 
        // btnGuardar
        // 
        btnGuardar.Location = new Point(30, 340);
        btnGuardar.Name = "btnGuardar";
        btnGuardar.Size = new Size(150, 38);
        btnGuardar.TabIndex = 16;
        btnGuardar.Text = "Guardar Cambios";
        btnGuardar.UseVisualStyleBackColor = true;
        btnGuardar.Click += BtnGuardar_Click;
        // 
        // btnRecargar
        // 
        btnRecargar.Location = new Point(190, 340);
        btnRecargar.Name = "btnRecargar";
        btnRecargar.Size = new Size(120, 38);
        btnRecargar.TabIndex = 17;
        btnRecargar.Text = "Recargar";
        btnRecargar.UseVisualStyleBackColor = true;
        btnRecargar.Click += BtnRecargar_Click;
        // 
        // FrmCentrosEducativos
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(720, 530);
        Controls.Add(pnlContenedor);
        Controls.Add(pnlTop);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        Name = "FrmCentrosEducativos";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Datos del Centro Educativo";
        Load += FrmCentrosEducativos_Load;
        ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
        pnlTop.ResumeLayout(false);
        pnlTop.PerformLayout();
        pnlContenedor.ResumeLayout(false);
        pnlContenedor.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private ErrorProvider errorProvider;
    private Panel pnlTop;
    private Label lblTitulo;
    private Panel pnlContenedor;
    private Label lblNombre;
    private TextBox txtNombre;
    private Label lblCodigo;
    private TextBox txtCodigo;
    private Label lblTelefono;
    private TextBox txtTelefono;
    private Label lblCorreo;
    private TextBox txtCorreo;
    private Label lblDireccion;
    private TextBox txtDireccion;
    private Label lblDistrito;
    private TextBox txtDistrito;
    private Label lblRegional;
    private TextBox txtRegional;
    private Label lblDirector;
    private ComboBox cmbDirector;
    private Button btnGuardar;
    private Button btnRecargar;
}
