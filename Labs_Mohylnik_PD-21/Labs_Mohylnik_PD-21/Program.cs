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
            //Zavd1_1();

            //lab #2 (16 variant)
            //Zavd2_2();

            //lab #3 (16 variant)
            //Zavd3_16();

            //lab #4 (16 variant)
            Zavd4_16();


            Console.ReadKey();
        }

        public static void Zavd1_1()
        {
            Console.WriteLine("input pendulum length:");
            double l = Convert.ToDouble(Console.ReadLine());

            double t = Math.Round(2 * Math.Sqrt(l / 9.8), 2);

            Console.WriteLine($"period of pendulum oscillations equals {t}");
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

        public static void Zavd4_16()
        {
            Console.WriteLine("Input array size:");
            int n = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int[] arr = new int[n];

            for(int i = 0; i < n; i++)
            {
                arr[i] = random.Next(1, 10);
                Console.Write($"{arr[i]} ");
            }

            Console.WriteLine();

            int counterL = 0;
            int counterR = 0;

            Console.WriteLine("Numbers of array:");
            for(int i = 1; i < n; i++)
            {
                if (arr[i] < arr[i - 1] && counterR == i - 1 && counterR != counterL)
                {
                    Console.WriteLine($"RISE from index {counterL} to index {counterR}");
                }
                else if (arr[i] > arr[i - 1] && counterL == i - 1 && counterR != counterL)
                {
                    Console.WriteLine($"LOWER from index {counterR} to index {counterL}");
                }

                if (arr[i] >= arr[i - 1] && i == n - 1)
                {
                    counterR = i;
                    Console.WriteLine($"RISE from index {counterL} to index {counterR}");
                }
                else if(arr[i] <= arr[i - 1] && i == n - 1)
                {
                    counterL = i;
                    Console.WriteLine($"LOWER from index {counterR} to index {counterL}");
                }
                else if (arr[i] >= arr[i - 1])
                {
                    counterR = i;
                }
                else if (arr[i] <= arr[i - 1])
                {
                    counterL = i;
                }
            }
        }
    }
}
