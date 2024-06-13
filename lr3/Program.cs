using System;

namespace lr3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, Rad, t, h, v, p;

            Console.WriteLine("1. Прямоугольник");
            Console.WriteLine("2. Круг");
            Console.WriteLine("3. Треугольник");
            Console.WriteLine("4. Трапеция");
            Console.WriteLine("5. Квадрат");

            string temp = Console.ReadLine();
            int variant = Convert.ToInt32(temp);    // преобразование в число

            switch (variant)
            {
                case 1:
                    Console.Write("Сторона А = ");
                    temp = Console.ReadLine();
                    a = Convert.ToDouble(temp);
                    Console.Write("Сторона B = ");
                    temp = Console.ReadLine();
                    b = Convert.ToDouble(temp);
                    Console.WriteLine("Площадь прямоугольника = " + a * b);
                    break;

                case 2:
                    Console.Write("Радиус R = ");
                    temp = Console.ReadLine();
                    Rad = Convert.ToDouble(temp);
                    Console.WriteLine("Площадь круга = " + 4 * Math.Atan(1) * Math.Pow(Rad, 2));
                    break;

                case 3:
                    Console.Write("Сторона T = ");
                    temp = Console.ReadLine();
                    t = Convert.ToDouble(temp);
                    Console.Write("Высота H = ");
                    temp = Console.ReadLine();
                    h = Convert.ToDouble(temp);
                    Console.WriteLine("Площадь треугольника = " + t * (h / 2));
                    break;

                case 4:
                    Console.Write("Основание P = ");
                    temp = Console.ReadLine();
                    p = Convert.ToDouble(temp);
                    Console.Write("Основание V = ");
                    temp = Console.ReadLine();
                    v = Convert.ToDouble(temp);
                    Console.Write("Высота Н = ");
                    temp = Console.ReadLine();
                    h = Convert.ToDouble(temp);
                    Console.WriteLine("Площадь трапеции = " + (p + v) / 2 * h);
                    break;

                case 5:
                    Console.Write("Сторона А = ");
                    temp = Console.ReadLine();
                    a = Convert.ToDouble(temp);
                    Console.Write("Сторона В = ");
                    temp = Console.ReadLine();
                    b = Convert.ToDouble(temp);
                    Console.WriteLine("Площадь квадрата = " + a*b);
                    break;

                default: Console.WriteLine("Выбор неверен "); break;
            }
        }
    }
}
