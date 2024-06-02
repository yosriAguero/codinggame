using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGame
{
    /// <summary>
    /// 3,3,5 => 45
    /// 3+6+9+12+15
    /// </summary>
    public class SommeSuite
    {
        public static void NotOptimized()
        {
       
            int M = 3;
            int D = 3;
            int N = 5;
            int Sum = M;
            List<int> list = new List<int>();
            //  list.Add(Sum);
            // Write an answer using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");
            for (int i = 0; i < N; i++)
            {

                list.Add(Sum);
                Sum += D;
            }

            Console.WriteLine(list.Select(e => e).Sum());
        }

        public static void Optimize() {

            int M = 3;
            int D = 3;
            int N = 5;
            long sum = M; // Use long to handle large sums

            // Calculate sum without storing elements in a list
            for (int i = 1; i < N; i++)
            {
                sum += M + i * D; // Calculate the value instead of adding to list
            }

            Console.WriteLine(sum);
        }
    }
}
