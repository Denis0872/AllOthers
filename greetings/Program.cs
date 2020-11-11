using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greetings
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName;


            Console.WriteLine("введите своё имя");
            myName = Console.ReadLine();
            Console.WriteLine("Добрый день {0}", myName);
            Console.ReadKey();
        }
    }
}
