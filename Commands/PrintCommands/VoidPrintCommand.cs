namespace OOP_Kata.Commands.PrintCommands
{
    class VoidPrintCommand : IPrintCommand
    {
        public VoidPrintCommand(Output output)
        {
            _output = output;
        }

        public void Execute(string[] args)
        {
            _output.Writeline("Invalid print parameters");
        }

        public bool Test(string[] args) => true;

        private readonly Output _output;
    }
}
