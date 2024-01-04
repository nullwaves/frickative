namespace frickative
{
    public enum Place
    {
        Bilabial,
        Labiodental,
        Linguolabial,
        Dental,
        Alveolar,
        Postalveolar,
        Retroflex,
        Palatal,
        Velar,
        Uvular,
        Pharyngeal,
        Glottal
    }

    public enum Manner
    {
        Nasal,
        Plosive,
        SibilantFricative,
        NonSibilantFricative,
        Approximant,
        TapFlap,
        Trill,
        LateralFricative,
        LateralApproximant,
        LateralTapFlap,
        Stop,
        Fricative,
        Tenuis,
        Voiced,
        TenuisLateral,
        VoicedLateral,
        NasalLateral,
        Voiceless,
        SibilantAffricate,
        NonSibilantAffricate,
        LateralAffricate,
        Central
    }

    public enum ConsonantType
    {
        Pulmonic,
        NonPulmonic,
        CoArticulated,
        Other
    }

    public abstract class IPALetter
    {
        public string Symbol { get; set; }

        public virtual string DisplayString 
        {
            get
            {
                return Symbol;
            }
        }

        public override string ToString()
        {
            return Symbol;
        }
    }

    public class Vowel : IPALetter
    {
        public enum TongueHeight
        {
            Close,
            NearClose,
            CloseMid,
            Mid,
            OpenMid,
            NearOpen,
            Open
        }

        public enum TongueTip
        {
            Front,
            Central,
            Back
        }

        public static readonly List<Vowel> All = [];
        public TongueHeight Position { get; set; }
        public TongueTip PositionTip { get; set; }
        public bool Rounded { get; set; }
        public override string DisplayString => $"{Symbol} - {Position} {PositionTip} {(Rounded ? "R" : "Unr")}ounded Vowel";

        public Vowel(string symbol, TongueHeight position, TongueTip tipPosition, bool round)
        {
            Symbol = symbol;
            Position = position;
            PositionTip = tipPosition;
            Rounded = round;
            All.Add(this);
        }

        // Fronts
        public static readonly Vowel i = new("i", TongueHeight.Close, TongueTip.Front, false);
        public static readonly Vowel y = new("y", TongueHeight.Close, TongueTip.Front, true);
        public static readonly Vowel ɪ = new("ɪ", TongueHeight.NearClose, TongueTip.Front, false);
        public static readonly Vowel ʏ = new("ʏ", TongueHeight.NearClose, TongueTip.Front, true);
        public static readonly Vowel e = new("e", TongueHeight.CloseMid, TongueTip.Front, false);
        public static readonly Vowel ø = new("ø", TongueHeight.CloseMid, TongueTip.Front, true);
        public static readonly Vowel e̞ = new("e̞", TongueHeight.Mid, TongueTip.Front, false);
        public static readonly Vowel ø̞ = new("ø̞", TongueHeight.Mid, TongueTip.Front, true);
        public static readonly Vowel ɛ = new("ɛ", TongueHeight.OpenMid, TongueTip.Front, false);
        public static readonly Vowel œ = new("œ", TongueHeight.OpenMid, TongueTip.Front, true);
        public static readonly Vowel æ = new("æ", TongueHeight.NearOpen, TongueTip.Front, false);
        public static readonly Vowel a = new("a", TongueHeight.Open, TongueTip.Front, false);
        public static readonly Vowel ɶ = new("ɶ", TongueHeight.Open, TongueTip.Front, true);

        // Centrals
        public static readonly Vowel ɨ = new("ɨ", TongueHeight.Close, TongueTip.Central, false);
        public static readonly Vowel ʉ = new("ʉ", TongueHeight.Close, TongueTip.Central, true);
        public static readonly Vowel ɘ = new("ɘ", TongueHeight.CloseMid, TongueTip.Central, false);
        public static readonly Vowel ɵ = new("ɵ", TongueHeight.CloseMid, TongueTip.Central, true);
        public static readonly Vowel ə = new("ə", TongueHeight.Mid, TongueTip.Central, false);
        public static readonly Vowel ɜ = new("ɜ", TongueHeight.OpenMid, TongueTip.Central, false);
        public static readonly Vowel ɞ = new("ɞ", TongueHeight.OpenMid, TongueTip.Central, true);
        public static readonly Vowel ɐ = new("ɐ", TongueHeight.NearOpen, TongueTip.Central, false);
        public static readonly Vowel ä = new("ä", TongueHeight.Open, TongueTip.Central, false);

        // Backs
        public static readonly Vowel ɯ = new("ɯ", TongueHeight.Close, TongueTip.Back, false);
        public static readonly Vowel u = new("u", TongueHeight.Close, TongueTip.Back, true);
        public static readonly Vowel ʊ = new("ʊ", TongueHeight.NearClose, TongueTip.Back, false);
        public static readonly Vowel ɤ = new("ɤ", TongueHeight.CloseMid, TongueTip.Back, false);
        public static readonly Vowel o = new("o", TongueHeight.CloseMid, TongueTip.Back, true);
        public static readonly Vowel ɤ̞ = new("ɤ̞", TongueHeight.Mid, TongueTip.Back, false);
        public static readonly Vowel o̞ = new("o̞", TongueHeight.Mid, TongueTip.Back, true);
        public static readonly Vowel ʌ = new("ʌ", TongueHeight.OpenMid, TongueTip.Back, false);
        public static readonly Vowel ɔ = new("ɔ", TongueHeight.OpenMid, TongueTip.Back, true);
        public static readonly Vowel ɑ = new("ɑ", TongueHeight.Open, TongueTip.Back, false);
        public static readonly Vowel ɒ = new("ɒ", TongueHeight.Open, TongueTip.Back, true);
    }

    public class Consonant : IPALetter
    {
        public static readonly List<Consonant> All = [];
        public Place Place { get; set; }
        public Manner Manner { get; set; }
        public bool Voiced { get; set; }
        public ConsonantType SoundType { get; set; }
        public override string DisplayString => $"{Symbol} - Voice{(Voiced ? "ed" : "less")} {Place} {Manner}";

        public Consonant(string symbol, Place place, Manner manner, bool voiced, ConsonantType ltype = ConsonantType.Pulmonic)
        {
            Symbol = symbol;
            Place = place;
            Manner = manner;
            Voiced = voiced;
            SoundType = ltype;
            All.Add(this);
        }

        #region Pulmonic Consonants

        // Nasals
        public static readonly Consonant m̥ = new("m̥", Place.Bilabial, Manner.Nasal, false);
        public static readonly Consonant m = new("m", Place.Bilabial, Manner.Nasal, true);
        public static readonly Consonant ɱ̊ = new("ɱ̊", Place.Labiodental, Manner.Nasal, false);
        public static readonly Consonant ɱ = new("ɱ", Place.Labiodental, Manner.Nasal, true);
        public static readonly Consonant n̼ = new("n̼", Place.Linguolabial, Manner.Nasal, true);
        public static readonly Consonant n̥ = new("n̥", Place.Alveolar, Manner.Nasal, false);
        public static readonly Consonant n = new("n", Place.Alveolar, Manner.Nasal, true);
        public static readonly Consonant ɳ̊ = new("ɳ̊", Place.Retroflex, Manner.Nasal, false);
        public static readonly Consonant ɳ = new("ɳ", Place.Retroflex, Manner.Nasal, true);
        public static readonly Consonant ɲ̊ = new("ɲ̊", Place.Palatal, Manner.Nasal, false);
        public static readonly Consonant ɲ = new("ɲ", Place.Palatal, Manner.Nasal, true);
        public static readonly Consonant ŋ̊ = new("ŋ̊", Place.Velar, Manner.Nasal, false);
        public static readonly Consonant ŋ = new("ŋ", Place.Velar, Manner.Nasal, true);
        public static readonly Consonant ɴ̥ = new("ɴ̥", Place.Uvular, Manner.Nasal, false);
        public static readonly Consonant ɴ = new("ɴ", Place.Uvular, Manner.Nasal, true);

        // Plosives
        public static readonly Consonant p = new("p", Place.Bilabial, Manner.Plosive, false);
        public static readonly Consonant b = new("b", Place.Bilabial, Manner.Plosive, true);
        public static readonly Consonant p̪ = new("p̪", Place.Labiodental, Manner.Plosive, false);
        public static readonly Consonant b̪ = new("b̪", Place.Labiodental, Manner.Plosive, true);
        public static readonly Consonant t̼ = new("t̼", Place.Linguolabial, Manner.Plosive, false);
        public static readonly Consonant d̼ = new("d̼", Place.Linguolabial, Manner.Plosive, true);
        public static readonly Consonant t = new("t", Place.Alveolar, Manner.Plosive, false);
        public static readonly Consonant d = new("d", Place.Alveolar, Manner.Plosive, true);
        public static readonly Consonant ʈ = new("ʈ", Place.Retroflex, Manner.Plosive, false);
        public static readonly Consonant ɖ = new("ɖ", Place.Retroflex, Manner.Plosive, true);
        public static readonly Consonant c = new("c", Place.Palatal, Manner.Plosive, false);
        public static readonly Consonant ɟ = new("ɟ", Place.Palatal, Manner.Plosive, true);
        public static readonly Consonant k = new("k", Place.Velar, Manner.Plosive, false);
        public static readonly Consonant ɡ = new("ɡ", Place.Velar, Manner.Plosive, true);
        public static readonly Consonant q = new("q", Place.Uvular, Manner.Plosive, false);
        public static readonly Consonant ɢ = new("ɢ", Place.Uvular, Manner.Plosive, true);
        public static readonly Consonant ʡ = new("ʡ", Place.Pharyngeal, Manner.Plosive, false);
        public static readonly Consonant ʔ = new("ʔ", Place.Glottal, Manner.Plosive, false);

        // Sibilant Affricates
        public static readonly Consonant ts = new("ts", Place.Alveolar, Manner.SibilantAffricate, false);
        public static readonly Consonant dz = new("dz", Place.Alveolar, Manner.SibilantAffricate, true);
        public static readonly Consonant t̠ʃ = new("t̠ʃ", Place.Postalveolar, Manner.SibilantAffricate, false);
        public static readonly Consonant d̠ʒ = new("d̠ʒ", Place.Postalveolar, Manner.SibilantAffricate, true);
        public static readonly Consonant tʂ = new("tʂ", Place.Retroflex, Manner.SibilantAffricate, false);
        public static readonly Consonant dʐ = new("dʐ", Place.Retroflex, Manner.SibilantAffricate, true);
        public static readonly Consonant tɕ = new("tɕ", Place.Palatal, Manner.SibilantAffricate, false);
        public static readonly Consonant dʑ = new("dʑ", Place.Palatal, Manner.SibilantAffricate, true);

        // Non-sibilant Affricates
        public static readonly Consonant pɸ = new("pɸ", Place.Bilabial, Manner.NonSibilantAffricate, false);
        public static readonly Consonant bβ = new("bβ", Place.Bilabial, Manner.NonSibilantAffricate, true);
        public static readonly Consonant p̪f = new("p̪f", Place.Labiodental, Manner.NonSibilantAffricate, false);
        public static readonly Consonant b̪v = new("b̪v", Place.Labiodental, Manner.NonSibilantAffricate, true);
        public static readonly Consonant t̪θ = new("t̪θ", Place.Dental, Manner.NonSibilantAffricate, false);
        public static readonly Consonant d̪ð = new("d̪ð", Place.Dental, Manner.NonSibilantAffricate, true);
        public static readonly Consonant tɹ̝̊ = new("tɹ̝̊", Place.Alveolar, Manner.NonSibilantAffricate, false);
        public static readonly Consonant dɹ̝ = new("dɹ̝", Place.Alveolar, Manner.NonSibilantAffricate, true);
        public static readonly Consonant t̠ɹ̠̊ = new ("tɹ̝̊", Place.Postalveolar, Manner.NonSibilantAffricate, false);
        public static readonly Consonant d̠ɹ̠ = new ("dɹ̝", Place.Postalveolar, Manner.NonSibilantAffricate, true);
        public static readonly Consonant cç = new("cç", Place.Palatal, Manner.NonSibilantAffricate, false);
        public static readonly Consonant ɟʝ = new("ɟʝ", Place.Palatal, Manner.NonSibilantAffricate, true);
        public static readonly Consonant kx = new("kx", Place.Velar, Manner.NonSibilantAffricate, false);
        public static readonly Consonant ɡɣ = new("ɡɣ", Place.Velar, Manner.NonSibilantAffricate, true);
        public static readonly Consonant qχ = new("qχ", Place.Uvular, Manner.NonSibilantAffricate, false);
        public static readonly Consonant ɢʁ = new("ɢʁ", Place.Uvular, Manner.NonSibilantAffricate, true);
        public static readonly Consonant ʡʜ = new("ʡʜ", Place.Pharyngeal, Manner.NonSibilantAffricate, false);
        public static readonly Consonant ʡʢ = new("ʡʢ", Place.Pharyngeal, Manner.NonSibilantAffricate, true);
        public static readonly Consonant ʔh = new("ʡʜ", Place.Glottal, Manner.NonSibilantAffricate, false);

        // Sibilant Fricatives
        public static readonly Consonant s = new("s", Place.Alveolar, Manner.SibilantFricative, false);
        public static readonly Consonant z = new("z", Place.Alveolar, Manner.SibilantFricative, true);
        public static readonly Consonant ʃ = new("ʃ", Place.Postalveolar, Manner.SibilantFricative, false);
        public static readonly Consonant ʒ = new("ʒ", Place.Postalveolar, Manner.SibilantFricative, true);
        public static readonly Consonant ʂ = new("ʂ", Place.Retroflex, Manner.SibilantFricative, false);
        public static readonly Consonant ʐ = new("ʐ", Place.Retroflex, Manner.SibilantFricative, true);
        public static readonly Consonant ɕ = new("ɕ", Place.Palatal, Manner.SibilantFricative, false);
        public static readonly Consonant ʑ = new("ʑ", Place.Palatal, Manner.SibilantFricative, true);

        // Non-sibilant Fricative
        public static readonly Consonant ɸ = new("ɸ", Place.Bilabial, Manner.NonSibilantFricative, false);
        public static readonly Consonant β = new("β", Place.Bilabial, Manner.NonSibilantFricative, true);
        public static readonly Consonant f = new("f", Place.Labiodental, Manner.NonSibilantFricative, false);
        public static readonly Consonant v = new("v", Place.Labiodental, Manner.NonSibilantFricative, true);
        public static readonly Consonant θ̼ = new("θ̼", Place.Linguolabial, Manner.NonSibilantFricative, false);
        public static readonly Consonant ð̼ = new("ð̼", Place.Linguolabial, Manner.NonSibilantFricative, true);
        public static readonly Consonant θ = new("θ", Place.Dental, Manner.NonSibilantFricative, false);
        public static readonly Consonant ð = new("ð", Place.Dental, Manner.NonSibilantFricative, true);
        public static readonly Consonant θ̠ = new("θ", Place.Alveolar, Manner.NonSibilantFricative, false);
        public static readonly Consonant ð̠ = new("ð", Place.Alveolar, Manner.NonSibilantFricative, true);
        public static readonly Consonant ɹ̠̊ = new ("ɹ̠̊˔", Place.Postalveolar, Manner.NonSibilantFricative, false);
        public static readonly Consonant ɹ̠  = new ("ɹ̠˔", Place.Postalveolar, Manner.NonSibilantFricative, true);
        public static readonly Consonant ɻ̊ = new ("ɻ̊˔", Place.Retroflex, Manner.NonSibilantFricative, false);
        public static readonly Consonant ɻn = new ("ɻ˔", Place.Retroflex, Manner.NonSibilantFricative, true);
        public static readonly Consonant ç = new("ç", Place.Palatal, Manner.NonSibilantFricative, false);
        public static readonly Consonant ʝ = new("ʝ", Place.Palatal, Manner.NonSibilantFricative, true);
        public static readonly Consonant x = new("x", Place.Velar, Manner.NonSibilantFricative, false);
        public static readonly Consonant ɣ = new("ɣ", Place.Velar, Manner.NonSibilantFricative, true);
        public static readonly Consonant χ = new("χ", Place.Uvular, Manner.NonSibilantFricative, false);
        public static readonly Consonant ʁ = new("ʁ", Place.Uvular, Manner.NonSibilantFricative, true);
        public static readonly Consonant ħ = new("ħ", Place.Pharyngeal, Manner.NonSibilantFricative, false);
        public static readonly Consonant ʕ = new("ʕ", Place.Pharyngeal, Manner.NonSibilantFricative, true);
        public static readonly Consonant h = new("h", Place.Glottal, Manner.NonSibilantFricative, false);
        public static readonly Consonant ɦ = new("ɦ", Place.Glottal, Manner.NonSibilantFricative, true);

        // Approximants
        public static readonly Consonant ʋ = new("ʋ", Place.Labiodental, Manner.Approximant, true);
        public static readonly Consonant ɹ = new("ɹ", Place.Alveolar, Manner.Approximant, true);
        public static readonly Consonant ɻ = new("ɻ", Place.Retroflex, Manner.Approximant, true);
        public static readonly Consonant j = new("j", Place.Palatal, Manner.Approximant, true);
        public static readonly Consonant ɰ = new("ɰ", Place.Velar, Manner.Approximant, true);
        public static readonly Consonant ʔ̞ = new("ʔ̞", Place.Glottal, Manner.Approximant, true);

        // Tap/Flaps
        public static readonly Consonant ⱱ̟ = new("ⱱ̟", Place.Bilabial, Manner.TapFlap, true);
        public static readonly Consonant ⱱ = new("ⱱ", Place.Labiodental, Manner.TapFlap, true);
        public static readonly Consonant ɾ̼ = new("ɾ̼", Place.Linguolabial, Manner.TapFlap, true);
        public static readonly Consonant ɾ̥ = new("ɾ̥", Place.Alveolar, Manner.TapFlap, false);
        public static readonly Consonant ɾ = new("ɾ", Place.Alveolar, Manner.TapFlap, true);
        public static readonly Consonant ɽ̊ = new("ɽ̊", Place.Retroflex, Manner.TapFlap, false);
        public static readonly Consonant ɽ = new("ɽ", Place.Retroflex, Manner.TapFlap, true);
        public static readonly Consonant ɢ̆ = new("ɢ̆", Place.Uvular, Manner.TapFlap, true);
        public static readonly Consonant ʡ̆ = new("ʡ̆", Place.Pharyngeal, Manner.TapFlap, true);

        // Trills
        public static readonly Consonant ʙ̥ = new("ʙ̥", Place.Bilabial, Manner.TapFlap, false);
        public static readonly Consonant ʙ = new("ʙ", Place.Bilabial, Manner.TapFlap, true);
        public static readonly Consonant r̥ = new("r̥", Place.Alveolar, Manner.TapFlap, false);
        public static readonly Consonant r = new("r", Place.Alveolar, Manner.TapFlap, true);
        public static readonly Consonant ɽ̊r̥ = new("ɽ̊r̥", Place.Retroflex, Manner.TapFlap, false);
        public static readonly Consonant ɽr = new("ɽr", Place.Retroflex, Manner.TapFlap, true);
        public static readonly Consonant ʀ̥ = new("ʀ̥", Place.Uvular, Manner.TapFlap, false);
        public static readonly Consonant ʀ = new("ʀ", Place.Uvular, Manner.TapFlap, true);
        public static readonly Consonant ʜ = new("ʜ", Place.Pharyngeal, Manner.TapFlap, false);
        public static readonly Consonant ʢ = new("ʢ", Place.Pharyngeal, Manner.TapFlap, true);

        // Lateral Affricates
        public static readonly Consonant tɬ = new("tɬ", Place.Alveolar, Manner.LateralAffricate, false);
        public static readonly Consonant dɮ = new("dɮ", Place.Alveolar, Manner.LateralAffricate, true);
        public static readonly Consonant tꞎ = new("tꞎ", Place.Retroflex, Manner.LateralAffricate, false);
        public static readonly Consonant drla = new ("d𝼅", Place.Retroflex, Manner.LateralAffricate, true);
        public static readonly Consonant cpla = new ("c𝼆", Place.Palatal, Manner.LateralAffricate, false);
        public static readonly Consonant ɟʎ̝ = new("ɟʎ̝", Place.Palatal, Manner.LateralAffricate, true);
        public static readonly Consonant kvla = new ("k𝼄", Place.Velar, Manner.LateralAffricate, false);
        public static readonly Consonant ɡʟ̝ = new("ɡʟ̝", Place.Velar, Manner.LateralAffricate, true);

        // Lateral Fricatives
        public static readonly Consonant ɬ = new("ɬ", Place.Alveolar, Manner.LateralFricative, false);
        public static readonly Consonant ɮ = new("ɮ", Place.Alveolar, Manner.LateralFricative, true);
        public static readonly Consonant ꞎ = new("ꞎ", Place.Retroflex, Manner.LateralFricative, false);
        public static readonly Consonant drlf = new ("𝼅", Place.Retroflex, Manner.LateralFricative, true);
        public static readonly Consonant cplf = new("𝼆", Place.Palatal, Manner.LateralFricative, false);
        public static readonly Consonant ʎ̝ = new("ʎ̝", Place.Palatal, Manner.LateralFricative, true);
        public static readonly Consonant kvlf = new ("𝼄", Place.Velar, Manner.LateralFricative, false);
        public static readonly Consonant ʟ̝ = new("ʟ̝", Place.Velar, Manner.LateralFricative, true);

        // Lateral Approximant
        public static readonly Consonant l = new("l", Place.Alveolar, Manner.LateralApproximant, true);
        public static readonly Consonant ɭ = new("ɭ", Place.Retroflex, Manner.LateralApproximant, true);
        public static readonly Consonant ʎ = new("ʎ", Place.Palatal, Manner.LateralApproximant, true);
        public static readonly Consonant ʟ = new("ʟ", Place.Velar, Manner.LateralApproximant, true);
        public static readonly Consonant ʟ̠ = new("ʟ̠", Place.Uvular, Manner.LateralApproximant, true);

        // Lateral Tap/Flaps
        public static readonly Consonant ɺ̥  = new("ɺ̥", Place.Alveolar, Manner.LateralTapFlap, false);
        public static readonly Consonant ɺ = new("ɺ", Place.Alveolar, Manner.LateralTapFlap, true);
        public static readonly Consonant vlrltf  = new ("𝼈̥", Place.Retroflex, Manner.LateralTapFlap, false);
        public static readonly Consonant vrltf = new ("𝼈", Place.Retroflex, Manner.LateralTapFlap, true);
        public static readonly Consonant ʎ̆ = new("ʎ̆", Place.Palatal, Manner.LateralTapFlap, true);
        public static readonly Consonant ʟ̆ = new("ʟ̆", Place.Velar, Manner.LateralTapFlap, true);

        #endregion

    }
}
