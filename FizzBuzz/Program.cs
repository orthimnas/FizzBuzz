using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Value to FizzBuzz up to: ");
                int nValue = 0;
                if (int.TryParse(Console.ReadLine(), out nValue) && nValue > 0)
                {
                    FizzBuzz(nValue);
                    Console.WriteLine("Complete, press any key to exit");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input, please try again.");
                }
            }
        }

        private static void FizzBuzz(int nValue)
        {
            for (int i = 1; i <= nValue; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i.ToString() + " Fizz Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(i.ToString() + " Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(i.ToString() + " Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
