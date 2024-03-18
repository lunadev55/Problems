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
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"{i} {i * i} {i * i * i}");
            Console.WriteLine($"{i} {(i*i) + 1} {(i * i * i) + 1}");
        }
    }       
}
