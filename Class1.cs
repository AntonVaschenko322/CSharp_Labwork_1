using System.Globalization;

namespace ClassLibrary
{
    public class rectangle
    {
        private double sideA, sideB;
        public rectangle(double sideA, double sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }
        private double calculateArea()
        {
            return sideA * sideB;
        }
        private double calculatePerimetr()
        {
            return sideA + sideB;
        }
        public double area
        {
            get { return calculateArea(); }
        }

        public double perimetr
        {
            get { return calculatePerimetr(); }
        }
    }


    public class point
    {
        private int x, y;
        public point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int x_cor
        {
            get { return x; }
        }

        public int y_cor
        {
            get { return y; }
        }
    }

    public class  figure
    {

        private double a = 0, b = 0, c = 0, d = 0, e = 0; 
        public string name { get; }
        public double A { get { return a; } }
        public double B { get { return b; } }
        public double C { get { return c; } }
        public double D { get { return d; } }
        public double E { get { return e; } }

        private double lengthside(point a, point b)
        {
            double x = Math.Pow(a.x_cor - b.x_cor, 2);
            double y = Math.Pow(a.y_cor - b.y_cor, 2);
            return Math.Sqrt(x + y);
        }

        public double perimetrcalculator()
        {
            return a + b + c + d + e;
        }

        public figure(point a, point b, point c)
        {
            this.a = lengthside(a, b);
            this.b = lengthside(b, c);
            this.c = lengthside(c, a);
            name = "Треугольник";
        }

        public figure(point a, point b, point c, point d) : this(a, b, c)
        {   
            this.d = lengthside(d, a);
            name = "Четырехугольник";
        }

        public figure(point a, point b, point c, point d, point e) : this(a, b, c, d)
        {
            this.e = lengthside(e, a);
            name = "Пятиугольник";
        }
    }
}
