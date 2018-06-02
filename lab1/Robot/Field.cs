using System;

namespace Robot_Program
{
    /// <summary>
    /// Field has matrix with references on Point, that should be achieve !
    /// If reference has NULL, it`s only road
    /// </summary>
    class Field
    {
        private Point[][] matrix;
        private int valueOfPoints;
        private Random generator;
        private readonly int N;
        private readonly int M;

        public Field(int n, int m)
        {
            matrix = new Point[n][];
            for (int i = 0; i < n; i++)
            {
               matrix[i] = new Point[m];
            }
            N = n;
            M = m;

            generator = new Random();
        }

        /* Probably for a litle fields it can be solv recursively
         *      Check(Robot rob)
         *          while(pointCounter != valueOfPoints)
         *              GoToPoint(rob))
         *              ChangeDirection(rob)       <-- in this func we make 2 copies for two turns and 
         *                                             call for each Check again. 
         */

        /// <summary>
        /// Main method of program. Calculate possibility to achieve all generated points
        /// </summary>
        /// <param name="rob">Robot with start point and direction, which should achieve all points</param>
        /// <returns>return true if it possible or false in all another conditions</returns>
        public bool Check(Robot rob)
        {
            int pointCounter = 0;
            int x = rob.Position.x;
            int y = rob.Position.y;

            if (matrix[y][x] != null)
            {
                pointCounter++;
                matrix[y][x] = null;
            }

            while(pointCounter != valueOfPoints)
            {
                if (GoToPoint(rob))
                {
                    pointCounter++;
                    x = rob.Position.x;
                    y = rob.Position.y;
                    matrix[y][x] = null;
                    ChangeDirection(rob);
                    rob.ShowInfo();
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        public bool ChangeDirection(Robot r)                    // return false if robot can`t find direction with special points
        {
            Robot RightRobot = r.DeepCopy();
            RightRobot.TurnRight();
            if (GoToPoint(RightRobot))
            {
                r.Direction = RightRobot.Direction;
                return true;
            }

            Robot LeftRobot = r.DeepCopy();
            LeftRobot.TurnLeft();
            if (GoToPoint(LeftRobot))
            {
                r.Direction = LeftRobot.Direction;
                return true;
            }

            return false;
        }

        private bool GoToPoint(Robot rob)
        {
            while (true)
            {
                rob.MakeStep();
                int x = rob.Position.x;
                int y = rob.Position.y;

                if (y >= N || x >= M || y < 0 || x < 0)
                    return false;

                if (matrix[y][x] != null)
                {
                    return true;
                }
            }
        }

        public Robot GenerateRobot(Direction d = Direction.Default)
        {
            int y = generator.Next(matrix.Length);
            int x = generator.Next(matrix[y].Length);

            return new Robot(new Point(x, y), d);
        }

        public void GeneratePoints(int value)
        {
            valueOfPoints = value;

            for(int i = 0; i < value; i++)
            {
                int y = generator.Next(matrix.Length);
                int x = generator.Next(matrix[y].Length);

                if (matrix[y][x] == null)
                {
                    matrix[y][x] = new Point(x, y);
                }
                else
                {
                    i--;
                }
            }
        }

        public void Output()
        {
            for(int i = 0; i < matrix.Length; i++)
            {
                if(i == 0)                                      // write OX
                {
                    Console.Write("\t");

                    for (int j = 0; j < matrix[i].Length; j++)
                        Console.Write(j + "\t");

                    Console.WriteLine();
                } 
                for(int j = 0; j < matrix[i].Length; j++)
                {
                    if (j == 0)                                 // write OY
                        Console.Write(i + "\t");

                    if(matrix[i][j] != null)
                    {
                        Console.Write("1\t");
                    }
                    else
                    {
                        Console.Write("0\t");
                    }
                }
                Console.WriteLine();
            }
        }

        public void Output(Robot r)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                if (i == 0)                                      // write OX
                {
                    Console.Write("\t");

                    for (int j = 0; j < matrix[i].Length; j++)
                        Console.Write(j + "\t");

                    Console.WriteLine();
                }
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (j == 0)                                 // write OY
                        Console.Write(i + "\t");

                    if(r.Position.x == j && r.Position.y == i)
                    {
                        Console.Write("R\t");
                        continue;
                    }

                    if (matrix[i][j] != null)
                    {
                        Console.Write("1\t");
                    }
                    else
                    {
                        Console.Write("0\t");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
