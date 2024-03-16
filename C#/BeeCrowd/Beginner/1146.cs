using System;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net.NetworkInformation;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;

class URI
{
    // Time limit exceeded - cannot identify why
    public static void Main(string[] args)
    {
        int value = Convert.ToInt32(Console.ReadLine());

        while (value != 0)
        {
            for (int i = 1; i <= value; i++)
            {
                if (i == value)
                    Console.WriteLine(i);
                else
                    Console.Write($"{i} ");
            }

            value = Convert.ToInt32(Console.ReadLine());
        }
    
    }   

}
