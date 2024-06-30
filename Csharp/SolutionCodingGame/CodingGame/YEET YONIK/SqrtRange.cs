using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGame.YEET_YONIK
{
    public static class SqrtRange
    {
        public static void M1()
        {
            int A = 3;
            int B = 9;

            List<int> numbersquares = Enumerable.Range(A, B).Where(e => Math.Sqrt(e) % 1 < double.Epsilon).ToList();
            // Write an answer using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine(numbersquares.FirstOrDefault());

        
        int x = (int)Math.Ceiling(Math.Sqrt(A));

            // Find the last integer y such that y^2 <= B
            int y = (int)Math.Floor(Math.Sqrt(B));

            // Count the number of integers from x to y (inclusive)
            int count = Enumerable.Range(x, y - x + 1).Count();

            // Output the result
            Console.WriteLine(count);
        }
    }
}
