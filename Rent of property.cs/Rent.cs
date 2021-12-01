using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    public class WayOfLiving
    {
        /// <summary>
        /// Стоимость
        /// </summary>
        public int Price { get; set; }
        /// <summary>
        /// Минимальная длительность аренды
        /// </summary>
        public int MinLeaseDuration { get; set; }
        /// <summary>
        /// Максимальная длительность аренды
        /// </summary>
        public int MaxLeaseDuration { get; set; }
        /// <summary>
        /// Предоплата
        /// </summary>
        public bool Prepayment { get; set; }
        public WayOfLiving(int price, int min, int max, bool prepayment)
        {
            Price = price;
            MinLeaseDuration = min;
            MaxLeaseDuration = max;
            Prepayment = prepayment;
        }
        public void MoveIn()
        {
            Console.WriteLine("Гость заселился.");
        }
        public void MoveOut()
        {
            Console.WriteLine("Гость выселился.");
        }
    }
    public class Hotel : WayOfLiving
    {
        public string TypeOfRoom;
        public string TypeOfEat;
        public Hotel(int price, int min, int max, bool prepayment, int number, RoomType room, EatType type) : base(price, min, max, prepayment)
        {
            if (room == RoomType.Single)
                TypeOfRoom = "Single";
            else if (room == RoomType.Double)
                TypeOfRoom = "Double";
            else if (room == RoomType.Family)
                TypeOfRoom = "Family";
            if (type == EatType.Breakfast)
                TypeOfEat = "Breakfast";
            else if (type == EatType.FullDay)
                TypeOfEat = "FullDay";
        }
    }
    public enum RoomType
    {
        Single,
        Double,
        Family
    }
    public enum EatType
    {
        Breakfast,
        FullDay
    }
    public class Rental : WayOfLiving
    {
        public string TypeOfHouse;
        public bool Cleaning { get; set; }
        public bool SecondKeys { get; set; }
        public bool Internet { get; set; }
        public Rental(int price, int min, int max, bool prepayment, HouseType house,
            bool cleaning, bool secondkeys, bool internet) : base(price, min, max, prepayment)
        {
            if (house == HouseType.FullHouse)
                TypeOfHouse = "FullHouse";
            else if (house == HouseType.Room)
                TypeOfHouse = "Room";
            Cleaning = cleaning;
            SecondKeys = secondkeys;
            Internet = internet;
        }
    }
    public enum HouseType
    {
        FullHouse,
        Room
    }
}
