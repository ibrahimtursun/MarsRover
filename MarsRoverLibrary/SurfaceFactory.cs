using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverLibrary
{
    public class SurfaceFactory
    {
        public static ISurface CreateSurface(string Coordinates)
        {
            Validation.ValidateCoordinates(Coordinates);
            string[] coordinates = Coordinates.Split(' ');
            int x = Convert.ToInt32(coordinates[0]);
            int y = Convert.ToInt32(coordinates[1]);

            return new Surface(x, y);
        }
    }
}
