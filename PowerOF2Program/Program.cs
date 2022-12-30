namespace PowerOF2Program
{
    class PowerofNumber
    {
        public static void readData()
        {
            int mul = 1;


            int number = Convert.ToInt32(Console.ReadLine());

            // CONDITION CHECK
            if (number > 31)
            {
                Console.WriteLine("value of number should be less than 31");
                return;
            }

            // COMPUTATION
            else
            {
                Console.WriteLine(mul);
                for (int j = 1; j <= number; j++)
                {
                    mul = mul * 2;
                    Console.WriteLine(mul);
                }
            }
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            PowerofNumber.readData();
        }
    }
}
