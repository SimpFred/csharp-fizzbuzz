using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_fizzbuzz.Main
{
    public class Extension
    {
        public string[] fizzbuzz(int lower, int higher)
        {

            //TODO: Extension: Implement a function that will create a list of strings containing the numbers from the lower number to the higher number
            /*
                Where a number is a multiple of three (3, 6, 9, etc) the array should contain the string "Fizz" instead of a number.
                Where a number is a multiple of five (5, 10, etc) the array should contain the string "Buzz" instead of a number.
                Where a number is a multiple of both five AND three (15, 30, etc) the array should contain the string "Fizzbuzz" instead of a number.
            * */

            // Creates a new instance of the Core class
            Core core = new Core();

            // Initializes an empty list of strings
            List<string> nums = new List<string>();

            // Loops through the range from lower to higher
            for (int i = lower; i <= higher; i++)
            {
                // Adds the number as a string to the nums list
                nums.Add(i.ToString());
            }

            // Calls the fizzbuzz method with the entire nums list converted to an array
            string[] array = core.fizzbuzz(nums.ToArray());

            // Returns the array
            return array;
        }
    }
}
