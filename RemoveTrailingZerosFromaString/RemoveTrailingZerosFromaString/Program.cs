using System;
using System.Collections.Generic;
using System.Numerics;

namespace RemoveTrailingZerosFromaString
{
    class Program
    {
        public static string RemoveTrailingZeros(string num)
        {
            BigInteger number = BigInteger.Parse(num);
            const int divisive = 10;
            bool status = true;

            while (status)
            {
                status = number % divisive == 0;
                if (status)
                {
                    number = number / divisive;
                }
            }

            return number.ToString();
        }
        static void Main(string[] args)
        {
            Console.WriteLine(RemoveTrailingZeros("1720865079269529096765717822459"));
        }
    }
}
