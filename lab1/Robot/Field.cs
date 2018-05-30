using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        Random generator;

        public Field(int n, int m)
        {
           matrix = new Point[n][];
           for (int i = 0; i < n; i++)
            {
                matrix[i] = new Point[m];
            }

            generator = new Random();
        }

        public bool Check(Point startPosition, Direction startDirection)
        {

            return true;
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
                        Console.Write(j + 1 + "\t");

                    Console.WriteLine();
                } 
                for(int j = 0; j < matrix[i].Length; j++)
                {
                    if (j == 0)                                 // write OY
                        Console.Write(i + 1 + "\t");

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
    }
}
