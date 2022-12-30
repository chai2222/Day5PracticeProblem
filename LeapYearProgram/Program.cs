namespace LeapYearProgram
{
    class Year
    {
        public static void Readdata()
        {
            Console.WriteLine("Enter the year in 4 Digit Number");

            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Entered Year Is :" + year);
            Console.WriteLine();
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("The Year is " + year + " are Leap Year");
            }
            else
            {
                Console.WriteLine("The Year Is " + year + " are Not Leap Year");
            }

        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Year.Readdata();
        }
    }
}
