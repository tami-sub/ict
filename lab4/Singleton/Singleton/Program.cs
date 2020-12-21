using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Log lg = new Log();
            lg.LogExecution("Метод Main()");
            double op = Operation.Run('-', 35);
            op = Operation.Run('+', 30);
        }
    }
}
