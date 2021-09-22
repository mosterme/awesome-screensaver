using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Unicode;
using System;
namespace awesomescr
{
    public class Unicode : Provider
    {
        public static String version = "Unicode v" + UnicodeInfo.UnicodeVersion.ToString(2);
        private static Random random = new Random();
        public Dictionary<string, UnicodeBlock> blocks = new Dictionary<string, UnicodeBlock>();
        public Unicode(HashSet<string> preset)
        {
            foreach (UnicodeBlock ub in UnicodeInfo.GetBlocks())
            {
                if (preset.Contains(ub.Name)) blocks.Add(ub.Name, ub);
            }
        }
        public string next()
        {
            int fallback = 0x1F499; UnicodeBlock current = blocks.ElementAt(random.Next(blocks.Count)).Value;
            while (fallback++ < 0x1F4A8)
            {
                int result = random.Next(current.CodePointRange.FirstCodePoint, current.CodePointRange.LastCodePoint + 1);
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
        public static HashSet<string> african_scripts = new HashSet<string>(){
            "Adlam",
            //"Bamum",
            //"Bamum Supplement",
            //"Bassa Vah",
            "Coptic",
            "Greek and Coptic",
            "Egyptian Hieroglyphs",
            "Ethiopic",
            "Ethiopic Extended",
            "Ethiopic Extended-A",
            "Ethiopic Supplement",
            //"Mende Kikakui",
            //"Meroitic Cursive",
            //"Meroitic Hieroglyphs",
            "NKo",
            "Osmanya",
            "Tifinagh",
            "Vai",
        };
        public static HashSet<string> american_scripts = new HashSet<string>(){
            "Cherokee",
            "Cherokee Supplement",
            "Deseret",
            "Osage",
            "Unified Canadian Aboriginal Syllabics",
            "Unified Canadian Aboriginal Syllabics Extended",

        };
        public static HashSet<string> emoji_pictographs = new HashSet<string>(){
            "Dingbats",
            "Emoticons",
            "Miscellaneous Symbols",
            "Miscellaneous Symbols and Pictographs",
            "Supplemental Symbols and Pictographs",
            //"Symbols and Pictographs Extended-A",
            "Transport and Map Symbols",
        };
        public static HashSet<string> mathematical_symbols = new HashSet<string>(){
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
        public static HashSet<string> other_symbols = new HashSet<string>(){
            "Alchemical Symbols",
            "Currency Symbols",
            "Domino Tiles",
            "Mahjong Tiles",
            "Playing Cards",
            "Miscellaneous Symbols and Arrows",
            "Yijing Hexagram Symbols",
        };
        private static HashSet<UnicodeCategory> categories = new HashSet<UnicodeCategory>(){
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