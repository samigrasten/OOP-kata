using System;

namespace OOP_Kata
{
    public class Output
    {
        public void Writeline(string message)
        {
            Console.WriteLine(message);
        }

        internal static string ReadLine()
        {
            Console.Write("Command> ");
            return Console.ReadLine();
        }
    }
}
