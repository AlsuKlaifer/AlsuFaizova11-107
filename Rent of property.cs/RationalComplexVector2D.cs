using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    public interface IClonable
    {
        object Clone();
    }
    class RationalComplexVector2D: IClonable
    {
        private Rationcomplex x;
        private Rationcomplex y;
        public Rationcomplex X
        {
            get {return x;}
        }
        public Rationcomplex Y
        {
            get { return y; }
        }
        public RationalComplexVector2D()
        {
            x = new Rationcomplex();
            y = new Rationcomplex();
        }
        public RationalComplexVector2D(Rationcomplex x, Rationcomplex y)
        {
            this.x = x;
            this.y = y;
        }
        /// <summary>
        /// Сложение двух векторов
        /// </summary>
        public RationalComplexVector2D Add(RationalComplexVector2D n)
        {
            return new RationalComplexVector2D(x.Add(n.X), y.Add(n.y));
        }
        public void AddToYourself(RationalComplexVector2D n)
        {
            x = x.Add(n.x);
            y = y.Add(n.y);
        }
        public override string ToString()
        {
            return $"({x.ToString()},{y.ToString()})";
        }
        /// <summary>
        /// Скалярное произведение
        /// </summary>
        public Rationcomplex ScalarProduct()
        {
            throw new NotImplementedException();
        }

        public object Clone()
        {
            var newX = CloneOneCoor(x);
            var newY = CloneOneCoor(y);
            return new RationalComplexVector2D(newX, newY);
        }

        private Rationcomplex CloneOneCoor(Rationcomplex coord)
        {
            //новая действительная часть
            var real = new RationalFraction(coord.Real.A, coord.Real.B);
            //новая мнимая часть
            var image = new RationalFraction(coord.Image.A, coord.Image.B);
            var newX = new Rationcomplex(real, image);
            return newX;
        }
    }
}
