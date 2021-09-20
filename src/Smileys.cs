using System.Collections.Generic;
using System.Linq;
using System;
namespace awesomescr
{
    class Smileys : Provider
    {
        public static string version = "Smileys v1.3";
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
            {":)" ,"classic : Cheshire cat"},
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
            {"x_x","kaomoji : stressed"},
            {"ಠ_ಠ","kaomoji : disapproval / disbelief"},
            {"ʕ•́ᴥ•̀ʔ","kaomoji : bear"},
            {"≧◉ᴥ◉≦","kaomoji : cat"},
            {"¯\\_(ツ)_/¯","kaomoji : shrug"},
        };
    }
}