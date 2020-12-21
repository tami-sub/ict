using System;

namespace Benders
{
    class Program
    {
        static void Main(string[] args)
        {
            Earth ror = new Earth("nok", 3000, 500, 60);
            ror.TotalPower();
            ror.ToString();
            ror.Rank(3000, 500);
        }
    }
}
