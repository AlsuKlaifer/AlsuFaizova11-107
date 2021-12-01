using System;

namespace Study
{
    class Program1
    {
        static void Main(string[] args)
        {
            var rcv1 = new RationalComplexVector2D
                (new Rationcomplex(
                    new RationalFraction(1, 2),
                    new RationalFraction(3, 4)),
                new Rationcomplex(
                    new RationalFraction(5, 6),
                    new RationalFraction(7, 8)));

            var rcv2 = rcv1.Clone(); //rvc2 - object 

            var rcv3 = (RationalComplexVector2D)rcv2; //явно привели к дочернему типу

            rcv1.AddToYourself(new RationalComplexVector2D
                (new Rationcomplex(
                    new RationalFraction(1, 1),
                    new RationalFraction(1, 1)),
                new Rationcomplex(
                    new RationalFraction(1, 1),
                    new RationalFraction(1, 1))));

            rcv3.AddToYourself(new RationalComplexVector2D
                (new Rationcomplex(
                    new RationalFraction(2, 1),
                    new RationalFraction(2, 1)),
                 new Rationcomplex(
                     new RationalFraction(2, 1),
                     new RationalFraction(2, 1))));

            ////var hotel = new Hotel(1500, 1, 5, true, 1, RoomType.Single, EatType.Breakfast);
            //var t1 = new RectangularTriangle(3, 4, 5, 60);
            //Console.WriteLine($"{t1.GetType()}. Периметр равен {t1.Perimeter()}. Площадь {t1.Square()}.");
            //var t2 = new IsoscelesTriangle(5, 6, 30);
            //Console.WriteLine($"{t2.GetType()}. Периметр равен {t2.Perimeter()}. Площадь {t2.Square()}.");
        }
    }
}
