namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Result of Add(3, 2) = " + Add(3, 2));
            Console.WriteLine("Result of Add(2.3, 2.7) = " + Add(2.3, 2.7));
            Console.WriteLine("Result of Add(5, 10, false) = " + Add(5, 10, false));
            Console.WriteLine("Result of Add(5, 10, true) = " + Add(5, 10, true));
            Console.WriteLine("Result of Add(1, 0, true) = " + Add(1, 0, true));
        }

        private static int Add(int a, int b)
        {
            return a + b;
        }

        private static double Add(double a, double b)
        {
            return a + b;
        }

        private static string Add(double a, double b, bool addDollar)
        {
            var sum = a + b;

            if (addDollar && sum == 1)
            {
                return $"{sum} dollar";
            } else if (addDollar)
            {
                return $"{sum} dollars";
            }

            return sum.ToString();
        }
    }
}
