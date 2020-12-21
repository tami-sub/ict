using System;
namespace task
{
    class DrunkServices : TransportService
    {
        public int Speed { get; set; }

        public DrunkServices(string name, int spd) : base(name)
        {
            Speed = spd;
        }

        public override double CostTransportation(double distance)
        {
            return distance * Speed * 0.75;
        }

        public override string ToString()
        {
            string s = String.Format("Фирма {0}, доставка водителя {1}", Name, Speed);
            return s;
        }
    }
}
