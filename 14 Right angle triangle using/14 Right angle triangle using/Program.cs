using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Right_angle_triangle_using
{
    class Program
    {
        static void Main(string[] args)
        {       //  know the user to enter the number of rows of stearic '*' for height of right triangle
            Console.WriteLine("Enter the number of of rows of stearic * for height");
            int Height  = int.Parse(Console.ReadLine());
            // iterate from 1 to Height for printing no of lines on
            for (int i=1;i<=Height;i++)
            {    // Print number of stearics '*' from 1 to i on each row
                for (int j=1;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
