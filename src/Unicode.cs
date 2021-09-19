using System.Collections.Generic;
using System.Globalization;
using System.Unicode;
using System;
namespace awesomescr
{
    public class Unicode : Provider
    {
        private static Random random = new Random();
        public static String version = "Unicode v" + UnicodeInfo.UnicodeVersion.ToString(2);
        private static UnicodeBlock[] blocks = UnicodeInfo.GetBlocks();
        public string next() {
            int fallback = 0x1F499, current = random.Next(blocks.Length);
            while (fallback++ < 0x1F4A8)
            {
                int result = random.Next(blocks[current].CodePointRange.FirstCodePoint, blocks[current].CodePointRange.LastCodePoint + 1);
                if (categories.Contains(UnicodeInfo.GetCharInfo(result).Category)) return Char.ConvertFromUtf32(result);
            }
            return Char.ConvertFromUtf32(fallback);
        }
        public string info(string key) {
            int i = Char.ConvertToUtf32(key,0);
            UnicodeCharInfo u = UnicodeInfo.GetCharInfo(i);
            return version + " : " + u.Block + " : " + u.Category + " : " + u.Name; // +  " : " + u.CodePoint.ToString("X4");
        }
        private static HashSet<UnicodeCategory> categories = new HashSet<UnicodeCategory>() {
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