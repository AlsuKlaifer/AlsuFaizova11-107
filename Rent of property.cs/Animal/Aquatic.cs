using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Animal
{
    class Aquatic : Animal
    {
        public double Temperature { get; set; }
        public bool SaltExist { get; set; }
        public Aquatic(double temperature, bool saltExist, string species, string name, int feedcount, FeedType feedtype, double minsquare, bool breedingAbility, Sex sex)
            : base(species, name, feedcount, feedtype, minsquare, breedingAbility, sex)
        {
            Temperature = temperature;
            SaltExist = saltExist;
        }
        public void AnimalInfo()
        {
            Console.WriteLine($"{Species} {Sex} по кличке {Name}");
        }

    }
}
