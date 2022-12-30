
namespace SwapTwoNumber
{
    class Swap
    {
        public static void DisplayNumber()
        {
            int a, b, c;

            Console.WriteLine("Enter The First Number A");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter The Second Number B");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before The Swapping Number Is: " + "a= " + a + " " + "b= " + b);
            //By Using Third Variable
            /* c = a;
             a = b;
             b = c;
            */
            //By WithOut Using Thrid Variable
            a = a + b;
            b = a - b;
            a = a - b;


            Console.WriteLine("After The Swapping Number Is: " + "a= " + a + " " + "b= " + b);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Swap.DisplayNumber();
        }
    }
}
