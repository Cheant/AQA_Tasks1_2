using System;

namespace Tasks12Library
{
    public class Calculation
    {
        private double parameter;
        public double Area;

        public Calculation(double inputParameter)
        {
            parameter = inputParameter;
        }

        public double InputParameter
        {
            get
            {
                return parameter;
            }
            private set
            {
                parameter = value;
            }
        }

        public double AreaResult
        {
            get
            {
                return Area;
            }
            private set
            {
                Area = value;
            }
        }

        public void CalculateCircleArea()
        {
            AreaResult = Math.Round(Math.PI * Math.Pow(InputParameter, 2), 2);
            Console.WriteLine($"Radius: {InputParameter}, Circle Area: {AreaResult}\n");
        }

        public void CalculateSquareArea()
        {
            AreaResult = Math.Round(Math.Pow(InputParameter, 2), 2);
            Console.WriteLine($"Side: {InputParameter}, Square Area: {AreaResult}\n");
        }

    }
}