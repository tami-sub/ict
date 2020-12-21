using System;
namespace task
{
    class DrunkTransCom : TransportCompany
    {
        public DrunkTransCom(string name) : base(name)
        { }

        public override TransportService Create(string n, int s)
        {
            return new DrunkServices(Name, s);
        }
    }
}
