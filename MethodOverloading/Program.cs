namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Add(1, 1);
            Add(1.5, 1.5);
            Add(0, 1, false);
        }

        public static int Add(int num1, int num2)
        {
            int sum = num1 + num2;

            Console.WriteLine(sum);
            return sum;
        }

        public static double Add(double num1, double num2)
        {
            double sum = num1 + num1;

            Console.WriteLine(sum);
            return sum;
        }

        public static void Add(int num1, int num2, bool insertDollar)
        {
            int sum = num1 + num2;

            if (insertDollar)
            {
                if (sum == 1)
                {
                    Console.WriteLine($"{sum} Dollar");
                }
                else
                {
                    Console.WriteLine($"{sum} Dollars");
                }
            }
            else
            {
                Console.WriteLine(sum);
            }

        }
    }
}
