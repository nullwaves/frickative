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
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SelectAllPulmonicConsonants = new Button();
            SelectNonePulmonicConsonants = new Button();
            PulmonicConsonants = new CheckedListBox();
            phoneticLetterBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)phoneticLetterBindingSource).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 350;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.FixedPanel = FixedPanel.Panel1;
            splitContainer2.IsSplitterFixed = true;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(flowLayoutPanel1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(PulmonicConsonants);
            splitContainer2.Size = new Size(350, 450);
            splitContainer2.SplitterDistance = 40;
            splitContainer2.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(SelectAllPulmonicConsonants);
            flowLayoutPanel1.Controls.Add(SelectNonePulmonicConsonants);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(350, 40);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // SelectAllPulmonicConsonants
            // 
            SelectAllPulmonicConsonants.AutoSize = true;
            SelectAllPulmonicConsonants.Location = new Point(3, 3);
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
            SelectNonePulmonicConsonants.Location = new Point(121, 3);
            SelectNonePulmonicConsonants.Name = "SelectNonePulmonicConsonants";
            SelectNonePulmonicConsonants.Size = new Size(116, 35);
            SelectNonePulmonicConsonants.TabIndex = 1;
            SelectNonePulmonicConsonants.Text = "Select None";
            SelectNonePulmonicConsonants.UseVisualStyleBackColor = true;
            SelectNonePulmonicConsonants.Click += SelectNonePulmonicConsonants_Click;
            // 
            // PulmonicConsonants
            // 
            PulmonicConsonants.Dock = DockStyle.Fill;
            PulmonicConsonants.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            PulmonicConsonants.FormattingEnabled = true;
            PulmonicConsonants.Location = new Point(0, 0);
            PulmonicConsonants.Name = "PulmonicConsonants";
            PulmonicConsonants.Size = new Size(350, 406);
            PulmonicConsonants.TabIndex = 2;
            // 
            // phoneticLetterBindingSource
            // 
            phoneticLetterBindingSource.DataSource = typeof(PhoneticLetter);
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Main";
            Text = "Frickative";
            Load += Main_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)phoneticLetterBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button SelectAllPulmonicConsonants;
        private Button SelectNonePulmonicConsonants;
        private CheckedListBox PulmonicConsonants;
        private BindingSource phoneticLetterBindingSource;
        private SplitContainer splitContainer2;
    }
}
