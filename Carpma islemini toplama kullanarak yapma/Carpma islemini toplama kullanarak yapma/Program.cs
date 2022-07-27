using System;

namespace Carpma_islemini_toplama_kullanarak_yapma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayi giriniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Giridiğiniz sayiyi carpmak istediğiniz sayiyi giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int sayac = 0;
            int toplam = 0;
            while (true)
            {
                toplam = sayi1 + toplam;
                sayac++;
                if (sayac==sayi2)
                    break;
            }
            Console.WriteLine("\n"+$"{sayi1} x {sayi2} = {toplam}");
        }
    }
}
