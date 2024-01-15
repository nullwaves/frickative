namespace conlanger
{
    public enum FootSize
    {
        Biambic = 2,
        Triambic = 3
    }

    public enum CountBy
    {
        Syllabic = 0,
        Moraic = 1
    }

    public enum StressSystem
    {
        Phonemic = 0,
        Fixed = 1
    }

    public class WordFactorySettings
    {
        public List<SyllableShape> PrimaryShapes { get; set; }
        public List<SyllableShape> MiddleShapes { get; set; }
        public List<SyllableShape> UltimateShapes { get; set; }

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

        public CountBy CountBy { get; set; }
        public FootSize FootSize { get; set; }
        public StressSystem StressSystem { get; set; }

        public WordFactorySettings()
        {
            PrimaryShapes = [];
            MiddleShapes = [];
            UltimateShapes = [];
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
                    sylSettings.Shape = settings.MiddleShapes[rand.Next(settings.MiddleShapes.Count)];
                    word.Add(SyllableFactory.MakeSyllable(sylSettings));
                }
                else if (length > 1 && syl == length-1)
                {
                    // Ultimate Syllable
                    sylSettings.Shape = settings.UltimateShapes[rand.Next(settings.UltimateShapes.Count)];
                    word.Add(SyllableFactory.MakeSyllable(sylSettings));
                }
            }
            // Apply Stress
            // Directly To The Word
            var foot = (int)settings.FootSize;
            bool isFixed = settings.StressSystem == StressSystem.Fixed;
            bool isMoraic = settings.CountBy == CountBy.Moraic;
            if (isFixed)
            {
                // Fixed
                throw new NotImplementedException();
            }
            else
            {
                // Phonemic
                if (isMoraic)
                {
                    // Moraic
                    throw new NotImplementedException();
                }
                else
                {
                    // Phonemic - Syllabic
                    int initOffset = rand.Next(word.Count);
                    word[initOffset].SyllabicStress = true;
                    for (int pos = initOffset + foot; pos < word.Count; pos += foot)
                        word[pos].SyllabicStress = true;
                    for (int pos = initOffset - foot; pos > -1; pos -= foot)
                        word[pos].SyllabicStress = true;
                }
            }

            return word;
        }
    }
}
