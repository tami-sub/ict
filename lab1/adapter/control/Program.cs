using System;

namespace control
{
    class Program
    {
        static void Main(string[] args)
        {
            ClimateControl cc = new ClimateControl("Garage");
            TemperatureSensor ts = new TemperatureSensor();

            Console.WriteLine("It is {0} in the {1} right now",
                cc.GetTemperature(ts), cc.ToString());

            FahrenheitReader fh = new FahrenheitReader();
            AdapterTSensor ats = new AdapterTSensor(fh);

            Console.WriteLine("It is {0} in the {1} right now",
                cc.GetTemperature(ats), cc.ToString());
        }
    }
}
