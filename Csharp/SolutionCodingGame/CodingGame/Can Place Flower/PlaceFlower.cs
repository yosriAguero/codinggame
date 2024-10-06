using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGame.Can_Place_Flower
{
    public static class PlaceFlower
    {

      
            public static bool CanPlaceFlowersCopilot(int[] flowerbed, int n)
            {
                int count = 0;
            //int[] flowerbed = flowerbed = [1, 0, 0, 0, 1]; int n = 1;
            for (int i = 0; i < flowerbed.Length; i++)
                {
                    if (flowerbed[i] == 0)
                    {
                        bool emptyLeftPlot = (i == 0) || (flowerbed[i - 1] == 0);
                        bool emptyRightPlot = (i == flowerbed.Length - 1) || (flowerbed[i + 1] == 0);

                        if (emptyLeftPlot && emptyRightPlot)
                        {
                            flowerbed[i] = 1;
                            count++;
                            if (count >= n)
                            {
                                return true;
                            }
                        }
                    }
                }
                return count >= n;
            }
        








        public static bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int count = 0;  // Number of flowers we can plant
            int length = flowerbed.Length;

            for (int i = 0; i < length; i++)
            {
                // Check if the current plot is empty and the adjacent plots are also empty or non-existent
                if (flowerbed[i] == 0 &&
                    (i == 0 || flowerbed[i - 1] == 0) && //we can plant a flower if it's first
                    (i == length - 1 || flowerbed[i + 1] == 0)) // we can plant a flower if it's last
                {
                    // Plant a flower here
                    flowerbed[i] = 1;
                    count++;

                    // If we have planted enough flowers, return true
                    if (count >= n)
                    {
                        return true;
                    }
                }
            }

            // If we can't plant the required number of flowers, return false
            return count >= n;
        }
    }
}
