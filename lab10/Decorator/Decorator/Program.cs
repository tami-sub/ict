using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Renault reno = new Renault("Рено", "Renault LOGAN Active", 499.0);
            Print(reno);

            AutoBase myreno = new MediaNAV(reno, "Навигация");
            Print(myreno);

            AutoBase newmyReno = new SystemSecurity(new MediaNAV(reno, "Навигация"),
            "Безопасность");
            Print(newmyReno);


            Aurus aurus = new Aurus("Аурус", "AURUS Senat", 40499.0);
            Print(aurus);

            AutoBase myaurus = new AudioSystem(aurus, "Аудиосистема");
            Print(myaurus);

            AutoBase nemyaurus = new Сonditioner(aurus, "Кондиционер");
            Print(nemyaurus);
        }
        private static void Print(AutoBase av)
        {
            Console.WriteLine(av.ToString());
        }
    }
}
