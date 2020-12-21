using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите три числа: f, l, h");
            int f =Convert.ToInt32( Console.ReadLine());
            int l = Convert.ToInt32(Console.ReadLine());
            int h = Convert.ToInt32(Console.ReadLine());
            Progression val = new GeomProgression(f, l, h);
            val.TemplateMethod();
        }
    }
}
