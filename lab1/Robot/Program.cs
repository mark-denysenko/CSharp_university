using System;

namespace Robot_Program
{
    sealed class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Denysenko Mark IP-61 (variant 5)";

            Execute();

            Console.ReadKey();
        }

        static void Execute()
        {
            Console.WriteLine("Input size for field!");
            Console.Write("Input N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input M: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Field testField = new Field(n, m);

            Console.Write("Input points for generating: ");
            testField.GeneratePoints(Convert.ToInt32(Console.ReadLine()));
            testField.Output();

            Robot testRobot = MakeRobot(testField);
            testRobot.ShowInfo();
            testField.Output(testRobot);

            Console.WriteLine("Way (only special achieved points): ");
            if(testField.Check(testRobot))
            {
                Console.WriteLine("YES, robot can go across all points!");
            }
            else
            {
                Console.WriteLine("NO, robot can't go across all points!");
            }

        }

        static Point ReadPoint()
        {
            Console.Write("Input X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            return new Point(x, y);
        }

        static Direction ReadDirection()
        {
            Console.Write("Input direction (up - u, left - l, down - d, right - r): ");
            string dir = Console.ReadLine();

            switch(dir[0])
            {
                case 'U':
                case 'u':
                    return Direction.Up;
                case 'L':
                case 'l':
                    return Direction.Left;
                case 'D':
                case 'd':
                    return Direction.Down;
                case 'R':
                case 'r':
                    return Direction.Right;
            }

            return Direction.Default;
        }

        static Robot MakeRobot(Field f)
        {
            Console.WriteLine("Choose way for starting program:");
            Console.WriteLine(" 1 - Generate start point and direction");
            Console.WriteLine(" 2 - Generate start point and choose direction manually");
            Console.WriteLine(" 3 - Manually choose point and direction");

            Console.Write("Your operation: ");
            int operation = Convert.ToInt32(Console.ReadLine());

            switch(operation)
            {
                case 1:
                    Console.WriteLine("Robot generated automatically!");
                    return f.GenerateRobot();
                case 2:
                    Console.WriteLine("Point generated, input direction!");
                    return f.GenerateRobot(ReadDirection());
                case 3:
                    Console.WriteLine("Input start position and direction for robot!");
                    return new Robot(ReadPoint(), ReadDirection());
            }

            return f.GenerateRobot();
        }
    }
}
