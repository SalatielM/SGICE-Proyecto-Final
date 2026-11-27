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
        pnlDatosContainer = new Panel();
        grpDatos = new GroupBox();
        lblNombre = new Label();
        txtNombre = new TextBox();
        lblCodigo = new Label();
        txtCodigo = new TextBox();
        lblTelefono = new Label();
        txtTelefono = new TextBox();
        lblCorreo = new Label();
        txtCorreo = new TextBox();
        lblDirector = new Label();
        cmbDirector = new ComboBox();
        lblDistrito = new Label();
        txtDistrito = new TextBox();
        lblRegional = new Label();
        txtRegional = new TextBox();
        lblDireccion = new Label();
        txtDireccion = new TextBox();
        pnlAcciones = new Panel();
        btnRecargar = new Button();
        btnGuardar = new Button();
        ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
        pnlTop.SuspendLayout();
        pnlDatosContainer.SuspendLayout();
        grpDatos.SuspendLayout();
        pnlAcciones.SuspendLayout();
        SuspendLayout();
        // 
        // errorProvider
        // 
        errorProvider.ContainerControl = this;
        // 
        // pnlTop
        // 
        pnlTop.BackColor = Color.FromArgb(142, 177, 209);
        pnlTop.Controls.Add(lblTitulo);
        pnlTop.Dock = DockStyle.Top;
        pnlTop.Location = new Point(0, 0);
        pnlTop.Name = "pnlTop";
        pnlTop.Size = new Size(840, 32);
        pnlTop.TabIndex = 0;
        // 
        // lblTitulo
        // 
        lblTitulo.Dock = DockStyle.Fill;
        lblTitulo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.Black;
        lblTitulo.Location = new Point(0, 0);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(840, 32);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "INFORMACIÓN DEL CENTRO EDUCATIVO";
        lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // pnlDatosContainer
        // 
        pnlDatosContainer.BackColor = SystemColors.Control;
        pnlDatosContainer.Controls.Add(grpDatos);
        pnlDatosContainer.Dock = DockStyle.Top;
        pnlDatosContainer.Location = new Point(0, 32);
        pnlDatosContainer.Name = "pnlDatosContainer";
        pnlDatosContainer.Padding = new Padding(8, 6, 8, 2);
        pnlDatosContainer.Size = new Size(840, 196);
        pnlDatosContainer.TabIndex = 1;
        // 
        // grpDatos
        // 
        grpDatos.BackColor = SystemColors.Control;
        grpDatos.Controls.Add(lblNombre);
        grpDatos.Controls.Add(txtNombre);
        grpDatos.Controls.Add(lblCodigo);
        grpDatos.Controls.Add(txtCodigo);
        grpDatos.Controls.Add(lblTelefono);
        grpDatos.Controls.Add(txtTelefono);
        grpDatos.Controls.Add(lblCorreo);
        grpDatos.Controls.Add(txtCorreo);
        grpDatos.Controls.Add(lblDirector);
        grpDatos.Controls.Add(cmbDirector);
        grpDatos.Controls.Add(lblDistrito);
        grpDatos.Controls.Add(txtDistrito);
        grpDatos.Controls.Add(lblRegional);
        grpDatos.Controls.Add(txtRegional);
        grpDatos.Controls.Add(lblDireccion);
        grpDatos.Controls.Add(txtDireccion);
        grpDatos.Dock = DockStyle.Fill;
        grpDatos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        grpDatos.ForeColor = Color.Black;
        grpDatos.Location = new Point(8, 6);
        grpDatos.Name = "grpDatos";
        grpDatos.Size = new Size(824, 188);
        grpDatos.TabIndex = 0;
        grpDatos.TabStop = false;
        grpDatos.Text = "Datos del Centro Educativo";
        // 
        // lblNombre
        // 
        lblNombre.AutoSize = true;
        lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblNombre.ForeColor = Color.Black;
        lblNombre.Location = new Point(12, 26);
        lblNombre.Name = "lblNombre";
        lblNombre.Size = new Size(57, 15);
        lblNombre.TabIndex = 0;
        lblNombre.Text = "Nombre:";
        // 
        // txtNombre
        // 
        txtNombre.BackColor = SystemColors.Window;
        txtNombre.BorderStyle = BorderStyle.FixedSingle;
        txtNombre.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        txtNombre.Location = new Point(98, 23);
        txtNombre.Name = "txtNombre";
        txtNombre.Size = new Size(340, 23);
        txtNombre.TabIndex = 1;
        // 
        // lblCodigo
        // 
        lblCodigo.AutoSize = true;
        lblCodigo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblCodigo.ForeColor = Color.Black;
        lblCodigo.Location = new Point(454, 26);
        lblCodigo.Name = "lblCodigo";
        lblCodigo.Size = new Size(51, 15);
        lblCodigo.TabIndex = 2;
        lblCodigo.Text = "Código:";
        // 
        // txtCodigo
        // 
        txtCodigo.BackColor = SystemColors.Window;
        txtCodigo.BorderStyle = BorderStyle.FixedSingle;
        txtCodigo.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        txtCodigo.Location = new Point(511, 23);
        txtCodigo.Name = "txtCodigo";
        txtCodigo.Size = new Size(120, 23);
        txtCodigo.TabIndex = 3;
        // 
        // lblTelefono
        // 
        lblTelefono.AutoSize = true;
        lblTelefono.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblTelefono.ForeColor = Color.Black;
        lblTelefono.Location = new Point(646, 26);
        lblTelefono.Name = "lblTelefono";
        lblTelefono.Size = new Size(60, 15);
        lblTelefono.TabIndex = 4;
        lblTelefono.Text = "Teléfono:";
        // 
        // txtTelefono
        // 
        txtTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtTelefono.BackColor = SystemColors.Window;
        txtTelefono.BorderStyle = BorderStyle.FixedSingle;
        txtTelefono.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        txtTelefono.Location = new Point(712, 23);
        txtTelefono.Name = "txtTelefono";
        txtTelefono.Size = new Size(98, 23);
        txtTelefono.TabIndex = 5;
        // 
        // lblCorreo
        // 
        lblCorreo.AutoSize = true;
        lblCorreo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblCorreo.ForeColor = Color.Black;
        lblCorreo.Location = new Point(12, 58);
        lblCorreo.Name = "lblCorreo";
        lblCorreo.Size = new Size(49, 15);
        lblCorreo.TabIndex = 6;
        lblCorreo.Text = "Correo:";
        // 
        // txtCorreo
        // 
        txtCorreo.BackColor = SystemColors.Window;
        txtCorreo.BorderStyle = BorderStyle.FixedSingle;
        txtCorreo.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        txtCorreo.Location = new Point(98, 55);
        txtCorreo.Name = "txtCorreo";
        txtCorreo.Size = new Size(340, 23);
        txtCorreo.TabIndex = 7;
        // 
        // lblDirector
        // 
        lblDirector.AutoSize = true;
        lblDirector.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblDirector.ForeColor = Color.Black;
        lblDirector.Location = new Point(454, 58);
        lblDirector.Name = "lblDirector";
        lblDirector.Size = new Size(55, 15);
        lblDirector.TabIndex = 8;
        lblDirector.Text = "Director:";
        // 
        // cmbDirector
        // 
        cmbDirector.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        cmbDirector.BackColor = SystemColors.Window;
        cmbDirector.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbDirector.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        cmbDirector.FormattingEnabled = true;
        cmbDirector.Location = new Point(515, 55);
        cmbDirector.Name = "cmbDirector";
        cmbDirector.Size = new Size(295, 23);
        cmbDirector.TabIndex = 9;
        // 
        // lblDistrito
        // 
        lblDistrito.AutoSize = true;
        lblDistrito.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblDistrito.ForeColor = Color.Black;
        lblDistrito.Location = new Point(12, 90);
        lblDistrito.Name = "lblDistrito";
        lblDistrito.Size = new Size(51, 15);
        lblDistrito.TabIndex = 10;
        lblDistrito.Text = "Distrito:";
        // 
        // txtDistrito
        // 
        txtDistrito.BackColor = SystemColors.Window;
        txtDistrito.BorderStyle = BorderStyle.FixedSingle;
        txtDistrito.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        txtDistrito.Location = new Point(98, 87);
        txtDistrito.Name = "txtDistrito";
        txtDistrito.Size = new Size(340, 23);
        txtDistrito.TabIndex = 11;
        // 
        // lblRegional
        // 
        lblRegional.AutoSize = true;
        lblRegional.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblRegional.ForeColor = Color.Black;
        lblRegional.Location = new Point(454, 90);
        lblRegional.Name = "lblRegional";
        lblRegional.Size = new Size(60, 15);
        lblRegional.TabIndex = 12;
        lblRegional.Text = "Regional:";
        // 
        // txtRegional
        // 
        txtRegional.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtRegional.BackColor = SystemColors.Window;
        txtRegional.BorderStyle = BorderStyle.FixedSingle;
        txtRegional.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        txtRegional.Location = new Point(520, 87);
        txtRegional.Name = "txtRegional";
        txtRegional.Size = new Size(290, 23);
        txtRegional.TabIndex = 13;
        // 
        // lblDireccion
        // 
        lblDireccion.AutoSize = true;
        lblDireccion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblDireccion.ForeColor = Color.Black;
        lblDireccion.Location = new Point(12, 126);
        lblDireccion.Name = "lblDireccion";
        lblDireccion.Size = new Size(64, 15);
        lblDireccion.TabIndex = 14;
        lblDireccion.Text = "Dirección:";
        // 
        // txtDireccion
        // 
        txtDireccion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtDireccion.BackColor = SystemColors.Window;
        txtDireccion.BorderStyle = BorderStyle.FixedSingle;
        txtDireccion.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        txtDireccion.Location = new Point(98, 124);
        txtDireccion.Multiline = true;
        txtDireccion.Name = "txtDireccion";
        txtDireccion.Size = new Size(712, 45);
        txtDireccion.TabIndex = 15;
        // 
        // pnlAcciones
        // 
        pnlAcciones.BackColor = SystemColors.Control;
        pnlAcciones.Controls.Add(btnRecargar);
        pnlAcciones.Controls.Add(btnGuardar);
        pnlAcciones.Dock = DockStyle.Top;
        pnlAcciones.Location = new Point(0, 228);
        pnlAcciones.Name = "pnlAcciones";
        pnlAcciones.Size = new Size(840, 40);
        pnlAcciones.TabIndex = 2;
        // 
        // btnRecargar
        // 
        btnRecargar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnRecargar.BackColor = Color.FromArgb(224, 247, 250);
        btnRecargar.FlatStyle = FlatStyle.Standard;
        btnRecargar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnRecargar.ForeColor = Color.Black;
        btnRecargar.Location = new Point(616, 6);
        btnRecargar.Name = "btnRecargar";
        btnRecargar.Size = new Size(105, 28);
        btnRecargar.TabIndex = 0;
        btnRecargar.Text = "Recargar";
        btnRecargar.UseVisualStyleBackColor = false;
        btnRecargar.Click += BtnRecargar_Click;
        // 
        // btnGuardar
        // 
        btnGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnGuardar.BackColor = Color.FromArgb(232, 245, 233);
        btnGuardar.FlatStyle = FlatStyle.Standard;
        btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnGuardar.ForeColor = Color.Black;
        btnGuardar.Location = new Point(727, 6);
        btnGuardar.Name = "btnGuardar";
        btnGuardar.Size = new Size(105, 28);
        btnGuardar.TabIndex = 1;
        btnGuardar.Text = "Guardar";
        btnGuardar.UseVisualStyleBackColor = false;
        btnGuardar.Click += BtnGuardar_Click;
        // 
        // FrmCentrosEducativos
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        ClientSize = new Size(840, 480);
        Controls.Add(pnlAcciones);
        Controls.Add(pnlDatosContainer);
        Controls.Add(pnlTop);
        Name = "FrmCentrosEducativos";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Datos del Centro Educativo";
        Load += FrmCentrosEducativos_Load;
        ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
        pnlTop.ResumeLayout(false);
        pnlDatosContainer.ResumeLayout(false);
        grpDatos.ResumeLayout(false);
        grpDatos.PerformLayout();
        pnlAcciones.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private ErrorProvider errorProvider;
    private Panel pnlTop;
    private Label lblTitulo;
    private Panel pnlDatosContainer;
    private GroupBox grpDatos;
    private Label lblNombre;
    private TextBox txtNombre;
    private Label lblCodigo;
    private TextBox txtCodigo;
    private Label lblTelefono;
    private TextBox txtTelefono;
    private Label lblCorreo;
    private TextBox txtCorreo;
    private Label lblDirector;
    private ComboBox cmbDirector;
    private Label lblDistrito;
    private TextBox txtDistrito;
    private Label lblRegional;
    private TextBox txtRegional;
    private Label lblDireccion;
    private TextBox txtDireccion;
    private Panel pnlAcciones;
    private Button btnGuardar;
    private Button btnRecargar;
}
