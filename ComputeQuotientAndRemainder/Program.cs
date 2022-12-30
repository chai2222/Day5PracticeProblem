namespace CompueQuotientAndReminder
{
    class Division
    {
        public static void Display()
        {
            int dividend = 0;
            Console.WriteLine("Enter the Dividend ");
            dividend = Convert.ToInt32(Console.ReadLine());

            int divisor = 0;
            Console.WriteLine("Enter the Divisor ");
            divisor = Convert.ToInt32(Console.ReadLine());

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);

        }
        
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Division.Display();
        }
    }
}
