using System;
namespace control
{
    public abstract class StrategyPath
    {
        public string Type { get; set; }

        public abstract string GetPath();
    }

}
