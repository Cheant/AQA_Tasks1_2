using System;

namespace Tasks12Library
{
    public class Circle
    {
        private double _radius;
        private double _area;

        public Circle(double inputRadius)
        {
            Radius = inputRadius;
            Area = CalculateCircleArea(Radius);
        }

        public double Radius
        {
            get
            {
                return _radius;
            }
            private set
            {
                _radius = value;
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

        private double CalculateCircleArea(double radius)
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
        }

        public void PrintRadiusCircleArea()
        {
            Console.WriteLine($"Radius: {Radius}, Circle Area: {Area}\n");
        }
    }
}