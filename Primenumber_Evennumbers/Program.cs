using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Primenumber_Evennumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int n, i, m = 0, number = 0;
            //Console.Write("Enter the Number to check Prime: ");
            //n = int.Parse(Console.ReadLine()); 
            //m = n / 2;
            //for (i = 2; i <= m ; i++) 
            //{
            //    if (n %i ==0)
            //    {
            //        Console.Write("Number is even number.");
            //        number = 1;
            //        break;
            //    }
            //    else 
            //    {
            //        Console.WriteLine("odd number");
            //        number = 1;
            //        break;
            //    }

            //}
            //if (number == 0)
            //{
            //    Console.Write("Number is Prime.");
            //}
            Console.Write("------Enter any  Number--------:\n");

            int nom = int.Parse(Console.ReadLine());
            bool value = true;
            // Console.WriteLine(nom / 2);
            for (int i = 2; i < nom / 2; i++)
            {
                if (nom % i == 0)
                {
                    value = false;

                    break;
                }
            }
            if (value)
            {
                Console.Write("Number is Prime");
            }
            else
            {
                Console.Write("Number is not Prime");
            }
            Console.ReadKey();
           

         

        }
    }
}
