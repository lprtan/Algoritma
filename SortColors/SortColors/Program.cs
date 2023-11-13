using System;

namespace SortColors
{
    class Program
    {
        // Question link: https://leetcode.com/problems/sort-colors/description/
        public static void SortColors(int[] nums)
        {
            Array.Sort(nums);
            foreach (int item in nums)
            {
                Console.Write(item);
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 2, 0, 2, 1, 1, 0 };
            SortColors(arr);
        }
    }
}
