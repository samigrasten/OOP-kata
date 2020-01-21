using OOP_Kata.Commands;

namespace OOP_Kata
{
    static class CommandHelpers
    {
        public static (ICommand command, string[] args) ExecuteCommand(this (ICommand command, string[] args) command)
        {
            command.command.Execute(command.args);
            return command;
        }
    }
}
