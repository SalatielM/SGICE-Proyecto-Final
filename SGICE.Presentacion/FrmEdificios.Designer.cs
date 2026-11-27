namespace SGICE.Presentacion;

partial class FrmEdificios
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
        lblPisos = new Label();
        txtPisos = new TextBox();
        lblDescripcion = new Label();
        txtDescripcion = new TextBox();
        pnlAcciones = new Panel();
        btnNuevo = new Button();
        btnGuardar = new Button();
        btnCancelar = new Button();
        pnlListaContainer = new Panel();
        grpLista = new GroupBox();
        dgvEdificios = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
        pnlTop.SuspendLayout();
        pnlFiltro.SuspendLayout();
        pnlDatosContainer.SuspendLayout();
        grpDatos.SuspendLayout();
        pnlAcciones.SuspendLayout();
        pnlListaContainer.SuspendLayout();
        grpLista.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvEdificios).BeginInit();
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
        pnlTop.Size = new Size(900, 32);
        pnlTop.TabIndex = 0;
        // 
        // lblTitulo
        // 
        lblTitulo.Dock = DockStyle.Fill;
        lblTitulo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.Black;
        lblTitulo.Location = new Point(0, 0);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(900, 32);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "REGISTRO DE EDIFICIOS";
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
        pnlFiltro.Size = new Size(900, 36);
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
        txtBuscar.Size = new Size(848, 23);
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
        btnBuscar.Location = new Point(862, 6);
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
        pnlDatosContainer.Size = new Size(900, 128);
        pnlDatosContainer.TabIndex = 2;
        // 
        // grpDatos
        // 
        grpDatos.BackColor = SystemColors.Control;
        grpDatos.Controls.Add(lblCodigo);
        grpDatos.Controls.Add(txtCodigo);
        grpDatos.Controls.Add(lblNombre);
        grpDatos.Controls.Add(txtNombre);
        grpDatos.Controls.Add(lblPisos);
        grpDatos.Controls.Add(txtPisos);
        grpDatos.Controls.Add(lblDescripcion);
        grpDatos.Controls.Add(txtDescripcion);
        grpDatos.Dock = DockStyle.Fill;
        grpDatos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        grpDatos.ForeColor = Color.Black;
        grpDatos.Location = new Point(8, 2);
        grpDatos.Name = "grpDatos";
        grpDatos.Size = new Size(884, 124);
        grpDatos.TabIndex = 0;
        grpDatos.TabStop = false;
        grpDatos.Text = "Datos del Edificio";
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
        txtCodigo.Location = new Point(98, 23);
        txtCodigo.Name = "txtCodigo";
        txtCodigo.PlaceholderText = "EDIF-01";
        txtCodigo.Size = new Size(150, 23);
        txtCodigo.TabIndex = 1;
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
        // 
        // txtNombre
        // 
        txtNombre.BackColor = SystemColors.Window;
        txtNombre.BorderStyle = BorderStyle.FixedSingle;
        txtNombre.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        txtNombre.Location = new Point(331, 23);
        txtNombre.Name = "txtNombre";
        txtNombre.Size = new Size(320, 23);
        txtNombre.TabIndex = 3;
        // 
        // lblPisos
        // 
        lblPisos.AutoSize = true;
        lblPisos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblPisos.ForeColor = Color.Black;
        lblPisos.Location = new Point(668, 26);
        lblPisos.Name = "lblPisos";
        lblPisos.Size = new Size(40, 15);
        lblPisos.TabIndex = 4;
        lblPisos.Text = "Pisos:";
        // 
        // txtPisos
        // 
        txtPisos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtPisos.BackColor = SystemColors.Window;
        txtPisos.BorderStyle = BorderStyle.FixedSingle;
        txtPisos.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        txtPisos.Location = new Point(714, 23);
        txtPisos.Name = "txtPisos";
        txtPisos.Size = new Size(156, 23);
        txtPisos.TabIndex = 5;
        // 
        // lblDescripcion
        // 
        lblDescripcion.AutoSize = true;
        lblDescripcion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblDescripcion.ForeColor = Color.Black;
        lblDescripcion.Location = new Point(12, 62);
        lblDescripcion.Name = "lblDescripcion";
        lblDescripcion.Size = new Size(76, 15);
        lblDescripcion.TabIndex = 6;
        lblDescripcion.Text = "Descripción:";
        // 
        // txtDescripcion
        // 
        txtDescripcion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtDescripcion.BackColor = SystemColors.Window;
        txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
        txtDescripcion.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        txtDescripcion.Location = new Point(98, 60);
        txtDescripcion.Multiline = true;
        txtDescripcion.Name = "txtDescripcion";
        txtDescripcion.Size = new Size(772, 45);
        txtDescripcion.TabIndex = 7;
        // 
        // pnlAcciones
        // 
        pnlAcciones.BackColor = SystemColors.Control;
        pnlAcciones.Controls.Add(btnNuevo);
        pnlAcciones.Controls.Add(btnGuardar);
        pnlAcciones.Controls.Add(btnCancelar);
        pnlAcciones.Dock = DockStyle.Top;
        pnlAcciones.Location = new Point(0, 196);
        pnlAcciones.Name = "pnlAcciones";
        pnlAcciones.Size = new Size(900, 38);
        pnlAcciones.TabIndex = 3;
        // 
        // btnNuevo
        // 
        btnNuevo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnNuevo.BackColor = Color.FromArgb(224, 247, 250);
        btnNuevo.FlatStyle = FlatStyle.Standard;
        btnNuevo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnNuevo.ForeColor = Color.Black;
        btnNuevo.Location = new Point(565, 5);
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
        btnGuardar.Location = new Point(676, 5);
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
        btnCancelar.Location = new Point(787, 5);
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
        pnlListaContainer.Location = new Point(0, 234);
        pnlListaContainer.Name = "pnlListaContainer";
        pnlListaContainer.Padding = new Padding(8, 2, 8, 8);
        pnlListaContainer.Size = new Size(900, 346);
        pnlListaContainer.TabIndex = 4;
        // 
        // grpLista
        // 
        grpLista.BackColor = SystemColors.Control;
        grpLista.Controls.Add(dgvEdificios);
        grpLista.Dock = DockStyle.Fill;
        grpLista.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        grpLista.ForeColor = Color.Black;
        grpLista.Location = new Point(8, 2);
        grpLista.Name = "grpLista";
        grpLista.Padding = new Padding(8);
        grpLista.Size = new Size(884, 336);
        grpLista.TabIndex = 0;
        grpLista.TabStop = false;
        grpLista.Text = "Lista de Edificios";
        // 
        // dgvEdificios
        // 
        dgvEdificios.AllowUserToAddRows = false;
        dgvEdificios.AllowUserToDeleteRows = false;
        dgvEdificios.AllowUserToResizeRows = false;
        dgvEdificios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvEdificios.BackgroundColor = Color.White;
        dgvEdificios.BorderStyle = BorderStyle.FixedSingle;
        dgvHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dgvHeaderStyle.BackColor = SystemColors.Control;
        dgvHeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        dgvHeaderStyle.ForeColor = Color.Black;
        dgvHeaderStyle.SelectionBackColor = SystemColors.Highlight;
        dgvHeaderStyle.SelectionForeColor = SystemColors.HighlightText;
        dgvHeaderStyle.WrapMode = DataGridViewTriState.True;
        dgvEdificios.ColumnHeadersDefaultCellStyle = dgvHeaderStyle;
        dgvEdificios.ColumnHeadersHeight = 26;
        dgvCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dgvCellStyle.BackColor = SystemColors.Window;
        dgvCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        dgvCellStyle.ForeColor = Color.Black;
        dgvCellStyle.SelectionBackColor = SystemColors.Highlight;
        dgvCellStyle.SelectionForeColor = SystemColors.HighlightText;
        dgvCellStyle.WrapMode = DataGridViewTriState.False;
        dgvEdificios.DefaultCellStyle = dgvCellStyle;
        dgvEdificios.Dock = DockStyle.Fill;
        dgvEdificios.EnableHeadersVisualStyles = true;
        dgvEdificios.Location = new Point(8, 22);
        dgvEdificios.MultiSelect = false;
        dgvEdificios.Name = "dgvEdificios";
        dgvEdificios.ReadOnly = true;
        dgvEdificios.RowHeadersVisible = true;
        dgvEdificios.RowHeadersWidth = 25;
        dgvEdificios.RowTemplate.Height = 24;
        dgvEdificios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvEdificios.Size = new Size(868, 306);
        dgvEdificios.TabIndex = 0;
        dgvEdificios.SelectionChanged += DgvEdificios_SelectionChanged;
        // 
        // FrmEdificios
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        ClientSize = new Size(900, 580);
        Controls.Add(pnlListaContainer);
        Controls.Add(pnlAcciones);
        Controls.Add(pnlDatosContainer);
        Controls.Add(pnlFiltro);
        Controls.Add(pnlTop);
        Name = "FrmEdificios";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Gestión de Edificios";
        Load += FrmEdificios_Load;
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
        ((System.ComponentModel.ISupportInitialize)dgvEdificios).EndInit();
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
    private Label lblPisos;
    private TextBox txtPisos;
    private Label lblDescripcion;
    private TextBox txtDescripcion;
    private Panel pnlAcciones;
    private Button btnNuevo;
    private Button btnGuardar;
    private Button btnCancelar;
    private Panel pnlListaContainer;
    private GroupBox grpLista;
    private DataGridView dgvEdificios;
}
