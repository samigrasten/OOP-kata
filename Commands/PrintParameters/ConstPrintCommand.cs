namespace OOP_Kata.Commands.PrintParameters
{
    public class ConstPrintCommand : IPrintParameter
    {
        public ConstPrintCommand(Parameters parameters)
        {
            _parameters = parameters;
        }

        public bool Test()
            => _parameters.First.StartsWith('"')
               && _parameters.First.EndsWith('"');

        public override string ToString()
            => _parameters
                .First
                .Substring(1, _parameters.First.Length - 2);

        private readonly Parameters _parameters;
    }
}
