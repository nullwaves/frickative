namespace conlanger
{
    public class Syllable : IComparable<Syllable>
    {
        public List<IPALetter> SoundWord { get; set; }

        public void Add(IPALetter letter) => SoundWord.Add(letter);
        public void AddRange(IEnumerable<IPALetter> letters) => SoundWord.AddRange(letters);

        public Syllable()
        {
            SoundWord = [];
        }

        public int CompareTo(Syllable? other)
        {
            if (other is null) return 1;
            return ToString().CompareTo(other.ToString());
        }

        public override string ToString()
        {
            return string.Join("", SoundWord);
        }
    }
}
