using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodsLab4
{

    class Program
    {

        public static void Greater()
        {
            int x;
            Console.WriteLine("Введите число а");
            if (int.TryParse(Console.ReadLine(), out x));
            else
            Console.WriteLine("Вы ввели некорректное число");
            int a = x;
            Console.WriteLine("Введите число b");
            if (int.TryParse(Console.ReadLine(), out x));
            else
                Console.WriteLine("Вы ввели некорректное число");
            int b = x;

            if (a > b)

            Console.WriteLine("Число {0} больше", a) ;
            else
                Console.WriteLine("Число {0} больше", b);


        }
        public static int Testing()
        {
            return 0;
        }
        static void Main(string[] args)
        {
            Greater();
           // Testing();
            Console.ReadKey();
        }
    }
}
