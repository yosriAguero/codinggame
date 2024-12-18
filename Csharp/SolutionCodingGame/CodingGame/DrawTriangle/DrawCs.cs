using System;

class StarPattern
{
    static void Display()
    {
        // Read the integer n
        int n = int.Parse(Console.ReadLine());

        // Print the inverted triangle
        for (int i = n; i > 0; i--)
        {
            Console.WriteLine(new string('*', i));
        }

        // Print the upright triangle
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(new string('*', i));
        }
    }
}
