<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutREiS
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

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutREiS))
        Me.lblAboutREiS = New System.Windows.Forms.Label()
        Me.lblREiS = New System.Windows.Forms.Label()
        Me.lblGreets = New System.Windows.Forms.Label()
        Me.lblMultiPatch = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblAboutREiS
        '
        Me.lblAboutREiS.AutoSize = True
        Me.lblAboutREiS.BackColor = System.Drawing.Color.Transparent
        Me.lblAboutREiS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblAboutREiS.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAboutREiS.ForeColor = System.Drawing.Color.White
        Me.lblAboutREiS.Location = New System.Drawing.Point(12, 9)
        Me.lblAboutREiS.Name = "lblAboutREiS"
        Me.lblAboutREiS.Size = New System.Drawing.Size(215, 234)
        Me.lblAboutREiS.TabIndex = 1
        Me.lblAboutREiS.Text = resources.GetString("lblAboutREiS.Text")
        Me.lblAboutREiS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblREiS
        '
        Me.lblREiS.AutoSize = True
        Me.lblREiS.BackColor = System.Drawing.Color.Transparent
        Me.lblREiS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblREiS.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblREiS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblREiS.Location = New System.Drawing.Point(34, 9)
        Me.lblREiS.Name = "lblREiS"
        Me.lblREiS.Size = New System.Drawing.Size(175, 52)
        Me.lblREiS.TabIndex = 2
        Me.lblREiS.Text = "=====================" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Reverse Engineering iN Software" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "=====================" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "[R" & _
    "EiS]"
        Me.lblREiS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGreets
        '
        Me.lblGreets.AutoSize = True
        Me.lblGreets.BackColor = System.Drawing.Color.Transparent
        Me.lblGreets.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblGreets.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGreets.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblGreets.Location = New System.Drawing.Point(12, 204)
        Me.lblGreets.Name = "lblGreets"
        Me.lblGreets.Size = New System.Drawing.Size(215, 39)
        Me.lblGreets.TabIndex = 3
        Me.lblGreets.Text = "==========================" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "URET, TSRh, REPT, Cin1team and others." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "=============" & _
    "============="
        Me.lblGreets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMultiPatch
        '
        Me.lblMultiPatch.AutoSize = True
        Me.lblMultiPatch.BackColor = System.Drawing.Color.Transparent
        Me.lblMultiPatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblMultiPatch.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMultiPatch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblMultiPatch.Location = New System.Drawing.Point(39, 87)
        Me.lblMultiPatch.Name = "lblMultiPatch"
        Me.lblMultiPatch.Size = New System.Drawing.Size(167, 39)
        Me.lblMultiPatch.TabIndex = 4
        Me.lblMultiPatch.Text = "====================" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cyberlink Software Multi-Patch" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "===================="
        Me.lblMultiPatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AboutREiS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.BackgroundImage = Global.Cyberlink_Software.My.Resources.Resources.AboutDiag
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(239, 252)
        Me.Controls.Add(Me.lblMultiPatch)
        Me.Controls.Add(Me.lblGreets)
        Me.Controls.Add(Me.lblREiS)
        Me.Controls.Add(Me.lblAboutREiS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutREiS"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "-= About Multi-Patch [REiS] =-"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAboutREiS As System.Windows.Forms.Label
    Friend WithEvents lblREiS As System.Windows.Forms.Label
    Friend WithEvents lblGreets As System.Windows.Forms.Label
    Friend WithEvents lblMultiPatch As System.Windows.Forms.Label
End Class
