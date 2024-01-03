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

    public enum LetterType
    {
        PulmonicConsonant,
        NonPulmonicConsonant,
        CoArticulatedConsonant,
        OtherConsonant,
        Vowel
    }

    public class PhoneticLetter
    {
        public static readonly List<PhoneticLetter> All = [];
        public string Symbol { get; set; }
        public Place Place { get; set; }
        public Manner Manner { get; set; }
        public bool Voiced { get; set; }
        public LetterType LetterType { get; set; }
        public string DisplayString 
        {
            get 
            {
                return $"{Symbol} - Voice{(Voiced ? "ed" : "less")} {Place} {Manner}"; 
            } 
        }

        public PhoneticLetter(string symbol, Place place, Manner manner, bool voiced, LetterType ltype = LetterType.PulmonicConsonant)
        {
            Symbol = symbol;
            Place = place;
            Manner = manner;
            Voiced = voiced;
            LetterType = ltype;
            All.Add(this);
        }

        public override string ToString()
        {
            return Symbol;
        }

        #region Pulmonic Consonants

        // Nasals
        public static readonly PhoneticLetter m̥ = new("m̥", Place.Bilabial, Manner.Nasal, false);
        public static readonly PhoneticLetter m = new("m", Place.Bilabial, Manner.Nasal, true);
        public static readonly PhoneticLetter ɱ̊ = new("ɱ̊", Place.Labiodental, Manner.Nasal, false);
        public static readonly PhoneticLetter ɱ = new("ɱ", Place.Labiodental, Manner.Nasal, true);
        public static readonly PhoneticLetter n̼ = new("n̼", Place.Linguolabial, Manner.Nasal, true);
        public static readonly PhoneticLetter n̥ = new("n̥", Place.Alveolar, Manner.Nasal, false);
        public static readonly PhoneticLetter n = new("n", Place.Alveolar, Manner.Nasal, true);
        public static readonly PhoneticLetter ɳ̊ = new("ɳ̊", Place.Retroflex, Manner.Nasal, false);
        public static readonly PhoneticLetter ɳ = new("ɳ", Place.Retroflex, Manner.Nasal, true);
        public static readonly PhoneticLetter ɲ̊ = new("ɲ̊", Place.Palatal, Manner.Nasal, false);
        public static readonly PhoneticLetter ɲ = new("ɲ", Place.Palatal, Manner.Nasal, true);
        public static readonly PhoneticLetter ŋ̊ = new("ŋ̊", Place.Velar, Manner.Nasal, false);
        public static readonly PhoneticLetter ŋ = new("ŋ", Place.Velar, Manner.Nasal, true);
        public static readonly PhoneticLetter ɴ̥ = new("ɴ̥", Place.Uvular, Manner.Nasal, false);
        public static readonly PhoneticLetter ɴ = new("ɴ", Place.Uvular, Manner.Nasal, true);

        // Plosives
        public static readonly PhoneticLetter p = new("p", Place.Bilabial, Manner.Plosive, false);
        public static readonly PhoneticLetter b = new("b", Place.Bilabial, Manner.Plosive, true);
        public static readonly PhoneticLetter p̪ = new("p̪", Place.Labiodental, Manner.Plosive, false);
        public static readonly PhoneticLetter b̪ = new("b̪", Place.Labiodental, Manner.Plosive, true);
        public static readonly PhoneticLetter t̼ = new("t̼", Place.Linguolabial, Manner.Plosive, false);
        public static readonly PhoneticLetter d̼ = new("d̼", Place.Linguolabial, Manner.Plosive, true);
        public static readonly PhoneticLetter t = new("t", Place.Alveolar, Manner.Plosive, false);
        public static readonly PhoneticLetter d = new("d", Place.Alveolar, Manner.Plosive, true);
        public static readonly PhoneticLetter ʈ = new("ʈ", Place.Retroflex, Manner.Plosive, false);
        public static readonly PhoneticLetter ɖ = new("ɖ", Place.Retroflex, Manner.Plosive, true);
        public static readonly PhoneticLetter c = new("c", Place.Palatal, Manner.Plosive, false);
        public static readonly PhoneticLetter ɟ = new("ɟ", Place.Palatal, Manner.Plosive, true);
        public static readonly PhoneticLetter k = new("k", Place.Velar, Manner.Plosive, false);
        public static readonly PhoneticLetter ɡ = new("ɡ", Place.Velar, Manner.Plosive, true);
        public static readonly PhoneticLetter q = new("q", Place.Uvular, Manner.Plosive, false);
        public static readonly PhoneticLetter ɢ = new("ɢ", Place.Uvular, Manner.Plosive, true);
        public static readonly PhoneticLetter ʡ = new("ʡ", Place.Pharyngeal, Manner.Plosive, false);
        public static readonly PhoneticLetter ʔ = new("ʔ", Place.Glottal, Manner.Plosive, false);

        // Sibilant Affricates
        public static readonly PhoneticLetter ts = new("ts", Place.Alveolar, Manner.SibilantAffricate, false);
        public static readonly PhoneticLetter dz = new("dz", Place.Alveolar, Manner.SibilantAffricate, true);
        public static readonly PhoneticLetter t̠ʃ = new("t̠ʃ", Place.Postalveolar, Manner.SibilantAffricate, false);
        public static readonly PhoneticLetter d̠ʒ = new("d̠ʒ", Place.Postalveolar, Manner.SibilantAffricate, true);
        public static readonly PhoneticLetter tʂ = new("tʂ", Place.Retroflex, Manner.SibilantAffricate, false);
        public static readonly PhoneticLetter dʐ = new("dʐ", Place.Retroflex, Manner.SibilantAffricate, true);
        public static readonly PhoneticLetter tɕ = new("tɕ", Place.Palatal, Manner.SibilantAffricate, false);
        public static readonly PhoneticLetter dʑ = new("dʑ", Place.Palatal, Manner.SibilantAffricate, true);

        // Non-sibilant Affricates
        public static readonly PhoneticLetter pɸ = new("pɸ", Place.Bilabial, Manner.NonSibilantAffricate, false);
        public static readonly PhoneticLetter bβ = new("bβ", Place.Bilabial, Manner.NonSibilantAffricate, true);
        public static readonly PhoneticLetter p̪f = new("p̪f", Place.Labiodental, Manner.NonSibilantAffricate, false);
        public static readonly PhoneticLetter b̪v = new("b̪v", Place.Labiodental, Manner.NonSibilantAffricate, true);
        public static readonly PhoneticLetter t̪θ = new("t̪θ", Place.Dental, Manner.NonSibilantAffricate, false);
        public static readonly PhoneticLetter d̪ð = new("d̪ð", Place.Dental, Manner.NonSibilantAffricate, true);
        public static readonly PhoneticLetter tɹ̝̊ = new("tɹ̝̊", Place.Alveolar, Manner.NonSibilantAffricate, false);
        public static readonly PhoneticLetter dɹ̝ = new("dɹ̝", Place.Alveolar, Manner.NonSibilantAffricate, true);
        public static readonly PhoneticLetter t̠ɹ̠̊ = new ("tɹ̝̊", Place.Postalveolar, Manner.NonSibilantAffricate, false);
        public static readonly PhoneticLetter d̠ɹ̠ = new ("dɹ̝", Place.Postalveolar, Manner.NonSibilantAffricate, true);
        public static readonly PhoneticLetter cç = new("cç", Place.Palatal, Manner.NonSibilantAffricate, false);
        public static readonly PhoneticLetter ɟʝ = new("ɟʝ", Place.Palatal, Manner.NonSibilantAffricate, true);
        public static readonly PhoneticLetter kx = new("kx", Place.Velar, Manner.NonSibilantAffricate, false);
        public static readonly PhoneticLetter ɡɣ = new("ɡɣ", Place.Velar, Manner.NonSibilantAffricate, true);
        public static readonly PhoneticLetter qχ = new("qχ", Place.Uvular, Manner.NonSibilantAffricate, false);
        public static readonly PhoneticLetter ɢʁ = new("ɢʁ", Place.Uvular, Manner.NonSibilantAffricate, true);
        public static readonly PhoneticLetter ʡʜ = new("ʡʜ", Place.Pharyngeal, Manner.NonSibilantAffricate, false);
        public static readonly PhoneticLetter ʡʢ = new("ʡʢ", Place.Pharyngeal, Manner.NonSibilantAffricate, true);
        public static readonly PhoneticLetter ʔh = new("ʡʜ", Place.Glottal, Manner.NonSibilantAffricate, false);

        // Sibilant Fricatives
        public static readonly PhoneticLetter s = new("s", Place.Alveolar, Manner.SibilantFricative, false);
        public static readonly PhoneticLetter z = new("z", Place.Alveolar, Manner.SibilantFricative, true);
        public static readonly PhoneticLetter ʃ = new("ʃ", Place.Postalveolar, Manner.SibilantFricative, false);
        public static readonly PhoneticLetter ʒ = new("ʒ", Place.Postalveolar, Manner.SibilantFricative, true);
        public static readonly PhoneticLetter ʂ = new("ʂ", Place.Retroflex, Manner.SibilantFricative, false);
        public static readonly PhoneticLetter ʐ = new("ʐ", Place.Retroflex, Manner.SibilantFricative, true);
        public static readonly PhoneticLetter ɕ = new("ɕ", Place.Palatal, Manner.SibilantFricative, false);
        public static readonly PhoneticLetter ʑ = new("ʑ", Place.Palatal, Manner.SibilantFricative, true);

        // Non-sibilant Fricative
        public static readonly PhoneticLetter ɸ = new("ɸ", Place.Bilabial, Manner.NonSibilantFricative, false);
        public static readonly PhoneticLetter β = new("β", Place.Bilabial, Manner.NonSibilantFricative, true);
        public static readonly PhoneticLetter f = new("f", Place.Labiodental, Manner.NonSibilantFricative, false);
        public static readonly PhoneticLetter v = new("v", Place.Labiodental, Manner.NonSibilantFricative, true);
        public static readonly PhoneticLetter θ̼ = new("θ̼", Place.Linguolabial, Manner.NonSibilantFricative, false);
        public static readonly PhoneticLetter ð̼ = new("ð̼", Place.Linguolabial, Manner.NonSibilantFricative, true);
        public static readonly PhoneticLetter θ = new("θ", Place.Dental, Manner.NonSibilantFricative, false);
        public static readonly PhoneticLetter ð = new("ð", Place.Dental, Manner.NonSibilantFricative, true);
        public static readonly PhoneticLetter θ̠ = new("θ", Place.Alveolar, Manner.NonSibilantFricative, false);
        public static readonly PhoneticLetter ð̠ = new("ð", Place.Alveolar, Manner.NonSibilantFricative, true);
        public static readonly PhoneticLetter ɹ̠̊ = new ("ɹ̠̊˔", Place.Postalveolar, Manner.NonSibilantFricative, false);
        public static readonly PhoneticLetter ɹ̠  = new ("ɹ̠˔", Place.Postalveolar, Manner.NonSibilantFricative, true);
        public static readonly PhoneticLetter ɻ̊ = new ("ɻ̊˔", Place.Retroflex, Manner.NonSibilantFricative, false);
        public static readonly PhoneticLetter ɻn = new ("ɻ˔", Place.Retroflex, Manner.NonSibilantFricative, true);
        public static readonly PhoneticLetter ç = new("ç", Place.Palatal, Manner.NonSibilantFricative, false);
        public static readonly PhoneticLetter ʝ = new("ʝ", Place.Palatal, Manner.NonSibilantFricative, true);
        public static readonly PhoneticLetter x = new("x", Place.Velar, Manner.NonSibilantFricative, false);
        public static readonly PhoneticLetter ɣ = new("ɣ", Place.Velar, Manner.NonSibilantFricative, true);
        public static readonly PhoneticLetter χ = new("χ", Place.Uvular, Manner.NonSibilantFricative, false);
        public static readonly PhoneticLetter ʁ = new("ʁ", Place.Uvular, Manner.NonSibilantFricative, true);
        public static readonly PhoneticLetter ħ = new("ħ", Place.Pharyngeal, Manner.NonSibilantFricative, false);
        public static readonly PhoneticLetter ʕ = new("ʕ", Place.Pharyngeal, Manner.NonSibilantFricative, true);
        public static readonly PhoneticLetter h = new("h", Place.Glottal, Manner.NonSibilantFricative, false);
        public static readonly PhoneticLetter ɦ = new("ɦ", Place.Glottal, Manner.NonSibilantFricative, true);

        // Approximants
        public static readonly PhoneticLetter ʋ = new("ʋ", Place.Labiodental, Manner.Approximant, true);
        public static readonly PhoneticLetter ɹ = new("ɹ", Place.Alveolar, Manner.Approximant, true);
        public static readonly PhoneticLetter ɻ = new("ɻ", Place.Retroflex, Manner.Approximant, true);
        public static readonly PhoneticLetter j = new("j", Place.Palatal, Manner.Approximant, true);
        public static readonly PhoneticLetter ɰ = new("ɰ", Place.Velar, Manner.Approximant, true);
        public static readonly PhoneticLetter ʔ̞ = new("ʔ̞", Place.Glottal, Manner.Approximant, true);

        // Tap/Flaps
        public static readonly PhoneticLetter ⱱ̟ = new("ⱱ̟", Place.Bilabial, Manner.TapFlap, true);
        public static readonly PhoneticLetter ⱱ = new("ⱱ", Place.Labiodental, Manner.TapFlap, true);
        public static readonly PhoneticLetter ɾ̼ = new("ɾ̼", Place.Linguolabial, Manner.TapFlap, true);
        public static readonly PhoneticLetter ɾ̥ = new("ɾ̥", Place.Alveolar, Manner.TapFlap, false);
        public static readonly PhoneticLetter ɾ = new("ɾ", Place.Alveolar, Manner.TapFlap, true);
        public static readonly PhoneticLetter ɽ̊ = new("ɽ̊", Place.Retroflex, Manner.TapFlap, false);
        public static readonly PhoneticLetter ɽ = new("ɽ", Place.Retroflex, Manner.TapFlap, true);
        public static readonly PhoneticLetter ɢ̆ = new("ɢ̆", Place.Uvular, Manner.TapFlap, true);
        public static readonly PhoneticLetter ʡ̆ = new("ʡ̆", Place.Pharyngeal, Manner.TapFlap, true);

        // Trills
        public static readonly PhoneticLetter ʙ̥ = new("ʙ̥", Place.Bilabial, Manner.TapFlap, false);
        public static readonly PhoneticLetter ʙ = new("ʙ", Place.Bilabial, Manner.TapFlap, true);
        public static readonly PhoneticLetter r̥ = new("r̥", Place.Alveolar, Manner.TapFlap, false);
        public static readonly PhoneticLetter r = new("r", Place.Alveolar, Manner.TapFlap, true);
        public static readonly PhoneticLetter ɽ̊r̥ = new("ɽ̊r̥", Place.Retroflex, Manner.TapFlap, false);
        public static readonly PhoneticLetter ɽr = new("ɽr", Place.Retroflex, Manner.TapFlap, true);
        public static readonly PhoneticLetter ʀ̥ = new("ʀ̥", Place.Uvular, Manner.TapFlap, false);
        public static readonly PhoneticLetter ʀ = new("ʀ", Place.Uvular, Manner.TapFlap, true);
        public static readonly PhoneticLetter ʜ = new("ʜ", Place.Pharyngeal, Manner.TapFlap, false);
        public static readonly PhoneticLetter ʢ = new("ʢ", Place.Pharyngeal, Manner.TapFlap, true);

        // Lateral Affricates
        public static readonly PhoneticLetter tɬ = new("tɬ", Place.Alveolar, Manner.LateralAffricate, false);
        public static readonly PhoneticLetter dɮ = new("dɮ", Place.Alveolar, Manner.LateralAffricate, true);
        public static readonly PhoneticLetter tꞎ = new("tꞎ", Place.Retroflex, Manner.LateralAffricate, false);
        public static readonly PhoneticLetter drla = new ("d𝼅", Place.Retroflex, Manner.LateralAffricate, true);
        public static readonly PhoneticLetter cpla = new ("c𝼆", Place.Palatal, Manner.LateralAffricate, false);
        public static readonly PhoneticLetter ɟʎ̝ = new("ɟʎ̝", Place.Palatal, Manner.LateralAffricate, true);
        public static readonly PhoneticLetter kvla = new ("k𝼄", Place.Velar, Manner.LateralAffricate, false);
        public static readonly PhoneticLetter ɡʟ̝ = new("ɡʟ̝", Place.Velar, Manner.LateralAffricate, true);

        // Lateral Fricatives
        public static readonly PhoneticLetter ɬ = new("ɬ", Place.Alveolar, Manner.LateralFricative, false);
        public static readonly PhoneticLetter ɮ = new("ɮ", Place.Alveolar, Manner.LateralFricative, true);
        public static readonly PhoneticLetter ꞎ = new("ꞎ", Place.Retroflex, Manner.LateralFricative, false);
        public static readonly PhoneticLetter drlf = new ("𝼅", Place.Retroflex, Manner.LateralFricative, true);
        public static readonly PhoneticLetter cplf = new("𝼆", Place.Palatal, Manner.LateralFricative, false);
        public static readonly PhoneticLetter ʎ̝ = new("ʎ̝", Place.Palatal, Manner.LateralFricative, true);
        public static readonly PhoneticLetter kvlf = new ("𝼄", Place.Velar, Manner.LateralFricative, false);
        public static readonly PhoneticLetter ʟ̝ = new("ʟ̝", Place.Velar, Manner.LateralFricative, true);

        // Lateral Approximant
        public static readonly PhoneticLetter l = new("l", Place.Alveolar, Manner.LateralApproximant, true);
        public static readonly PhoneticLetter ɭ = new("ɭ", Place.Retroflex, Manner.LateralApproximant, true);
        public static readonly PhoneticLetter ʎ = new("ʎ", Place.Palatal, Manner.LateralApproximant, true);
        public static readonly PhoneticLetter ʟ = new("ʟ", Place.Velar, Manner.LateralApproximant, true);
        public static readonly PhoneticLetter ʟ̠ = new("ʟ̠", Place.Uvular, Manner.LateralApproximant, true);

        // Lateral Tap/Flaps
        public static readonly PhoneticLetter ɺ̥  = new("ɺ̥", Place.Alveolar, Manner.LateralTapFlap, false);
        public static readonly PhoneticLetter ɺ = new("ɺ", Place.Alveolar, Manner.LateralTapFlap, true);
        public static readonly PhoneticLetter vlrltf  = new ("𝼈̥", Place.Retroflex, Manner.LateralTapFlap, false);
        public static readonly PhoneticLetter vrltf = new ("𝼈", Place.Retroflex, Manner.LateralTapFlap, true);
        public static readonly PhoneticLetter ʎ̆ = new("ʎ̆", Place.Palatal, Manner.LateralTapFlap, true);
        public static readonly PhoneticLetter ʟ̆ = new("ʟ̆", Place.Velar, Manner.LateralTapFlap, true);

        #endregion

    }
}
