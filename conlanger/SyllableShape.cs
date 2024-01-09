using System.Text.RegularExpressions;

namespace conlanger
{
    public class SyllableShape
    {
        public int Onset { get; set; }
        public int Coda { get; set; }

        public static bool TryParse(string input, out SyllableShape retVal)
        {
            retVal = new() { Coda = -1, Onset = -1 };
            if (!SyllableValidation.RegexPattern().IsMatch(input))
            {
                return false;
            }
            var sParts = input.Split('v');
            retVal = new SyllableShape()
            {
                Onset = sParts[0].Length,
                Coda = sParts[1].Length
            };
            return true;
        }
    }

    public partial class SyllableValidation()
    {
        [GeneratedRegex("^c*v{1}c*$")]
        public static partial Regex RegexPattern();
    }
}
