namespace NumberEvenOrOdd
{
    class EvenOdd
    {
        public static void DisplayNumber()
        {
            int Number;

            Console.WriteLine("Enter The Number");
            Number = Convert.ToInt32(Console.ReadLine());

            if (Number % 2 == 0)
            {
                Console.WriteLine("Number Is Even");
            }
            else
            {
                Console.WriteLine("Number Is Odd");
            }
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            EvenOdd.DisplayNumber();
        }
    }
}

