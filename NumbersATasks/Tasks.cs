namespace NumbersATasks
{
    public static class Tasks
    {
        public static void Task1(int n)
        {
            int leftDigit = 0;
            
                leftDigit = n / 10;

            Console.WriteLine($"Left digit is {leftDigit}");
        }

        public static void Task2(int n)
        {
            int sum = 0;
            int product = 0;

            sum = ((n / 10) + (n % 10));
            product = ((n / 10) * (n % 10));

            Console.WriteLine($"Sum = {sum}, Product = {product}");
        }

        public static void Task3(int n)
        {
            int sum = 0;
            int product = 1;

            sum = ((n / 100) + (n % 10) + ((n / 10) %10 ));
            product = ((n / 100) * (n % 10) * ((n / 10) % 10));

            Console.WriteLine($"Sum = {sum}, Product = {product}");
        }

        public static void Task4(int n)
        {
            int result = 0;
            int x = n / 100;
            result = ((n -(x * 100)) * 10) +x;



            Console.WriteLine($"Result is {result}");
        }
    }
}
