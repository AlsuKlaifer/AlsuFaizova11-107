using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    public class Triangle
    {
        //стороны
        public double ab { get; set; }
        public double bc { get; set; }
        public double ac { get; set; }
        //углы
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }

        public Triangle(double ab, double bc, double ac, int a, int b)
        {
            if ((ab + bc) <= ac || (ac + bc) <= ab || (ac + ab) <= bc)
                Console.WriteLine("Ошибка. Введите существующий треугольник");
            this.ab = ab;
            this.bc = bc;
            this.ac = ac;
            this.a = a;
            this.b = b;
            c = 180 - a - b;
        }
        public double Perimeter()
        {
            return ab + bc + ac;
        }
        /// <summary>
        /// Площадь по формуле Герона (по трем сторонам)
        /// </summary>
        public double Square()
        {
            double p2 = (a + b + c) / 2; //полупериметр
            return Math.Sqrt(p2*(p2 - a)*(p2 - b)*(p2 - c));
        }
        public string GetType()
        {
            if (ab == bc && ab == ac) return "Треугольник равносторонний";
            if (ab == bc || bc == ac || ab == ac) return "Треугольник равнобедренный";
            if (ab*ab + ac*ac == bc*bc || bc*bc + ab*ab == ac*ac || ac*ac + bc*bc == ab*ab) return "Треугольник прямоугольный";
            return "Обычный треугольник";
        }
    }

    public class RectangularTriangle : Triangle
    {
        public RectangularTriangle(double ab, double bc, double ac, int a) : base(ab, bc, ac, a, 90)
        {
            if (ac != Math.Sqrt(ab * ab + bc * bc))
                Console.WriteLine("Ошибка. Треугольник не прямоугольный.");
            b = 90;
            c = b - a;
        }
        public double Square()
        {
            return ab * bc / 2;
        }
    }

    public class IsoscelesTriangle : Triangle
    {
        public IsoscelesTriangle(double ab, double bc, int b) : base(ab, bc, ab, b, b)
        {
            this.ac = ab;
            c = b;
            a = 180 - 2 * c;
        }
        public double Square()
        {
            double h = Math.Sqrt(ac * ac - (bc / 2) * (bc / 2));
            return bc * h / 2;
        }
    }
}
