namespace LineComparision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a option\n 1. Length of line");
            Console.WriteLine("Enter the number");
            int option=Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    LengthOfLine.CalculateLengthOfLine();
                break;
                default:
                    Console.WriteLine("Choose a rigth number");
                    break;
            }
        }
    }
}