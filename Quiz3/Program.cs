using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            bool isPal = true;

            while (input != "exit")
            {
                Console.Write("Enter a string: ");
                input = Console.ReadLine();

                

                for (int i = 0;  i < input.Length; i++)
                {
                    if (input[i] != input[input.Length - 1])
                    {
                        isPal = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Result: " + input + " is a palindrome.");
                        break;
                    }
                }

                if (isPal == false)
                {
                    Console.WriteLine("Result: " + input + " is not a palindrome.");
                    break;
                }
            }

            

            Console.ReadLine();
        }
    }
}
