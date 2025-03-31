# frickative
 /fɹɪk/

## Sound Generation Settings

### Syllable Settings

- Shape 
    - Syllable shape in the format "CVC", where C represents a consonant and V represents a vowel. The smallest allowed shape is "V".
- Consonants 
    - All acceptable consonants that are allowed to appear in sounds.
- Vowels 
    - All acceptable vowels and diphthongs that are allowed to appear in sounds.
- Cluster Matrix 
    - Represents which manners of consonants can follow a given consonant's manner in a consonant cluster.
- Allow Crowding 
    - If false, prevent unvoiced consonants from following voiced consonants.

### Stress Settings

- Primary, Middle, and Ultimate Syllable Shapes 
    - Each shape type represents where in a sound-word a shape can appear. The following represents how they are used: 
        - 1 Syllable word: (Primary)
        - 2 Syllable word: (Primary).(Ultimate)
        - 3+ Syllable word: (Primary).(Middle)...(Ultimate)
- Foot Size 
    - Stress will either be applied on every second (Biambic) or third (Triambic) syllable/mora in a sound-word.
- Count By 
    - Stress in the language will be assigned based on either Syllabic grouping (/mim.im.bu/) or Moraic grouping (\[mi,m,i,m,bu\])
- Stress System 
    - Fixed stress always places on the same initial syllable position, while Phonemic is (programmatically) random.
- Moraism (Only applicable if Count By is Moraic) 
    - Maximum number of Morae a syllable can be split into based on vowel length and coda. 
        - Bimoraic: /nu:n/ -&gt; \[nu,un\]
        - Trimoraic /nu:n/ -&gt; \[nu,u,n\]
- Resultant Stress (only applicable if Foot Size is Triambic) 
    - If true, apply secondary stresses to sound-parts directly before or after a primary stress
- Resultant Stress Direction 
    - Primary, places a secondary stress on the syllable/mora before one with a primary stress, while Ultimate places one after the primary stress.

#### Fixed System Settings

- Stress Degree 
    - The syllable (1st, 2nd, 3rd) to put the initial stress on. 
        - Note: In a Biambic language, the 1st and 3rd options are essentially equivalent as a stress on the third sound-part would place a primary stress on the first (3-2) in the same way it would place a primary stress on the fifth sound-part.
- Stress Direction 
    - The direction to count syllables/morae. Primary starts at the beginning of the sound-word and Ultimate starts at the end.
