using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("y=7x^2-3x+4");
            Console.WriteLine("Введите число которое вставится вместо x");
            string x = Console.ReadLine();
            int X = int.Parse(x);
            int y = (7 * (X * X)) - ((3 * X) + 4);
            Console.Write("y=");
            Console.WriteLine(y);
            Console.ReadLine();
        }
    }
}
