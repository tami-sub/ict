using System;
namespace control
{
    public class PublicPath : StrategyPath
    {
        public PublicPath()
        {
            Type = "Public transport directions";
        }

        public override string ToString()
        {
            return Type;
        }

        public override string GetPath()
        {
            return "════════█+█▒▒▒▒▒█╬╬█╬╬█╬╬\n" +
                "════════██+█▒▒▒▒█╬╬█╬╬█╬╬\n" +
                "═══════░██+██████████████\n" +
                "═══════██+██▀▒▒▒█╬╬█╬╬█╬╬\n" +
                "══════░█+█▒▒▒▒▒▒█╬╬█╬╬█╬█\n" +
                "══════█+██▒▒▒▒▒▒█╬╬█╬╬███\n" +
                "═════█+██▒▒▒▒▒▒▒█╬█████╬╬\n" +
                "════█+██▒▒▒▒▒▒▒▒██╬█╬╬█╬╬\n" +
                "═══█+██▒▒▒▒▒▒▄███╬╬█╬╬█╬╬\n" +
                "═══█+█████████▀═█╬╬█╬╬█╬╬\n" +
                "═█+███══════════█╬╬█╬╬█╬╬\n" +
                "█+███═══════════█╬╬█╬╬█╬╬\n" +
                "████════════════█╬╬█╬╬█╬╬\n" +
                "██══════════════█╬╬█╬╬█╬╬";
        }
    }
}
