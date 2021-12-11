using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.IStudent
{
    public abstract class Student: ITheory
    {
        private string fio;
        public string FIO { get { return fio; } }
        public Student(string s)
        {
            fio = s;
        }
        public int YearsOfStudy { get; set; }
        public abstract void Study();

        public abstract void StudyTheory();
    }
}
