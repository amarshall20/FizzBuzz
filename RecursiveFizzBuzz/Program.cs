using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz(100);
            Console.ReadLine();
        }
        static void FizzBuzz(int n)
        {
            if (n == 0)
            {
                Console.WriteLine(n);
            }
            else
            {
                if (n % 3 == 0)
                {
                    if (n % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else
                    {
                        Console.WriteLine("Fizz");
                    }
                }
                else
                {
                    if (n % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.WriteLine(n);
                    }
                }
                FizzBuzz(n - 1);
            }
        }
    }
}
