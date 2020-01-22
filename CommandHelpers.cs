using OOP_Kata.Commands;

namespace OOP_Kata
{
    static class CommandHelpers
    {
        public static ICommand ExecuteCommand(this ICommand command)
        {
            command.Execute();
            return command;
        }
    }
}
