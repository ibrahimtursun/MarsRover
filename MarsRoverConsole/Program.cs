using System;
using System.Collections.Generic;
using MarsRoverLibrary;

namespace MarsRoverConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test Input:
            //5 5
            //1 2 N
            //LMLMLMLMM
            //3 3 E
            //MMRMMRMRRM
            //Expected Output:
            //1 3 N
            //5 1 E

            string surf = Console.ReadLine(); //5 5
            ISurface surface = SurfaceFactory.CreateSurface(surf);

            string rov = Console.ReadLine(); //1 2 N
            IRover rover = RoverFactory.CreateRover(rov, surface);

            string moves = Console.ReadLine(); //LMLMLMLMM
            List<string> movements = MovementFactory.CreateMovement(moves);

            foreach (var movement in movements)
            {
                rover.Move(movement);
            }

            string rov2 = Console.ReadLine(); //3 3 E
            IRover rover2 = RoverFactory.CreateRover(rov2, surface);

            string moves2 = Console.ReadLine(); //MMRMMRMRRM
            List<string> movements2 = MovementFactory.CreateMovement(moves2);

            foreach (var movement2 in movements2)
            {
                rover2.Move(movement2);
            }

            Console.WriteLine($"{rover.X} {rover.Y} {rover.Direction}");
            Console.WriteLine($"{rover2.X} {rover2.Y} {rover2.Direction}");
            Console.ReadLine();
        }
    }
}

