using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_Mohylnik_PD_21
{
    class Program
    {
        static void Main(string[] args)
        {
            //lab#1 (16 variant)
            Zavd1_1();


            Console.ReadKey();
        }

        public static void Zavd1_1()
        {
            Console.WriteLine("input pendulum length:");
            double l = Convert.ToDouble(Console.ReadLine());

            double t = Math.Round(2 * Math.Sqrt(l / 9.8), 2);

            Console.WriteLine($"period of pendulum oscillations equals {t}");
        }
    }
}
