using System;
using System.Collections.Generic;

namespace Robot_Program
{
    class Robot
    {
        Point startPosition;
        Point currentPosition;
        Direction direction;
        //List<Point> way;

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
            set
            {
                direction = value;
            }
        }

        public Robot():
            this(new Point(0, 0), Direction.Default) { }

        public Robot(Point p, Direction d = Direction.Default)
        {
            startPosition = p;
            currentPosition = startPosition;
            //way.Add(currentPosition);
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

        public void TurnRight()                     // + Pi/2
        {
            direction += 90;

            if((int)direction == 360)
            {
                direction = Direction.Right;
            }
        }

        public void TurnLeft()                      // - Pi/2
        {
            switch(direction)
            {
                case Direction.Right:
                    direction = Direction.Up;
                    break;
                case Direction.Down:
                    direction = Direction.Right;
                    break;
                case Direction.Left:
                    direction = Direction.Down;
                    break;
                case Direction.Up:
                    direction = Direction.Left;
                    break;
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Robot postion ({currentPosition.x},{currentPosition.y}), direction ({direction.ToString()})");
        }

        public Robot DeepCopy()
        {
            Robot tmp = new Robot(startPosition.DeepCopy(), direction);
            tmp.currentPosition = this.currentPosition.DeepCopy();

            return tmp;
        }
    }
}
