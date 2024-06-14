<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StatisticsForm
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
        Me.PlayerListBox = New System.Windows.Forms.ListBox()
        Me.TimeListBox = New System.Windows.Forms.ListBox()
        Me.cmbPlayerNames = New System.Windows.Forms.ComboBox()
        Me.btnShowStats = New System.Windows.Forms.Button()
        Me.btnSortByName = New System.Windows.Forms.Button()
        Me.btnSortByTime = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PlayerListBox
        '
        Me.PlayerListBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlayerListBox.BackColor = System.Drawing.Color.Tomato
        Me.PlayerListBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PlayerListBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PlayerListBox.ForeColor = System.Drawing.SystemColors.Window
        Me.PlayerListBox.FormattingEnabled = True
        Me.PlayerListBox.ItemHeight = 19
        Me.PlayerListBox.Location = New System.Drawing.Point(10, 71)
        Me.PlayerListBox.Name = "PlayerListBox"
        Me.PlayerListBox.Size = New System.Drawing.Size(330, 266)
        Me.PlayerListBox.TabIndex = 0
        '
        'TimeListBox
        '
        Me.TimeListBox.BackColor = System.Drawing.Color.Tomato
        Me.TimeListBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TimeListBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TimeListBox.ForeColor = System.Drawing.SystemColors.Window
        Me.TimeListBox.FormattingEnabled = True
        Me.TimeListBox.ItemHeight = 19
        Me.TimeListBox.Location = New System.Drawing.Point(339, 71)
        Me.TimeListBox.Name = "TimeListBox"
        Me.TimeListBox.Size = New System.Drawing.Size(336, 266)
        Me.TimeListBox.TabIndex = 1
        '
        'cmbPlayerNames
        '
        Me.cmbPlayerNames.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cmbPlayerNames.FormattingEnabled = True
        Me.cmbPlayerNames.Location = New System.Drawing.Point(10, 373)
        Me.cmbPlayerNames.Name = "cmbPlayerNames"
        Me.cmbPlayerNames.Size = New System.Drawing.Size(331, 27)
        Me.cmbPlayerNames.TabIndex = 2
        '
        'btnShowStats
        '
        Me.btnShowStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowStats.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnShowStats.Location = New System.Drawing.Point(10, 411)
        Me.btnShowStats.Name = "btnShowStats"
        Me.btnShowStats.Size = New System.Drawing.Size(212, 41)
        Me.btnShowStats.TabIndex = 3
        Me.btnShowStats.Text = "Voir Statistiques"
        Me.btnShowStats.UseVisualStyleBackColor = True
        '
        'btnSortByName
        '
        Me.btnSortByName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSortByName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSortByName.Location = New System.Drawing.Point(63, 27)
        Me.btnSortByName.Name = "btnSortByName"
        Me.btnSortByName.Size = New System.Drawing.Size(186, 32)
        Me.btnSortByName.TabIndex = 4
        Me.btnSortByName.Text = "Trier par nom"
        Me.btnSortByName.UseVisualStyleBackColor = True
        '
        'btnSortByTime
        '
        Me.btnSortByTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSortByTime.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSortByTime.Location = New System.Drawing.Point(435, 27)
        Me.btnSortByTime.Name = "btnSortByTime"
        Me.btnSortByTime.Size = New System.Drawing.Size(186, 32)
        Me.btnSortByTime.TabIndex = 5
        Me.btnSortByTime.Text = "Trier par temps"
        Me.btnSortByTime.UseVisualStyleBackColor = True
        '
        'StatisticsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 464)
        Me.Controls.Add(Me.btnSortByTime)
        Me.Controls.Add(Me.btnSortByName)
        Me.Controls.Add(Me.btnShowStats)
        Me.Controls.Add(Me.cmbPlayerNames)
        Me.Controls.Add(Me.TimeListBox)
        Me.Controls.Add(Me.PlayerListBox)
        Me.Name = "StatisticsForm"
        Me.Text = "Tableau des Scores"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PlayerListBox As ListBox
    Friend WithEvents TimeListBox As ListBox
    Friend WithEvents PlayerComboBox As ComboBox
    Friend WithEvents ShowPlayerStatsButton As Button
    Friend WithEvents cmbPlayerNames As ComboBox
    Friend WithEvents btnShowStats As Button
    Friend WithEvents btnSortByName As Button
    Friend WithEvents btnSortByTime As Button
End Class