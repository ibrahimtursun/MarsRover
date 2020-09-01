using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverLibrary
{
    public class Rover : IRover
    {
        public string Direction { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public ISurface Surface { get; set; }
        public Rover(int x, int y, string direction, ISurface surface)
        {
            this.X = x;
            this.Y = y;
            this.Direction = direction;
            this.Surface = surface;
        }

        public void Move(string MovementCode)
        {
            switch (MovementCode.ToUpper())
            {
                case "M":
                    MoveStraight();
                    break;
                case "L":
                    TurnLeft();
                    break;
                case "R":
                    TurnRight();
                    break;
                default:
                    dontMove();
                    break;
            }
        }

        private void MoveStraight()
        {
            switch (this.Direction)
            {
                case Directions.North:
                    this.Y += 1;
                    break;

                case Directions.East:
                    this.X += 1;
                    break;

                case Directions.South:
                    this.Y -= 1;
                    break;

                case Directions.West:
                    this.X -= 1;
                    break;
            }

            checkLastPosition();
        }

        private void TurnRight()
        {
            switch (this.Direction)
            {
                case Directions.North:
                    this.Direction = Directions.East;
                    break;

                case Directions.East:
                    this.Direction = Directions.South;
                    break;

                case Directions.South:
                    this.Direction = Directions.West;
                    break;

                case Directions.West:
                    this.Direction = Directions.North;
                    break;
            }
        }

        private void TurnLeft()
        {
            switch (this.Direction)
            {
                case Directions.North:
                    this.Direction = Directions.West;
                    break;

                case Directions.West:
                    this.Direction = Directions.South;
                    break;

                case Directions.South:
                    this.Direction = Directions.East;
                    break;

                case Directions.East:
                    this.Direction = Directions.North;
                    break;
            }
        }

        private void dontMove()
        {
            throw new ArgumentException("Movement has invalid movement characters. Example (L, R, M)");
        }

        private void checkLastPosition()
        {
            if (X < 0 || X > Surface.X)
            {
                throw new ArgumentException("The rover has gone out of range");
            }
            else if (Y < 0 || Y > Surface.Y)
            {
                throw new ArgumentException("The rover has gone out of range");
            }
        }
    }
}
