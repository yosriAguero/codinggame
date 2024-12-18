using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGame.Sum_Array_except_itself
{
    public static class ProductExcept
    {
        public static int[]  M1()
        {
            int[] nums = [5, 2, 3, 4];
            int[] result = new int[nums.Length];
            int initial = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = initial;
                initial *= nums[i];
            }
            initial = 1;
            for (int j = nums.Length - 1; j >= 0; j--)
            {
                result[j] = result[j] * initial;
                initial *= nums[j];
            }
            return result;
        }
    }
}
