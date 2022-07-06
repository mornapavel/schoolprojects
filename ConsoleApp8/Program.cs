using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, x;
            Console.WriteLine("Introduceti a = ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti b = ");
            b = float.Parse(Console.ReadLine());
            if (a == 0)
                if (b == 0)
                    Console.WriteLine("ecuatia nederteminata ");
                else Console.WriteLine("Ecuatia imposibila ");
            else
            {
                x = -b / a;
                Console.WriteLine("Solutia este x = {0}", x );
            }
            Console.ReadKey();
        }
    }
}
