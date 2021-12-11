using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Animal
{
    class Animal
    {
        public string Species { get; set; }
        public string Name { get; set; }
        public int FeedCount { get; set; }
        public FeedType Feedtype { get; set; }
        public double MinSquare { get; set; }
        public bool BreedingAbility { get; set; }
        public Sex Sex { get; set; }
        public void AnimalInfo()
        {
            Console.WriteLine($"{Species} {Sex} по кличке {Name}");
        }
        public Animal(string species, string name, int feedcount, FeedType feedtype, double minsquare, bool breedingAbility, Sex sex)
        {
            Species = species;
            Name = name;
            FeedCount = feedcount;
            Feedtype = feedtype;
            MinSquare = minsquare;
            BreedingAbility = breedingAbility;
            Sex = sex;
        }
        public override int GetHashCode()
        {
            int hashcode = Name.GetHashCode();
            hashcode = 31 * hashcode + Sex.GetHashCode();
            return hashcode;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Animal))
                throw new Exception("not obj animal");
            var a = obj as Animal;
            if (a.Name != Name || a.Feedtype != Feedtype || a.FeedCount != FeedCount)
                return false;
            else
                return true;
        }
        public override string ToString()
        {
            return ($"{Species}{Name}{Sex}");

        }

    }
    enum Sex
    {
        Male,
        Female
    }
    enum FeedType
    {
        Carnivore,
        Herbivore,
        Omnivore
    }
}
