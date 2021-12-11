using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Dots
{
    class Coordinate2D
    {
        protected int cordX { set; get; }
        protected int cordY { set; get; }
        private void ShowCord()
        {
            Console.WriteLine($"X:{cordX}, Y:{cordY}");
        }

        public Coordinate2D(int cordX, int cordY)
        {
            this.cordX = cordX;
            this.cordY = cordY;
        }
    }
}
