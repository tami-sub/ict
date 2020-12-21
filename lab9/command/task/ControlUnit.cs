using System;
using System.Collections.Generic;

namespace task
{
    public class ControlUnit
    {
        private List<Command> commands = new List<Command>();
        private int current = 0;

        public void StoreCommand(Command command)
        {
            commands.Add(command);
        }

        public void ExecuteCommand()
        {
            commands[current].Execute();
            current++;
        }

        public void Undo()
        {
            commands[current - 1].UnExecute();
        }

        public void Redo()
        {
            commands[current - 1].Execute();
        }

        //Override
        public void Undo(int times)
        {
            for (; times>0; times--)
                commands[current - 1].UnExecute();
        }

        public void Redo(int times)
        {
            for (; times > 0; times--)
                commands[current - 1].Execute();
        }
    }
}
