﻿using System;

namespace Tasks12Library
{
    public class Validation
    {
        private bool isDouble;
        private double validatedValue;

        public Validation(string inputValue)
        {
            isDouble = double.TryParse(inputValue, out validatedValue);
        }

        public double ValidatedValue
        {
            get
            {
                return validatedValue;
            }
            private set
            {
                validatedValue = value;
            }
        }

        public void GetValidatedValue()
        {
            for (int i = 0; i < 3; i++)
            {
                if (isDouble && ValidatedValue > 0)
                {
                    break;
                }
                else if (i == 2)
                {
                    Random randomNumber = new Random();
                    ValidatedValue = Convert.ToDouble(randomNumber.Next(5, 51) / 10.0);
                }
                else
                {
                    Console.WriteLine("Please enter a positive numeric value: ");
                    isDouble = double.TryParse(Console.ReadLine(), out validatedValue);
                }
            }
        }
    }
}