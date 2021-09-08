using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //lab #2 (16 variant)
            Zavd2_2();

            Console.ReadKey();
        }

        public static void Zavd2_2()
        {
            int n;
            Console.WriteLine("input \"n\":");
            n = Convert.ToInt32(Console.ReadLine());

            int k;
            Console.WriteLine("input \"k\":");
            k = Convert.ToInt32(Console.ReadLine());

            if (!(0 <= n * n && n * n <= n * k))
            {
                Console.WriteLine("Wrong input");
                Console.ReadKey();
                Console.Clear();
                Zavd2_2();
                return;
            }

            double sum = 0;

            for (int i = n * n; i <= n * k; i++)
            {
                sum += Math.Round((Math.Pow(k, 2) + Math.Pow(-1, k) * k - 1) / (Math.Pow(k, 2) + 1), 2);
                Console.WriteLine($"Sum = {sum}");
            }

        }
    }
}
