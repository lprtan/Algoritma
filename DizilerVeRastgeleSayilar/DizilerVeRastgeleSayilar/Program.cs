using System;

namespace DizilerVeRastgeleSayilar
{
    class Program
    {
        public static int Goster(int elemanSayisi)
        {
            Random rdm = new Random();
            int dizi1ElemanSayisi = 0;
            int dizi2ElemanSayisi = 0;
            int dizi1Sayac = 0;
            int dizi2Sayac = 0;

            int[] dizi1=new int[elemanSayisi];
            int[] dizi2=new int[elemanSayisi];
            int sonuc = 0;

            for (int i = 0; i < elemanSayisi-1; i++)
            {
                int randomSayi = rdm.Next(0, 100);

                if (randomSayi<50 && randomSayi%2==0)
                {
                    dizi1ElemanSayisi++;
                    dizi1[dizi1Sayac] = randomSayi;
                    dizi1Sayac++;
                }
                else if (randomSayi>50 && randomSayi%2!=0)
                {
                    dizi2ElemanSayisi++;
                    dizi2[dizi2Sayac] = randomSayi;
                    dizi2Sayac++;
                }
            }
            Array.Resize(ref dizi1, dizi1ElemanSayisi);
            Array.Resize(ref dizi2, dizi1ElemanSayisi);

            for (int a = 0; a < dizi1.Length; a++)
            {
                Console.Write(dizi1[a] + " ");
            }
            Console.WriteLine("\n");
            for (int b = 0; b < dizi2.Length; b++)
            {
                Console.Write(dizi2[b] + " ");
            }
            Console.WriteLine("\n");


            sonuc = dizi1.Length + dizi2.Length;

            return sonuc;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Bir Sayı Giriniz!");
            int sayi = int.Parse(Console.ReadLine());

            Console.WriteLine(Goster(sayi));
        }
    }
}
