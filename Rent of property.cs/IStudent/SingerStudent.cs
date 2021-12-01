using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.IStudent
{
    class SingerStudent : Student, ISinger, ITheory
    {
        public SingerStudent(string s): base(s)
        {

        }

        public void Sing()
        {
            Console.WriteLine("Singer student sings.");
        }

        public override void Study()
        {
            StudyTheory();
            Sing();
        }

        public void StudyTheory()
        {
            Console.WriteLine("Singer student studys a theory.");
        }
    }
}
