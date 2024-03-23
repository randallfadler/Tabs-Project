Imports System.Data.Common

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
        Dim TreeNode1 As TreeNode = New TreeNode("Logs")
        Dim TreeNode2 As TreeNode = New TreeNode("Bin")
        Dim TreeNode3 As TreeNode = New TreeNode("CARD", New TreeNode() {TreeNode1, TreeNode2})
        Dim TreeNode4 As TreeNode = New TreeNode("PIR")
        Dim TreeNode5 As TreeNode = New TreeNode("SWIFT")
        Dim TreeNode6 As TreeNode = New TreeNode("Communictions")
        Dim TreeNode7 As TreeNode = New TreeNode("Comm Logs")
        Dim TreeNode8 As TreeNode = New TreeNode("Batch Logs")
        Dim TreeNode9 As TreeNode = New TreeNode("BONY", New TreeNode() {TreeNode6, TreeNode7, TreeNode8})
        Dim TreeNode10 As TreeNode = New TreeNode("Interfaces", New TreeNode() {TreeNode3, TreeNode4, TreeNode5, TreeNode9})
        Dim TreeNode11 As TreeNode = New TreeNode("CARD")
        Dim TreeNode12 As TreeNode = New TreeNode("PIR")
        Dim TreeNode13 As TreeNode = New TreeNode("Documentation", New TreeNode() {TreeNode11, TreeNode12})
        Dim TreeNode14 As TreeNode = New TreeNode("Performance Reports")
        Dim TreeNode15 As TreeNode = New TreeNode("Goals and Classes")
        Dim TreeNode16 As TreeNode = New TreeNode("Personal", New TreeNode() {TreeNode14, TreeNode15})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        TabControl2 = New TabControl()
        TabPage1 = New TabPage()
        TabControl1 = New TabControl()
        TabPage4 = New TabPage()
        LinkLabel2 = New LinkLabel()
        Label1 = New Label()
        LinkLabel1 = New LinkLabel()
        ListBox1 = New ListBox()
        LinkLabel4 = New LinkLabel()
        LinkLabel3 = New LinkLabel()
        TabPage5 = New TabPage()
        TabPage2 = New TabPage()
        TabPage3 = New TabPage()
        Button3 = New Button()
        TreeView1 = New TreeView()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        NewToolStripMenuItem = New ToolStripMenuItem()
        OpenToolStripMenuItem = New ToolStripMenuItem()
        toolStripSeparator = New ToolStripSeparator()
        SaveToolStripMenuItem = New ToolStripMenuItem()
        SaveAsToolStripMenuItem = New ToolStripMenuItem()
        toolStripSeparator1 = New ToolStripSeparator()
        PrintToolStripMenuItem = New ToolStripMenuItem()
        PrintPreviewToolStripMenuItem = New ToolStripMenuItem()
        toolStripSeparator2 = New ToolStripSeparator()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        EditToolStripMenuItem = New ToolStripMenuItem()
        UndoToolStripMenuItem = New ToolStripMenuItem()
        RedoToolStripMenuItem = New ToolStripMenuItem()
        toolStripSeparator3 = New ToolStripSeparator()
        CutToolStripMenuItem = New ToolStripMenuItem()
        CopyToolStripMenuItem = New ToolStripMenuItem()
        PasteToolStripMenuItem = New ToolStripMenuItem()
        toolStripSeparator4 = New ToolStripSeparator()
        SelectAllToolStripMenuItem = New ToolStripMenuItem()
        ToolsToolStripMenuItem = New ToolStripMenuItem()
        CustomizeToolStripMenuItem = New ToolStripMenuItem()
        OptionsToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        ContentsToolStripMenuItem = New ToolStripMenuItem()
        IndexToolStripMenuItem = New ToolStripMenuItem()
        SearchToolStripMenuItem = New ToolStripMenuItem()
        toolStripSeparator5 = New ToolStripSeparator()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        GroupBox1 = New GroupBox()
        TextBox2 = New TextBox()
        Button4 = New Button()
        TextBox1 = New TextBox()
        Button2 = New Button()
        Button1 = New Button()
        TabControl2.SuspendLayout()
        TabPage1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage4.SuspendLayout()
        MenuStrip1.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl2
        ' 
        TabControl2.Appearance = TabAppearance.Buttons
        TabControl2.Controls.Add(TabPage1)
        TabControl2.Controls.Add(TabPage2)
        TabControl2.Controls.Add(TabPage3)
        TabControl2.Location = New Point(159, 130)
        TabControl2.Name = "TabControl2"
        TabControl2.SelectedIndex = 0
        TabControl2.Size = New Size(1161, 601)
        TabControl2.SizeMode = TabSizeMode.Fixed
        TabControl2.TabIndex = 1
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(TabControl1)
        TabPage1.Location = New Point(4, 27)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1153, 570)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Interfaces"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage4)
        TabControl1.Controls.Add(TabPage5)
        TabControl1.Location = New Point(6, 6)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1141, 412)
        TabControl1.TabIndex = 11
        ' 
        ' TabPage4
        ' 
        TabPage4.Controls.Add(LinkLabel2)
        TabPage4.Controls.Add(Label1)
        TabPage4.Controls.Add(LinkLabel1)
        TabPage4.Controls.Add(ListBox1)
        TabPage4.Controls.Add(LinkLabel4)
        TabPage4.Controls.Add(LinkLabel3)
        TabPage4.Location = New Point(4, 24)
        TabPage4.Name = "TabPage4"
        TabPage4.Padding = New Padding(3)
        TabPage4.Size = New Size(1133, 384)
        TabPage4.TabIndex = 0
        TabPage4.Text = "CARD"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.AutoSize = True
        LinkLabel2.Location = New Point(28, 268)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(171, 15)
        LinkLabel2.TabIndex = 7
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "CARD Esclation Proceuress.doc"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 74)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 15)
        Label1.TabIndex = 10
        Label1.Text = "CARD Files"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(28, 186)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(171, 15)
        LinkLabel1.TabIndex = 6
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "CARD Send Files Proceures.doc"
        ' 
        ' ListBox1
        ' 
        ListBox1.Font = New Font("Cascadia Code", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListBox1.FormattingEnabled = True
        ListBox1.HorizontalScrollbar = True
        ListBox1.Items.AddRange(New Object() {"File Name" & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "FileSize" & vbTab & vbTab & "DateCreated", "Davis Contracts" & vbTab & vbTab & vbTab & vbTab & vbTab & "0" & vbTab & vbTab & vbTab & vbTab & "June1,2023", "Smith Contracts" & vbTab & vbTab & vbTab & vbTab & vbTab & "0 " & vbTab & vbTab & vbTab & vbTab & "July1,2023", "Contract Master.doc" & vbTab & vbTab & vbTab & vbTab & "34k" & vbTab & vbTab & vbTab & vbTab & "April,21,2023", "Contacts.xls " & vbTab & vbTab & vbTab & vbTab & vbTab & "56k" & vbTab & vbTab & vbTab & vbTab & "April22,2023"})
        ListBox1.Location = New Point(6, 6)
        ListBox1.Name = "ListBox1"
        ListBox1.ScrollAlwaysVisible = True
        ListBox1.Size = New Size(1111, 164)
        ListBox1.TabIndex = 3
        ' 
        ' LinkLabel4
        ' 
        LinkLabel4.AutoSize = True
        LinkLabel4.Location = New Point(28, 211)
        LinkLabel4.Name = "LinkLabel4"
        LinkLabel4.Size = New Size(168, 15)
        LinkLabel4.TabIndex = 9
        LinkLabel4.TabStop = True
        LinkLabel4.Text = "CARD Send File Delivery Tables"
        ' 
        ' LinkLabel3
        ' 
        LinkLabel3.AutoSize = True
        LinkLabel3.Location = New Point(28, 239)
        LinkLabel3.Name = "LinkLabel3"
        LinkLabel3.Size = New Size(130, 15)
        LinkLabel3.TabIndex = 8
        LinkLabel3.TabStop = True
        LinkLabel3.Text = "CARD Contact Info.doc"
        ' 
        ' TabPage5
        ' 
        TabPage5.Location = New Point(4, 24)
        TabPage5.Name = "TabPage5"
        TabPage5.Padding = New Padding(3)
        TabPage5.Size = New Size(1133, 384)
        TabPage5.TabIndex = 1
        TabPage5.Text = "TabPage5"
        TabPage5.UseVisualStyleBackColor = True
        ' 
        ' TabPage2
        ' 
        TabPage2.Location = New Point(4, 27)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1153, 570)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Documentation"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' TabPage3
        ' 
        TabPage3.Location = New Point(4, 27)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(1153, 570)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Personal"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(348, 34)
        Button3.Name = "Button3"
        Button3.Size = New Size(121, 23)
        Button3.TabIndex = 11
        Button3.Text = "Add Subproject"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' TreeView1
        ' 
        TreeView1.Location = New Point(12, 130)
        TreeView1.Name = "TreeView1"
        TreeNode1.Name = "Node5"
        TreeNode1.Text = "Logs"
        TreeNode2.Name = "Node6"
        TreeNode2.Text = "Bin"
        TreeNode3.Name = "Node1"
        TreeNode3.Text = "CARD"
        TreeNode4.Name = "Node2"
        TreeNode4.Text = "PIR"
        TreeNode5.Name = "Node3"
        TreeNode5.Text = "SWIFT"
        TreeNode6.Name = "Node7"
        TreeNode6.Text = "Communictions"
        TreeNode7.Name = "Node8"
        TreeNode7.Text = "Comm Logs"
        TreeNode8.Name = "Node9"
        TreeNode8.Text = "Batch Logs"
        TreeNode9.Name = "Node4"
        TreeNode9.Text = "BONY"
        TreeNode10.Name = "Node0"
        TreeNode10.Text = "Interfaces"
        TreeNode11.Name = "Node12"
        TreeNode11.Text = "CARD"
        TreeNode12.Name = "Node13"
        TreeNode12.NodeFont = New Font("Microsoft Sans Serif", 8.25F)
        TreeNode12.Text = "PIR"
        TreeNode13.Name = "Node10"
        TreeNode13.Text = "Documentation"
        TreeNode14.Name = "Node14"
        TreeNode14.Text = "Performance Reports"
        TreeNode15.Name = "Node15"
        TreeNode15.Text = "Goals and Classes"
        TreeNode16.Name = "Node11"
        TreeNode16.Text = "Personal"
        TreeView1.Nodes.AddRange(New TreeNode() {TreeNode10, TreeNode13, TreeNode16})
        TreeView1.Size = New Size(145, 573)
        TreeView1.TabIndex = 2
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, EditToolStripMenuItem, ToolsToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1326, 24)
        MenuStrip1.TabIndex = 3
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NewToolStripMenuItem, OpenToolStripMenuItem, toolStripSeparator, SaveToolStripMenuItem, SaveAsToolStripMenuItem, toolStripSeparator1, PrintToolStripMenuItem, PrintPreviewToolStripMenuItem, toolStripSeparator2, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "&File"
        ' 
        ' NewToolStripMenuItem
        ' 
        NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), Image)
        NewToolStripMenuItem.ImageTransparentColor = Color.Magenta
        NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        NewToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.N
        NewToolStripMenuItem.Size = New Size(146, 22)
        NewToolStripMenuItem.Text = "&New"
        ' 
        ' OpenToolStripMenuItem
        ' 
        OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), Image)
        OpenToolStripMenuItem.ImageTransparentColor = Color.Magenta
        OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        OpenToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.O
        OpenToolStripMenuItem.Size = New Size(146, 22)
        OpenToolStripMenuItem.Text = "&Open"
        ' 
        ' toolStripSeparator
        ' 
        toolStripSeparator.Name = "toolStripSeparator"
        toolStripSeparator.Size = New Size(143, 6)
        ' 
        ' SaveToolStripMenuItem
        ' 
        SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), Image)
        SaveToolStripMenuItem.ImageTransparentColor = Color.Magenta
        SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        SaveToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.S
        SaveToolStripMenuItem.Size = New Size(146, 22)
        SaveToolStripMenuItem.Text = "&Save"
        ' 
        ' SaveAsToolStripMenuItem
        ' 
        SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        SaveAsToolStripMenuItem.Size = New Size(146, 22)
        SaveAsToolStripMenuItem.Text = "Save &As"
        ' 
        ' toolStripSeparator1
        ' 
        toolStripSeparator1.Name = "toolStripSeparator1"
        toolStripSeparator1.Size = New Size(143, 6)
        ' 
        ' PrintToolStripMenuItem
        ' 
        PrintToolStripMenuItem.Image = CType(resources.GetObject("PrintToolStripMenuItem.Image"), Image)
        PrintToolStripMenuItem.ImageTransparentColor = Color.Magenta
        PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        PrintToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.P
        PrintToolStripMenuItem.Size = New Size(146, 22)
        PrintToolStripMenuItem.Text = "&Print"
        ' 
        ' PrintPreviewToolStripMenuItem
        ' 
        PrintPreviewToolStripMenuItem.Image = CType(resources.GetObject("PrintPreviewToolStripMenuItem.Image"), Image)
        PrintPreviewToolStripMenuItem.ImageTransparentColor = Color.Magenta
        PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        PrintPreviewToolStripMenuItem.Size = New Size(146, 22)
        PrintPreviewToolStripMenuItem.Text = "Print Pre&view"
        ' 
        ' toolStripSeparator2
        ' 
        toolStripSeparator2.Name = "toolStripSeparator2"
        toolStripSeparator2.Size = New Size(143, 6)
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(146, 22)
        ExitToolStripMenuItem.Text = "E&xit"
        ' 
        ' EditToolStripMenuItem
        ' 
        EditToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {UndoToolStripMenuItem, RedoToolStripMenuItem, toolStripSeparator3, CutToolStripMenuItem, CopyToolStripMenuItem, PasteToolStripMenuItem, toolStripSeparator4, SelectAllToolStripMenuItem})
        EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        EditToolStripMenuItem.Size = New Size(39, 20)
        EditToolStripMenuItem.Text = "&Edit"
        ' 
        ' UndoToolStripMenuItem
        ' 
        UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        UndoToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.Z
        UndoToolStripMenuItem.Size = New Size(144, 22)
        UndoToolStripMenuItem.Text = "&Undo"
        ' 
        ' RedoToolStripMenuItem
        ' 
        RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        RedoToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.Y
        RedoToolStripMenuItem.Size = New Size(144, 22)
        RedoToolStripMenuItem.Text = "&Redo"
        ' 
        ' toolStripSeparator3
        ' 
        toolStripSeparator3.Name = "toolStripSeparator3"
        toolStripSeparator3.Size = New Size(141, 6)
        ' 
        ' CutToolStripMenuItem
        ' 
        CutToolStripMenuItem.Image = CType(resources.GetObject("CutToolStripMenuItem.Image"), Image)
        CutToolStripMenuItem.ImageTransparentColor = Color.Magenta
        CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        CutToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.X
        CutToolStripMenuItem.Size = New Size(144, 22)
        CutToolStripMenuItem.Text = "Cu&t"
        ' 
        ' CopyToolStripMenuItem
        ' 
        CopyToolStripMenuItem.Image = CType(resources.GetObject("CopyToolStripMenuItem.Image"), Image)
        CopyToolStripMenuItem.ImageTransparentColor = Color.Magenta
        CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        CopyToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.C
        CopyToolStripMenuItem.Size = New Size(144, 22)
        CopyToolStripMenuItem.Text = "&Copy"
        ' 
        ' PasteToolStripMenuItem
        ' 
        PasteToolStripMenuItem.Image = CType(resources.GetObject("PasteToolStripMenuItem.Image"), Image)
        PasteToolStripMenuItem.ImageTransparentColor = Color.Magenta
        PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        PasteToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.V
        PasteToolStripMenuItem.Size = New Size(144, 22)
        PasteToolStripMenuItem.Text = "&Paste"
        ' 
        ' toolStripSeparator4
        ' 
        toolStripSeparator4.Name = "toolStripSeparator4"
        toolStripSeparator4.Size = New Size(141, 6)
        ' 
        ' SelectAllToolStripMenuItem
        ' 
        SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        SelectAllToolStripMenuItem.Size = New Size(144, 22)
        SelectAllToolStripMenuItem.Text = "Select &All"
        ' 
        ' ToolsToolStripMenuItem
        ' 
        ToolsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CustomizeToolStripMenuItem, OptionsToolStripMenuItem})
        ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        ToolsToolStripMenuItem.Size = New Size(46, 20)
        ToolsToolStripMenuItem.Text = "&Tools"
        ' 
        ' CustomizeToolStripMenuItem
        ' 
        CustomizeToolStripMenuItem.Name = "CustomizeToolStripMenuItem"
        CustomizeToolStripMenuItem.Size = New Size(130, 22)
        CustomizeToolStripMenuItem.Text = "&Customize"
        ' 
        ' OptionsToolStripMenuItem
        ' 
        OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        OptionsToolStripMenuItem.Size = New Size(130, 22)
        OptionsToolStripMenuItem.Text = "&Options"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ContentsToolStripMenuItem, IndexToolStripMenuItem, SearchToolStripMenuItem, toolStripSeparator5, AboutToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(44, 20)
        HelpToolStripMenuItem.Text = "&Help"
        ' 
        ' ContentsToolStripMenuItem
        ' 
        ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        ContentsToolStripMenuItem.Size = New Size(122, 22)
        ContentsToolStripMenuItem.Text = "&Contents"
        ' 
        ' IndexToolStripMenuItem
        ' 
        IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        IndexToolStripMenuItem.Size = New Size(122, 22)
        IndexToolStripMenuItem.Text = "&Index"
        ' 
        ' SearchToolStripMenuItem
        ' 
        SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        SearchToolStripMenuItem.Size = New Size(122, 22)
        SearchToolStripMenuItem.Text = "&Search"
        ' 
        ' toolStripSeparator5
        ' 
        toolStripSeparator5.Name = "toolStripSeparator5"
        toolStripSeparator5.Size = New Size(119, 6)
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(122, 22)
        AboutToolStripMenuItem.Text = "&About..."
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(Button4)
        GroupBox1.Controls.Add(Button3)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.FlatStyle = FlatStyle.Popup
        GroupBox1.Location = New Point(12, 32)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1304, 100)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "Project Maintenance"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(475, 35)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(164, 23)
        TextBox2.TabIndex = 13
        TextBox2.Text = "Subproject Name"
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(348, 63)
        Button4.Name = "Button4"
        Button4.Size = New Size(121, 23)
        Button4.TabIndex = 12
        Button4.Text = "Remove Subproject"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(175, 35)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(164, 23)
        TextBox1.TabIndex = 7
        TextBox1.Text = "Project Name"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(48, 63)
        Button2.Name = "Button2"
        Button2.Size = New Size(121, 23)
        Button2.TabIndex = 1
        Button2.Text = "Remove Project"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(48, 34)
        Button1.Name = "Button1"
        Button1.Size = New Size(121, 23)
        Button1.TabIndex = 0
        Button1.Text = "Add Project"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1326, 743)
        Controls.Add(GroupBox1)
        Controls.Add(TreeView1)
        Controls.Add(TabControl2)
        Controls.Add(MenuStrip1)
        Name = "Form1"
        Text = "Form1"
        TabControl2.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabControl1.ResumeLayout(False)
        TabPage4.ResumeLayout(False)
        TabPage4.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage2 As TabPage


    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)

        Dim tabpage As New TabPage
        TabControl2.Text = "(empty)"

        '      Dim textbox1 As New TextBox
        '     Dim textbox2 As New TextBox
        '
        ' TextBox1.Parent = tabpage
        'textbox2.Parent = tabpage
        '
        'TextBox1.Location = New Point(10, 10)
        'textbox2.Location = New Point(10, 30)

        TabControl2.TabPages.Add(tabpage)

    End Sub

    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintPreviewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As ToolStripSeparator
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button

    Private Function GetTabControl2() As TabControl
        Return TabControl2
    End Function


    Friend WithEvents TabPage3 As TabPage

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Select()
        CreateNewListBoxInsideNewPageTab(TextBox1.Text)
    End Sub

    Public Function CreateNewListBoxInsideNewPageTab(tabName As String) As ListBox
        Dim newTab As New TabPage()
        If tabName <> "" Then
            newTab.Text = tabName
        Else
            newTab.Text = "Tab " & TabControl2.TabPages.Count + 1
        End If


        Dim newLst As New ListBox
        newLst.Dock = DockStyle.Fill

        newTab.Controls.Add(newLst)
        TabControl2.TabPages.Add(newTab)
        TabControl2.SelectedTab = newTab
        Return newLst
    End Function

    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox2 As TextBox

    Friend WithEvents TextBox1 As TextBox

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TabControl2.TabPages.Remove(TabControl2.SelectedTab)
    End Sub

    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Button3 As Button

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox2.Select()
        CreateNewListBoxInsideNewPageTab2(TextBox2.Text)
    End Sub

    Public Function CreateNewListBoxInsideNewPageTab2(tabName As String) As ListBox
        Dim newTab As New TabPage()
        If tabName <> "" Then
            newTab.Text = tabName
        Else
            newTab.Text = "Tab " & TabControl1.TabPages.Count + 1
        End If


        Dim newLst As New ListBox
        newLst.Dock = DockStyle.Fill

        newTab.Controls.Add(newLst)
        TabControl1.TabPages.Add(newTab)
        TabControl1.SelectedTab = newTab
        Return newLst
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TabControl1.TabPages.Remove(TabControl1.SelectedTab)
    End Sub
End Class
