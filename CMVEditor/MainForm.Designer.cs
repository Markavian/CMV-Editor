namespace CMVEditor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            CMVData.TileSet tileSet3 = new CMVData.TileSet();
            CMVData.CMV cmv2 = new CMVData.CMV();
            CMVData.TileSet tileSet4 = new CMVData.TileSet();
            this.panelControls = new System.Windows.Forms.Panel();
            this.timelineControl = new CMVEditorComponents.TimelineControl();
            this.flowLayoutControls = new System.Windows.Forms.FlowLayoutPanel();
            this.playerControls = new CMVEditorComponents.PlayerControls();
            this.timelineControls = new CMVEditorComponents.TimelineControls();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCMVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.revertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.cropToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateFrameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.padFramesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stripFramesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
            this.exportFrameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpTopicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.bay12GamesWebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.openCMVFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveCMVFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.saveImageFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolTipProvider = new System.Windows.Forms.ToolTip(this.components);
            this.buttonBrowseForTileset = new System.Windows.Forms.Button();
            this.openImageFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panelForTools = new System.Windows.Forms.Panel();
            this.toolbarLabel = new System.Windows.Forms.Label();
            this.colorPickerLabel2 = new System.Windows.Forms.Label();
            this.colorPickerLabel1 = new System.Windows.Forms.Label();
            this.foregroundColourPicker = new CMVEditorComponents.ColourPickerControl();
            this.backgroundColourPicker = new CMVEditorComponents.ColourPickerControl();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolButtonNone = new System.Windows.Forms.ToolStripButton();
            this.toolButtonPaint = new System.Windows.Forms.ToolStripButton();
            this.toolButtonSelection = new System.Windows.Forms.ToolStripButton();
            this.toolButtonText = new System.Windows.Forms.ToolStripButton();
            this.cmvInfoControl = new CMVEditorComponents.CMVInfoControl();
            this.groupBrushStyle = new System.Windows.Forms.GroupBox();
            this.tileSelector = new CMVEditorComponents.TileSelector();
            this.mainSurface = new System.Windows.Forms.Panel();
            this.cmvPlayer = new CMVEditorComponents.CMVPlayerEditor();
            this.panelControls.SuspendLayout();
            this.flowLayoutControls.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.panelForTools.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.groupBrushStyle.SuspendLayout();
            this.mainSurface.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.timelineControl);
            this.panelControls.Controls.Add(this.flowLayoutControls);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControls.Location = new System.Drawing.Point(0, 295);
            this.panelControls.Name = "panelControls";
            this.panelControls.Padding = new System.Windows.Forms.Padding(4);
            this.panelControls.Size = new System.Drawing.Size(743, 86);
            this.panelControls.TabIndex = 0;
            // 
            // timelineControl
            // 
            this.timelineControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.timelineControl.FrameCount = 0;
            this.timelineControl.Location = new System.Drawing.Point(4, 3);
            this.timelineControl.Name = "timelineControl";
            this.timelineControl.PlayHeadPosition = 0;
            this.timelineControl.SelectionEnd = -1;
            this.timelineControl.SelectionStart = -1;
            this.timelineControl.Size = new System.Drawing.Size(735, 39);
            this.timelineControl.TabIndex = 2;
            this.timelineControl.TrackPlayhead = true;
            this.timelineControl.ViewOffset = 0;
            this.timelineControl.Zoom = 1F;
            this.timelineControl.FrameSelected += new CMVEditorComponents.TimelineControl.IndexHandler(this.timelineControl_FrameSelected);
            // 
            // flowLayoutControls
            // 
            this.flowLayoutControls.Controls.Add(this.playerControls);
            this.flowLayoutControls.Controls.Add(this.timelineControls);
            this.flowLayoutControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutControls.Location = new System.Drawing.Point(4, 42);
            this.flowLayoutControls.Name = "flowLayoutControls";
            this.flowLayoutControls.Size = new System.Drawing.Size(735, 40);
            this.flowLayoutControls.TabIndex = 1;
            // 
            // playerControls
            // 
            this.playerControls.AutoSize = true;
            this.playerControls.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.playerControls.FrameNumberText = "";
            this.playerControls.Location = new System.Drawing.Point(3, 3);
            this.playerControls.Name = "playerControls";
            this.playerControls.Size = new System.Drawing.Size(299, 36);
            this.playerControls.TabIndex = 0;
            this.playerControls.PlayClick += new System.EventHandler(this.action_cmvPlayerPlay);
            this.playerControls.StepForwardsClick += new System.EventHandler(this.action_cmvPlayerStepForwards);
            this.playerControls.StepBackwardsClick += new System.EventHandler(this.action_cmvPlayerStepBackwards);
            this.playerControls.RewindClick += new System.EventHandler(this.action_cmvPlayerRewind);
            this.playerControls.PauseClick += new System.EventHandler(this.action_cmvPlayerPause);
            this.playerControls.SkipToEndClick += new System.EventHandler(this.action_cmvPlayerSkipToEnd);
            // 
            // timelineControls
            // 
            this.timelineControls.AutoSize = true;
            this.timelineControls.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.timelineControls.Location = new System.Drawing.Point(308, 3);
            this.timelineControls.Name = "timelineControls";
            this.timelineControls.PasteEnabled = false;
            this.timelineControls.Size = new System.Drawing.Size(424, 36);
            this.timelineControls.TabIndex = 1;
            this.timelineControls.Timeline = this.timelineControl;
            this.timelineControls.UndoEnabled = false;
            this.timelineControls.DeleteClick += new System.EventHandler(this.action_Delete);
            this.timelineControls.CopyClick += new System.EventHandler(this.action_Copy);
            this.timelineControls.UndoClick += new System.EventHandler(this.action_Undo);
            this.timelineControls.StripClick += new System.EventHandler(this.action_Strip);
            this.timelineControls.CropClick += new System.EventHandler(this.action_Crop);
            this.timelineControls.PasteClick += new System.EventHandler(this.action_Paste);
            this.timelineControls.PadClick += new System.EventHandler(this.action_Pad);
            this.timelineControls.CutClick += new System.EventHandler(this.action_Cut);
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.shareToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(743, 24);
            this.menuStripMain.TabIndex = 2;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openCMVToolStripMenuItem,
            this.toolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.revertToolStripMenuItem,
            this.toolStripMenuItem3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.newToolStripMenuItem.Text = "New...";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.action_NewFile);
            // 
            // openCMVToolStripMenuItem
            // 
            this.openCMVToolStripMenuItem.Name = "openCMVToolStripMenuItem";
            this.openCMVToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.openCMVToolStripMenuItem.Text = "Open CMV";
            this.openCMVToolStripMenuItem.Click += new System.EventHandler(this.action_OpenCMV);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(122, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.action_SaveCMV);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.action_SaveAsCMV);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(122, 6);
            // 
            // revertToolStripMenuItem
            // 
            this.revertToolStripMenuItem.Name = "revertToolStripMenuItem";
            this.revertToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.revertToolStripMenuItem.Text = "Revert";
            this.revertToolStripMenuItem.Click += new System.EventHandler(this.action_Revert);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(122, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.action_Exit);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.toolStripMenuItem7,
            this.cropToolStripMenuItem,
            this.splitToolStripMenuItem,
            this.deleteSelectionToolStripMenuItem,
            this.toolStripMenuItem4,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.duplicateFrameToolStripMenuItem,
            this.toolStripMenuItem5,
            this.padFramesToolStripMenuItem,
            this.stripFramesToolStripMenuItem,
            this.toolStripMenuItem6,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.editToolStripMenuItem.Text = "Timeline";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.action_Undo);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(222, 6);
            // 
            // cropToolStripMenuItem
            // 
            this.cropToolStripMenuItem.Name = "cropToolStripMenuItem";
            this.cropToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.cropToolStripMenuItem.Text = "Crop to selection";
            this.cropToolStripMenuItem.Click += new System.EventHandler(this.action_Crop);
            // 
            // splitToolStripMenuItem
            // 
            this.splitToolStripMenuItem.Enabled = false;
            this.splitToolStripMenuItem.Name = "splitToolStripMenuItem";
            this.splitToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.splitToolStripMenuItem.Text = "Split selection...";
            // 
            // deleteSelectionToolStripMenuItem
            // 
            this.deleteSelectionToolStripMenuItem.Name = "deleteSelectionToolStripMenuItem";
            this.deleteSelectionToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteSelectionToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.deleteSelectionToolStripMenuItem.Text = "Delete selection";
            this.deleteSelectionToolStripMenuItem.Click += new System.EventHandler(this.action_Delete);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(222, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.action_Cut);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.action_Copy);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.action_Paste);
            // 
            // duplicateFrameToolStripMenuItem
            // 
            this.duplicateFrameToolStripMenuItem.Name = "duplicateFrameToolStripMenuItem";
            this.duplicateFrameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.duplicateFrameToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.duplicateFrameToolStripMenuItem.Text = "Duplicate Frame";
            this.duplicateFrameToolStripMenuItem.Click += new System.EventHandler(this.action_DuplicateFrame);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(222, 6);
            // 
            // padFramesToolStripMenuItem
            // 
            this.padFramesToolStripMenuItem.Enabled = false;
            this.padFramesToolStripMenuItem.Name = "padFramesToolStripMenuItem";
            this.padFramesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.padFramesToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.padFramesToolStripMenuItem.Text = "Pad frames...";
            // 
            // stripFramesToolStripMenuItem
            // 
            this.stripFramesToolStripMenuItem.Enabled = false;
            this.stripFramesToolStripMenuItem.Name = "stripFramesToolStripMenuItem";
            this.stripFramesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.stripFramesToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.stripFramesToolStripMenuItem.Text = "Strip frames...";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(222, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.selectAllToolStripMenuItem.Text = "Select all";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.action_selectAll);
            // 
            // shareToolStripMenuItem
            // 
            this.shareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uploadMovieToolStripMenuItem,
            this.toolStripMenuItem10,
            this.exportFrameToolStripMenuItem});
            this.shareToolStripMenuItem.Name = "shareToolStripMenuItem";
            this.shareToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.shareToolStripMenuItem.Text = "Share";
            // 
            // uploadMovieToolStripMenuItem
            // 
            this.uploadMovieToolStripMenuItem.Name = "uploadMovieToolStripMenuItem";
            this.uploadMovieToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.uploadMovieToolStripMenuItem.Text = "Upload Movie to Archive";
            this.uploadMovieToolStripMenuItem.Click += new System.EventHandler(this.action_uploadMovieToArchive);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(187, 6);
            // 
            // exportFrameToolStripMenuItem
            // 
            this.exportFrameToolStripMenuItem.Name = "exportFrameToolStripMenuItem";
            this.exportFrameToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.exportFrameToolStripMenuItem.Text = "Export frame...";
            this.exportFrameToolStripMenuItem.Click += new System.EventHandler(this.action_exportFrame);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpTopicsToolStripMenuItem,
            this.toolStripMenuItem9,
            this.bay12GamesWebsiteToolStripMenuItem,
            this.toolStripMenuItem8,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpTopicsToolStripMenuItem
            // 
            this.helpTopicsToolStripMenuItem.Name = "helpTopicsToolStripMenuItem";
            this.helpTopicsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.helpTopicsToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.helpTopicsToolStripMenuItem.Text = "Help Topics";
            this.helpTopicsToolStripMenuItem.Click += new System.EventHandler(this.action_HelpTopics);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(175, 6);
            // 
            // bay12GamesWebsiteToolStripMenuItem
            // 
            this.bay12GamesWebsiteToolStripMenuItem.Name = "bay12GamesWebsiteToolStripMenuItem";
            this.bay12GamesWebsiteToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.bay12GamesWebsiteToolStripMenuItem.Text = "Bay12Games Website";
            this.bay12GamesWebsiteToolStripMenuItem.Click += new System.EventHandler(this.action_VisitBay12gamesWebsite);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(175, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.action_About);
            // 
            // openCMVFileDialog
            // 
            this.openCMVFileDialog.Filter = "DF Movie files|*.cmv|DFMA Compressed Movie files|*.ccmv|All files|*.*";
            this.openCMVFileDialog.Title = "Open CMV Movie file...";
            // 
            // saveCMVFileDialog
            // 
            this.saveCMVFileDialog.Filter = "DF Movie files|*.cmv|DFMA Compressed Movie files|*.ccmv|All files|*.*";
            this.saveCMVFileDialog.Title = "Save CMV Movie file...";
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 150);
            // 
            // saveImageFileDialog
            // 
            this.saveImageFileDialog.Filter = "PNG (Compressed)|*.png|BMP (Uncompressed)|*.bmp|JPG (Lossy compression)|*.jpg";
            this.saveImageFileDialog.Title = "Save Image file...";
            // 
            // buttonBrowseForTileset
            // 
            this.buttonBrowseForTileset.Image = global::CMVEditor.Properties.Resources.browse_icon_x24;
            this.buttonBrowseForTileset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBrowseForTileset.Location = new System.Drawing.Point(100, 51);
            this.buttonBrowseForTileset.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBrowseForTileset.Name = "buttonBrowseForTileset";
            this.buttonBrowseForTileset.Size = new System.Drawing.Size(32, 32);
            this.buttonBrowseForTileset.TabIndex = 3;
            this.buttonBrowseForTileset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipProvider.SetToolTip(this.buttonBrowseForTileset, "Choose new tileset");
            this.buttonBrowseForTileset.UseVisualStyleBackColor = true;
            this.buttonBrowseForTileset.Click += new System.EventHandler(this.action_ChooseNewTileset);
            // 
            // openImageFileDialog
            // 
            this.openImageFileDialog.Filter = "Tileset Files|*.bmp;*.png";
            this.openImageFileDialog.Title = "Open Image file...";
            // 
            // panelForTools
            // 
            this.panelForTools.Controls.Add(this.backgroundColourPicker);
            this.panelForTools.Controls.Add(this.toolbarLabel);
            this.panelForTools.Controls.Add(this.colorPickerLabel2);
            this.panelForTools.Controls.Add(this.colorPickerLabel1);
            this.panelForTools.Controls.Add(this.foregroundColourPicker);
            this.panelForTools.Controls.Add(this.toolStrip);
            this.panelForTools.Controls.Add(this.cmvInfoControl);
            this.panelForTools.Controls.Add(this.groupBrushStyle);
            this.panelForTools.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelForTools.Location = new System.Drawing.Point(591, 24);
            this.panelForTools.MinimumSize = new System.Drawing.Size(152, 271);
            this.panelForTools.Name = "panelForTools";
            this.panelForTools.Size = new System.Drawing.Size(152, 271);
            this.panelForTools.TabIndex = 8;
            // 
            // toolbarLabel
            // 
            this.toolbarLabel.AutoSize = true;
            this.toolbarLabel.Location = new System.Drawing.Point(4, 103);
            this.toolbarLabel.Name = "toolbarLabel";
            this.toolbarLabel.Size = new System.Drawing.Size(33, 13);
            this.toolbarLabel.TabIndex = 14;
            this.toolbarLabel.Text = "Tools";
            // 
            // colorPickerLabel2
            // 
            this.colorPickerLabel2.AutoSize = true;
            this.colorPickerLabel2.Location = new System.Drawing.Point(3, 127);
            this.colorPickerLabel2.Name = "colorPickerLabel2";
            this.colorPickerLabel2.Size = new System.Drawing.Size(21, 13);
            this.colorPickerLabel2.TabIndex = 13;
            this.colorPickerLabel2.Text = "FG";
            // 
            // colorPickerLabel1
            // 
            this.colorPickerLabel1.AutoSize = true;
            this.colorPickerLabel1.Location = new System.Drawing.Point(3, 159);
            this.colorPickerLabel1.Name = "colorPickerLabel1";
            this.colorPickerLabel1.Size = new System.Drawing.Size(22, 13);
            this.colorPickerLabel1.TabIndex = 12;
            this.colorPickerLabel1.Text = "BG";
            // 
            // foregroundColourPicker
            // 
            this.foregroundColourPicker.AutoSize = true;
            this.foregroundColourPicker.Colors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(55))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(112)))), ((int)(((byte)(41))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(50))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(180)))), ((int)(((byte)(240))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))};
            this.foregroundColourPicker.Location = new System.Drawing.Point(25, 127);
            this.foregroundColourPicker.Name = "foregroundColourPicker";
            this.foregroundColourPicker.Size = new System.Drawing.Size(120, 33);
            this.foregroundColourPicker.TabIndex = 11;
            this.foregroundColourPicker.ColorSelected += new CMVEditorComponents.ColourPickerControl.ColorEvent(this.foregroundColourPicked);
            // 
            // backgroundColourPicker
            // 
            this.backgroundColourPicker.AutoSize = true;
            this.backgroundColourPicker.Colors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(55))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(112)))), ((int)(((byte)(41))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))))};
            this.backgroundColourPicker.Location = new System.Drawing.Point(25, 159);
            this.backgroundColourPicker.Name = "backgroundColourPicker";
            this.backgroundColourPicker.Size = new System.Drawing.Size(120, 17);
            this.backgroundColourPicker.TabIndex = 10;
            this.backgroundColourPicker.ColorSelected += new CMVEditorComponents.ColourPickerControl.ColorEvent(this.backgroundColourPicked);
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolButtonNone,
            this.toolButtonPaint,
            this.toolButtonSelection,
            this.toolButtonText});
            this.toolStrip.Location = new System.Drawing.Point(39, 97);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(106, 25);
            this.toolStrip.TabIndex = 9;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolButtonNone
            // 
            this.toolButtonNone.CheckOnClick = true;
            this.toolButtonNone.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolButtonNone.Image = global::CMVEditor.Properties.Resources.icon_cursor_x16;
            this.toolButtonNone.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolButtonNone.Margin = new System.Windows.Forms.Padding(6, 1, 0, 2);
            this.toolButtonNone.Name = "toolButtonNone";
            this.toolButtonNone.Size = new System.Drawing.Size(23, 22);
            this.toolButtonNone.Text = "No tool";
            this.toolButtonNone.Click += new System.EventHandler(this.action_toolSelectNone);
            // 
            // toolButtonPaint
            // 
            this.toolButtonPaint.CheckOnClick = true;
            this.toolButtonPaint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolButtonPaint.Image = global::CMVEditor.Properties.Resources.icon_paintbrush_x16;
            this.toolButtonPaint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolButtonPaint.Name = "toolButtonPaint";
            this.toolButtonPaint.Size = new System.Drawing.Size(23, 22);
            this.toolButtonPaint.Text = "Paint Brush";
            this.toolButtonPaint.Click += new System.EventHandler(this.action_toolSelectPaintBrush);
            // 
            // toolButtonSelection
            // 
            this.toolButtonSelection.CheckOnClick = true;
            this.toolButtonSelection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolButtonSelection.Image = global::CMVEditor.Properties.Resources.icon_selection_x16;
            this.toolButtonSelection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolButtonSelection.Name = "toolButtonSelection";
            this.toolButtonSelection.Size = new System.Drawing.Size(23, 22);
            this.toolButtonSelection.Text = "Selection Area Tool";
            this.toolButtonSelection.Click += new System.EventHandler(this.action_toolSelectSelection);
            // 
            // toolButtonText
            // 
            this.toolButtonText.CheckOnClick = true;
            this.toolButtonText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolButtonText.Image = global::CMVEditor.Properties.Resources.icon_text_x16;
            this.toolButtonText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolButtonText.Name = "toolButtonText";
            this.toolButtonText.Size = new System.Drawing.Size(23, 22);
            this.toolButtonText.Text = "Text Tool";
            this.toolButtonText.Click += new System.EventHandler(this.action_toolSelectText);
            // 
            // cmvInfoControl
            // 
            this.cmvInfoControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.cmvInfoControl.CMV = null;
            this.cmvInfoControl.Location = new System.Drawing.Point(3, 179);
            this.cmvInfoControl.Name = "cmvInfoControl";
            this.cmvInfoControl.Size = new System.Drawing.Size(144, 89);
            this.cmvInfoControl.TabIndex = 8;
            // 
            // groupBrushStyle
            // 
            this.groupBrushStyle.Controls.Add(this.buttonBrowseForTileset);
            this.groupBrushStyle.Controls.Add(this.tileSelector);
            this.groupBrushStyle.Location = new System.Drawing.Point(3, 3);
            this.groupBrushStyle.Name = "groupBrushStyle";
            this.groupBrushStyle.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.groupBrushStyle.Size = new System.Drawing.Size(142, 90);
            this.groupBrushStyle.TabIndex = 6;
            this.groupBrushStyle.TabStop = false;
            this.groupBrushStyle.Text = "Brush style";
            // 
            // tileSelector
            // 
            this.tileSelector.BackgroundColor = System.Drawing.Color.Black;
            this.tileSelector.ForegroundColor = System.Drawing.Color.White;
            this.tileSelector.Location = new System.Drawing.Point(6, 15);
            this.tileSelector.Name = "tileSelector";
            this.tileSelector.SelectedTile = 0;
            this.tileSelector.Size = new System.Drawing.Size(129, 70);
            this.tileSelector.TabIndex = 2;
            this.tileSelector.TileSet = tileSet3;
            // 
            // mainSurface
            // 
            this.mainSurface.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mainSurface.AutoScroll = true;
            this.mainSurface.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainSurface.BackColor = System.Drawing.Color.SeaGreen;
            this.mainSurface.Controls.Add(this.cmvPlayer);
            this.mainSurface.Location = new System.Drawing.Point(0, 24);
            this.mainSurface.Name = "mainSurface";
            this.mainSurface.Size = new System.Drawing.Size(588, 271);
            this.mainSurface.TabIndex = 9;
            // 
            // cmvPlayer
            // 
            this.cmvPlayer.BackColor = System.Drawing.Color.SeaGreen;
            cmv2.Frames = null;
            cmv2.Version = ((uint)(0u));
            this.cmvPlayer.CMV = cmv2;
            this.cmvPlayer.Editable = true;
            this.cmvPlayer.Frame = -1;
            this.cmvPlayer.Location = new System.Drawing.Point(0, 0);
            this.cmvPlayer.Margin = new System.Windows.Forms.Padding(0);
            this.cmvPlayer.MinimumSize = new System.Drawing.Size(5, 5);
            this.cmvPlayer.Name = "cmvPlayer";
            this.cmvPlayer.PlayRate = 40;
            this.cmvPlayer.Size = new System.Drawing.Size(5, 5);
            this.cmvPlayer.TabIndex = 0;
            this.cmvPlayer.TileSet = tileSet4;
            this.cmvPlayer.ToolMode = CMVEditorComponents.ToolMode.NONE;
            this.cmvPlayer.CellPaintMove += new System.EventHandler(this.action_PaintMove);
            this.cmvPlayer.CellPaintStart += new System.EventHandler(this.action_PaintStart);
            this.cmvPlayer.CMVChanged += new System.EventHandler(this.cmvPlayer_CMVChanged);
            this.cmvPlayer.FrameChanged += new System.EventHandler(this.cmvPlayer_FrameChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(743, 381);
            this.Controls.Add(this.mainSurface);
            this.Controls.Add(this.panelForTools);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.menuStripMain);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStripMain;
            this.MinimumSize = new System.Drawing.Size(751, 415);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "CMV Editor";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.handleKeyPress);
            this.panelControls.ResumeLayout(false);
            this.flowLayoutControls.ResumeLayout(false);
            this.flowLayoutControls.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.panelForTools.ResumeLayout(false);
            this.panelForTools.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.groupBrushStyle.ResumeLayout(false);
            this.mainSurface.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutControls;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openCMVToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem revertToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cropToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem splitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem padFramesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stripFramesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpTopicsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadMovieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportFrameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem bay12GamesWebsiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem10;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.OpenFileDialog openCMVFileDialog;
        private System.Windows.Forms.SaveFileDialog saveCMVFileDialog;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private CMVEditorComponents.TimelineControl timelineControl;
        private CMVEditorComponents.CMVPlayerEditor cmvPlayer;
        private CMVEditorComponents.PlayerControls playerControls;
        private CMVEditorComponents.TimelineControls timelineControls;
        private System.Windows.Forms.SaveFileDialog saveImageFileDialog;
        private System.Windows.Forms.ToolTip toolTipProvider;
        private System.Windows.Forms.OpenFileDialog openImageFileDialog;
        private System.Windows.Forms.ToolStripMenuItem duplicateFrameToolStripMenuItem;
        private System.Windows.Forms.Panel panelForTools;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolButtonNone;
        private System.Windows.Forms.ToolStripButton toolButtonPaint;
        private System.Windows.Forms.ToolStripButton toolButtonSelection;
        private System.Windows.Forms.ToolStripButton toolButtonText;
        private CMVEditorComponents.CMVInfoControl cmvInfoControl;
        private System.Windows.Forms.GroupBox groupBrushStyle;
        private CMVEditorComponents.TileSelector tileSelector;
        private System.Windows.Forms.Panel mainSurface;
        private CMVEditorComponents.ColourPickerControl backgroundColourPicker;
        private CMVEditorComponents.ColourPickerControl foregroundColourPicker;
        private System.Windows.Forms.Label colorPickerLabel1;
        private System.Windows.Forms.Label toolbarLabel;
        private System.Windows.Forms.Label colorPickerLabel2;
        private System.Windows.Forms.Button buttonBrowseForTileset;
    }
}

