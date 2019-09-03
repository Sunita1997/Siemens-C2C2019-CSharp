using CalculationLibrary;
using ExtensionLibrary;
using static System.Console;

namespace UserInterface
{
    class Program
    {
        static void Main()
        {
            ICalculation calculation = new Calculation();
            int resultAdd = calculation.Add(12, 13);
            int resultSubtract = calculation.Subtract(12, 3);
            WriteLine(resultAdd);
            WriteLine(resultSubtract);

            string message = "some string";
            WriteLine(message.SayHi("joydip"));
        }
    }
}
