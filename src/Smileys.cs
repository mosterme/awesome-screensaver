using System.Collections.Generic;
using System.Linq;
using System;
namespace awesomescr
{
    class Smileys : Provider
    {
        public static readonly string version = "Smileys v1.5";
        private Dictionary<string, string> data;
        public Smileys(Dictionary<string, string> preset)
        {
            this.data = new Dictionary<string, string>(preset);
        }
        public string next()
        {
            return data.ElementAt(Screensaver.random.Next(data.Count)).Key;
        }
        public string info(string key)
        {
            return version + " : " + data[key];
        }
        public static readonly Dictionary<string, string> classic = new Dictionary<string, string>() {
            {":-)","classic : smiling happy face / don't take me too seriously"},
            {";-)","classic : winking happy face / something said tongue-in-cheek"},
            {":-(","classic : disappointed / sad"},
            {";-(","classic : crying / sad"},
            {":-?","classic : pipe smoking"},
            {":-\"","classic : whistling"},
            {":-|","classic : disgusted / no expression"},
            {":-D","classic : wide happy face / Mistrel singers"},
            {":-O","classic : Oh, nooooooo! / Uh oh!"},
            {":-P","classic : tongue stuck out"},
            {":-V","classic : shouting"},
            {":-v","classic : speaking"},
            {":) ","classic : Cheshire cat"},
            {":*)","classic : clown / drunk"},
            {":^)","classic : pointy nose"},
            {":~)","classic : broken nose"},
            {"?-(","classic : sad face with a black eye"},
            {"(_8(I)","classic : Homer Simpson"},
            {"(-:","classic : Australian / left-handed"},
            {"*<|:-)","classic : Santa Claus (Ho Ho Ho)"},
            {"%-)","classic : confused but happy"},
            {"%-^","classic : Picasso"},
            {"+:-)","classic : priest"},
            {"<°(((><x","classic : fish"},
            {"=:-)","classic : punk rocker"},
            {"|-)","classic : Lt. LaForge"},
            {"7:^]","classic : Ronald Reagan"},
            {"8-)","classic : smiling face with a wide-eyed look"},
            {"B-)","classic : smiling face with horn-rimmed glasses"},
            {"d:-)","classic : baseball cap"},
            {"q:-)","classic : baseball cap backwards"},
            {"-","classic : "},
        };
        public static readonly Dictionary<string, string> mini = new Dictionary<string, string>() {
            {":)","mini : smiling face"},
            {";)","mini : winking face"},
            {";(","mini : crying face"},
            {":(","mini : frowning face"},
            {":/","mini : disappointment"},
            {":|","mini : neutral face"},
            {":D","mini : grinning face"},
            {":O","mini : shocked face"},
            {":P","mini : tongue stuck out"},
            {"</3","mini : broken heart"},
            {"<3","mini : heart"},
            {"=(","mini : big frown"},
            {"=)","mini : big smile"},
            {"-","mini : "},
        };
        public static readonly Dictionary<string, string> kaomoji = new Dictionary<string, string>() {
            {"( ¬‿¬)", "kaomoji : happy / He he he"},
            {"( ͠❛ ͜ʖ͠❛ )", "kaomoji : "},
            {"( ͡° ͜ʖ ͡°)","kaomoji : Le Lenny"},
            {"($_$)","kaomoji : greedy"},
            {"(*_*)","kaomoji : in love"},
            {"(-.-)Zzz...","kaomoji : sleeping"},
            {"(-_-)","kaomoji : secret smile"},
            {"(=_=)","kaomoji : sleepy"},
            {"(>_<)","kaomoji : furious / hurt"},
            {"(@ @)","kaomoji : You're kidding!"},
            {"(@_@)","kaomoji : stunned"},
            {"(^_^)","kaomoji : smile"},
            {"(^o^)","kaomoji : singing"},
            {"(g_g)","kaomoji : sleepy"},
            {"(o_o)","kaomoji : shocked"},
            {"(u_u)","kaomoji : sleeping"},
            {"(x_x)","kaomoji : dead"},
            {"(⌐■_■)", "kaomoji : sun glasses / cool"},
            {"(◔◡◔)", "kaomoji : "},
            {"(ㆆ_ㆆ)", "kaomoji : "},
            {"+_+","kaomoji : (?)"},
            {"-,-","kaomoji : sleepy"},
            {"-.-","kaomoji : sleepy"},
            {"-_-","kaomoji : "},
            {";;", "kaomoji : sadness"},
            {";_;","kaomoji : crying"},
            {"T_T","kaomoji : crying / sadness"},
            {"\\ ^_^ /","kaomoji : joyful"},
            {"^^", "kaomoji : happiness"},
            {"^_^","kaomoji : basic smilie"},
            {"o_O","kaomoji : "},
            {"o_o","kaomoji : (?)"},
            {"x_X","kaomoji : dead / stressed"},
            {"x_x","kaomoji : dead / stressed"},
            {"{{(>_<)}}","kaomoji : cold"},
            {"~\\ (^o^) /~/~","kaomoji : octopus"},
            {"~_~","kaomoji : (?)"},
            {"¯\\_(ツ)_/¯","kaomoji : shrug"},
            {"ʕծ‸ ծʔ","kaomoji : sad bear"},
            {"ʕಠᴥಠʔ","kaomoji : angry bear"},
            {"ʕ•́ᴥ•̀ʔ","kaomoji : bear"},
            {"ʕ•́ᴥ•̀ʔっ", "kaomoji : pointing bear"},
            {"ಠ_ಠ","kaomoji : disapproval / disbelief"},
            {"≧◉ᴥ◉≦","kaomoji : cat"},
            {"◕‿◕", "kaomoji : "},
            {"♪♫*•♪", "kaomoji : ♪♫•♪"},
        };
    }
}