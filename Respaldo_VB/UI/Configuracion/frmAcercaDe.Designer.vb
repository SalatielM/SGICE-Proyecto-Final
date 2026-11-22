<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAcercaDe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAcercaDe))
        label1 = New Label()
        GroupBox1 = New GroupBox()
        Label3 = New Label()
        Label2 = New Label()
        GroupBox2 = New GroupBox()
        PictureBox2 = New PictureBox()
        Label4 = New Label()
        GroupBox3 = New GroupBox()
        PictureBox1 = New PictureBox()
        Label6 = New Label()
        GroupBox4 = New GroupBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' label1
        ' 
        label1.BackColor = SystemColors.ActiveCaption
        label1.BorderStyle = BorderStyle.Fixed3D
        label1.Dock = DockStyle.Top
        label1.Font = New Font("Bookman Old Style", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label1.Location = New Point(0, 0)
        label1.Margin = New Padding(4, 0, 4, 0)
        label1.Name = "label1"
        label1.Size = New Size(1247, 37)
        label1.TabIndex = 10
        label1.Text = "ACERCA DE"
        label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(280, 70)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(928, 237)
        GroupBox1.TabIndex = 11
        GroupBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.Font = New Font("Bookman Old Style", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(15, 145)
        Label3.Name = "Label3"
        Label3.Size = New Size(907, 54)
        Label3.TabIndex = 14
        Label3.Text = "Permite registrar, controlar y dar seguimiento a los bienes de una institución, " & vbCrLf & "optimizando su uso y evitando pérdidas o desorden en su administración."
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.Font = New Font("Bookman Old Style", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(15, 50)
        Label2.Name = "Label2"
        Label2.Size = New Size(899, 64)
        Label2.TabIndex = 13
        Label2.Text = "SISTEMA DE GESTION DE ACTIVOS Y MOBILIARIOS " & vbCrLf & "PARA CENTROS EDUCATIVOS"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox2.Controls.Add(PictureBox2)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Location = New Point(32, 328)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1176, 159)
        GroupBox2.TabIndex = 12
        GroupBox2.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(9, 20)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(1156, 92)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 13
        PictureBox2.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.Font = New Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(9, 118)
        Label4.Name = "Label4"
        Label4.Size = New Size(1156, 28)
        Label4.TabIndex = 14
        Label4.Text = "<RH>dev> Software Factory"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(PictureBox1)
        GroupBox3.Location = New Point(32, 70)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(242, 237)
        GroupBox3.TabIndex = 13
        GroupBox3.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(25, 25)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(193, 199)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label6.Font = New Font("Bookman Old Style", 11F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(9, 37)
        Label6.Name = "Label6"
        Label6.Size = New Size(1153, 192)
        Label6.TabIndex = 15
        Label6.Text = resources.GetString("Label6.Text")
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox4.Controls.Add(Label6)
        GroupBox4.Location = New Point(32, 493)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(1176, 247)
        GroupBox4.TabIndex = 16
        GroupBox4.TabStop = False
        ' 
        ' frmAcercaDe
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1247, 765)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmAcercaDe"
        Text = "frmAcercaDe"
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox4.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Private WithEvents label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox4 As GroupBox
End Class
