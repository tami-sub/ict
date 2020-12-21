using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactorySingleton
{
    class Client
    {
        private AbstractCar abstractCar;
        private AbstractEngine abstractEngine;
        private AbstracBodyType absbody;


        public Client(CarFactory car_factory)
        {
            abstractCar = car_factory.CreateCar();
            abstractEngine = car_factory.CreateEngine();
            absbody = car_factory.CreateBodyType();
        }
        public int RunMaxSpeed()
        {
            return abstractCar.MaxSpeed(abstractEngine);
        }

        public override string ToString()
        {
            return abstractCar.ToString();
        }

        public string GetBodyType()
        {
            return abstractCar.Bodytype(absbody);
        }
    }
}
