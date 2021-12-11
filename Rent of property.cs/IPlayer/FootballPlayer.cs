using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.IPlayer
{
    class FootballPlayer : IPlayer
    {
        public string Name { get; }
        public int Age { get; }
        public FootballPlayer(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Play()
        {
            if (Age < 20)
                Console.WriteLine($"Футболист {Name} играет в футбол.") ;
        }
    }
}
