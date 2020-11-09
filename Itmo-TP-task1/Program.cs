using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Itmo_TP_task1
{
    class Program
    {
        private static string[] spisok_pok;
        private static string[] mag1;
        private static string[] mag2;
        private static string[] mag3;

        private static void Comparer(string[] First_ar, string[] Second_Ar)
        {
             for (int i = 0; i < First_ar.Length; i++)
                 for (int j = 0; j < Second_Ar.Length; j++)
                 {
                     if (First_ar[i] == Second_Ar[j])
                         First_ar[i] = null;
                 }
             First_ar = First_ar.Where(x => x != null).ToArray();
             for (int i = 0; i < First_ar.Length; i++)
             {
                 Console.WriteLine(First_ar[i]);
             }
        }
        static void Main(string[] args)
        {
            //создание списка покупок
            spisok_pok = new string[] { "Carrot", "beet", "potato", "Juice", "vodka", "beer", "pelmeni", "Cottage-cream", "meat", "fish" };
            for (int i = 0; i < spisok_pok.Length; i++)
            {
                Console.WriteLine(spisok_pok[i]);
            }
            Console.WriteLine("----------------Список изначальный");
            //создание списков ассортимента товаров в магазинах
            mag1 = new string[] { "Carrot", "beet", "potato", "cabbage", "onion", "cucumder", "tomatoes", "pepper" };
            mag2 = new string[] { "Juice", "vodka", "beer", "pelmeni", "Cottage-cream", "meat", "water", "lemonade", "milk" };
            mag3 = new string[] { "pelmeni", "Cottage-cream", "meat", "fish", "cigarettes", "chees", "sugar" };


            Comparer(spisok_pok, mag1);
            Console.WriteLine("----------------Список не купленных товаров после первого магазина");

            Comparer(spisok_pok, mag2);
            Console.WriteLine("----------------Список не купленных товаров после второго магазина");
            Comparer(spisok_pok, mag3);
            Console.WriteLine("----------------Списокне купленных товаров после третьего магазина");

            Console.ReadKey();
        }
    }
 }
    
