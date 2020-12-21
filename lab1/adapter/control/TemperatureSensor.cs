using System;
namespace control
{
    public class TemperatureSensor : ISensor
    {
        Random temp;

        public TemperatureSensor()
        {
            temp = new Random();
        }

        public double GetData()
        {
            return temp.Next(40)-10;
        }
    }
}
