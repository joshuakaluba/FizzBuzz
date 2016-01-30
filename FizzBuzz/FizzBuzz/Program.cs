using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Joshua Kaluba - 2016-01-30
// A program that prints the numbers from 1 to 100. 
// But for multiples of three print “Fizz” instead of the number. 
// For the multiples of five print “Buzz” instead of the number. 
// For numbers which are multiples of both three and five print “FizzBuzz”.

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int index = 1; index <= 100; index++)
            {
                string output = "";

                if (index % 3 == 0)
                {
                    //check if index is divisible by 3
                    output += "Fizz";

                    if (index % 5 == 0)
                    {
                        //check if index is also divisble by 5
                        output += "Buzz";
                    }
                }

                else if (index  % 5 == 0)
                {
                    //check if index is only divisble by 5
                    output = "Buzz";
                }

                else
                {
                    //if all else fails, output the index
                    output = index.ToString();
                }

                Console.WriteLine(output);
            }

            Console.Read();
        }

    }
}
