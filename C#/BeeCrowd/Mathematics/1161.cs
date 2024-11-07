using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.ExceptionServices;
class URI {   
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        while (input != null)
        {
            string[] inputAsArray = input.Split(' ');
            long factorialSum = Factorial(long.Parse(inputAsArray[0])) 
                        + Factorial(long.Parse(inputAsArray[1]));

            Console.WriteLine(factorialSum);

            input = Console.ReadLine();
        }
    }
    static long Factorial(long n)
    {
        if (n == 1 || n == 0)
            return 1;
        else
            return n * Factorial(n - 1);
    }
}
