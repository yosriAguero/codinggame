using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CodingGame.IncreaseDecrease
{
    public static class IncereaseDecrease
    {
        public static string Output(string input)
        {

            int[] inputArray = input.Split(' ').Select(x=> (int.Parse(x))).ToArray();
            string direction = inputArray[0] < inputArray[1] ? "Increasing" : "Decreasing";
            int difference = Math.Abs(inputArray[1] - inputArray[0]);
            int firstitem = direction == "Increasing" ? inputArray[0] - difference:
                inputArray[0] + difference;
            int lastitem = direction == "Increasing" ? inputArray[inputArray.Length -1] + difference :
           inputArray[inputArray.Length - 1] - difference;
            string output = $"{direction} {firstitem} {lastitem}";
            return output;
        }
    }
    public class TestClass
    {
     
        public TestClass()
        {
                
        }
        [Test]
        public void Test1()
        {
            string sequence = "2 3 4 5 6 7 8 9";
            string output = "Increasing 1 10";
            Assert.That(IncereaseDecrease.Output(sequence), Is.EqualTo(output));
        }
    }
    








}
