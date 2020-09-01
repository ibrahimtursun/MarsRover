using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverLibrary
{
    public class Surface : ISurface
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Surface(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
