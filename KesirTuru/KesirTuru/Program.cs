using System;

namespace KesirTuru
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen pay değerini giriniz:");
            int pay = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen payda değerini giriniz:");
            int payda = int.Parse(Console.ReadLine());

            int kalanPay=pay;
            int kalanPayda=payda;

            if (payda>pay)
            {
                Console.WriteLine($"Basit Kesir giridiniz. Sadeleştirilmiş gösterimi = {pay}/{payda}");
            }
            else if (pay==payda)
            {
                Console.WriteLine("Girdiğiniz değer tamsayıdır. Sadeleştirilmiş gösterimi = 1");
            }
            else
            {
                for (int i = 10; i > 0; i--)
                {
                    if (pay%i==0 && payda%i==0)
                    {
                        kalanPay = pay / i;
                        kalanPayda = payda / i;
                    }
                    pay = kalanPay;
                    payda = kalanPayda;
                }

                Console.WriteLine($"Birleşik kesir girdinidiniz. Sadeleştirilmiş gösterimi = {pay}/{payda}");
            }
        }
    }
}
