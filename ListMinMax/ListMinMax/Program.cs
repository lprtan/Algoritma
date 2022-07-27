using System;
using System.Collections.Generic;

namespace ListMinMax
{
    class Program
    {
        public static void MinMax(List<int> myList)
        {
            long toplamKucuk = 0;
            long toplamBuyuk = 0;

            myList.Sort();

            for (int i = 0; i < myList.Count - 1; i++)
            {
                toplamKucuk = toplamKucuk + myList[i];
            }
            myList.Reverse();
            for (int j = 0; j < myList.Count - 1; j++)
            {
                toplamBuyuk = toplamBuyuk + myList[j];
            }

            Console.Write(toplamKucuk + " " + toplamBuyuk);
        }
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();

            myList.Add(140638725);
            myList.Add(436257910);
            myList.Add(953274816);
            myList.Add(734065819);
            myList.Add(362748590);

            MinMax(myList);
        }
    }
}
