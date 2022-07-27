using System;
using System.Numerics;

namespace BuyukFaktoriyelHesabi
{
    class Program
    {
        public static string Sifreleme(string s)
        {
            string a = s.Replace(" ", "");
            int deger = a.Length;
            int rows = (int)(Math.Sqrt(deger));
            int columns = ((int)(Math.Sqrt(deger))) + 1;
            int sayac = 0;
            char[] array = a.ToCharArray(0, a.Length);
            string mesaj = "";


            if (rows * columns < 8 && deger != 1)
            {
                string[,] arr = new string[3, 3];

                for (int c = 0; c < 3; c++)
                {
                    for (int b = 0; b < 3; b++)
                    {
                        arr[c, b] = array[sayac].ToString();
                        sayac++;

                        if (sayac == array.Length)
                        {
                            break;
                        }
                    }

                }

                for (int m = 0; m < 3; m++)
                {
                    for (int n = 0; n < 3; n++)
                    {
                        mesaj += arr[n, m];
                    }
                    mesaj += " ";
                }

            }
            else if (rows * rows == deger && deger != 1)
            {
                columns--;
                string[,] arrr = new string[rows, rows];

                for (int c = 0; c < rows; c++)
                {
                    for (int b = 0; b < rows; b++)
                    {
                        arrr[c, b] = array[sayac].ToString();
                        sayac++;

                        if (sayac == array.Length)
                        {
                            break;
                        }
                    }
                }

                for (int m = 0; m < rows; m++)
                {
                    for (int n = 0; n < rows; n++)
                    {
                        mesaj += arrr[n, m];
                    }
                    mesaj += " ";
                }
            }
            else if (a.Length == 1)
            {
                mesaj += a;
            }
            else
            {
                string[,] ar = new string[rows, columns];

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        ar[i, j] = array[sayac].ToString();
                        sayac++;


                        if (sayac == array.Length)
                        {
                            break;
                        }
                    }

                }

                for (int m = 0; m < columns; m++)
                {
                    for (int n = 0; n < rows; n++)
                    {
                        mesaj += ar[n, m];
                    }
                    mesaj += " ";
                }
            }

            return mesaj;

        }

        static void Main(string[] args)
        {
            Console.WriteLine(" Bir metin ve ya kelime giriniz");
            string s = Console.ReadLine();

            Console.WriteLine(Sifreleme(s));
            
        }
    }
}
