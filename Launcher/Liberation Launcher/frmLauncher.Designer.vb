<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLauncher
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLauncher))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.LegalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LicenseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreditsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ResetBrowserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdvancedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ForceValidationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedownloadFLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompiledFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BetaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeprecatedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevelopmentKitsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MapKitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SourceKitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibKitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LauncherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.webMain = New System.Windows.Forms.WebBrowser()
        Me.pbDl = New System.Windows.Forms.ProgressBar()
        Me.lblLaunch = New System.Windows.Forms.Button()
        Me.txtLog = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, -124)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(800, 451)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem, Me.AdvancedToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(777, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.ToolStripMenuItem1, Me.LegalToolStripMenuItem, Me.ToolStripMenuItem2, Me.ResetBrowserToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(144, 6)
        '
        'LegalToolStripMenuItem
        '
        Me.LegalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LicenseToolStripMenuItem, Me.ContactToolStripMenuItem, Me.CreditsToolStripMenuItem})
        Me.LegalToolStripMenuItem.Name = "LegalToolStripMenuItem"
        Me.LegalToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.LegalToolStripMenuItem.Text = "Legal"
        '
        'LicenseToolStripMenuItem
        '
        Me.LicenseToolStripMenuItem.Name = "LicenseToolStripMenuItem"
        Me.LicenseToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.LicenseToolStripMenuItem.Text = "License"
        '
        'ContactToolStripMenuItem
        '
        Me.ContactToolStripMenuItem.Name = "ContactToolStripMenuItem"
        Me.ContactToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.ContactToolStripMenuItem.Text = "Contact"
        '
        'CreditsToolStripMenuItem
        '
        Me.CreditsToolStripMenuItem.Name = "CreditsToolStripMenuItem"
        Me.CreditsToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.CreditsToolStripMenuItem.Text = "Credits"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(144, 6)
        '
        'ResetBrowserToolStripMenuItem
        '
        Me.ResetBrowserToolStripMenuItem.Name = "ResetBrowserToolStripMenuItem"
        Me.ResetBrowserToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.ResetBrowserToolStripMenuItem.Text = "Reset Browser"
        '
        'AdvancedToolStripMenuItem
        '
        Me.AdvancedToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ForceValidationToolStripMenuItem, Me.RedownloadFLToolStripMenuItem, Me.ViewLogToolStripMenuItem})
        Me.AdvancedToolStripMenuItem.Name = "AdvancedToolStripMenuItem"
        Me.AdvancedToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.AdvancedToolStripMenuItem.Text = "Advanced"
        '
        'ForceValidationToolStripMenuItem
        '
        Me.ForceValidationToolStripMenuItem.Name = "ForceValidationToolStripMenuItem"
        Me.ForceValidationToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ForceValidationToolStripMenuItem.Text = "Force Validation"
        '
        'RedownloadFLToolStripMenuItem
        '
        Me.RedownloadFLToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompiledFilesToolStripMenuItem, Me.DevelopmentKitsToolStripMenuItem})
        Me.RedownloadFLToolStripMenuItem.Enabled = False
        Me.RedownloadFLToolStripMenuItem.Name = "RedownloadFLToolStripMenuItem"
        Me.RedownloadFLToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.RedownloadFLToolStripMenuItem.Text = "Force Download"
        '
        'CompiledFilesToolStripMenuItem
        '
        Me.CompiledFilesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BetaToolStripMenuItem, Me.StableToolStripMenuItem, Me.DeprecatedToolStripMenuItem})
        Me.CompiledFilesToolStripMenuItem.Name = "CompiledFilesToolStripMenuItem"
        Me.CompiledFilesToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.CompiledFilesToolStripMenuItem.Text = "Compiled Files"
        '
        'BetaToolStripMenuItem
        '
        Me.BetaToolStripMenuItem.Name = "BetaToolStripMenuItem"
        Me.BetaToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.BetaToolStripMenuItem.Text = "Beta"
        '
        'StableToolStripMenuItem
        '
        Me.StableToolStripMenuItem.Name = "StableToolStripMenuItem"
        Me.StableToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.StableToolStripMenuItem.Text = "Stable"
        '
        'DeprecatedToolStripMenuItem
        '
        Me.DeprecatedToolStripMenuItem.Name = "DeprecatedToolStripMenuItem"
        Me.DeprecatedToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.DeprecatedToolStripMenuItem.Text = "Deprecated"
        '
        'DevelopmentKitsToolStripMenuItem
        '
        Me.DevelopmentKitsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MapKitToolStripMenuItem, Me.SourceKitToolStripMenuItem, Me.LibKitToolStripMenuItem})
        Me.DevelopmentKitsToolStripMenuItem.Name = "DevelopmentKitsToolStripMenuItem"
        Me.DevelopmentKitsToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.DevelopmentKitsToolStripMenuItem.Text = "Development Kits"
        '
        'MapKitToolStripMenuItem
        '
        Me.MapKitToolStripMenuItem.Name = "MapKitToolStripMenuItem"
        Me.MapKitToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.MapKitToolStripMenuItem.Text = "Map Kit"
        '
        'SourceKitToolStripMenuItem
        '
        Me.SourceKitToolStripMenuItem.Name = "SourceKitToolStripMenuItem"
        Me.SourceKitToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.SourceKitToolStripMenuItem.Text = "Source Kit"
        '
        'LibKitToolStripMenuItem
        '
        Me.LibKitToolStripMenuItem.Name = "LibKitToolStripMenuItem"
        Me.LibKitToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.LibKitToolStripMenuItem.Text = "LibKit"
        '
        'ViewLogToolStripMenuItem
        '
        Me.ViewLogToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LauncherToolStripMenuItem})
        Me.ViewLogToolStripMenuItem.Name = "ViewLogToolStripMenuItem"
        Me.ViewLogToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ViewLogToolStripMenuItem.Text = "View Log"
        '
        'LauncherToolStripMenuItem
        '
        Me.LauncherToolStripMenuItem.CheckOnClick = True
        Me.LauncherToolStripMenuItem.Name = "LauncherToolStripMenuItem"
        Me.LauncherToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.LauncherToolStripMenuItem.Text = "Launcher"
        '
        'webMain
        '
        Me.webMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.webMain.Location = New System.Drawing.Point(7, 333)
        Me.webMain.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webMain.Name = "webMain"
        Me.webMain.ScriptErrorsSuppressed = True
        Me.webMain.Size = New System.Drawing.Size(758, 345)
        Me.webMain.TabIndex = 2
        Me.webMain.Url = New System.Uri("http://scratso.xyz/archives/ubipy", System.UriKind.Absolute)
        '
        'pbDl
        '
        Me.pbDl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbDl.Location = New System.Drawing.Point(7, 689)
        Me.pbDl.Name = "pbDl"
        Me.pbDl.Size = New System.Drawing.Size(757, 29)
        Me.pbDl.TabIndex = 3
        '
        'lblLaunch
        '
        Me.lblLaunch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLaunch.Location = New System.Drawing.Point(661, 691)
        Me.lblLaunch.Name = "lblLaunch"
        Me.lblLaunch.Size = New System.Drawing.Size(94, 25)
        Me.lblLaunch.TabIndex = 4
        Me.lblLaunch.Text = "Launch >>"
        Me.lblLaunch.UseVisualStyleBackColor = True
        Me.lblLaunch.Visible = False
        '
        'txtLog
        '
        Me.txtLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLog.Location = New System.Drawing.Point(7, 333)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ReadOnly = True
        Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtLog.Size = New System.Drawing.Size(758, 345)
        Me.txtLog.TabIndex = 5
        Me.txtLog.Tag = ""
        Me.txtLog.Text = "Liberation Launcher |" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pre-release Log       |" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "----------------------------|"
        Me.txtLog.Visible = False
        '
        'frmLauncher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(777, 727)
        Me.Controls.Add(Me.lblLaunch)
        Me.Controls.Add(Me.pbDl)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtLog)
        Me.Controls.Add(Me.webMain)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmLauncher"
        Me.Text = "Liberation Launcher: Ubipy Music Player"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LegalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LicenseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContactToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreditsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdvancedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ForceValidationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedownloadFLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompiledFilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BetaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeprecatedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DevelopmentKitsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MapKitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SourceKitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LibKitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewLogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LauncherToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents webMain As System.Windows.Forms.WebBrowser
    Friend WithEvents pbDl As System.Windows.Forms.ProgressBar
    Friend WithEvents lblLaunch As System.Windows.Forms.Button
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ResetBrowserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtLog As System.Windows.Forms.TextBox
End Class
