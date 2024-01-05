using System.Text.RegularExpressions;

namespace frickative
{
    public partial class Main : Form
    {
        public CheckBox[,] AcceptedClusters;

        public Main()
        {
            InitializeComponent();
            PulmonicConsonants.DataSource = Consonant.All;
            PulmonicConsonants.DisplayMember = "DisplayString";
            Vowels.DataSource = Vowel.All;
            Vowels.DisplayMember = "DisplayString";
            PopulateClusterMatrix();
        }

        private void PopulateClusterMatrix()
        { 
            // Cluster Matrix
            var manners = (Manner[])Enum.GetValues(typeof(Manner));
            AcceptedClusters = new CheckBox[manners.Length, manners.Length];
            ClusterMatrix.RowCount = ClusterMatrix.ColumnCount = manners.Length + 1;
            foreach (var m in manners)
            {
                Label onset = new()
                {
                    Text = m.ToString(),
                    AutoSize = true,
                    Font = new(DefaultFont, FontStyle.Bold)
                };
                VerticalLabel coda = new()
                {
                    Text = m.ToString(),
                    AutoSize = false,
                    Anchor = AnchorStyles.Bottom,
                    Font = new(DefaultFont, FontStyle.Bold)
                };
                coda.Width = coda.PreferredHeight;
                coda.Height = coda.PreferredWidth;
                coda.Dock = DockStyle.Fill;
                var x = (int)m;
                ClusterMatrix.Controls.Add(onset, 0, x + 1);
                ClusterMatrix.Controls.Add(coda, x + 1, 0);
                foreach (var n in manners)
                {
                    var y = (int)n;
                    CheckBox checkbox = new() { Checked = true };
                    AcceptedClusters[x, y] = checkbox;
                    ClusterMatrix.Controls.Add(checkbox, y + 1, x + 1);
                }
            }
            ClusterMatrix.ColumnStyles.Clear();
            ClusterMatrix.RowStyles.Clear();
            ClusterMatrix.ColumnStyles.Add(new(SizeType.AutoSize));
            ClusterMatrix.RowStyles.Add(new(SizeType.AutoSize));
            for (int i = 1; i < ClusterMatrix.ColumnCount; i++)
            {
                ClusterMatrix.ColumnStyles.Add(new(SizeType.Absolute, 30));
                ClusterMatrix.RowStyles.Add(new(SizeType.AutoSize));
            }
        }

        static void SetAllItemsChecked(CheckedListBox box, bool state)
        {
            for (int i = 0; i < box.Items.Count; i++)
            {
                box.SetItemChecked(i, state);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            SetAllItemsChecked(PulmonicConsonants, true);
            SetAllItemsChecked(Vowels, true);
        }

        #region Select All/None Buttons

        private void SelectAllPulmonicConsonants_Click(object sender, EventArgs e)
        {
            SetAllItemsChecked(PulmonicConsonants, true);
        }

        private void SelectNonePulmonicConsonants_Click(object sender, EventArgs e)
        {
            SetAllItemsChecked(PulmonicConsonants, false);
        }

        private void SelectAllVowels_Click(object sender, EventArgs e)
        {
            SetAllItemsChecked(Vowels, true);
        }

        private void SelectNoneVowels_Click(object sender, EventArgs e)
        {
            SetAllItemsChecked(Vowels, false);
        }

        #endregion

        private void GenerateSyllables_Click(object sender, EventArgs e)
        {
            var shapeInput = SyllableShape.Text.Trim().ToLower();
            if (Regex.IsMatch(shapeInput, "^c*v{1}c*$"))
            {
                var sParts = shapeInput.Split('v');
                var onset = sParts[0].Length;
                var coda = sParts[1].Length;
                var consonants = PulmonicConsonants.CheckedItems.Cast<Consonant>().ToList();
                var vowels = Vowels.CheckedItems.Cast<Vowel>().ToList();
                if (vowels.Count < 1 || consonants.Count < 1)
                    return;

                var random = new Random();
                SyllableOutput.DataSource = new string[0];
                List<string> strings = new();

                for(int i = 0; i < 1000; i++)
                {
                    var s = string.Empty;
                    do
                    {
                        IPALetter[] word = new IPALetter[coda + onset + 1];
                        var pos = 0;
                        for (; pos < onset; pos++)
                            word[pos] = consonants[random.Next(0, consonants.Count)];
                        word[pos] = vowels[random.Next(0, vowels.Count)];
                        pos++;
                        for (; pos < onset + 1 + coda; pos++)
                            word[pos] = consonants[random.Next(0, consonants.Count)];
                        s = string.Join<IPALetter>("", word);
                    } while (strings.Contains(s));
                    strings.Add(s);
                }
                strings.Sort();
                SyllableOutput.DataSource = strings;
            }
            else
            {
                MessageBox.Show("Syllable shape must be in format \"CVC\", and is not case-sensitve.");
            }
        }
    }
}
