namespace SGICE.Presentacion;

partial class FrmTraslados
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
        pnlCabeceraContainer = new Panel();
        grpCabecera = new GroupBox();
        lblOrigen = new Label();
        cmbOrigen = new ComboBox();
        lblDestino = new Label();
        cmbDestino = new ComboBox();
        lblTipoDoc = new Label();
        cmbTipoDoc = new ComboBox();
        lblNoDoc = new Label();
        txtNoDoc = new TextBox();
        lblDirector = new Label();
        cmbDirector = new ComboBox();
        lblRazon = new Label();
        txtRazon = new TextBox();
        pnlActivoContainer = new Panel();
        grpActivo = new GroupBox();
        lblActivo = new Label();
        cmbActivosDisponibles = new ComboBox();
        btnAgregar = new Button();
        pnlDetalleContainer = new Panel();
        grpDetalle = new GroupBox();
        dgvDetalle = new DataGridView();
        pnlDetalleFooter = new Panel();
        lblTotalItems = new Label();
        btnQuitar = new Button();
        pnlAcciones = new Panel();
        btnLimpiar = new Button();
        btnProcesar = new Button();
        ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
        pnlTop.SuspendLayout();
        pnlCabeceraContainer.SuspendLayout();
        grpCabecera.SuspendLayout();
        pnlActivoContainer.SuspendLayout();
        grpActivo.SuspendLayout();
        pnlDetalleContainer.SuspendLayout();
        grpDetalle.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
        pnlDetalleFooter.SuspendLayout();
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
        pnlTop.Size = new Size(1060, 32);
        pnlTop.TabIndex = 0;
        // 
        // lblTitulo
        // 
        lblTitulo.Dock = DockStyle.Fill;
        lblTitulo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.Black;
        lblTitulo.Location = new Point(0, 0);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(1060, 32);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "TRASLADO DE ACTIVOS ENTRE UBICACIONES";
        lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
        lblTitulo.Click += lblTitulo_Click;
        // 
        // pnlCabeceraContainer
        // 
        pnlCabeceraContainer.BackColor = SystemColors.Control;
        pnlCabeceraContainer.Controls.Add(grpCabecera);
        pnlCabeceraContainer.Dock = DockStyle.Top;
        pnlCabeceraContainer.Location = new Point(0, 32);
        pnlCabeceraContainer.Name = "pnlCabeceraContainer";
        pnlCabeceraContainer.Padding = new Padding(8, 6, 8, 2);
        pnlCabeceraContainer.Size = new Size(1060, 156);
        pnlCabeceraContainer.TabIndex = 1;
        // 
        // grpCabecera
        // 
        grpCabecera.BackColor = SystemColors.Control;
        grpCabecera.Controls.Add(lblOrigen);
        grpCabecera.Controls.Add(cmbOrigen);
        grpCabecera.Controls.Add(lblDestino);
        grpCabecera.Controls.Add(cmbDestino);
        grpCabecera.Controls.Add(lblTipoDoc);
        grpCabecera.Controls.Add(cmbTipoDoc);
        grpCabecera.Controls.Add(lblNoDoc);
        grpCabecera.Controls.Add(txtNoDoc);
        grpCabecera.Controls.Add(lblDirector);
        grpCabecera.Controls.Add(cmbDirector);
        grpCabecera.Controls.Add(lblRazon);
        grpCabecera.Controls.Add(txtRazon);
        grpCabecera.Dock = DockStyle.Fill;
        grpCabecera.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        grpCabecera.ForeColor = Color.Black;
        grpCabecera.Location = new Point(8, 6);
        grpCabecera.Name = "grpCabecera";
        grpCabecera.Size = new Size(1044, 148);
        grpCabecera.TabIndex = 0;
        grpCabecera.TabStop = false;
        grpCabecera.Text = "Datos Generales del Traslado";
        // 
        // lblOrigen
        // 
        lblOrigen.AutoSize = true;
        lblOrigen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblOrigen.ForeColor = Color.Black;
        lblOrigen.Location = new Point(12, 26);
        lblOrigen.Name = "lblOrigen";
        lblOrigen.Size = new Size(51, 15);
        lblOrigen.TabIndex = 0;
        lblOrigen.Text = "Origen:";
        // 
        // cmbOrigen
        // 
        cmbOrigen.BackColor = SystemColors.Window;
        cmbOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbOrigen.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        cmbOrigen.FormattingEnabled = true;
        cmbOrigen.Location = new Point(108, 23);
        cmbOrigen.Name = "cmbOrigen";
        cmbOrigen.Size = new Size(270, 23);
        cmbOrigen.TabIndex = 1;
        cmbOrigen.SelectedIndexChanged += CmbOrigen_SelectedIndexChanged;
        // 
        // lblDestino
        // 
        lblDestino.AutoSize = true;
        lblDestino.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblDestino.ForeColor = Color.Black;
        lblDestino.Location = new Point(392, 26);
        lblDestino.Name = "lblDestino";
        lblDestino.Size = new Size(56, 15);
        lblDestino.TabIndex = 2;
        lblDestino.Text = "Destino:";
        // 
        // cmbDestino
        // 
        cmbDestino.BackColor = SystemColors.Window;
        cmbDestino.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbDestino.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        cmbDestino.FormattingEnabled = true;
        cmbDestino.Location = new Point(454, 23);
        cmbDestino.Name = "cmbDestino";
        cmbDestino.Size = new Size(270, 23);
        cmbDestino.TabIndex = 3;
        // 
        // lblTipoDoc
        // 
        lblTipoDoc.AutoSize = true;
        lblTipoDoc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblTipoDoc.ForeColor = Color.Black;
        lblTipoDoc.Location = new Point(738, 26);
        lblTipoDoc.Name = "lblTipoDoc";
        lblTipoDoc.Size = new Size(63, 15);
        lblTipoDoc.TabIndex = 4;
        lblTipoDoc.Text = "Tipo Doc.:";
        // 
        // cmbTipoDoc
        // 
        cmbTipoDoc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        cmbTipoDoc.BackColor = SystemColors.Window;
        cmbTipoDoc.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbTipoDoc.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        cmbTipoDoc.FormattingEnabled = true;
        cmbTipoDoc.Location = new Point(807, 23);
        cmbTipoDoc.Name = "cmbTipoDoc";
        cmbTipoDoc.Size = new Size(223, 23);
        cmbTipoDoc.TabIndex = 5;
        // 
        // lblNoDoc
        // 
        lblNoDoc.AutoSize = true;
        lblNoDoc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblNoDoc.ForeColor = Color.Black;
        lblNoDoc.Location = new Point(12, 58);
        lblNoDoc.Name = "lblNoDoc";
        lblNoDoc.Size = new Size(57, 15);
        lblNoDoc.TabIndex = 6;
        lblNoDoc.Text = "No. Doc.:";
        // 
        // txtNoDoc
        // 
        txtNoDoc.BackColor = SystemColors.Window;
        txtNoDoc.BorderStyle = BorderStyle.FixedSingle;
        txtNoDoc.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        txtNoDoc.Location = new Point(108, 55);
        txtNoDoc.Name = "txtNoDoc";
        txtNoDoc.PlaceholderText = "MEMO-2026-01";
        txtNoDoc.Size = new Size(270, 23);
        txtNoDoc.TabIndex = 7;
        // 
        // lblDirector
        // 
        lblDirector.AutoSize = true;
        lblDirector.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblDirector.ForeColor = Color.Black;
        lblDirector.Location = new Point(392, 58);
        lblDirector.Name = "lblDirector";
        lblDirector.Size = new Size(94, 15);
        lblDirector.TabIndex = 8;
        lblDirector.Text = "Autorizado Por:";
        // 
        // cmbDirector
        // 
        cmbDirector.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        cmbDirector.BackColor = SystemColors.Window;
        cmbDirector.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbDirector.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        cmbDirector.FormattingEnabled = true;
        cmbDirector.Location = new Point(492, 55);
        cmbDirector.Name = "cmbDirector";
        cmbDirector.Size = new Size(538, 23);
        cmbDirector.TabIndex = 9;
        // 
        // lblRazon
        // 
        lblRazon.AutoSize = true;
        lblRazon.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblRazon.ForeColor = Color.Black;
        lblRazon.Location = new Point(12, 94);
        lblRazon.Name = "lblRazon";
        lblRazon.Size = new Size(85, 15);
        lblRazon.TabIndex = 10;
        lblRazon.Text = "Observación:";
        // 
        // txtRazon
        // 
        txtRazon.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtRazon.BackColor = SystemColors.Window;
        txtRazon.BorderStyle = BorderStyle.FixedSingle;
        txtRazon.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        txtRazon.Location = new Point(108, 90);
        txtRazon.Multiline = true;
        txtRazon.Name = "txtRazon";
        txtRazon.PlaceholderText = "Motivo o razón del traslado...";
        txtRazon.Size = new Size(922, 45);
        txtRazon.TabIndex = 11;
        // 
        // pnlActivoContainer
        // 
        pnlActivoContainer.BackColor = SystemColors.Control;
        pnlActivoContainer.Controls.Add(grpActivo);
        pnlActivoContainer.Dock = DockStyle.Top;
        pnlActivoContainer.Location = new Point(0, 188);
        pnlActivoContainer.Name = "pnlActivoContainer";
        pnlActivoContainer.Padding = new Padding(8, 2, 8, 2);
        pnlActivoContainer.Size = new Size(1060, 66);
        pnlActivoContainer.TabIndex = 2;
        // 
        // grpActivo
        // 
        grpActivo.BackColor = SystemColors.Control;
        grpActivo.Controls.Add(lblActivo);
        grpActivo.Controls.Add(cmbActivosDisponibles);
        grpActivo.Controls.Add(btnAgregar);
        grpActivo.Dock = DockStyle.Fill;
        grpActivo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        grpActivo.ForeColor = Color.Black;
        grpActivo.Location = new Point(8, 2);
        grpActivo.Name = "grpActivo";
        grpActivo.Size = new Size(1044, 62);
        grpActivo.TabIndex = 0;
        grpActivo.TabStop = false;
        grpActivo.Text = "Selección de Activo Físico";
        // 
        // lblActivo
        // 
        lblActivo.AutoSize = true;
        lblActivo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblActivo.ForeColor = Color.Black;
        lblActivo.Location = new Point(12, 26);
        lblActivo.Name = "lblActivo";
        lblActivo.Size = new Size(141, 15);
        lblActivo.TabIndex = 0;
        lblActivo.Text = "Activo Físico (QR / AF):";
        // 
        // cmbActivosDisponibles
        // 
        cmbActivosDisponibles.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        cmbActivosDisponibles.BackColor = SystemColors.Window;
        cmbActivosDisponibles.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbActivosDisponibles.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        cmbActivosDisponibles.FormattingEnabled = true;
        cmbActivosDisponibles.Location = new Point(160, 23);
        cmbActivosDisponibles.Name = "cmbActivosDisponibles";
        cmbActivosDisponibles.Size = new Size(748, 23);
        cmbActivosDisponibles.TabIndex = 1;
        // 
        // btnAgregar
        // 
        btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnAgregar.BackColor = Color.FromArgb(232, 245, 233);
        btnAgregar.FlatStyle = FlatStyle.Standard;
        btnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnAgregar.ForeColor = Color.Black;
        btnAgregar.Location = new Point(920, 20);
        btnAgregar.Name = "btnAgregar";
        btnAgregar.Size = new Size(110, 28);
        btnAgregar.TabIndex = 2;
        btnAgregar.Text = "Agregar";
        btnAgregar.UseVisualStyleBackColor = false;
        btnAgregar.Click += BtnAgregar_Click;
        // 
        // pnlDetalleContainer
        // 
        pnlDetalleContainer.BackColor = SystemColors.Control;
        pnlDetalleContainer.Controls.Add(grpDetalle);
        pnlDetalleContainer.Dock = DockStyle.Fill;
        pnlDetalleContainer.Location = new Point(0, 254);
        pnlDetalleContainer.Name = "pnlDetalleContainer";
        pnlDetalleContainer.Padding = new Padding(8, 2, 8, 2);
        pnlDetalleContainer.Size = new Size(1060, 324);
        pnlDetalleContainer.TabIndex = 3;
        // 
        // grpDetalle
        // 
        grpDetalle.BackColor = SystemColors.Control;
        grpDetalle.Controls.Add(dgvDetalle);
        grpDetalle.Controls.Add(pnlDetalleFooter);
        grpDetalle.Dock = DockStyle.Fill;
        grpDetalle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        grpDetalle.ForeColor = Color.Black;
        grpDetalle.Location = new Point(8, 2);
        grpDetalle.Name = "grpDetalle";
        grpDetalle.Padding = new Padding(8);
        grpDetalle.Size = new Size(1044, 320);
        grpDetalle.TabIndex = 0;
        grpDetalle.TabStop = false;
        grpDetalle.Text = "Detalle de Activos a Trasladar";
        // 
        // dgvDetalle
        // 
        dgvDetalle.AllowUserToAddRows = false;
        dgvDetalle.AllowUserToDeleteRows = false;
        dgvDetalle.AllowUserToResizeRows = false;
        dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvDetalle.BackgroundColor = Color.White;
        dgvDetalle.BorderStyle = BorderStyle.FixedSingle;
        dgvHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dgvHeaderStyle.BackColor = SystemColors.Control;
        dgvHeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        dgvHeaderStyle.ForeColor = Color.Black;
        dgvHeaderStyle.SelectionBackColor = SystemColors.Highlight;
        dgvHeaderStyle.SelectionForeColor = SystemColors.HighlightText;
        dgvHeaderStyle.WrapMode = DataGridViewTriState.True;
        dgvDetalle.ColumnHeadersDefaultCellStyle = dgvHeaderStyle;
        dgvDetalle.ColumnHeadersHeight = 26;
        dgvCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dgvCellStyle.BackColor = SystemColors.Window;
        dgvCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        dgvCellStyle.ForeColor = Color.Black;
        dgvCellStyle.SelectionBackColor = SystemColors.Highlight;
        dgvCellStyle.SelectionForeColor = SystemColors.HighlightText;
        dgvCellStyle.WrapMode = DataGridViewTriState.False;
        dgvDetalle.DefaultCellStyle = dgvCellStyle;
        dgvDetalle.Dock = DockStyle.Fill;
        dgvDetalle.EnableHeadersVisualStyles = true;
        dgvDetalle.Location = new Point(8, 22);
        dgvDetalle.MultiSelect = false;
        dgvDetalle.Name = "dgvDetalle";
        dgvDetalle.ReadOnly = true;
        dgvDetalle.RowHeadersVisible = true;
        dgvDetalle.RowHeadersWidth = 25;
        dgvDetalle.RowTemplate.Height = 24;
        dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvDetalle.Size = new Size(1028, 254);
        dgvDetalle.TabIndex = 0;
        dgvDetalle.CellContentClick += dgvDetalle_CellContentClick;
        // 
        // pnlDetalleFooter
        // 
        pnlDetalleFooter.BackColor = SystemColors.Control;
        pnlDetalleFooter.Controls.Add(lblTotalItems);
        pnlDetalleFooter.Controls.Add(btnQuitar);
        pnlDetalleFooter.Dock = DockStyle.Bottom;
        pnlDetalleFooter.Location = new Point(8, 276);
        pnlDetalleFooter.Name = "pnlDetalleFooter";
        pnlDetalleFooter.Size = new Size(1028, 36);
        pnlDetalleFooter.TabIndex = 1;
        // 
        // lblTotalItems
        // 
        lblTotalItems.AutoSize = true;
        lblTotalItems.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblTotalItems.ForeColor = Color.Black;
        lblTotalItems.Location = new Point(2, 10);
        lblTotalItems.Name = "lblTotalItems";
        lblTotalItems.Size = new Size(227, 15);
        lblTotalItems.TabIndex = 0;
        lblTotalItems.Text = "Activos seleccionados para traslado: 0";
        // 
        // btnQuitar
        // 
        btnQuitar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnQuitar.BackColor = Color.FromArgb(255, 235, 238);
        btnQuitar.FlatStyle = FlatStyle.Standard;
        btnQuitar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnQuitar.ForeColor = Color.Black;
        btnQuitar.Location = new Point(913, 5);
        btnQuitar.Name = "btnQuitar";
        btnQuitar.Size = new Size(115, 28);
        btnQuitar.TabIndex = 1;
        btnQuitar.Text = "Eliminar Fila";
        btnQuitar.UseVisualStyleBackColor = false;
        btnQuitar.Click += BtnQuitar_Click;
        // 
        // pnlAcciones
        // 
        pnlAcciones.BackColor = SystemColors.Control;
        pnlAcciones.Controls.Add(btnLimpiar);
        pnlAcciones.Controls.Add(btnProcesar);
        pnlAcciones.Dock = DockStyle.Bottom;
        pnlAcciones.Location = new Point(0, 578);
        pnlAcciones.Name = "pnlAcciones";
        pnlAcciones.Size = new Size(1060, 42);
        pnlAcciones.TabIndex = 4;
        // 
        // btnLimpiar
        // 
        btnLimpiar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnLimpiar.BackColor = Color.FromArgb(224, 247, 250);
        btnLimpiar.FlatStyle = FlatStyle.Standard;
        btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnLimpiar.ForeColor = Color.Black;
        btnLimpiar.Location = new Point(780, 7);
        btnLimpiar.Name = "btnLimpiar";
        btnLimpiar.Size = new Size(125, 28);
        btnLimpiar.TabIndex = 0;
        btnLimpiar.Text = "Limpiar Campos";
        btnLimpiar.UseVisualStyleBackColor = false;
        btnLimpiar.Click += BtnLimpiar_Click;
        // 
        // btnProcesar
        // 
        btnProcesar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnProcesar.BackColor = Color.FromArgb(232, 245, 233);
        btnProcesar.FlatStyle = FlatStyle.Standard;
        btnProcesar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnProcesar.ForeColor = Color.Black;
        btnProcesar.Location = new Point(912, 7);
        btnProcesar.Name = "btnProcesar";
        btnProcesar.Size = new Size(140, 28);
        btnProcesar.TabIndex = 1;
        btnProcesar.Text = "Guardar Traslado";
        btnProcesar.UseVisualStyleBackColor = false;
        btnProcesar.Click += BtnProcesar_Click;
        // 
        // FrmTraslados
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        ClientSize = new Size(1060, 620);
        Controls.Add(pnlDetalleContainer);
        Controls.Add(pnlAcciones);
        Controls.Add(pnlActivoContainer);
        Controls.Add(pnlCabeceraContainer);
        Controls.Add(pnlTop);
        Name = "FrmTraslados";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Traslados de Activos entre Ubicaciones";
        Load += FrmTraslados_Load;
        ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
        pnlTop.ResumeLayout(false);
        pnlCabeceraContainer.ResumeLayout(false);
        grpCabecera.ResumeLayout(false);
        grpCabecera.PerformLayout();
        pnlActivoContainer.ResumeLayout(false);
        grpActivo.ResumeLayout(false);
        grpActivo.PerformLayout();
        pnlDetalleContainer.ResumeLayout(false);
        grpDetalle.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
        pnlDetalleFooter.ResumeLayout(false);
        pnlDetalleFooter.PerformLayout();
        pnlAcciones.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private ErrorProvider errorProvider;
    private Panel pnlTop;
    private Label lblTitulo;
    private Panel pnlCabeceraContainer;
    private GroupBox grpCabecera;
    private Label lblOrigen;
    private ComboBox cmbOrigen;
    private Label lblDestino;
    private ComboBox cmbDestino;
    private Label lblTipoDoc;
    private ComboBox cmbTipoDoc;
    private Label lblNoDoc;
    private TextBox txtNoDoc;
    private Label lblDirector;
    private ComboBox cmbDirector;
    private Label lblRazon;
    private TextBox txtRazon;
    private Panel pnlActivoContainer;
    private GroupBox grpActivo;
    private Label lblActivo;
    private ComboBox cmbActivosDisponibles;
    private Button btnAgregar;
    private Panel pnlDetalleContainer;
    private GroupBox grpDetalle;
    private DataGridView dgvDetalle;
    private Panel pnlDetalleFooter;
    private Label lblTotalItems;
    private Button btnQuitar;
    private Panel pnlAcciones;
    private Button btnProcesar;
    private Button btnLimpiar;
}
