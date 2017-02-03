using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 99, 5, 1, 44, 55, 5, 22, 12 };
            int i;
            for (i = 0; i < sayilar.Length; i++)
            {
                int a;
                int geçici;
                for (a = sayilar.Length - 1; a > 0; a--)
                {
                    if (sayilar[a] < sayilar[a - 1])
                    {

                        geçici = sayilar[a];
                        sayilar[a] = sayilar[a - 1];
                        sayilar[a - 1] = geçici;

                    }

                }



            }
            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }
            Console.Read();
        }
        }
    }