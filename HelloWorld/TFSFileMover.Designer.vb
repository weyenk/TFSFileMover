<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileMover
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MoveButton = New System.Windows.Forms.Button()
        Me.CnlButton = New System.Windows.Forms.Button()
        Me.FromTB = New System.Windows.Forms.TextBox()
        Me.ToTB = New System.Windows.Forms.TextBox()
        Me.FromBrwoseButton = New System.Windows.Forms.Button()
        Me.ToBrowseButton = New System.Windows.Forms.Button()
        Me.FromOFD = New System.Windows.Forms.OpenFileDialog()
        Me.ToFBD = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'MoveButton
        '
        Me.MoveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MoveButton.FlatAppearance.BorderSize = 2
        Me.MoveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MoveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.MoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MoveButton.Location = New System.Drawing.Point(168, 75)
        Me.MoveButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MoveButton.Name = "MoveButton"
        Me.MoveButton.Size = New System.Drawing.Size(87, 28)
        Me.MoveButton.TabIndex = 0
        Me.MoveButton.TabStop = False
        Me.MoveButton.Text = "Move Files"
        Me.MoveButton.UseVisualStyleBackColor = True
        '
        'CnlButton
        '
        Me.CnlButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CnlButton.FlatAppearance.BorderSize = 2
        Me.CnlButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.CnlButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.CnlButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CnlButton.Location = New System.Drawing.Point(261, 75)
        Me.CnlButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CnlButton.Name = "CnlButton"
        Me.CnlButton.Size = New System.Drawing.Size(87, 28)
        Me.CnlButton.TabIndex = 1
        Me.CnlButton.TabStop = False
        Me.CnlButton.Text = "Cancel"
        Me.CnlButton.UseVisualStyleBackColor = True
        '
        'FromTB
        '
        Me.FromTB.AllowDrop = True
        Me.FromTB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FromTB.Location = New System.Drawing.Point(12, 12)
        Me.FromTB.Name = "FromTB"
        Me.FromTB.ReadOnly = True
        Me.FromTB.Size = New System.Drawing.Size(243, 25)
        Me.FromTB.TabIndex = 1
        Me.FromTB.Text = "From"
        '
        'ToTB
        '
        Me.ToTB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToTB.Location = New System.Drawing.Point(12, 43)
        Me.ToTB.Name = "ToTB"
        Me.ToTB.ReadOnly = True
        Me.ToTB.Size = New System.Drawing.Size(243, 25)
        Me.ToTB.TabIndex = 2
        Me.ToTB.Text = "To"
        '
        'FromBrwoseButton
        '
        Me.FromBrwoseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FromBrwoseButton.FlatAppearance.BorderSize = 2
        Me.FromBrwoseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.FromBrwoseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.FromBrwoseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FromBrwoseButton.Location = New System.Drawing.Point(261, 9)
        Me.FromBrwoseButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FromBrwoseButton.Name = "FromBrwoseButton"
        Me.FromBrwoseButton.Size = New System.Drawing.Size(87, 28)
        Me.FromBrwoseButton.TabIndex = 5
        Me.FromBrwoseButton.TabStop = False
        Me.FromBrwoseButton.Text = "Browse..."
        Me.FromBrwoseButton.UseVisualStyleBackColor = True
        '
        'ToBrowseButton
        '
        Me.ToBrowseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToBrowseButton.FlatAppearance.BorderSize = 2
        Me.ToBrowseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.ToBrowseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.ToBrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ToBrowseButton.Location = New System.Drawing.Point(261, 40)
        Me.ToBrowseButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ToBrowseButton.Name = "ToBrowseButton"
        Me.ToBrowseButton.Size = New System.Drawing.Size(87, 28)
        Me.ToBrowseButton.TabIndex = 6
        Me.ToBrowseButton.TabStop = False
        Me.ToBrowseButton.Text = "Browse..."
        Me.ToBrowseButton.UseMnemonic = False
        Me.ToBrowseButton.UseVisualStyleBackColor = True
        '
        'FromOFD
        '
        Me.FromOFD.Filter = "Kapow Robots|*.robot|All Files|*.*"
        Me.FromOFD.InitialDirectory = "c:\"
        Me.FromOFD.Tag = ""
        '
        'ToFBD
        '
        Me.ToFBD.ShowNewFolderButton = False
        '
        'FileMover
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(364, 119)
        Me.Controls.Add(Me.ToBrowseButton)
        Me.Controls.Add(Me.FromBrwoseButton)
        Me.Controls.Add(Me.ToTB)
        Me.Controls.Add(Me.FromTB)
        Me.Controls.Add(Me.CnlButton)
        Me.Controls.Add(Me.MoveButton)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximumSize = New System.Drawing.Size(380, 158)
        Me.MinimumSize = New System.Drawing.Size(380, 158)
        Me.Name = "FileMover"
        Me.Text = "TFS File Mover"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MoveButton As System.Windows.Forms.Button
    Friend WithEvents CnlButton As System.Windows.Forms.Button
    Friend WithEvents FromTB As System.Windows.Forms.TextBox
    Friend WithEvents ToTB As System.Windows.Forms.TextBox
    Friend WithEvents FromBrwoseButton As System.Windows.Forms.Button
    Friend WithEvents ToBrowseButton As System.Windows.Forms.Button
    Friend WithEvents FromOFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ToFBD As System.Windows.Forms.FolderBrowserDialog

End Class
