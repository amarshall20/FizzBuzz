using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Looping(15));
            Console.WriteLine(DownUpRecursive(15));
            Console.ReadLine();
        }
        static string Looping(int n)
        {
            string fizzBuzz = "";
            while (n > 0)
            {
                fizzBuzz += FizzBuzz(n);
                n--;
            }
            return fizzBuzz.TrimEnd('\n');
        }
        static string DownUpRecursive(int n)
        {
            string fizzBuzz = "";
            if (n > 1)
            {
                fizzBuzz += FizzBuzz(n) + DownUpRecursive(n - 1);
                return fizzBuzz + FizzBuzz(n);
            }
            else
                return n.ToString() + "\n";
        }
        static string FizzBuzz(int n)
        {
            string fizzBuzz = "";
            if (n % 15 == 0)
                fizzBuzz += "FizzBuzz\n";
            else if (n % 5 == 0)
                fizzBuzz += "Buzz\n";
            else if (n % 3 == 0)
                fizzBuzz += "Fizz\n";
            else
                fizzBuzz += n + "\n";
            return fizzBuzz;
        }
    }
}
