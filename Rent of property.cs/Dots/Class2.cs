using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Dots
{
    class Coordinate3D : Coordinate2D
    {
        protected int cordZ { set; get; }

        public void ShowCord()
        {
            Console.WriteLine($"X:{cordX}, Y:{cordY}, Z:{cordZ}");
        }
        public Coordinate3D(int cordX, int cordY, int cordZ)
            : base(cordX, cordY)
        {
            this.cordZ = cordZ;
        }
    }
}
