<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REiS
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(REiS))
        Me.lblWinInfo = New System.Windows.Forms.Label()
        Me.lblPatchInfo = New System.Windows.Forms.Label()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.lblKiller = New System.Windows.Forms.Label()
        Me.RichKill = New System.Windows.Forms.RichTextBox()
        Me.RichPatch = New System.Windows.Forms.RichTextBox()
        Me.SelectProducts = New System.Windows.Forms.ComboBox()
        Me.lblPlatform = New System.Windows.Forms.Label()
        Me.lblWindows = New System.Windows.Forms.Label()
        Me.lblInfoVersion = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.btnPatch = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnKill = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWinInfo
        '
        Me.lblWinInfo.AutoSize = True
        Me.lblWinInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblWinInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblWinInfo.Location = New System.Drawing.Point(34, 185)
        Me.lblWinInfo.Name = "lblWinInfo"
        Me.lblWinInfo.Size = New System.Drawing.Size(71, 13)
        Me.lblWinInfo.TabIndex = 0
        Me.lblWinInfo.Text = "Windows Info"
        Me.lblWinInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPatchInfo
        '
        Me.lblPatchInfo.AutoSize = True
        Me.lblPatchInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblPatchInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblPatchInfo.Location = New System.Drawing.Point(35, 226)
        Me.lblPatchInfo.Name = "lblPatchInfo"
        Me.lblPatchInfo.Size = New System.Drawing.Size(54, 13)
        Me.lblPatchInfo.TabIndex = 1
        Me.lblPatchInfo.Text = "Patch Info"
        Me.lblPatchInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.BackColor = System.Drawing.Color.Transparent
        Me.lblStart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblStart.Location = New System.Drawing.Point(170, 185)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(73, 13)
        Me.lblStart.TabIndex = 2
        Me.lblStart.Text = "Start Patching"
        Me.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblKiller
        '
        Me.lblKiller.AutoSize = True
        Me.lblKiller.BackColor = System.Drawing.Color.Transparent
        Me.lblKiller.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblKiller.Location = New System.Drawing.Point(167, 277)
        Me.lblKiller.Name = "lblKiller"
        Me.lblKiller.Size = New System.Drawing.Size(61, 13)
        Me.lblKiller.TabIndex = 3
        Me.lblKiller.Text = "Kill Process"
        Me.lblKiller.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RichKill
        '
        Me.RichKill.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichKill.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.RichKill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RichKill.ForeColor = System.Drawing.Color.White
        Me.RichKill.Location = New System.Drawing.Point(168, 296)
        Me.RichKill.Name = "RichKill"
        Me.RichKill.ReadOnly = True
        Me.RichKill.ShortcutsEnabled = False
        Me.RichKill.Size = New System.Drawing.Size(194, 56)
        Me.RichKill.TabIndex = 4
        Me.RichKill.TabStop = False
        Me.RichKill.Text = ""
        '
        'RichPatch
        '
        Me.RichPatch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichPatch.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.RichPatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RichPatch.ForeColor = System.Drawing.Color.White
        Me.RichPatch.Location = New System.Drawing.Point(168, 231)
        Me.RichPatch.Name = "RichPatch"
        Me.RichPatch.ReadOnly = True
        Me.RichPatch.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RichPatch.ShortcutsEnabled = False
        Me.RichPatch.Size = New System.Drawing.Size(194, 29)
        Me.RichPatch.TabIndex = 5
        Me.RichPatch.TabStop = False
        Me.RichPatch.Text = ""
        '
        'SelectProducts
        '
        Me.SelectProducts.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.SelectProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SelectProducts.ForeColor = System.Drawing.Color.White
        Me.SelectProducts.FormattingEnabled = True
        Me.SelectProducts.Location = New System.Drawing.Point(168, 204)
        Me.SelectProducts.Name = "SelectProducts"
        Me.SelectProducts.Size = New System.Drawing.Size(197, 21)
        Me.SelectProducts.TabIndex = 6
        Me.SelectProducts.TabStop = False
        '
        'lblPlatform
        '
        Me.lblPlatform.AutoSize = True
        Me.lblPlatform.BackColor = System.Drawing.Color.Transparent
        Me.lblPlatform.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlatform.ForeColor = System.Drawing.Color.White
        Me.lblPlatform.Location = New System.Drawing.Point(38, 200)
        Me.lblPlatform.Name = "lblPlatform"
        Me.lblPlatform.Size = New System.Drawing.Size(50, 13)
        Me.lblPlatform.TabIndex = 7
        Me.lblPlatform.Text = "Platform:"
        Me.lblPlatform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWindows
        '
        Me.lblWindows.AutoSize = True
        Me.lblWindows.BackColor = System.Drawing.Color.Transparent
        Me.lblWindows.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWindows.ForeColor = System.Drawing.Color.White
        Me.lblWindows.Location = New System.Drawing.Point(89, 200)
        Me.lblWindows.Name = "lblWindows"
        Me.lblWindows.Size = New System.Drawing.Size(45, 13)
        Me.lblWindows.TabIndex = 8
        Me.lblWindows.Text = "Win XxX"
        Me.lblWindows.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInfoVersion
        '
        Me.lblInfoVersion.AutoSize = True
        Me.lblInfoVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblInfoVersion.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoVersion.ForeColor = System.Drawing.Color.White
        Me.lblInfoVersion.Location = New System.Drawing.Point(38, 241)
        Me.lblInfoVersion.Name = "lblInfoVersion"
        Me.lblInfoVersion.Size = New System.Drawing.Size(45, 13)
        Me.lblInfoVersion.TabIndex = 9
        Me.lblInfoVersion.Text = "Version:"
        Me.lblInfoVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(40, 254)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Built in:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblVersion.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.ForeColor = System.Drawing.Color.White
        Me.lblVersion.Location = New System.Drawing.Point(89, 241)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(40, 13)
        Me.lblVersion.TabIndex = 11
        Me.lblVersion.Text = "1.0.0.0"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(89, 254)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(49, 13)
        Me.lblDate.TabIndex = 12
        Me.lblDate.Text = "Jan 2014"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPatch
        '
        Me.btnPatch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPatch.BackColor = System.Drawing.Color.Transparent
        Me.btnPatch.BackgroundImage = Global.Cyberlink_Software.My.Resources.Resources.patch_button
        Me.btnPatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPatch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPatch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnPatch.Location = New System.Drawing.Point(53, 278)
        Me.btnPatch.Name = "btnPatch"
        Me.btnPatch.Size = New System.Drawing.Size(76, 24)
        Me.btnPatch.TabIndex = 13
        Me.btnPatch.TabStop = False
        Me.btnPatch.UseVisualStyleBackColor = False
        '
        'btnAbout
        '
        Me.btnAbout.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAbout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAbout.BackColor = System.Drawing.Color.Transparent
        Me.btnAbout.BackgroundImage = Global.Cyberlink_Software.My.Resources.Resources.about_button
        Me.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnAbout.Location = New System.Drawing.Point(53, 308)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(76, 24)
        Me.btnAbout.TabIndex = 14
        Me.btnAbout.TabStop = False
        Me.btnAbout.UseVisualStyleBackColor = False
        '
        'btnKill
        '
        Me.btnKill.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnKill.BackColor = System.Drawing.Color.Transparent
        Me.btnKill.BackgroundImage = Global.Cyberlink_Software.My.Resources.Resources.killer_button
        Me.btnKill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnKill.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKill.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnKill.Location = New System.Drawing.Point(53, 338)
        Me.btnKill.Name = "btnKill"
        Me.btnKill.Size = New System.Drawing.Size(76, 24)
        Me.btnKill.TabIndex = 15
        Me.btnKill.TabStop = False
        Me.btnKill.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(396, 183)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'REiS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(396, 372)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnKill)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnPatch)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblInfoVersion)
        Me.Controls.Add(Me.lblWindows)
        Me.Controls.Add(Me.lblPlatform)
        Me.Controls.Add(Me.SelectProducts)
        Me.Controls.Add(Me.RichPatch)
        Me.Controls.Add(Me.RichKill)
        Me.Controls.Add(Me.lblKiller)
        Me.Controls.Add(Me.lblStart)
        Me.Controls.Add(Me.lblPatchInfo)
        Me.Controls.Add(Me.lblWinInfo)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "REiS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "[Multi-Patch] Cyberlink Software [REiS]"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblWinInfo As System.Windows.Forms.Label
    Friend WithEvents lblPatchInfo As System.Windows.Forms.Label
    Friend WithEvents lblStart As System.Windows.Forms.Label
    Friend WithEvents lblKiller As System.Windows.Forms.Label
    Friend WithEvents RichKill As System.Windows.Forms.RichTextBox
    Friend WithEvents RichPatch As System.Windows.Forms.RichTextBox
    Friend WithEvents SelectProducts As System.Windows.Forms.ComboBox
    Friend WithEvents lblPlatform As System.Windows.Forms.Label
    Friend WithEvents lblWindows As System.Windows.Forms.Label
    Friend WithEvents lblInfoVersion As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents btnPatch As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents btnKill As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
