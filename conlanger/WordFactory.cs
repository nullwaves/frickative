﻿namespace conlanger
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
        public bool ResultantStress { get; set; }
        public StressDirection ResultantDirection { get; set; }

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
            int secondary = settings.FootSize is FootSize.Triambic &&
                settings.ResultantStress ?
                settings.ResultantDirection is StressDirection.Primary ?
                1 : -1 : 0; // 1 if Forward, -1 if Back, 0 if None
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
                    {
                        word.AddMoraStress(i, Syllable.PrimaryStress, settings.Moraism);
                        if (secondary != 0)
                        {
                            var spos = secondary + i;
                            if (spos > -1 && spos < moraCount)
                            {
                                word.AddMoraStress(spos, Syllable.SecondaryStress, settings.Moraism);
                            }
                        }
                    }
                }
                else
                {
                    // Syllabic - Fixed
                    int initPos = dir > 0 ? degree : word.Count - (degree + 1);
                    if (!settings.Weighted)
                        // Unweighted
                        for (int i = initPos; i > -1 && i < word.Count; i += slope)
                        {
                            word[i].SyllabicStress = Syllable.PrimaryStress;
                            if (secondary != 0)
                            {
                                var spos = secondary + i;
                                if (spos > -1 && spos < word.Count)
                                {
                                    word[spos].SyllabicStress = Syllable.SecondaryStress;
                                }
                            }
                        }
                    else
                    {
                        // Weighted - filter out light syllables.
                        var syls = word.Syllables.Where(x => x.IsHeavy).ToList();
                        initPos = dir > 0 ? degree : syls.Count - (degree + 1);
                        for (int i = initPos; i > -1 && i < syls.Count; i += slope)
                        {
                            syls[i].SyllabicStress = Syllable.PrimaryStress;
                            if (secondary != 0)
                            {
                                var spos = secondary + i;
                                if (spos > -1 && spos < syls.Count)
                                {
                                    word[spos].SyllabicStress = Syllable.SecondaryStress;
                                }
                            }
                        }
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
                    int initOffset = rand.Next(foot <= length ? foot : length);
                    for (int pos = initOffset; pos < moraCount; pos += foot)
                    {
                        word.AddMoraStress(pos, Syllable.PrimaryStress, settings.Moraism);
                        if (secondary != 0)
                        {
                            var spos = secondary + pos;
                            if (spos > -1 && spos < moraCount)
                            {
                                word.AddMoraStress(spos, Syllable.SecondaryStress, settings.Moraism);
                            }
                        }
                    }
                }
                else
                {
                    // Phonemic - Syllabic
                    int initOffset = rand.Next(foot <= length ? foot : length);
                    word[initOffset].SyllabicStress = Syllable.PrimaryStress;
                    for (int pos = initOffset; pos < word.Count; pos += foot)
                    {
                        word[pos].SyllabicStress = Syllable.PrimaryStress;
                        if (secondary != 0)
                        {
                            var spos = secondary + pos;
                            if (spos > -1 && spos < word.Count)
                            {
                                word[spos].SyllabicStress = Syllable.SecondaryStress;
                            }
                        }
                    }
                }
            }
            return word;
        }
    }
}
