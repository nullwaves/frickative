using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace conlanger
{

    public class Syllable : IComparable<Syllable>
    {
        public const char PrimaryStress = '\u02C8';
        public const char MoraicBoundryMarker = ',';

        public List<IPALetter> SoundWord { get; set; }
        public List<int> MoraStresses { get; set; }
        public bool SyllabicStress { get; set; }
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
            if (MoraStresses.Contains(0))
                sb.Append(PrimaryStress);
            if (HasOnset)
                sb.Append(string.Join("", Onset));
            if (!Nucleus.Long)
            {
                // Short Nucleus, just add.
                sb.Append(Nucleus);
                if (HasCoda)
                {
                    sb.Append(MoraicBoundryMarker);
                    if (MoraStresses.Contains(1))
                        sb.Append(PrimaryStress);
                    sb.Append(string.Join("", Coda));
                }
            }
            else
            {
                if (Nucleus is Dipthong)
                {
                    Dipthong dip = (Dipthong)Nucleus;
                    sb.Append(dip.ParentVowels[0]);
                    sb.Append(MoraicBoundryMarker);
                    if (MoraStresses.Contains(1))
                        sb.Append(PrimaryStress);
                    sb.Append(dip.ParentVowels[1]);
                    if (moraism is Moraism.Trimoraic && HasCoda)
                    {
                        sb.Append(MoraicBoundryMarker);
                        if (MoraStresses.Contains(2))
                            sb.Append(PrimaryStress);
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
                    if (MoraStresses.Contains(1))
                        sb.Append(PrimaryStress);
                    sb.Append(parent);
                    if (moraism is Moraism.Trimoraic && HasCoda)
                    {
                        sb.Append(MoraicBoundryMarker);
                        if (MoraStresses.Contains(2))
                            sb.Append(PrimaryStress);
                    }
                    sb.Append(string.Join("", Coda));
                }
            }
            return sb.ToString();
        }

        public override string ToString()
        {
            var ret = string.Join("", SoundWord);
            if (SyllabicStress) ret = $"{PrimaryStress}{ret}";
            return ret;
        }

        public void AddMoraStress(int moraPosition)
        {
            MoraStresses.Add(moraPosition);
        }
    }
}
