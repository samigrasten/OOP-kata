namespace OOP_Kata.Commands.PrintParameters
{
    class VoidPrintCommand : IPrintParameter
    {
        public bool Test() => true;

        public override string ToString()
            => "Invalid print parameters";
    }
}
