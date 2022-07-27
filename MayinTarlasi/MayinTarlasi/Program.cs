using System;

namespace MayinTarlasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rdm = new Random();

            int puan = 0;

            Console.WriteLine("Lütfen oyun alanı için satır sayısı giriniz");
            int satir = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen oyun alanı için sütun sayısı giriniz");
            int sutun = Convert.ToInt32(Console.ReadLine());

            int[,] tarla = new int[satir, sutun];

            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    tarla[i, j] = rdm.Next(0, 2);

                }
            }

            for (int k = 0; k < satir; k++)
            {
                for (int l = 0; l < sutun; l++)     
                {
                    Console.Write(tarla[k, l] + " ");
                }
                Console.WriteLine(" ");
            }


            while (true)
            {
                Console.WriteLine("Lütfen oynamak istediğiniz satır numarsını giriniz");
                int satırNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Lütfen oynamak istediğiniz sütun numarsını giriniz");
                int sutunNo = Convert.ToInt32(Console.ReadLine());


                if (tarla[satırNo,sutunNo]==0)
                {
                    puan += 10;
                    Console.WriteLine($"Hayatasın...Devam");
                }
                else if (tarla[satırNo, sutunNo]==1)
                {
                    Console.WriteLine($"Oyun bitti!!! ----- Mevcut puanınız={puan}");
                    break;
                }
                
            }

        }
    }
}
