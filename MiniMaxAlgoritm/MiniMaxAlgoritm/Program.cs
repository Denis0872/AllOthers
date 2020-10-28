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

        static int[] MinimaxArray = new int[] {0, -11, 2, 3, 4, 11};
        static int LndMax;
        static int LndMin;

        private static int[] MetodEnter()
        {
           int num = 0;
            do
            {
                int x;
                Console.WriteLine("Введите элемент массива");
                if (int.TryParse(Console.ReadLine(), out x))
                    Console.WriteLine("Число введено корректно. Введите следующее");
                else
                    Console.WriteLine("Вы ввели некорректное число");
                MinimaxArray[num] = x;
                num++;
            }
             while (num < 6);
           
            return MinimaxArray;
        }
        #region Через For      
        /*     {
                 for (int i = 0; i < MinimaxArray.Length; i++)
                 {
                    int x;
                     Console.WriteLine("Введите элемент массива");
                     if (int.TryParse(Console.ReadLine(), out x))   
                         Console.WriteLine("Число введено корректно. Введите следующее");
                     else
                         Console.WriteLine("Вы ввели некорректное число");
                   MinimaxArray[i]=x;
                 }

             }*/
        #endregion
        static void MetodMM(int[] MiniMaxarray)
            {
                for (int i = 0; i < MinimaxArray.Length; i++)
                {
                    if (MinimaxArray[i] > LndMax)
                    {
                        LndMax = MinimaxArray[i];
                    }
                    else if (MinimaxArray[i] < LndMin)
                    {
                        LndMin = MinimaxArray[i];
                    }

                }
                Console.WriteLine("LndMax=" + " " + LndMax);
                Console.WriteLine("LndMin=" + " " + LndMin);
            }

            static void Main(string[] args)
            {
                MetodEnter();
                MetodMM(MinimaxArray);
                Console.ReadKey();
            }
        }
    }



