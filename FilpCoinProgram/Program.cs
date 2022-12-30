namespace FilpCoinProgram
{
    class CalculatePercentage
    {

        public static void FilpNumber()
        {
            int TailCount = 0;
            int HeadCount = 0;
            double TailPercentage = 0.0;
            double HeadPercentage = 0.0;

            Console.WriteLine("Please Enter the flips number");

            int flip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Flip Number " + flip);

            if (flip > 0)
            {
                for (int i = 0; i < flip; i++)
                {
                    Random random = new Random();
                    int number = random.Next(2);
                    Console.WriteLine(number);

                    if (number == 0)
                    {
                        TailCount++;
                    }
                    else
                    {
                        HeadCount++;
                    }
                }

                Console.WriteLine("The TailCount Is :" + TailCount);
                Console.WriteLine("The HeadCount Is :" + HeadCount);

                //percentage
                TailPercentage = (TailCount * 100) / 100;
                HeadPercentage = (HeadCount * 100) / 100;

                Console.WriteLine("The Percentage Of Tail :" + TailPercentage);
                Console.WriteLine("The Percentage Of Head :" + HeadPercentage);
            }
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            CalculatePercentage.FilpNumber();
        }

    }
}