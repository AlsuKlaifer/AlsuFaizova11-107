using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.IStudent
{
    class ArtSchool
    {
        private Student[] students;
        public Student[] Students { get { return students; } }
        public ArtSchool(Student[] s)
        {
            students = s;
        }
        /// <summary>
        /// Отправляем всех на изучение истории искусств
        /// </summary>
        public void ArtHistory()
        {
            for (int i = 0; i < students.Length; i++)
                students[i].StudyTheory();
        }
        /// <summary>
        /// Отправляем студентов певцов петь
        /// </summary>
        public void Sing()
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] is ISinger)
                    ((ISinger)students[i]).Sing();
            }
        }
    }
}
