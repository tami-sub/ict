using System;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            double result = 0;
            result = calculator.Add(5);
            Console.WriteLine(result);

            result = calculator.Add(4);
            Console.WriteLine(result);

            result = calculator.Multiply(3);
            Console.WriteLine(result);

            result = calculator.Divide(9);
            Console.WriteLine(result);

            result = calculator.Subtract(2);
            Console.WriteLine(result);

            result = calculator.Redo();
            Console.WriteLine(result);

            result = calculator.Undo(2);
            Console.WriteLine(result);
        }
    }
}
