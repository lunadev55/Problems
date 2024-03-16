using System;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net.NetworkInformation;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;

class URI
{
    public static void Main(string[] args)
    {
        int testCases = Convert.ToInt32(Console.ReadLine());

        while (testCases > 0)
        {
            int value = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i < value; i++)
            {
                if (value % i == 0)
                    sum += i;
            }

            if (sum == value)
                Console.WriteLine($"{value} eh perfeito");
            else
                Console.WriteLine($"{value} nao eh perfeito");

            testCases--;
        }        
    }   

}
