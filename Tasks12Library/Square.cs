using System;

namespace Tasks12Library
{
    public class Square
    {
        public double area;
        private double side;

        public Square(double inputSide)
        {
            side = inputSide;
        }

        public double Side
        {
            get
            {
                return side;
            }
            private set
            {
                side = value;
            }
        }

        public double Area
        {
            get
            {
                return Math.Round(Math.Pow(Side, 2), 2);
            }
        }

        public void PrintSquareArea()
        {
            Console.WriteLine($"Side: {Side}, Square Area: {Area}\n");
        }
    }
}