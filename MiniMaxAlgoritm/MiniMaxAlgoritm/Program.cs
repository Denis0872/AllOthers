using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MiniMaxAlgoritm
{

    class Program
    {

        static int[] MinimaxArray = new int[6];
        //static int[] MinimaxArray = new int[] { -3, 11, 3, 5, 7, -12 };
        static int LndMax;
        static int LndMin;
        private static int[] MetodEnter()
        {
            try
            {
                for (int i = 0; i < MinimaxArray.Length; i++)
                {
                    int x;

                    Console.WriteLine("Введите элемент массива");

                    int p = Convert.ToInt32(Console.ReadLine());
                    x = p;
                    MinimaxArray[i] = x;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return MinimaxArray;     
        }
            static void MetodMM(int[] MiniMaxarray)
            {

               LndMax = MinimaxArray[0] ; //присваиваем значение первого элемента массива переменной LndMax
               LndMin = MinimaxArray[0] ; //присваиваем значение первого элемента массива переменной LndMin
                for (int i = 1; i < MinimaxArray.Length; i++) //цикл начинается со второго элемена
                {

                    if (MinimaxArray[i] > LndMax) //второй элемент сравнивается с первой переменной
                    {
                        LndMax = MinimaxArray[i]; //в переменную записывается новое число
                    }
                    else if (MinimaxArray[i] < LndMin)// ...если не удовлетворяет условию if то со второй
                    {
                        LndMin = MinimaxArray[i]; //в переменную записывается новое число
                    }

                }
                Console.WriteLine("LndMax=" + " " + LndMax); //вывод максимального значения
                Console.WriteLine("LndMin=" + " " + LndMin);//  вывод минимального значения
            }


            static void Main(string[] args)
            {
                ClassLibrary1.Engine eng = new ClassLibrary1.Engine();
                MetodEnter();
                MetodMM(MinimaxArray);
                eng.Run();
                Console.ReadKey();
            }
    }
}




