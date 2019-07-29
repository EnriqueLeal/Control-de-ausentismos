<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCaptura
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
        Me.panel = New System.Windows.Forms.Panel()
        Me.gbxGrupo = New System.Windows.Forms.GroupBox()
        Me.btnCapturar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMatricula = New System.Windows.Forms.TextBox()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboCursos = New System.Windows.Forms.ComboBox()
        Me.txbPeriodo = New System.Windows.Forms.TextBox()
        Me.dgvCaptura = New System.Windows.Forms.DataGridView()
        Me.panel.SuspendLayout()
        Me.gbxGrupo.SuspendLayout()
        CType(Me.dgvCaptura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel
        '
        Me.panel.Controls.Add(Me.gbxGrupo)
        Me.panel.Controls.Add(Me.btnInicio)
        Me.panel.Controls.Add(Me.Label2)
        Me.panel.Controls.Add(Me.Label1)
        Me.panel.Controls.Add(Me.cboCursos)
        Me.panel.Controls.Add(Me.txbPeriodo)
        Me.panel.ForeColor = System.Drawing.Color.White
        Me.panel.Location = New System.Drawing.Point(18, 19)
        Me.panel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(685, 272)
        Me.panel.TabIndex = 0
        '
        'gbxGrupo
        '
        Me.gbxGrupo.Controls.Add(Me.btnCapturar)
        Me.gbxGrupo.Controls.Add(Me.Label3)
        Me.gbxGrupo.Controls.Add(Me.txtMatricula)
        Me.gbxGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbxGrupo.Location = New System.Drawing.Point(7, 149)
        Me.gbxGrupo.Name = "gbxGrupo"
        Me.gbxGrupo.Size = New System.Drawing.Size(672, 116)
        Me.gbxGrupo.TabIndex = 5
        Me.gbxGrupo.TabStop = False
        Me.gbxGrupo.Visible = False
        '
        'btnCapturar
        '
        Me.btnCapturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCapturar.Location = New System.Drawing.Point(394, 42)
        Me.btnCapturar.Name = "btnCapturar"
        Me.btnCapturar.Size = New System.Drawing.Size(75, 36)
        Me.btnCapturar.TabIndex = 2
        Me.btnCapturar.Text = "Captura"
        Me.btnCapturar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(190, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 21)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Matricula:"
        '
        'txtMatricula
        '
        Me.txtMatricula.Location = New System.Drawing.Point(274, 47)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(100, 29)
        Me.txtMatricula.TabIndex = 0
        '
        'btnInicio
        '
        Me.btnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInicio.Location = New System.Drawing.Point(273, 77)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(128, 36)
        Me.btnInicio.TabIndex = 4
        Me.btnInicio.Text = "Iniciar captura"
        Me.btnInicio.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(337, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Periodo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Curso:"
        '
        'cboCursos
        '
        Me.cboCursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCursos.FormattingEnabled = True
        Me.cboCursos.Location = New System.Drawing.Point(64, 31)
        Me.cboCursos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboCursos.Name = "cboCursos"
        Me.cboCursos.Size = New System.Drawing.Size(247, 29)
        Me.cboCursos.TabIndex = 1
        '
        'txbPeriodo
        '
        Me.txbPeriodo.Location = New System.Drawing.Point(411, 31)
        Me.txbPeriodo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txbPeriodo.Name = "txbPeriodo"
        Me.txbPeriodo.ReadOnly = True
        Me.txbPeriodo.Size = New System.Drawing.Size(247, 29)
        Me.txbPeriodo.TabIndex = 0
        '
        'dgvCaptura
        '
        Me.dgvCaptura.AllowUserToAddRows = False
        Me.dgvCaptura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCaptura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCaptura.Location = New System.Drawing.Point(25, 299)
        Me.dgvCaptura.Name = "dgvCaptura"
        Me.dgvCaptura.ReadOnly = True
        Me.dgvCaptura.Size = New System.Drawing.Size(672, 227)
        Me.dgvCaptura.TabIndex = 1
        '
        'frmCaptura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(722, 551)
        Me.Controls.Add(Me.dgvCaptura)
        Me.Controls.Add(Me.panel)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmCaptura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.panel.ResumeLayout(False)
        Me.panel.PerformLayout()
        Me.gbxGrupo.ResumeLayout(False)
        Me.gbxGrupo.PerformLayout()
        CType(Me.dgvCaptura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panel As System.Windows.Forms.Panel
    Friend WithEvents cboCursos As System.Windows.Forms.ComboBox
    Friend WithEvents txbPeriodo As System.Windows.Forms.TextBox
    Friend WithEvents gbxGrupo As System.Windows.Forms.GroupBox
    Friend WithEvents btnCapturar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMatricula As System.Windows.Forms.TextBox
    Friend WithEvents btnInicio As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvCaptura As System.Windows.Forms.DataGridView
End Class
