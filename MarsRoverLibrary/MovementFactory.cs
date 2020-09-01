using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRoverLibrary
{
    public class MovementFactory
    {
        public static List<string> CreateMovement(string Movements)
        {
            Movements = Movements.Replace(" ", "");
            return Movements.ToCharArray().Select(i => i.ToString()).ToList();
        }
    }
}
