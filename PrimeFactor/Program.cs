namespace PrimeFactor
{
    class PrimeFactor
    {
        public static void readData()
        {
            Console.WriteLine("Enter The Number to Find The Prime Factor");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i < number; i++)
            {
                while (number % i == 0)
                {
                    Console.WriteLine(i);
                    number = number / i;
                }
            }
            if (number > 2)
            {
                Console.WriteLine(number);
            }
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            PrimeFactor.readData();
        }
    }
}
