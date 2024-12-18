using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGame.StringCompression
{
    public static class StringCompression
    {
        public static string[] M1()
        {
            string[] tabstring = ["a", "b", "b", "b", "b", "b", "b", "b", "b", "b", "b", "b", "b"];

            StringBuilder st = new StringBuilder(tabstring.Length);
            List<string> list = new List<string>();

            for(int i = 0; i <tabstring.Length;i++)
            {
                int consecutive_occurence = 1;
                string currentelement = tabstring[i];
                while(i+1 < tabstring.Length && tabstring[i] == tabstring[i+1])
                {
                    consecutive_occurence++;
                    i++;
                }
                string nb_occ = consecutive_occurence.ToString();
                list.Add(currentelement);
                foreach (var item in nb_occ)
                    {
                    list.Add(item.ToString());

                    }
                              
               
            }
            return list.ToArray();
        }
    }
}
