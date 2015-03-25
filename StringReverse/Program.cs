using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverse
{
    // print the characters of a string in reverse order

    class Program
    {
        static void Main(string[] args)
        {
            //  set up the test string
            string sample = "This is a test string.";

            // Use the reverse method and place in an array of char
            char[] backward = sample.Reverse().ToArray();

            foreach (char chr in backward)
            {
                Console.Write(chr);
            }

            Console.WriteLine();

            // from an array of strings, print the strings in reverse order & the chars in the array in reverse order

            string[] testTwo = { "This is a test", "This is only a test", "If this were a real emergency" };

            for (int i = testTwo.Length -1; i >= 0; i--)
            {
                backward = testTwo[i].Reverse().ToArray();

                foreach (char chr in backward)
                {
                    Console.Write(chr);
                }

                Console.WriteLine();

            }

            Console.WriteLine();
            Console.ReadLine();
           
        }
    }


}
