using System;

namespace PolindromSayi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz");
            string sayi = Console.ReadLine();
            bool durum = false;
            char[] arr;
            arr = sayi.ToCharArray(0, sayi.Length);
            int i = 0;
            for (int j = arr.Length - 1; j >= 0; j--)
            {
                if (arr[i] == arr[j])
                {
                    durum = true;
                }
                else
                {
                    durum = false;
                    break;
                }
                i++;
            }
            Console.WriteLine(durum);
        }
    }
}


