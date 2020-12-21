using System;
namespace task
{
    class TaxiTransCom : TransportCompany
    {
        public TaxiTransCom(string name) : base(name)
        { }

        public override TransportService Create(string n, int c)
        {
            return new TaxiServices(Name, c);
        }
    }
}
