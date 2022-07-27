using System;

namespace YolBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Harita = { { 1, 0, 0, 0, 1 }, { 0, 1, 1, 0, 0 }, { 0, 1, 1, 1, 0 }, { 0, 0, 0, 1, 1 } };

            string yollar = "";

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (Harita[i,j]==1)
                    {
                        yollar += " " + i + j;
                    }
                }
            }

            Console.WriteLine(yollar);
        }
    }

   
}

