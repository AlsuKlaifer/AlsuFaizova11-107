using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.IStudent
{
    class CinemaActorStudent : Student, IActor, ITheory
    {
        public CinemaActorStudent(string s): base(s) { }
        public void Play()
        {
            Console.WriteLine("Cinema actor Student plays a role.");
        }

        public override void Study()
        {
            StudyTheory();
            Play();
        }

        public void StudyTheory()
        {
            Console.WriteLine("Cinema actor Student studys a theory.");
        }
    }
}
