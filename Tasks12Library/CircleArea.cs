using System;

namespace Tasks12Library
{
    public class Circle
    {
        private bool isDouble;
        private double radius;
        public double area;

        public Circle(string inputRadius)
        {
            isDouble = double.TryParse(inputRadius, out radius);
        }

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
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
                if (isDouble && Radius >= 0)
                {
                    Area = Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
                    Console.WriteLine($"Radius: {Radius}, Circle Area: {Area}\n");
                    break;
                }
                else if (i == 2)
                {
                    Random RandomNumber = new Random();
                    Radius = Convert.ToDouble(RandomNumber.Next(5, 51) / 10.0);
                    Area = Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
                    Console.WriteLine($"Radius: {Radius}, Circle Area: {Area}\n");
                }
                else
                {
                    Console.WriteLine("Please enter a positive numeric Radius\nEnter Radius: ");
                    isDouble = double.TryParse(Console.ReadLine(), out radius);
                }
            }
        }
    }
}