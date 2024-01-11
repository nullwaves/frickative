namespace conlanger
{
    public class WordFactorySettings
    {
        public List<SyllableShape> PrimaryShapes { get; set; }
        public List<SyllableShape> MiddleShapes { get; set; }
        public List<SyllableShape> UltimateShapes { get; set; }
        public bool AllowMora { get; set; }
        public List<IPALetter> Mora { get; set; }

        public SyllableFactorySettings SyllableSettings { get; set; }
        public List<Consonant> Consonants 
        { 
            get { return SyllableSettings.Consonants; } 
            set { SyllableSettings.Consonants = value; } 
        }
        public List<IPALetter> Vowels 
        { 
            get { return SyllableSettings.Vowels; } 
            set { SyllableSettings.Vowels = value; }
        }
        public Dictionary<Manner, List<Manner>> Clusters 
        { 
            get { return SyllableSettings.Clusters; } 
            set { SyllableSettings.Clusters = value; }
        }
        public bool AllowCrowding 
        { 
            get { return SyllableSettings.AllowCrowding; }
            set { SyllableSettings.AllowCrowding = value; }
        }

        public WordFactorySettings()
        {
            PrimaryShapes = [];
            MiddleShapes = [];
            UltimateShapes = [];
            Mora = [];
            SyllableSettings = new();
        }
    }

    public static class WordFactory
    {
        public static Word MakeWord(WordFactorySettings settings, int length)
        {
            Word word = new();
            var rand = RandomService.Instance;
            var sylSettings = settings.SyllableSettings;
            for (int syl = 0; syl < length; syl++)
            {
                if(syl == 0)
                {
                    // Primary Syllable
                    sylSettings.Shape = settings.PrimaryShapes[rand.Next(settings.PrimaryShapes.Count)];
                    word.Add(SyllableFactory.MakeSyllable(sylSettings));
                }
                else if (syl > 0 && syl < length-1)
                {
                    // Middle Syllable
                    if (settings.AllowMora)
                    {
                        int roll = rand.Next(settings.MiddleShapes.Count + 1);
                        if (roll == settings.MiddleShapes.Count)
                        {
                            word.Add(new Syllable() { SoundWord = { settings.Mora[rand.Next(settings.Mora.Count)] } });
                        }
                        else
                        {
                            sylSettings.Shape = settings.MiddleShapes[roll];
                            word.Add(SyllableFactory.MakeSyllable(sylSettings));
                        }
                    }
                    else
                    {
                        sylSettings.Shape = settings.MiddleShapes[rand.Next(settings.MiddleShapes.Count)];
                        word.Add(SyllableFactory.MakeSyllable(sylSettings));
                    }
                }
                else if (length > 1 && syl == length-1)
                {
                    // Ultimate Syllable
                    if (settings.AllowMora)
                    {
                        int roll = rand.Next(settings.UltimateShapes.Count + 1);
                        if (roll == settings.UltimateShapes.Count)
                        {
                            word.Add(new Syllable() { SoundWord = { settings.Mora[rand.Next(settings.Mora.Count)] } });
                        }
                        else
                        {
                            sylSettings.Shape = settings.UltimateShapes[roll];
                            word.Add(SyllableFactory.MakeSyllable(sylSettings));
                        }
                    }
                    else
                    {
                        sylSettings.Shape = settings.UltimateShapes[rand.Next(settings.UltimateShapes.Count)];
                        word.Add(SyllableFactory.MakeSyllable(sylSettings));
                    }
                }
            }
            return word;
        }
    }
}
