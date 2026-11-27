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
        pnlAcciones = new Panel();
        btnNuevo = new Button();
        btnGuardar = new Button();
        btnCancelar = new Button();
        pnlListaContainer = new Panel();
        grpLista = new GroupBox();
        dgvUbicaciones = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
        pnlTop.SuspendLayout();
        pnlFiltro.SuspendLayout();
        pnlDatosContainer.SuspendLayout();
        grpDatos.SuspendLayout();
        pnlAcciones.SuspendLayout();
        pnlListaContainer.SuspendLayout();
        grpLista.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvUbicaciones).BeginInit();
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
        pnlTop.Size = new Size(940, 32);
        pnlTop.TabIndex = 0;
        // 
        // lblTitulo
        // 
        lblTitulo.Dock = DockStyle.Fill;
        lblTitulo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.Black;
        lblTitulo.Location = new Point(0, 0);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(940, 32);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "REGISTRO DE UBICACIONES";
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
        pnlFiltro.Size = new Size(940, 36);
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
        txtBuscar.Size = new Size(888, 23);
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
        btnBuscar.Location = new Point(902, 6);
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
        pnlDatosContainer.Size = new Size(940, 154);
        pnlDatosContainer.TabIndex = 2;
        // 
        // grpDatos
        // 
        grpDatos.BackColor = SystemColors.Control;
        grpDatos.Controls.Add(lblEdificio);
        grpDatos.Controls.Add(cmbEdificio);
        grpDatos.Controls.Add(lblNombre);
        grpDatos.Controls.Add(txtNombre);
        grpDatos.Controls.Add(lblPiso);
        grpDatos.Controls.Add(txtPiso);
        grpDatos.Controls.Add(lblDimension);
        grpDatos.Controls.Add(txtDimension);
        grpDatos.Controls.Add(lblDescripcion);
        grpDatos.Controls.Add(txtDescripcion);
        grpDatos.Dock = DockStyle.Fill;
        grpDatos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        grpDatos.ForeColor = Color.Black;
        grpDatos.Location = new Point(8, 2);
        grpDatos.Name = "grpDatos";
        grpDatos.Size = new Size(924, 150);
        grpDatos.TabIndex = 0;
        grpDatos.TabStop = false;
        grpDatos.Text = "Datos de la Ubicación";
        // 
        // lblEdificio
        // 
        lblEdificio.AutoSize = true;
        lblEdificio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblEdificio.ForeColor = Color.Black;
        lblEdificio.Location = new Point(12, 26);
        lblEdificio.Name = "lblEdificio";
        lblEdificio.Size = new Size(52, 15);
        lblEdificio.TabIndex = 0;
        lblEdificio.Text = "Edificio:";
        // 
        // cmbEdificio
        // 
        cmbEdificio.BackColor = SystemColors.Window;
        cmbEdificio.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbEdificio.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        cmbEdificio.FormattingEnabled = true;
        cmbEdificio.Location = new Point(98, 23);
        cmbEdificio.Name = "cmbEdificio";
        cmbEdificio.Size = new Size(270, 23);
        cmbEdificio.TabIndex = 1;
        // 
        // lblNombre
        // 
        lblNombre.AutoSize = true;
        lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblNombre.ForeColor = Color.Black;
        lblNombre.Location = new Point(386, 26);
        lblNombre.Name = "lblNombre";
        lblNombre.Size = new Size(57, 15);
        lblNombre.TabIndex = 2;
        lblNombre.Text = "Nombre:";
        // 
        // txtNombre
        // 
        txtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtNombre.BackColor = SystemColors.Window;
        txtNombre.BorderStyle = BorderStyle.FixedSingle;
        txtNombre.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        txtNombre.Location = new Point(450, 23);
        txtNombre.Name = "txtNombre";
        txtNombre.Size = new Size(460, 23);
        txtNombre.TabIndex = 3;
        txtNombre.TextChanged += txtNombre_TextChanged;
        // 
        // lblPiso
        // 
        lblPiso.AutoSize = true;
        lblPiso.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblPiso.ForeColor = Color.Black;
        lblPiso.Location = new Point(12, 58);
        lblPiso.Name = "lblPiso";
        lblPiso.Size = new Size(34, 15);
        lblPiso.TabIndex = 4;
        lblPiso.Text = "Piso:";
        // 
        // txtPiso
        // 
        txtPiso.BackColor = SystemColors.Window;
        txtPiso.BorderStyle = BorderStyle.FixedSingle;
        txtPiso.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        txtPiso.Location = new Point(98, 55);
        txtPiso.Name = "txtPiso";
        txtPiso.Size = new Size(140, 23);
        txtPiso.TabIndex = 5;
        // 
        // lblDimension
        // 
        lblDimension.AutoSize = true;
        lblDimension.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblDimension.ForeColor = Color.Black;
        lblDimension.Location = new Point(260, 58);
        lblDimension.Name = "lblDimension";
        lblDimension.Size = new Size(71, 15);
        lblDimension.TabIndex = 6;
        lblDimension.Text = "Dimensión:";
        // 
        // txtDimension
        // 
        txtDimension.BackColor = SystemColors.Window;
        txtDimension.BorderStyle = BorderStyle.FixedSingle;
        txtDimension.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        txtDimension.Location = new Point(338, 55);
        txtDimension.Name = "txtDimension";
        txtDimension.PlaceholderText = "6x8 m";
        txtDimension.Size = new Size(180, 23);
        txtDimension.TabIndex = 7;
        // 
        // lblDescripcion
        // 
        lblDescripcion.AutoSize = true;
        lblDescripcion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblDescripcion.ForeColor = Color.Black;
        lblDescripcion.Location = new Point(12, 92);
        lblDescripcion.Name = "lblDescripcion";
        lblDescripcion.Size = new Size(76, 15);
        lblDescripcion.TabIndex = 8;
        lblDescripcion.Text = "Descripción:";
        // 
        // txtDescripcion
        // 
        txtDescripcion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtDescripcion.BackColor = SystemColors.Window;
        txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
        txtDescripcion.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        txtDescripcion.Location = new Point(98, 90);
        txtDescripcion.Multiline = true;
        txtDescripcion.Name = "txtDescripcion";
        txtDescripcion.Size = new Size(812, 45);
        txtDescripcion.TabIndex = 9;
        // 
        // pnlAcciones
        // 
        pnlAcciones.BackColor = SystemColors.Control;
        pnlAcciones.Controls.Add(btnNuevo);
        pnlAcciones.Controls.Add(btnGuardar);
        pnlAcciones.Controls.Add(btnCancelar);
        pnlAcciones.Dock = DockStyle.Top;
        pnlAcciones.Location = new Point(0, 222);
        pnlAcciones.Name = "pnlAcciones";
        pnlAcciones.Size = new Size(940, 38);
        pnlAcciones.TabIndex = 3;
        // 
        // btnNuevo
        // 
        btnNuevo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnNuevo.BackColor = Color.FromArgb(224, 247, 250);
        btnNuevo.FlatStyle = FlatStyle.Standard;
        btnNuevo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnNuevo.ForeColor = Color.Black;
        btnNuevo.Location = new Point(605, 5);
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
        btnGuardar.Location = new Point(716, 5);
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
        btnCancelar.Location = new Point(827, 5);
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
        pnlListaContainer.Location = new Point(0, 260);
        pnlListaContainer.Name = "pnlListaContainer";
        pnlListaContainer.Padding = new Padding(8, 2, 8, 8);
        pnlListaContainer.Size = new Size(940, 320);
        pnlListaContainer.TabIndex = 4;
        // 
        // grpLista
        // 
        grpLista.BackColor = SystemColors.Control;
        grpLista.Controls.Add(dgvUbicaciones);
        grpLista.Dock = DockStyle.Fill;
        grpLista.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        grpLista.ForeColor = Color.Black;
        grpLista.Location = new Point(8, 2);
        grpLista.Name = "grpLista";
        grpLista.Padding = new Padding(8);
        grpLista.Size = new Size(924, 310);
        grpLista.TabIndex = 0;
        grpLista.TabStop = false;
        grpLista.Text = "Lista de Ubicaciones";
        // 
        // dgvUbicaciones
        // 
        dgvUbicaciones.AllowUserToAddRows = false;
        dgvUbicaciones.AllowUserToDeleteRows = false;
        dgvUbicaciones.AllowUserToResizeRows = false;
        dgvUbicaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvUbicaciones.BackgroundColor = Color.White;
        dgvUbicaciones.BorderStyle = BorderStyle.FixedSingle;
        dgvHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dgvHeaderStyle.BackColor = SystemColors.Control;
        dgvHeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        dgvHeaderStyle.ForeColor = Color.Black;
        dgvHeaderStyle.SelectionBackColor = SystemColors.Highlight;
        dgvHeaderStyle.SelectionForeColor = SystemColors.HighlightText;
        dgvHeaderStyle.WrapMode = DataGridViewTriState.True;
        dgvUbicaciones.ColumnHeadersDefaultCellStyle = dgvHeaderStyle;
        dgvUbicaciones.ColumnHeadersHeight = 26;
        dgvCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dgvCellStyle.BackColor = SystemColors.Window;
        dgvCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        dgvCellStyle.ForeColor = Color.Black;
        dgvCellStyle.SelectionBackColor = SystemColors.Highlight;
        dgvCellStyle.SelectionForeColor = SystemColors.HighlightText;
        dgvCellStyle.WrapMode = DataGridViewTriState.False;
        dgvUbicaciones.DefaultCellStyle = dgvCellStyle;
        dgvUbicaciones.Dock = DockStyle.Fill;
        dgvUbicaciones.EnableHeadersVisualStyles = true;
        dgvUbicaciones.Location = new Point(8, 22);
        dgvUbicaciones.MultiSelect = false;
        dgvUbicaciones.Name = "dgvUbicaciones";
        dgvUbicaciones.ReadOnly = true;
        dgvUbicaciones.RowHeadersVisible = true;
        dgvUbicaciones.RowHeadersWidth = 25;
        dgvUbicaciones.RowTemplate.Height = 24;
        dgvUbicaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvUbicaciones.Size = new Size(908, 280);
        dgvUbicaciones.TabIndex = 0;
        dgvUbicaciones.SelectionChanged += DgvUbicaciones_SelectionChanged;
        // 
        // FrmUbicaciones
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        ClientSize = new Size(940, 580);
        Controls.Add(pnlListaContainer);
        Controls.Add(pnlAcciones);
        Controls.Add(pnlDatosContainer);
        Controls.Add(pnlFiltro);
        Controls.Add(pnlTop);
        Name = "FrmUbicaciones";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Gestión de Ubicaciones";
        Load += FrmUbicaciones_Load;
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
        ((System.ComponentModel.ISupportInitialize)dgvUbicaciones).EndInit();
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
    private Panel pnlAcciones;
    private Button btnNuevo;
    private Button btnGuardar;
    private Button btnCancelar;
    private Panel pnlListaContainer;
    private GroupBox grpLista;
    private DataGridView dgvUbicaciones;
}
