using System;

namespace Tasks12Library
{
    public class Square
    {
        private double _side;
        private double _area;

        public Square(double inputSide)
        {
            Side = inputSide;
            Area = CalculateSquareArea(Side);
        }

        public double Side
        {
            get
            {
                return _side;
            }
            private set
            {
                _side = value;
            }
        }

        public double Area
        {
            get
            {
                return _area;
            }
            private set
            {
                _area = value;
            }
        }

        private double CalculateSquareArea(double side)
        {
            return Math.Round(Math.Pow(Side, 2), 2);
        }

        public void PrintSideSquareArea()
        {
            Console.WriteLine($"Side: {Side}, Square Area: {Area}{Environment.NewLine}");
        }
    }
}