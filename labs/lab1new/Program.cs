using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {

//        LAB1
//      Написати програму, що виконує наступні функції 
//1.	Виводить на екран введене число з клавіатури в зворотному порядку(1234->4321)
//2.	Виводить будь-яку строку в зворотному порядку(АБВ->ВБА)
//3.	Дробові числа виводяться в зворотному порядку і ціла частина і дробова(123.456->321.654)
//4.	Реалізувати метод, що буде масив повертати задом навпаки(Використання Array.Reverse() заборонено!)
//5.	Виконати пункт 4 з використанням ключових слів ref i out

        //zavd 1-5
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Enter data");
            input = Console.ReadLine();
            Reverse(input, out string res);
            Console.WriteLine(res);
            Console.ReadLine();
        }


        static void Reverse(string str, out string res)
        {
            char[] inputarray = str.ToCharArray();
            string reverse = string.Empty;
            for (int i = inputarray.Length - 1; i >= 0; i--)
            {
                reverse += inputarray[i];
            }

            res = reverse;
        }
    }
}
