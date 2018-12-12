using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)

        {
            Random rng = new Random();
            int r = rng.Next(1, 100);
            int nr = 0;
            bool corect = false;

            Console.WriteLine("Am generat un numar intre 1 si 100.");

            while (!corect)
            {
 
                Console.Write("Ghiceste-l: ");
                string input = Console.ReadLine();

                

                if (nr < r)
                {
                    Console.WriteLine("Numarul este prea mic ");
                }
                else if (nr > r)
                {
                    Console.WriteLine("Numarul este prea mare ");
                }
                else
                {
                    corect = true;
                    Console.WriteLine("Numarul este corect!");
                }

            }
        }
    }
}
