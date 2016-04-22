<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NetworkScanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SnifferToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IDSScanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenConfigurationFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RulesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartScanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MapperToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NmapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NmapCheatSheetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttackAdviserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BackwardButton = New System.Windows.Forms.ToolStripButton()
        Me.ForwardButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.HomeButton = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataAnalysisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolsToolStripMenuItem, Me.DataAnalysisToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NetworkScanToolStripMenuItem, Me.IDSScanToolStripMenuItem, Me.MapperToolStripMenuItem, Me.AttackAdviserToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'NetworkScanToolStripMenuItem
        '
        Me.NetworkScanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SnifferToolStripMenuItem})
        Me.NetworkScanToolStripMenuItem.Name = "NetworkScanToolStripMenuItem"
        Me.NetworkScanToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.NetworkScanToolStripMenuItem.Text = "Network Scan"
        '
        'SnifferToolStripMenuItem
        '
        Me.SnifferToolStripMenuItem.Name = "SnifferToolStripMenuItem"
        Me.SnifferToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.SnifferToolStripMenuItem.Text = "Scanner"
        '
        'IDSScanToolStripMenuItem
        '
        Me.IDSScanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenConfigurationFileToolStripMenuItem, Me.RulesToolStripMenuItem, Me.StartScanToolStripMenuItem})
        Me.IDSScanToolStripMenuItem.Name = "IDSScanToolStripMenuItem"
        Me.IDSScanToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.IDSScanToolStripMenuItem.Text = "IDS Scan"
        '
        'OpenConfigurationFileToolStripMenuItem
        '
        Me.OpenConfigurationFileToolStripMenuItem.Name = "OpenConfigurationFileToolStripMenuItem"
        Me.OpenConfigurationFileToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.OpenConfigurationFileToolStripMenuItem.Text = "Open Configuration File"
        '
        'RulesToolStripMenuItem
        '
        Me.RulesToolStripMenuItem.Name = "RulesToolStripMenuItem"
        Me.RulesToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.RulesToolStripMenuItem.Text = "Rules"
        '
        'StartScanToolStripMenuItem
        '
        Me.StartScanToolStripMenuItem.Name = "StartScanToolStripMenuItem"
        Me.StartScanToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.StartScanToolStripMenuItem.Text = "Scan"
        '
        'MapperToolStripMenuItem
        '
        Me.MapperToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NmapToolStripMenuItem, Me.NmapCheatSheetToolStripMenuItem})
        Me.MapperToolStripMenuItem.Name = "MapperToolStripMenuItem"
        Me.MapperToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.MapperToolStripMenuItem.Text = "Mapper"
        '
        'NmapToolStripMenuItem
        '
        Me.NmapToolStripMenuItem.Name = "NmapToolStripMenuItem"
        Me.NmapToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.NmapToolStripMenuItem.Text = "Nmap"
        '
        'NmapCheatSheetToolStripMenuItem
        '
        Me.NmapCheatSheetToolStripMenuItem.Name = "NmapCheatSheetToolStripMenuItem"
        Me.NmapCheatSheetToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.NmapCheatSheetToolStripMenuItem.Text = "Nmap Cheat Sheet"
        '
        'AttackAdviserToolStripMenuItem
        '
        Me.AttackAdviserToolStripMenuItem.Name = "AttackAdviserToolStripMenuItem"
        Me.AttackAdviserToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.AttackAdviserToolStripMenuItem.Text = "Attack Adviser"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SystemInformationToolStripMenuItem, Me.ToolStripSeparator2, Me.LogOutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'SystemInformationToolStripMenuItem
        '
        Me.SystemInformationToolStripMenuItem.Name = "SystemInformationToolStripMenuItem"
        Me.SystemInformationToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.SystemInformationToolStripMenuItem.Text = "System Information"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(175, 6)
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackwardButton, Me.ForwardButton, Me.ToolStripSeparator1, Me.HomeButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip1.TabIndex = 7
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BackwardButton
        '
        Me.BackwardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BackwardButton.Image = CType(resources.GetObject("BackwardButton.Image"), System.Drawing.Image)
        Me.BackwardButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BackwardButton.Name = "BackwardButton"
        Me.BackwardButton.Size = New System.Drawing.Size(23, 22)
        Me.BackwardButton.Text = "ToolStripButton1"
        Me.BackwardButton.ToolTipText = "Back"
        '
        'ForwardButton
        '
        Me.ForwardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ForwardButton.Image = CType(resources.GetObject("ForwardButton.Image"), System.Drawing.Image)
        Me.ForwardButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ForwardButton.Name = "ForwardButton"
        Me.ForwardButton.Size = New System.Drawing.Size(23, 22)
        Me.ForwardButton.Text = "ToolStripButton2"
        Me.ForwardButton.ToolTipText = "Forward"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'HomeButton
        '
        Me.HomeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HomeButton.Image = CType(resources.GetObject("HomeButton.Image"), System.Drawing.Image)
        Me.HomeButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(23, 22)
        Me.HomeButton.Text = "ToolStripButton3"
        Me.HomeButton.ToolTipText = "Home"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.ListBox1)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(203, 525)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"SQL Injection", "Cross-Site Scripting", "Denial-of-Service (DOS)", "Buffer Overflow", "Session Hijacking"})
        Me.ListBox1.Location = New System.Drawing.Point(7, 40)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(189, 459)
        Me.ListBox1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ATTACKS"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.Location = New System.Drawing.Point(232, 63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(556, 525)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'DataAnalysisToolStripMenuItem
        '
        Me.DataAnalysisToolStripMenuItem.Name = "DataAnalysisToolStripMenuItem"
        Me.DataAnalysisToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.DataAnalysisToolStripMenuItem.Text = "Data Analysis"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NetSec Manager: Attack Adviser"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NetworkScanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SnifferToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IDSScanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenConfigurationFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RulesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartScanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AttackAdviserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SystemInformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents BackwardButton As ToolStripButton
    Friend WithEvents ForwardButton As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents HomeButton As ToolStripButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MapperToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NmapToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NmapCheatSheetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataAnalysisToolStripMenuItem As ToolStripMenuItem
End Class
