using System;
using System.Collections.Generic;

namespace Robot_Program
{
    class Robot
    {
        Point startPosition;
        Point currentPosition;
        Direction direction;
        List<Point> way;

        public Point Position
        {
            get
            {
                return currentPosition;
            }
        }

        public Direction Direction
        {
            get
            {
                return direction;
            }
        }

        public Robot():
            this(new Point(0, 0), Direction.Default) { }

        public Robot(Point p, Direction d = Direction.Default)
        {
            startPosition = p;
            currentPosition = startPosition;
            way.Add(currentPosition);
            direction = d;
        }

        public bool MakeStep()
        {
            switch(direction)
            {
                case Direction.Right:
                    currentPosition.x++;
                    break;
                case Direction.Down:
                    currentPosition.y++;
                    break;
                case Direction.Left:
                    currentPosition.x--;
                    break;
                case Direction.Up:
                    currentPosition.y--;
                    break;
            }

            return true;
        }
    }
}
