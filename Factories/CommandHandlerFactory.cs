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
        internal static (ICommand command, string[] args) Create(string command)
        {
            var args = command.Split(" ");
            var key = args[0].ToUpper();
            return (_commands.ContainsKey(key)
                           ? _commands[key]
                           : new VoidCommand(), 
                        args.Skip(1).ToArray());
        }

        private static Dictionary<string, ICommand> _commands = new Dictionary<string, ICommand>
        {
            ["PRINT"] = new PrintCommand(new Output()),
            ["QUIT"] = new QuitCommand(),
        };
    }
}