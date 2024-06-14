<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SettingsForm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.HScrollBarDiff = New System.Windows.Forms.HScrollBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBoxCurrentValue = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.radioEasy = New System.Windows.Forms.RadioButton()
        Me.radioNormal = New System.Windows.Forms.RadioButton()
        Me.radioHard = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HScrollBarDiff
        '
        Me.HScrollBarDiff.Location = New System.Drawing.Point(52, 21)
        Me.HScrollBarDiff.Name = "HScrollBarDiff"
        Me.HScrollBarDiff.Size = New System.Drawing.Size(581, 61)
        Me.HScrollBarDiff.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Tomato
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Controls.Add(Me.HScrollBarDiff)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(61, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(685, 100)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'TextBoxCurrentValue
        '
        Me.TextBoxCurrentValue.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCurrentValue.Location = New System.Drawing.Point(255, 162)
        Me.TextBoxCurrentValue.Name = "TextBoxCurrentValue"
        Me.TextBoxCurrentValue.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxCurrentValue.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nombre de cases vide : "
        '
        'radioEasy
        '
        Me.radioEasy.AutoSize = True
        Me.radioEasy.BackColor = System.Drawing.Color.Transparent
        Me.radioEasy.ForeColor = System.Drawing.Color.White
        Me.radioEasy.Location = New System.Drawing.Point(18, 35)
        Me.radioEasy.Name = "radioEasy"
        Me.radioEasy.Size = New System.Drawing.Size(72, 23)
        Me.radioEasy.TabIndex = 5
        Me.radioEasy.TabStop = True
        Me.radioEasy.Text = "Facile"
        Me.radioEasy.UseVisualStyleBackColor = False
        '
        'radioNormal
        '
        Me.radioNormal.AutoSize = True
        Me.radioNormal.ForeColor = System.Drawing.Color.White
        Me.radioNormal.Location = New System.Drawing.Point(18, 68)
        Me.radioNormal.Name = "radioNormal"
        Me.radioNormal.Size = New System.Drawing.Size(91, 23)
        Me.radioNormal.TabIndex = 6
        Me.radioNormal.TabStop = True
        Me.radioNormal.Text = "Normale"
        Me.radioNormal.UseVisualStyleBackColor = True
        '
        'radioHard
        '
        Me.radioHard.AutoSize = True
        Me.radioHard.ForeColor = System.Drawing.Color.White
        Me.radioHard.Location = New System.Drawing.Point(18, 103)
        Me.radioHard.Name = "radioHard"
        Me.radioHard.Size = New System.Drawing.Size(83, 23)
        Me.radioHard.TabIndex = 7
        Me.radioHard.TabStop = True
        Me.radioHard.Text = "Difficile"
        Me.radioHard.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Tomato
        Me.GroupBox2.Controls.Add(Me.radioEasy)
        Me.GroupBox2.Controls.Add(Me.radioHard)
        Me.GroupBox2.Controls.Add(Me.radioNormal)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(61, 232)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(232, 144)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Choix de la difficulté"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(577, 277)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(43, 26)
        Me.NumericUpDown1.TabIndex = 9
        Me.NumericUpDown1.Value = New Decimal(New Integer() {7, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(499, 279)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 19)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Temps :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(625, 279)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 19)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "minutes"
        '
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxCurrentValue)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "SettingsForm"
        Me.Text = "Paramettre"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HScrollBarDiff As HScrollBar
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBoxCurrentValue As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents radioEasy As RadioButton
    Friend WithEvents radioNormal As RadioButton
    Friend WithEvents radioHard As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
