using System;
namespace task
{
    public class Kost : IGame
    {
        Random r;

        public Kost()
        {
            r = new Random();
        }
        public int Brosok()
        {
            //Random number 1 to 6
            int res = r.Next(6) + 1;
            return res;
        }
    }
}
