<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Jeu
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnAbandonner = New System.Windows.Forms.Button()
        Me.lblJoueur = New System.Windows.Forms.Label()
        Me.lblTempsRestant = New System.Windows.Forms.Label()
        Me.btnPause = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAbandonner
        '
        Me.btnAbandonner.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbandonner.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAbandonner.Location = New System.Drawing.Point(660, 459)
        Me.btnAbandonner.Name = "btnAbandonner"
        Me.btnAbandonner.Size = New System.Drawing.Size(128, 45)
        Me.btnAbandonner.TabIndex = 4
        Me.btnAbandonner.Text = "Abandonner"
        Me.btnAbandonner.UseVisualStyleBackColor = True
        '
        'lblJoueur
        '
        Me.lblJoueur.AutoSize = True
        Me.lblJoueur.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJoueur.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblJoueur.Location = New System.Drawing.Point(12, 9)
        Me.lblJoueur.Name = "lblJoueur"
        Me.lblJoueur.Size = New System.Drawing.Size(170, 19)
        Me.lblJoueur.TabIndex = 5
        Me.lblJoueur.Text = "Joueur: ABD LeBoss"
        '
        'lblTempsRestant
        '
        Me.lblTempsRestant.AutoSize = True
        Me.lblTempsRestant.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTempsRestant.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTempsRestant.Location = New System.Drawing.Point(190, 9)
        Me.lblTempsRestant.Name = "lblTempsRestant"
        Me.lblTempsRestant.Size = New System.Drawing.Size(131, 19)
        Me.lblTempsRestant.TabIndex = 6
        Me.lblTempsRestant.Text = "Temps restant : "
        '
        'btnPause
        '
        Me.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPause.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnPause.Location = New System.Drawing.Point(482, 459)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(128, 45)
        Me.btnPause.TabIndex = 7
        Me.btnPause.Text = "Pause"
        Me.btnPause.UseVisualStyleBackColor = True
        '
        'Jeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 516)
        Me.Controls.Add(Me.btnPause)
        Me.Controls.Add(Me.lblTempsRestant)
        Me.Controls.Add(Me.lblJoueur)
        Me.Controls.Add(Me.btnAbandonner)
        Me.Name = "Jeu"
        Me.Text = "Jeu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAbandonner As Button
    Friend WithEvents lblJoueur As Label
    Friend WithEvents lblTempsRestant As Label
    Friend WithEvents btnPause As Button
End Class
