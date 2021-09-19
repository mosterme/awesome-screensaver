using System.Collections.Generic;
using System.Linq;
using System;
namespace awesomescr
{
    class Smileys
    {
        private static Random random = new Random();
        public static string version = "Smileys v1.1";
        public static string next() {
            return data.ElementAt(random.Next(data.Count)).Key;
        }
        public static string info(string key) {
            return version + " : " + data[key];
        }
        private static Dictionary<string, string> data = new Dictionary<string, string>() {
            {":-)","classic : smiling happy face / don't take me too seriously"},
            {";-)","classic : winking happy face / something said tongue-in-cheek"},
            {":-(","classic : sad or disappointed face"},
            {";-(","classic : crying sad face"},
            {"8-)","classic : smiling face with a wide-eyed look"},
            {"B-)","classic : smiling face with horn-rimmed glasses"},
            {"%-)","classic : confused smiling happy face"},
            {"?-(","classic : sad face with a black eye"},
            {":^)","classic : smiling happy face with pointy nose"},
            {":*)","classic : drunk smiling face / clowning around"},
            {":-D","classic : wide happy face / Mistrel singers"},
            {":-O","classic : shouting or talkaktive face / Uh oh!"},
            {":-P","classic : tongue stuck out"},
            {":-|","classic : stone face / no expression"},
 
            {":)","mini : smiling face / Cheshire cat"},
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
 
            {"^^", "kaomoji : "}, 
            {"^_^","kaomoji : "}, 
            {"-_-","kaomoji : "},
            {"o_O","kaomoji : "},
            {"T_T","kaomoji : crying / sadness"},
            {"x_x","kaomoji : stressed"},
            {"ಠ_ಠ","kaomoji : disapproval / disbelief"},
            {"ʕ•́ᴥ•̀ʔ","kaomoji : bear"},
            {"≧◉ᴥ◉≦","kaomoji : cat"},
            {"¯\\_(ツ)_/¯","kaomoji : shrug"},
        };
    }
}