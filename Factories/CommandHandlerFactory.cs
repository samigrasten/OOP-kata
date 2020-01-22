using OOP_Kata.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using ICommand = OOP_Kata.Commands.ICommand;

namespace OOP_Kata.Factories
{
    public class CommandHandlerFactory
    {
        internal static ICommand Create(string command)
        {
            var parameters = new Parameters(command);
            return Commands.ContainsKey(parameters.Command)
                           ? Commands[parameters.Command](parameters)
                           : new VoidCommand();
        }

        private static readonly Dictionary<string, Func<Parameters, ICommand>> Commands = new Dictionary<string, Func<Parameters, ICommand>>
        {
            ["PRINT"] = args => new PrintCommand(new Output(), args),
            ["QUIT"] = args => new QuitCommand(),
        };
    }
}