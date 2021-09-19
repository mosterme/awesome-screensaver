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

            {":-D","classic : wider happy face / Mistrel singers"},
            {":-O","classic : shouting or talkaktive face / Uh oh!"},
            {":-P","classic : tongue stuck out"},
            {":-|","classic : stone face / no expression"},
 
            {":)","mini : smiling face / Cheshire cat"},
            {";)","mini : winking face"},
            {"=)","mini : big smile"},
            {":(","mini : frowning face"},
            {";(","mini : crying face"},
            {"=(","mini : big frown"},
 
            {"o_O",""},
            {"ಠ_ಠ",""},
            {"ʕ•́ᴥ•̀ʔ",""},
            {"≧◉ᴥ◉≦",""},
            {"¯\\_(ツ)_/¯",""},
        };
    }
}