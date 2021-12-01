using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.IStudent
{
    class TheatreActorStudent: Student, IActor, ITheory
    {
        public TheatreActorStudent(string s): base(s) { }

        public void Play()
        {
            Console.WriteLine("Theatre actor Student plays a role.");
        }

        public override void Study()
        {
            StudyTheory();
            Play();
        }

        public void StudyTheory()
        {
            Console.WriteLine("Theatre actor Student studys a theory.");
        }
    }
}
