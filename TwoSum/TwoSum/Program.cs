using System;

namespace TwoSum
{
    class Program
    {
        //Question Url: https://leetcode.com/problems/two-sum/submissions/1180866746/
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;
                        return result;
                    }

                }
            }

            return null;
        }
        static void Main(string[] args)
        {
            int[] nums = { 3, 2, 3 };
            int target = 6;
            Console.WriteLine(TwoSum(nums,target));
        }
    }
}
