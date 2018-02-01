﻿using System;
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
            LoopingFizzBuzz(15);
            FizzBuzz(15);
            UpAndDownFizzBuzz(0, 15);
            Console.ReadLine();
        }
        static void LoopingFizzBuzz(int n)
        {
            while (n > 0)
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
                n--;
            }
        }
        static void FizzBuzz(int n)
        {
            if (n != 0)
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
        static void UpAndDownFizzBuzz(int begin, int end)
        {
            if (begin <= end)
            {
                if (begin != 0)
                {
                    if (begin % 3 == 0)
                    {
                        if (begin % 5 == 0)
                            Console.WriteLine("FizzBuzz");
                        else
                            Console.WriteLine("Fizz");
                    }
                    else
                    {
                        if (begin % 5 == 0)
                            Console.WriteLine("Buzz");
                        else
                            Console.WriteLine(begin);
                    }
                }
                UpAndDownFizzBuzz(begin + 1, end);
            }
            else
            {
                if (end != 0)
                {
                    if (end % 3 == 0)
                    {
                        if (end % 5 == 0)
                            Console.WriteLine("FizzBuzz");
                        else
                            Console.WriteLine("Fizz");
                    }
                    else
                    {
                        if (end % 5 == 0)
                            Console.WriteLine("Buzz");
                        else
                            Console.WriteLine(end);
                    }
                    UpAndDownFizzBuzz(begin, end - 1);
                }
            }
        }
    }
}
