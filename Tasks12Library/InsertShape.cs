using System;

namespace Tasks12Library
{
    public class InsertShape
    {
        public double circleArea;
        public double squareArea;

        public InsertShape(double circlearea, double squarearea)
        {
            circleArea = circlearea;
            squareArea = squarearea;
        }

        public void PrintResult()
        {
            if (Math.Sqrt(circleArea / Math.PI) < Math.Sqrt(squareArea) / 2)
            {
                Console.WriteLine($"It is possible to put the circle into the square");
            }
            else if (Math.Sqrt(circleArea / Math.PI) > Math.Sqrt(squareArea / 2))
            {
                Console.WriteLine($"It is possible to put the square into the circle");
            }
            else
            {
                Console.WriteLine($"It is impossible to put the circle into the square or the square into the circle");
            }
        }
    }
}