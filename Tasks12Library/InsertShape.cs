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
                Console.WriteLine($"It is possible to put the Circle into the Square");
            }
            else if (Math.Sqrt(CircleArea / Math.PI) >= Math.Sqrt(SquareArea / 2))
            {
                Console.WriteLine($"It is possible to put the Square into the Circle");
            }
            else
            {
                Console.WriteLine($"It is impossible to put the Circle into the Square or the Square into the Circle");
            }
        }
    }
}