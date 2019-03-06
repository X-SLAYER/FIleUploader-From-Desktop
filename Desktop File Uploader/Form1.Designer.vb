<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Lv1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CM1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BrowseFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CopyFullLinkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyShortLinkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IM = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.P1 = New System.Windows.Forms.PictureBox()
        Me.lb1 = New System.Windows.Forms.Label()
        Me.FolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.CM1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.P1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lv1
        '
        Me.Lv1.AllowDrop = True
        Me.Lv1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Lv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lv1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.Lv1.ContextMenuStrip = Me.CM1
        Me.Lv1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Lv1.ForeColor = System.Drawing.Color.White
        Me.Lv1.FullRowSelect = True
        Me.Lv1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.Lv1.LargeImageList = Me.IM
        Me.Lv1.Location = New System.Drawing.Point(0, 54)
        Me.Lv1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Lv1.Name = "Lv1"
        Me.Lv1.Size = New System.Drawing.Size(379, 442)
        Me.Lv1.SmallImageList = Me.IM
        Me.Lv1.TabIndex = 1
        Me.Lv1.UseCompatibleStateImageBehavior = False
        Me.Lv1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "File"
        Me.ColumnHeader1.Width = 161
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Status"
        Me.ColumnHeader2.Width = 212
        '
        'CM1
        '
        Me.CM1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BrowseFolderToolStripMenuItem, Me.ToolStripSeparator1, Me.CopyFullLinkToolStripMenuItem, Me.CopyShortLinkToolStripMenuItem})
        Me.CM1.Name = "CM1"
        Me.CM1.Size = New System.Drawing.Size(159, 76)
        '
        'BrowseFolderToolStripMenuItem
        '
        Me.BrowseFolderToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FolderToolStripMenuItem, Me.FileToolStripMenuItem})
        Me.BrowseFolderToolStripMenuItem.Image = CType(resources.GetObject("BrowseFolderToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BrowseFolderToolStripMenuItem.Name = "BrowseFolderToolStripMenuItem"
        Me.BrowseFolderToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.BrowseFolderToolStripMenuItem.Text = "Browse"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(155, 6)
        '
        'CopyFullLinkToolStripMenuItem
        '
        Me.CopyFullLinkToolStripMenuItem.Enabled = False
        Me.CopyFullLinkToolStripMenuItem.Image = CType(resources.GetObject("CopyFullLinkToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopyFullLinkToolStripMenuItem.Name = "CopyFullLinkToolStripMenuItem"
        Me.CopyFullLinkToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.CopyFullLinkToolStripMenuItem.Text = "Copy Full Link"
        '
        'CopyShortLinkToolStripMenuItem
        '
        Me.CopyShortLinkToolStripMenuItem.Enabled = False
        Me.CopyShortLinkToolStripMenuItem.Image = CType(resources.GetObject("CopyShortLinkToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopyShortLinkToolStripMenuItem.Name = "CopyShortLinkToolStripMenuItem"
        Me.CopyShortLinkToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.CopyShortLinkToolStripMenuItem.Text = "Copy Short Link"
        '
        'IM
        '
        Me.IM.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.IM.ImageSize = New System.Drawing.Size(17, 17)
        Me.IM.TransparentColor = System.Drawing.Color.Transparent
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.P1)
        Me.Panel1.Controls.Add(Me.lb1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(379, 37)
        Me.Panel1.TabIndex = 3
        '
        'P1
        '
        Me.P1.Image = CType(resources.GetObject("P1.Image"), System.Drawing.Image)
        Me.P1.Location = New System.Drawing.Point(58, 5)
        Me.P1.Name = "P1"
        Me.P1.Size = New System.Drawing.Size(24, 24)
        Me.P1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.P1.TabIndex = 1
        Me.P1.TabStop = False
        '
        'lb1
        '
        Me.lb1.ForeColor = System.Drawing.Color.White
        Me.lb1.Location = New System.Drawing.Point(0, 0)
        Me.lb1.Name = "lb1"
        Me.lb1.Size = New System.Drawing.Size(376, 37)
        Me.lb1.TabIndex = 0
        Me.lb1.Text = "AnonFile Uploader Desktop | X-SLAYER"
        Me.lb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FolderToolStripMenuItem
        '
        Me.FolderToolStripMenuItem.Image = CType(resources.GetObject("FolderToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FolderToolStripMenuItem.Name = "FolderToolStripMenuItem"
        Me.FolderToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FolderToolStripMenuItem.Text = "Folder"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Image = CType(resources.GetObject("FileToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(363, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(17, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Blue
        Me.LinkLabel1.Location = New System.Drawing.Point(3, 37)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(41, 15)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "About"
        '
        'Form1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(379, 496)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Lv1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AnonFile Uploader Desktop | X-SLAYER"
        Me.CM1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.P1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lv1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents IM As System.Windows.Forms.ImageList
    Friend WithEvents CM1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BrowseFolderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CopyFullLinkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyShortLinkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lb1 As System.Windows.Forms.Label
    Friend WithEvents P1 As System.Windows.Forms.PictureBox
    Friend WithEvents FolderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel

End Class
