using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGame
{
    public class MaxOccurences
    {
        public static void Optimized()
        {
            string str = "Hello World";
            if (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("No input provided.");
                return;
            }

            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (charCount.ContainsKey(c))
                    charCount[c]++;
                else
                    charCount[c] = 1;
            }

            KeyValuePair<char, int> mostFrequent = charCount.OrderByDescending(pair => pair.Value).First();

            Console.WriteLine($"{mostFrequent.Key} {mostFrequent.Value}");
        }

        public static void NotOptimized()
        {
            string str = "Hello World";
            str = str.Trim();
            char frequent = ' ';
            int max = 0;
            List<char> treated = new List<char>();

            foreach (var item in str)
            {
                if (treated.Contains(item))
                {
                    continue;
                }
                int count = str.Where(e => e == item).Count();
                if (count > max)
                {
                    frequent = item;
                    max = count;
                }
                treated.Add(item);
            }

            // Write an answer using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine(frequent + " " + max);
        }
    }
}
