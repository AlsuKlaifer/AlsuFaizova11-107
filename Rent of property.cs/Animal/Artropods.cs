using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Animal
{
    class Artropods : Animal
    {
        public bool Venomous { get; set; }
        public Artropods(bool venomous, string species, string name, int feedcount, FeedType feedtype, double minsquare, bool breedingAbility, Sex sex)
            : base(species, name, feedcount, feedtype, minsquare, breedingAbility, sex)
        {
            Venomous = venomous;
        }
        public void AnimalInfo()
        {
            Console.WriteLine($"{Species} {Sex} по кличке {Name}");
        }
    }
}
