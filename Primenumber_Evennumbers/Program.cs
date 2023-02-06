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
            Console.Write("Enter Any Number:\n");
            int nom = int.Parse(Console.ReadLine());
            bool value = true;int i;

            for (i = 2; i <= nom / 2; i++)
            {
                if (nom % i == 0)
                {
                    value = false;

                    break;
                }
            }
            if (value)
            {
                Console.Write("{0} is Prime  Number  ",nom);
                if (nom % i != 0)
                {
                    Console.Write("And odd Number");
                }
                else if (nom % i == 0)
                {
                    Console.Write("And is even Number");
                }                               
            }
            else if (nom % 2 == 0)
            {
                Console.Write("{0} is even number", nom);

            }
            else
            {
                Console.WriteLine("{0} is odd Number", nom);
            }
            Console.ReadKey();
        }
    }
}
