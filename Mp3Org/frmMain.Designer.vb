<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlSongList = New System.Windows.Forms.Panel()
        Me.dgvSongList = New System.Windows.Forms.DataGridView()
        Me.tsMain = New System.Windows.Forms.ToolStrip()
        Me.txtRunPath = New System.Windows.Forms.ToolStripTextBox()
        Me.btnBrowse = New System.Windows.Forms.ToolStripButton()
        Me.btnLoad = New System.Windows.Forms.ToolStripButton()
        Me.btnRun = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSearchCovers = New System.Windows.Forms.ToolStripButton()
        Me.cboFileNameOptions = New System.Windows.Forms.ToolStripComboBox()
        Me.lblFileNameOptions = New System.Windows.Forms.ToolStripLabel()
        Me.gboSongList = New System.Windows.Forms.GroupBox()
        Me.gboCover = New System.Windows.Forms.GroupBox()
        Me.tlpCover = New System.Windows.Forms.TableLayoutPanel()
        Me.picCover = New System.Windows.Forms.PictureBox()
        Me.lblCoverSize = New System.Windows.Forms.Label()
        Me.btnRemoveCover = New System.Windows.Forms.Button()
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlInfo = New System.Windows.Forms.Panel()
        Me.gboTagEditor = New System.Windows.Forms.GroupBox()
        Me.tlpTagEditor = New System.Windows.Forms.TableLayoutPanel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtGenre = New System.Windows.Forms.TextBox()
        Me.txtAlbum = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAlbumArtist = New System.Windows.Forms.TextBox()
        Me.txtArtist = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTrack = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTrackCount = New System.Windows.Forms.TextBox()
        Me.txtDisc = New System.Windows.Forms.TextBox()
        Me.txtDiscCount = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtBitRateString = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.picWaveForm = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.colCoverImage = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colArtist = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAlbumArtist = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTitle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAlbum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGenre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colYear = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTrack = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBitRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFullName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlSongList.SuspendLayout()
        CType(Me.dgvSongList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMain.SuspendLayout()
        Me.gboSongList.SuspendLayout()
        Me.gboCover.SuspendLayout()
        Me.tlpCover.SuspendLayout()
        CType(Me.picCover, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMain.SuspendLayout()
        Me.pnlInfo.SuspendLayout()
        Me.gboTagEditor.SuspendLayout()
        Me.tlpTagEditor.SuspendLayout()
        CType(Me.picWaveForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlSongList
        '
        Me.pnlSongList.Controls.Add(Me.dgvSongList)
        Me.pnlSongList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSongList.Location = New System.Drawing.Point(3, 16)
        Me.pnlSongList.Name = "pnlSongList"
        Me.pnlSongList.Size = New System.Drawing.Size(986, 277)
        Me.pnlSongList.TabIndex = 1
        '
        'dgvSongList
        '
        Me.dgvSongList.AllowDrop = True
        Me.dgvSongList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSongList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCoverImage, Me.colArtist, Me.colAlbumArtist, Me.colTitle, Me.colAlbum, Me.colGenre, Me.colYear, Me.colTrack, Me.colBitRate, Me.colFullName})
        Me.dgvSongList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSongList.Location = New System.Drawing.Point(0, 0)
        Me.dgvSongList.Name = "dgvSongList"
        Me.dgvSongList.RowHeadersWidth = 72
        Me.dgvSongList.RowTemplate.Height = 24
        Me.dgvSongList.Size = New System.Drawing.Size(986, 277)
        Me.dgvSongList.TabIndex = 0
        '
        'tsMain
        '
        Me.tsMain.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.tsMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtRunPath, Me.btnBrowse, Me.btnLoad, Me.btnRun, Me.ToolStripSeparator1, Me.btnSearchCovers, Me.cboFileNameOptions, Me.lblFileNameOptions})
        Me.tsMain.Location = New System.Drawing.Point(0, 0)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(998, 25)
        Me.tsMain.TabIndex = 2
        Me.tsMain.Text = "tsMain"
        '
        'txtRunPath
        '
        Me.txtRunPath.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.txtRunPath.Name = "txtRunPath"
        Me.txtRunPath.Size = New System.Drawing.Size(300, 25)
        '
        'btnBrowse
        '
        Me.btnBrowse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnBrowse.Image = CType(resources.GetObject("btnBrowse.Image"), System.Drawing.Image)
        Me.btnBrowse.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(59, 22)
        Me.btnBrowse.Text = "Browse..."
        '
        'btnLoad
        '
        Me.btnLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnLoad.Image = CType(resources.GetObject("btnLoad.Image"), System.Drawing.Image)
        Me.btnLoad.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(35, 22)
        Me.btnLoad.Text = "Load"
        '
        'btnRun
        '
        Me.btnRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnRun.Image = CType(resources.GetObject("btnRun.Image"), System.Drawing.Image)
        Me.btnRun.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(30, 22)
        Me.btnRun.Text = "Run"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnSearchCovers
        '
        Me.btnSearchCovers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnSearchCovers.Image = CType(resources.GetObject("btnSearchCovers.Image"), System.Drawing.Image)
        Me.btnSearchCovers.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSearchCovers.Name = "btnSearchCovers"
        Me.btnSearchCovers.Size = New System.Drawing.Size(93, 22)
        Me.btnSearchCovers.Text = "Search Covers..."
        '
        'cboFileNameOptions
        '
        Me.cboFileNameOptions.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cboFileNameOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFileNameOptions.Name = "cboFileNameOptions"
        Me.cboFileNameOptions.Size = New System.Drawing.Size(200, 25)
        '
        'lblFileNameOptions
        '
        Me.lblFileNameOptions.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblFileNameOptions.Name = "lblFileNameOptions"
        Me.lblFileNameOptions.Size = New System.Drawing.Size(85, 22)
        Me.lblFileNameOptions.Text = "Naming Options:"
        '
        'gboSongList
        '
        Me.gboSongList.Controls.Add(Me.pnlSongList)
        Me.gboSongList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gboSongList.Location = New System.Drawing.Point(3, 3)
        Me.gboSongList.Name = "gboSongList"
        Me.gboSongList.Size = New System.Drawing.Size(992, 296)
        Me.gboSongList.TabIndex = 3
        Me.gboSongList.TabStop = False
        Me.gboSongList.Text = "Song List"
        '
        'gboCover
        '
        Me.gboCover.Controls.Add(Me.tlpCover)
        Me.gboCover.Dock = System.Windows.Forms.DockStyle.Left
        Me.gboCover.Location = New System.Drawing.Point(0, 0)
        Me.gboCover.Name = "gboCover"
        Me.gboCover.Size = New System.Drawing.Size(221, 252)
        Me.gboCover.TabIndex = 4
        Me.gboCover.TabStop = False
        Me.gboCover.Text = "Cover"
        '
        'tlpCover
        '
        Me.tlpCover.ColumnCount = 2
        Me.tlpCover.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCover.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104.0!))
        Me.tlpCover.Controls.Add(Me.picCover, 0, 0)
        Me.tlpCover.Controls.Add(Me.lblCoverSize, 1, 1)
        Me.tlpCover.Controls.Add(Me.btnRemoveCover, 0, 1)
        Me.tlpCover.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCover.Location = New System.Drawing.Point(3, 16)
        Me.tlpCover.Name = "tlpCover"
        Me.tlpCover.RowCount = 3
        Me.tlpCover.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 189.0!))
        Me.tlpCover.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpCover.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCover.Size = New System.Drawing.Size(215, 233)
        Me.tlpCover.TabIndex = 0
        '
        'picCover
        '
        Me.tlpCover.SetColumnSpan(Me.picCover, 2)
        Me.picCover.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picCover.Location = New System.Drawing.Point(3, 3)
        Me.picCover.Name = "picCover"
        Me.picCover.Size = New System.Drawing.Size(209, 183)
        Me.picCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCover.TabIndex = 1
        Me.picCover.TabStop = False
        '
        'lblCoverSize
        '
        Me.lblCoverSize.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCoverSize.AutoSize = True
        Me.lblCoverSize.Location = New System.Drawing.Point(114, 200)
        Me.lblCoverSize.Name = "lblCoverSize"
        Me.lblCoverSize.Size = New System.Drawing.Size(98, 14)
        Me.lblCoverSize.TabIndex = 2
        Me.lblCoverSize.Text = " "
        '
        'btnRemoveCover
        '
        Me.btnRemoveCover.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRemoveCover.Location = New System.Drawing.Point(3, 192)
        Me.btnRemoveCover.Name = "btnRemoveCover"
        Me.btnRemoveCover.Size = New System.Drawing.Size(105, 30)
        Me.btnRemoveCover.TabIndex = 3
        Me.btnRemoveCover.Text = "Remove"
        Me.btnRemoveCover.UseVisualStyleBackColor = True
        '
        'tlpMain
        '
        Me.tlpMain.ColumnCount = 1
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.Controls.Add(Me.gboSongList, 0, 0)
        Me.tlpMain.Controls.Add(Me.pnlInfo, 0, 1)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(0, 25)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 2
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 258.0!))
        Me.tlpMain.Size = New System.Drawing.Size(998, 560)
        Me.tlpMain.TabIndex = 5
        '
        'pnlInfo
        '
        Me.pnlInfo.Controls.Add(Me.gboTagEditor)
        Me.pnlInfo.Controls.Add(Me.gboCover)
        Me.pnlInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlInfo.Location = New System.Drawing.Point(3, 305)
        Me.pnlInfo.Name = "pnlInfo"
        Me.pnlInfo.Size = New System.Drawing.Size(992, 252)
        Me.pnlInfo.TabIndex = 5
        '
        'gboTagEditor
        '
        Me.gboTagEditor.Controls.Add(Me.tlpTagEditor)
        Me.gboTagEditor.Controls.Add(Me.picWaveForm)
        Me.gboTagEditor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gboTagEditor.Location = New System.Drawing.Point(221, 0)
        Me.gboTagEditor.Name = "gboTagEditor"
        Me.gboTagEditor.Size = New System.Drawing.Size(771, 252)
        Me.gboTagEditor.TabIndex = 5
        Me.gboTagEditor.TabStop = False
        Me.gboTagEditor.Text = "Tags"
        '
        'tlpTagEditor
        '
        Me.tlpTagEditor.ColumnCount = 6
        Me.tlpTagEditor.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpTagEditor.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTagEditor.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.tlpTagEditor.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72.0!))
        Me.tlpTagEditor.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66.0!))
        Me.tlpTagEditor.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tlpTagEditor.Controls.Add(Me.Label14, 0, 0)
        Me.tlpTagEditor.Controls.Add(Me.txtFileName, 1, 0)
        Me.tlpTagEditor.Controls.Add(Me.txtComment, 1, 7)
        Me.tlpTagEditor.Controls.Add(Me.Label6, 0, 7)
        Me.tlpTagEditor.Controls.Add(Me.Label5, 0, 6)
        Me.tlpTagEditor.Controls.Add(Me.txtGenre, 1, 6)
        Me.tlpTagEditor.Controls.Add(Me.txtAlbum, 1, 5)
        Me.tlpTagEditor.Controls.Add(Me.Label4, 0, 5)
        Me.tlpTagEditor.Controls.Add(Me.Label3, 0, 4)
        Me.tlpTagEditor.Controls.Add(Me.txtAlbumArtist, 1, 4)
        Me.tlpTagEditor.Controls.Add(Me.txtArtist, 1, 3)
        Me.tlpTagEditor.Controls.Add(Me.Label2, 0, 3)
        Me.tlpTagEditor.Controls.Add(Me.Label1, 0, 2)
        Me.tlpTagEditor.Controls.Add(Me.txtTitle, 1, 2)
        Me.tlpTagEditor.Controls.Add(Me.Label7, 3, 2)
        Me.tlpTagEditor.Controls.Add(Me.Label8, 3, 3)
        Me.tlpTagEditor.Controls.Add(Me.Label9, 3, 4)
        Me.tlpTagEditor.Controls.Add(Me.txtTrack, 4, 3)
        Me.tlpTagEditor.Controls.Add(Me.txtYear, 4, 2)
        Me.tlpTagEditor.Controls.Add(Me.Label10, 3, 5)
        Me.tlpTagEditor.Controls.Add(Me.Label11, 3, 6)
        Me.tlpTagEditor.Controls.Add(Me.txtTrackCount, 4, 4)
        Me.tlpTagEditor.Controls.Add(Me.txtDisc, 4, 5)
        Me.tlpTagEditor.Controls.Add(Me.txtDiscCount, 4, 6)
        Me.tlpTagEditor.Controls.Add(Me.Label12, 3, 0)
        Me.tlpTagEditor.Controls.Add(Me.txtBitRateString, 4, 0)
        Me.tlpTagEditor.Controls.Add(Me.Label13, 3, 1)
        Me.tlpTagEditor.Controls.Add(Me.txtLength, 4, 1)
        Me.tlpTagEditor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpTagEditor.Location = New System.Drawing.Point(3, 16)
        Me.tlpTagEditor.Name = "tlpTagEditor"
        Me.tlpTagEditor.RowCount = 9
        Me.tlpTagEditor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpTagEditor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpTagEditor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpTagEditor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpTagEditor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpTagEditor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpTagEditor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpTagEditor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpTagEditor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTagEditor.Size = New System.Drawing.Size(765, 233)
        Me.tlpTagEditor.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(3, 5)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 14)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "FileName:"
        '
        'txtFileName
        '
        Me.txtFileName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFileName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtFileName.Location = New System.Drawing.Point(103, 3)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.ReadOnly = True
        Me.txtFileName.Size = New System.Drawing.Size(481, 20)
        Me.txtFileName.TabIndex = 0
        '
        'txtComment
        '
        Me.txtComment.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtComment.Location = New System.Drawing.Point(103, 178)
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(481, 20)
        Me.txtComment.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 14)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Comment:"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 14)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Genre:"
        '
        'txtGenre
        '
        Me.txtGenre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGenre.Location = New System.Drawing.Point(103, 153)
        Me.txtGenre.Name = "txtGenre"
        Me.txtGenre.Size = New System.Drawing.Size(481, 20)
        Me.txtGenre.TabIndex = 5
        '
        'txtAlbum
        '
        Me.txtAlbum.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAlbum.Location = New System.Drawing.Point(103, 128)
        Me.txtAlbum.Name = "txtAlbum"
        Me.txtAlbum.Size = New System.Drawing.Size(481, 20)
        Me.txtAlbum.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 14)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Album:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 14)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Album Artist:"
        '
        'txtAlbumArtist
        '
        Me.txtAlbumArtist.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAlbumArtist.Location = New System.Drawing.Point(103, 103)
        Me.txtAlbumArtist.Name = "txtAlbumArtist"
        Me.txtAlbumArtist.Size = New System.Drawing.Size(481, 20)
        Me.txtAlbumArtist.TabIndex = 3
        '
        'txtArtist
        '
        Me.txtArtist.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtArtist.Location = New System.Drawing.Point(103, 78)
        Me.txtArtist.Name = "txtArtist"
        Me.txtArtist.Size = New System.Drawing.Size(481, 20)
        Me.txtArtist.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Artist:"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Title:"
        '
        'txtTitle
        '
        Me.txtTitle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTitle.Location = New System.Drawing.Point(103, 53)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(481, 20)
        Me.txtTitle.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(622, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 14)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Year:"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(622, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 14)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Track#:"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(622, 105)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 14)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Tracks:"
        '
        'txtTrack
        '
        Me.txtTrack.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTrack.Location = New System.Drawing.Point(694, 78)
        Me.txtTrack.Name = "txtTrack"
        Me.txtTrack.Size = New System.Drawing.Size(60, 20)
        Me.txtTrack.TabIndex = 8
        '
        'txtYear
        '
        Me.txtYear.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtYear.Location = New System.Drawing.Point(694, 53)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(60, 20)
        Me.txtYear.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(622, 130)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 14)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Disc#:"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(622, 155)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 14)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Discs:"
        '
        'txtTrackCount
        '
        Me.txtTrackCount.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTrackCount.Location = New System.Drawing.Point(694, 103)
        Me.txtTrackCount.Name = "txtTrackCount"
        Me.txtTrackCount.Size = New System.Drawing.Size(60, 20)
        Me.txtTrackCount.TabIndex = 9
        '
        'txtDisc
        '
        Me.txtDisc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDisc.Location = New System.Drawing.Point(694, 128)
        Me.txtDisc.Name = "txtDisc"
        Me.txtDisc.Size = New System.Drawing.Size(60, 20)
        Me.txtDisc.TabIndex = 10
        '
        'txtDiscCount
        '
        Me.txtDiscCount.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDiscCount.Location = New System.Drawing.Point(694, 153)
        Me.txtDiscCount.Name = "txtDiscCount"
        Me.txtDiscCount.Size = New System.Drawing.Size(60, 20)
        Me.txtDiscCount.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(622, 5)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 14)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "BitRate:"
        '
        'txtBitRateString
        '
        Me.txtBitRateString.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBitRateString.Enabled = False
        Me.txtBitRateString.Location = New System.Drawing.Point(694, 3)
        Me.txtBitRateString.Name = "txtBitRateString"
        Me.txtBitRateString.Size = New System.Drawing.Size(60, 20)
        Me.txtBitRateString.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(622, 30)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 14)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Length"
        '
        'txtLength
        '
        Me.txtLength.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLength.Enabled = False
        Me.txtLength.Location = New System.Drawing.Point(694, 28)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(60, 20)
        Me.txtLength.TabIndex = 0
        '
        'picWaveForm
        '
        Me.picWaveForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picWaveForm.Location = New System.Drawing.Point(3, 16)
        Me.picWaveForm.Name = "picWaveForm"
        Me.picWaveForm.Size = New System.Drawing.Size(765, 233)
        Me.picWaveForm.TabIndex = 0
        Me.picWaveForm.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 585)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(998, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'colCoverImage
        '
        Me.colCoverImage.DataPropertyName = "Cover"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.NullValue = Nothing
        Me.colCoverImage.DefaultCellStyle = DataGridViewCellStyle1
        Me.colCoverImage.HeaderText = "Cover"
        Me.colCoverImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.colCoverImage.MinimumWidth = 50
        Me.colCoverImage.Name = "colCoverImage"
        Me.colCoverImage.ReadOnly = True
        Me.colCoverImage.Width = 50
        '
        'colArtist
        '
        Me.colArtist.DataPropertyName = "Artist"
        Me.colArtist.HeaderText = "Artist"
        Me.colArtist.MinimumWidth = 100
        Me.colArtist.Name = "colArtist"
        Me.colArtist.Width = 150
        '
        'colAlbumArtist
        '
        Me.colAlbumArtist.DataPropertyName = "AlbumArtist"
        Me.colAlbumArtist.HeaderText = "Album Artist"
        Me.colAlbumArtist.MinimumWidth = 100
        Me.colAlbumArtist.Name = "colAlbumArtist"
        Me.colAlbumArtist.Width = 150
        '
        'colTitle
        '
        Me.colTitle.DataPropertyName = "Title"
        Me.colTitle.HeaderText = "Title"
        Me.colTitle.MinimumWidth = 100
        Me.colTitle.Name = "colTitle"
        Me.colTitle.Width = 150
        '
        'colAlbum
        '
        Me.colAlbum.DataPropertyName = "Album"
        Me.colAlbum.HeaderText = "Album"
        Me.colAlbum.MinimumWidth = 100
        Me.colAlbum.Name = "colAlbum"
        Me.colAlbum.Width = 150
        '
        'colGenre
        '
        Me.colGenre.DataPropertyName = "Genre"
        Me.colGenre.HeaderText = "Genre"
        Me.colGenre.MinimumWidth = 75
        Me.colGenre.Name = "colGenre"
        Me.colGenre.Width = 75
        '
        'colYear
        '
        Me.colYear.DataPropertyName = "Year"
        Me.colYear.HeaderText = "Year"
        Me.colYear.MinimumWidth = 75
        Me.colYear.Name = "colYear"
        Me.colYear.Width = 75
        '
        'colTrack
        '
        Me.colTrack.DataPropertyName = "Track"
        Me.colTrack.HeaderText = "#"
        Me.colTrack.MinimumWidth = 40
        Me.colTrack.Name = "colTrack"
        Me.colTrack.Width = 40
        '
        'colBitRate
        '
        Me.colBitRate.DataPropertyName = "BitRateString"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colBitRate.DefaultCellStyle = DataGridViewCellStyle2
        Me.colBitRate.HeaderText = "BitRate"
        Me.colBitRate.MinimumWidth = 60
        Me.colBitRate.Name = "colBitRate"
        Me.colBitRate.ReadOnly = True
        Me.colBitRate.Width = 60
        '
        'colFullName
        '
        Me.colFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colFullName.DataPropertyName = "FullName"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colFullName.DefaultCellStyle = DataGridViewCellStyle3
        Me.colFullName.HeaderText = "FullName"
        Me.colFullName.MinimumWidth = 300
        Me.colFullName.Name = "colFullName"
        Me.colFullName.ReadOnly = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 607)
        Me.Controls.Add(Me.tlpMain)
        Me.Controls.Add(Me.tsMain)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frmMain"
        Me.Text = "Mp3Org"
        Me.pnlSongList.ResumeLayout(False)
        CType(Me.dgvSongList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        Me.gboSongList.ResumeLayout(False)
        Me.gboCover.ResumeLayout(False)
        Me.tlpCover.ResumeLayout(False)
        Me.tlpCover.PerformLayout()
        CType(Me.picCover, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMain.ResumeLayout(False)
        Me.pnlInfo.ResumeLayout(False)
        Me.gboTagEditor.ResumeLayout(False)
        Me.tlpTagEditor.ResumeLayout(False)
        Me.tlpTagEditor.PerformLayout()
        CType(Me.picWaveForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlSongList As Panel
    Friend WithEvents tsMain As ToolStrip
    Friend WithEvents txtRunPath As ToolStripTextBox
    Friend WithEvents btnLoad As ToolStripButton
    Friend WithEvents gboSongList As GroupBox
    Friend WithEvents dgvSongList As DataGridView
    Friend WithEvents btnBrowse As ToolStripButton
    Friend WithEvents btnRun As ToolStripButton
    Friend WithEvents gboCover As GroupBox
    Friend WithEvents btnSearchCovers As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tlpMain As TableLayoutPanel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents pnlInfo As Panel
    Friend WithEvents gboTagEditor As GroupBox
    Friend WithEvents picWaveForm As PictureBox
    Friend WithEvents tlpTagEditor As TableLayoutPanel
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtArtist As TextBox
    Friend WithEvents txtAlbumArtist As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAlbum As TextBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtComment As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtYear As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtTrack As TextBox
    Friend WithEvents txtTrackCount As TextBox
    Friend WithEvents txtDisc As TextBox
    Friend WithEvents txtDiscCount As TextBox
    Friend WithEvents tlpCover As TableLayoutPanel
    Friend WithEvents picCover As PictureBox
    Friend WithEvents txtBitRateString As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtLength As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtFileName As TextBox
    Friend WithEvents lblCoverSize As Label
    Friend WithEvents btnRemoveCover As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents cboFileNameOptions As ToolStripComboBox
    Friend WithEvents lblFileNameOptions As ToolStripLabel
    Friend WithEvents colCoverImage As DataGridViewImageColumn
    Friend WithEvents colArtist As DataGridViewTextBoxColumn
    Friend WithEvents colAlbumArtist As DataGridViewTextBoxColumn
    Friend WithEvents colTitle As DataGridViewTextBoxColumn
    Friend WithEvents colAlbum As DataGridViewTextBoxColumn
    Friend WithEvents colGenre As DataGridViewTextBoxColumn
    Friend WithEvents colYear As DataGridViewTextBoxColumn
    Friend WithEvents colTrack As DataGridViewTextBoxColumn
    Friend WithEvents colBitRate As DataGridViewTextBoxColumn
    Friend WithEvents colFullName As DataGridViewTextBoxColumn
End Class
