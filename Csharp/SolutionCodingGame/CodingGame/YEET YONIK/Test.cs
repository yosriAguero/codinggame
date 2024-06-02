using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGame.YEET_YONIK
{
    public class M1()
    {
        [Test]
        public void TestM1()
        {
            string allitems = "Bread, Apple, Lemon, Cucumber, Chicken";

            List<string> wishlist = [
"Banana",
"Orange",
"Grapes",
"Lemon",
"Strawberries",
"Bread",
"Apple",
"Sock",
];
            List<string> output = [
"YEET",
"YEET",
"YEET",
"YOINK",
"YEET",
"YOINK",
"YOINK",
"YEET",
];
            List<string> results = YeetYoinkModel.ProcessWhishes(allitems, wishlist);

            List<string> result2 = YeetYoinkModel.ProcessWishesOptimize(allitems, wishlist);

           // List<string> result3 = YanikBarbech.ProcessWishesOptimize(allitems, wishlist);
            //Assert.That(output.SequenceEqual(result3));
            Assert.That(output.SequenceEqual(results));
            Assert.That(output.SequenceEqual(result2));
        }
    }
}
