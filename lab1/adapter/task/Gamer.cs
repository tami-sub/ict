using System;
namespace task
{
    public class Gamer
    {
        public string Name { get; set; }

        public Gamer(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }

        public int SeansGame(IGame ig)
        {
            return ig.Brosok();
        }
    }
}
