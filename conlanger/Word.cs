namespace conlanger
{
    public class Word : IComparable<Word>
    {
        public List<Syllable> Syllables { get; set; }

        public Syllable this[int index]
        {
            get { return Syllables[index]; }
            set { Syllables[index] = value; }
        }
        public int Count => Syllables.Count;
        public void Add(Syllable value) => Syllables.Add(value);

        public Word()
        {
            Syllables = [];
        }

        public override string ToString()
        {
            return $"/{string.Join(".", Syllables)}/";
        }

        public int CompareTo(Word? other)
        {
            if (other is null) return 1 ;
            return ToString().CompareTo(other.ToString());
        }
    }
}
