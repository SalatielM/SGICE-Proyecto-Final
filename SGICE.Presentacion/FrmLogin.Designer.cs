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
        pnlIzquierdo = new Panel();
        pictureBox1 = new PictureBox();
        lblTitulo = new Label();
        pnlDerecho = new Panel();
        picUsuario = new PictureBox();
        lblUsuario = new Label();
        txtUsuario = new TextBox();
        lblClave = new Label();
        txtClave = new TextBox();
        lblMensaje = new Label();
        btnIngresar = new Button();
        btnCancelar = new Button();
        pnlIzquierdo.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        pnlDerecho.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)picUsuario).BeginInit();
        SuspendLayout();
        // 
        // pnlIzquierdo
        // 
        pnlIzquierdo.BackColor = Color.White;
        pnlIzquierdo.Controls.Add(lblTitulo);
        pnlIzquierdo.Controls.Add(pictureBox1);
        pnlIzquierdo.Dock = DockStyle.Left;
        pnlIzquierdo.Location = new Point(0, 0);
        pnlIzquierdo.Name = "pnlIzquierdo";
        pnlIzquierdo.Padding = new Padding(20);
        pnlIzquierdo.Size = new Size(380, 460);
        pnlIzquierdo.TabIndex = 0;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = Properties.Resources.WhatsApp_Image_2026_11_25_at_10_22_28;
        pictureBox1.Location = new Point(55, 58);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(270, 230);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // lblTitulo
        // 
        lblTitulo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.Black;
        lblTitulo.Location = new Point(20, 305);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(340, 75);
        lblTitulo.TabIndex = 1;
        lblTitulo.Text = "SISTEMA DE GESTION DE INMOBILIARIOS PARA CENTROS EDUCATIVOS";
        lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // pnlDerecho
        // 
        pnlDerecho.BackColor = Color.FromArgb(142, 177, 209);
        pnlDerecho.Controls.Add(picUsuario);
        pnlDerecho.Controls.Add(lblUsuario);
        pnlDerecho.Controls.Add(txtUsuario);
        pnlDerecho.Controls.Add(lblClave);
        pnlDerecho.Controls.Add(txtClave);
        pnlDerecho.Controls.Add(lblMensaje);
        pnlDerecho.Controls.Add(btnIngresar);
        pnlDerecho.Controls.Add(btnCancelar);
        pnlDerecho.Dock = DockStyle.Fill;
        pnlDerecho.Location = new Point(380, 0);
        pnlDerecho.Name = "pnlDerecho";
        pnlDerecho.Size = new Size(380, 460);
        pnlDerecho.TabIndex = 1;
        // 
        // picUsuario
        // 
        picUsuario.Image = Properties.Resources.lider;
        picUsuario.Location = new Point(140, 40);
        picUsuario.Name = "picUsuario";
        picUsuario.Size = new Size(100, 90);
        picUsuario.SizeMode = PictureBoxSizeMode.Zoom;
        picUsuario.TabIndex = 0;
        picUsuario.TabStop = false;
        // 
        // lblUsuario
        // 
        lblUsuario.AutoSize = true;
        lblUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblUsuario.ForeColor = Color.Black;
        lblUsuario.Location = new Point(55, 155);
        lblUsuario.Name = "lblUsuario";
        lblUsuario.Size = new Size(54, 15);
        lblUsuario.TabIndex = 1;
        lblUsuario.Text = "Usuario:";
        // 
        // txtUsuario
        // 
        txtUsuario.BackColor = SystemColors.Window;
        txtUsuario.BorderStyle = BorderStyle.FixedSingle;
        txtUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        txtUsuario.Location = new Point(55, 175);
        txtUsuario.Name = "txtUsuario";
        txtUsuario.Size = new Size(270, 23);
        txtUsuario.TabIndex = 2;
        // 
        // lblClave
        // 
        lblClave.AutoSize = true;
        lblClave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblClave.ForeColor = Color.Black;
        lblClave.Location = new Point(55, 215);
        lblClave.Name = "lblClave";
        lblClave.Size = new Size(73, 15);
        lblClave.TabIndex = 3;
        lblClave.Text = "Contraseña:";
        // 
        // txtClave
        // 
        txtClave.BackColor = SystemColors.Window;
        txtClave.BorderStyle = BorderStyle.FixedSingle;
        txtClave.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        txtClave.Location = new Point(55, 235);
        txtClave.Name = "txtClave";
        txtClave.Size = new Size(270, 23);
        txtClave.TabIndex = 4;
        txtClave.UseSystemPasswordChar = true;
        // 
        // lblMensaje
        // 
        lblMensaje.AutoSize = true;
        lblMensaje.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblMensaje.ForeColor = Color.DarkRed;
        lblMensaje.Location = new Point(55, 270);
        lblMensaje.MaximumSize = new Size(270, 0);
        lblMensaje.Name = "lblMensaje";
        lblMensaje.Size = new Size(0, 15);
        lblMensaje.TabIndex = 5;
        lblMensaje.Visible = false;
        // 
        // btnIngresar
        // 
        btnIngresar.BackColor = Color.FromArgb(232, 245, 233);
        btnIngresar.FlatStyle = FlatStyle.Standard;
        btnIngresar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnIngresar.ForeColor = Color.Black;
        btnIngresar.Location = new Point(55, 315);
        btnIngresar.Name = "btnIngresar";
        btnIngresar.Size = new Size(125, 28);
        btnIngresar.TabIndex = 6;
        btnIngresar.Text = "Iniciar";
        btnIngresar.UseVisualStyleBackColor = false;
        btnIngresar.Click += BtnIngresar_Click;
        // 
        // btnCancelar
        // 
        btnCancelar.BackColor = Color.FromArgb(255, 235, 238);
        btnCancelar.FlatStyle = FlatStyle.Standard;
        btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnCancelar.ForeColor = Color.Black;
        btnCancelar.Location = new Point(200, 315);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new Size(125, 28);
        btnCancelar.TabIndex = 7;
        btnCancelar.Text = "Salir";
        btnCancelar.UseVisualStyleBackColor = false;
        btnCancelar.Click += BtnCancelar_Click;
        // 
        // FrmLogin
        // 
        AcceptButton = btnIngresar;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        CancelButton = btnCancelar;
        ClientSize = new Size(760, 460);
        Controls.Add(pnlDerecho);
        Controls.Add(pnlIzquierdo);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "FrmLogin";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "SGICE - Inicio de Sesión";
        pnlIzquierdo.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        pnlDerecho.ResumeLayout(false);
        pnlDerecho.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)picUsuario).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Panel pnlIzquierdo;
    private PictureBox pictureBox1;
    private Label lblTitulo;
    private Panel pnlDerecho;
    private PictureBox picUsuario;
    private Label lblUsuario;
    private TextBox txtUsuario;
    private Label lblClave;
    private TextBox txtClave;
    private Label lblMensaje;
    private Button btnIngresar;
    private Button btnCancelar;
}
