namespace SGICE.Presentacion;

partial class FrmEntradas
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
        pnlCabecera = new Panel();
        lblTipoDoc = new Label();
        cmbTipoDoc = new ComboBox();
        lblNoDoc = new Label();
        txtNoDoc = new TextBox();
        lblObservacion = new Label();
        txtObservacion = new TextBox();
        pnlGeneracion = new Panel();
        lblActivo = new Label();
        cmbActivo = new ComboBox();
        lblCantidad = new Label();
        txtCantidad = new TextBox();
        btnGenerar = new Button();
        btnQuitar = new Button();
        pnlAcciones = new Panel();
        btnProcesar = new Button();
        btnLimpiar = new Button();
        lblTotalActivos = new Label();
        dgvActivosFisicos = new DataGridView();
        pictureBox1 = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
        pnlTop.SuspendLayout();
        pnlCabecera.SuspendLayout();
        pnlGeneracion.SuspendLayout();
        pnlAcciones.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvActivosFisicos).BeginInit();
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
        pnlTop.Size = new Size(1060, 77);
        pnlTop.TabIndex = 0;
        // 
        // lblTitulo
        // 
        lblTitulo.AutoSize = true;
        lblTitulo.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblTitulo.ForeColor = Color.White;
        lblTitulo.Location = new Point(249, 23);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(634, 31);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "Entrada de Activos y Asignación de Códigos QR / AF";
        // 
        // pnlCabecera
        // 
        pnlCabecera.BackColor = Color.FromArgb(248, 250, 252);
        pnlCabecera.Controls.Add(lblTipoDoc);
        pnlCabecera.Controls.Add(cmbTipoDoc);
        pnlCabecera.Controls.Add(lblNoDoc);
        pnlCabecera.Controls.Add(txtNoDoc);
        pnlCabecera.Controls.Add(lblObservacion);
        pnlCabecera.Controls.Add(txtObservacion);
        pnlCabecera.Dock = DockStyle.Top;
        pnlCabecera.Location = new Point(0, 77);
        pnlCabecera.Name = "pnlCabecera";
        pnlCabecera.Padding = new Padding(16, 10, 16, 10);
        pnlCabecera.Size = new Size(1060, 85);
        pnlCabecera.TabIndex = 1;
        // 
        // lblTipoDoc
        // 
        lblTipoDoc.AutoSize = true;
        lblTipoDoc.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblTipoDoc.ForeColor = Color.FromArgb(51, 65, 85);
        lblTipoDoc.Location = new Point(16, 12);
        lblTipoDoc.Name = "lblTipoDoc";
        lblTipoDoc.Size = new Size(129, 15);
        lblTipoDoc.TabIndex = 0;
        lblTipoDoc.Text = "Documento de Origen:";
        // 
        // cmbTipoDoc
        // 
        cmbTipoDoc.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbTipoDoc.Font = new Font("Segoe UI", 9.5F);
        cmbTipoDoc.FormattingEnabled = true;
        cmbTipoDoc.Location = new Point(16, 30);
        cmbTipoDoc.Name = "cmbTipoDoc";
        cmbTipoDoc.Size = new Size(200, 25);
        cmbTipoDoc.TabIndex = 1;
        // 
        // lblNoDoc
        // 
        lblNoDoc.AutoSize = true;
        lblNoDoc.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblNoDoc.ForeColor = Color.FromArgb(51, 65, 85);
        lblNoDoc.Location = new Point(230, 12);
        lblNoDoc.Name = "lblNoDoc";
        lblNoDoc.Size = new Size(96, 15);
        lblNoDoc.TabIndex = 2;
        lblNoDoc.Text = "No. Documento:";
        // 
        // txtNoDoc
        // 
        txtNoDoc.Font = new Font("Segoe UI", 9.5F);
        txtNoDoc.Location = new Point(230, 30);
        txtNoDoc.Name = "txtNoDoc";
        txtNoDoc.PlaceholderText = "FAC-98432";
        txtNoDoc.Size = new Size(200, 24);
        txtNoDoc.TabIndex = 3;
        // 
        // lblObservacion
        // 
        lblObservacion.AutoSize = true;
        lblObservacion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblObservacion.ForeColor = Color.FromArgb(51, 65, 85);
        lblObservacion.Location = new Point(450, 12);
        lblObservacion.Name = "lblObservacion";
        lblObservacion.Size = new Size(87, 15);
        lblObservacion.TabIndex = 4;
        lblObservacion.Text = "Observaciones:";
        // 
        // txtObservacion
        // 
        txtObservacion.Font = new Font("Segoe UI", 9.5F);
        txtObservacion.Location = new Point(450, 30);
        txtObservacion.Name = "txtObservacion";
        txtObservacion.Size = new Size(590, 24);
        txtObservacion.TabIndex = 5;
        // 
        // pnlGeneracion
        // 
        pnlGeneracion.BackColor = Color.White;
        pnlGeneracion.Controls.Add(lblActivo);
        pnlGeneracion.Controls.Add(cmbActivo);
        pnlGeneracion.Controls.Add(lblCantidad);
        pnlGeneracion.Controls.Add(txtCantidad);
        pnlGeneracion.Controls.Add(btnGenerar);
        pnlGeneracion.Controls.Add(btnQuitar);
        pnlGeneracion.Dock = DockStyle.Top;
        pnlGeneracion.Location = new Point(0, 162);
        pnlGeneracion.Name = "pnlGeneracion";
        pnlGeneracion.Padding = new Padding(16, 10, 16, 10);
        pnlGeneracion.Size = new Size(1060, 56);
        pnlGeneracion.TabIndex = 2;
        // 
        // lblActivo
        // 
        lblActivo.AutoSize = true;
        lblActivo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblActivo.ForeColor = Color.FromArgb(51, 65, 85);
        lblActivo.Location = new Point(16, 18);
        lblActivo.Name = "lblActivo";
        lblActivo.Size = new Size(110, 15);
        lblActivo.TabIndex = 0;
        lblActivo.Text = "Catálogo de Activo:";
        // 
        // cmbActivo
        // 
        cmbActivo.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbActivo.Font = new Font("Segoe UI", 9.5F);
        cmbActivo.FormattingEnabled = true;
        cmbActivo.Location = new Point(135, 14);
        cmbActivo.Name = "cmbActivo";
        cmbActivo.Size = new Size(420, 25);
        cmbActivo.TabIndex = 1;
        // 
        // lblCantidad
        // 
        lblCantidad.AutoSize = true;
        lblCantidad.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblCantidad.ForeColor = Color.FromArgb(51, 65, 85);
        lblCantidad.Location = new Point(570, 18);
        lblCantidad.Name = "lblCantidad";
        lblCantidad.Size = new Size(57, 15);
        lblCantidad.TabIndex = 2;
        lblCantidad.Text = "Cantidad:";
        // 
        // txtCantidad
        // 
        txtCantidad.Font = new Font("Segoe UI", 9.5F);
        txtCantidad.Location = new Point(633, 14);
        txtCantidad.Name = "txtCantidad";
        txtCantidad.PlaceholderText = "1";
        txtCantidad.Size = new Size(80, 24);
        txtCantidad.TabIndex = 3;
        // 
        // btnGenerar
        // 
        btnGenerar.BackColor = Color.MediumSpringGreen;
        btnGenerar.Location = new Point(730, 10);
        btnGenerar.Name = "btnGenerar";
        btnGenerar.Size = new Size(180, 32);
        btnGenerar.TabIndex = 4;
        btnGenerar.Text = "Generar Activos Físicos";
        btnGenerar.UseVisualStyleBackColor = false;
        btnGenerar.Click += BtnGenerar_Click;
        // 
        // btnQuitar
        // 
        btnQuitar.BackColor = SystemColors.ActiveBorder;
        btnQuitar.Location = new Point(920, 10);
        btnQuitar.Name = "btnQuitar";
        btnQuitar.Size = new Size(120, 32);
        btnQuitar.TabIndex = 5;
        btnQuitar.Text = "Quitar Selección";
        btnQuitar.UseVisualStyleBackColor = false;
        btnQuitar.Click += BtnQuitar_Click;
        // 
        // pnlAcciones
        // 
        pnlAcciones.BackColor = Color.FromArgb(248, 250, 252);
        pnlAcciones.Controls.Add(btnProcesar);
        pnlAcciones.Controls.Add(btnLimpiar);
        pnlAcciones.Controls.Add(lblTotalActivos);
        pnlAcciones.Dock = DockStyle.Bottom;
        pnlAcciones.Location = new Point(0, 560);
        pnlAcciones.Name = "pnlAcciones";
        pnlAcciones.Padding = new Padding(16, 12, 16, 12);
        pnlAcciones.Size = new Size(1060, 60);
        pnlAcciones.TabIndex = 4;
        // 
        // btnProcesar
        // 
        btnProcesar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnProcesar.BackColor = Color.MediumSpringGreen;
        btnProcesar.Location = new Point(780, 12);
        btnProcesar.Name = "btnProcesar";
        btnProcesar.Size = new Size(260, 36);
        btnProcesar.TabIndex = 0;
        btnProcesar.Text = "Registrar Entrada Transaccional";
        btnProcesar.UseVisualStyleBackColor = false;
        btnProcesar.Click += BtnProcesar_Click;
        // 
        // btnLimpiar
        // 
        btnLimpiar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnLimpiar.BackColor = SystemColors.ActiveBorder;
        btnLimpiar.Location = new Point(660, 12);
        btnLimpiar.Name = "btnLimpiar";
        btnLimpiar.Size = new Size(110, 36);
        btnLimpiar.TabIndex = 1;
        btnLimpiar.Text = "Cancelar";
        btnLimpiar.UseVisualStyleBackColor = false;
        btnLimpiar.Click += BtnLimpiar_Click;
        // 
        // lblTotalActivos
        // 
        lblTotalActivos.AutoSize = true;
        lblTotalActivos.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        lblTotalActivos.ForeColor = Color.FromArgb(30, 41, 59);
        lblTotalActivos.Location = new Point(16, 20);
        lblTotalActivos.Name = "lblTotalActivos";
        lblTotalActivos.Size = new Size(264, 19);
        lblTotalActivos.TabIndex = 2;
        lblTotalActivos.Text = "Total de activos físicos generados (AF): 0";
        // 
        // dgvActivosFisicos
        // 
        dgvActivosFisicos.Dock = DockStyle.Fill;
        dgvActivosFisicos.Location = new Point(0, 218);
        dgvActivosFisicos.Name = "dgvActivosFisicos";
        dgvActivosFisicos.Size = new Size(1060, 342);
        dgvActivosFisicos.TabIndex = 3;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = Properties.Resources.orden;
        pictureBox1.Location = new Point(57, 3);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(79, 74);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 1;
        pictureBox1.TabStop = false;
        // 
        // FrmEntradas
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1060, 620);
        Controls.Add(dgvActivosFisicos);
        Controls.Add(pnlAcciones);
        Controls.Add(pnlGeneracion);
        Controls.Add(pnlCabecera);
        Controls.Add(pnlTop);
        Name = "FrmEntradas";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Recepción y Entrada de Activos";
        Load += FrmEntradas_Load;
        ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
        pnlTop.ResumeLayout(false);
        pnlTop.PerformLayout();
        pnlCabecera.ResumeLayout(false);
        pnlCabecera.PerformLayout();
        pnlGeneracion.ResumeLayout(false);
        pnlGeneracion.PerformLayout();
        pnlAcciones.ResumeLayout(false);
        pnlAcciones.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvActivosFisicos).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private ErrorProvider errorProvider;
    private Panel pnlTop;
    private Label lblTitulo;
    private Panel pnlCabecera;
    private Label lblTipoDoc;
    private ComboBox cmbTipoDoc;
    private Label lblNoDoc;
    private TextBox txtNoDoc;
    private Label lblObservacion;
    private TextBox txtObservacion;
    private Panel pnlGeneracion;
    private Label lblActivo;
    private ComboBox cmbActivo;
    private Label lblCantidad;
    private TextBox txtCantidad;
    private Button btnGenerar;
    private Button btnQuitar;
    private Panel pnlAcciones;
    private Button btnProcesar;
    private Button btnLimpiar;
    private Label lblTotalActivos;
    private DataGridView dgvActivosFisicos;
    private PictureBox pictureBox1;
}
