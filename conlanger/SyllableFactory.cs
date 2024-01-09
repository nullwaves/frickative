namespace conlanger
{
    public class SyllableFactorySettings
    {
        public SyllableShape Shape { get; set; }
        public List<Consonant> Consonants { get; set; }
        public List<IPALetter> Vowels { get; set; }
        public Dictionary<Manner, List<Manner>> Clusters { get; set; }
        public bool AllowCrowding { get; set; }

        public SyllableFactorySettings()
        {
            Shape = new();
            Clusters = [];
            Consonants = [];
            Vowels = [];
        }
    }

    public static class SyllableFactory
    {
        public static string MakeSyllableString(SyllableFactorySettings settings)
        {
            List<IPALetter> word = [];
            var pos = 0;

            // Onset
            word.AddRange(GenerateCluster(settings.Shape.Onset, settings.Consonants, settings.Clusters, settings.AllowCrowding));
            // Vowel
            word.Add(settings.Vowels[RandomService.Instance.Next(0, settings.Vowels.Count)]);
            pos++;
            // Coda
            word.AddRange(GenerateCluster(settings.Shape.Coda, settings.Consonants, settings.Clusters, settings.AllowCrowding));

            return string.Join("", word);
        }

        private static Consonant[] GenerateCluster(
            int length,
            List<Consonant> consonants,
            Dictionary<Manner, List<Manner>> followerManners,
            bool allowCrowding
            )
        {
            Consonant[] word = new Consonant[length];
            for (int pos = 0; pos < length; pos++)
                if (pos > 0)
                {
                    var lastletter = word[pos - 1];
                    var acceptable = consonants.Where(x => followerManners[lastletter.Manner].Contains(x.Manner)).ToList();
                    if (!allowCrowding && lastletter.Voiced)
                    {
                        var unvoiced = acceptable.Where(x => !x.Voiced).ToList();
                        foreach (var v in unvoiced)
                            acceptable.Remove(v);
                    }
                    word[pos] = acceptable[RandomService.Instance.Next(0, acceptable.Count)];
                }
                else
                {
                    word[pos] = consonants[RandomService.Instance.Next(0, consonants.Count)];
                }
            return word;
        }
    }
}
