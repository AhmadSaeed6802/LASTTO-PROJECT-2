using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Fibonacci_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of terms in fibnacci sequence:"); // let know the user what's required
            int NoOfTerms = int.Parse(Console.ReadLine());// read vlaue in a variable 
            PrintFibancciSeries(NoOfTerms);               // calling a the function
            Console.ReadKey();
        }
        static void PrintFibancciSeries(int n)   //defining a function 
        {
            int FirstTerm = 0;             //  initializing 1st two terms 
            int SecondTerm = 1;
            Console.WriteLine("Fibnacci sequence:");
            Console.Write(FirstTerm+" "+ SecondTerm+" "); //Print the first two terms
            for (int i=3;i<=n; i++)                       // printing the remaining terms
            {
                int nextTerm = FirstTerm + SecondTerm;
                Console.Write(nextTerm + " " );
                FirstTerm = SecondTerm; //shift the values for 2nd iteration
                SecondTerm = nextTerm;
            }

        }
    }
}
