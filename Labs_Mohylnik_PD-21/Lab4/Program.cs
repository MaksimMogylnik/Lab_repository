using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            //lab #4 (16 variant)
            Zavd4_16();

            Console.ReadKey();
        }

        public static void Zavd4_16()
        {
            Console.WriteLine("Input array size:");
            int n = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = random.Next(1, 10);
                Console.Write($"{arr[i]} ");
            }

            Console.WriteLine();

            int counterL = 0;
            int counterR = 0;

            Console.WriteLine("Numbers of array:");
            for (int i = 1; i < n; i++)
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
                else if (arr[i] <= arr[i - 1] && i == n - 1)
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
