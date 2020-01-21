using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Kata.Commands.PrintCommands
{
    class ConstPrintCommand : IPrintCommand
    {
        public ConstPrintCommand(Output output)
        {
            _output = output;
        }

        public void Execute(string[] args)
        {
            _output.Writeline(args[0].Substring(1, args[0].Length - 2));
        }

        public bool Test(string[] args)
            => args[0].StartsWith('"');

        private readonly Output _output;
    }
}
