using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class Сonditioner : DecoratorOptions
    {
        public Сonditioner(AutoBase p, string t) : base(p, t)
        {
            AutoProperty = p;
            Name = p.Name + ". С охлаждением";
            Description = p.Description + ". " + this.Title + ". Улучшенный кодиционер";
        }
        public override double GetCost()
        {
            return AutoProperty.GetCost() + 540;
        }
    }
}
