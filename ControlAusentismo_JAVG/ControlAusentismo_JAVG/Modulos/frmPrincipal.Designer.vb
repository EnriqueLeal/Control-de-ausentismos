<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.msPrincipal = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlAusentismosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarAsistenciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarAusentismosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CapturaEquiposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CapturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.msPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'msPrincipal
        '
        Me.msPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.ControlAusentismosToolStripMenuItem, Me.CapturaEquiposToolStripMenuItem})
        Me.msPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.msPrincipal.Name = "msPrincipal"
        Me.msPrincipal.Size = New System.Drawing.Size(674, 24)
        Me.msPrincipal.TabIndex = 0
        Me.msPrincipal.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'ControlAusentismosToolStripMenuItem
        '
        Me.ControlAusentismosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarAsistenciasToolStripMenuItem, Me.AdministrarAusentismosToolStripMenuItem})
        Me.ControlAusentismosToolStripMenuItem.Name = "ControlAusentismosToolStripMenuItem"
        Me.ControlAusentismosToolStripMenuItem.Size = New System.Drawing.Size(130, 20)
        Me.ControlAusentismosToolStripMenuItem.Text = "Control Ausentismos"
        '
        'RegistrarAsistenciasToolStripMenuItem
        '
        Me.RegistrarAsistenciasToolStripMenuItem.Name = "RegistrarAsistenciasToolStripMenuItem"
        Me.RegistrarAsistenciasToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.RegistrarAsistenciasToolStripMenuItem.Text = "Registrar Asistencias"
        '
        'AdministrarAusentismosToolStripMenuItem
        '
        Me.AdministrarAusentismosToolStripMenuItem.Name = "AdministrarAusentismosToolStripMenuItem"
        Me.AdministrarAusentismosToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.AdministrarAusentismosToolStripMenuItem.Text = "Administrar Ausentismos"
        '
        'CapturaEquiposToolStripMenuItem
        '
        Me.CapturaEquiposToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministracionToolStripMenuItem, Me.CapturaToolStripMenuItem})
        Me.CapturaEquiposToolStripMenuItem.Name = "CapturaEquiposToolStripMenuItem"
        Me.CapturaEquiposToolStripMenuItem.ShowShortcutKeys = False
        Me.CapturaEquiposToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.CapturaEquiposToolStripMenuItem.Text = "Equipos"
        '
        'AdministracionToolStripMenuItem
        '
        Me.AdministracionToolStripMenuItem.Name = "AdministracionToolStripMenuItem"
        Me.AdministracionToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AdministracionToolStripMenuItem.Text = "Administracion"
        '
        'CapturaToolStripMenuItem
        '
        Me.CapturaToolStripMenuItem.Name = "CapturaToolStripMenuItem"
        Me.CapturaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CapturaToolStripMenuItem.Text = "Captura"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(674, 494)
        Me.Controls.Add(Me.msPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.msPrincipal
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.msPrincipal.ResumeLayout(False)
        Me.msPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents msPrincipal As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ControlAusentismosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrarAsistenciasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministrarAusentismosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CapturaEquiposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministracionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CapturaToolStripMenuItem As ToolStripMenuItem
End Class
