using System.Collections.Generic;
using System.Linq;
using System;
namespace awesomescr
{
    class Smileys : Provider
    {
        public static string version = "Smileys v1.4";
        private static Random random = new Random();
        private Dictionary<string, string> data;
        public Smileys(Dictionary<string, string> preset)
        {
            this.data = new Dictionary<string, string>(preset);
        }
        public string next()
        {
            return data.ElementAt(random.Next(data.Count)).Key;
        }
        public string info(string key)
        {
            return version + " : " + data[key];
        }
        public static Dictionary<string, string> classic = new Dictionary<string, string>() {
            {":-)","classic : smiling happy face / don't take me too seriously"},
            {";-)","classic : winking happy face / something said tongue-in-cheek"},
            {":-(","classic : disappointed / sad"},
            {";-(","classic : crying / sad"},
            {"8-)","classic : smiling face with a wide-eyed look"},
            {"B-)","classic : smiling face with horn-rimmed glasses"},
            {"%-)","classic : confused but happy"},
            {"?-(","classic : sad face with a black eye"},
            {":^)","classic : pointy nose"},
            {":*)","classic : clown / drunk"},
            {":-D","classic : wide happy face / Mistrel singers"},
            {":-O","classic : Oh, nooooooo! / Uh oh!"},
            {":-P","classic : tongue stuck out"},
            {":-|","classic : disgusted / no expression"},
            {":) ","classic : Cheshire cat"},
            {"7:^]","classic : Ronald Reagan"},
            {"*<|:-)","classic : Santa Claus (Ho Ho Ho)"},
            {"d:-)","classic : baseball cap"},
            {"q:-)","classic : baseball cap backwards"},
            {"(-:","classic : Australian / left-handed"},
            {"+:-)","classic : priest"},
            {"=:-)","classic : punk rocker"},
            {"%-^","classic : Picasso"},
            {":-\"","classic : whistling"},
            {":-v","classic : speaking"},
            {":-V","classic : shouting"},
            {"(_8(I)","classic : Homer Simpson"},
            {"<°(((><x","classic : fish"},
            {"|-)","classic : Lt. LaForge"},
            {":~)","classic : broken nose"},
            {":-?","classic : pipe smoking"},
            {"x","classic : "},
            {"y","classic : "},
            {"z","classic : "},
        };
        public static Dictionary<string, string> mini = new Dictionary<string, string>() {
            {":)","mini : smiling face"},
            {":(","mini : frowning face"},
            {":|","mini : neutral face"},
            {":/","mini : disappointment"},
            {":D","mini : grinning face"},
            {":O","mini : shocked face"},
            {":P","mini : tongue stuck out"},
            {";)","mini : winking face"},
            {";(","mini : crying face"},
            {"=)","mini : big smile"},
            {"=(","mini : big frown"},
            {"<3","mini : heart"},
            {"</3","mini : broken heart"},
        };
        public static Dictionary<string, string> kaomoji = new Dictionary<string, string>() {
            {"^^", "kaomoji : "},
            {"^_^","kaomoji : "},
            {"-_-","kaomoji : "},
            {"o_O","kaomoji : "},
            {"T_T","kaomoji : crying / sadness"},
            {"x_x","kaomoji : dead / stressed"},
            {"x_X","kaomoji : dead / stressed"},
            {"ಠ_ಠ","kaomoji : disapproval / disbelief"},
            {"ʕ•́ᴥ•̀ʔ","kaomoji : bear"},
            {"ʕಠᴥಠʔ","kaomoji : angry bear"},
            {"ʕծ‸ ծʔ","kaomoji : sad bear"},
            {"≧◉ᴥ◉≦","kaomoji : cat"},
            {"¯\\_(ツ)_/¯","kaomoji : shrug"},
            {"( ͡° ͜ʖ ͡°)","kaomoji : Le Lenny"},
            {"(@ @)","kaomoji : You're kidding!"},
            {"( ¬‿¬)", "kaomoji : happy / He he he"},
            {"(⌐■_■)", "kaomoji : sun glasses / cool"},
        };
    }
}