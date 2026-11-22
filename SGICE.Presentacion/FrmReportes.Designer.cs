namespace SGICE.Presentacion;

partial class FrmReportes
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
        pnlFiltros = new Panel();
        lblTipoReporte = new Label();
        cmbTipoReporte = new ComboBox();
        lblFechaDesde = new Label();
        dtpFechaDesde = new DateTimePicker();
        lblFechaHasta = new Label();
        dtpFechaHasta = new DateTimePicker();
        btnGenerar = new Button();
        btnExportar = new Button();
        pnlFooter = new Panel();
        lblTotalRegistros = new Label();
        dgvReporte = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
        pnlTop.SuspendLayout();
        pnlFiltros.SuspendLayout();
        pnlFooter.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
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
        pnlTop.Size = new Size(1100, 50);
        pnlTop.TabIndex = 0;
        // 
        // lblTitulo
        // 
        lblTitulo.AutoSize = true;
        lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.White;
        lblTitulo.Location = new Point(16, 12);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(420, 25);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "Módulo de Reportes y Bitácora de Auditoría";
        // 
        // pnlFiltros
        // 
        pnlFiltros.BackColor = Color.FromArgb(248, 250, 252);
        pnlFiltros.Controls.Add(lblTipoReporte);
        pnlFiltros.Controls.Add(cmbTipoReporte);
        pnlFiltros.Controls.Add(lblFechaDesde);
        pnlFiltros.Controls.Add(dtpFechaDesde);
        pnlFiltros.Controls.Add(lblFechaHasta);
        pnlFiltros.Controls.Add(dtpFechaHasta);
        pnlFiltros.Controls.Add(btnGenerar);
        pnlFiltros.Controls.Add(btnExportar);
        pnlFiltros.Dock = DockStyle.Top;
        pnlFiltros.Location = new Point(0, 50);
        pnlFiltros.Name = "pnlFiltros";
        pnlFiltros.Padding = new Padding(16, 10, 16, 10);
        pnlFiltros.Size = new Size(1100, 65);
        pnlFiltros.TabIndex = 1;
        // 
        // lblTipoReporte
        // 
        lblTipoReporte.AutoSize = true;
        lblTipoReporte.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblTipoReporte.ForeColor = Color.FromArgb(51, 65, 85);
        lblTipoReporte.Location = new Point(16, 12);
        lblTipoReporte.Name = "lblTipoReporte";
        lblTipoReporte.Size = new Size(93, 15);
        lblTipoReporte.TabIndex = 0;
        lblTipoReporte.Text = "Tipo de Reporte:";
        // 
        // cmbTipoReporte
        // 
        cmbTipoReporte.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbTipoReporte.Font = new Font("Segoe UI", 9.5F);
        cmbTipoReporte.FormattingEnabled = true;
        cmbTipoReporte.Location = new Point(16, 30);
        cmbTipoReporte.Name = "cmbTipoReporte";
        cmbTipoReporte.Size = new Size(240, 24);
        cmbTipoReporte.TabIndex = 1;
        // 
        // lblFechaDesde
        // 
        lblFechaDesde.AutoSize = true;
        lblFechaDesde.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblFechaDesde.ForeColor = Color.FromArgb(51, 65, 85);
        lblFechaDesde.Location = new Point(275, 12);
        lblFechaDesde.Name = "lblFechaDesde";
        lblFechaDesde.Size = new Size(76, 15);
        lblFechaDesde.TabIndex = 2;
        lblFechaDesde.Text = "Fecha Desde:";
        // 
        // dtpFechaDesde
        // 
        dtpFechaDesde.Checked = false;
        dtpFechaDesde.CustomFormat = "dd/MM/yyyy";
        dtpFechaDesde.Font = new Font("Segoe UI", 9.5F);
        dtpFechaDesde.Format = DateTimePickerFormat.Custom;
        dtpFechaDesde.Location = new Point(275, 30);
        dtpFechaDesde.Name = "dtpFechaDesde";
        dtpFechaDesde.ShowCheckBox = true;
        dtpFechaDesde.Size = new Size(130, 24);
        dtpFechaDesde.TabIndex = 3;
        // 
        // lblFechaHasta
        // 
        lblFechaHasta.AutoSize = true;
        lblFechaHasta.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        lblFechaHasta.ForeColor = Color.FromArgb(51, 65, 85);
        lblFechaHasta.Location = new Point(420, 12);
        lblFechaHasta.Name = "lblFechaHasta";
        lblFechaHasta.Size = new Size(74, 15);
        lblFechaHasta.TabIndex = 4;
        lblFechaHasta.Text = "Fecha Hasta:";
        // 
        // dtpFechaHasta
        // 
        dtpFechaHasta.Checked = false;
        dtpFechaHasta.CustomFormat = "dd/MM/yyyy";
        dtpFechaHasta.Font = new Font("Segoe UI", 9.5F);
        dtpFechaHasta.Format = DateTimePickerFormat.Custom;
        dtpFechaHasta.Location = new Point(420, 30);
        dtpFechaHasta.Name = "dtpFechaHasta";
        dtpFechaHasta.ShowCheckBox = true;
        dtpFechaHasta.Size = new Size(130, 24);
        dtpFechaHasta.TabIndex = 5;
        // 
        // btnGenerar
        // 
        btnGenerar.Location = new Point(570, 26);
        btnGenerar.Name = "btnGenerar";
        btnGenerar.Size = new Size(140, 32);
        btnGenerar.TabIndex = 6;
        btnGenerar.Text = "Generar Reporte";
        btnGenerar.UseVisualStyleBackColor = true;
        btnGenerar.Click += BtnGenerar_Click;
        // 
        // btnExportar
        // 
        btnExportar.Location = new Point(720, 26);
        btnExportar.Name = "btnExportar";
        btnExportar.Size = new Size(180, 32);
        btnExportar.TabIndex = 7;
        btnExportar.Text = "Exportar a CSV / Excel";
        btnExportar.UseVisualStyleBackColor = true;
        btnExportar.Click += BtnExportar_Click;
        // 
        // pnlFooter
        // 
        pnlFooter.BackColor = Color.FromArgb(248, 250, 252);
        pnlFooter.Controls.Add(lblTotalRegistros);
        pnlFooter.Dock = DockStyle.Bottom;
        pnlFooter.Location = new Point(0, 580);
        pnlFooter.Name = "pnlFooter";
        pnlFooter.Padding = new Padding(16, 10, 16, 10);
        pnlFooter.Size = new Size(1100, 40);
        pnlFooter.TabIndex = 2;
        // 
        // lblTotalRegistros
        // 
        lblTotalRegistros.AutoSize = true;
        lblTotalRegistros.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
        lblTotalRegistros.ForeColor = Color.FromArgb(30, 41, 59);
        lblTotalRegistros.Location = new Point(16, 12);
        lblTotalRegistros.Name = "lblTotalRegistros";
        lblTotalRegistros.Size = new Size(157, 17);
        lblTotalRegistros.TabIndex = 0;
        lblTotalRegistros.Text = "Registros encontrados: 0";
        // 
        // dgvReporte
        // 
        dgvReporte.Dock = DockStyle.Fill;
        dgvReporte.Location = new Point(0, 115);
        dgvReporte.Name = "dgvReporte";
        dgvReporte.Size = new Size(1100, 465);
        dgvReporte.TabIndex = 3;
        // 
        // FrmReportes
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1100, 620);
        Controls.Add(dgvReporte);
        Controls.Add(pnlFooter);
        Controls.Add(pnlFiltros);
        Controls.Add(pnlTop);
        Name = "FrmReportes";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Reportes y Auditoría del Sistema";
        Load += FrmReportes_Load;
        ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
        pnlTop.ResumeLayout(false);
        pnlTop.PerformLayout();
        pnlFiltros.ResumeLayout(false);
        pnlFiltros.PerformLayout();
        pnlFooter.ResumeLayout(false);
        pnlFooter.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private ErrorProvider errorProvider;
    private Panel pnlTop;
    private Label lblTitulo;
    private Panel pnlFiltros;
    private Label lblTipoReporte;
    private ComboBox cmbTipoReporte;
    private Label lblFechaDesde;
    private DateTimePicker dtpFechaDesde;
    private Label lblFechaHasta;
    private DateTimePicker dtpFechaHasta;
    private Button btnGenerar;
    private Button btnExportar;
    private Panel pnlFooter;
    private Label lblTotalRegistros;
    private DataGridView dgvReporte;
}
