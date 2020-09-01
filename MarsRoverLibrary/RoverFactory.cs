using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverLibrary
{
    public class RoverFactory
    {
        public static IRover CreateRover(string CoordinatesAndDirection, ISurface surface)
        {
            Validation.ValidateCoordinatesAndDirection(CoordinatesAndDirection);
            string[] arr = CoordinatesAndDirection.Split(' ');
            int x = Convert.ToInt32(arr[0]);
            int y = Convert.ToInt32(arr[1]);
            string direction = arr[2];

            return new Rover(x, y, direction, surface);
        }
    }
}
