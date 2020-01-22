using System.Linq;

namespace OOP_Kata
{
    public class Parameters
    {
        public Parameters(string command)
        {
            var args = command.Split(" ");
            _parameters = args.Skip(1).ToArray();
            Command = args[0].ToUpper();
        }

        public readonly string Command;
        
        public string First => _parameters.Length > 0 
            ? _parameters[0] 
            : string.Empty;

        private readonly string[] _parameters;

    }
}