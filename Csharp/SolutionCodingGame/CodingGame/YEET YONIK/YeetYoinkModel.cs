using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static NUnit.Framework.Constraints.Tolerance;

namespace CodingGame.YEET_YONIK
{
    public static class YeetYoinkModel
    {
        public static List<string> ProcessWishesOptimize(string allItems, List<string> wishlist)
        {
            // Remove all whitespace from the allItems string and split by comma
            string[] wishesArray = allItems.Replace(" ", "").Split(',');
            HashSet<string> wishesSet = new HashSet<string>(wishesArray);

            List<string> output = new List<string>();

            foreach (string wish in wishlist)
            {
                if (wishesSet.Contains(wish))
                {
                    output.Add("YOINK");
                }
                else
                {
                    output.Add("YEET");
                }
            }

            return output;
        }
        public static List<string> ProcessWhishes (string allitems, List<string> wishlist)
        {
            //convert Array string to string using join

           string[] wishes = allitems.Replace(" ","").Split(",");
            List<string> output = new List<string>();
            foreach (string wish in wishlist)
            {
                var exist = wishes.Where(i => i == wish).FirstOrDefault();

                if (exist == null)
                {
                    output.Add("YEET");
                }
                else
                {
                    output.Add("YOINK");
                }

            }

            return output;
        }
    }

  
}
