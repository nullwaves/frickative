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
    }
}
