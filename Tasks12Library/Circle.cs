using System;

namespace Tasks12Library
{
    public class Circle
    {
        private double radius;
        public double area;

        public Circle(double inputRadius)
        {
            radius = inputRadius;
        }

        public double Radius
        {
            get
            {
                return radius;
            }
            private set
            {
                radius = value;
            }
        }

        public double Area
        {
            get
            {
                return Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
            }
        }

        public void PrintCircleArea()
        {
            Console.WriteLine($"Radius: {Radius}, Circle Area: {Area}\n");
        }
    }
}