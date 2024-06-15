using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGame.Merge_Strings_Alternately
{
    public static class MergeStringCsharp
    {

        [Test]
        public static void TestMergeAlternately()
        {

            string output = string.Empty;
            output = MergeStringCsharp.MergeAlternately2("abc", "pqr");
            Assert.That(output.Equals("apbqcr"));

            output = MergeStringCsharp.MergeAlternately2("ab", "pqrs");
            Assert.That(output.Equals("apbqrs"));

            output = MergeStringCsharp.MergeAlternately2("abcd", "pq");
            Assert.That(output.Equals("apbqcd"));
        }
        public static string MergeAlternately(string word1, string word2)
        {
            char[] arrayword1 = word1.ToCharArray();
            char[] arrayword2 = word2.ToCharArray();
            char[] arraywordshortest = [];
            char[] arraywordlongest = [];   
            if(arrayword1.Length >= arrayword2.Length)
            {
                arraywordlongest = arrayword1;
                arraywordshortest = arrayword2;
            }
            else
            {
                arraywordlongest = arrayword2;
                arraywordshortest = arrayword1;
            }

            string output = string.Empty;

            for (int i = 0; i < arraywordshortest.Length; i++)
            {
                output += $"{arrayword1[i]}{arrayword2[i]}";
            }
            for (int i = arraywordshortest.Length; i < arraywordlongest.Length ; i++)
            
            {
                output += arraywordlongest[i];
            }
            return output;

        }


        public static string MergeAlternately2(string word1, string word2)
        {
            int len1 = word1.Length;
            int len2 = word2.Length;
            int minLength = Math.Min(len1, len2);

            StringBuilder output = new StringBuilder(len1 + len2);

            for (int i = 0; i < minLength; i++)
            {
                output.Append(word1[i]);
                output.Append(word2[i]);
            }

            if (len1 > len2)
            {
                output.Append(word1.Substring(minLength));
            }
            else
            {
                output.Append(word2.Substring(minLength));
            }

            return output.ToString();
        }




    }
}
