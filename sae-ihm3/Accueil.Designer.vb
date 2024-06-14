<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Accueil
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Me.cmbPlayerNames = New System.Windows.Forms.ComboBox()
        Me.btnNewGame = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnScores = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbPlayerNames
        '
        Me.cmbPlayerNames.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbPlayerNames.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cmbPlayerNames.FormattingEnabled = True
        Me.cmbPlayerNames.Location = New System.Drawing.Point(237, 88)
        Me.cmbPlayerNames.Name = "cmbPlayerNames"
        Me.cmbPlayerNames.Size = New System.Drawing.Size(213, 27)
        Me.cmbPlayerNames.TabIndex = 0
        '
        'btnNewGame
        '
        Me.btnNewGame.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNewGame.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnNewGame.Location = New System.Drawing.Point(237, 168)
        Me.btnNewGame.Name = "btnNewGame"
        Me.btnNewGame.Size = New System.Drawing.Size(213, 30)
        Me.btnNewGame.TabIndex = 1
        Me.btnNewGame.Text = "Jouer"
        Me.btnNewGame.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnQuit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnQuit.Location = New System.Drawing.Point(591, 349)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(69, 30)
        Me.btnQuit.TabIndex = 2
        Me.btnQuit.Text = "Quitter"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnScores
        '
        Me.btnScores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnScores.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnScores.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnScores.Location = New System.Drawing.Point(237, 217)
        Me.btnScores.Name = "btnScores"
        Me.btnScores.Size = New System.Drawing.Size(213, 30)
        Me.btnScores.TabIndex = 3
        Me.btnScores.Text = "Scores"
        Me.btnScores.UseVisualStyleBackColor = True
        '
        'btnSettings
        '
        Me.btnSettings.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSettings.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSettings.Location = New System.Drawing.Point(237, 262)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(213, 30)
        Me.btnSettings.TabIndex = 4
        Me.btnSettings.Text = "Paramètres"
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(686, 390)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.btnScores)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnNewGame)
        Me.Controls.Add(Me.cmbPlayerNames)
        Me.Name = "Accueil"
        Me.Text = "Sudoku"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmbPlayerNames As ComboBox
    Friend WithEvents btnNewGame As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents btnScores As Button
    Friend WithEvents ScoreListBox As ListBox
    Friend WithEvents btnSettings As Button
End Class
