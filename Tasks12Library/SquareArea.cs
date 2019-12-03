using System;

namespace Tasks12Library
{
    public class Square
    {
        private bool isDouble;
        private double side;
        public double area;

        public Square(string inputSide)
        {
            isDouble = double.TryParse(inputSide, out side);
        }

        public double Side
        {
            get
            {
                return side;
            }
            set
            {
                side = value;
            }
        }

        public double Area
        {
            get
            {
                return area;
            }
            set
            {
                area = value;
            }
        }

        public void PrintArea()
        {
            for (int i = 0; i < 3; i++)
            {
                if (isDouble && Side >= 0)
                {
                    Area = Math.Round(Math.Pow(Side, 2), 2);
                    Console.WriteLine($"Side: {Side}, Square Area: {Area}\n");
                    break;
                }
                else if (i == 2)
                {
                    Random RandomNumber = new Random();
                    Side = Convert.ToDouble(RandomNumber.Next(5, 51) / 10.0);
                    Area = Math.Round(Math.Pow(Side, 2), 2);
                    Console.WriteLine($"Side: {Side}, Square Area: {Area}\n");
                }
                else
                {
                    Console.WriteLine("Please enter a positive numeric Side\nEnter Side: ");
                    isDouble = double.TryParse(Console.ReadLine(), out side);
                }
            }
        }
    }
}