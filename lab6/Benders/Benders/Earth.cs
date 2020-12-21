using System;
using System.Collections.Generic;
using System.Text;

namespace Benders
{
    class Earth : Human
    {
        public Earth(string name, double power, double def, double bonus) : base(name, power, def, bonus) { }

        public override void Rank(double totaldam, double def)
        {
            double SumRank = (totaldam - def)*0.3;
            Console.WriteLine("Изначальный ранг мага равен {0}",SumRank);
        }
    }
}
