namespace frickative
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
            flowLayoutPanel2 = new FlowLayoutPanel();
            SelectAllVowels = new Button();
            SelectNoneVowels = new Button();
            Vowels = new CheckedListBox();
            ClusterAndOutputContainer = new SplitContainer();
            splitContainer2 = new SplitContainer();
            ClusterMatrix = new TableLayoutPanel();
            ClusterMatrixContextMenu = new ContextMenuStrip(components);
            selectAllClustersToolStripMenuItem = new ToolStripMenuItem();
            selectNoneClustersToolStripMenuItem = new ToolStripMenuItem();
            ResetClustersMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            SyllableShape = new TextBox();
            GenerateSyllables = new Button();
            SyllableOutput = new TextBox();
            groupBox1 = new GroupBox();
            MainContainer = new SplitContainer();
            LetterSelectonPanel = new FlowLayoutPanel();
            MainMenuStrip = new MenuStrip();
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
            ((System.ComponentModel.ISupportInitialize)splitContainerVowels).BeginInit();
            splitContainerVowels.Panel1.SuspendLayout();
            splitContainerVowels.Panel2.SuspendLayout();
            splitContainerVowels.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ClusterAndOutputContainer).BeginInit();
            ClusterAndOutputContainer.Panel1.SuspendLayout();
            ClusterAndOutputContainer.Panel2.SuspendLayout();
            ClusterAndOutputContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ClusterMatrix.SuspendLayout();
            ClusterMatrixContextMenu.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainContainer).BeginInit();
            MainContainer.Panel1.SuspendLayout();
            MainContainer.Panel2.SuspendLayout();
            MainContainer.SuspendLayout();
            LetterSelectonPanel.SuspendLayout();
            MainMenuStrip.SuspendLayout();
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
            splitContainerVowels.Panel1.Controls.Add(flowLayoutPanel2);
            // 
            // splitContainerVowels.Panel2
            // 
            splitContainerVowels.Panel2.Controls.Add(Vowels);
            splitContainerVowels.Size = new Size(394, 320);
            splitContainerVowels.SplitterDistance = 40;
            splitContainerVowels.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(SelectAllVowels);
            flowLayoutPanel2.Controls.Add(SelectNoneVowels);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(394, 40);
            flowLayoutPanel2.TabIndex = 1;
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
            // 
            // ClusterAndOutputContainer
            // 
            ClusterAndOutputContainer.BackColor = SystemColors.HotTrack;
            ClusterAndOutputContainer.Dock = DockStyle.Fill;
            ClusterAndOutputContainer.Location = new Point(0, 0);
            ClusterAndOutputContainer.Name = "ClusterAndOutputContainer";
            ClusterAndOutputContainer.Orientation = Orientation.Horizontal;
            // 
            // ClusterAndOutputContainer.Panel1
            // 
            ClusterAndOutputContainer.Panel1.Controls.Add(splitContainer2);
            // 
            // ClusterAndOutputContainer.Panel2
            // 
            ClusterAndOutputContainer.Panel2.Controls.Add(SyllableOutput);
            ClusterAndOutputContainer.Size = new Size(557, 776);
            ClusterAndOutputContainer.SplitterDistance = 280;
            ClusterAndOutputContainer.SplitterWidth = 10;
            ClusterAndOutputContainer.TabIndex = 1;
            // 
            // splitContainer2
            // 
            splitContainer2.BackColor = SystemColors.ControlDark;
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.FixedPanel = FixedPanel.Panel2;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.AllowDrop = true;
            splitContainer2.Panel1.AutoScroll = true;
            splitContainer2.Panel1.BackColor = SystemColors.ControlDark;
            splitContainer2.Panel1.Controls.Add(ClusterMatrix);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(flowLayoutPanel3);
            splitContainer2.Size = new Size(557, 280);
            splitContainer2.SplitterDistance = 215;
            splitContainer2.SplitterWidth = 10;
            splitContainer2.TabIndex = 0;
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
            ClusterMatrix.Controls.Add(label1, 0, 0);
            ClusterMatrix.Location = new Point(0, 0);
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
            // label1
            // 
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(153, 101);
            label1.TabIndex = 0;
            label1.Text = "Checked values indicate that Column can follow Row.";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.BackColor = SystemColors.ControlDark;
            flowLayoutPanel3.Controls.Add(SyllableShape);
            flowLayoutPanel3.Controls.Add(GenerateSyllables);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(0, 0);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(557, 55);
            flowLayoutPanel3.TabIndex = 1;
            // 
            // SyllableShape
            // 
            SyllableShape.Anchor = AnchorStyles.Left;
            SyllableShape.Location = new Point(3, 5);
            SyllableShape.Name = "SyllableShape";
            SyllableShape.PlaceholderText = "Syllable Shape";
            SyllableShape.Size = new Size(292, 31);
            SyllableShape.TabIndex = 1;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(splitContainerVowels);
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 350);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Vowels";
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
            MainContainer.Panel2.Controls.Add(ClusterAndOutputContainer);
            MainContainer.Size = new Size(1567, 776);
            MainContainer.SplitterDistance = 1006;
            MainContainer.TabIndex = 4;
            // 
            // LetterSelectonPanel
            // 
            LetterSelectonPanel.AutoScroll = true;
            LetterSelectonPanel.Controls.Add(groupBox1);
            LetterSelectonPanel.Dock = DockStyle.Fill;
            LetterSelectonPanel.Location = new Point(0, 0);
            LetterSelectonPanel.Name = "LetterSelectonPanel";
            LetterSelectonPanel.Size = new Size(1006, 776);
            LetterSelectonPanel.TabIndex = 0;
            // 
            // MainMenuStrip
            // 
            MainMenuStrip.ImageScalingSize = new Size(24, 24);
            MainMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, soundsToolStripMenuItem });
            MainMenuStrip.Location = new Point(0, 0);
            MainMenuStrip.Name = "MainMenuStrip";
            MainMenuStrip.Size = new Size(1567, 33);
            MainMenuStrip.TabIndex = 5;
            MainMenuStrip.Text = "menuStrip1";
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
            consonantsToolStripMenuItem.Size = new Size(270, 34);
            consonantsToolStripMenuItem.Text = "Consonants";
            // 
            // selectAllConsonantsToolStripMenuItem
            // 
            selectAllConsonantsToolStripMenuItem.Name = "selectAllConsonantsToolStripMenuItem";
            selectAllConsonantsToolStripMenuItem.Size = new Size(270, 34);
            selectAllConsonantsToolStripMenuItem.Text = "Select All";
            selectAllConsonantsToolStripMenuItem.Click += SelectAllConsonats_Click;
            // 
            // selectNoneToolStripMenuItem
            // 
            selectNoneToolStripMenuItem.Name = "selectNoneToolStripMenuItem";
            selectNoneToolStripMenuItem.Size = new Size(270, 34);
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
            Controls.Add(MainMenuStrip);
            Name = "Main";
            Text = "Frickative";
            Load += Main_Load;
            splitContainerVowels.Panel1.ResumeLayout(false);
            splitContainerVowels.Panel1.PerformLayout();
            splitContainerVowels.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerVowels).EndInit();
            splitContainerVowels.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ClusterAndOutputContainer.Panel1.ResumeLayout(false);
            ClusterAndOutputContainer.Panel2.ResumeLayout(false);
            ClusterAndOutputContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ClusterAndOutputContainer).EndInit();
            ClusterAndOutputContainer.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ClusterMatrix.ResumeLayout(false);
            ClusterMatrixContextMenu.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            groupBox1.ResumeLayout(false);
            MainContainer.Panel1.ResumeLayout(false);
            MainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MainContainer).EndInit();
            MainContainer.ResumeLayout(false);
            LetterSelectonPanel.ResumeLayout(false);
            MainMenuStrip.ResumeLayout(false);
            MainMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button SelectAllPulmonicConsonants;
        private Button SelectNonePulmonicConsonants;
        private SplitContainer splitContainerPulmonicConsonants;
        private SplitContainer splitContainerVowels;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button SelectAllVowels;
        private Button SelectNoneVowels;
        private CheckedListBox Vowels;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel3;
        private TextBox SyllableShape;
        private Button GenerateSyllables;
        private TextBox SyllableOutput;
        private SplitContainer splitContainer2;
        private TableLayoutPanel ClusterMatrix;
        private SplitContainer ClusterAndOutputContainer;
        private Label label1;
        private Label label3;
        private GroupBox groupBox1;
        private SplitContainer MainContainer;
        private FlowLayoutPanel LetterSelectonPanel;
        private ContextMenuStrip ClusterMatrixContextMenu;
        private ToolStripMenuItem selectAllClustersToolStripMenuItem;
        private ToolStripMenuItem selectNoneClustersToolStripMenuItem;
        private ToolStripMenuItem ResetClustersMenuItem;
        private MenuStrip MainMenuStrip;
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
    }
}
