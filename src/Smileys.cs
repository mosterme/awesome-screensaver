using System.Collections.Generic;
using System.Linq;
using System;
namespace awesomescr
{
    class Smileys
    {
        private static Random random = new Random();
        public static string randomSmiley() {
            return data.ElementAt(random.Next(data.Count)).Key;
        }
        private static Dictionary<string, string> data = new Dictionary<string, string>() {
            {":-)","Smiling happy face - don't take me too seriously."},
            {";-)","Winking happy face - something said tongue-in-cheek."},
            {":-(","Sad or disappointed face."},
            {";-(","Crying sad face."},

            {"8-)","Smiling face with a wide-eyed look."},
            {"B-)","Smiling face with horn-rimmed glasses."},
            {"%-)","Confused smiling happy face."},
            {"?-(","Sad face with a black eye."},

            {":^)","Smiling happy face with pointy nose."},
            {":*)","Drunk smiling face. Clowning around."},
            //{":-)",""},
            //{":-)",""},

            {":-D","Wider happy face (or Mistrel singers)"},
            {":-O","Shouting or talkaktive face. Uh oh."},
            {":-P","Tongue stuck out."},
            {":-|","Face with no expression - 'that comment doesn't phase me'"},
 
            {":)","Mini smiling face or Cheshire cat."},
            {";)","Mini winking face."},
            {"=)",""},
            {":(","Mini frowning face."},
            {";(","Mini crying face."},
            {"=(",""},
 
            {"o_O",""},
            {"ಠ_ಠ",""},
            {"ʕ•́ᴥ•̀ʔ",""},
            {"≧◉ᴥ◉≦",""},
            {"¯\\_(ツ)_/¯",""},
        };
    }
}