using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Palidrome_invert_string_array
{
    class Program
    {
        static void Main(string[] args)
        {
            // let know the user to enter a string 
            Console.WriteLine("Enter a string:");
            //Read the user input and store in a variable
            String input = Console.ReadLine();
            /* not used
           //call the Reverse method to reverse the string
         string reversed = Reverse(input);
           //display the reverse string
           Console.WriteLine("Reversed string: " + reversed);
           bool palidrome = isPalidrome(input, reversed);
            */
            if (isPalidrome(input))
            {
                Console.WriteLine(input+" is a Palidrome");
            }
            else
            {
                Console.WriteLine(input+"is not a Palidrome");
            }
            Console.ReadKey();
        }
        /* not used
        static string Reverse(string str)
        {
            //convert the input string  to character array
            char[] charArray = str.ToCharArray();
            //reverse the character array
            Array.Reverse(charArray);
            return  new string(charArray);

        } 
        */
        static bool isPalidrome(string str)

        {  // traversing from both side
            int left = 0;
            int right = str.Length - 1;
            while(left<right)
            {

                //checking if palidrome
                if (str[left]!=str[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }


        /* not used
         * static bool isPalidrome(string stri,string irts)
          {
              if(stri==irts)
              {
                  return true;
              }
          }*/
    }
}
