using System.Linq;

namespace OOP_Kata.Commands.PrintParameters
{
    public class NumberPrintCommand : IPrintParameter
    {
        public NumberPrintCommand(Parameters parameters)
        {
            _parameters = parameters;
        }

        public bool Test()
            => _parameters.First.Length > 0
               && _parameters.First.All(c => 
                   char.IsDigit(c) 
                   || c == '+');

        public override string ToString()
            => _parameters.First
                .Split('+')
                .Select(number => int.Parse(number))
                .Sum()
                .ToString();

        private readonly Parameters _parameters;
    }
}