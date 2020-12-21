using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    abstract class CarFactory
    {
        public abstract AbstractCar CreateCar();
        public abstract AbstractEngine CreateEngine();
        public abstract AbstracBodyType CreateBodyType();
    }
}

abstract class AbstractCar
{
    public string Name { get; set; }
    public abstract int MaxSpeed(AbstractEngine engine);
    public abstract string Bodytype(AbstracBodyType body);
}

abstract class AbstractEngine
{
    public int max_speed { get; set; }
}

abstract class AbstracBodyType
{
    public string body_type {get; set;}
}