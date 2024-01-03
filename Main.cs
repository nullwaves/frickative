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
            PulmonicConsonants.DataSource = PhoneticLetter.All;
            PulmonicConsonants.DisplayMember = "DisplayString";
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
    }
}
