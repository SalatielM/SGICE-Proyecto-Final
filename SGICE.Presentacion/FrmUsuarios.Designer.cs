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
        pnlAcciones = new Panel();
        btnNuevo = new Button();
        btnGuardar = new Button();
        btnCancelar = new Button();
        pnlListaContainer = new Panel();
        grpLista = new GroupBox();
        dgvUsuarios = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
        pnlTop.SuspendLayout();
        pnlFiltro.SuspendLayout();
        pnlDatosContainer.SuspendLayout();
        grpDatos.SuspendLayout();
        pnlAcciones.SuspendLayout();
        pnlListaContainer.SuspendLayout();
        grpLista.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
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
        pnlTop.Size = new Size(1020, 32);
        pnlTop.TabIndex = 0;
        // 
        // lblTitulo
        // 
        lblTitulo.Dock = DockStyle.Fill;
        lblTitulo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.Black;
        lblTitulo.Location = new Point(0, 0);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(1020, 32);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "REGISTRO DE USUARIOS Y SEGURIDAD";
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
        pnlFiltro.Size = new Size(1020, 36);
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
        txtBuscar.Size = new Size(968, 23);
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
        btnBuscar.Location = new Point(982, 6);
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
        pnlDatosContainer.Size = new Size(1020, 98);
        pnlDatosContainer.TabIndex = 2;
        // 
        // grpDatos
        // 
        grpDatos.BackColor = SystemColors.Control;
        grpDatos.Controls.Add(lblNombreUsuario);
        grpDatos.Controls.Add(txtNombreUsuario);
        grpDatos.Controls.Add(lblClave);
        grpDatos.Controls.Add(txtClave);
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
        grpDatos.Controls.Add(lblRol);
        grpDatos.Controls.Add(cmbRol);
        grpDatos.Dock = DockStyle.Fill;
        grpDatos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        grpDatos.ForeColor = Color.Black;
        grpDatos.Location = new Point(8, 2);
        grpDatos.Name = "grpDatos";
        grpDatos.Size = new Size(1004, 94);
        grpDatos.TabIndex = 0;
        grpDatos.TabStop = false;
        grpDatos.Text = "Datos del Usuario";
        // 
        // lblNombreUsuario
        // 
        lblNombreUsuario.AutoSize = true;
        lblNombreUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblNombreUsuario.ForeColor = Color.Black;
        lblNombreUsuario.Location = new Point(12, 26);
        lblNombreUsuario.Name = "lblNombreUsuario";
        lblNombreUsuario.Size = new Size(54, 15);
        lblNombreUsuario.TabIndex = 0;
        lblNombreUsuario.Text = "Usuario:";
        // 
        // txtNombreUsuario
        // 
        txtNombreUsuario.BackColor = SystemColors.Window;
        txtNombreUsuario.BorderStyle = BorderStyle.FixedSingle;
        txtNombreUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        txtNombreUsuario.Location = new Point(74, 23);
        txtNombreUsuario.Name = "txtNombreUsuario";
        txtNombreUsuario.PlaceholderText = "jlopez";
        txtNombreUsuario.Size = new Size(140, 23);
        txtNombreUsuario.TabIndex = 1;
        // 
        // lblClave
        // 
        lblClave.AutoSize = true;
        lblClave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblClave.ForeColor = Color.Black;
        lblClave.Location = new Point(226, 26);
        lblClave.Name = "lblClave";
        lblClave.Size = new Size(73, 15);
        lblClave.TabIndex = 2;
        lblClave.Text = "Contraseña:";
        // 
        // txtClave
        // 
        txtClave.BackColor = SystemColors.Window;
        txtClave.BorderStyle = BorderStyle.FixedSingle;
        txtClave.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        txtClave.Location = new Point(305, 23);
        txtClave.Name = "txtClave";
        txtClave.PlaceholderText = "(Opcional al editar)";
        txtClave.Size = new Size(165, 23);
        txtClave.TabIndex = 3;
        txtClave.UseSystemPasswordChar = true;
        // 
        // lblNombre
        // 
        lblNombre.AutoSize = true;
        lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblNombre.ForeColor = Color.Black;
        lblNombre.Location = new Point(482, 26);
        lblNombre.Name = "lblNombre";
        lblNombre.Size = new Size(57, 15);
        lblNombre.TabIndex = 4;
        lblNombre.Text = "Nombre:";
        // 
        // txtNombre
        // 
        txtNombre.BackColor = SystemColors.Window;
        txtNombre.BorderStyle = BorderStyle.FixedSingle;
        txtNombre.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        txtNombre.Location = new Point(545, 23);
        txtNombre.Name = "txtNombre";
        txtNombre.Size = new Size(180, 23);
        txtNombre.TabIndex = 5;
        // 
        // lblApellido
        // 
        lblApellido.AutoSize = true;
        lblApellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblApellido.ForeColor = Color.Black;
        lblApellido.Location = new Point(738, 26);
        lblApellido.Name = "lblApellido";
        lblApellido.Size = new Size(57, 15);
        lblApellido.TabIndex = 6;
        lblApellido.Text = "Apellido:";
        // 
        // txtApellido
        // 
        txtApellido.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtApellido.BackColor = SystemColors.Window;
        txtApellido.BorderStyle = BorderStyle.FixedSingle;
        txtApellido.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        txtApellido.Location = new Point(801, 23);
        txtApellido.Name = "txtApellido";
        txtApellido.Size = new Size(189, 23);
        txtApellido.TabIndex = 7;
        // 
        // lblCedula
        // 
        lblCedula.AutoSize = true;
        lblCedula.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblCedula.ForeColor = Color.Black;
        lblCedula.Location = new Point(12, 58);
        lblCedula.Name = "lblCedula";
        lblCedula.Size = new Size(49, 15);
        lblCedula.TabIndex = 8;
        lblCedula.Text = "Cédula:";
        // 
        // txtCedula
        // 
        txtCedula.BackColor = SystemColors.Window;
        txtCedula.BorderStyle = BorderStyle.FixedSingle;
        txtCedula.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        txtCedula.Location = new Point(74, 55);
        txtCedula.Name = "txtCedula";
        txtCedula.PlaceholderText = "001-0000000-0";
        txtCedula.Size = new Size(140, 23);
        txtCedula.TabIndex = 9;
        // 
        // lblTelefono
        // 
        lblTelefono.AutoSize = true;
        lblTelefono.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblTelefono.ForeColor = Color.Black;
        lblTelefono.Location = new Point(226, 58);
        lblTelefono.Name = "lblTelefono";
        lblTelefono.Size = new Size(60, 15);
        lblTelefono.TabIndex = 10;
        lblTelefono.Text = "Teléfono:";
        // 
        // txtTelefono
        // 
        txtTelefono.BackColor = SystemColors.Window;
        txtTelefono.BorderStyle = BorderStyle.FixedSingle;
        txtTelefono.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        txtTelefono.Location = new Point(305, 55);
        txtTelefono.Name = "txtTelefono";
        txtTelefono.PlaceholderText = "809-555-0100";
        txtTelefono.Size = new Size(165, 23);
        txtTelefono.TabIndex = 11;
        // 
        // lblCorreo
        // 
        lblCorreo.AutoSize = true;
        lblCorreo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblCorreo.ForeColor = Color.Black;
        lblCorreo.Location = new Point(482, 58);
        lblCorreo.Name = "lblCorreo";
        lblCorreo.Size = new Size(49, 15);
        lblCorreo.TabIndex = 12;
        lblCorreo.Text = "Correo:";
        // 
        // txtCorreo
        // 
        txtCorreo.BackColor = SystemColors.Window;
        txtCorreo.BorderStyle = BorderStyle.FixedSingle;
        txtCorreo.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        txtCorreo.Location = new Point(545, 55);
        txtCorreo.Name = "txtCorreo";
        txtCorreo.PlaceholderText = "usuario@escuela.edu.do";
        txtCorreo.Size = new Size(180, 23);
        txtCorreo.TabIndex = 13;
        // 
        // lblRol
        // 
        lblRol.AutoSize = true;
        lblRol.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblRol.ForeColor = Color.Black;
        lblRol.Location = new Point(738, 58);
        lblRol.Name = "lblRol";
        lblRol.Size = new Size(29, 15);
        lblRol.TabIndex = 14;
        lblRol.Text = "Rol:";
        // 
        // cmbRol
        // 
        cmbRol.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        cmbRol.BackColor = SystemColors.Window;
        cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbRol.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        cmbRol.FormattingEnabled = true;
        cmbRol.Location = new Point(801, 55);
        cmbRol.Name = "cmbRol";
        cmbRol.Size = new Size(189, 23);
        cmbRol.TabIndex = 15;
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
        pnlAcciones.Size = new Size(1020, 38);
        pnlAcciones.TabIndex = 3;
        // 
        // btnNuevo
        // 
        btnNuevo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnNuevo.BackColor = Color.FromArgb(224, 247, 250);
        btnNuevo.FlatStyle = FlatStyle.Standard;
        btnNuevo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnNuevo.ForeColor = Color.Black;
        btnNuevo.Location = new Point(685, 5);
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
        btnGuardar.Location = new Point(796, 5);
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
        btnCancelar.Location = new Point(907, 5);
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
        pnlListaContainer.Size = new Size(1020, 416);
        pnlListaContainer.TabIndex = 4;
        // 
        // grpLista
        // 
        grpLista.BackColor = SystemColors.Control;
        grpLista.Controls.Add(dgvUsuarios);
        grpLista.Dock = DockStyle.Fill;
        grpLista.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        grpLista.ForeColor = Color.Black;
        grpLista.Location = new Point(8, 2);
        grpLista.Name = "grpLista";
        grpLista.Padding = new Padding(8);
        grpLista.Size = new Size(1004, 406);
        grpLista.TabIndex = 0;
        grpLista.TabStop = false;
        grpLista.Text = "Lista de Usuarios";
        // 
        // dgvUsuarios
        // 
        dgvUsuarios.AllowUserToAddRows = false;
        dgvUsuarios.AllowUserToDeleteRows = false;
        dgvUsuarios.AllowUserToResizeRows = false;
        dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvUsuarios.BackgroundColor = Color.White;
        dgvUsuarios.BorderStyle = BorderStyle.FixedSingle;
        dgvHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dgvHeaderStyle.BackColor = SystemColors.Control;
        dgvHeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        dgvHeaderStyle.ForeColor = Color.Black;
        dgvHeaderStyle.SelectionBackColor = SystemColors.Highlight;
        dgvHeaderStyle.SelectionForeColor = SystemColors.HighlightText;
        dgvHeaderStyle.WrapMode = DataGridViewTriState.True;
        dgvUsuarios.ColumnHeadersDefaultCellStyle = dgvHeaderStyle;
        dgvUsuarios.ColumnHeadersHeight = 26;
        dgvCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dgvCellStyle.BackColor = SystemColors.Window;
        dgvCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        dgvCellStyle.ForeColor = Color.Black;
        dgvCellStyle.SelectionBackColor = SystemColors.Highlight;
        dgvCellStyle.SelectionForeColor = SystemColors.HighlightText;
        dgvCellStyle.WrapMode = DataGridViewTriState.False;
        dgvUsuarios.DefaultCellStyle = dgvCellStyle;
        dgvUsuarios.Dock = DockStyle.Fill;
        dgvUsuarios.EnableHeadersVisualStyles = true;
        dgvUsuarios.Location = new Point(8, 22);
        dgvUsuarios.MultiSelect = false;
        dgvUsuarios.Name = "dgvUsuarios";
        dgvUsuarios.ReadOnly = true;
        dgvUsuarios.RowHeadersVisible = true;
        dgvUsuarios.RowHeadersWidth = 25;
        dgvUsuarios.RowTemplate.Height = 24;
        dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvUsuarios.Size = new Size(988, 376);
        dgvUsuarios.TabIndex = 0;
        dgvUsuarios.SelectionChanged += DgvUsuarios_SelectionChanged;
        // 
        // FrmUsuarios
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        ClientSize = new Size(1020, 620);
        Controls.Add(pnlListaContainer);
        Controls.Add(pnlAcciones);
        Controls.Add(pnlDatosContainer);
        Controls.Add(pnlFiltro);
        Controls.Add(pnlTop);
        Name = "FrmUsuarios";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Gestión de Usuarios del Sistema";
        Load += FrmUsuarios_Load;
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
        ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
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
    private Panel pnlAcciones;
    private Button btnNuevo;
    private Button btnGuardar;
    private Button btnCancelar;
    private Panel pnlListaContainer;
    private GroupBox grpLista;
    private DataGridView dgvUsuarios;
}
