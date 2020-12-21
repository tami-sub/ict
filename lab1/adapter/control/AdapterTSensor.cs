using System;
namespace control
{
    public class AdapterTSensor : ISensor
    {
        FahrenheitReader fah;

        public AdapterTSensor(FahrenheitReader reader)
        {
            fah = reader;
        }

        public double GetData()
        {
            return Math.Round((fah.GetTemperature()-32)*5/9);
        }
    }
}
