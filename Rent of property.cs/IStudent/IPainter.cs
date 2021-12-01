using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.IStudent
{
    /// <summary>
    /// художник
    /// </summary>
    interface IPainter
    {
        /// <summary>
        /// сделать набросок
        /// </summary>
        void MakeSketch();
        /// <summary>
        /// нанести краски
        /// </summary>
        void ApplyPaint();
    }
}
