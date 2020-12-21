using System;

namespace AbstractFactorySingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory ford_car = new FordFactory();
            CarFactory audi_car = new AudiFactory();
            Client c1 = new Client(ford_car);

            Client c2 = new Client(audi_car);
            
            Console.WriteLine("Максимальная скорость {0} составляет {1} км/час, а также кузов типа {2}",
            c1.ToString(), c1.RunMaxSpeed(), c1.GetBodyType());

            Console.WriteLine("Максимальная скорость {0} составляет {1} км/час, а также кузов типа {2}",
            c2.ToString(), c2.RunMaxSpeed(), c2.GetBodyType());

          
        }
    }
}
