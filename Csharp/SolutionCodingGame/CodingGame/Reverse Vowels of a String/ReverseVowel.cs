using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodingGame.Reverse_Vowels_of_a_String
{
    public static class ReverseVowel
    {
        public static string ReverseVowelsJs()
        {
            string s = "leetcode";
            // Crée une expression régulière pour trouver toutes les voyelles dans la chaîne.
            Regex vowelsRegex = new Regex("[aeiouAEIOU]");

            // Inverse l'ordre des voyelles dans la chaîne.
            string reversedVowels = vowelsRegex.Replace(s, match => match.Value.ToUpper());

            // Retourne la chaîne résultante.
            return reversedVowels;
        }
        public static bool IsVowel(char c)
        {
            char[] vowels = new[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            return vowels.Any(ch => ch == c);
        }


        public static string ReverseVowelsOfString()
        {
            string s = "leetcode";
            Stack<char> vowels = new Stack<char>(s.Where(IsVowel));
            //e o e e
            StringBuilder sb = new StringBuilder();

            foreach (char c in s)
            {
                if (IsVowel(c))
                {
                    sb.Append(vowels.Pop());
                }
                else
                {
                    sb.Append(c);
                }
                //l
            }

            return sb.ToString();
        }















        //Input: s = "leetcode"
        //Output: "leotcede"

        public static void Reverse()
        {
            string s = "leetcode";
            List<char> allvowels = ['a', 'e', 'i', 'o'];
            List<int> indexvoyels = new List<int>(s.Length);
            List<char> voyels = new List<char>(s.Length);
            //e e o e
            //1 3 5 7
            for (int i = 0; i < s.Length; i++)
            {
                if (allvowels.Contains(s[i]))
                {
                    indexvoyels.Add(i);
                    voyels.Add(s[i]);
                }
            }
            for (int i = 0; i < s.Length; i++)
            {


            }
        }
    }
}
