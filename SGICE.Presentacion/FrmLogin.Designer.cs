namespace SGICE.Presentacion;

partial class FrmLogin
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
        pnlHeader = new Panel();
        lblSubtitulo = new Label();
        lblTitulo = new Label();
        pnlContenedor = new Panel();
        lblMensaje = new Label();
        btnCancelar = new Button();
        btnIngresar = new Button();
        txtClave = new TextBox();
        lblClave = new Label();
        txtUsuario = new TextBox();
        lblUsuario = new Label();
        pictureBox1 = new PictureBox();
        pnlHeader.SuspendLayout();
        pnlContenedor.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = Color.FromArgb(30, 41, 59);
        pnlHeader.Controls.Add(lblSubtitulo);
        pnlHeader.Controls.Add(lblTitulo);
        pnlHeader.Dock = DockStyle.Top;
        pnlHeader.Location = new Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Size = new Size(678, 85);
        pnlHeader.TabIndex = 0;
        // 
        // lblSubtitulo
        // 
        lblSubtitulo.AutoSize = true;
        lblSubtitulo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblSubtitulo.ForeColor = Color.FromArgb(148, 163, 184);
        lblSubtitulo.Location = new Point(24, 50);
        lblSubtitulo.Name = "lblSubtitulo";
        lblSubtitulo.Size = new Size(351, 15);
        lblSubtitulo.TabIndex = 1;
        lblSubtitulo.Text = "Sistema de Gestión de Activos Inmuebles para centros educativos";
        // 
        // lblTitulo
        // 
        lblTitulo.AutoSize = true;
        lblTitulo.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblTitulo.ForeColor = Color.White;
        lblTitulo.Location = new Point(20, 12);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(98, 31);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "SGICE";
        // 
        // pnlContenedor
        // 
        pnlContenedor.BackColor = Color.FromArgb(248, 250, 252);
        pnlContenedor.Controls.Add(pictureBox1);
        pnlContenedor.Controls.Add(lblMensaje);
        pnlContenedor.Controls.Add(btnCancelar);
        pnlContenedor.Controls.Add(btnIngresar);
        pnlContenedor.Controls.Add(txtClave);
        pnlContenedor.Controls.Add(lblClave);
        pnlContenedor.Controls.Add(txtUsuario);
        pnlContenedor.Controls.Add(lblUsuario);
        pnlContenedor.Dock = DockStyle.Fill;
        pnlContenedor.Location = new Point(0, 85);
        pnlContenedor.Name = "pnlContenedor";
        pnlContenedor.Padding = new Padding(28, 20, 28, 20);
        pnlContenedor.Size = new Size(678, 376);
        pnlContenedor.TabIndex = 1;
        pnlContenedor.Paint += pnlContenedor_Paint;
        // 
        // lblMensaje
        // 
        lblMensaje.AutoSize = true;
        lblMensaje.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblMensaje.ForeColor = Color.FromArgb(220, 38, 38);
        lblMensaje.Location = new Point(28, 153);
        lblMensaje.Name = "lblMensaje";
        lblMensaje.Size = new Size(0, 13);
        lblMensaje.TabIndex = 6;
        lblMensaje.Visible = false;
        // 
        // btnCancelar
        // 
        btnCancelar.BackColor = Color.FromArgb(226, 232, 240);
        btnCancelar.Cursor = Cursors.Hand;
        btnCancelar.FlatAppearance.BorderSize = 0;
        btnCancelar.FlatStyle = FlatStyle.Flat;
        btnCancelar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnCancelar.ForeColor = Color.FromArgb(51, 65, 85);
        btnCancelar.Location = new Point(437, 203);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new Size(115, 36);
        btnCancelar.TabIndex = 5;
        btnCancelar.Text = "Cancelar";
        btnCancelar.UseVisualStyleBackColor = false;
        btnCancelar.Click += BtnCancelar_Click;
        // 
        // btnIngresar
        // 
        btnIngresar.BackColor = Color.FromArgb(37, 99, 235);
        btnIngresar.Cursor = Cursors.Hand;
        btnIngresar.FlatAppearance.BorderSize = 0;
        btnIngresar.FlatStyle = FlatStyle.Flat;
        btnIngresar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnIngresar.ForeColor = Color.White;
        btnIngresar.Location = new Point(437, 157);
        btnIngresar.Name = "btnIngresar";
        btnIngresar.Size = new Size(115, 40);
        btnIngresar.TabIndex = 4;
        btnIngresar.Text = "Iniciar Sesión";
        btnIngresar.UseVisualStyleBackColor = false;
        btnIngresar.Click += BtnIngresar_Click;
        // 
        // txtClave
        // 
        txtClave.BorderStyle = BorderStyle.FixedSingle;
        txtClave.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtClave.ForeColor = Color.FromArgb(15, 23, 42);
        txtClave.Location = new Point(418, 125);
        txtClave.Name = "txtClave";
        txtClave.Size = new Size(160, 26);
        txtClave.TabIndex = 3;
        txtClave.UseSystemPasswordChar = true;
        // 
        // lblClave
        // 
        lblClave.AutoSize = true;
        lblClave.Font = new Font("Segoe UI", 9.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblClave.ForeColor = Color.FromArgb(51, 65, 85);
        lblClave.Location = new Point(418, 105);
        lblClave.Name = "lblClave";
        lblClave.Size = new Size(81, 17);
        lblClave.TabIndex = 2;
        lblClave.Text = "Contraseña:";
        // 
        // txtUsuario
        // 
        txtUsuario.BorderStyle = BorderStyle.FixedSingle;
        txtUsuario.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtUsuario.ForeColor = Color.FromArgb(15, 23, 42);
        txtUsuario.Location = new Point(418, 58);
        txtUsuario.Name = "txtUsuario";
        txtUsuario.Size = new Size(160, 26);
        txtUsuario.TabIndex = 1;
        // 
        // lblUsuario
        // 
        lblUsuario.AutoSize = true;
        lblUsuario.Font = new Font("Segoe UI", 9.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblUsuario.ForeColor = Color.FromArgb(51, 65, 85);
        lblUsuario.Location = new Point(418, 38);
        lblUsuario.Name = "lblUsuario";
        lblUsuario.Size = new Size(59, 17);
        lblUsuario.TabIndex = 0;
        lblUsuario.Text = "Usuario:";
        // 
        // pictureBox1
        // 
        pictureBox1.Image = Properties.Resources.WhatsApp_Image_2026_11_25_at_10_22_28;
        pictureBox1.Location = new Point(0, 0);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(377, 364);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 7;
        pictureBox1.TabStop = false;
        // 
        // FrmLogin
        // 
        AcceptButton = btnIngresar;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        CancelButton = btnCancelar;
        ClientSize = new Size(678, 461);
        Controls.Add(pnlContenedor);
        Controls.Add(pnlHeader);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "FrmLogin";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "SGICE - Inicio de Sesión";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlContenedor.ResumeLayout(false);
        pnlContenedor.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Panel pnlHeader;
    private Label lblTitulo;
    private Label lblSubtitulo;
    private Panel pnlContenedor;
    private Label lblUsuario;
    private TextBox txtUsuario;
    private Label lblClave;
    private TextBox txtClave;
    private Button btnIngresar;
    private Button btnCancelar;
    private Label lblMensaje;
    private PictureBox pictureBox1;
}
