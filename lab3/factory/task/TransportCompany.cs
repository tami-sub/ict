using System;
namespace task
{
    abstract class TransportCompany
    {
        public string Name { get; set; }

        public TransportCompany(string n)
        {
            Name = n;
        }

        public override string ToString()
        {
            return Name;
        }

        // фабричный метод
        abstract public TransportService Create(string n, int k);
    }
}