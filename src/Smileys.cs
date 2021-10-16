using System.Collections.Generic;
using System.Linq;
using System;
namespace awesomescr
{
    class Smileys : Provider
    {
        public static readonly string version = "Smileys v1.7";
        private Dictionary<string,string> data;
        public Smileys(Dictionary<string,string> preset)
        {
            this.data = new Dictionary<string,string>(preset);
        }
        public string next()
        {
            return data.ElementAt(Screensaver.random.Next(data.Count)).Key;
        }
        public string info(string key)
        {
            return version + " : " + data[key];
        }
        public static readonly Dictionary<string,string> classic = new Dictionary<string,string>() {
            {":-)","classic : smiling happy face / don't take me too seriously"},
            {";-)","classic : winking happy face / something said tongue-in-cheek"},
            {":-(","classic : disappointed / sad"},
            {";-(","classic : crying / sad"},
            {":^X^C","classic : Emacs user"},
            {":wq", "classic : vi user"},
            {"C:\\>","classic : MS-DOS user"},
            // {"-:-(","classic : Mr. T doesn't smile"},
            // {"-:-)","classic : Mr. T"},
            {"!-(","classic : black eye"},
            {"#-)","classic : partied all night"},
            {"$-)","classic : yuppie"},
            {"%*)","classic : very drunk"},
            {"%-(","classic : confused"},
            {"%-)","classic : confused but happy"},
            {"%-\\","classic : hungover"},
            {"%-^","classic : Picasso"},
            {"%-|","classic : been working all night"},
            {"(-:","classic : Australian / left-handed"},
            {"(:)-)","classic : scuba diver"},
            {"(:-H","classic : football player"},
            {"([(","classic : Robocop"},
            {"(_8(I)","classic : Homer Simpson"},
            {"***:-)","classic : Marge Simpson"},
            {"*<|:-)","classic : Santa Claus (Ho Ho Ho)"},
            {"+-(:-)","classic : The Pope"},
            {"+:-)","classic : priest"},
            {"+<:-)","classic : Peace be upon you, my children..."},
            {"+<||-)","classic : knight"},
            {"-=#:-)","classic : wizard"},
            {".-(","classic : should have worn safety glasses"},
            {"3:*>","classic : Rudolph the red-nosed reindeer"},
            {"4:-)","classic : George Washington"},
            {"5:-)","classic : Elvis Presley"},
            {"7:-)","classic : Fred Flintstone"},
            {"7:^]","classic : Ronald Reagan"},
            {"8-)","classic : smiling face with a wide-eyed look"},
            {":) ","classic : Cheshire cat"},
            {":*)","classic : clown / drunk"},
            {":-*","classic : ate something sour"},
            {":---)","classic : Pinnochio"},
            {":-/","classic : skeptical"},
            {":->","classic : sarcastic"},
            {":-?","classic : pipe smoking"},
            {":-@","classic : screaming"},
            {":-@%$#","classic : swearing"},
            {":-C","classic : really bummed out"},
            {":-D","classic : wide happy face / Mistrel singers"},
            {":-I","classic : indifferent / Hmmm"},
            {":-O","classic : Oh,nooooooo! / Uh oh!"},
            {":-P","classic : tongue stuck out"},
            {":-Q","classic : smoking"},
            {":-V","classic : shouting"},
            {":-X","classic : big wet kiss / lips are sealed"},
            {":-\"","classic : whistling"},
            {":-\\","classic : undecided"},
            {":-`","classic : spitting out chewing tobacco"},
            {":-c","classic : bummed out"},
            {":-e","classic : disappointed"},
            {":-p","classic : bleahhh (sticking tongue out)"},
            {":-t","classic : pouting"},
            {":-v","classic : speaking"},
            {":-x","classic : kiss kiss / my lips are sealed"},
            {":-{","classic : Count Dracula"},
            {":-{)","classic : mustache"},
            {":-{}","classic : wears heavy lipstick"},
            {":-|","classic : disgusted / no expression"},
            {":^)","classic : pointy nose"},
            {":_)","classic : boxer"},
            {":~)","classic : broken nose"},
            {":~/","classic : really mixed up"},
            {";-\\","classic : Popeye"},
            {";-p","classic : Popeye"},
            {"<+|:-)","classic : The Pope"},
            {"<:-(","classic : dunce"},
            {"<:-)","classic : dumb question"},
            {"=):-)","classic : Uncle Sam"},
            {"=:-(","classic : real punks never smile"},
            {"=:-)","classic : punk rocker"},
            {"=|:-)","classic : Abe Lincoln"},
            {"?-(","classic : sad face with a black eye"},
            {"@-)","classic : Cyclops"},
            {"@:-)","classic : wearing a turban"},
            {"B-)","classic : smiling face with horn-rimmed glasses"},
            {"C8<]","classic : Darth Vader"},
            {"C:#","classic : football player"},
            {"C=:-)","classic : chef"},
            {"D-)","classic : scuba diver"},
            {"G-(","classic : scuba diver with a broken mask"},
            {"H-)","classic : Geordie LaForge"},
            {"L:-)","classic : just graduated"},
            {"M-)","classic : see no evil"},
            {"O :-)","classic : Angel"},
            {"O-)","classic : Cyclops"},
            {"O:-)","classic : Angel"},
            {"P-(","classic : pirate"},
            {"P-)","classic : pirate"},
            {"Q:-)","classic : new graduate"},
            {"R-(","classic : broken glasses"},
            {"R-)","classic : broken glasses"},
            {"X-(","classic : just died"},
            {"\\:-)","classic : French hat"},
            {"]B-)","classic : Batman"},
            {"_:^)","classic : Native American"},
            {"d:-)","classic : baseball cap"},
            {"oO:)&&","classic : grandmother"},
            {"q:-)","classic : baseball cap backwards"},
            {"r:-)","classic : wearing ponytail"},
            {"y:-)","classic : bad toupee"},
            {"|-)","classic : Geordie LaForge"},
            {"|-P","classic : yuk"},
            {"}:-(","classic : Toupee in an updraft"},

            {":@","mini : what?"},
            {":)","mini : smiling face"},
            {";)","mini : winking face"},
            {";(","mini : crying face"},
            {":(","mini : frowning face"},
            {":/","mini : disappointment"},
            {":|","mini : neutral face"},
            {":D","mini : grinning face"},
            {":O","mini : shocked face"},
            {":P","mini : tongue stuck out"},
            {"=(","mini : big frown"},
            {"=)","mini : big smile"},

            {"pp#","animals : cow"},
            {"pq'#'","animals : bull"},
            {"<°(((><x","animals :  : fish"},
            {">-^);>","animals : fish"},

            {"@>+-+--","other : a rose"},
            {"@}->--","other : a rose"},
            {"</3","other : broken heart"},
            {"<3","other : heart"},
        };
        public static readonly Dictionary<string,string> kaomoji = new Dictionary<string,string>() {
            {"(-_-)","kaomoji : secret smile"},
            {"(-,-)","kaomoji : sleepy"},
            {"(-.-)","kaomoji : sleepy"},
            {"(-.-) zzZ","kaomoji : sleeping"},
            {"(@_@)","kaomoji : stunned"},
            {"(*_*)","kaomoji : in love"},
            {"(^_^)","kaomoji : smile"},
            {"(^o^)","kaomoji : singing"},
            {"(+_+)","kaomoji : stressed"},
            {"(=_=)","kaomoji : sleepy"},
            {"(>_<)","kaomoji : painful"},
            {"(~_~)","kaomoji : "},
            {"(♥_♥)","kaomoji : in love"},
            {"($_$)","kaomoji : greedy"},
            {"(g_g)","kaomoji : sleepy"},
            {"(ò_ó)","kaomoji : furious"},
            {"(o_o)","kaomoji : shocked"},
            {"(O_O)","kaomoji : shocked"},
            {"(u_u)","kaomoji : sleeping"},
            {"(x_x)","kaomoji : dead"},
            {"(⌐■_■)","kaomoji : be cool"},
            {"(ㆆ_ㆆ)","kaomoji : unamused"},
            {"[•.•ิ]","kaomoji : huh?!"},
            {"o_O","kaomoji : huh?!"},
            {"x_X","kaomoji : stressed"},
            {"ಠ_ಠ","kaomoji : disapproval"},
            {"ಠ_ರೃ","kaomoji : monocle"},
            {"ಥ_ಥ","kaomoji : crying"},
            {"¯\\_(ツ)_/¯","kaomoji : shrug"},
            {"˙ ͜ʟ˙","kaomoji : content"},
            {"|̲̅̅●̲̅̅|̲̅̅=̲̅̅|̲̅̅●̲̅̅|","kaomoji : boom box"},
            {"♪♫•♪","kaomoji : ♪♫•♪"},
            {"⫷ °⧭° ⫸","kaomoji : clown"},
            // flowergirl
            {"(◐‿◑)","kaomoji : flowergirl : crazy"},
            {"(◔◡◔)","kaomoji : flowergirl : happy"},
            // {"◔̯◔","kaomoji : rolling eyes"},
            // bears
            {"ᶘ ⊙ᴥ⊙ᶅ","kaomoji : bear"},
            {"ᶘ ᵒᴥᵒᶅ","kaomoji : bear"},
            {"ᶘಠᴥಠᶅ","kaomoji : bear"},
            {"ʕ •ᴥ•ʔ","kaomoji : koala"},
            {"ʕ•́ᴥ•̀ʔ","kaomoji : bear"},
            {"ʕ•͡ᴥ•ʔ","kaomoji : polar bear"},
            {"ʕ•́ᴥ•̀ʔっ","kaomoji : pointing bear"},
            {"ʕ´•ᴥ•`ʔ","kaomoji : shocked bear"},
            {"ʕ♡ᴥ♡ʔ","kaomoji : bear in love"},
            {"ʕծ‸ ծʔ","kaomoji : sad bear"},
            {"ʕಠᴥಠʔ","kaomoji : angry bear"},
            // circle and square kaomoji // TODO - check label font!
            // {" ∵⃝","kaomoji : circle : "},
            // {" ⍤⃝","kaomoji : circle : "},
            // {"⍩⃝","kaomoji : circle : "},
            // {"⍨⃝","kaomoji : circle : "},
            // {" ⍤⃝<꒳ᵒ꒳","kaomoji : circle : "},
            // {"⍥⃝ ♬","kaomoji : circle : "},
            // {"＼ ∵⃝／","kaomoji : circle : "},
            // {"ヽ ⍤⃝ノ","kaomoji : circle : "},
            // {"⍩⃝⃜","kaomoji : circle : "},
            // {"─=≡Σᕕ(∵⃝ ᕗ","kaomoji : circle : "},
            // {"三三ᕕ ⍨⃝ ᕗ","kaomoji : circle : "},
            // {" ⍤⃞","kaomoji : square : "},
            // {"⍥⃞","kaomoji : square : "},
            // {"⍩⃞","kaomoji : square : "},
            // {"⍢⃞","kaomoji : square : "},
            // {"⍨⃞","kaomoji : square : "},
            // animals
            {"❀ஐ〰","kaomoji : animal : butterfly"},
            {"Ƹ̵̡Ӝ̵̨̄Ʒ","kaomoji : animal : butterfly"},
            {"≧◉ᴥ◉≦","kaomoji : animal : cat"},
            {"V●ᴥ●V","kaomoji : animal : dog"},
            {"ᘛ⁐̤ᕐᐷ","kaomoji : animal : mouse"},
            {"(ᵔᴥᵔ)","kaomoji : animal : seal"},
            {"<コ:彡","kaomoji : animal : squid"},
            {"Ｃ:彡","kaomoji : animal : octopus"},
            {"~\\ (^o^) /~/~","kaomoji : animal : octopus"},
            // Lenny faces
            {"( ͡° ͜ʖ ͡°)","kaomoji : Le Lenny"},
            {"( ° ͜ʖ °)","kaomoji : Lenny"},
            {"( ͠° ͟ʖ ͠°)","kaomoji : Lenny"},
            {"( ͡° ʖ̯ ͡°)","kaomoji : Lenny"},
            {"( ͡~ ͜ʖ ͡°)","kaomoji : Lenny"},
            {"( ͡◉ ͜ʖ ͡◉)","kaomoji : Lenny"},
            {"( ͡☉ ͜ʖ ͡☉)","kaomoji : Lenny"},
            {"( ͡o ͜ʖ ͡o)","kaomoji : Lenny"},
            {"( ͡ᵔ ͜ʖ ͡ᵔ )","kaomoji : Lenny"},
            {"( ͝סּ ͜ʖ͡סּ)","kaomoji : Lenny"},
            {"ʕ ͡° ʖ̯ ͡°ʔ","kaomoji : Lenny"},
            {"ʕ ͡° ͜ʖ ͡°ʔ","kaomoji : Lenny"},
        };
    }
}