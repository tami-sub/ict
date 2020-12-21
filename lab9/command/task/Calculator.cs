using System;
namespace task
{
    class Calculator
    {
        ArithmeticUnit arithmeticUnit;
        ControlUnit controlUnit;

        public Calculator()
        {
            arithmeticUnit = new ArithmeticUnit();
            controlUnit = new ControlUnit();
        }

        private double Run(Command command)
        {
            controlUnit.StoreCommand(command);
            controlUnit.ExecuteCommand();
            return arithmeticUnit.Register;
        }

        public double Undo()
        {
            controlUnit.Undo();
            return arithmeticUnit.Register;
        }

        public double Redo()
        {
            controlUnit.Redo();
            return arithmeticUnit.Register;
        }

        //Override
        public double Undo(int times)
        {
            controlUnit.Undo(times);
            return arithmeticUnit.Register;
        }

        public double Redo(int times)
        {
            controlUnit.Redo(times);
            return arithmeticUnit.Register;
        }

        //Operations
        public double Add(double operand)
        {
            return Run(new Add(arithmeticUnit, operand));
        }

        public double Subtract(double operand)
        {
            return Run(new Subtract(arithmeticUnit, operand));
        }

        public double Multiply(double operand)
        {
            return Run(new Multiply(arithmeticUnit, operand));
        }

        public double Divide(double operand)
        {
            return Run(new Divide(arithmeticUnit, operand));
        }
    }
}

