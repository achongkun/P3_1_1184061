using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_1_1184061
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ayam;
            Console.Write("ANAK AYAM TURUN");
            ayam = int.Parse(Console.ReadLine());

            if (ayam > 10 || ayam <= 0)
            {
                Console.WriteLine("tidak sesuai");
            }
            else
            {
                for (int i = ayam; i >= 1; i--)
                {



                    if (i == 1)
                    {
                        Console.WriteLine("lebih dari ayam 1 " + "mati satu tinggal induknya");
                    }
                    else
                    {
                        Console.WriteLine("lebih dari ayam " + i + "," + "Matilah satu tinggalah " + (i - 1));
                    }

                }
            }
        }
    }
}
