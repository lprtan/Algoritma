using System;
using System.Collections.Generic;

namespace deneme
{
    class Program
    {
        public static int ListeKontrol(int n, int k, List<int> ar)
        {
            int sayac = 0;
            int toplam = 0;

            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    if (ar[i] == ar[j])
                    {
                        continue;
                    }

                    toplam = ar[i] + ar[j];

                    if (toplam % k == 0)
                    {
                        sayac++;
                    }
                }
            }

            return sayac / 2;
        }
        static void Main(string[] args)
        {
            List<int> ar = new List<int>() { 43, 95, 51, 55, 40, 86, 65, 81, 51, 20, 47, 50, 65, 53, 23, 78, 75, 75, 47, 73, 25, 27, 14, 8, 26, 58, 95, 28, 3, 23, 48, 69, 26, 3, 73, 52, 34, 7, 40, 33, 56, 98, 71, 29, 70, 71, 28, 12, 18, 49, 19, 25, 2, 18, 15, 41, 51, 42, 46, 19, 98, 56, 54, 98, 72, 25, 16, 49, 34, 99, 48, 93, 64, 44, 50, 91, 44, 17, 63, 27, 3, 65, 75, 19, 68, 30, 43, 37, 72, 54, 82, 92, 37, 52, 72, 62, 3, 88, 82, 71 };

            int n = ar.Count;

            Console.WriteLine("lütfen bölen sayısını giriniz");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(ListeKontrol(n, k, ar));
        }
    }
}
