namespace DigitSum
{
    public class DigitSumMethod
    {
        static void Main(string[] args)
        {
            int number = 154489;
            Console.WriteLine($"Digit sum {number} of is {SumDigits(number)}.");
        }
        public static int SumDigits(int number)
        {
            if (number < 10)
            {
                return number;
            }
            else
            {
                return number % 10 + SumDigits(number / 10);
            }
        }
    }
}
