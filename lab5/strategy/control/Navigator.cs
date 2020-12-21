using System;
namespace control
{
    public class Navigator
    {
        StrategyPath strategy;

        string map = "════════███▒▒▒▒▒█╬╬█╬╬█╬╬\n" +
                "════════████▒▒▒▒█╬╬█╬╬█╬╬\n" +
                "═══════░█████████████████\n" +
                "═══════█████▀▒▒▒█╬╬█╬╬█╬╬\n" +
                "══════░███▒▒▒▒▒▒█╬╬█╬╬█╬█\n" +
                "══════████▒▒▒▒▒▒█╬╬█╬╬███\n" +
                "═════████▒▒▒▒▒▒▒█╬█████╬╬\n" +
                "════████▒▒▒▒▒▒▒▒██╬█╬╬█╬╬\n" +
                "═══████▒▒▒▒▒▒▄███╬╬█╬╬█╬╬\n" +
                "═══███████████▀═█╬╬█╬╬█╬╬\n" +
                "═█████══════════█╬╬█╬╬█╬╬\n" +
                "█+███═══════════█╬╬█╬╬█╬╬\n" +
                "████════════════█╬╬█╬╬█╬╬\n" +
                "██══════════════█╬╬█╬╬█╬╬";

        public Navigator(StrategyPath strategy)
        {
            this.strategy = strategy;
        }

        public void ShowMap()
        {
            Console.WriteLine(strategy);
            Console.WriteLine(map);
        }
        public void GetPath()
        {
            map = strategy.GetPath();
        }
    }
}
