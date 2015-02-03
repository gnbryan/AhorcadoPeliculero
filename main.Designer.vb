<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_main
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
        Me.btn_1player = New System.Windows.Forms.Button
        Me.lbl_titulo = New System.Windows.Forms.Label
        Me.btn_2players = New System.Windows.Forms.Button
        Me.btn_salir = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btn_1player
        '
        Me.btn_1player.Location = New System.Drawing.Point(60, 94)
        Me.btn_1player.Name = "btn_1player"
        Me.btn_1player.Size = New System.Drawing.Size(75, 23)
        Me.btn_1player.TabIndex = 1
        Me.btn_1player.Text = "1 jugador"
        Me.btn_1player.UseVisualStyleBackColor = True
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.BackColor = System.Drawing.SystemColors.ControlText
        Me.lbl_titulo.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.ForeColor = System.Drawing.Color.LawnGreen
        Me.lbl_titulo.Location = New System.Drawing.Point(46, 36)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(98, 22)
        Me.lbl_titulo.TabIndex = 3
        Me.lbl_titulo.Text = "AHORCADO"
        '
        'btn_2players
        '
        Me.btn_2players.Location = New System.Drawing.Point(60, 133)
        Me.btn_2players.Name = "btn_2players"
        Me.btn_2players.Size = New System.Drawing.Size(75, 23)
        Me.btn_2players.TabIndex = 4
        Me.btn_2players.Text = "2 jugadores"
        Me.btn_2players.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(60, 173)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(75, 23)
        Me.btn_salir.TabIndex = 5
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AhorcadoPeliculero.My.Resources.Resources.matrix
        Me.ClientSize = New System.Drawing.Size(198, 217)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_2players)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.btn_1player)
        Me.IsMdiContainer = True
        Me.Name = "frm_main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_1player As System.Windows.Forms.Button
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents btn_2players As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button

End Class
