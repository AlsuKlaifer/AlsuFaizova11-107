using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.IPlayer
{
    class Musician: IPlayer
    {
        public string Name { get; }
        public string Instrument;
        public Musician(string name, string instrument)
        {
            Name = name;
            Instrument = instrument;
        }

        public void Play()
        {
            if(Instrument == "скрипка")
            Console.WriteLine($"Музыкант {Name} играет на {Instrument}.");
        }
    }
}
