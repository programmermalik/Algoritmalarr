using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 1, 10, 7, 6, 9, 2, 4, 3, 8 };
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

            for (int ileri = 0; ileri < sayilar.Length - 1; ileri++)
            {
                if (sayilar[ileri] != sayilar[ileri + 1] - 1)
                {
                    Console.Write(sayilar[ileri] + 1);
                }

            }
            Console.Read();
        }

    }

}