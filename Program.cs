using System.Drawing;
using ClassLibrary;
namespace main
{
    class Program
    {
        static void Main()
        {
            //Задание 1
            Console.WriteLine("Задание 1");
            Console.WriteLine("short: " + short.MinValue + " " + short.MaxValue);
            Console.WriteLine("int: " + int.MinValue + " " + int.MaxValue);
            Console.WriteLine("long: " + long.MinValue + " " + long.MaxValue);
            Console.WriteLine("float: " + float.MinValue + " " + float.MaxValue);
            Console.WriteLine("double: " + double.MinValue + " " + double.MaxValue + Environment.NewLine);

            //Задание 2
            Console.WriteLine("Задание 2");
            rectangle rectangleh = new rectangle(33, 11);
            Console.WriteLine("Площадь прямоугольника: " + rectangleh.area);
            Console.WriteLine("Периметр прямоугольника: " + rectangleh.perimetr + Environment.NewLine);

            //Задание 3
            Console.WriteLine("Задание 3");
            point a = new point(3, 4);
            point b = new point(1, 7);
            point c = new point(8, 1);
            point d = new point(7, 8);
            point e = new point(1, 1);

            figure trian = new figure(a, b, c);
            Console.WriteLine("Фигура: " + trian.name + " " + " Периметр: " + trian.perimetrcalculator());
            figure quad= new figure(a, b, c, d);
            Console.WriteLine("Фигура: " + quad.name +  " " + "Периметр: " + quad.perimetrcalculator());
            figure penta = new figure(a, b, c, d, e);
            Console.WriteLine("Фигура: " + penta.name + " " + "Периметр: " + penta.perimetrcalculator());




        }
    }
}
