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
            splitContainerPulmonicConsonants = new SplitContainer();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label3 = new Label();
            SelectAllPulmonicConsonants = new Button();
            SelectNonePulmonicConsonants = new Button();
            PulmonicConsonants = new CheckedListBox();
            splitContainerVowels = new SplitContainer();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label2 = new Label();
            SelectAllVowels = new Button();
            SelectNoneVowels = new Button();
            Vowels = new CheckedListBox();
            phoneticLetterBindingSource = new BindingSource(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            ClusterMatrix = new TableLayoutPanel();
            label1 = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            SyllableShape = new TextBox();
            GenerateSyllables = new Button();
            SyllableOutput = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainerPulmonicConsonants).BeginInit();
            splitContainerPulmonicConsonants.Panel1.SuspendLayout();
            splitContainerPulmonicConsonants.Panel2.SuspendLayout();
            splitContainerPulmonicConsonants.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerVowels).BeginInit();
            splitContainerVowels.Panel1.SuspendLayout();
            splitContainerVowels.Panel2.SuspendLayout();
            splitContainerVowels.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)phoneticLetterBindingSource).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ClusterMatrix.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainerPulmonicConsonants
            // 
            splitContainerPulmonicConsonants.Dock = DockStyle.Fill;
            splitContainerPulmonicConsonants.FixedPanel = FixedPanel.Panel1;
            splitContainerPulmonicConsonants.IsSplitterFixed = true;
            splitContainerPulmonicConsonants.Location = new Point(441, 3);
            splitContainerPulmonicConsonants.Name = "splitContainerPulmonicConsonants";
            splitContainerPulmonicConsonants.Orientation = Orientation.Horizontal;
            // 
            // splitContainerPulmonicConsonants.Panel1
            // 
            splitContainerPulmonicConsonants.Panel1.Controls.Add(flowLayoutPanel1);
            // 
            // splitContainerPulmonicConsonants.Panel2
            // 
            splitContainerPulmonicConsonants.Panel2.Controls.Add(PulmonicConsonants);
            splitContainerPulmonicConsonants.Size = new Size(552, 803);
            splitContainerPulmonicConsonants.SplitterDistance = 40;
            splitContainerPulmonicConsonants.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(SelectAllPulmonicConsonants);
            flowLayoutPanel1.Controls.Add(SelectNonePulmonicConsonants);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(552, 40);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(300, 38);
            label3.TabIndex = 3;
            label3.Text = "Pulmonic Consonants";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SelectAllPulmonicConsonants
            // 
            SelectAllPulmonicConsonants.AutoSize = true;
            SelectAllPulmonicConsonants.Location = new Point(309, 3);
            SelectAllPulmonicConsonants.Name = "SelectAllPulmonicConsonants";
            SelectAllPulmonicConsonants.Size = new Size(112, 35);
            SelectAllPulmonicConsonants.TabIndex = 0;
            SelectAllPulmonicConsonants.Text = "Select All";
            SelectAllPulmonicConsonants.UseVisualStyleBackColor = true;
            SelectAllPulmonicConsonants.Click += SelectAllPulmonicConsonants_Click;
            // 
            // SelectNonePulmonicConsonants
            // 
            SelectNonePulmonicConsonants.AutoSize = true;
            SelectNonePulmonicConsonants.Location = new Point(427, 3);
            SelectNonePulmonicConsonants.Name = "SelectNonePulmonicConsonants";
            SelectNonePulmonicConsonants.Size = new Size(116, 35);
            SelectNonePulmonicConsonants.TabIndex = 1;
            SelectNonePulmonicConsonants.Text = "Select None";
            SelectNonePulmonicConsonants.UseVisualStyleBackColor = true;
            SelectNonePulmonicConsonants.Click += SelectNonePulmonicConsonants_Click;
            // 
            // PulmonicConsonants
            // 
            PulmonicConsonants.CheckOnClick = true;
            PulmonicConsonants.Dock = DockStyle.Fill;
            PulmonicConsonants.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            PulmonicConsonants.FormattingEnabled = true;
            PulmonicConsonants.HorizontalScrollbar = true;
            PulmonicConsonants.Location = new Point(0, 0);
            PulmonicConsonants.Name = "PulmonicConsonants";
            PulmonicConsonants.Size = new Size(552, 759);
            PulmonicConsonants.TabIndex = 2;
            // 
            // splitContainerVowels
            // 
            splitContainerVowels.Dock = DockStyle.Fill;
            splitContainerVowels.FixedPanel = FixedPanel.Panel1;
            splitContainerVowels.Location = new Point(3, 3);
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
            splitContainerVowels.Size = new Size(432, 803);
            splitContainerVowels.SplitterDistance = 40;
            splitContainerVowels.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Controls.Add(SelectAllVowels);
            flowLayoutPanel2.Controls.Add(SelectNoneVowels);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(432, 40);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(108, 38);
            label2.TabIndex = 2;
            label2.Text = "Vowels";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SelectAllVowels
            // 
            SelectAllVowels.AutoSize = true;
            SelectAllVowels.Location = new Point(117, 3);
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
            SelectNoneVowels.Location = new Point(235, 3);
            SelectNoneVowels.Name = "SelectNoneVowels";
            SelectNoneVowels.Size = new Size(116, 35);
            SelectNoneVowels.TabIndex = 1;
            SelectNoneVowels.Text = "Select None";
            SelectNoneVowels.UseVisualStyleBackColor = true;
            SelectNoneVowels.Click += SelectNoneVowels_Click;
            // 
            // Vowels
            // 
            Vowels.CheckOnClick = true;
            Vowels.Dock = DockStyle.Fill;
            Vowels.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            Vowels.FormattingEnabled = true;
            Vowels.HorizontalScrollbar = true;
            Vowels.Location = new Point(0, 0);
            Vowels.Name = "Vowels";
            Vowels.Size = new Size(432, 759);
            Vowels.TabIndex = 3;
            // 
            // phoneticLetterBindingSource
            // 
            phoneticLetterBindingSource.DataSource = typeof(Consonant);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.9515F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.67326F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.37524F));
            tableLayoutPanel1.Controls.Add(splitContainerVowels, 0, 0);
            tableLayoutPanel1.Controls.Add(splitContainerPulmonicConsonants, 1, 0);
            tableLayoutPanel1.Controls.Add(splitContainer1, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1567, 809);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(999, 3);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(SyllableOutput);
            splitContainer1.Size = new Size(565, 803);
            splitContainer1.SplitterDistance = 299;
            splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.FixedPanel = FixedPanel.Panel2;
            splitContainer2.IsSplitterFixed = true;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(ClusterMatrix);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(flowLayoutPanel3);
            splitContainer2.Size = new Size(565, 299);
            splitContainer2.SplitterDistance = 243;
            splitContainer2.SplitterWidth = 10;
            splitContainer2.TabIndex = 0;
            // 
            // ClusterMatrix
            // 
            ClusterMatrix.AutoScroll = true;
            ClusterMatrix.AutoSize = true;
            ClusterMatrix.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClusterMatrix.ColumnCount = 2;
            ClusterMatrix.ColumnStyles.Add(new ColumnStyle());
            ClusterMatrix.ColumnStyles.Add(new ColumnStyle());
            ClusterMatrix.Controls.Add(label1, 0, 0);
            ClusterMatrix.Dock = DockStyle.Fill;
            ClusterMatrix.Location = new Point(0, 0);
            ClusterMatrix.Name = "ClusterMatrix";
            ClusterMatrix.RowCount = 2;
            ClusterMatrix.RowStyles.Add(new RowStyle());
            ClusterMatrix.RowStyles.Add(new RowStyle());
            ClusterMatrix.Size = new Size(565, 243);
            ClusterMatrix.TabIndex = 0;
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
            flowLayoutPanel3.Controls.Add(SyllableShape);
            flowLayoutPanel3.Controls.Add(GenerateSyllables);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(0, 0);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(565, 46);
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
            SyllableOutput.BackColor = SystemColors.ControlDark;
            SyllableOutput.Dock = DockStyle.Fill;
            SyllableOutput.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SyllableOutput.ForeColor = SystemColors.ControlText;
            SyllableOutput.Location = new Point(0, 0);
            SyllableOutput.Multiline = true;
            SyllableOutput.Name = "SyllableOutput";
            SyllableOutput.ReadOnly = true;
            SyllableOutput.ScrollBars = ScrollBars.Vertical;
            SyllableOutput.Size = new Size(565, 500);
            SyllableOutput.TabIndex = 0;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1567, 809);
            Controls.Add(tableLayoutPanel1);
            Name = "Main";
            Text = "Frickative";
            Load += Main_Load;
            splitContainerPulmonicConsonants.Panel1.ResumeLayout(false);
            splitContainerPulmonicConsonants.Panel1.PerformLayout();
            splitContainerPulmonicConsonants.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerPulmonicConsonants).EndInit();
            splitContainerPulmonicConsonants.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            splitContainerVowels.Panel1.ResumeLayout(false);
            splitContainerVowels.Panel1.PerformLayout();
            splitContainerVowels.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerVowels).EndInit();
            splitContainerVowels.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)phoneticLetterBindingSource).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ClusterMatrix.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private Button SelectAllPulmonicConsonants;
        private Button SelectNonePulmonicConsonants;
        private CheckedListBox PulmonicConsonants;
        private BindingSource phoneticLetterBindingSource;
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
        private SplitContainer splitContainer1;
        private Label label1;
        private Label label3;
        private Label label2;
    }
}
