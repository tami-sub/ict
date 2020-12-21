using System;

namespace control
{
    class Program
    {
        static void Main(string[] args)
        {
            StrategyPath strategy = new CarPath();
            Navigator navigator = new Navigator(strategy);

            while (true)
            {
                navigator.ShowMap();
                Console.WriteLine("Get directions by:\n0 — Car\n1 — Foot" +
                    "\n2 — Bike\n3 — Public transport\n4 — Through famous sights");

                int dir = Int32.Parse(Console.ReadLine());
                switch (dir)
                {
                    case 0:
                        strategy = new CarPath();
                        break;

                    case 1:
                        strategy = new WalkPath();
                        break;

                    case 2:
                        strategy = new CyclePath();
                        break;

                    case 3:
                        strategy = new PublicPath();
                        break;

                    case 4:
                        strategy = new SightPath();
                        break;
                }
                navigator.GetPath();
            }
        }
    }
}
