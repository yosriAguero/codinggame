using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGame
{
    public static class MaxProfit
    {
        public static void M1()
        {
            int[] prices = [7, 1, 5, 3, 6, 4];
            int minprice = prices[0];
            int profit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                
                if (minprice > prices[i] )
                {
                    minprice = prices[i];
                }

                if(profit < prices[i] - minprice )
                {
                    profit = prices[i] - minprice;
                }
            }

        }
    }
}
