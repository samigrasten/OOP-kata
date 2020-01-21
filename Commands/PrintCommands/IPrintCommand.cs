namespace OOP_Kata.Commands.PrintCommands
{
    internal interface IPrintCommand
    {
        bool Test(string[] args);

        void Execute(string[] args);
    }
}
