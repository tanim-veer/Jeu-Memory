<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmThemes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmThemes))
        Me.btnOptions = New System.Windows.Forms.Button()
        Me.btnCinema = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnJouer = New System.Windows.Forms.Button()
        Me.rb90Sec = New System.Windows.Forms.RadioButton()
        Me.rb60Sec = New System.Windows.Forms.RadioButton()
        Me.rb30Sec = New System.Windows.Forms.RadioButton()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOptions
        '
        Me.btnOptions.BackColor = System.Drawing.Color.Transparent
        Me.btnOptions.Location = New System.Drawing.Point(193, 204)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(95, 32)
        Me.btnOptions.TabIndex = 21
        Me.btnOptions.Text = "FastFood"
        Me.btnOptions.UseVisualStyleBackColor = False
        '
        'btnCinema
        '
        Me.btnCinema.BackColor = System.Drawing.Color.Transparent
        Me.btnCinema.Location = New System.Drawing.Point(12, 204)
        Me.btnCinema.Name = "btnCinema"
        Me.btnCinema.Size = New System.Drawing.Size(88, 32)
        Me.btnCinema.TabIndex = 20
        Me.btnCinema.Text = "Cinema"
        Me.btnCinema.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(0, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(296, 31)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "🧠 Memory Theme 🧠"
        '
        'btnQuitter
        '
        Me.btnQuitter.BackColor = System.Drawing.Color.Transparent
        Me.btnQuitter.Location = New System.Drawing.Point(167, 352)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(56, 24)
        Me.btnQuitter.TabIndex = 23
        Me.btnQuitter.Text = "Retour"
        Me.btnQuitter.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Location = New System.Drawing.Point(68, 77)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(161, 112)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'btnJouer
        '
        Me.btnJouer.BackColor = System.Drawing.Color.Transparent
        Me.btnJouer.Location = New System.Drawing.Point(75, 353)
        Me.btnJouer.Name = "btnJouer"
        Me.btnJouer.Size = New System.Drawing.Size(54, 23)
        Me.btnJouer.TabIndex = 25
        Me.btnJouer.Text = "Jouer"
        Me.btnJouer.UseVisualStyleBackColor = False
        '
        'rb90Sec
        '
        Me.rb90Sec.AutoSize = True
        Me.rb90Sec.BackColor = System.Drawing.Color.Transparent
        Me.rb90Sec.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rb90Sec.Location = New System.Drawing.Point(103, 244)
        Me.rb90Sec.Name = "rb90Sec"
        Me.rb90Sec.Size = New System.Drawing.Size(86, 17)
        Me.rb90Sec.TabIndex = 26
        Me.rb90Sec.Text = "90 secondes"
        Me.rb90Sec.UseVisualStyleBackColor = False
        '
        'rb60Sec
        '
        Me.rb60Sec.AutoSize = True
        Me.rb60Sec.BackColor = System.Drawing.Color.Transparent
        Me.rb60Sec.Checked = True
        Me.rb60Sec.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rb60Sec.Location = New System.Drawing.Point(103, 267)
        Me.rb60Sec.Name = "rb60Sec"
        Me.rb60Sec.Size = New System.Drawing.Size(86, 17)
        Me.rb60Sec.TabIndex = 27
        Me.rb60Sec.TabStop = True
        Me.rb60Sec.Text = "60 secondes"
        Me.rb60Sec.UseVisualStyleBackColor = False
        '
        'rb30Sec
        '
        Me.rb30Sec.AutoSize = True
        Me.rb30Sec.BackColor = System.Drawing.Color.Transparent
        Me.rb30Sec.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rb30Sec.Location = New System.Drawing.Point(103, 289)
        Me.rb30Sec.Name = "rb30Sec"
        Me.rb30Sec.Size = New System.Drawing.Size(86, 17)
        Me.rb30Sec.TabIndex = 28
        Me.rb30Sec.Text = "30 secondes"
        Me.rb30Sec.UseVisualStyleBackColor = False
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(259, 43)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(37, 15)
        Me.AxWindowsMediaPlayer1.TabIndex = 84
        Me.AxWindowsMediaPlayer1.Visible = False
        '
        'frmThemes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.BackgroundImage = Global.SAE_DE_IHM.My.Resources.Resources.cinema5
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(300, 388)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.rb30Sec)
        Me.Controls.Add(Me.rb60Sec)
        Me.Controls.Add(Me.rb90Sec)
        Me.Controls.Add(Me.btnJouer)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.btnOptions)
        Me.Controls.Add(Me.btnCinema)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmThemes"
        Me.Text = "Memory"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOptions As Button
    Friend WithEvents btnCinema As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnQuitter As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnJouer As Button
    Friend WithEvents rb90Sec As RadioButton
    Friend WithEvents rb60Sec As RadioButton
    Friend WithEvents rb30Sec As RadioButton
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
End Class
