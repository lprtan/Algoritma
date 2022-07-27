using System;

namespace Algoritma3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen 3 basamaklı bir sayı giriniz!");
            string sayi = Console.ReadLine();
            char[] sayiDizisi;
            sayiDizisi = sayi.ToCharArray(0, 3);

            string a = sayiDizisi[0].ToString();
            string b = sayiDizisi[1].ToString();
            string c = sayiDizisi[2].ToString();

            int aSayi = Convert.ToInt32(a);
            int bSayi = Convert.ToInt32(b);
            int cSayi = Convert.ToInt32(c);

            int armstrongSayi = (aSayi * aSayi * aSayi) + (bSayi * bSayi * aSayi) + (cSayi * cSayi * cSayi);

            if (Convert.ToInt32(sayi)==armstrongSayi)
            {
                Console.WriteLine($"{sayi} sayısı Armstrong bir sayıdır");
            }
            else
                Console.WriteLine($"{sayi} sayısı Armstrong bir sayı değilidr");
        }
    }
}
