using System;

namespace task
{
    class Program
    {
        private static void Print(TransportService compTax, double distg)
        {
            Console.WriteLine("Компания {0}, расстояние {1}, стоимость: {2}",
            compTax.ToString(), distg, compTax.CostTransportation(distg));
        }

        static void Main(string[] args)
        {
            TransportCompany tCom = new TaxiTransCom("Служба такси");
            TransportService compService = tCom.Create("Такси", 1);
            double dist = 15.5;
            Print(compService, dist);

            TransportCompany gCom = new ShipTransCom("Служба перевозок");
            compService = gCom.Create("Грузоперевозки", 2);

            double distg = 150.5;
            Print(compService, distg);

            //Control task
            TransportCompany dCom = new DrunkTransCom("Пьяный водитель");
            compService = dCom.Create("Достака водителей", 2);

            double distd = 100;
            Print(compService, distd);
        }
    }
}
