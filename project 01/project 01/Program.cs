using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, syco, zoro, bar, fpy;

            Console.Write("\n\n");
            Console.Write("Find the prime numbers within a range of numbers:\n");
            Console.Write("---------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input first number  : ");
           bar = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second number : ");
            fpy = Convert.ToInt32(Console.ReadLine());
            Console.Write("The prime numbers between {0} and {1} are : \n", bar, fpy);


            for (num = bar; num <= fpy; num++)
            {
                zoro = 0;

                for (syco = 2; syco <= num / 2; syco++)
                {
                    if (num % syco == 0)
                    {
                        zoro++;
                        break;
                    }
                }

                if (zoro == 0 && num != 1)
                    Console.Write("{0} ", num);
            }
            Console.Write("\n");
        }


    }
    
}
