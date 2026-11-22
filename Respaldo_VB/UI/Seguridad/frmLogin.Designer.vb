<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        txtUsuarioLogin = New TextBox()
        lblUsuarioLogin = New Label()
        btnIniciarSesion = New Button()
        lblContrasenaLogin = New Label()
        txtContrasenaLogin = New TextBox()
        btnSalirLogin = New Button()
        GroupBox1 = New GroupBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.Dock = DockStyle.Left
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(438, 439)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(187, 30)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(104, 94)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' txtUsuarioLogin
        ' 
        txtUsuarioLogin.Font = New Font("Bookman Old Style", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txtUsuarioLogin.Location = New Point(55, 198)
        txtUsuarioLogin.Name = "txtUsuarioLogin"
        txtUsuarioLogin.Size = New Size(373, 36)
        txtUsuarioLogin.TabIndex = 2
        ' 
        ' lblUsuarioLogin
        ' 
        lblUsuarioLogin.AutoSize = True
        lblUsuarioLogin.Font = New Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUsuarioLogin.Location = New Point(55, 167)
        lblUsuarioLogin.Name = "lblUsuarioLogin"
        lblUsuarioLogin.Size = New Size(107, 28)
        lblUsuarioLogin.TabIndex = 3
        lblUsuarioLogin.Text = "Usuario"
        ' 
        ' btnIniciarSesion
        ' 
        btnIniciarSesion.BackColor = Color.Honeydew
        btnIniciarSesion.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnIniciarSesion.Location = New Point(55, 351)
        btnIniciarSesion.Name = "btnIniciarSesion"
        btnIniciarSesion.Size = New Size(184, 34)
        btnIniciarSesion.TabIndex = 4
        btnIniciarSesion.Text = "Iniciar"
        btnIniciarSesion.UseVisualStyleBackColor = False
        ' 
        ' lblContrasenaLogin
        ' 
        lblContrasenaLogin.AutoSize = True
        lblContrasenaLogin.Font = New Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblContrasenaLogin.Location = New Point(55, 249)
        lblContrasenaLogin.Name = "lblContrasenaLogin"
        lblContrasenaLogin.Size = New Size(165, 28)
        lblContrasenaLogin.TabIndex = 5
        lblContrasenaLogin.Text = "Constraseña"
        ' 
        ' txtContrasenaLogin
        ' 
        txtContrasenaLogin.Font = New Font("Bookman Old Style", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txtContrasenaLogin.Location = New Point(55, 280)
        txtContrasenaLogin.Name = "txtContrasenaLogin"
        txtContrasenaLogin.Size = New Size(373, 36)
        txtContrasenaLogin.TabIndex = 6
        txtContrasenaLogin.UseSystemPasswordChar = True
        ' 
        ' btnSalirLogin
        ' 
        btnSalirLogin.BackColor = Color.MistyRose
        btnSalirLogin.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSalirLogin.Location = New Point(245, 351)
        btnSalirLogin.Name = "btnSalirLogin"
        btnSalirLogin.Size = New Size(183, 34)
        btnSalirLogin.TabIndex = 7
        btnSalirLogin.Text = "Salir"
        btnSalirLogin.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnIniciarSesion)
        GroupBox1.Controls.Add(btnSalirLogin)
        GroupBox1.Controls.Add(PictureBox2)
        GroupBox1.Controls.Add(lblContrasenaLogin)
        GroupBox1.Controls.Add(txtContrasenaLogin)
        GroupBox1.Controls.Add(txtUsuarioLogin)
        GroupBox1.Controls.Add(lblUsuarioLogin)
        GroupBox1.Location = New Point(454, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(476, 425)
        GroupBox1.TabIndex = 8
        GroupBox1.TabStop = False
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(942, 439)
        Controls.Add(PictureBox1)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtUsuarioLogin As TextBox
    Friend WithEvents lblUsuarioLogin As Label
    Friend WithEvents btnIniciarSesion As Button
    Friend WithEvents lblContrasenaLogin As Label
    Friend WithEvents txtContrasenaLogin As TextBox
    Friend WithEvents btnSalirLogin As Button
    Friend WithEvents GroupBox1 As GroupBox

End Class
