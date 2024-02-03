
namespace DotnetFormatExample
{
    public class Calculator
    {
        public int AddNumbers(int one, int two)
        {
            int finalNumber = 0;
            finalNumber = one + two;
            return finalNumber;
        }

        public int SubtractNumbers(int one, int two)
        {
            int finalNumber = 0;
            finalNumber = one - two;
            return finalNumber;
        }

        public int MultiplyNumbers(int one, int two)
        {
            int finalNumber = 0;
            finalNumber = one * two;
            return finalNumber;
        }

        public double DivideNumbers(int one, int two)
        {
            double finalNumber = 0;
            finalNumber = one / two;
            return finalNumber;
        }

        public int ModulasNumbers(int one, int two)
        {
            int finalNumber = 0;
            finalNumber = one % two;
            return finalNumber;
        }
    }
}
