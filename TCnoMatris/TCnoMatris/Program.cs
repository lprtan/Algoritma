using System;

namespace TCnoMatris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir TC no giriniz: ");
            string tc = Console.ReadLine();
            int sayac = 0;
            int[] sutunToplam=new int[3];
            int[] satirToplam=new int[3];

            char[] arr = tc.ToCharArray(0, tc.Length - 2);

            int[,] array = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i, j] = Convert.ToInt32(arr[sayac].ToString());
                    sayac++;
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine(" ");
            }

            for (int m = 0; m < 3; m++)
            {
                int sutun_toplam = 0;
                int satır_toplam = 0;
                for (int n = 0; n < 3; n++)
                {
                    satır_toplam += array[m, n];
                    sutun_toplam += array[n, m];
                }
                satirToplam[m] = satır_toplam;
                sutunToplam[m] = sutun_toplam;
            }
           
            int SonIkiBasamak = Convert.ToInt32(tc.Substring(9));

            if (SonIkiBasamak<50)
            {
                int min = satirToplam[0];
                for (int i = 0; i < 3; i++)
                {
                    if (min > satirToplam[i])
                    {
                        min = satirToplam[i];
                    }
                }
                Console.WriteLine(min);
            }
            else if (SonIkiBasamak>50)
            {
                int max = sutunToplam[0];
                for (int i = 0; i < 3; i++)
                {
                    if (sutunToplam[i] > max)
                    {
                        max = sutunToplam[i];
                    }
                }
                Console.WriteLine(max);
            }

        }
    }
}
