using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CodingGame.DailyTemperature
{
    public class DailyTemperatureYosri
    {
        public static int[] Temperatures(int[] inputs)
        {

            //int[] inputs = { 73, 74, 75, 71, 69, 72, 76, 73 };
            int n = inputs.Length;
            //1,1,4,2,1,1,0,0 hedha s7i7
            int[] answer = new int[n];

            for (int i = 0; i < n; i++)
            {
                int j = i + 1;
                while (j < n)
                {
                    if (inputs[j] > inputs[i])
                    {

                        answer[i] = j - i;
                        j = n;

                    }
                    else
                    {
                        answer[i] = 0;
                        j++;
                    }

                }

            }
            Console.WriteLine(string.Join(",", answer));
            return answer;

        }
        public static int[] DailyTemperatures(int[] temperatures)
        {
            //int[] tabtemperatures = { 73, 74, 75, 71, 69, 72, 76, 73 };
            int n = temperatures.Length;
            int[] answer = new int[n];
            Stack<int> stack = new Stack<int>(); // Stack pour stocker les indices

            for (int i = 0; i < n; i++)
            {
                if(i==5)
                {

                }
                // Tant que la pile n'est pas vide et que la température actuelle est supérieure
                // à celle du jour précédent stocké dans la pile
                while (stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()])
                {
                    int prevIndex = stack.Pop(); // Retirer l'indice précédent
                    answer[prevIndex] = i - prevIndex; // Calculer la différence de jours
                }

                // Ajouter l'indice actuel dans la pile
                stack.Push(i);
            }

            // Les éléments restants dans la pile sont ceux pour lesquels il n'y a pas de jour plus chaud.
            // Par défaut, `answer` est déjà initialisé à 0 pour ces cas.

            return answer;
        }
    }
}
