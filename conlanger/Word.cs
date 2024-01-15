using System.Text;

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

        public void AddMoraStress(int moraPosition, Moraism moraism)
        {
            if (moraPosition < 0 || moraPosition > CountMora(moraism) - 1)
                throw new ArgumentOutOfRangeException(nameof(moraPosition));
            var localPos = moraPosition;
            int sylPos = 0;
            while (Syllables[sylPos].CountMora(moraism) <= localPos)
            {
                localPos -= Syllables[sylPos].CountMora(moraism);
                sylPos++;
            }
            Syllables[sylPos].AddMoraStress(localPos);
        }

        public int CountMora(Moraism moraism)
        {
            int c = 0;
            foreach (var item in Syllables)
            {
                c += item.CountMora(moraism);
            }
            return c;
        }

        public string Format(Moraism moraism)
        {
            var sb = new StringBuilder();
            sb.Append("[");
            foreach (var item in Syllables)
                sb.Append(item.Format(moraism) + ".");
            sb.Remove(sb.Length - 1, 1);
            sb.Append("]");
            return sb.ToString();
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
