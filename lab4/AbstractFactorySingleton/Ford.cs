using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactorySingleton
{
    class FordFactory : CarFactory
    {

        static Lazy<FordFactory> myFordFactory = new Lazy<FordFactory>(() => new FordFactory());

        public static FordFactory MyFordFactory
        {
            get
            {
                return myFordFactory.Value;
            }
        }


        public override AbstractCar CreateCar()
        {
            return new FordCar("Форд");
        }
        public override AbstractEngine CreateEngine()
        {
            return new FordEngine();
        }

        public override AbstracBodyType CreateBodyType()
        {
            return new FordBodyType();
        }
    }

    class FordCar : AbstractCar
    {
        public FordCar(string name)
        {
            Name = name;
        }
        public override int MaxSpeed(AbstractEngine engine)
        {
            int ms = engine.max_speed;
            return ms;
        }
        public override string ToString()
        {
            return "Автомобиль " + Name;

        }

        public override string Bodytype(AbstracBodyType body)
        {
            return body.body_type;
        }
    }

class FordEngine : AbstractEngine
    {
        public FordEngine()
        {
            max_speed = 220;
        }
    }
}

class FordBodyType : AbstracBodyType
{
    public FordBodyType()
    {
        body_type = "Универсал";
    }
}

