using OOP_Kata.Commands;
using OOP_Kata.Factories;
using System;
using System.Linq;

namespace OOP_Kata
{
    class Program
    {
        static void Main(string[] args)
            => CommandEngine
                .NextCommand()
                .Select((command, arguments) => command.ExecuteCommand())
                .First(command => command.command is QuitCommand);
    }
}
