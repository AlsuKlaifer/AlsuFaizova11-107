using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    class Rationcomplex
    {
        private RationalFraction real;
        private RationalFraction image;
        public RationalFraction Real
        {
            get { return real; }
        }
        public RationalFraction Image
        {
            get { return image; }
        }
        public Rationcomplex()
        {
            image = new RationalFraction();
            real = new RationalFraction();
        }
        public Rationcomplex(RationalFraction r, RationalFraction i)
        {
            real = r;
            image = i;
        }
        public Rationcomplex Add(Rationcomplex n)
        {
            return new Rationcomplex(real.Add(n.Real), image.Add(n.Image));
        }
        public Rationcomplex Mult(Rationcomplex n)
        {
            return new Rationcomplex(
                real.Mult(n.real).Add(image.Mult(n.image)),
                real.Mult(n.image).Add(image.Mult(n.real)))
        }
        public override string ToString()
        {
            return $"{real.RFToString()} + i* {image.RFToString()}";
        }
    }
}
