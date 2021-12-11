using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.IStudent
{
    class PainterStudent : Student, IPainter
    {
        public PainterStudent(string s) : base(s)
        { }
        void IPainter.ApplyPaint()
        {
            Console.WriteLine("Painter Student applies a paints.");
        }

        void IPainter.MakeSketch()
        {
            Console.WriteLine("Painter Student makes a sketch.");
        }

        public override void Study()
        {
            StudyTheory();
            ((IPainter)this).MakeSketch();
            ((IPainter)this).ApplyPaint();
        }

        public override void StudyTheory()
        {
            Console.WriteLine("Painter Student studys a theory.");
        }
    }
}
