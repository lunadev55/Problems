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
        string input = Console.ReadLine();

        int lineBreak = Convert.ToInt32(input.Split(' ')[0]);
        int limit = Convert.ToInt32(input.Split(' ')[1]);
        
        for (int i = 1; i <= limit; i++)
        {
            if (i % lineBreak == 0)
                Console.WriteLine($"{i}");
            else
                Console.Write($"{i} ");
        }
       
    }   

}