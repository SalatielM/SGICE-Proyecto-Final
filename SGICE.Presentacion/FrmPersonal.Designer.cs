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
        DataGridViewCellStyle dgvHeaderStyle = new DataGridViewCellStyle();
        DataGridViewCellStyle dgvCellStyle = new DataGridViewCellStyle();
        errorProvider = new ErrorProvider(components);
        pnlTop = new Panel();
        lblTitulo = new Label();
        pnlFiltro = new Panel();
        txtBuscar = new TextBox();
        btnBuscar = new Button();
        pnlDatosContainer = new Panel();
        grpDatos = new GroupBox();
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
        pnlAcciones = new Panel();
        btnNuevo = new Button();
        btnGuardar = new Button();
        btnCancelar = new Button();
        pnlListaContainer = new Panel();
        grpLista = new GroupBox();
        dgvPersonal = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
        pnlTop.SuspendLayout();
        pnlFiltro.SuspendLayout();
        pnlDatosContainer.SuspendLayout();
        grpDatos.SuspendLayout();
        pnlAcciones.SuspendLayout();
        pnlListaContainer.SuspendLayout();
        grpLista.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvPersonal).BeginInit();
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
        pnlTop.Size = new Size(1000, 32);
        pnlTop.TabIndex = 0;
        // 
        // lblTitulo
        // 
        lblTitulo.Dock = DockStyle.Fill;
        lblTitulo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.Black;
        lblTitulo.Location = new Point(0, 0);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(1000, 32);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "REGISTRO DE PERSONAL ESCOLAR";
        lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // pnlFiltro
        // 
        pnlFiltro.BackColor = SystemColors.Control;
        pnlFiltro.Controls.Add(txtBuscar);
        pnlFiltro.Controls.Add(btnBuscar);
        pnlFiltro.Dock = DockStyle.Top;
        pnlFiltro.Location = new Point(0, 32);
        pnlFiltro.Name = "pnlFiltro";
        pnlFiltro.Padding = new Padding(8, 6, 8, 4);
        pnlFiltro.Size = new Size(1000, 36);
        pnlFiltro.TabIndex = 1;
        // 
        // txtBuscar
        // 
        txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtBuscar.BackColor = SystemColors.Window;
        txtBuscar.BorderStyle = BorderStyle.FixedSingle;
        txtBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        txtBuscar.Location = new Point(8, 7);
        txtBuscar.Name = "txtBuscar";
        txtBuscar.PlaceholderText = "Buscar...";
        txtBuscar.Size = new Size(948, 23);
        txtBuscar.TabIndex = 0;
        txtBuscar.TextChanged += TxtBuscar_TextChanged;
        // 
        // btnBuscar
        // 
        btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnBuscar.BackColor = SystemColors.Control;
        btnBuscar.FlatStyle = FlatStyle.Standard;
        btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnBuscar.ForeColor = Color.Black;
        btnBuscar.Location = new Point(962, 6);
        btnBuscar.Name = "btnBuscar";
        btnBuscar.Size = new Size(30, 24);
        btnBuscar.TabIndex = 1;
        btnBuscar.Text = "🔍";
        btnBuscar.UseVisualStyleBackColor = true;
        btnBuscar.Click += BtnBuscar_Click;
        // 
        // pnlDatosContainer
        // 
        pnlDatosContainer.BackColor = SystemColors.Control;
        pnlDatosContainer.Controls.Add(grpDatos);
        pnlDatosContainer.Dock = DockStyle.Top;
        pnlDatosContainer.Location = new Point(0, 68);
        pnlDatosContainer.Name = "pnlDatosContainer";
        pnlDatosContainer.Padding = new Padding(8, 2, 8, 2);
        pnlDatosContainer.Size = new Size(1000, 98);
        pnlDatosContainer.TabIndex = 2;
        // 
        // grpDatos
        // 
        grpDatos.BackColor = SystemColors.Control;
        grpDatos.Controls.Add(lblCodigo);
        grpDatos.Controls.Add(txtCodigo);
        grpDatos.Controls.Add(lblNombre);
        grpDatos.Controls.Add(txtNombre);
        grpDatos.Controls.Add(lblApellido);
        grpDatos.Controls.Add(txtApellido);
        grpDatos.Controls.Add(lblCedula);
        grpDatos.Controls.Add(txtCedula);
        grpDatos.Controls.Add(lblTelefono);
        grpDatos.Controls.Add(txtTelefono);
        grpDatos.Controls.Add(lblCorreo);
        grpDatos.Controls.Add(txtCorreo);
        grpDatos.Controls.Add(lblPuesto);
        grpDatos.Controls.Add(cmbPuesto);
        grpDatos.Dock = DockStyle.Fill;
        grpDatos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        grpDatos.ForeColor = Color.Black;
        grpDatos.Location = new Point(8, 2);
        grpDatos.Name = "grpDatos";
        grpDatos.Size = new Size(984, 94);
        grpDatos.TabIndex = 0;
        grpDatos.TabStop = false;
        grpDatos.Text = "Datos del Personal";
        // 
        // lblCodigo
        // 
        lblCodigo.AutoSize = true;
        lblCodigo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblCodigo.ForeColor = Color.Black;
        lblCodigo.Location = new Point(12, 26);
        lblCodigo.Name = "lblCodigo";
        lblCodigo.Size = new Size(51, 15);
        lblCodigo.TabIndex = 0;
        lblCodigo.Text = "Código:";
        // 
        // txtCodigo
        // 
        txtCodigo.BackColor = SystemColors.Window;
        txtCodigo.BorderStyle = BorderStyle.FixedSingle;
        txtCodigo.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        txtCodigo.Location = new Point(80, 23);
        txtCodigo.Name = "txtCodigo";
        txtCodigo.PlaceholderText = "EMP-001";
        txtCodigo.Size = new Size(110, 23);
        txtCodigo.TabIndex = 1;
        // 
        // lblNombre
        // 
        lblNombre.AutoSize = true;
        lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblNombre.ForeColor = Color.Black;
        lblNombre.Location = new Point(204, 26);
        lblNombre.Name = "lblNombre";
        lblNombre.Size = new Size(57, 15);
        lblNombre.TabIndex = 2;
        lblNombre.Text = "Nombre:";
        // 
        // txtNombre
        // 
        txtNombre.BackColor = SystemColors.Window;
        txtNombre.BorderStyle = BorderStyle.FixedSingle;
        txtNombre.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        txtNombre.Location = new Point(267, 23);
        txtNombre.Name = "txtNombre";
        txtNombre.Size = new Size(190, 23);
        txtNombre.TabIndex = 3;
        // 
        // lblApellido
        // 
        lblApellido.AutoSize = true;
        lblApellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblApellido.ForeColor = Color.Black;
        lblApellido.Location = new Point(470, 26);
        lblApellido.Name = "lblApellido";
        lblApellido.Size = new Size(57, 15);
        lblApellido.TabIndex = 4;
        lblApellido.Text = "Apellido:";
        // 
        // txtApellido
        // 
        txtApellido.BackColor = SystemColors.Window;
        txtApellido.BorderStyle = BorderStyle.FixedSingle;
        txtApellido.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        txtApellido.Location = new Point(533, 23);
        txtApellido.Name = "txtApellido";
        txtApellido.Size = new Size(190, 23);
        txtApellido.TabIndex = 5;
        // 
        // lblCedula
        // 
        lblCedula.AutoSize = true;
        lblCedula.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblCedula.ForeColor = Color.Black;
        lblCedula.Location = new Point(736, 26);
        lblCedula.Name = "lblCedula";
        lblCedula.Size = new Size(49, 15);
        lblCedula.TabIndex = 6;
        lblCedula.Text = "Cédula:";
        // 
        // txtCedula
        // 
        txtCedula.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtCedula.BackColor = SystemColors.Window;
        txtCedula.BorderStyle = BorderStyle.FixedSingle;
        txtCedula.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        txtCedula.Location = new Point(791, 23);
        txtCedula.Name = "txtCedula";
        txtCedula.PlaceholderText = "001-0000000-0";
        txtCedula.Size = new Size(179, 23);
        txtCedula.TabIndex = 7;
        // 
        // lblTelefono
        // 
        lblTelefono.AutoSize = true;
        lblTelefono.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblTelefono.ForeColor = Color.Black;
        lblTelefono.Location = new Point(12, 58);
        lblTelefono.Name = "lblTelefono";
        lblTelefono.Size = new Size(60, 15);
        lblTelefono.TabIndex = 8;
        lblTelefono.Text = "Teléfono:";
        // 
        // txtTelefono
        // 
        txtTelefono.BackColor = SystemColors.Window;
        txtTelefono.BorderStyle = BorderStyle.FixedSingle;
        txtTelefono.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        txtTelefono.Location = new Point(80, 55);
        txtTelefono.Name = "txtTelefono";
        txtTelefono.PlaceholderText = "809-555-0100";
        txtTelefono.Size = new Size(180, 23);
        txtTelefono.TabIndex = 9;
        // 
        // lblCorreo
        // 
        lblCorreo.AutoSize = true;
        lblCorreo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblCorreo.ForeColor = Color.Black;
        lblCorreo.Location = new Point(276, 58);
        lblCorreo.Name = "lblCorreo";
        lblCorreo.Size = new Size(49, 15);
        lblCorreo.TabIndex = 10;
        lblCorreo.Text = "Correo:";
        // 
        // txtCorreo
        // 
        txtCorreo.BackColor = SystemColors.Window;
        txtCorreo.BorderStyle = BorderStyle.FixedSingle;
        txtCorreo.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        txtCorreo.Location = new Point(331, 55);
        txtCorreo.Name = "txtCorreo";
        txtCorreo.PlaceholderText = "docente@escuela.edu.do";
        txtCorreo.Size = new Size(300, 23);
        txtCorreo.TabIndex = 11;
        // 
        // lblPuesto
        // 
        lblPuesto.AutoSize = true;
        lblPuesto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblPuesto.ForeColor = Color.Black;
        lblPuesto.Location = new Point(646, 58);
        lblPuesto.Name = "lblPuesto";
        lblPuesto.Size = new Size(49, 15);
        lblPuesto.TabIndex = 12;
        lblPuesto.Text = "Puesto:";
        // 
        // cmbPuesto
        // 
        cmbPuesto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        cmbPuesto.BackColor = SystemColors.Window;
        cmbPuesto.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbPuesto.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        cmbPuesto.FormattingEnabled = true;
        cmbPuesto.Location = new Point(701, 55);
        cmbPuesto.Name = "cmbPuesto";
        cmbPuesto.Size = new Size(269, 23);
        cmbPuesto.TabIndex = 13;
        // 
        // pnlAcciones
        // 
        pnlAcciones.BackColor = SystemColors.Control;
        pnlAcciones.Controls.Add(btnNuevo);
        pnlAcciones.Controls.Add(btnGuardar);
        pnlAcciones.Controls.Add(btnCancelar);
        pnlAcciones.Dock = DockStyle.Top;
        pnlAcciones.Location = new Point(0, 166);
        pnlAcciones.Name = "pnlAcciones";
        pnlAcciones.Size = new Size(1000, 38);
        pnlAcciones.TabIndex = 3;
        // 
        // btnNuevo
        // 
        btnNuevo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnNuevo.BackColor = Color.FromArgb(224, 247, 250);
        btnNuevo.FlatStyle = FlatStyle.Standard;
        btnNuevo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnNuevo.ForeColor = Color.Black;
        btnNuevo.Location = new Point(665, 5);
        btnNuevo.Name = "btnNuevo";
        btnNuevo.Size = new Size(105, 28);
        btnNuevo.TabIndex = 0;
        btnNuevo.Text = "Nuevo";
        btnNuevo.UseVisualStyleBackColor = false;
        btnNuevo.Click += BtnNuevo_Click;
        // 
        // btnGuardar
        // 
        btnGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnGuardar.BackColor = Color.FromArgb(232, 245, 233);
        btnGuardar.FlatStyle = FlatStyle.Standard;
        btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnGuardar.ForeColor = Color.Black;
        btnGuardar.Location = new Point(776, 5);
        btnGuardar.Name = "btnGuardar";
        btnGuardar.Size = new Size(105, 28);
        btnGuardar.TabIndex = 1;
        btnGuardar.Text = "Guardar";
        btnGuardar.UseVisualStyleBackColor = false;
        btnGuardar.Click += BtnGuardar_Click;
        // 
        // btnCancelar
        // 
        btnCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnCancelar.BackColor = Color.FromArgb(255, 235, 238);
        btnCancelar.FlatStyle = FlatStyle.Standard;
        btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnCancelar.ForeColor = Color.Black;
        btnCancelar.Location = new Point(887, 5);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new Size(105, 28);
        btnCancelar.TabIndex = 2;
        btnCancelar.Text = "Cancelar";
        btnCancelar.UseVisualStyleBackColor = false;
        btnCancelar.Click += BtnCancelar_Click;
        // 
        // pnlListaContainer
        // 
        pnlListaContainer.BackColor = SystemColors.Control;
        pnlListaContainer.Controls.Add(grpLista);
        pnlListaContainer.Dock = DockStyle.Fill;
        pnlListaContainer.Location = new Point(0, 204);
        pnlListaContainer.Name = "pnlListaContainer";
        pnlListaContainer.Padding = new Padding(8, 2, 8, 8);
        pnlListaContainer.Size = new Size(1000, 396);
        pnlListaContainer.TabIndex = 4;
        // 
        // grpLista
        // 
        grpLista.BackColor = SystemColors.Control;
        grpLista.Controls.Add(dgvPersonal);
        grpLista.Dock = DockStyle.Fill;
        grpLista.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        grpLista.ForeColor = Color.Black;
        grpLista.Location = new Point(8, 2);
        grpLista.Name = "grpLista";
        grpLista.Padding = new Padding(8);
        grpLista.Size = new Size(984, 386);
        grpLista.TabIndex = 0;
        grpLista.TabStop = false;
        grpLista.Text = "Lista de Personal Escolar";
        // 
        // dgvPersonal
        // 
        dgvPersonal.AllowUserToAddRows = false;
        dgvPersonal.AllowUserToDeleteRows = false;
        dgvPersonal.AllowUserToResizeRows = false;
        dgvPersonal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvPersonal.BackgroundColor = Color.White;
        dgvPersonal.BorderStyle = BorderStyle.FixedSingle;
        dgvHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dgvHeaderStyle.BackColor = SystemColors.Control;
        dgvHeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        dgvHeaderStyle.ForeColor = Color.Black;
        dgvHeaderStyle.SelectionBackColor = SystemColors.Highlight;
        dgvHeaderStyle.SelectionForeColor = SystemColors.HighlightText;
        dgvHeaderStyle.WrapMode = DataGridViewTriState.True;
        dgvPersonal.ColumnHeadersDefaultCellStyle = dgvHeaderStyle;
        dgvPersonal.ColumnHeadersHeight = 26;
        dgvCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dgvCellStyle.BackColor = SystemColors.Window;
        dgvCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        dgvCellStyle.ForeColor = Color.Black;
        dgvCellStyle.SelectionBackColor = SystemColors.Highlight;
        dgvCellStyle.SelectionForeColor = SystemColors.HighlightText;
        dgvCellStyle.WrapMode = DataGridViewTriState.False;
        dgvPersonal.DefaultCellStyle = dgvCellStyle;
        dgvPersonal.Dock = DockStyle.Fill;
        dgvPersonal.EnableHeadersVisualStyles = true;
        dgvPersonal.Location = new Point(8, 22);
        dgvPersonal.MultiSelect = false;
        dgvPersonal.Name = "dgvPersonal";
        dgvPersonal.ReadOnly = true;
        dgvPersonal.RowHeadersVisible = true;
        dgvPersonal.RowHeadersWidth = 25;
        dgvPersonal.RowTemplate.Height = 24;
        dgvPersonal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvPersonal.Size = new Size(968, 356);
        dgvPersonal.TabIndex = 0;
        dgvPersonal.SelectionChanged += DgvPersonal_SelectionChanged;
        // 
        // FrmPersonal
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        ClientSize = new Size(1000, 600);
        Controls.Add(pnlListaContainer);
        Controls.Add(pnlAcciones);
        Controls.Add(pnlDatosContainer);
        Controls.Add(pnlFiltro);
        Controls.Add(pnlTop);
        Name = "FrmPersonal";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Gestión de Personal Escolar";
        Load += FrmPersonal_Load;
        ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
        pnlTop.ResumeLayout(false);
        pnlFiltro.ResumeLayout(false);
        pnlFiltro.PerformLayout();
        pnlDatosContainer.ResumeLayout(false);
        grpDatos.ResumeLayout(false);
        grpDatos.PerformLayout();
        pnlAcciones.ResumeLayout(false);
        pnlListaContainer.ResumeLayout(false);
        grpLista.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvPersonal).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private ErrorProvider errorProvider;
    private Panel pnlTop;
    private Label lblTitulo;
    private Panel pnlFiltro;
    private TextBox txtBuscar;
    private Button btnBuscar;
    private Panel pnlDatosContainer;
    private GroupBox grpDatos;
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
    private Panel pnlAcciones;
    private Button btnNuevo;
    private Button btnGuardar;
    private Button btnCancelar;
    private Panel pnlListaContainer;
    private GroupBox grpLista;
    private DataGridView dgvPersonal;
}
