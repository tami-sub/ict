using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class AudioSystem : DecoratorOptions
    {
        public AudioSystem(AutoBase p, string t) : base(p, t)
        {
            AutoProperty = p;
            Name = p.Name + ". Высокочастотный";
            Description = p.Description + ". " + this.Title + ". Улучшенная аудиосистема с усилителями";
        }
        public override double GetCost()
        {
            return AutoProperty.GetCost() + 40;
        }
    }
}
