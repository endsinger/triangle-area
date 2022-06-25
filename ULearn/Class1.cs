using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULearn
{
    class Class1
    {
       public static void GetInput(int input)
        {
            if (input == 1)
            {
                Console.WriteLine(" Введите значения двух сторон и угла");
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                DveStoronyUgol(a, b, y);

            } 
            else if (input == 2)
            {
                Console.WriteLine(" Введите значения основания и высоты");
                double b = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                Osnovanie(b, h);
            }
            else if (input == 3)
            {
                Console.WriteLine(" Введите значения трех строн треугольника");
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double c = double.Parse(Console.ReadLine());
                Geron(a, b, c);
            } else
            {
                Console.WriteLine("Введеное число неверное");
            }
        }
        public static void Geron(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double s = p * (p - a) * (p - b) * (p - c);
            double sFinally = Math.Sqrt(s);
            Console.WriteLine($"Площадь равна: {sFinally}");
        }

        public static void DveStoronyUgol(double a, double b, double y)
        {
            double s = 0.5 * a * b * Math.Sin(y);
            Console.WriteLine($"Площадь равна: {s}");
        }
        public static void Osnovanie(double b, double h)
        {
            double s = 0.5 * b * h;
            Console.WriteLine($"Площадь равна: {s}");
        }
    }
}
