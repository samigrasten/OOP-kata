using System.Collections.Generic;
using System.Linq;
using OOP_Kata.Commands.PrintParameters;
using OOP_Kata.Factories;

namespace OOP_Kata.Commands
{
    public class PrintCommand : ICommand
    {
        public PrintCommand(Output output, Parameters args)
        {
            _output = output;
            _printParameter = new PrintParametersFactory().Create(args);
        }

        public void Execute()
            => _output.Writeline(_printParameter.ToString());


        private readonly IPrintParameter _printParameter;
        private readonly Output _output;
    }
}