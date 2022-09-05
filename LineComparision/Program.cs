namespace LineComparision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a option\n 1. Length of line\n 2. Two line comparision using Equals method\n 3. Two line comparision using CompareTo method\n 4. Two line comparision by oops concept");
            Console.WriteLine("Enter the number");
            int option=Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    LengthOfLine.CalculateLengthOfLine();
                break;
                case 2:
                    LineComparisionEqualsMethod.CheckLengthEqualsMetho();
                    break;
                case 3:
                    LineComparisionCompareToMethod.CheckLengthCompareToMethod();
                    break;
                case 4:
                    LineComparisionOopsConcept obj = new LineComparisionOopsConcept();
                    obj.SetLength1(2, 4, 6, 8);
                    obj.GetLength1();
                    obj.SetLength2(2, 4, 6, 8);
                    obj.GetLength2();
                    obj.display1();
                    obj.display2();
                    break;
                default:
                    Console.WriteLine("Choose a rigth number");
                    break;
            }
        }
    }
}