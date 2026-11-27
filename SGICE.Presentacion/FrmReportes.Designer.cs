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
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        errorProvider = new ErrorProvider(components);
        pnlTop = new Panel();
        lblTitulo = new Label();
        pnlFiltrosContainer = new Panel();
        grpFiltros = new GroupBox();
        lblTipoReporte = new Label();
        cmbTipoReporte = new ComboBox();
        lblFechaDesde = new Label();
        dtpFechaDesde = new DateTimePicker();
        lblFechaHasta = new Label();
        dtpFechaHasta = new DateTimePicker();
        btnGenerar = new Button();
        btnExportar = new Button();
        pnlListaContainer = new Panel();
        grpResultados = new GroupBox();
        dgvReporte = new DataGridView();
        pnlFooter = new Panel();
        lblTotalRegistros = new Label();
        ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
        pnlTop.SuspendLayout();
        pnlFiltrosContainer.SuspendLayout();
        grpFiltros.SuspendLayout();
        pnlListaContainer.SuspendLayout();
        grpResultados.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
        pnlFooter.SuspendLayout();
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
        pnlTop.Margin = new Padding(3, 4, 3, 4);
        pnlTop.Name = "pnlTop";
        pnlTop.Size = new Size(1211, 43);
        pnlTop.TabIndex = 0;
        // 
        // lblTitulo
        // 
        lblTitulo.Dock = DockStyle.Fill;
        lblTitulo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.Black;
        lblTitulo.Location = new Point(0, 0);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(1211, 43);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "REPORTES Y BITÁCORA DE AUDITORÍA";
        lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // pnlFiltrosContainer
        // 
        pnlFiltrosContainer.BackColor = SystemColors.Control;
        pnlFiltrosContainer.Controls.Add(grpFiltros);
        pnlFiltrosContainer.Dock = DockStyle.Top;
        pnlFiltrosContainer.Location = new Point(0, 43);
        pnlFiltrosContainer.Margin = new Padding(3, 4, 3, 4);
        pnlFiltrosContainer.Name = "pnlFiltrosContainer";
        pnlFiltrosContainer.Padding = new Padding(9, 8, 9, 5);
        pnlFiltrosContainer.Size = new Size(1211, 99);
        pnlFiltrosContainer.TabIndex = 1;
        // 
        // grpFiltros
        // 
        grpFiltros.BackColor = SystemColors.Control;
        grpFiltros.Controls.Add(lblTipoReporte);
        grpFiltros.Controls.Add(cmbTipoReporte);
        grpFiltros.Controls.Add(lblFechaDesde);
        grpFiltros.Controls.Add(dtpFechaDesde);
        grpFiltros.Controls.Add(lblFechaHasta);
        grpFiltros.Controls.Add(dtpFechaHasta);
        grpFiltros.Controls.Add(btnGenerar);
        grpFiltros.Controls.Add(btnExportar);
        grpFiltros.Dock = DockStyle.Fill;
        grpFiltros.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        grpFiltros.ForeColor = Color.Black;
        grpFiltros.Location = new Point(9, 8);
        grpFiltros.Margin = new Padding(3, 4, 3, 4);
        grpFiltros.Name = "grpFiltros";
        grpFiltros.Padding = new Padding(3, 4, 3, 4);
        grpFiltros.Size = new Size(1193, 86);
        grpFiltros.TabIndex = 0;
        grpFiltros.TabStop = false;
        grpFiltros.Text = "Filtros de Consulta";
        // 
        // lblTipoReporte
        // 
        lblTipoReporte.AutoSize = true;
        lblTipoReporte.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblTipoReporte.ForeColor = Color.Black;
        lblTipoReporte.Location = new Point(14, 37);
        lblTipoReporte.Name = "lblTipoReporte";
        lblTipoReporte.Size = new Size(125, 20);
        lblTipoReporte.TabIndex = 0;
        lblTipoReporte.Text = "Tipo de Reporte:";
        // 
        // cmbTipoReporte
        // 
        cmbTipoReporte.BackColor = SystemColors.Window;
        cmbTipoReporte.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbTipoReporte.Font = new Font("Segoe UI", 9F);
        cmbTipoReporte.FormattingEnabled = true;
        cmbTipoReporte.Location = new Point(139, 33);
        cmbTipoReporte.Margin = new Padding(3, 4, 3, 4);
        cmbTipoReporte.Name = "cmbTipoReporte";
        cmbTipoReporte.Size = new Size(217, 28);
        cmbTipoReporte.TabIndex = 1;
        cmbTipoReporte.SelectedIndexChanged += cmbTipoReporte_SelectedIndexChanged;
        // 
        // lblFechaDesde
        // 
        lblFechaDesde.AutoSize = true;
        lblFechaDesde.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblFechaDesde.ForeColor = Color.Black;
        lblFechaDesde.Location = new Point(368, 37);
        lblFechaDesde.Name = "lblFechaDesde";
        lblFechaDesde.Size = new Size(56, 20);
        lblFechaDesde.TabIndex = 2;
        lblFechaDesde.Text = "Desde:";
        // 
        // dtpFechaDesde
        // 
        dtpFechaDesde.Checked = false;
        dtpFechaDesde.CustomFormat = "dd/MM/yyyy";
        dtpFechaDesde.Font = new Font("Segoe UI", 9F);
        dtpFechaDesde.Format = DateTimePickerFormat.Custom;
        dtpFechaDesde.Location = new Point(425, 33);
        dtpFechaDesde.Margin = new Padding(3, 4, 3, 4);
        dtpFechaDesde.Name = "dtpFechaDesde";
        dtpFechaDesde.ShowCheckBox = true;
        dtpFechaDesde.Size = new Size(125, 27);
        dtpFechaDesde.TabIndex = 3;
        // 
        // lblFechaHasta
        // 
        lblFechaHasta.AutoSize = true;
        lblFechaHasta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblFechaHasta.ForeColor = Color.Black;
        lblFechaHasta.Location = new Point(562, 37);
        lblFechaHasta.Name = "lblFechaHasta";
        lblFechaHasta.Size = new Size(53, 20);
        lblFechaHasta.TabIndex = 4;
        lblFechaHasta.Text = "Hasta:";
        // 
        // dtpFechaHasta
        // 
        dtpFechaHasta.Checked = false;
        dtpFechaHasta.CustomFormat = "dd/MM/yyyy";
        dtpFechaHasta.Font = new Font("Segoe UI", 9F);
        dtpFechaHasta.Format = DateTimePickerFormat.Custom;
        dtpFechaHasta.Location = new Point(617, 33);
        dtpFechaHasta.Margin = new Padding(3, 4, 3, 4);
        dtpFechaHasta.Name = "dtpFechaHasta";
        dtpFechaHasta.ShowCheckBox = true;
        dtpFechaHasta.Size = new Size(125, 27);
        dtpFechaHasta.TabIndex = 5;
        // 
        // btnGenerar
        // 
        btnGenerar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnGenerar.BackColor = Color.FromArgb(232, 245, 233);
        btnGenerar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnGenerar.ForeColor = Color.Black;
        btnGenerar.Location = new Point(885, 29);
        btnGenerar.Margin = new Padding(3, 4, 3, 4);
        btnGenerar.Name = "btnGenerar";
        btnGenerar.Size = new Size(143, 37);
        btnGenerar.TabIndex = 6;
        btnGenerar.Text = "Generar Reporte";
        btnGenerar.UseVisualStyleBackColor = false;
        btnGenerar.Click += BtnGenerar_Click;
        // 
        // btnExportar
        // 
        btnExportar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnExportar.BackColor = Color.FromArgb(224, 247, 250);
        btnExportar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnExportar.ForeColor = Color.Black;
        btnExportar.Location = new Point(1037, 29);
        btnExportar.Margin = new Padding(3, 4, 3, 4);
        btnExportar.Name = "btnExportar";
        btnExportar.Size = new Size(143, 37);
        btnExportar.TabIndex = 7;
        btnExportar.Text = "Exportar CSV";
        btnExportar.UseVisualStyleBackColor = false;
        btnExportar.Click += BtnExportar_Click;
        // 
        // pnlListaContainer
        // 
        pnlListaContainer.BackColor = SystemColors.Control;
        pnlListaContainer.Controls.Add(grpResultados);
        pnlListaContainer.Dock = DockStyle.Fill;
        pnlListaContainer.Location = new Point(0, 142);
        pnlListaContainer.Margin = new Padding(3, 4, 3, 4);
        pnlListaContainer.Name = "pnlListaContainer";
        pnlListaContainer.Padding = new Padding(9, 3, 9, 5);
        pnlListaContainer.Size = new Size(1211, 640);
        pnlListaContainer.TabIndex = 2;
        // 
        // grpResultados
        // 
        grpResultados.BackColor = SystemColors.Control;
        grpResultados.Controls.Add(dgvReporte);
        grpResultados.Dock = DockStyle.Fill;
        grpResultados.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        grpResultados.ForeColor = Color.Black;
        grpResultados.Location = new Point(9, 3);
        grpResultados.Margin = new Padding(3, 4, 3, 4);
        grpResultados.Name = "grpResultados";
        grpResultados.Padding = new Padding(9, 11, 9, 11);
        grpResultados.Size = new Size(1193, 632);
        grpResultados.TabIndex = 0;
        grpResultados.TabStop = false;
        grpResultados.Text = "Resultados del Reporte";
        // 
        // dgvReporte
        // 
        dgvReporte.AllowUserToAddRows = false;
        dgvReporte.AllowUserToDeleteRows = false;
        dgvReporte.AllowUserToResizeRows = false;
        dgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvReporte.BackgroundColor = Color.White;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = SystemColors.Control;
        dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        dataGridViewCellStyle1.ForeColor = Color.Black;
        dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        dgvReporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dgvReporte.ColumnHeadersHeight = 26;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = SystemColors.Window;
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle2.ForeColor = Color.Black;
        dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
        dgvReporte.DefaultCellStyle = dataGridViewCellStyle2;
        dgvReporte.Dock = DockStyle.Fill;
        dgvReporte.Location = new Point(9, 31);
        dgvReporte.Margin = new Padding(3, 4, 3, 4);
        dgvReporte.MultiSelect = false;
        dgvReporte.Name = "dgvReporte";
        dgvReporte.ReadOnly = true;
        dgvReporte.RowHeadersWidth = 25;
        dgvReporte.RowTemplate.Height = 24;
        dgvReporte.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvReporte.Size = new Size(1175, 590);
        dgvReporte.TabIndex = 0;
        // 
        // pnlFooter
        // 
        pnlFooter.BackColor = SystemColors.Control;
        pnlFooter.Controls.Add(lblTotalRegistros);
        pnlFooter.Dock = DockStyle.Bottom;
        pnlFooter.Location = new Point(0, 782);
        pnlFooter.Margin = new Padding(3, 4, 3, 4);
        pnlFooter.Name = "pnlFooter";
        pnlFooter.Padding = new Padding(11, 5, 11, 5);
        pnlFooter.Size = new Size(1211, 37);
        pnlFooter.TabIndex = 3;
        // 
        // lblTotalRegistros
        // 
        lblTotalRegistros.AutoSize = true;
        lblTotalRegistros.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblTotalRegistros.ForeColor = Color.Black;
        lblTotalRegistros.Location = new Point(11, 8);
        lblTotalRegistros.Name = "lblTotalRegistros";
        lblTotalRegistros.Size = new Size(183, 20);
        lblTotalRegistros.TabIndex = 0;
        lblTotalRegistros.Text = "Registros encontrados: 0";
        // 
        // FrmReportes
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        ClientSize = new Size(1211, 819);
        Controls.Add(pnlListaContainer);
        Controls.Add(pnlFooter);
        Controls.Add(pnlFiltrosContainer);
        Controls.Add(pnlTop);
        Margin = new Padding(3, 4, 3, 4);
        Name = "FrmReportes";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Reportes y Auditoría del Sistema";
        Load += FrmReportes_Load;
        ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
        pnlTop.ResumeLayout(false);
        pnlFiltrosContainer.ResumeLayout(false);
        grpFiltros.ResumeLayout(false);
        grpFiltros.PerformLayout();
        pnlListaContainer.ResumeLayout(false);
        grpResultados.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
        pnlFooter.ResumeLayout(false);
        pnlFooter.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private ErrorProvider errorProvider;
    private Panel pnlTop;
    private Label lblTitulo;
    private Panel pnlFiltrosContainer;
    private GroupBox grpFiltros;
    private Label lblTipoReporte;
    private Label lblFechaDesde;
    private DateTimePicker dtpFechaDesde;
    private Label lblFechaHasta;
    private DateTimePicker dtpFechaHasta;
    private Button btnGenerar;
    private Button btnExportar;
    private Panel pnlListaContainer;
    private GroupBox grpResultados;
    private DataGridView dgvReporte;
    private Panel pnlFooter;
    private Label lblTotalRegistros;
    private ComboBox cmbTipoReporte;
}
