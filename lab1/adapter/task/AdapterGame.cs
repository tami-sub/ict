using System;
namespace task
{
    public class AdapterGame : IGame
    {
        Monet mon;

        public AdapterGame(Monet mt)
        {
            mon = mt;
        }

        public int Brosok()
        {
            return mon.BrosokM();
        }
    }
}
