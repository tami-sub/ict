using System;
namespace task
{
    public class Monet
    {
        Random r;

        public Monet()
        {
            r = new Random();
        }

        public int BrosokM()
        {
            //Random number 1 or 2
            int res = r.Next(2) + 1;
            return res;
        }
    }
}
