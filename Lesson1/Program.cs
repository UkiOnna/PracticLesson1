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
            //FirstTask();
            //SecondTask();
            //ThirdTask();
            //FourthTask();
            FifthTask();
        }

        private static void FifthTask()
        {
            Console.WriteLine("Введите двузначноечисло");
            string numberAsString = Console.ReadLine();
            int numberAsInt = int.Parse(numberAsString);
            int divider = 10;
            int decade = numberAsInt / divider;
            int units = numberAsInt % divider;
            int summa = decade + units;
            int composition = decade * units;
            Console.Write("Десятков = ");
            Console.WriteLine(decade);
            Console.Write("Едениц = ");
            Console.WriteLine(units);
            Console.Write("Сумма = ");
            Console.WriteLine(summa);
            Console.Write("Произведение = ");
            Console.WriteLine(composition);
            Console.ReadLine();
        }

        private static void FourthTask()
        {
            int pastDays = 234;
            int week = 7;
            int fulWeek = pastDays / week;
            Console.Write("Полных недель - ");
            Console.WriteLine(fulWeek);
            Console.ReadLine();
        }

        private static void ThirdTask()
        {
            Console.WriteLine("Введите расстояние в сантиметрах");
            string distanceAsString = Console.ReadLine();
            int distanceAsIntInSantimetrs = int.Parse(distanceAsString);
            int divider = 100;
            int distanceInMeters = distanceAsIntInSantimetrs / divider;
            Console.Write("Расстояние в сантиметрах - ");
            Console.WriteLine(distanceInMeters);
            Console.ReadLine();
        }

        private static void SecondTask()
        {
            Console.WriteLine("Введите радиус окружности");
            string radiusAsString = Console.ReadLine();
            int radiusAsInt = int.Parse(radiusAsString);
            double length = 2 * Math.PI * radiusAsInt;
            double square = Math.PI *( Math.Pow(radiusAsInt,2));
            Console.Write("Площадь равна = ");
            Console.WriteLine(square);
            Console.Write("Длина равна = ");
            Console.WriteLine(length);
            Console.ReadLine();
        }

        private static void FirstTask()
        {
            Console.WriteLine("y=7x^2-3x+4");
            Console.WriteLine("Введите число которое вставится вместо x");
            string x = Console.ReadLine();
            int X = int.Parse(x);
            double y = (7 * (Math.Pow(X,2))) - ((3 * X) + 4);
            Console.Write("y=");
            Console.WriteLine(y);
            Console.ReadLine();
            
        }

    }
}
