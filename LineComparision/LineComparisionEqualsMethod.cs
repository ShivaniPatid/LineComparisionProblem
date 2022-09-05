using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision
{
    internal class LineComparisionEqualsMethod
    {
        public static void CheckLengthEqualsMetho()
        {
            Console.WriteLine("Enter the value of x1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of x2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of y2");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of p1");
            int p1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of q1");
            int q1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of p2");
            int p2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of q2");
            int q2 = Convert.ToInt32(Console.ReadLine());

            double length1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Length of line is " + length1);

            double length2 = Math.Sqrt(Math.Pow((p2 - p1), 2) + Math.Pow((q2 - q1), 2));
            Console.WriteLine("Length of line is " + length2);

            if (length1.Equals(length2))
            {
                Console.WriteLine("The length of two lines are equal");
            }
            else
            {
                Console.WriteLine("The length of two lines are not equal");
            }
        }
    }
}
