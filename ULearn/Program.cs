using System;

namespace ULearn
{
    class Program
    {      
        public static void Main()
        {
            while (true)
            {
                Console.WriteLine("========================== \n \n Что вы хотите найти? \n Площадь треугольника через две сороны и угол между ними введите - 1 \n Через основание и высоту введите - 2 \n Через формулу Герона - 3 ");
                try
                {
                    int input = int.Parse(Console.ReadLine());
                    Class1.GetInput(input);                 
                }
                catch
                {
                    Console.WriteLine("Проверьте правильность написания");
                }
            }
        }

    }

}
