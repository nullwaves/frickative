using conlanger;
using System.Text;

namespace frickform
{
    public partial class Main : Form
    {
        public static Manner[] Manners => (Manner[])Enum.GetValues(typeof(Manner));
        public static readonly Random Random = new();
        public CheckBox[,] AcceptedClusters;
        public List<CheckedListBox> ConsonantBoxes;
        public CheckedListBox Vowels, Dipthongs;
        public TextBox PShapes, MShapes, UShapes;
        public ComboBox FootSizeInput, MoraismInput, ResultantDirectionInput, StressCountingInput, StressSystemInput,
            StressDirectionInput, StressDegreeInput;
        public CheckBox FixedIsWeighted, ResultantStressInput;

        public bool AllowCrowding => !DisallowVoiceCrowding.Checked;
        public List<SyllableShape> PrimaryShapes
        {
            get
            {
                var shapes = new List<SyllableShape>();
                foreach (var line in PShapes.Lines)
                {
                    if (SyllableShape.TryParse(line.Trim(), out var shape))
                        shapes.Add(shape);
                    else
                    {
                        _ = MessageBox.Show($"Invalid shape '{line}' in Primary Shapes", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                return shapes;
            }
        }
        public List<SyllableShape> MiddleShapes
        {
            get
            {
                var shapes = new List<SyllableShape>();
                foreach (var line in MShapes.Lines)
                {
                    if (SyllableShape.TryParse(line.Trim(), out var shape))
                        shapes.Add(shape);
                    else
                    {
                        _ = MessageBox.Show($"Invalid shape '{line}' in Middle Shapes", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                return shapes;
            }
        }
        public List<SyllableShape> UltimateShapes
        {
            get
            {
                var shapes = new List<SyllableShape>();
                foreach (var line in UShapes.Lines)
                {
                    if (SyllableShape.TryParse(line.Trim(), out var shape))
                        shapes.Add(shape);
                    else
                    {
                        _ = MessageBox.Show($"Invalid shape '{line}' in Ultimate Shapes", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                return shapes;
            }
        }
        public List<Consonant> SelectedConsonants
        {
            get
            {
                var consonants = new List<Consonant>();
                foreach (var box in ConsonantBoxes)
                    consonants.AddRange(box.CheckedItems.Cast<Consonant>().ToList());
                return consonants;
            }
        }
        public List<IPALetter> SelectedVowels
        {
            get
            {
                var vowels = Vowels.CheckedItems.Cast<IPALetter>().ToList();
                vowels.AddRange(Dipthongs.CheckedItems.Cast<IPALetter>().ToList());
                return vowels;
            }
        }

        // Stress Settings
        public FootSize FootSize => (FootSize)(FootSizeInput.SelectedItem ?? FootSize.Biambic);
        public CountBy CountBy => (CountBy)(StressCountingInput.SelectedItem ?? CountBy.Syllabic);
        public StressSystem StressSystem => (StressSystem)(StressSystemInput.SelectedItem ?? StressSystem.Phonemic);
        public StressDegree StressDegree => (StressDegree)(StressDegreeInput.SelectedItem ?? StressDegree.First);
        public StressDirection StressDirection => (StressDirection)(StressDirectionInput.SelectedItem ?? StressDirection.Primary);
        public bool Weighted => FixedIsWeighted.Checked;
        public Moraism Moraism => (Moraism)(MoraismInput.SelectedItem ?? Moraism.Bimoraic);
        public bool ResultantStress => ResultantStressInput.Checked;
        public StressDirection ResultantDirection => (StressDirection)(ResultantDirectionInput.SelectedItem ?? StressDirection.Primary);

        #region Construct/Init

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Main()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            InitializeComponent();
            Text = $"Frickative v{Application.ProductVersion}";
            ConsonantBoxes = [];
            PopulateSyllableShapeInputs();
            PopulateLetterSelection();
            PopulateClusterMatrix();
        }

        private void PopulateSyllableShapeInputs()
        {
#pragma warning disable CS8601 // Possible null reference assignment.
            var box = CreateShapeInputBox("Primary Shapes");
            LetterSelectonPanel.Controls.Add(box);
            PShapes = box.FindControl<TextBox>();
            var box2 = CreateShapeInputBox("Middle Shapes");
            LetterSelectonPanel.Controls.Add(box2);
            MShapes = box2.FindControl<TextBox>();
            var box3 = CreateShapeInputBox("Ultimate Shapes");
            LetterSelectonPanel.Controls.Add(box3);
            UShapes = box3.FindControl<TextBox>();
#pragma warning restore CS8601 // Possible null reference assignment.
            LetterSelectonPanel.Controls.Add(CreateStressSettingsBox());
        }

        private void PopulateLetterSelection()
        {
            LetterSelectonPanel.Controls.Add(CreateVowelsBox());
            LetterSelectonPanel.Controls.Add(CreateDipthongsBox());
            foreach (var manner in Manners)
            {
                LetterSelectonPanel.Controls.Add(CreateConsonantsBox(manner));
            }
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

        private void Main_Load(object sender, EventArgs e)
        {
            SetInitialState();
        }

        private void SetInitialState()
        {
            Vowels.SetAllChecked(true);
            Dipthongs.SetAllChecked(true);
            foreach (var box in ConsonantBoxes)
                box.SetAllChecked(true);
            SetInitialClusterState();
            DisallowVoiceCrowding.Checked = true;
            foreach (var box in new TextBox[] { PShapes, MShapes, UShapes })
                box.Text = "cvc\r\nccvc\r\nvc";
        }

        private void SetInitialClusterState()
        {
            foreach (CheckBox box in AcceptedClusters)
            {
                box.Checked = true;
            }
            for (int i = 0; i < Manners.Length; i++)
                AcceptedClusters[i, i].Checked = false;
        }

        #endregion

        #region Control Factories

        private static GroupBox CreateShapeInputBox(string text)
        {
            var container = CreateGroupBox(text);
            var tbox = new TextBox()
            {
                Dock = DockStyle.Fill,
                Font = new("Segoe UI", 9),
                Multiline = true,
            };
            container.Controls.Add(tbox);
            return container;
        }

        private GroupBox CreateStressSettingsBox()
        {
            var box = CreateGroupBox("Stress");
            var flow = new FlowLayoutPanel()
            {
                AutoScroll = true,
                Dock = DockStyle.Fill,
                Font = new("Segoe UI", 9),
            };
            var table = new TableLayoutPanel() { Parent = flow, AutoSize = true, ColumnCount = 2 };
            // Foot Size
            table.Controls.Add(new Label() { Text = "Foot Size:", AutoSize = true }, 0, 0);
            var foot = new ComboBox() { DataSource = (FootSize[])Enum.GetValues(typeof(FootSize)) };
            FootSizeInput = foot;
            FootSizeInput.SelectedValueChanged += FootSizeInput_SelectedValueChanged;
            table.Controls.Add(foot, 1, 0);
            // Counting System
            table.Controls.Add(new Label() { Text = "Count By:", AutoSize = true }, 0, 1);
            var stype = new ComboBox() { DataSource = (CountBy[])Enum.GetValues(typeof(CountBy)) };
            StressCountingInput = stype;
            StressCountingInput.SelectedValueChanged += StressCountingInput_SelectedValueChanged;
            table.Controls.Add(stype, 1, 1);
            // Moraism
            table.Controls.Add(new Label() { Text = "Moraism:", AutoSize = true }, 0, 2 );
            var moraism = new ComboBox() { DataSource = (Moraism[])Enum.GetValues(typeof(Moraism)) };
            MoraismInput = moraism;
            table.Controls.Add(moraism, 1, 2);
            // Stress System
            table.Controls.Add(new Label() { Text = "Stress Type:", AutoSize = true }, 0, 3);
            var ssys = new ComboBox() { DataSource = (StressSystem[])Enum.GetValues(typeof(StressSystem)) };
            StressSystemInput = ssys;
            table.Controls.Add(ssys, 1,3);
            // Fixed Weighting
            var weight = new CheckBox() { Text = "Weighted", AutoSize = true, Enabled = false };
            table.Controls.Add(weight, 1, 4);
            table.SetColumnSpan(weight, 2);
            FixedIsWeighted = weight;
            StressSystemInput.SelectedIndexChanged += StressSystemInput_SelectedIndexChanged;
            // Stress Direction
            table.Controls.Add(new Label() { Text = "Direction:", AutoSize = true }, 0, 5);
            var direct = new ComboBox() 
            { 
                DataSource = (StressDirection[])Enum.GetValues(typeof(StressDirection)),
                Enabled = false
            };
            StressDirectionInput = direct;
            table.Controls.Add(direct, 1, 5);
            // Stress Degree
            table.Controls.Add(new Label() { Text = "Degree:", AutoSize = true }, 0, 6);
            var degree = new ComboBox() { DataSource = (StressDegree[])Enum.GetValues(typeof(StressDegree)), Enabled = false };
            StressDegreeInput = degree;
            table.Controls.Add(degree, 1, 6);
            // Resultant Stress
            var resultant = new CheckBox() { Text = "Resultant Stress", AutoSize = true, Enabled = false };
            ResultantStressInput = resultant;
            table.Controls.Add(resultant, 0, 7);
            table.SetColumnSpan(resultant, 2);
            // Resultant Direction
            table.Controls.Add(new Label() { Text = "Resultant Direction:", AutoSize = true }, 0, 8);
            var resDir = new ComboBox() { DataSource = (StressDirection[])Enum.GetValues(typeof(StressDirection)), Enabled = false };
            ResultantDirectionInput = resDir;
            table.Controls.Add(resDir, 1, 8);

            box.Controls.Add(flow);
            return box;
        }

        private GroupBox CreateVowelsBox()
        {
#pragma warning disable CS8601, CS8602, CS8622 // CreateFrickContainer and its contents are not nullable
            var box = CreateFrickContainer("Vowels", Vowel.All);
            Vowels = box.FindControl<CheckedListBox>();
            Vowels.ItemCheck += Vowels_ItemCheck;
            return box;
#pragma warning restore CS8601, CS8602, CS8622
        }

        private GroupBox CreateDipthongsBox()
        {
#pragma warning disable CS8601 // Possible null reference assignment.
            var box = CreateFrickContainer("Dipthongs", null);
            Dipthongs = box.FindControl<CheckedListBox>();
            return box;
#pragma warning restore CS8601 // Possible null reference assignment.
        }

        private static Button CreateFrickButton(string text)
        {
            return new()
            {
                AutoSize = true,
                BackColor = SystemColors.ButtonFace,
                Text = text,
                Font = new("Segoe UI", 9)
            };
        }

        private static GroupBox CreateGroupBox(string text)
        {
            return new()
            {
                Text = text,
                Size = new(400, 350),
                Font = new("Segoe UI Semibold", 9, FontStyle.Bold)
            };
        }

        private static SplitContainer CreateHSplit()
        {
            return new()
            {
                Orientation = Orientation.Horizontal,
                FixedPanel = FixedPanel.Panel1,
                SplitterDistance = 40,
                Dock = DockStyle.Fill
            };
        }

        private static CheckedListBox CreateCheckedList()
        {
            return new()
            {
                CheckOnClick = true,
                Dock = DockStyle.Fill,
                Font = new("Times New Roman", 12, FontStyle.Bold),
                HorizontalScrollbar = true,
            };
        }

        private GroupBox CreateFrickContainer(string text, object? data)
        {
            var container = CreateGroupBox(text);
            var split = CreateHSplit();
            FlowLayoutPanel buttonContainer = new()
            {
                Dock = DockStyle.Fill,
            };
            Button selectAll = CreateFrickButton("Select All");
            selectAll.Click += ConsonantBoxSelectAll_Click;
            Button selectNone = CreateFrickButton("Select None");
            selectNone.Click += ConsonantBoxSelectNone_Click;
            var checkbox = CreateCheckedList();
            checkbox.DataSource = data;
            checkbox.DisplayMember = "DisplayString";

            buttonContainer.Controls.AddRange([selectAll, selectNone]);
            split.Panel1.Controls.Add(buttonContainer);
            split.Panel2.Controls.Add(checkbox);
            container.Controls.Add(split);
            return container;
        }

        private GroupBox CreateConsonantsBox(Manner manner)
        {
            var data = Consonant.All.Where(x => x.Manner == manner).ToArray();

            GroupBox container = CreateFrickContainer($"Pulmonic Consonants - {manner}", data);
#pragma warning disable CS8604 // Possible null reference argument.
            ConsonantBoxes.Add(container.FindControl<CheckedListBox>());
#pragma warning restore CS8604 // Possible null reference argument.
            return container;
        }

        private static CheckedListBox? GetBoxFromButton(Button btn)
        {
            return btn.Parent?.Parent?.Parent?.FindControl<CheckedListBox>();
        }

        #endregion

        #region Select All/None Buttons

        private void ConsonantBoxSelectAll_Click(object? sender, EventArgs e)
        {
            if (sender is null) return;
            var checkbox = GetBoxFromButton((Button)sender);
            checkbox?.SetAllChecked(true);
        }

        private void ConsonantBoxSelectNone_Click(object? sender, EventArgs e)
        {
            if (sender is null) return;
            var checkbox = GetBoxFromButton((Button)sender);
            checkbox?.SetAllChecked(false);
        }

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

        #endregion

        private Dictionary<Manner, List<Manner>>? GetAcceptableFollowers()
        {
            Dictionary<Manner, List<Manner>> acceptableFollowers = [];
            var manners = SelectedConsonants.Select(x => x.Manner).Distinct().ToList();
            if (manners is null) return null;
            foreach (var m in manners)
            {
                var localManners = GetAcceptedFollowerTypes(m);
                localManners = localManners.Where(manners.Contains).ToList();
                if (localManners.Count < 1)
                {
                    _ = MessageBox.Show($"{m} consonants have no acceptable followers.");
                    return null;
                }
                acceptableFollowers[m] = localManners;
            }
            return acceptableFollowers;
        }

        private void GenerateSyllables_Click(object sender, EventArgs e)
        {
            if (!SyllableShape.TryParse(SyllableShapeInput.Text.Trim().ToLower(), out var shape))
            {
                _ = MessageBox.Show("Syllable shape must be in format \"cvc\", and is not case-sensitve.");
                return;
            }
            if (SelectedVowels.Count < 1 || SelectedConsonants.Count < 1)
            {
                _ = MessageBox.Show("Must select at least 1 Consonant and 1 Vowel.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var acceptableFollowers = GetAcceptableFollowers();
            if (acceptableFollowers == null) return;

            var settings = new SyllableFactorySettings()
            {
                Shape = shape,
                Consonants = SelectedConsonants,
                Vowels = SelectedVowels,
                AllowCrowding = AllowCrowding,
                Clusters = acceptableFollowers
            };

            SyllableOutput.Clear();
            List<string> strings = [];

            for (int i = 0; i < 1000; i++)
            {
                var s = string.Empty;
                var tries = 0;
                do
                {
                    tries++;
                    s = SyllableFactory.MakeSyllable(settings).ToString();

                } while (strings.Contains(s) && tries < 10);
                if (tries < 10)
                    strings.Add(s);
            }
            strings.Sort();
            SyllableOutput.Lines = [.. strings];
        }

        private void GenerateWords_Click(object sender, EventArgs e)
        {
            if (SelectedVowels.Count < 1 || SelectedConsonants.Count < 1)
            {
                _ = MessageBox.Show("Must select at least 1 Consonant and 1 Vowel.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var acceptableFollowers = GetAcceptableFollowers();
            if (acceptableFollowers == null) return;

            var sylSettings = new SyllableFactorySettings()
            {
                Shape = new(),
                Consonants = SelectedConsonants,
                Vowels = SelectedVowels,
                AllowCrowding = AllowCrowding,
                Clusters = acceptableFollowers
            };

            var settings = new WordFactorySettings()
            {
                PrimaryShapes = PrimaryShapes,
                MiddleShapes = MiddleShapes,
                UltimateShapes = UltimateShapes,
                SyllableSettings = sylSettings,
                FootSize = FootSize,
                CountBy = CountBy,
                StressSystem = StressSystem,
                StressDegree = StressDegree,
                StressDirection = StressDirection,
                Weighted = Weighted,
                Moraism = Moraism,
                ResultantStress = ResultantStress,
                ResultantDirection = ResultantDirection,
            };

            if(!int.TryParse(NumberOfSyllables.Text, out int length))
            {
                NumberOfSyllables.Clear();
                NumberOfSyllables.Focus();
                return;
            }

            var words = new List<Word>();
            for (int i = 0; i < 1000; i++)
            {
                words.Add(WordFactory.MakeWord(settings, length));
            }
            SyllableOutput.Clear();
            var sb = new StringBuilder();
            foreach (var item in words)
                sb.AppendLine(CountBy is CountBy.Syllabic ? item.ToString() : item.Format(Moraism));
            SyllableOutput.Text = sb.ToString(); ;
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

        #region MainToolStrip Events

        private void ResetClusters_Click(object sender, EventArgs e) => SetInitialClusterState();

        private void Exit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you'd like to quit?", "frickform", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) { Application.Exit(); }
        }

        private void NewLanguage_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you'd like to clear all changes?", "frickform", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) { SetInitialState(); }
        }

        private void SelectAllConsonants_Click(object sender, EventArgs e)
        {
            foreach (var box in ConsonantBoxes)
                box.SetAllChecked(true);
        }

        private void SelectNoneConsonants_Click(object sender, EventArgs e)
        {
            foreach (var box in ConsonantBoxes)
                box.SetAllChecked(false);
        }

        #endregion

        #region Checkbox Events

        private void Vowels_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var box = sender as CheckedListBox;
            if (box?.Items[e.Index] is not Vowel vowel || box is null)
                throw new NullReferenceException("Vowel with checkstate to be changed was null");
            if (vowel.Long) return;
            if (e.NewValue == CheckState.Checked)
            {
                // Add new dipthongs to Dipthongs list
                List<Dipthong> possible = [];
                var vowels = box.CheckedItems.Cast<Vowel>().Where(x => !x.Long);
                foreach (var coda in vowels)
                {
                    var dip = new Dipthong(vowel, coda);
                    if (!Dipthongs.Items.Contains(dip))
                        Dipthongs.Items.Add(dip);
                    var rdip = new Dipthong(coda, vowel);
                    if (!Dipthongs.Items.Contains(rdip))
                        Dipthongs.Items.Add(rdip);
                }
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                // Remove unavailable dipthongs from list
                var noLongerAvailable = Dipthongs.Items.Cast<Dipthong>().Where(x => x.ParentVowels.Contains(vowel)).ToList();
                foreach (var dip in noLongerAvailable)
                    Dipthongs.Items.Remove(dip);
            }
        }

        private void FootSizeInput_SelectedValueChanged(object? sender, EventArgs e)
        {
            if (FootSize is FootSize.Triambic)
            {
                ResultantStressInput.Enabled = true;
                ResultantDirectionInput.Enabled = true;
            }
            else
            {
                ResultantStressInput.Enabled = false;
                ResultantStressInput.Checked = false;
                ResultantDirectionInput.Enabled = false;
            }
        }

        private void StressSystemInput_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (StressSystem is StressSystem.Fixed)
            {
                FixedIsWeighted.Enabled = !(CountBy == CountBy.Moraic);
                StressDegreeInput.Enabled = true;
                StressDirectionInput.Enabled = true;
            }
            else
            {
                FixedIsWeighted.Enabled = false;
                FixedIsWeighted.Checked = false;
                StressDegreeInput.Enabled = false;
                StressDirectionInput.Enabled = false;
            }
        }

        private void StressCountingInput_SelectedValueChanged(object? sender, EventArgs e)
        {
            if (CountBy is CountBy.Moraic)
            {
                MoraismInput.Enabled = true;
                if (FixedIsWeighted.Enabled)
                {
                    FixedIsWeighted.Checked = false;
                    FixedIsWeighted.Enabled = false;
                }
            }
            else
            {
                MoraismInput.Enabled = false;
                if (StressSystem is StressSystem.Fixed)
                {
                    FixedIsWeighted.Enabled = true;
                }
            }
        }

        #endregion
    }
}
