﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    class ArithmeticProgression : Progression
    {
        public ArithmeticProgression(int f, int l, int h) : base(f, l, h) { }
        public override void Progress()
        {
            int fF = First;
            do
            {
                progList.Add(fF);
                fF = fF + H;
            }
            while (fF < Last);
        }
    }
}
