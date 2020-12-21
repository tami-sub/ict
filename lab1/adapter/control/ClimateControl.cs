using System;
namespace control
{
    public class ClimateControl
    {
        public string Location { get; set; }

        public ClimateControl(string location)
        {
            Location = location;
        }

        public override string ToString()
        {
            return Location;
        }

        public string GetTemperature(ISensor sensor)
        {
            return sensor.GetData() + "°C";
        }
    }
}
