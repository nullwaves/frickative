using System.Diagnostics;

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

    public enum StressDirection
    {
        Primary,
        Ultimate,
    }

    public enum StressDegree
    {
        First = 0,
        Second = 1,
        Third = 2
    }

    public enum Moraism
    {
        Bimoraic = 2,
        Trimoraic = 3,
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
        public bool Weighted { get; set; }
        public StressDegree StressDegree { get; set; }
        public StressDirection StressDirection { get; set; }
        public Moraism Moraism { get; set; }

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
                int degree = foot == 2 && settings.StressDegree == StressDegree.Third ? 0 : (int)settings.StressDegree;
                int dir = settings.StressDirection is StressDirection.Primary ? 1 : -1;
                int slope = dir * foot;
                if (isMoraic)
                {
                    // Moraic - Fixed
                    int moraCount = word.CountMora(settings.Moraism);
                    int initPos = dir > 0 ? degree : moraCount - (degree + 1);
                    for (int i = initPos; i > -1 && i < moraCount; i += slope)
                        word.AddMoraStress(i, settings.Moraism);
                }
                else
                {
                    // Phonemix - Fixed
                    int initPos = dir > 0 ? degree : word.Count - (degree + 1);
                    if (!settings.Weighted)
                        // Unweighted
                        for (int i = initPos; i > -1 && i < word.Count; i += slope)
                            word[i].SyllabicStress = true;
                    else
                    {
                        // Weighted - filter out light syllables.
                        var syls = word.Syllables.Where(x => x.IsHeavy).ToList();
                        initPos = dir > 0 ? degree : syls.Count - (degree + 1);
                        for (int i = initPos; i > -1 && i < syls.Count; i += slope)
                            syls[i].SyllabicStress = true;
                    }
                }
            }
            else
            {
                // Phonemic
                if (isMoraic)
                {
                    // Moraism
                    int moraCount = word.CountMora(settings.Moraism);
                    int initOffset = rand.Next(moraCount);
                    word.AddMoraStress(initOffset, settings.Moraism);
                    for (int pos = initOffset + foot; pos < moraCount; pos += foot)
                        word.AddMoraStress(pos, settings.Moraism);
                    for (int pos = initOffset - foot; pos > -1; pos -= foot)
                        word.AddMoraStress(pos, settings.Moraism);
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
