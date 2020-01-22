using System.Collections.Generic;
using System.Linq;
using OOP_Kata.Commands.PrintParameters;

namespace OOP_Kata.Factories
{
    public class PrintParametersFactory
    {
        public IPrintParameter Create(Parameters args) 
            => GetCommands(args)
                .First(command => command.Test());

        private List<IPrintParameter> GetCommands(Parameters args) 
            => new List<IPrintParameter> {
                new ConstPrintCommand(args),
                new NumberPrintCommand(args),
                new VoidPrintCommand()
            };
    }
}