using System;

namespace BuyukHarfBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Büyük küçük harf kullanarak bir kelime giriniz");
            string kelime = Console.ReadLine();
            char[] arr;
            arr = kelime.ToCharArray(0, kelime.Length);
            string buyukHarf = "";

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]>='A' && arr[i]<= 'Z')
                {
                    buyukHarf += arr[i];
                    buyukHarf += " ";
                }
            }

            Console.WriteLine(buyukHarf);
        }
    }

    
}
