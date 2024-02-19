using System;

namespace LongestCommonPrefix
{
    class Program
    {
        //Question Url: https://leetcode.com/problems/longest-common-prefix/submissions/1179895328/
        public static string LongestCommonPrefix(string[] strs)
        {
            int m = 0;
            int count = 0;
            string result = "";
            while (m < strs[0].Length)
            {
                char x = strs[0][m];
                for (int j = 1; j < strs.Length; j++)
                {
                    if (m >= strs[j].Length || strs[j][m] != x)
                    {
                        return result;
                    }
                }
                result += x;
                m++;
            }


            return result;
        }

        static void Main(string[] args)
        {
            string[] strs = { "flower", "flow", "flight" };
            Console.WriteLine(LongestCommonPrefix(strs));
        }
    }
}
