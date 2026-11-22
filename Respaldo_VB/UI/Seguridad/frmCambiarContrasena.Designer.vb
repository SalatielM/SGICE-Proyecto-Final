<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCambiarContrasena
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCambiarContrasena))
        pnlInferiordeInformacion = New Panel()
        btnCerrar = New Button()
        TableLayoutPanel1 = New TableLayoutPanel()
        txtUsuario = New TextBox()
        Label1 = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        Label2 = New Label()
        txtClaveActual = New TextBox()
        TableLayoutPanel3 = New TableLayoutPanel()
        Label3 = New Label()
        txtClaveNueva = New TextBox()
        btnCambiarClave = New Button()
        pnlInferiordeInformacion.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlInferiordeInformacion
        ' 
        pnlInferiordeInformacion.BackColor = SystemColors.ActiveCaption
        pnlInferiordeInformacion.BorderStyle = BorderStyle.Fixed3D
        pnlInferiordeInformacion.Controls.Add(btnCerrar)
        pnlInferiordeInformacion.Dock = DockStyle.Top
        pnlInferiordeInformacion.Location = New Point(0, 0)
        pnlInferiordeInformacion.Name = "pnlInferiordeInformacion"
        pnlInferiordeInformacion.Size = New Size(537, 39)
        pnlInferiordeInformacion.TabIndex = 3
        ' 
        ' btnCerrar
        ' 
        btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), Image)
        btnCerrar.Location = New Point(497, 2)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(32, 30)
        btnCerrar.TabIndex = 4
        btnCerrar.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 29.2803974F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 70.7196045F))
        TableLayoutPanel1.Controls.Add(txtUsuario, 1, 0)
        TableLayoutPanel1.Controls.Add(Label1, 0, 0)
        TableLayoutPanel1.Location = New Point(63, 63)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(403, 44)
        TableLayoutPanel1.TabIndex = 4
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtUsuario.Location = New Point(124, 6)
        txtUsuario.Margin = New Padding(6)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(273, 31)
        txtUsuario.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(10, 10)
        Label1.Margin = New Padding(10)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 24)
        Label1.TabIndex = 7
        Label1.Text = "Usuario:"
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 42.4317627F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 57.5682373F))
        TableLayoutPanel2.Controls.Add(Label2, 0, 0)
        TableLayoutPanel2.Controls.Add(txtClaveActual, 1, 0)
        TableLayoutPanel2.Location = New Point(63, 123)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Size = New Size(403, 44)
        TableLayoutPanel2.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(10, 10)
        Label2.Margin = New Padding(10)
        Label2.Name = "Label2"
        Label2.Size = New Size(151, 24)
        Label2.TabIndex = 8
        Label2.Text = "Clave Actual:"
        ' 
        ' txtClaveActual
        ' 
        txtClaveActual.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtClaveActual.Location = New Point(177, 6)
        txtClaveActual.Margin = New Padding(6)
        txtClaveActual.Name = "txtClaveActual"
        txtClaveActual.Size = New Size(220, 31)
        txtClaveActual.TabIndex = 8
        txtClaveActual.UseSystemPasswordChar = True
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 40.69479F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 59.30521F))
        TableLayoutPanel3.Controls.Add(Label3, 0, 0)
        TableLayoutPanel3.Controls.Add(txtClaveNueva, 1, 0)
        TableLayoutPanel3.Location = New Point(63, 180)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Size = New Size(403, 44)
        TableLayoutPanel3.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(10, 10)
        Label3.Margin = New Padding(10)
        Label3.Name = "Label3"
        Label3.Size = New Size(144, 24)
        Label3.TabIndex = 8
        Label3.Text = "Clave Nueva:"
        ' 
        ' txtClaveNueva
        ' 
        txtClaveNueva.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtClaveNueva.Location = New Point(170, 6)
        txtClaveNueva.Margin = New Padding(6)
        txtClaveNueva.Name = "txtClaveNueva"
        txtClaveNueva.Size = New Size(227, 31)
        txtClaveNueva.TabIndex = 8
        txtClaveNueva.UseSystemPasswordChar = True
        ' 
        ' btnCambiarClave
        ' 
        btnCambiarClave.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnCambiarClave.BackColor = SystemColors.GradientActiveCaption
        btnCambiarClave.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCambiarClave.Location = New Point(63, 244)
        btnCambiarClave.Name = "btnCambiarClave"
        btnCambiarClave.Size = New Size(403, 34)
        btnCambiarClave.TabIndex = 7
        btnCambiarClave.Text = "Cambiar Clave"
        btnCambiarClave.UseVisualStyleBackColor = False
        ' 
        ' frmCambiarContrasena
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(537, 308)
        Controls.Add(btnCambiarClave)
        Controls.Add(TableLayoutPanel3)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(pnlInferiordeInformacion)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmCambiarContrasena"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmCambiarContrasena"
        pnlInferiordeInformacion.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlInferiordeInformacion As Panel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtClaveActual As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtClaveNueva As TextBox
    Friend WithEvents btnCambiarClave As Button
End Class
