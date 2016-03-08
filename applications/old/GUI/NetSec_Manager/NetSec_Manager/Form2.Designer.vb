<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IPScanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SnifferToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SnortScanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenConfigicgurationFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RulesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartScanCMDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttackAdviserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataAnalysisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.RosyBrown
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolsToolStripMenuItem, Me.DataAnalysisToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(693, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IPScanToolStripMenuItem, Me.SnortScanToolStripMenuItem, Me.AttackAdviserToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Font = New System.Drawing.Font("Oxygen", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'IPScanToolStripMenuItem
        '
        Me.IPScanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SnifferToolStripMenuItem})
        Me.IPScanToolStripMenuItem.Name = "IPScanToolStripMenuItem"
        Me.IPScanToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.IPScanToolStripMenuItem.Text = "Network Scan"
        '
        'SnifferToolStripMenuItem
        '
        Me.SnifferToolStripMenuItem.Name = "SnifferToolStripMenuItem"
        Me.SnifferToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.SnifferToolStripMenuItem.Text = "Sniffer"
        '
        'SnortScanToolStripMenuItem
        '
        Me.SnortScanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenConfigicgurationFileToolStripMenuItem, Me.RulesToolStripMenuItem, Me.StartScanCMDToolStripMenuItem})
        Me.SnortScanToolStripMenuItem.Name = "SnortScanToolStripMenuItem"
        Me.SnortScanToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.SnortScanToolStripMenuItem.Text = "IDS Scan"
        '
        'OpenConfigicgurationFileToolStripMenuItem
        '
        Me.OpenConfigicgurationFileToolStripMenuItem.Name = "OpenConfigicgurationFileToolStripMenuItem"
        Me.OpenConfigicgurationFileToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.OpenConfigicgurationFileToolStripMenuItem.Text = "Open Configuration File"
        '
        'RulesToolStripMenuItem
        '
        Me.RulesToolStripMenuItem.Name = "RulesToolStripMenuItem"
        Me.RulesToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.RulesToolStripMenuItem.Text = "Rules"
        '
        'StartScanCMDToolStripMenuItem
        '
        Me.StartScanCMDToolStripMenuItem.Name = "StartScanCMDToolStripMenuItem"
        Me.StartScanCMDToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.StartScanCMDToolStripMenuItem.Text = "Start Scan (CMD)"
        '
        'AttackAdviserToolStripMenuItem
        '
        Me.AttackAdviserToolStripMenuItem.Name = "AttackAdviserToolStripMenuItem"
        Me.AttackAdviserToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.AttackAdviserToolStripMenuItem.Text = "Attack Adviser"
        '
        'DataAnalysisToolStripMenuItem
        '
        Me.DataAnalysisToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewDataToolStripMenuItem})
        Me.DataAnalysisToolStripMenuItem.Font = New System.Drawing.Font("Oxygen", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataAnalysisToolStripMenuItem.Name = "DataAnalysisToolStripMenuItem"
        Me.DataAnalysisToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.DataAnalysisToolStripMenuItem.Text = "Data Analysis"
        '
        'ViewDataToolStripMenuItem
        '
        Me.ViewDataToolStripMenuItem.Name = "ViewDataToolStripMenuItem"
        Me.ViewDataToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.ViewDataToolStripMenuItem.Text = "View Data"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutUsToolStripMenuItem, Me.ChangePasswordToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.AboutToolStripMenuItem.Font = New System.Drawing.Font("Oxygen", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'AboutUsToolStripMenuItem
        '
        Me.AboutUsToolStripMenuItem.Name = "AboutUsToolStripMenuItem"
        Me.AboutUsToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.AboutUsToolStripMenuItem.Text = "About Us"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Documentation"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Oxygen", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(214, 183)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 31)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Welcome to NetSec Manager!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Oxygen", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(514, 31)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Choose from the menu above to get started."
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(693, 419)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Oxygen", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form2"
        Me.Text = "NetSec Manager: Home"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutUsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IPScanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SnortScanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenConfigicgurationFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RulesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartScanCMDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataAnalysisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SnifferToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AttackAdviserToolStripMenuItem As ToolStripMenuItem
End Class
