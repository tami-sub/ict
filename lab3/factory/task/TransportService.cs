using System;
namespace task
{
    abstract class TransportService
    {
        public string Name { get; set; }

        public TransportService(string name)
        {
            Name = name;
        }

        abstract public double CostTransportation(double distance);

    }
}