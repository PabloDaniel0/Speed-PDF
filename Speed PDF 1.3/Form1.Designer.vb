<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentanaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PantallaCompletaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NormalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinimizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SporteTecnicoYControlDeVersiónesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.VentanaToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        resources.ApplyResources(Me.ArchivoToolStripMenuItem, "ArchivoToolStripMenuItem")
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.AbrirToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        resources.ApplyResources(Me.AbrirToolStripMenuItem, "AbrirToolStripMenuItem")
        '
        'VentanaToolStripMenuItem
        '
        Me.VentanaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.VentanaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PantallaCompletaToolStripMenuItem, Me.NormalToolStripMenuItem, Me.MinimizarToolStripMenuItem, Me.CerrarToolStripMenuItem})
        Me.VentanaToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.VentanaToolStripMenuItem.Name = "VentanaToolStripMenuItem"
        resources.ApplyResources(Me.VentanaToolStripMenuItem, "VentanaToolStripMenuItem")
        '
        'PantallaCompletaToolStripMenuItem
        '
        Me.PantallaCompletaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.PantallaCompletaToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.PantallaCompletaToolStripMenuItem.Name = "PantallaCompletaToolStripMenuItem"
        resources.ApplyResources(Me.PantallaCompletaToolStripMenuItem, "PantallaCompletaToolStripMenuItem")
        '
        'NormalToolStripMenuItem
        '
        Me.NormalToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.NormalToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.NormalToolStripMenuItem.Name = "NormalToolStripMenuItem"
        resources.ApplyResources(Me.NormalToolStripMenuItem, "NormalToolStripMenuItem")
        '
        'MinimizarToolStripMenuItem
        '
        Me.MinimizarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.MinimizarToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.MinimizarToolStripMenuItem.Name = "MinimizarToolStripMenuItem"
        resources.ApplyResources(Me.MinimizarToolStripMenuItem, "MinimizarToolStripMenuItem")
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.CerrarToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        resources.ApplyResources(Me.CerrarToolStripMenuItem, "CerrarToolStripMenuItem")
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SporteTecnicoYControlDeVersiónesToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        resources.ApplyResources(Me.AyudaToolStripMenuItem, "AyudaToolStripMenuItem")
        '
        'SporteTecnicoYControlDeVersiónesToolStripMenuItem
        '
        Me.SporteTecnicoYControlDeVersiónesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.SporteTecnicoYControlDeVersiónesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SporteTecnicoYControlDeVersiónesToolStripMenuItem.Name = "SporteTecnicoYControlDeVersiónesToolStripMenuItem"
        resources.ApplyResources(Me.SporteTecnicoYControlDeVersiónesToolStripMenuItem, "SporteTecnicoYControlDeVersiónesToolStripMenuItem")
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.AcercaDeToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        resources.ApplyResources(Me.AcercaDeToolStripMenuItem, "AcercaDeToolStripMenuItem")
        '
        'AxAcroPDF1
        '
        resources.ApplyResources(Me.AxAcroPDF1, "AxAcroPDF1")
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.Controls.Add(Me.AxAcroPDF1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentanaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PantallaCompletaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NormalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MinimizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SporteTecnicoYControlDeVersiónesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
