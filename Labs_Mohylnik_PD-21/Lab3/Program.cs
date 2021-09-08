using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //lab #3 (16 variant)
            Zavd3_16();

            Console.ReadKey();
        }

        public static void Zavd3_16()
        {
            Console.WriteLine("input number which contains 3 decimals:");
            string number = Console.ReadLine();

            if (number.Length != 3)
            {
                Console.WriteLine("Wrong input");
                Console.ReadKey();
                Console.Clear();
                Zavd3_16();
                return;
            }

            int b1 = Convert.ToInt32(number[0]);
            int b2 = Convert.ToInt32(number[1]);
            int b3 = Convert.ToInt32(number[2]);

            Console.WriteLine(Math.Abs(b2) == Convert.ToInt32(Math.Sqrt(b1 * b3)));
        }
    }
}
