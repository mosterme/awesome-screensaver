using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Unicode;
using System;
namespace awesomescr
{
    public class Unicode : Provider
    {
        public static readonly string version = "Unicode v" + UnicodeInfo.UnicodeVersion.ToString(2);
        private Dictionary<string, UnicodeBlock> blocks = new Dictionary<string, UnicodeBlock>();
        public Unicode(HashSet<string> preset)
        {
            foreach (UnicodeBlock ub in UnicodeInfo.GetBlocks())
            {
                if (preset.Contains(ub.Name)) blocks.Add(ub.Name, ub);
            }
        }
        public string next()
        {
            int fallback = 0x1F499; UnicodeBlock current = blocks.ElementAt(Screensaver.random.Next(blocks.Count)).Value;
            while (fallback++ < 0x1F4A8)
            {
                int result = Screensaver.random.Next(current.CodePointRange.FirstCodePoint, current.CodePointRange.LastCodePoint + 1);
                if (categories.Contains(UnicodeInfo.GetCharInfo(result).Category)) return Char.ConvertFromUtf32(result);
            }
            return Char.ConvertFromUtf32(fallback);
        }
        public string info(string key)
        {
            int i = Char.ConvertToUtf32(key, 0);
            UnicodeCharInfo u = UnicodeInfo.GetCharInfo(i);
            return version + " : " + u.Block + " : " + u.Category + " : " + u.Name; // +  " : " + u.CodePoint.ToString("X4");
        }
        public static readonly HashSet<string> african_scripts = new HashSet<string>(){
            "Adlam",
            //"Bamum",
            //"Bamum Supplement",
            //"Bassa Vah",
            "Coptic",
            //"Coptic Epact Numbers",
            "Greek and Coptic",
            "Egyptian Hieroglyphs",
            "Ethiopic",
            "Ethiopic Extended",
            "Ethiopic Extended-A",
            //"Ethiopic Extended-B",
            "Ethiopic Supplement",
            //"Medefaidrin",
            //"Mende Kikakui",
            //"Meroitic Cursive",
            //"Meroitic Hieroglyphs",
            "NKo",
            "Osmanya",
            "Tifinagh",
            "Vai",
        };
        public static readonly HashSet<string> american_scripts = new HashSet<string>(){
            "Cherokee",
            "Cherokee Supplement",
            "Deseret",
            "Osage",
            "Unified Canadian Aboriginal Syllabics",
            "Unified Canadian Aboriginal Syllabics Extended",
        };
        public static readonly HashSet<string> central_asian_scripts = new HashSet<string>(){
            //"Manichaean",
            //"Marchen",
            "Mongolian",
            //"Mongolian Supplement",
            //"Old Sogdian",
            "Old Turkic",
            "Phags-pa",
            //"Sogdian",
            //"Soyombo",
            "Tibetan",
            //"Zanabazar Square",
        };
        public static readonly HashSet<string> east_asian_scripts = new HashSet<string>(){
            "Bopomofo",
            //"Bopomofo Extended",
            "CJK Compatibility",
            //"CJK Compatibility Forms",
            "CJK Compatibility Ideographs",
            //"CJK Compatibility Ideographs Supplement",
            "CJK Radicals Supplement",
            //"CJK Strokes",
            "CJK Symbols and Punctuation",
            "CJK Unified Ideographs",
            "CJK Unified Ideographs Extension A",
            "CJK Unified Ideographs Extension B",
            "CJK Unified Ideographs Extension C",
            "CJK Unified Ideographs Extension D",
            //"CJK Unified Ideographs Extension E",
            //"Halfwidth and Fullwidth Forms",
            "Hangul Jamo",
            "Hangul Compatibility Jamo",
            "Hangul Jamo Extended-A",
            "Hangul Jamo Extended-B",
            "Hangul Syllables",
            //"Hanunoo",
            "Hiragana",
            //"Ideographic Description Characters",
            //"Ideographic Symbols and Punctuation",
            //"Kana Supplement",
            "Kanbun",
            "Katakana",
            "Katakana Phonetic Extensions",
            "Lisu",
            //"Miao",
            //"Tangut",
            //"Tangut Components",
            "Yi Radicals",
            "Yi Syllables",
        };
        public static readonly HashSet<string> emoji_pictographs = new HashSet<string>(){
            "Dingbats",
            "Emoticons",
            "Miscellaneous Symbols",
            "Miscellaneous Symbols and Pictographs",
            "Supplemental Symbols and Pictographs",
            //"Symbols and Pictographs Extended-A",
            "Transport and Map Symbols",
        };
        public static readonly HashSet<string> indonesia_oceania_scripts = new HashSet<string>(){
            //"Balinese",
            //"Batak",
            "Buginese",
            //"Buhid",
            //"Hanunoo",
            "Javanese",
            //"Makasar",
            //"Rejang",
            //"Sundanese",
            //"Sundanese Supplement",
            //"Tagalog",
            //"Tagbanwa",
        };
        public static readonly HashSet<string> mathematical_symbols = new HashSet<string>(){
            "Arrows",
            "Supplemental Arrows-A",
            "Supplemental Arrows-B",
            "Supplemental Arrows-C",
            "Miscellaneous Symbols and Arrows",
            "Letterlike Symbols",
            "Mathematical Alphanumeric Symbols",
            "Mathematical Operators",
            "Supplemental Mathematical Operators",
            "Miscellaneous Mathematical Symbols-A",
            "Miscellaneous Mathematical Symbols-B",
            "Block Elements",
            "Box Drawing",
            "Geometric Shapes",
            "Geometric Shapes Extended",
        };
        public static readonly HashSet<string> middle_eastern_scripts = new HashSet<string>(){
            //"Arabic Extended-A",
            "Arabic Presentation Forms-B",
            "Arabic Supplement",
            "Arabic",
            "Hebrew",
            "Imperial Aramaic",
            "Inscriptional Pahlavi",
            "Inscriptional Parthian",
            "Old South Arabian",
            "Syriac",
            //"Anatolian Hieroglyphs",
            //"Arabic Extended-B",
            //"Arabic Presentation Forms-A",
            //"Avestan",
            //"Chorasmian",
            //"Cuneiform Numbers and Punctuation",
            //"Cuneiform",
            //"Early Dynastic Cuneiform",
            //"Elymaic",
            //"Hatran",
            //"Mandaic",
            //"Nabataean",
            //"Old North Arabian",
            //"Old Persian",
            //"Palmyrene",
            //"Psalter Pahlavi",
            //"Samaritan",
            //"Ugaritic",
            //"Yezidi",
        };
        public static readonly HashSet<string> other_symbols = new HashSet<string>(){
            "Alchemical Symbols",
            "Currency Symbols",
            "Domino Tiles",
            "Mahjong Tiles",
            "Playing Cards",
            "Miscellaneous Symbols and Arrows",
            "Yijing Hexagram Symbols",
        };
        public static readonly HashSet<string> southeast_asian_scripts = new HashSet<string>(){
            //"Cham",
            //"Hanifi Rohingya",
            //"Kayah Li",
            "Khmer",
            "Khmer Symbols",
            "Lao",
            "Myanmar",
            "Myanmar Extended-A",
            "Myanmar Extended-B",
            "New Tai Lue",
            //"Nyiakeng Puachue Hmong",
            //"Pahawh Hmong",
            //"Pau Cin Hau",
            "Tai Le",
            //"Tai Tham",
            //"Tai Viet",
            //"Tangsa",
            "Thai",
        };
        public static readonly HashSet<string> south_asian_scripts = new HashSet<string>(){
            //"Ahom",
            "Bengali",
            //"Bhaiksuki",
            "Brahmi",
            //"Chakma",
            "Devanagari",
            "Devanagari Extended",
            //"Dives Akuru",
            //"Dogra",
            //"Grantha",
            "Gujarati",
            //"Gunjala Gondi",
            "Gurmukhi",
            //"Kaithi",
            "Kannada",
            "Kharoshthi",
            //"Khojki",
            //"Khudawadi",
            //"Lepcha",
            //"Limbu",
            //"Mahajani",
            "Malayalam",
            //"Masaram Gondi",
            //"Meetei Mayek",
            //"Meetei Mayek Extensions",
            //"Modi",
            //"Mro",
            //"Multani",
            //"Nandinagari",
            //"Newa",
            "Ol Chiki",
            "Oriya",
            //"Saurashtra",
            //"Sharada",
            //"Siddham",
            "Sinhala",
            "Sinhala Archaic Numbers",
            "Sora Sompeng",
            //"Syloti Nagri",
            //"Takri",
            "Tamil",
            //"Tamil Supplement",
            "Telugu",
            "Thaana",
            //"Tirhuta",
            //"Toto",
            //"Vedic Extensions",
            //"Wancho",
        };
        private static readonly HashSet<UnicodeCategory> categories = new HashSet<UnicodeCategory>(){
            //UnicodeCategory.Control,
            //UnicodeCategory.LineSeparator,
            //UnicodeCategory.ModifierSymbol,
            //UnicodeCategory.NonSpacingMark,
            //UnicodeCategory.OtherNotAssigned,
            //UnicodeCategory.ParagraphSeparator,
            //UnicodeCategory.PrivateUse,
            //UnicodeCategory.SpaceSeparator,
            //UnicodeCategory.SpacingCombiningMark,
            //UnicodeCategory.Surrogate,
            UnicodeCategory.ClosePunctuation,
            UnicodeCategory.ConnectorPunctuation,
            UnicodeCategory.CurrencySymbol,
            UnicodeCategory.DashPunctuation,
            UnicodeCategory.DecimalDigitNumber,
            UnicodeCategory.EnclosingMark,
            UnicodeCategory.FinalQuotePunctuation,
            UnicodeCategory.Format,
            UnicodeCategory.InitialQuotePunctuation,
            UnicodeCategory.LetterNumber,
            UnicodeCategory.LowercaseLetter,
            UnicodeCategory.MathSymbol,
            UnicodeCategory.ModifierLetter,
            UnicodeCategory.OpenPunctuation,
            UnicodeCategory.OtherLetter,
            UnicodeCategory.OtherNumber,
            UnicodeCategory.OtherPunctuation,
            UnicodeCategory.OtherSymbol,
            UnicodeCategory.TitlecaseLetter,
            UnicodeCategory.UppercaseLetter,
        };
    }
}