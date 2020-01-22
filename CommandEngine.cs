using OOP_Kata.Commands;
using OOP_Kata.Factories;
using System.Collections.Generic;

namespace OOP_Kata
{
    public static class CommandEngine
    {
        public static IEnumerable<ICommand> NextCommand()
        {
            while (true) yield return CommandHandlerFactory.Create(Output.ReadLine());
        }
    }
}
