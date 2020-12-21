using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactorySingleton
{
    class AudiFactory : CarFactory
    {

        static Lazy<AudiFactory> Myaudi = new Lazy<AudiFactory>(() => new AudiFactory());

        public static AudiFactory MyAudiFactory
        {
            get
            {
                return Myaudi.Value;
            }
        }
        
        public override AbstractCar CreateCar()
        {
            return new AudiCar("Ауди");
        }
        public override AbstractEngine CreateEngine()
        {
            return new AudiEngine();
        }

        public override AbstracBodyType CreateBodyType()
        {
            return new AudiBodyType();
        }
    }

    class AudiCar : AbstractCar
    {
        public AudiCar(string name)
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

    class AudiEngine : AbstractEngine
    {
        public AudiEngine()
        {
            max_speed = 240;
        }
    }

    class AudiBodyType: AbstracBodyType
    {
        public AudiBodyType()
        {
            body_type = "седан";
        }
    }
}
