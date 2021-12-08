using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4new
{
    class Program
    {

        //        LAB4
        //            Використовуючи інтерфейси або спадкування реалізуйте еволюцію:
        //            дисковий телефон ->
        //            кнопочний телефон –>
        //            мобільний телефон з чорнобілим екраном – >
        //            мобільний телефон з кольоровим екраном – >
        //            смартфон. (краще спадкування)


        static void Main(string[] args)
        {
            Dictionary<string, DiskPhone> phones = new Dictionary<string, DiskPhone>()
            {
                {"diskPhone", new DiskPhone()},
                {"buttonedPhone", new ButtonedPhone()},
                {"bwPhone", new BWPhone()},
                {"coloredPhone", new ColoredPhone()},
                {"smartphone", new Smartphone()},
            };

            //Поліморфізм працює, це значить завдання виконано

            Console.ReadKey();
        }
    }
}
