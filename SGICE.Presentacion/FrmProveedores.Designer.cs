namespace SGICE.Presentacion;

partial class FrmProveedores
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
        lblRNC = new Label();
        txtRNC = new TextBox();
        lblNombre = new Label();
        txtNombre = new TextBox();
        lblTelefono = new Label();
        txtTelefono = new TextBox();
        lblCorreo = new Label();
        txtCorreo = new TextBox();
        lblContacto = new Label();
        txtContacto = new TextBox();
        lblDireccion = new Label();
        txtDireccion = new TextBox();
        pnlAcciones = new Panel();
        btnNuevo = new Button();
        btnGuardar = new Button();
        btnCancelar = new Button();
        pnlListaContainer = new Panel();
        grpLista = new GroupBox();
        dgvProveedores = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
        pnlTop.SuspendLayout();
        pnlFiltro.SuspendLayout();
        pnlDatosContainer.SuspendLayout();
        grpDatos.SuspendLayout();
        pnlAcciones.SuspendLayout();
        pnlListaContainer.SuspendLayout();
        grpLista.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
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
        pnlTop.Size = new Size(960, 32);
        pnlTop.TabIndex = 0;
        // 
        // lblTitulo
        // 
        lblTitulo.Dock = DockStyle.Fill;
        lblTitulo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.Black;
        lblTitulo.Location = new Point(0, 0);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(960, 32);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "REGISTRO DE PROVEEDORES";
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
        pnlFiltro.Size = new Size(960, 36);
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
        txtBuscar.Size = new Size(908, 23);
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
        btnBuscar.Location = new Point(922, 6);
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
        pnlDatosContainer.Size = new Size(960, 156);
        pnlDatosContainer.TabIndex = 2;
        // 
        // grpDatos
        // 
        grpDatos.BackColor = SystemColors.Control;
        grpDatos.Controls.Add(lblRNC);
        grpDatos.Controls.Add(txtRNC);
        grpDatos.Controls.Add(lblNombre);
        grpDatos.Controls.Add(txtNombre);
        grpDatos.Controls.Add(lblTelefono);
        grpDatos.Controls.Add(txtTelefono);
        grpDatos.Controls.Add(lblCorreo);
        grpDatos.Controls.Add(txtCorreo);
        grpDatos.Controls.Add(lblContacto);
        grpDatos.Controls.Add(txtContacto);
        grpDatos.Controls.Add(lblDireccion);
        grpDatos.Controls.Add(txtDireccion);
        grpDatos.Dock = DockStyle.Fill;
        grpDatos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        grpDatos.ForeColor = Color.Black;
        grpDatos.Location = new Point(8, 2);
        grpDatos.Name = "grpDatos";
        grpDatos.Size = new Size(944, 152);
        grpDatos.TabIndex = 0;
        grpDatos.TabStop = false;
        grpDatos.Text = "Datos del Proveedor";
        // 
        // lblRNC
        // 
        lblRNC.AutoSize = true;
        lblRNC.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblRNC.ForeColor = Color.Black;
        lblRNC.Location = new Point(12, 26);
        lblRNC.Name = "lblRNC";
        lblRNC.Size = new Size(36, 15);
        lblRNC.TabIndex = 0;
        lblRNC.Text = "RNC:";
        // 
        // txtRNC
        // 
        txtRNC.BackColor = SystemColors.Window;
        txtRNC.BorderStyle = BorderStyle.FixedSingle;
        txtRNC.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        txtRNC.Location = new Point(98, 23);
        txtRNC.Name = "txtRNC";
        txtRNC.PlaceholderText = "101-12345-6";
        txtRNC.Size = new Size(150, 23);
        txtRNC.TabIndex = 1;
        // 
        // lblNombre
        // 
        lblNombre.AutoSize = true;
        lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblNombre.ForeColor = Color.Black;
        lblNombre.Location = new Point(268, 26);
        lblNombre.Name = "lblNombre";
        lblNombre.Size = new Size(57, 15);
        lblNombre.TabIndex = 2;
        lblNombre.Text = "Nombre:";
        lblNombre.Click += lblNombre_Click;
        // 
        // txtNombre
        // 
        txtNombre.BackColor = SystemColors.Window;
        txtNombre.BorderStyle = BorderStyle.FixedSingle;
        txtNombre.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        txtNombre.Location = new Point(331, 23);
        txtNombre.Name = "txtNombre";
        txtNombre.Size = new Size(310, 23);
        txtNombre.TabIndex = 3;
        // 
        // lblTelefono
        // 
        lblTelefono.AutoSize = true;
        lblTelefono.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblTelefono.ForeColor = Color.Black;
        lblTelefono.Location = new Point(658, 26);
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
        txtTelefono.Location = new Point(724, 23);
        txtTelefono.Name = "txtTelefono";
        txtTelefono.PlaceholderText = "809-555-0100";
        txtTelefono.Size = new Size(206, 23);
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
        txtCorreo.PlaceholderText = "ventas@proveedor.com";
        txtCorreo.Size = new Size(340, 23);
        txtCorreo.TabIndex = 7;
        // 
        // lblContacto
        // 
        lblContacto.AutoSize = true;
        lblContacto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblContacto.ForeColor = Color.Black;
        lblContacto.Location = new Point(458, 58);
        lblContacto.Name = "lblContacto";
        lblContacto.Size = new Size(61, 15);
        lblContacto.TabIndex = 8;
        lblContacto.Text = "Contacto:";
        // 
        // txtContacto
        // 
        txtContacto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtContacto.BackColor = SystemColors.Window;
        txtContacto.BorderStyle = BorderStyle.FixedSingle;
        txtContacto.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        txtContacto.Location = new Point(525, 55);
        txtContacto.Name = "txtContacto";
        txtContacto.Size = new Size(405, 23);
        txtContacto.TabIndex = 9;
        // 
        // lblDireccion
        // 
        lblDireccion.AutoSize = true;
        lblDireccion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblDireccion.ForeColor = Color.Black;
        lblDireccion.Location = new Point(12, 92);
        lblDireccion.Name = "lblDireccion";
        lblDireccion.Size = new Size(64, 15);
        lblDireccion.TabIndex = 10;
        lblDireccion.Text = "Dirección:";
        // 
        // txtDireccion
        // 
        txtDireccion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtDireccion.BackColor = SystemColors.Window;
        txtDireccion.BorderStyle = BorderStyle.FixedSingle;
        txtDireccion.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        txtDireccion.Location = new Point(98, 90);
        txtDireccion.Multiline = true;
        txtDireccion.Name = "txtDireccion";
        txtDireccion.Size = new Size(832, 45);
        txtDireccion.TabIndex = 11;
        // 
        // pnlAcciones
        // 
        pnlAcciones.BackColor = SystemColors.Control;
        pnlAcciones.Controls.Add(btnNuevo);
        pnlAcciones.Controls.Add(btnGuardar);
        pnlAcciones.Controls.Add(btnCancelar);
        pnlAcciones.Dock = DockStyle.Top;
        pnlAcciones.Location = new Point(0, 224);
        pnlAcciones.Name = "pnlAcciones";
        pnlAcciones.Size = new Size(960, 38);
        pnlAcciones.TabIndex = 3;
        // 
        // btnNuevo
        // 
        btnNuevo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnNuevo.BackColor = Color.FromArgb(224, 247, 250);
        btnNuevo.FlatStyle = FlatStyle.Standard;
        btnNuevo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnNuevo.ForeColor = Color.Black;
        btnNuevo.Location = new Point(625, 5);
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
        btnGuardar.Location = new Point(736, 5);
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
        btnCancelar.Location = new Point(847, 5);
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
        pnlListaContainer.Location = new Point(0, 262);
        pnlListaContainer.Name = "pnlListaContainer";
        pnlListaContainer.Padding = new Padding(8, 2, 8, 8);
        pnlListaContainer.Size = new Size(960, 338);
        pnlListaContainer.TabIndex = 4;
        // 
        // grpLista
        // 
        grpLista.BackColor = SystemColors.Control;
        grpLista.Controls.Add(dgvProveedores);
        grpLista.Dock = DockStyle.Fill;
        grpLista.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        grpLista.ForeColor = Color.Black;
        grpLista.Location = new Point(8, 2);
        grpLista.Name = "grpLista";
        grpLista.Padding = new Padding(8);
        grpLista.Size = new Size(944, 328);
        grpLista.TabIndex = 0;
        grpLista.TabStop = false;
        grpLista.Text = "Lista de Proveedores";
        // 
        // dgvProveedores
        // 
        dgvProveedores.AllowUserToAddRows = false;
        dgvProveedores.AllowUserToDeleteRows = false;
        dgvProveedores.AllowUserToResizeRows = false;
        dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvProveedores.BackgroundColor = Color.White;
        dgvProveedores.BorderStyle = BorderStyle.FixedSingle;
        dgvHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dgvHeaderStyle.BackColor = SystemColors.Control;
        dgvHeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        dgvHeaderStyle.ForeColor = Color.Black;
        dgvHeaderStyle.SelectionBackColor = SystemColors.Highlight;
        dgvHeaderStyle.SelectionForeColor = SystemColors.HighlightText;
        dgvHeaderStyle.WrapMode = DataGridViewTriState.True;
        dgvProveedores.ColumnHeadersDefaultCellStyle = dgvHeaderStyle;
        dgvProveedores.ColumnHeadersHeight = 26;
        dgvCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dgvCellStyle.BackColor = SystemColors.Window;
        dgvCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        dgvCellStyle.ForeColor = Color.Black;
        dgvCellStyle.SelectionBackColor = SystemColors.Highlight;
        dgvCellStyle.SelectionForeColor = SystemColors.HighlightText;
        dgvCellStyle.WrapMode = DataGridViewTriState.False;
        dgvProveedores.DefaultCellStyle = dgvCellStyle;
        dgvProveedores.Dock = DockStyle.Fill;
        dgvProveedores.EnableHeadersVisualStyles = true;
        dgvProveedores.Location = new Point(8, 22);
        dgvProveedores.MultiSelect = false;
        dgvProveedores.Name = "dgvProveedores";
        dgvProveedores.ReadOnly = true;
        dgvProveedores.RowHeadersVisible = true;
        dgvProveedores.RowHeadersWidth = 25;
        dgvProveedores.RowTemplate.Height = 24;
        dgvProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvProveedores.Size = new Size(928, 298);
        dgvProveedores.TabIndex = 0;
        dgvProveedores.SelectionChanged += DgvProveedores_SelectionChanged;
        // 
        // FrmProveedores
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        ClientSize = new Size(960, 600);
        Controls.Add(pnlListaContainer);
        Controls.Add(pnlAcciones);
        Controls.Add(pnlDatosContainer);
        Controls.Add(pnlFiltro);
        Controls.Add(pnlTop);
        Name = "FrmProveedores";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Gestión de Proveedores";
        Load += FrmProveedores_Load;
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
        ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
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
    private Label lblRNC;
    private TextBox txtRNC;
    private Label lblNombre;
    private TextBox txtNombre;
    private Label lblTelefono;
    private TextBox txtTelefono;
    private Label lblCorreo;
    private TextBox txtCorreo;
    private Label lblContacto;
    private TextBox txtContacto;
    private Label lblDireccion;
    private TextBox txtDireccion;
    private Panel pnlAcciones;
    private Button btnNuevo;
    private Button btnGuardar;
    private Button btnCancelar;
    private Panel pnlListaContainer;
    private GroupBox grpLista;
    private DataGridView dgvProveedores;
}
