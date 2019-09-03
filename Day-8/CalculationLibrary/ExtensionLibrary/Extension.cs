using CalculationLibrary;

namespace ExtensionLibrary
{
    public static class Extension
    {
        public static int Subtract(this ICalculation calc, int x, int y)
        {
            return (x - y);
        }
        public static string SayHi(this string str, string name)
        {
            return $"Hi {name}";
        }
    }
}
