using System;

namespace Tasks12Library
{
    public class InsertShape
    {
        public double CircleArea;
        public double SquareArea;

        public InsertShape(double circleArea, double squareArea)
        {
            CircleArea = circleArea;
            SquareArea = squareArea;
        }

        public void PrintResult()
        {
            if (Math.Sqrt(CircleArea / Math.PI) <= Math.Sqrt(SquareArea) / 2)
            {
                Console.WriteLine($"It is possible to put the circle into the square");
            }
            else if (Math.Sqrt(CircleArea / Math.PI) >= Math.Sqrt(SquareArea / 2))
            {
                Console.WriteLine($"It is possible to put the square into the circle");
            }
            else
            {
                Console.WriteLine($"It is impossible to put the circle into the Square or the square into the Circle");
            }
        }
    }
}
