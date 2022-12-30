namespace HarmonicNumberProblem
{
    class Number
    {
        public static void readData()
        {
            double s = 0.0;

            Console.WriteLine("Input the number of terms : ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i <= number; i++)
            {
                Console.Write("1/" + i + " + ");
                s = s + 1 / (float)i;
            }
            Console.WriteLine();
            Console.WriteLine("Sum of Series upto" + number + " terms :" + s);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Number.readData();
        }
    }
}
