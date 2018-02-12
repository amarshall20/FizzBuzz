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
            Console.WriteLine(LoopingFizzBuzz(15));
            //need to provide string to concatenate it recursively
            string fizzBuzz = "";
            Console.WriteLine(RecursiveFizzBuzz(fizzBuzz, 15));
            //need to provide beginning and end to go up and down recursively
            Console.WriteLine(UpAndDownFizzBuzz(fizzBuzz, 1, 15));
            Console.ReadLine();
        }
        static string LoopingFizzBuzz(int n)
        {
            string fizzBuzz = "";
            while (n > 0)
            {
                if (n % 3 == 0)
                {
                    if (n % 5 == 0)
                        fizzBuzz += "FizzBuzz\n";
                    else
                        fizzBuzz += "Fizz\n";
                }
                else
                {
                    if (n % 5 == 0)
                        fizzBuzz += "Buzz\n";
                    else
                        fizzBuzz += n + "\n";
                }
                n--;
            }
            return fizzBuzz.TrimEnd('\n');
        }
        static string RecursiveFizzBuzz(string fizzBuzz, int n)
        {
            if (n > 0)
            {
                if (n % 3 == 0)
                {
                    if (n % 5 == 0)
                    {
                        fizzBuzz += "FizzBuzz\n";
                        return RecursiveFizzBuzz(fizzBuzz, n-1);
                    }
                    else
                    {
                        fizzBuzz += "Fizz\n";
                        return RecursiveFizzBuzz(fizzBuzz, n-1);
                    }
                }
                else
                {
                    if (n % 5 == 0)
                    {
                        fizzBuzz += "Buzz\n";
                        return RecursiveFizzBuzz(fizzBuzz, n-1);
                    }

                    else
                    {
                        fizzBuzz += n + "\n";
                        return RecursiveFizzBuzz(fizzBuzz, n-1);
                    }
                }
            }else
            {
                return fizzBuzz.TrimEnd('\n');
            }
        }
        static string UpAndDownFizzBuzz(string fizzBuzz, int begin, int end)
        {
            if (begin <= end)
            {
                if (begin % 3 == 0)
                {
                    if (begin % 5 == 0)
                    {
                        fizzBuzz += "FizzBuzz\n";
                        return UpAndDownFizzBuzz(fizzBuzz, begin + 1, end);
                    }
                    else
                    {
                        fizzBuzz += "Fizz\n";
                        return UpAndDownFizzBuzz(fizzBuzz, begin + 1, end);
                    }
                }
                else
                {
                    if (begin % 5 == 0)
                    {
                        fizzBuzz += "Buzz\n";
                        return UpAndDownFizzBuzz(fizzBuzz, begin + 1, end);
                    }
                    else{
                        fizzBuzz += begin + "\n";
                        return UpAndDownFizzBuzz(fizzBuzz, begin + 1, end);
                    }
                }
            }
            else
            {
                if (end > 0)
                {
                    if (end % 3 == 0)
                    {
                        if (end % 5 == 0)
                        {
                            fizzBuzz += "FizzBuzz\n";
                            return UpAndDownFizzBuzz(fizzBuzz, begin, end - 1);
                        }
                        else
                        {
                            fizzBuzz += "Fizz\n";
                            return UpAndDownFizzBuzz(fizzBuzz, begin, end - 1);
                        }
                    }
                    else
                    {
                        if (end % 5 == 0)
                        {
                            fizzBuzz += "Buzz\n";
                            return UpAndDownFizzBuzz(fizzBuzz, begin, end - 1);
                        }
                        else
                        {
                            fizzBuzz += end + "\n";
                            return UpAndDownFizzBuzz(fizzBuzz, begin, end - 1);
                        }
                    }
                }else
                {
                    return fizzBuzz.TrimEnd('\n');
                }
            }
        }
    }
}
