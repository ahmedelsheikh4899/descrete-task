using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k,c, sum  ,m, x;
           

            Console.Write("\n\n");
            Console.Write("Find perfect numbers:\n");
            Console.Write("--------------------");
            Console.Write("\n\n");

            Console.Write("Input the first number (n1) : ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the second number (n2) : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("the list of the perfect numbers from n1 to n2   : ");
            



            for (k = m; k <= x; k++)
            {
                c = 1;
                sum = 0;
                while (c < k)
                {
                    if (k % c == 0)
                        sum = sum + c;
                    c++;
                }
                if (sum == k)
                    Console.Write("{0} ", k);
            }
            Console.Write("\n");





        }
    }
}
