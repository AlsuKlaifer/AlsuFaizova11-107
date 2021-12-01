using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.IStudent
{
    class PainterStudent : Student, IPainter, ITheory
    {
        public PainterStudent(string s) : base(s)
        { }
        public void ApplyPaint()
        {
            Console.WriteLine("Painter Student applies a paints.");
        }

        public void MakeSketch()
        {
            Console.WriteLine("Painter Student makes a sketch.");
        }

        public override void Study()
        {
            StudyTheory();
            MakeSketch();
            ApplyPaint();
        }

        public void StudyTheory()
        {
            Console.WriteLine("Painter Student studys a theory.");
        }
    }
}
