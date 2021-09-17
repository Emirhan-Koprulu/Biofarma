using System;
using System.Collections.Generic;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            //El ile girişte sağlanabilir.
            //Console.WriteLine("Denklem noktalarını giriniz");
            //string x = Console.ReadLine();

            //Örnek datalar
            string x = "(1;2) , (3;7) , (0;7) , (1;1) , (1;6)";
            string y = "(1;2) , (3;2) , (3;6) , (1;1) , (1;7)";
            string z = "(2;2) , (3;2) , (3;6) , (1;6) , (1;7)";
            char[] ayrac = { ',', ';', '(', ')' };

            string[] parcalar = x.Split(ayrac);
            //string[] parcalar = y.Split(ayrac);
            //string[] parcalar = z.Split(ayrac);

            for (int i = 1; i < parcalar.Length; i += 4)
            {
                for (int k = 1; k < parcalar.Length; k += 4)
                {
                    if (i == k)
                    {
                        break;
                    }
                    if (parcalar[i] == parcalar[k])
                    {
                        //y eksenine paralel
                        a++;
                    }

                    if (parcalar[i + 1] == parcalar[k + 1])
                    {
                        //x eksenine paralel
                        b++;
                    }
                }
            }
            Console.WriteLine("Bu kümede " + a + " adet y eksenine paralel doğru," + b + " adet x eksenine paralel doğru bulunmaktadır.");
        }
    }
}
