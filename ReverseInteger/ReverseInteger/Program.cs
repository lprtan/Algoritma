using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseInteger
{
    // Soru Link: https://leetcode.com/problems/reverse-integer/description/
    class Program
    {
        public static int Reverse(int x)
        {
            string num = x.ToString();
            string result = "";
            List<string> list = num.Select(c => c.ToString()).ToList();

            if (x < 0)
            {
                list.Reverse();
                list.RemoveAt(list.Count - 1);
                if (x % 10 == 0)
                {
                    list.RemoveAt(0);
                    result = "-"+String.Join("", list);
                    if (int.TryParse(result, out int parsedResult))
                    {
                        return parsedResult;
                    }
                }
                result = "-" + String.Join("", list);
                if (int.TryParse(result, out int parsedResult2))
                {
                    return parsedResult2;
                }
            }
            else if (x >= 0)
            {
                list.Reverse();
                if (x % 10 == 0 && x!=0)
                {
                    list.RemoveAt(0);
                    result = String.Join("", list);
                    if (int.TryParse(result, out int parsedResult3))
                    {
                        return parsedResult3;
                    }
                }
                result = String.Join("", list);
                if (int.TryParse(result, out int parsedResult4))
                {
                    return parsedResult4;
                }
            }

            return 0;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse(0));
        }
    }
}
