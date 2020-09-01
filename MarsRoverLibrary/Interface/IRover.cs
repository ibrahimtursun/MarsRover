using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverLibrary
{
    public interface IRover : ISurface
    {
        public string Direction { get; set; }
        public ISurface Surface { get; set; }
        public void Move(string MovementCode);
    }
}
