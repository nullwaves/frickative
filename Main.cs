using System.Text.RegularExpressions;

namespace frickative
{
    public partial class Main : Form
    {
        public static Manner[] Manners => (Manner[])Enum.GetValues(typeof(Manner));
        public static readonly Random Random = new();
        public CheckBox[,] AcceptedClusters;
        public List<CheckedListBox> ConsonantBoxes;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Main()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            InitializeComponent();
            ConsonantBoxes = [];
            Vowels.DataSource = Vowel.All;
            Vowels.DisplayMember = "DisplayString";
            PopulateConsonants();
            PopulateClusterMatrix();
        }

        private void PopulateConsonants()
        {
            foreach (var manner in Manners)
            {
                LetterSelectonPanel.Controls.Add(CreateConsonantsBox(manner));
            }
        }

        private GroupBox CreateConsonantsBox(Manner manner)
        {
            var data = Consonant.All.Where(x => x.Manner == manner).ToArray();

            GroupBox container = new()
            {
                Text = $"Pulmonic Consonants - {manner}",
                Height = 350,
                Width = 400,
                Font = new("Segue UI Semibold", 9, FontStyle.Bold),
            };
            SplitContainer split = new()
            {
                Orientation = Orientation.Horizontal,
                FixedPanel = FixedPanel.Panel1,
                SplitterDistance = 40,
                Dock = DockStyle.Fill
            };
            FlowLayoutPanel buttonContainer = new()
            {
                Dock = DockStyle.Fill,
            };
            Button selectAll = new()
            {
                AutoSize = true,
                BackColor = SystemColors.ButtonFace,
                Text = "Select All",
                Font = new("Segoe UI", 9),
            };
            selectAll.Click += ConsonantBoxSelectAll_Click;
            Button selectNone = new()
            {
                AutoSize = true,
                BackColor = SystemColors.ButtonFace,
                Text = "Select None",
                Font = new("Segoe UI", 9),
            };
            selectNone.Click += ConsonantBoxSelectNone_Click;
            CheckedListBox checkbox = new()
            {
                CheckOnClick = true,
                Dock = DockStyle.Fill,
                Font = new("Times New Roman", 12, FontStyle.Bold),
                HorizontalScrollbar = true,
                DataSource = data,
                DisplayMember = "DisplayString",
            };

            ConsonantBoxes.Add(checkbox);

            buttonContainer.Controls.AddRange([selectAll, selectNone]);
            split.Panel1.Controls.Add(buttonContainer);
            split.Panel2.Controls.Add(checkbox);
            container.Controls.Add(split);
            return container;
        }

        private void ConsonantBoxSelectAll_Click(object? sender, EventArgs e)
        {
            if (sender is null) return;
            var checkbox = GetBoxFromButton((Button)sender);
            if (checkbox is not null)
                SetAllItemsChecked(checkbox, true);
        }

        private void ConsonantBoxSelectNone_Click(object? sender, EventArgs e)
        {
            if (sender is null) return;
            var checkbox = GetBoxFromButton((Button)sender);
            if (checkbox is not null)
                SetAllItemsChecked(checkbox, false);
        }

        private CheckedListBox? GetBoxFromButton(Button btn)
        {
            return btn.Parent?.Parent?.Parent?.FindControl<CheckedListBox>();
        }

        private void PopulateClusterMatrix()
        {
            // Cluster Matrix
            AcceptedClusters = new CheckBox[Manners.Length, Manners.Length];
            ClusterMatrix.RowCount = ClusterMatrix.ColumnCount = Manners.Length + 1;
            foreach (var m in Manners)
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
                foreach (var n in Manners)
                {
                    var y = (int)n;
                    CheckBox checkbox = new() { Checked = x != y };
                    AcceptedClusters[x, y] = checkbox;
                    ClusterMatrix.Controls.Add(checkbox, y + 1, x + 1);
                }
            }
            ClusterMatrix.ColumnStyles.Clear();
            ClusterMatrix.RowStyles.Clear();
            _ = ClusterMatrix.ColumnStyles.Add(new(SizeType.AutoSize));
            _ = ClusterMatrix.RowStyles.Add(new(SizeType.AutoSize));
            for (int i = 1; i < ClusterMatrix.ColumnCount; i++)
            {
                _ = ClusterMatrix.ColumnStyles.Add(new(SizeType.Absolute, 30));
                _ = ClusterMatrix.RowStyles.Add(new(SizeType.AutoSize));
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
            SetAllItemsChecked(Vowels, true);
            foreach (var box in ConsonantBoxes)
                SetAllItemsChecked(box, true);
        }

        #region Select All/None Buttons

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
            if (!SyllableShapePattern().IsMatch(shapeInput))
            {
                _ = MessageBox.Show("Syllable shape must be in format \"CVC\", and is not case-sensitve.");
                return;
            }
            var sParts = shapeInput.Split('v');
            var onset = sParts[0].Length;
            var coda = sParts[1].Length;
            var consonants = new List<Consonant>();
            foreach (var box in ConsonantBoxes)
                consonants.AddRange(box.CheckedItems.Cast<Consonant>().ToList());
            var vowels = Vowels.CheckedItems.Cast<Vowel>().ToList();
            if (vowels.Count < 1 || consonants.Count < 1)
                return;

            Dictionary<Manner, List<Manner>> acceptableFollowers = [];
            var manners = consonants.Select(x => x.Manner).Distinct().ToList();
            if (manners is null) return;
            foreach (var m in manners)
            {
                var localManners = GetAcceptedFollowerTypes(m);
                localManners = localManners.Where(manners.Contains).ToList();
                if (localManners.Count < 1)
                {
                    _ = MessageBox.Show($"{m} consonants have no acceptable followers.");
                    return;
                }
                acceptableFollowers[m] = localManners;
            }
            SyllableOutput.Clear();
            List<string> strings = [];

            for (int i = 0; i < 1000; i++)
            {
                var s = string.Empty;
                var tries = 0;
                do
                {
                    tries++;
                    List<IPALetter> word = [];
                    var pos = 0;

                    // Onset
                    word.AddRange(GenerateCluster(onset, consonants, acceptableFollowers));
                    // Vowel
                    word.Add(vowels[Random.Next(0, vowels.Count)]);
                    pos++;
                    // Coda
                    word.AddRange(GenerateCluster(coda, consonants, acceptableFollowers));

                    s = string.Join("", word);
                } while (strings.Contains(s) && tries < 10);
                if (tries < 10)
                    strings.Add(s);
            }
            strings.Sort();
            SyllableOutput.Lines = [.. strings];
        }

        private Consonant[] GenerateCluster(
            int length,
            List<Consonant> consonants,
            Dictionary<Manner, List<Manner>> followerManners)
        {
            Consonant[] word = new Consonant[length];
            for (int pos = 0; pos < length; pos++)
                if (pos > 0)
                {
                    var prevManner = ((Consonant)word[pos - 1]).Manner;
                    var acceptable = consonants.Where(x => followerManners[prevManner].Contains(x.Manner)).ToArray();
                    word[pos] = acceptable[Random.Next(0, acceptable.Length)];
                }
                else
                {
                    word[pos] = consonants[Random.Next(0, consonants.Count)];
                }
            return word;
        }

        private List<Manner> GetAcceptedFollowerTypes(Manner manner)
        {
            var len = Manners.Length;
            List<Manner> accepts = [];
            for (int i = 0; i < len; i++)
                if (AcceptedClusters[(int)manner, i].Checked)
                    accepts.Add((Manner)i);
            return accepts;
        }

        [GeneratedRegex("^c*v{1}c*$")]
        private static partial Regex SyllableShapePattern();

        private void SelectAllClusters_Click(object sender, EventArgs e)
        {
            foreach (CheckBox box in AcceptedClusters)
            {
                box.Checked = true;
            }
        }

        private void SelectNoneClusters_Click(object sender, EventArgs e)
        {
            foreach (CheckBox box in AcceptedClusters)
            {
                box.Checked = false;
            }
        }

        private void ResetClusters_Click(object sender, EventArgs e)
        {
            foreach (CheckBox box in AcceptedClusters)
            {
                box.Checked = true;
            }
            for (int i = 0; i < Manners.Length; i++)
                AcceptedClusters[i,i].Checked = false;
        }
    }
}
