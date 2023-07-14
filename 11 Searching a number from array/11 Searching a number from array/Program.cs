using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Searching_a_number_from_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5] {10,20,30,40,50 };//creating an array of 5 integers
            Console.WriteLine("Enter a number to search :");
            int SearchNumber =int.Parse(Console.ReadLine());// read vlaue in a variable 
            bool found = false; //flag to track the number is found 
            for (int i=0;i<numbers.Length;i++)
            {
                if(numbers[i]== SearchNumber)  // Iterate through the array and check whether the number exist
                {
                    found = true;
                    break;    //exit the loop if number is found
                }
            }
            if(found)        // print the result
                Console.WriteLine("Entered  number {0} is found :",SearchNumber);
            else
                Console.WriteLine("Entered  number {0} is not found :", SearchNumber);

            Console.ReadKey();


        }
    }
}
