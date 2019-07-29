<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControlAusentismos
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
        Me.panelPrincipal = New System.Windows.Forms.Panel()
        Me.gvDatos = New System.Windows.Forms.DataGridView()
        Me.gbxFiltros = New System.Windows.Forms.GroupBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.gbxRecargarFaltas = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbNA2 = New System.Windows.Forms.RadioButton()
        Me.rbA2 = New System.Windows.Forms.RadioButton()
        Me.rbJ2 = New System.Windows.Forms.RadioButton()
        Me.rbF2 = New System.Windows.Forms.RadioButton()
        Me.gbxRecargarCon = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbNA1 = New System.Windows.Forms.RadioButton()
        Me.rbF1 = New System.Windows.Forms.RadioButton()
        Me.rbA1 = New System.Windows.Forms.RadioButton()
        Me.rbProceso1 = New System.Windows.Forms.RadioButton()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtHoraFin = New System.Windows.Forms.TextBox()
        Me.txtHoraInicio = New System.Windows.Forms.TextBox()
        Me.lblHoraFin = New System.Windows.Forms.Label()
        Me.lblHoraInicio = New System.Windows.Forms.Label()
        Me.cboHorarios = New System.Windows.Forms.ComboBox()
        Me.lblHorario = New System.Windows.Forms.Label()
        Me.cboCursos = New System.Windows.Forms.ComboBox()
        Me.txtDocente = New System.Windows.Forms.TextBox()
        Me.lblCurso = New System.Windows.Forms.Label()
        Me.lblDocente = New System.Windows.Forms.Label()
        Me.txtPeriodo = New System.Windows.Forms.TextBox()
        Me.lblPeriodo = New System.Windows.Forms.Label()
        Me.panelPrincipal.SuspendLayout()
        CType(Me.gvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxFiltros.SuspendLayout()
        Me.gbxRecargarFaltas.SuspendLayout()
        Me.gbxRecargarCon.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelPrincipal
        '
        Me.panelPrincipal.Controls.Add(Me.gvDatos)
        Me.panelPrincipal.Controls.Add(Me.gbxFiltros)
        Me.panelPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelPrincipal.Location = New System.Drawing.Point(12, 28)
        Me.panelPrincipal.Name = "panelPrincipal"
        Me.panelPrincipal.Size = New System.Drawing.Size(648, 696)
        Me.panelPrincipal.TabIndex = 0
        '
        'gvDatos
        '
        Me.gvDatos.AllowUserToAddRows = False
        Me.gvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvDatos.Location = New System.Drawing.Point(26, 429)
        Me.gvDatos.Name = "gvDatos"
        Me.gvDatos.Size = New System.Drawing.Size(591, 240)
        Me.gvDatos.TabIndex = 1
        '
        'gbxFiltros
        '
        Me.gbxFiltros.Controls.Add(Me.dtpFecha)
        Me.gbxFiltros.Controls.Add(Me.gbxRecargarFaltas)
        Me.gbxFiltros.Controls.Add(Me.gbxRecargarCon)
        Me.gbxFiltros.Controls.Add(Me.btnEliminar)
        Me.gbxFiltros.Controls.Add(Me.btnProcesar)
        Me.gbxFiltros.Controls.Add(Me.btnBuscar)
        Me.gbxFiltros.Controls.Add(Me.txtHoraFin)
        Me.gbxFiltros.Controls.Add(Me.txtHoraInicio)
        Me.gbxFiltros.Controls.Add(Me.lblHoraFin)
        Me.gbxFiltros.Controls.Add(Me.lblHoraInicio)
        Me.gbxFiltros.Controls.Add(Me.cboHorarios)
        Me.gbxFiltros.Controls.Add(Me.lblHorario)
        Me.gbxFiltros.Controls.Add(Me.cboCursos)
        Me.gbxFiltros.Controls.Add(Me.txtDocente)
        Me.gbxFiltros.Controls.Add(Me.lblCurso)
        Me.gbxFiltros.Controls.Add(Me.lblDocente)
        Me.gbxFiltros.Controls.Add(Me.txtPeriodo)
        Me.gbxFiltros.Controls.Add(Me.lblPeriodo)
        Me.gbxFiltros.ForeColor = System.Drawing.Color.White
        Me.gbxFiltros.Location = New System.Drawing.Point(0, 0)
        Me.gbxFiltros.Name = "gbxFiltros"
        Me.gbxFiltros.Size = New System.Drawing.Size(649, 404)
        Me.gbxFiltros.TabIndex = 0
        Me.gbxFiltros.TabStop = False
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(391, 28)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(195, 22)
        Me.dtpFecha.TabIndex = 16
        '
        'gbxRecargarFaltas
        '
        Me.gbxRecargarFaltas.Controls.Add(Me.Label1)
        Me.gbxRecargarFaltas.Controls.Add(Me.rbNA2)
        Me.gbxRecargarFaltas.Controls.Add(Me.rbA2)
        Me.gbxRecargarFaltas.Controls.Add(Me.rbJ2)
        Me.gbxRecargarFaltas.Controls.Add(Me.rbF2)
        Me.gbxRecargarFaltas.Location = New System.Drawing.Point(332, 245)
        Me.gbxRecargarFaltas.Name = "gbxRecargarFaltas"
        Me.gbxRecargarFaltas.Size = New System.Drawing.Size(303, 144)
        Me.gbxRecargarFaltas.TabIndex = 15
        Me.gbxRecargarFaltas.TabStop = False
        Me.gbxRecargarFaltas.Text = "Precargar Faltas de proceso con:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Precargar Faltas de proceso con:"
        '
        'rbNA2
        '
        Me.rbNA2.AutoSize = True
        Me.rbNA2.Location = New System.Drawing.Point(184, 102)
        Me.rbNA2.Name = "rbNA2"
        Me.rbNA2.Size = New System.Drawing.Size(84, 20)
        Me.rbNA2.TabIndex = 3
        Me.rbNA2.Text = "No aplica"
        Me.rbNA2.UseVisualStyleBackColor = True
        '
        'rbA2
        '
        Me.rbA2.AutoSize = True
        Me.rbA2.Location = New System.Drawing.Point(32, 102)
        Me.rbA2.Name = "rbA2"
        Me.rbA2.Size = New System.Drawing.Size(88, 20)
        Me.rbA2.TabIndex = 2
        Me.rbA2.Text = "Asistencia"
        Me.rbA2.UseVisualStyleBackColor = True
        '
        'rbJ2
        '
        Me.rbJ2.AutoSize = True
        Me.rbJ2.Location = New System.Drawing.Point(184, 50)
        Me.rbJ2.Name = "rbJ2"
        Me.rbJ2.Size = New System.Drawing.Size(90, 20)
        Me.rbJ2.TabIndex = 1
        Me.rbJ2.Text = "Justificada"
        Me.rbJ2.UseVisualStyleBackColor = True
        '
        'rbF2
        '
        Me.rbF2.AutoSize = True
        Me.rbF2.Checked = True
        Me.rbF2.Location = New System.Drawing.Point(32, 50)
        Me.rbF2.Name = "rbF2"
        Me.rbF2.Size = New System.Drawing.Size(56, 20)
        Me.rbF2.TabIndex = 0
        Me.rbF2.TabStop = True
        Me.rbF2.Text = "Falta"
        Me.rbF2.UseVisualStyleBackColor = True
        '
        'gbxRecargarCon
        '
        Me.gbxRecargarCon.Controls.Add(Me.Label2)
        Me.gbxRecargarCon.Controls.Add(Me.rbNA1)
        Me.gbxRecargarCon.Controls.Add(Me.rbF1)
        Me.gbxRecargarCon.Controls.Add(Me.rbA1)
        Me.gbxRecargarCon.Controls.Add(Me.rbProceso1)
        Me.gbxRecargarCon.Location = New System.Drawing.Point(26, 245)
        Me.gbxRecargarCon.Name = "gbxRecargarCon"
        Me.gbxRecargarCon.Size = New System.Drawing.Size(300, 144)
        Me.gbxRecargarCon.TabIndex = 1
        Me.gbxRecargarCon.TabStop = False
        Me.gbxRecargarCon.Text = "Precargar datos con:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Precargar datos con:"
        '
        'rbNA1
        '
        Me.rbNA1.AutoSize = True
        Me.rbNA1.Location = New System.Drawing.Point(175, 102)
        Me.rbNA1.Name = "rbNA1"
        Me.rbNA1.Size = New System.Drawing.Size(84, 20)
        Me.rbNA1.TabIndex = 3
        Me.rbNA1.Text = "No aplica"
        Me.rbNA1.UseVisualStyleBackColor = True
        '
        'rbF1
        '
        Me.rbF1.AutoSize = True
        Me.rbF1.Location = New System.Drawing.Point(33, 102)
        Me.rbF1.Name = "rbF1"
        Me.rbF1.Size = New System.Drawing.Size(56, 20)
        Me.rbF1.TabIndex = 2
        Me.rbF1.Text = "Falta"
        Me.rbF1.UseVisualStyleBackColor = True
        '
        'rbA1
        '
        Me.rbA1.AutoSize = True
        Me.rbA1.Location = New System.Drawing.Point(175, 50)
        Me.rbA1.Name = "rbA1"
        Me.rbA1.Size = New System.Drawing.Size(88, 20)
        Me.rbA1.TabIndex = 1
        Me.rbA1.Text = "Asistencia"
        Me.rbA1.UseVisualStyleBackColor = True
        '
        'rbProceso1
        '
        Me.rbProceso1.AutoSize = True
        Me.rbProceso1.Checked = True
        Me.rbProceso1.Location = New System.Drawing.Point(33, 50)
        Me.rbProceso1.Name = "rbProceso1"
        Me.rbProceso1.Size = New System.Drawing.Size(77, 20)
        Me.rbProceso1.TabIndex = 0
        Me.rbProceso1.TabStop = True
        Me.rbProceso1.Text = "Proceso"
        Me.rbProceso1.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(516, 155)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 28)
        Me.btnEliminar.TabIndex = 14
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnProcesar
        '
        Me.btnProcesar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcesar.ForeColor = System.Drawing.Color.White
        Me.btnProcesar.Location = New System.Drawing.Point(516, 121)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(75, 28)
        Me.btnProcesar.TabIndex = 13
        Me.btnProcesar.Text = "Procesar"
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(516, 87)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 28)
        Me.btnBuscar.TabIndex = 12
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtHoraFin
        '
        Me.txtHoraFin.Location = New System.Drawing.Point(247, 219)
        Me.txtHoraFin.Name = "txtHoraFin"
        Me.txtHoraFin.ReadOnly = True
        Me.txtHoraFin.Size = New System.Drawing.Size(100, 22)
        Me.txtHoraFin.TabIndex = 11
        '
        'txtHoraInicio
        '
        Me.txtHoraInicio.Location = New System.Drawing.Point(26, 219)
        Me.txtHoraInicio.Name = "txtHoraInicio"
        Me.txtHoraInicio.ReadOnly = True
        Me.txtHoraInicio.Size = New System.Drawing.Size(100, 22)
        Me.txtHoraInicio.TabIndex = 10
        '
        'lblHoraFin
        '
        Me.lblHoraFin.AutoSize = True
        Me.lblHoraFin.Location = New System.Drawing.Point(244, 203)
        Me.lblHoraFin.Name = "lblHoraFin"
        Me.lblHoraFin.Size = New System.Drawing.Size(57, 16)
        Me.lblHoraFin.TabIndex = 9
        Me.lblHoraFin.Text = "Hora fin:"
        '
        'lblHoraInicio
        '
        Me.lblHoraInicio.AutoSize = True
        Me.lblHoraInicio.Location = New System.Drawing.Point(23, 203)
        Me.lblHoraInicio.Name = "lblHoraInicio"
        Me.lblHoraInicio.Size = New System.Drawing.Size(75, 16)
        Me.lblHoraInicio.TabIndex = 8
        Me.lblHoraInicio.Text = "Hora inicio:"
        '
        'cboHorarios
        '
        Me.cboHorarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHorarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboHorarios.FormattingEnabled = True
        Me.cboHorarios.Location = New System.Drawing.Point(26, 160)
        Me.cboHorarios.Name = "cboHorarios"
        Me.cboHorarios.Size = New System.Drawing.Size(321, 24)
        Me.cboHorarios.TabIndex = 7
        '
        'lblHorario
        '
        Me.lblHorario.AutoSize = True
        Me.lblHorario.Location = New System.Drawing.Point(23, 144)
        Me.lblHorario.Name = "lblHorario"
        Me.lblHorario.Size = New System.Drawing.Size(138, 16)
        Me.lblHorario.TabIndex = 6
        Me.lblHorario.Text = "Seleccione el horario:"
        '
        'cboCursos
        '
        Me.cboCursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCursos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboCursos.FormattingEnabled = True
        Me.cboCursos.Location = New System.Drawing.Point(26, 108)
        Me.cboCursos.Name = "cboCursos"
        Me.cboCursos.Size = New System.Drawing.Size(321, 24)
        Me.cboCursos.TabIndex = 5
        '
        'txtDocente
        '
        Me.txtDocente.Location = New System.Drawing.Point(91, 56)
        Me.txtDocente.Name = "txtDocente"
        Me.txtDocente.ReadOnly = True
        Me.txtDocente.Size = New System.Drawing.Size(269, 22)
        Me.txtDocente.TabIndex = 4
        '
        'lblCurso
        '
        Me.lblCurso.AutoSize = True
        Me.lblCurso.Location = New System.Drawing.Point(23, 92)
        Me.lblCurso.Name = "lblCurso"
        Me.lblCurso.Size = New System.Drawing.Size(129, 16)
        Me.lblCurso.TabIndex = 3
        Me.lblCurso.Text = "Seleccione el curso:"
        '
        'lblDocente
        '
        Me.lblDocente.AutoSize = True
        Me.lblDocente.Location = New System.Drawing.Point(23, 59)
        Me.lblDocente.Name = "lblDocente"
        Me.lblDocente.Size = New System.Drawing.Size(62, 16)
        Me.lblDocente.TabIndex = 2
        Me.lblDocente.Text = "Docente:"
        '
        'txtPeriodo
        '
        Me.txtPeriodo.Location = New System.Drawing.Point(91, 28)
        Me.txtPeriodo.Name = "txtPeriodo"
        Me.txtPeriodo.ReadOnly = True
        Me.txtPeriodo.Size = New System.Drawing.Size(269, 22)
        Me.txtPeriodo.TabIndex = 1
        '
        'lblPeriodo
        '
        Me.lblPeriodo.AutoSize = True
        Me.lblPeriodo.Location = New System.Drawing.Point(26, 31)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(59, 16)
        Me.lblPeriodo.TabIndex = 0
        Me.lblPeriodo.Text = "Periodo:"
        '
        'frmControlAusentismos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(677, 736)
        Me.Controls.Add(Me.panelPrincipal)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmControlAusentismos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.panelPrincipal.ResumeLayout(False)
        CType(Me.gvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxFiltros.ResumeLayout(False)
        Me.gbxFiltros.PerformLayout()
        Me.gbxRecargarFaltas.ResumeLayout(False)
        Me.gbxRecargarFaltas.PerformLayout()
        Me.gbxRecargarCon.ResumeLayout(False)
        Me.gbxRecargarCon.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelPrincipal As System.Windows.Forms.Panel
    Friend WithEvents gbxFiltros As System.Windows.Forms.GroupBox
    Friend WithEvents cboHorarios As System.Windows.Forms.ComboBox
    Friend WithEvents lblHorario As System.Windows.Forms.Label
    Friend WithEvents cboCursos As System.Windows.Forms.ComboBox
    Friend WithEvents txtDocente As System.Windows.Forms.TextBox
    Friend WithEvents lblCurso As System.Windows.Forms.Label
    Friend WithEvents lblDocente As System.Windows.Forms.Label
    Friend WithEvents txtPeriodo As System.Windows.Forms.TextBox
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents txtHoraFin As System.Windows.Forms.TextBox
    Friend WithEvents txtHoraInicio As System.Windows.Forms.TextBox
    Friend WithEvents lblHoraFin As System.Windows.Forms.Label
    Friend WithEvents lblHoraInicio As System.Windows.Forms.Label
    Friend WithEvents gbxRecargarFaltas As System.Windows.Forms.GroupBox
    Friend WithEvents rbNA2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbA2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbJ2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbF2 As System.Windows.Forms.RadioButton
    Friend WithEvents gbxRecargarCon As System.Windows.Forms.GroupBox
    Friend WithEvents rbNA1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbF1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbA1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbProceso1 As System.Windows.Forms.RadioButton
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnProcesar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents gvDatos As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
