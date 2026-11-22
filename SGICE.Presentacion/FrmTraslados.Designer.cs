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
        errorProvider = new ErrorProvider(components);
        pnlTop = new Panel();
        lblTitulo = new Label();
        pnlCabecera = new Panel();
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
        pnlActivo = new Panel();
        lblActivo = new Label();
        cmbActivosDisponibles = new ComboBox();
        btnAgregar = new Button();
        btnQuitar = new Button();
        pnlAcciones = new Panel();
        btnProcesar = new Button();
        btnLimpiar = new Button();
        lblTotalItems = new Label();
        dgvDetalle = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
        pnlTop.SuspendLayout();
        pnlCabecera.SuspendLayout();
        pnlActivo.SuspendLayout();
        pnlAcciones.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
        SuspendLayout();
        // 
        // errorProvider
        // 
        errorProvider.ContainerControl = this;
        // 
        // pnlTop
        // 
        pnlTop.BackColor = Color.FromArgb(30, 41, 59);
        pnlTop.Controls.Add(lblTitulo);
        pnlTop.Dock = DockStyle.Top;
        pnlTop.Location = new Point(0, 0);
        pnlTop.Name = "pnlTop";
        pnlTop.Size = new Size(1060, 50);
        pnlTop.TabIndex = 0;
        // 
        // lblTitulo
        // 
        lblTitulo.AutoSize = true;
        lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.White;
        lblTitulo.Location = new Point(16, 12);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(412, 25);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "Traslado Transaccional entre Ubicaciones";
        // 
        // pnlCabecera
        // 
        pnlCabecera.BackColor = Color.FromArgb(248, 250, 252);
        pnlCabecera.Controls.Add(lblOrigen);
        pnlCabecera.Controls.Add(cmbOrigen);
        pnlCabecera.Controls.Add(lblDestino);
        pnlCabecera.Controls.Add(cmbDestino);
        pnlCabecera.Controls.Add(lblTipoDoc);
        pnlCabecera.Controls.Add(cmbTipoDoc);
        pnlCabecera.Controls.Add(lblNoDoc);
        pnlCabecera.Controls.Add(txtNoDoc);
        pnlCabecera.Controls.Add(lblDirector);
        pnlCabecera.Controls.Add(cmbDirector);
        pnlCabecera.Controls.Add(lblRazon);
        pnlCabecera.Controls.Add(txtRazon);
        pnlCabecera.Dock = DockStyle.Top;
        pnlCabecera.Location = new Point(0, 50);
        pnlCabecera.Name = "pnlCabecera";
        pnlCabecera.Padding = new Padding(16, 10, 16, 10);
        pnlCabecera.Size = new Size(1060, 140);
        pnlCabecera.TabIndex = 1;
        // 
        // lblOrigen
        // 
        lblOrigen.AutoSize = true;
        lblOrigen.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblOrigen.ForeColor = Color.FromArgb(51, 65, 85);
        lblOrigen.Location = new Point(16, 12);
        lblOrigen.Name = "lblOrigen";
        lblOrigen.Size = new Size(122, 15);
        lblOrigen.TabIndex = 0;
        lblOrigen.Text = "Ubicación de Origen:";
        // 
        // cmbOrigen
        // 
        cmbOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbOrigen.Font = new Font("Segoe UI", 9.5F);
        cmbOrigen.FormattingEnabled = true;
        cmbOrigen.Location = new Point(16, 30);
        cmbOrigen.Name = "cmbOrigen";
        cmbOrigen.Size = new Size(310, 24);
        cmbOrigen.TabIndex = 1;
        cmbOrigen.SelectedIndexChanged += CmbOrigen_SelectedIndexChanged;
        // 
        // lblDestino
        // 
        lblDestino.AutoSize = true;
        lblDestino.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblDestino.ForeColor = Color.FromArgb(51, 65, 85);
        lblDestino.Location = new Point(350, 12);
        lblDestino.Name = "lblDestino";
        lblDestino.Size = new Size(127, 15);
        lblDestino.TabIndex = 2;
        lblDestino.Text = "Ubicación de Destino:";
        // 
        // cmbDestino
        // 
        cmbDestino.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbDestino.Font = new Font("Segoe UI", 9.5F);
        cmbDestino.FormattingEnabled = true;
        cmbDestino.Location = new Point(350, 30);
        cmbDestino.Name = "cmbDestino";
        cmbDestino.Size = new Size(310, 24);
        cmbDestino.TabIndex = 3;
        // 
        // lblTipoDoc
        // 
        lblTipoDoc.AutoSize = true;
        lblTipoDoc.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblTipoDoc.ForeColor = Color.FromArgb(51, 65, 85);
        lblTipoDoc.Location = new Point(680, 12);
        lblTipoDoc.Name = "lblTipoDoc";
        lblTipoDoc.Size = new Size(116, 15);
        lblTipoDoc.TabIndex = 4;
        lblTipoDoc.Text = "Tipo Documento:";
        // 
        // cmbTipoDoc
        // 
        cmbTipoDoc.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbTipoDoc.Font = new Font("Segoe UI", 9.5F);
        cmbTipoDoc.FormattingEnabled = true;
        cmbTipoDoc.Location = new Point(680, 30);
        cmbTipoDoc.Name = "cmbTipoDoc";
        cmbTipoDoc.Size = new Size(170, 24);
        cmbTipoDoc.TabIndex = 5;
        // 
        // lblNoDoc
        // 
        lblNoDoc.AutoSize = true;
        lblNoDoc.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblNoDoc.ForeColor = Color.FromArgb(51, 65, 85);
        lblNoDoc.Location = new Point(870, 12);
        lblNoDoc.Name = "lblNoDoc";
        lblNoDoc.Size = new Size(99, 15);
        lblNoDoc.TabIndex = 6;
        lblNoDoc.Text = "No. Documento:";
        // 
        // txtNoDoc
        // 
        txtNoDoc.Font = new Font("Segoe UI", 9.5F);
        txtNoDoc.Location = new Point(870, 30);
        txtNoDoc.Name = "txtNoDoc";
        txtNoDoc.PlaceholderText = "MEMO-2026-01";
        txtNoDoc.Size = new Size(170, 24);
        txtNoDoc.TabIndex = 7;
        // 
        // lblDirector
        // 
        lblDirector.AutoSize = true;
        lblDirector.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblDirector.ForeColor = Color.FromArgb(51, 65, 85);
        lblDirector.Location = new Point(16, 70);
        lblDirector.Name = "lblDirector";
        lblDirector.Size = new Size(94, 15);
        lblDirector.TabIndex = 8;
        lblDirector.Text = "Autorizado Por:";
        // 
        // cmbDirector
        // 
        cmbDirector.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbDirector.Font = new Font("Segoe UI", 9.5F);
        cmbDirector.FormattingEnabled = true;
        cmbDirector.Location = new Point(16, 88);
        cmbDirector.Name = "cmbDirector";
        cmbDirector.Size = new Size(310, 24);
        cmbDirector.TabIndex = 9;
        // 
        // lblRazon
        // 
        lblRazon.AutoSize = true;
        lblRazon.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblRazon.ForeColor = Color.FromArgb(51, 65, 85);
        lblRazon.Location = new Point(350, 70);
        lblRazon.Name = "lblRazon";
        lblRazon.Size = new Size(116, 15);
        lblRazon.TabIndex = 10;
        lblRazon.Text = "Razón del Traslado:";
        // 
        // txtRazon
        // 
        txtRazon.Font = new Font("Segoe UI", 9.5F);
        txtRazon.Location = new Point(350, 88);
        txtRazon.Name = "txtRazon";
        txtRazon.PlaceholderText = "Reasignación de equipamiento para nuevo período lectivo...";
        txtRazon.Size = new Size(690, 24);
        txtRazon.TabIndex = 11;
        // 
        // pnlActivo
        // 
        pnlActivo.BackColor = Color.White;
        pnlActivo.Controls.Add(lblActivo);
        pnlActivo.Controls.Add(cmbActivosDisponibles);
        pnlActivo.Controls.Add(btnAgregar);
        pnlActivo.Controls.Add(btnQuitar);
        pnlActivo.Dock = DockStyle.Top;
        pnlActivo.Location = new Point(0, 190);
        pnlActivo.Name = "pnlActivo";
        pnlActivo.Padding = new Padding(16, 10, 16, 10);
        pnlActivo.Size = new Size(1060, 56);
        pnlActivo.TabIndex = 2;
        // 
        // lblActivo
        // 
        lblActivo.AutoSize = true;
        lblActivo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblActivo.ForeColor = Color.FromArgb(51, 65, 85);
        lblActivo.Location = new Point(16, 18);
        lblActivo.Name = "lblActivo";
        lblActivo.Size = new Size(157, 15);
        lblActivo.TabIndex = 0;
        lblActivo.Text = "Activo Físico a Trasladar:";
        // 
        // cmbActivosDisponibles
        // 
        cmbActivosDisponibles.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbActivosDisponibles.Font = new Font("Segoe UI", 9.5F);
        cmbActivosDisponibles.FormattingEnabled = true;
        cmbActivosDisponibles.Location = new Point(180, 14);
        cmbActivosDisponibles.Name = "cmbActivosDisponibles";
        cmbActivosDisponibles.Size = new Size(580, 24);
        cmbActivosDisponibles.TabIndex = 1;
        // 
        // btnAgregar
        // 
        btnAgregar.Location = new Point(780, 11);
        btnAgregar.Name = "btnAgregar";
        btnAgregar.Size = new Size(125, 32);
        btnAgregar.TabIndex = 2;
        btnAgregar.Text = "Agregar Ítem";
        btnAgregar.UseVisualStyleBackColor = true;
        btnAgregar.Click += BtnAgregar_Click;
        // 
        // btnQuitar
        // 
        btnQuitar.Location = new Point(915, 11);
        btnQuitar.Name = "btnQuitar";
        btnQuitar.Size = new Size(125, 32);
        btnQuitar.TabIndex = 3;
        btnQuitar.Text = "Quitar Selección";
        btnQuitar.UseVisualStyleBackColor = true;
        btnQuitar.Click += BtnQuitar_Click;
        // 
        // pnlAcciones
        // 
        pnlAcciones.BackColor = Color.FromArgb(248, 250, 252);
        pnlAcciones.Controls.Add(btnProcesar);
        pnlAcciones.Controls.Add(btnLimpiar);
        pnlAcciones.Controls.Add(lblTotalItems);
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
        btnProcesar.Location = new Point(780, 12);
        btnProcesar.Name = "btnProcesar";
        btnProcesar.Size = new Size(260, 36);
        btnProcesar.TabIndex = 0;
        btnProcesar.Text = "Procesar Traslado Transaccional";
        btnProcesar.UseVisualStyleBackColor = true;
        btnProcesar.Click += BtnProcesar_Click;
        // 
        // btnLimpiar
        // 
        btnLimpiar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnLimpiar.Location = new Point(660, 12);
        btnLimpiar.Name = "btnLimpiar";
        btnLimpiar.Size = new Size(110, 36);
        btnLimpiar.TabIndex = 1;
        btnLimpiar.Text = "Cancelar";
        btnLimpiar.UseVisualStyleBackColor = true;
        btnLimpiar.Click += BtnLimpiar_Click;
        // 
        // lblTotalItems
        // 
        lblTotalItems.AutoSize = true;
        lblTotalItems.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        lblTotalItems.ForeColor = Color.FromArgb(30, 41, 59);
        lblTotalItems.Location = new Point(16, 20);
        lblTotalItems.Name = "lblTotalItems";
        lblTotalItems.Size = new Size(213, 19);
        lblTotalItems.TabIndex = 2;
        lblTotalItems.Text = "Activos seleccionados para traslado: 0";
        // 
        // dgvDetalle
        // 
        dgvDetalle.Dock = DockStyle.Fill;
        dgvDetalle.Location = new Point(0, 246);
        dgvDetalle.Name = "dgvDetalle";
        dgvDetalle.Size = new Size(1060, 314);
        dgvDetalle.TabIndex = 3;
        // 
        // FrmTraslados
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1060, 620);
        Controls.Add(dgvDetalle);
        Controls.Add(pnlAcciones);
        Controls.Add(pnlActivo);
        Controls.Add(pnlCabecera);
        Controls.Add(pnlTop);
        Name = "FrmTraslados";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Traslados de Activos entre Ubicaciones";
        Load += FrmTraslados_Load;
        ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
        pnlTop.ResumeLayout(false);
        pnlTop.PerformLayout();
        pnlCabecera.ResumeLayout(false);
        pnlCabecera.PerformLayout();
        pnlActivo.ResumeLayout(false);
        pnlActivo.PerformLayout();
        pnlAcciones.ResumeLayout(false);
        pnlAcciones.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private ErrorProvider errorProvider;
    private Panel pnlTop;
    private Label lblTitulo;
    private Panel pnlCabecera;
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
    private Panel pnlActivo;
    private Label lblActivo;
    private ComboBox cmbActivosDisponibles;
    private Button btnAgregar;
    private Button btnQuitar;
    private Panel pnlAcciones;
    private Button btnProcesar;
    private Button btnLimpiar;
    private Label lblTotalItems;
    private DataGridView dgvDetalle;
}
