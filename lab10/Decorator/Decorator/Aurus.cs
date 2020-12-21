using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class Aurus : AutoBase
    {
        public Aurus(string name, string info, double costbase)
        {
            Name = name;
            Description = info;
            CostBase = costbase;
        }
        public override double GetCost()
        {
            return CostBase * 4;
        }
    }
}
