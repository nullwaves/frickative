namespace frickform
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            splitContainerVowels = new SplitContainer();
            VowelsButtonPanel = new FlowLayoutPanel();
            SelectAllVowels = new Button();
            SelectNoneVowels = new Button();
            Vowels = new CheckedListBox();
            RightContainer = new SplitContainer();
            clusterAndShapeContainer = new SplitContainer();
            ClusterSettingsPanel = new FlowLayoutPanel();
            ClusterMatrix = new TableLayoutPanel();
            ClusterMatrixContextMenu = new ContextMenuStrip(components);
            selectAllClustersToolStripMenuItem = new ToolStripMenuItem();
            selectNoneClustersToolStripMenuItem = new ToolStripMenuItem();
            ResetClustersMenuItem = new ToolStripMenuItem();
            ClusterMatrixLabel = new Label();
            DisallowVoiceCrowding = new CheckBox();
            SyllableShapeInputPanel = new FlowLayoutPanel();
            SyllableShapeInput = new TextBox();
            GenerateSyllables = new Button();
            SyllableOutput = new TextBox();
            VowelsGroup = new GroupBox();
            MainContainer = new SplitContainer();
            LetterSelectonPanel = new FlowLayoutPanel();
            DipthongsGroup = new GroupBox();
            DipthongsContainer = new SplitContainer();
            DipthongsButtonPanel = new FlowLayoutPanel();
            SelectAllDipthongs = new Button();
            SelectNoneDipthongs = new Button();
            Dipthongs = new CheckedListBox();
            mainMenuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            soundsToolStripMenuItem = new ToolStripMenuItem();
            consonantsToolStripMenuItem = new ToolStripMenuItem();
            selectAllConsonantsToolStripMenuItem = new ToolStripMenuItem();
            selectNoneToolStripMenuItem = new ToolStripMenuItem();
            Tooltip = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)splitContainerVowels).BeginInit();
            splitContainerVowels.Panel1.SuspendLayout();
            splitContainerVowels.Panel2.SuspendLayout();
            splitContainerVowels.SuspendLayout();
            VowelsButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RightContainer).BeginInit();
            RightContainer.Panel1.SuspendLayout();
            RightContainer.Panel2.SuspendLayout();
            RightContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)clusterAndShapeContainer).BeginInit();
            clusterAndShapeContainer.Panel1.SuspendLayout();
            clusterAndShapeContainer.Panel2.SuspendLayout();
            clusterAndShapeContainer.SuspendLayout();
            ClusterSettingsPanel.SuspendLayout();
            ClusterMatrix.SuspendLayout();
            ClusterMatrixContextMenu.SuspendLayout();
            SyllableShapeInputPanel.SuspendLayout();
            VowelsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainContainer).BeginInit();
            MainContainer.Panel1.SuspendLayout();
            MainContainer.Panel2.SuspendLayout();
            MainContainer.SuspendLayout();
            LetterSelectonPanel.SuspendLayout();
            DipthongsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DipthongsContainer).BeginInit();
            DipthongsContainer.Panel1.SuspendLayout();
            DipthongsContainer.Panel2.SuspendLayout();
            DipthongsContainer.SuspendLayout();
            DipthongsButtonPanel.SuspendLayout();
            mainMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainerVowels
            // 
            splitContainerVowels.Dock = DockStyle.Fill;
            splitContainerVowels.FixedPanel = FixedPanel.Panel1;
            splitContainerVowels.Location = new Point(3, 27);
            splitContainerVowels.Name = "splitContainerVowels";
            splitContainerVowels.Orientation = Orientation.Horizontal;
            // 
            // splitContainerVowels.Panel1
            // 
            splitContainerVowels.Panel1.Controls.Add(VowelsButtonPanel);
            // 
            // splitContainerVowels.Panel2
            // 
            splitContainerVowels.Panel2.Controls.Add(Vowels);
            splitContainerVowels.Size = new Size(394, 320);
            splitContainerVowels.SplitterDistance = 40;
            splitContainerVowels.TabIndex = 0;
            // 
            // VowelsButtonPanel
            // 
            VowelsButtonPanel.AutoSize = true;
            VowelsButtonPanel.Controls.Add(SelectAllVowels);
            VowelsButtonPanel.Controls.Add(SelectNoneVowels);
            VowelsButtonPanel.Dock = DockStyle.Fill;
            VowelsButtonPanel.Location = new Point(0, 0);
            VowelsButtonPanel.Name = "VowelsButtonPanel";
            VowelsButtonPanel.Size = new Size(394, 40);
            VowelsButtonPanel.TabIndex = 1;
            // 
            // SelectAllVowels
            // 
            SelectAllVowels.AutoSize = true;
            SelectAllVowels.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SelectAllVowels.Location = new Point(3, 3);
            SelectAllVowels.Name = "SelectAllVowels";
            SelectAllVowels.Size = new Size(112, 35);
            SelectAllVowels.TabIndex = 0;
            SelectAllVowels.Text = "Select All";
            SelectAllVowels.UseVisualStyleBackColor = true;
            SelectAllVowels.Click += SelectAllVowels_Click;
            // 
            // SelectNoneVowels
            // 
            SelectNoneVowels.AutoSize = true;
            SelectNoneVowels.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SelectNoneVowels.Location = new Point(121, 3);
            SelectNoneVowels.Name = "SelectNoneVowels";
            SelectNoneVowels.Size = new Size(123, 35);
            SelectNoneVowels.TabIndex = 1;
            SelectNoneVowels.Text = "Select None";
            SelectNoneVowels.UseVisualStyleBackColor = true;
            SelectNoneVowels.Click += SelectNoneVowels_Click;
            // 
            // Vowels
            // 
            Vowels.CheckOnClick = true;
            Vowels.Dock = DockStyle.Fill;
            Vowels.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            Vowels.FormattingEnabled = true;
            Vowels.HorizontalScrollbar = true;
            Vowels.Location = new Point(0, 0);
            Vowels.Name = "Vowels";
            Vowels.Size = new Size(394, 276);
            Vowels.TabIndex = 3;
            Vowels.ItemCheck += Vowels_ItemCheck;
            // 
            // RightContainer
            // 
            RightContainer.BackColor = SystemColors.HotTrack;
            RightContainer.Dock = DockStyle.Fill;
            RightContainer.Location = new Point(0, 0);
            RightContainer.Name = "RightContainer";
            RightContainer.Orientation = Orientation.Horizontal;
            // 
            // RightContainer.Panel1
            // 
            RightContainer.Panel1.Controls.Add(clusterAndShapeContainer);
            // 
            // RightContainer.Panel2
            // 
            RightContainer.Panel2.Controls.Add(SyllableOutput);
            RightContainer.Size = new Size(557, 776);
            RightContainer.SplitterDistance = 280;
            RightContainer.SplitterWidth = 10;
            RightContainer.TabIndex = 1;
            // 
            // clusterAndShapeContainer
            // 
            clusterAndShapeContainer.BackColor = SystemColors.ControlDark;
            clusterAndShapeContainer.Dock = DockStyle.Fill;
            clusterAndShapeContainer.FixedPanel = FixedPanel.Panel2;
            clusterAndShapeContainer.Location = new Point(0, 0);
            clusterAndShapeContainer.Name = "clusterAndShapeContainer";
            clusterAndShapeContainer.Orientation = Orientation.Horizontal;
            // 
            // clusterAndShapeContainer.Panel1
            // 
            clusterAndShapeContainer.Panel1.AllowDrop = true;
            clusterAndShapeContainer.Panel1.BackColor = SystemColors.ControlDark;
            clusterAndShapeContainer.Panel1.Controls.Add(ClusterSettingsPanel);
            // 
            // clusterAndShapeContainer.Panel2
            // 
            clusterAndShapeContainer.Panel2.Controls.Add(SyllableShapeInputPanel);
            clusterAndShapeContainer.Size = new Size(557, 280);
            clusterAndShapeContainer.SplitterDistance = 220;
            clusterAndShapeContainer.SplitterWidth = 10;
            clusterAndShapeContainer.TabIndex = 0;
            // 
            // ClusterSettingsPanel
            // 
            ClusterSettingsPanel.AutoScroll = true;
            ClusterSettingsPanel.Controls.Add(ClusterMatrix);
            ClusterSettingsPanel.Controls.Add(DisallowVoiceCrowding);
            ClusterSettingsPanel.Dock = DockStyle.Fill;
            ClusterSettingsPanel.Location = new Point(0, 0);
            ClusterSettingsPanel.Name = "ClusterSettingsPanel";
            ClusterSettingsPanel.Size = new Size(557, 220);
            ClusterSettingsPanel.TabIndex = 0;
            // 
            // ClusterMatrix
            // 
            ClusterMatrix.AutoSize = true;
            ClusterMatrix.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClusterMatrix.BackColor = SystemColors.ControlDark;
            ClusterMatrix.ColumnCount = 2;
            ClusterMatrix.ColumnStyles.Add(new ColumnStyle());
            ClusterMatrix.ColumnStyles.Add(new ColumnStyle());
            ClusterMatrix.ContextMenuStrip = ClusterMatrixContextMenu;
            ClusterMatrix.Controls.Add(ClusterMatrixLabel, 0, 0);
            ClusterMatrix.Location = new Point(3, 3);
            ClusterMatrix.Name = "ClusterMatrix";
            ClusterMatrix.RowCount = 2;
            ClusterMatrix.RowStyles.Add(new RowStyle());
            ClusterMatrix.RowStyles.Add(new RowStyle());
            ClusterMatrix.Size = new Size(159, 101);
            ClusterMatrix.TabIndex = 0;
            // 
            // ClusterMatrixContextMenu
            // 
            ClusterMatrixContextMenu.ImageScalingSize = new Size(24, 24);
            ClusterMatrixContextMenu.Items.AddRange(new ToolStripItem[] { selectAllClustersToolStripMenuItem, selectNoneClustersToolStripMenuItem, ResetClustersMenuItem });
            ClusterMatrixContextMenu.Name = "ClusterMatrixContextMenu";
            ClusterMatrixContextMenu.Size = new Size(179, 100);
            ClusterMatrixContextMenu.Text = "Cluster Matrix";
            // 
            // selectAllClustersToolStripMenuItem
            // 
            selectAllClustersToolStripMenuItem.Name = "selectAllClustersToolStripMenuItem";
            selectAllClustersToolStripMenuItem.ShortcutKeyDisplayString = "";
            selectAllClustersToolStripMenuItem.Size = new Size(178, 32);
            selectAllClustersToolStripMenuItem.Text = "Select All";
            selectAllClustersToolStripMenuItem.Click += SelectAllClusters_Click;
            // 
            // selectNoneClustersToolStripMenuItem
            // 
            selectNoneClustersToolStripMenuItem.Name = "selectNoneClustersToolStripMenuItem";
            selectNoneClustersToolStripMenuItem.Size = new Size(178, 32);
            selectNoneClustersToolStripMenuItem.Text = "Select None";
            selectNoneClustersToolStripMenuItem.Click += SelectNoneClusters_Click;
            // 
            // ResetClustersMenuItem
            // 
            ResetClustersMenuItem.Name = "ResetClustersMenuItem";
            ResetClustersMenuItem.Size = new Size(178, 32);
            ResetClustersMenuItem.Text = "Reset";
            ResetClustersMenuItem.Click += ResetClusters_Click;
            // 
            // ClusterMatrixLabel
            // 
            ClusterMatrixLabel.Location = new Point(3, 0);
            ClusterMatrixLabel.Name = "ClusterMatrixLabel";
            ClusterMatrixLabel.Size = new Size(153, 101);
            ClusterMatrixLabel.TabIndex = 0;
            ClusterMatrixLabel.Text = "Checked values indicate that Column can follow Row.";
            // 
            // DisallowVoiceCrowding
            // 
            DisallowVoiceCrowding.AutoSize = true;
            DisallowVoiceCrowding.Checked = true;
            DisallowVoiceCrowding.CheckState = CheckState.Checked;
            DisallowVoiceCrowding.Location = new Point(168, 3);
            DisallowVoiceCrowding.Name = "DisallowVoiceCrowding";
            DisallowVoiceCrowding.Size = new Size(233, 29);
            DisallowVoiceCrowding.TabIndex = 1;
            DisallowVoiceCrowding.Text = "Disallow Voice Crowding";
            Tooltip.SetToolTip(DisallowVoiceCrowding, "When checked, generator will not allow a voiceless consonant to fall between a voiced consonant and the vowel.");
            DisallowVoiceCrowding.UseVisualStyleBackColor = true;
            // 
            // SyllableShapeInputPanel
            // 
            SyllableShapeInputPanel.AutoSize = true;
            SyllableShapeInputPanel.BackColor = SystemColors.ControlDark;
            SyllableShapeInputPanel.Controls.Add(SyllableShapeInput);
            SyllableShapeInputPanel.Controls.Add(GenerateSyllables);
            SyllableShapeInputPanel.Dock = DockStyle.Fill;
            SyllableShapeInputPanel.Location = new Point(0, 0);
            SyllableShapeInputPanel.Name = "SyllableShapeInputPanel";
            SyllableShapeInputPanel.Size = new Size(557, 50);
            SyllableShapeInputPanel.TabIndex = 1;
            // 
            // SyllableShapeInput
            // 
            SyllableShapeInput.Anchor = AnchorStyles.Left;
            SyllableShapeInput.Location = new Point(3, 5);
            SyllableShapeInput.Name = "SyllableShapeInput";
            SyllableShapeInput.PlaceholderText = "Syllable Shape";
            SyllableShapeInput.Size = new Size(292, 31);
            SyllableShapeInput.TabIndex = 1;
            // 
            // GenerateSyllables
            // 
            GenerateSyllables.Anchor = AnchorStyles.Left;
            GenerateSyllables.AutoSize = true;
            GenerateSyllables.Location = new Point(301, 3);
            GenerateSyllables.Name = "GenerateSyllables";
            GenerateSyllables.Size = new Size(184, 35);
            GenerateSyllables.TabIndex = 0;
            GenerateSyllables.Text = "Generate Syllables";
            GenerateSyllables.UseVisualStyleBackColor = true;
            GenerateSyllables.Click += GenerateSyllables_Click;
            // 
            // SyllableOutput
            // 
            SyllableOutput.BackColor = SystemColors.Control;
            SyllableOutput.BorderStyle = BorderStyle.FixedSingle;
            SyllableOutput.Dock = DockStyle.Fill;
            SyllableOutput.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SyllableOutput.ForeColor = SystemColors.ControlText;
            SyllableOutput.Location = new Point(0, 0);
            SyllableOutput.Multiline = true;
            SyllableOutput.Name = "SyllableOutput";
            SyllableOutput.ReadOnly = true;
            SyllableOutput.ScrollBars = ScrollBars.Vertical;
            SyllableOutput.Size = new Size(557, 486);
            SyllableOutput.TabIndex = 0;
            // 
            // VowelsGroup
            // 
            VowelsGroup.Controls.Add(splitContainerVowels);
            VowelsGroup.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VowelsGroup.Location = new Point(3, 3);
            VowelsGroup.Name = "VowelsGroup";
            VowelsGroup.Size = new Size(400, 350);
            VowelsGroup.TabIndex = 3;
            VowelsGroup.TabStop = false;
            VowelsGroup.Text = "Vowels";
            // 
            // MainContainer
            // 
            MainContainer.Dock = DockStyle.Fill;
            MainContainer.Location = new Point(0, 33);
            MainContainer.Name = "MainContainer";
            // 
            // MainContainer.Panel1
            // 
            MainContainer.Panel1.Controls.Add(LetterSelectonPanel);
            // 
            // MainContainer.Panel2
            // 
            MainContainer.Panel2.Controls.Add(RightContainer);
            MainContainer.Size = new Size(1567, 776);
            MainContainer.SplitterDistance = 1006;
            MainContainer.TabIndex = 4;
            // 
            // LetterSelectonPanel
            // 
            LetterSelectonPanel.AutoScroll = true;
            LetterSelectonPanel.Controls.Add(VowelsGroup);
            LetterSelectonPanel.Controls.Add(DipthongsGroup);
            LetterSelectonPanel.Dock = DockStyle.Fill;
            LetterSelectonPanel.Location = new Point(0, 0);
            LetterSelectonPanel.Name = "LetterSelectonPanel";
            LetterSelectonPanel.Size = new Size(1006, 776);
            LetterSelectonPanel.TabIndex = 0;
            // 
            // DipthongsGroup
            // 
            DipthongsGroup.Controls.Add(DipthongsContainer);
            DipthongsGroup.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DipthongsGroup.Location = new Point(409, 3);
            DipthongsGroup.Name = "DipthongsGroup";
            DipthongsGroup.Size = new Size(400, 350);
            DipthongsGroup.TabIndex = 6;
            DipthongsGroup.TabStop = false;
            DipthongsGroup.Text = "Dipthongs";
            // 
            // DipthongsContainer
            // 
            DipthongsContainer.Dock = DockStyle.Fill;
            DipthongsContainer.FixedPanel = FixedPanel.Panel1;
            DipthongsContainer.Location = new Point(3, 27);
            DipthongsContainer.Name = "DipthongsContainer";
            DipthongsContainer.Orientation = Orientation.Horizontal;
            // 
            // DipthongsContainer.Panel1
            // 
            DipthongsContainer.Panel1.Controls.Add(DipthongsButtonPanel);
            // 
            // DipthongsContainer.Panel2
            // 
            DipthongsContainer.Panel2.Controls.Add(Dipthongs);
            DipthongsContainer.Size = new Size(394, 320);
            DipthongsContainer.SplitterDistance = 40;
            DipthongsContainer.TabIndex = 1;
            // 
            // DipthongsButtonPanel
            // 
            DipthongsButtonPanel.AutoSize = true;
            DipthongsButtonPanel.Controls.Add(SelectAllDipthongs);
            DipthongsButtonPanel.Controls.Add(SelectNoneDipthongs);
            DipthongsButtonPanel.Dock = DockStyle.Fill;
            DipthongsButtonPanel.Location = new Point(0, 0);
            DipthongsButtonPanel.Name = "DipthongsButtonPanel";
            DipthongsButtonPanel.Size = new Size(394, 40);
            DipthongsButtonPanel.TabIndex = 1;
            // 
            // SelectAllDipthongs
            // 
            SelectAllDipthongs.AutoSize = true;
            SelectAllDipthongs.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SelectAllDipthongs.Location = new Point(3, 3);
            SelectAllDipthongs.Name = "SelectAllDipthongs";
            SelectAllDipthongs.Size = new Size(112, 35);
            SelectAllDipthongs.TabIndex = 0;
            SelectAllDipthongs.Text = "Select All";
            SelectAllDipthongs.UseVisualStyleBackColor = true;
            SelectAllDipthongs.Click += SelectAllDipthongs_Click;
            // 
            // SelectNoneDipthongs
            // 
            SelectNoneDipthongs.AutoSize = true;
            SelectNoneDipthongs.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SelectNoneDipthongs.Location = new Point(121, 3);
            SelectNoneDipthongs.Name = "SelectNoneDipthongs";
            SelectNoneDipthongs.Size = new Size(123, 35);
            SelectNoneDipthongs.TabIndex = 1;
            SelectNoneDipthongs.Text = "Select None";
            SelectNoneDipthongs.UseVisualStyleBackColor = true;
            SelectNoneDipthongs.Click += SelectNoneDipthongs_Click;
            // 
            // Dipthongs
            // 
            Dipthongs.CheckOnClick = true;
            Dipthongs.Dock = DockStyle.Fill;
            Dipthongs.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            Dipthongs.FormattingEnabled = true;
            Dipthongs.HorizontalScrollbar = true;
            Dipthongs.Location = new Point(0, 0);
            Dipthongs.Name = "Dipthongs";
            Dipthongs.Size = new Size(394, 276);
            Dipthongs.TabIndex = 3;
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.ImageScalingSize = new Size(24, 24);
            mainMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, soundsToolStripMenuItem });
            mainMenuStrip.Location = new Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Size = new Size(1567, 33);
            mainMenuStrip.TabIndex = 5;
            mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, toolStripSeparator2, saveToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(213, 34);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += NewLanguage_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Enabled = false;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(213, 34);
            openToolStripMenuItem.Text = "Open";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(210, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Enabled = false;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(213, 34);
            saveToolStripMenuItem.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(210, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            exitToolStripMenuItem.Size = new Size(213, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += Exit_Click;
            // 
            // soundsToolStripMenuItem
            // 
            soundsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consonantsToolStripMenuItem });
            soundsToolStripMenuItem.Name = "soundsToolStripMenuItem";
            soundsToolStripMenuItem.Size = new Size(88, 29);
            soundsToolStripMenuItem.Text = "Sounds";
            // 
            // consonantsToolStripMenuItem
            // 
            consonantsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { selectAllConsonantsToolStripMenuItem, selectNoneToolStripMenuItem });
            consonantsToolStripMenuItem.Name = "consonantsToolStripMenuItem";
            consonantsToolStripMenuItem.Size = new Size(208, 34);
            consonantsToolStripMenuItem.Text = "Consonants";
            // 
            // selectAllConsonantsToolStripMenuItem
            // 
            selectAllConsonantsToolStripMenuItem.Name = "selectAllConsonantsToolStripMenuItem";
            selectAllConsonantsToolStripMenuItem.Size = new Size(208, 34);
            selectAllConsonantsToolStripMenuItem.Text = "Select All";
            selectAllConsonantsToolStripMenuItem.Click += SelectAllConsonats_Click;
            // 
            // selectNoneToolStripMenuItem
            // 
            selectNoneToolStripMenuItem.Name = "selectNoneToolStripMenuItem";
            selectNoneToolStripMenuItem.Size = new Size(208, 34);
            selectNoneToolStripMenuItem.Text = "Select None";
            selectNoneToolStripMenuItem.Click += SelectNoneConsonats_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1567, 809);
            Controls.Add(MainContainer);
            Controls.Add(mainMenuStrip);
            Name = "Main";
            Text = "Frickative";
            Load += Main_Load;
            splitContainerVowels.Panel1.ResumeLayout(false);
            splitContainerVowels.Panel1.PerformLayout();
            splitContainerVowels.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerVowels).EndInit();
            splitContainerVowels.ResumeLayout(false);
            VowelsButtonPanel.ResumeLayout(false);
            VowelsButtonPanel.PerformLayout();
            RightContainer.Panel1.ResumeLayout(false);
            RightContainer.Panel2.ResumeLayout(false);
            RightContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RightContainer).EndInit();
            RightContainer.ResumeLayout(false);
            clusterAndShapeContainer.Panel1.ResumeLayout(false);
            clusterAndShapeContainer.Panel2.ResumeLayout(false);
            clusterAndShapeContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)clusterAndShapeContainer).EndInit();
            clusterAndShapeContainer.ResumeLayout(false);
            ClusterSettingsPanel.ResumeLayout(false);
            ClusterSettingsPanel.PerformLayout();
            ClusterMatrix.ResumeLayout(false);
            ClusterMatrixContextMenu.ResumeLayout(false);
            SyllableShapeInputPanel.ResumeLayout(false);
            SyllableShapeInputPanel.PerformLayout();
            VowelsGroup.ResumeLayout(false);
            MainContainer.Panel1.ResumeLayout(false);
            MainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MainContainer).EndInit();
            MainContainer.ResumeLayout(false);
            LetterSelectonPanel.ResumeLayout(false);
            DipthongsGroup.ResumeLayout(false);
            DipthongsContainer.Panel1.ResumeLayout(false);
            DipthongsContainer.Panel1.PerformLayout();
            DipthongsContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DipthongsContainer).EndInit();
            DipthongsContainer.ResumeLayout(false);
            DipthongsButtonPanel.ResumeLayout(false);
            DipthongsButtonPanel.PerformLayout();
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private SplitContainer splitContainerVowels;
        private FlowLayoutPanel VowelsButtonPanel;
        private Button SelectAllVowels;
        private Button SelectNoneVowels;
        private CheckedListBox Vowels;
        private SplitContainer RightContainer;
        private GroupBox VowelsGroup;
        private SplitContainer MainContainer;
        private FlowLayoutPanel LetterSelectonPanel;
        private ContextMenuStrip ClusterMatrixContextMenu;
        private ToolStripMenuItem selectAllClustersToolStripMenuItem;
        private ToolStripMenuItem selectNoneClustersToolStripMenuItem;
        private ToolStripMenuItem ResetClustersMenuItem;
        private MenuStrip mainMenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem soundsToolStripMenuItem;
        private ToolStripMenuItem consonantsToolStripMenuItem;
        private ToolStripMenuItem selectAllConsonantsToolStripMenuItem;
        private ToolStripMenuItem selectNoneToolStripMenuItem;
        private GroupBox DipthongsGroup;
        private SplitContainer DipthongsContainer;
        private FlowLayoutPanel DipthongsButtonPanel;
        private Button SelectAllDipthongs;
        private Button SelectNoneDipthongs;
        private CheckedListBox Dipthongs;
        private TextBox SyllableOutput;
        private ToolTip Tooltip;
        private SplitContainer clusterAndShapeContainer;
        private FlowLayoutPanel ClusterSettingsPanel;
        private TableLayoutPanel ClusterMatrix;
        private Label ClusterMatrixLabel;
        private CheckBox DisallowVoiceCrowding;
        private FlowLayoutPanel SyllableShapeInputPanel;
        private TextBox SyllableShapeInput;
        private Button GenerateSyllables;
    }
}
