using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_largest_and_smallest_in_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 5, 57, 2, 9, 11 };
            // assume the fist number is both the largest and smallest
            int smallest = numbers[0];
            int largest = numbers[0];
            //iterate through the array ton find the largest and smallest 
            for (int i=1;i<numbers.Length;i++)
            {
                if (numbers[i]<smallest)
                {
                    smallest = numbers[i];
                }
                if(numbers[i]>largest)
                {
                    largest = numbers[i];
                }
               
            }
            // output the smallest and largest numbers
            Console.WriteLine("Smallest number : " + smallest);
            Console.WriteLine("Smallest number : " + largest);
            Console.ReadKey();

        }
    }
}
