using System.Text;

namespace conlanger
{

    public class Syllable : IComparable<Syllable>
    {
        public const char PrimaryStress = '\u02C8';
        public const char SecondaryStress = '\u02CC';
        public const char MoraicBoundryMarker = ',';

        public List<IPALetter> SoundWord { get; set; }
        public Dictionary<int, char> MoraStresses { get; set; }
        public char? SyllabicStress { get; set; }
        public Vowel? Nucleus => SoundWord.Where(x => x.GetType().InheritsFromOrIs(typeof(Vowel))).Cast<Vowel>().FirstOrDefault();
        public int NucleusIndex => Nucleus is null ? -1 : SoundWord.IndexOf(Nucleus);
        public bool HasOnset => NucleusIndex > 0;
        public bool HasCoda => Nucleus is not null && NucleusIndex < SoundWord.Count - 1;
        public bool IsHeavy => Nucleus is not null && (Nucleus.Long || HasCoda);
        public List<IPALetter> Onset => Nucleus is null ? SoundWord : SoundWord.GetRange(0, NucleusIndex);
        public List<IPALetter> Coda => Nucleus is null ? [] : SoundWord.GetRange(NucleusIndex + 1, SoundWord.Count - NucleusIndex - 1);

        public int CountMora(Moraism moraism)
        {
            if (Nucleus is null) return 0; // Only consonants, no mora
            int mora = Nucleus.Long ? 2 : 1; // Long consonants are 2 mora
            if (HasCoda)
                mora++; // Add a mora for a coda
            if (moraism is Moraism.Bimoraic && mora > 2)
                mora = 2; // Reduce if not Trimoraic
            return mora;
        }

        public void Add(IPALetter letter) => SoundWord.Add(letter);
        public void AddRange(IEnumerable<IPALetter> letters) => SoundWord.AddRange(letters);

        public Syllable()
        {
            SoundWord = [];
            MoraStresses = [];
        }

        public int CompareTo(Syllable? other)
        {
            if (other is null) return 1;
            return ToString().CompareTo(other.ToString());
        }

        public string Format(Moraism moraism)
        {
            // stahp
            if (Nucleus is null) return ToString();
            var sb = new StringBuilder();
            if (MoraStresses.TryGetValue(0, out char value))
                sb.Append(value);
            if (HasOnset)
                sb.Append(string.Join("", Onset));
            if (!Nucleus.Long)
            {
                // Short Nucleus, just add.
                sb.Append(Nucleus);
                if (HasCoda)
                {
                    sb.Append(MoraicBoundryMarker);
                    if (MoraStresses.TryGetValue(1, out char value1))
                        sb.Append(value1);
                    sb.Append(string.Join("", Coda));
                }
            }
            else
            {
                if (Nucleus is Dipthong dip)
                {
                    sb.Append(dip.ParentVowels[0]);
                    sb.Append(MoraicBoundryMarker);
                    if (MoraStresses.TryGetValue(1, out char value1))
                        sb.Append(value1);
                    sb.Append(dip.ParentVowels[1]);
                    if (moraism is Moraism.Trimoraic && HasCoda)
                    {
                        sb.Append(MoraicBoundryMarker);
                        if (MoraStresses.TryGetValue(2, out char value2))
                            sb.Append(value2);
                    }
                    sb.Append(string.Join("", Coda));
                }
                else
                {
                    var parent = Vowel.All.Where(
                        x =>
                        x.Position == Nucleus.Position &&
                        x.PositionTip == Nucleus.PositionTip &&
                        x.Rounded == Nucleus.Rounded &&
                        x.Long == false
                        ).First();
                    sb.Append(parent);
                    sb.Append(MoraicBoundryMarker);
                    if (MoraStresses.TryGetValue(1, out char value1))
                        sb.Append(value1);
                    sb.Append(parent);
                    if (moraism is Moraism.Trimoraic && HasCoda)
                    {
                        sb.Append(MoraicBoundryMarker);
                        if (MoraStresses.TryGetValue(2, out char value2))
                            sb.Append(value2);
                    }
                    sb.Append(string.Join("", Coda));
                }
            }
            return sb.ToString();
        }

        public override string ToString()
        {
            var ret = string.Join("", SoundWord);
            ret = $"{(SyllabicStress is not null ? SyllabicStress : string.Empty)}{ret}";
            return ret;
        }

        public void AddMoraStress(int moraPosition, char marker)
        {
            MoraStresses.Add(moraPosition, marker);
        }
    }
}
