using System;

namespace Study.IPlayer
{
    class Program1
    {
        static void Main(string[] args)
        {
            var m1 = new Musician("Алсу", "скрипка");
            var m2 = new Musician("Марат", "скрипка");
            var m3 = new Musician("Илья", "пианино");

            var p1 = new FootballPlayer("Егор", 22);
            var p2 = new FootballPlayer("Алексей", 21);
            var p3 = new FootballPlayer("Булат", 18);
            var p4 = new FootballPlayer("Глеб", 18);

            IPlayer[] players = { m1, m2, m3, p1, p2, p3, p4 };
            foreach(var player in players)
            {
                player.Play();
            }

            //string s = "яблоко банан апельсин мандарин";
            //Console.WriteLine(s.OneByOneJoin("купить съесть убрать"));

            //    var animal = new Aquatic(-273, false, "cat", "Boris", 1, FeedType.Omnivore, 25, true, Sex.Female);
            //    Console.WriteLine(animal.ToString());
            //    object o;
            //    var c1 = new RefTypeExampleClass() { IntField = 5 };
            //    var s1 = new ValueTypeExampleStruct() { IntField = 5 };
            //    var c2 = c1;
            //    var s2 = s1;
            //    c1.IntField = 7;
            //    s1.IntField = 7;
            //}
            //public class RefTypeExampleClass
            //{
            //    public int IntField;
            //}
            //public struct ValueTypeExampleStruct
            //{
            //    public int IntField;
            //}

            //var rf = new RationalFraction(1, 2);
            //Console.WriteLine(rf.IsInteger());

            //var singer = new SingerStudent("singer");
            //singer.Sing();


            //var rcv1 = new RationalComplexVector2D
            //    (new Rationcomplex(
            //        new RationalFraction(1, 2),
            //        new RationalFraction(3, 4)),
            //    new Rationcomplex(
            //        new RationalFraction(5, 6),
            //        new RationalFraction(7, 8)));

            //var rcv2 = rcv1.Clone(); //rvc2 - object 

            //var rcv3 = (RationalComplexVector2D)rcv2; //явно привели к дочернему типу

            //rcv1.AddToYourself(new RationalComplexVector2D
            //    (new Rationcomplex(
            //        new RationalFraction(1, 1),
            //        new RationalFraction(1, 1)),
            //    new Rationcomplex(
            //        new RationalFraction(1, 1),
            //        new RationalFraction(1, 1))));

            //rcv3.AddToYourself(new RationalComplexVector2D
            //    (new Rationcomplex(
            //        new RationalFraction(2, 1),
            //        new RationalFraction(2, 1)),
            //     new Rationcomplex(
            //         new RationalFraction(2, 1),
            //         new RationalFraction(2, 1))));

            ////var hotel = new Hotel(1500, 1, 5, true, 1, RoomType.Single, EatType.Breakfast);
            //var t1 = new RectangularTriangle(3, 4, 5, 60);
            //Console.WriteLine($"{t1.GetType()}. Периметр равен {t1.Perimeter()}. Площадь {t1.Square()}.");
            //var t2 = new IsoscelesTriangle(5, 6, 30);
            //Console.WriteLine($"{t2.GetType()}. Периметр равен {t2.Perimeter()}. Площадь {t2.Square()}.");
        }
    }
}
