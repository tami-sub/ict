using System;
namespace control
{
    public class FahrenheitReader 
    {
        Random temp;

        public FahrenheitReader()
        {
            temp = new Random();
        }

        public double GetTemperature()
        {
            return temp.Next(72) + 14;
        }
    }
}
