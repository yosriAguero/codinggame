using System;

public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int n = nums.Length;
        int[] answer = new int[n];

        // Step 1: Calculate prefix products
        answer[0] = 1; // No elements to the left of the first element
        for (int i = 1; i < n; i++)
        {
            answer[i] = answer[i - 1] * nums[i - 1];
        }

        // Step 2: Calculate suffix products and multiply with prefix products
        int suffixProduct = 1; // No elements to the right of the last element
        for (int i = n - 1; i >= 0; i--)
        {
            answer[i] *= suffixProduct;
            suffixProduct *= nums[i];
        }

        return answer;
    }
}

// Example usage
class Program
{
    static void Main()
    {
        Solution solution = new Solution();

        int[] nums1 = { 1, 2, 3, 4 };
        int[] result1 = solution.ProductExceptSelf(nums1);
        Console.WriteLine(string.Join(", ", result1)); // Output: 24, 12, 8, 6

        int[] nums2 = { -1, 1, 0, -3, 3 };
        int[] result2 = solution.ProductExceptSelf(nums2);
        Console.WriteLine(string.Join(", ", result2)); // Output: 0, 0, 9, 0, 0
    }
}
