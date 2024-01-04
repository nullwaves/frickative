using System.DirectoryServices;
using System.Text.RegularExpressions;

namespace frickative
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            PulmonicConsonants.DataSource = Consonant.All;
            PulmonicConsonants.DisplayMember = "DisplayString";
            Vowels.DataSource = Vowel.All;
            Vowels.DisplayMember = "DisplayString";
        }

        private void SelectAllPulmonicConsonants_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < PulmonicConsonants.Items.Count; i++)
            {
                PulmonicConsonants.SetItemChecked(i, true);
            }
        }

        private void SelectNonePulmonicConsonants_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < PulmonicConsonants.Items.Count; i++)
            {
                PulmonicConsonants.SetItemChecked(i, false);
            }
        }

        private void SelectAllVowels_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Vowels.Items.Count; i++)
            {
                Vowels.SetItemChecked(i, true);
            }
        }

        private void SelectNoneVowels_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Vowels.Items.Count; i++)
            {
                Vowels.SetItemChecked(i, false);
            }
        }

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
