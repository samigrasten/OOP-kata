using OOP_Kata.Commands.PrintCommands;
using System.Collections.Generic;
using System.Linq;

namespace OOP_Kata.Commands
{
    public class PrintCommand : ICommand
    {
        public PrintCommand(Output output)
        {
            _output = output;
            _printCommands = GetCommands(_output);
        }

        public void Execute(string[] args)
            => _printCommands
                .First(command => command.Test(args))
                .Execute(args);
        
        private List<IPrintCommand> GetCommands(Output output) 
            => new List<IPrintCommand> {
                new ConstPrintCommand(output),
                new VoidPrintCommand(output)
        };

        private Output _output;

        private List<IPrintCommand> _printCommands;                
    }
}