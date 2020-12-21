using System;
using System.Collections.Generic;
using System.Text;

namespace Benders
{
    abstract class Human
    {
        public string Name { get; set; }
        public double Power { get; set; }
        public double Defense { get; set; }
        public double Bonus { get; set; }

        public Human(string name, double power, double def, double bonus)
        {
            Name = name;
            Power = power;
            Defense = def;
            Bonus = bonus;
        }

        public void TotalPower()
        {
            double coefficient = RndCoefficient();
            double total = CalcTotalPower(Bonus, coefficient);
            Print(total, Defense);
        }

        private double CalcTotalPower(double bonus, double coefficient)
        {
            return (Power + bonus) * coefficient;
        }

        private double RndCoefficient()
        {
            Random rand = new Random();
            return rand.Next(1, 5);
        }

        private void Print(double total, double def)
        {
            Console.WriteLine($"Сила мага с именем {Name} равна {total}\n");
            Console.WriteLine($"Зашита мага с именем {Name} равна {def}\n");
        }

        public abstract void Rank(double totaldam, double def);
    }

}