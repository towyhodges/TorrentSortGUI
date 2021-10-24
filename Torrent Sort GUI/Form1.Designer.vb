<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ListBoxItems = New System.Windows.Forms.ListBox()
        Me.ListBoxTags = New System.Windows.Forms.ListBox()
        Me.ListBoxFormats = New System.Windows.Forms.ListBox()
        Me.ButtonAddTag = New System.Windows.Forms.Button()
        Me.ButtonAddFormat = New System.Windows.Forms.Button()
        Me.ButtonImport = New System.Windows.Forms.Button()
        Me.ButtonStrip = New System.Windows.Forms.Button()
        Me.ListBoxShows = New System.Windows.Forms.ListBox()
        Me.ButtonAddTV = New System.Windows.Forms.Button()
        Me.ButtonSortTV = New System.Windows.Forms.Button()
        Me.ButtonOpen = New System.Windows.Forms.Button()
        Me.ListBoxIgnore = New System.Windows.Forms.ListBox()
        Me.ButtonAddIgnore = New System.Windows.Forms.Button()
        Me.ButtonCleanDir = New System.Windows.Forms.Button()
        Me.TabControlMain = New System.Windows.Forms.TabControl()
        Me.TabPageSort = New System.Windows.Forms.TabPage()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.TabPageSettings = New System.Windows.Forms.TabPage()
        Me.CheckBoxSaveExit = New System.Windows.Forms.CheckBox()
        Me.ButtonBrowseTV = New System.Windows.Forms.Button()
        Me.ButtonBrowseTarget = New System.Windows.Forms.Button()
        Me.ButtonBrowseSource = New System.Windows.Forms.Button()
        Me.TextBoxSource = New System.Windows.Forms.TextBox()
        Me.TextBoxTVTarget = New System.Windows.Forms.TextBox()
        Me.TextBoxTarget = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialogMain = New System.Windows.Forms.FolderBrowserDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ButtonHelp = New System.Windows.Forms.Button()
        Me.TabControlMain.SuspendLayout()
        Me.TabPageSort.SuspendLayout()
        Me.TabPageSettings.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBoxItems
        '
        Me.ListBoxItems.FormattingEnabled = True
        Me.ListBoxItems.Location = New System.Drawing.Point(169, 7)
        Me.ListBoxItems.Name = "ListBoxItems"
        Me.ListBoxItems.Size = New System.Drawing.Size(300, 537)
        Me.ListBoxItems.TabIndex = 0
        '
        'ListBoxTags
        '
        Me.ListBoxTags.FormattingEnabled = True
        Me.ListBoxTags.Location = New System.Drawing.Point(475, 7)
        Me.ListBoxTags.Name = "ListBoxTags"
        Me.ListBoxTags.Size = New System.Drawing.Size(156, 537)
        Me.ListBoxTags.TabIndex = 0
        '
        'ListBoxFormats
        '
        Me.ListBoxFormats.FormattingEnabled = True
        Me.ListBoxFormats.Location = New System.Drawing.Point(7, 7)
        Me.ListBoxFormats.Name = "ListBoxFormats"
        Me.ListBoxFormats.Size = New System.Drawing.Size(156, 251)
        Me.ListBoxFormats.TabIndex = 0
        '
        'ButtonAddTag
        '
        Me.ButtonAddTag.Location = New System.Drawing.Point(475, 550)
        Me.ButtonAddTag.Name = "ButtonAddTag"
        Me.ButtonAddTag.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAddTag.TabIndex = 2
        Me.ButtonAddTag.Text = "Add Tag"
        Me.ButtonAddTag.UseVisualStyleBackColor = True
        '
        'ButtonAddFormat
        '
        Me.ButtonAddFormat.Location = New System.Drawing.Point(7, 264)
        Me.ButtonAddFormat.Name = "ButtonAddFormat"
        Me.ButtonAddFormat.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAddFormat.TabIndex = 2
        Me.ButtonAddFormat.Text = "Add Format"
        Me.ButtonAddFormat.UseVisualStyleBackColor = True
        '
        'ButtonImport
        '
        Me.ButtonImport.Location = New System.Drawing.Point(88, 264)
        Me.ButtonImport.Name = "ButtonImport"
        Me.ButtonImport.Size = New System.Drawing.Size(75, 23)
        Me.ButtonImport.TabIndex = 2
        Me.ButtonImport.Text = "Import Files"
        Me.ButtonImport.UseVisualStyleBackColor = True
        '
        'ButtonStrip
        '
        Me.ButtonStrip.Location = New System.Drawing.Point(556, 550)
        Me.ButtonStrip.Name = "ButtonStrip"
        Me.ButtonStrip.Size = New System.Drawing.Size(75, 23)
        Me.ButtonStrip.TabIndex = 2
        Me.ButtonStrip.Text = "Strip Files"
        Me.ButtonStrip.UseVisualStyleBackColor = True
        '
        'ListBoxShows
        '
        Me.ListBoxShows.FormattingEnabled = True
        Me.ListBoxShows.Location = New System.Drawing.Point(637, 7)
        Me.ListBoxShows.Name = "ListBoxShows"
        Me.ListBoxShows.Size = New System.Drawing.Size(156, 537)
        Me.ListBoxShows.TabIndex = 0
        '
        'ButtonAddTV
        '
        Me.ButtonAddTV.Location = New System.Drawing.Point(637, 550)
        Me.ButtonAddTV.Name = "ButtonAddTV"
        Me.ButtonAddTV.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAddTV.TabIndex = 2
        Me.ButtonAddTV.Text = "Add Show"
        Me.ButtonAddTV.UseVisualStyleBackColor = True
        '
        'ButtonSortTV
        '
        Me.ButtonSortTV.Location = New System.Drawing.Point(718, 550)
        Me.ButtonSortTV.Name = "ButtonSortTV"
        Me.ButtonSortTV.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSortTV.TabIndex = 2
        Me.ButtonSortTV.Text = "Sort Shows"
        Me.ButtonSortTV.UseVisualStyleBackColor = True
        '
        'ButtonOpen
        '
        Me.ButtonOpen.Location = New System.Drawing.Point(350, 550)
        Me.ButtonOpen.Name = "ButtonOpen"
        Me.ButtonOpen.Size = New System.Drawing.Size(119, 23)
        Me.ButtonOpen.TabIndex = 2
        Me.ButtonOpen.Text = "Open Directory"
        Me.ButtonOpen.UseVisualStyleBackColor = True
        '
        'ListBoxIgnore
        '
        Me.ListBoxIgnore.FormattingEnabled = True
        Me.ListBoxIgnore.Location = New System.Drawing.Point(7, 293)
        Me.ListBoxIgnore.Name = "ListBoxIgnore"
        Me.ListBoxIgnore.Size = New System.Drawing.Size(156, 251)
        Me.ListBoxIgnore.TabIndex = 0
        '
        'ButtonAddIgnore
        '
        Me.ButtonAddIgnore.Location = New System.Drawing.Point(7, 550)
        Me.ButtonAddIgnore.Name = "ButtonAddIgnore"
        Me.ButtonAddIgnore.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAddIgnore.TabIndex = 2
        Me.ButtonAddIgnore.Text = "Add Format"
        Me.ButtonAddIgnore.UseVisualStyleBackColor = True
        '
        'ButtonCleanDir
        '
        Me.ButtonCleanDir.Location = New System.Drawing.Point(88, 550)
        Me.ButtonCleanDir.Name = "ButtonCleanDir"
        Me.ButtonCleanDir.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCleanDir.TabIndex = 2
        Me.ButtonCleanDir.Text = "Clean Dir"
        Me.ButtonCleanDir.UseVisualStyleBackColor = True
        '
        'TabControlMain
        '
        Me.TabControlMain.Controls.Add(Me.TabPageSort)
        Me.TabControlMain.Controls.Add(Me.TabPageSettings)
        Me.TabControlMain.Location = New System.Drawing.Point(12, 42)
        Me.TabControlMain.Name = "TabControlMain"
        Me.TabControlMain.SelectedIndex = 0
        Me.TabControlMain.Size = New System.Drawing.Size(807, 606)
        Me.TabControlMain.TabIndex = 3
        '
        'TabPageSort
        '
        Me.TabPageSort.Controls.Add(Me.ButtonRefresh)
        Me.TabPageSort.Controls.Add(Me.ButtonCleanDir)
        Me.TabPageSort.Controls.Add(Me.ListBoxFormats)
        Me.TabPageSort.Controls.Add(Me.ButtonImport)
        Me.TabPageSort.Controls.Add(Me.ListBoxItems)
        Me.TabPageSort.Controls.Add(Me.ButtonAddIgnore)
        Me.TabPageSort.Controls.Add(Me.ListBoxShows)
        Me.TabPageSort.Controls.Add(Me.ButtonAddFormat)
        Me.TabPageSort.Controls.Add(Me.ListBoxTags)
        Me.TabPageSort.Controls.Add(Me.ButtonStrip)
        Me.TabPageSort.Controls.Add(Me.ListBoxIgnore)
        Me.TabPageSort.Controls.Add(Me.ButtonOpen)
        Me.TabPageSort.Controls.Add(Me.ButtonAddTag)
        Me.TabPageSort.Controls.Add(Me.ButtonSortTV)
        Me.TabPageSort.Controls.Add(Me.ButtonAddTV)
        Me.TabPageSort.Location = New System.Drawing.Point(4, 22)
        Me.TabPageSort.Name = "TabPageSort"
        Me.TabPageSort.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageSort.Size = New System.Drawing.Size(799, 580)
        Me.TabPageSort.TabIndex = 1
        Me.TabPageSort.Text = "Sort"
        Me.TabPageSort.UseVisualStyleBackColor = True
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Location = New System.Drawing.Point(169, 550)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRefresh.TabIndex = 2
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'TabPageSettings
        '
        Me.TabPageSettings.Controls.Add(Me.ButtonHelp)
        Me.TabPageSettings.Controls.Add(Me.CheckBoxSaveExit)
        Me.TabPageSettings.Controls.Add(Me.ButtonBrowseTV)
        Me.TabPageSettings.Controls.Add(Me.ButtonBrowseTarget)
        Me.TabPageSettings.Controls.Add(Me.ButtonBrowseSource)
        Me.TabPageSettings.Controls.Add(Me.TextBoxSource)
        Me.TabPageSettings.Controls.Add(Me.TextBoxTVTarget)
        Me.TabPageSettings.Controls.Add(Me.TextBoxTarget)
        Me.TabPageSettings.Controls.Add(Me.Label3)
        Me.TabPageSettings.Controls.Add(Me.Label2)
        Me.TabPageSettings.Controls.Add(Me.Label1)
        Me.TabPageSettings.Location = New System.Drawing.Point(4, 22)
        Me.TabPageSettings.Name = "TabPageSettings"
        Me.TabPageSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageSettings.Size = New System.Drawing.Size(799, 580)
        Me.TabPageSettings.TabIndex = 2
        Me.TabPageSettings.Text = "Settings"
        Me.TabPageSettings.UseVisualStyleBackColor = True
        '
        'CheckBoxSaveExit
        '
        Me.CheckBoxSaveExit.AutoSize = True
        Me.CheckBoxSaveExit.Checked = True
        Me.CheckBoxSaveExit.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxSaveExit.Location = New System.Drawing.Point(664, 557)
        Me.CheckBoxSaveExit.Name = "CheckBoxSaveExit"
        Me.CheckBoxSaveExit.Size = New System.Drawing.Size(129, 17)
        Me.CheckBoxSaveExit.TabIndex = 3
        Me.CheckBoxSaveExit.Text = "Save Settings On Exit"
        Me.CheckBoxSaveExit.UseVisualStyleBackColor = True
        '
        'ButtonBrowseTV
        '
        Me.ButtonBrowseTV.Location = New System.Drawing.Point(633, 68)
        Me.ButtonBrowseTV.Name = "ButtonBrowseTV"
        Me.ButtonBrowseTV.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBrowseTV.TabIndex = 2
        Me.ButtonBrowseTV.Text = "Browse"
        Me.ButtonBrowseTV.UseVisualStyleBackColor = True
        '
        'ButtonBrowseTarget
        '
        Me.ButtonBrowseTarget.Location = New System.Drawing.Point(633, 38)
        Me.ButtonBrowseTarget.Name = "ButtonBrowseTarget"
        Me.ButtonBrowseTarget.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBrowseTarget.TabIndex = 2
        Me.ButtonBrowseTarget.Text = "Browse"
        Me.ButtonBrowseTarget.UseVisualStyleBackColor = True
        '
        'ButtonBrowseSource
        '
        Me.ButtonBrowseSource.Location = New System.Drawing.Point(633, 8)
        Me.ButtonBrowseSource.Name = "ButtonBrowseSource"
        Me.ButtonBrowseSource.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBrowseSource.TabIndex = 2
        Me.ButtonBrowseSource.Text = "Browse"
        Me.ButtonBrowseSource.UseVisualStyleBackColor = True
        '
        'TextBoxSource
        '
        Me.TextBoxSource.Location = New System.Drawing.Point(86, 10)
        Me.TextBoxSource.Name = "TextBoxSource"
        Me.TextBoxSource.Size = New System.Drawing.Size(541, 20)
        Me.TextBoxSource.TabIndex = 1
        '
        'TextBoxTVTarget
        '
        Me.TextBoxTVTarget.Location = New System.Drawing.Point(86, 70)
        Me.TextBoxTVTarget.Name = "TextBoxTVTarget"
        Me.TextBoxTVTarget.Size = New System.Drawing.Size(541, 20)
        Me.TextBoxTVTarget.TabIndex = 1
        '
        'TextBoxTarget
        '
        Me.TextBoxTarget.Location = New System.Drawing.Point(86, 40)
        Me.TextBoxTarget.Name = "TextBoxTarget"
        Me.TextBoxTarget.Size = New System.Drawing.Size(541, 20)
        Me.TextBoxTarget.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "TV Sort Folder"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Sort Target"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Source Folder"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(756, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(63, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(219, 41)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'ButtonHelp
        '
        Me.ButtonHelp.Location = New System.Drawing.Point(3, 551)
        Me.ButtonHelp.Name = "ButtonHelp"
        Me.ButtonHelp.Size = New System.Drawing.Size(75, 23)
        Me.ButtonHelp.TabIndex = 4
        Me.ButtonHelp.Text = "Help"
        Me.ButtonHelp.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 657)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TabControlMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Torrent Sort GUI"
        Me.TabControlMain.ResumeLayout(False)
        Me.TabPageSort.ResumeLayout(False)
        Me.TabPageSettings.ResumeLayout(False)
        Me.TabPageSettings.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBoxItems As ListBox
    Friend WithEvents ListBoxTags As ListBox
    Friend WithEvents ListBoxFormats As ListBox
    Friend WithEvents ButtonAddTag As Button
    Friend WithEvents ButtonAddFormat As Button
    Friend WithEvents ButtonImport As Button
    Friend WithEvents ButtonStrip As Button
    Friend WithEvents ListBoxShows As ListBox
    Friend WithEvents ButtonAddTV As Button
    Friend WithEvents ButtonSortTV As Button
    Friend WithEvents ButtonOpen As Button
    Friend WithEvents ListBoxIgnore As ListBox
    Friend WithEvents ButtonAddIgnore As Button
    Friend WithEvents ButtonCleanDir As Button
    Friend WithEvents TabControlMain As TabControl
    Friend WithEvents TabPageSort As TabPage
    Friend WithEvents TabPageSettings As TabPage
    Friend WithEvents ButtonBrowseTV As Button
    Friend WithEvents ButtonBrowseTarget As Button
    Friend WithEvents ButtonBrowseSource As Button
    Friend WithEvents TextBoxSource As TextBox
    Friend WithEvents TextBoxTVTarget As TextBox
    Friend WithEvents TextBoxTarget As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents FolderBrowserDialogMain As FolderBrowserDialog
    Friend WithEvents ButtonRefresh As Button
    Friend WithEvents CheckBoxSaveExit As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ButtonHelp As Button
End Class
