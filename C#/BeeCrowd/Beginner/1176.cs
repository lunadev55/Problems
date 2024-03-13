using System;
using System.Collections.Specialized;
using System.Runtime.Serialization;

class URI
{
    public static void Main(string[] args)
    {
        int testCases = Convert.ToInt32(Console.ReadLine());

        while (testCases > 0) 
        {
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Fib({value}) = {Fibonacci(value)}");

            testCases--;
        }        
    }

    public static long Fibonacci(int val)
    {        
        if (val == 0)
            return 0;
        if (val == 1)
            return 1;

        long[] fib = new long[val + 1];
        fib[0] = 0; fib[1] = 1;              

        for (int i = 2; i <= val; i++)
        {
            fib[i] = fib[i - 1] + fib[i - 2];
        }

        return fib[val];
    }

    // recursive version - time limit exceeded (worst implementation ever haha).
    // public static int Fibonacci(int val) 
    // {
    //     if (val == 0)
    //         return 0;
    //     if (val == 1)
    //         return 1;
        
    //     return Fibonacci(val - 1) + Fibonacci(val - 2);
    // }
}
