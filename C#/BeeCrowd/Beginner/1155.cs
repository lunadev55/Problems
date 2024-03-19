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
        double sum = 0;
        
        for (double i = 1; i <= 100; i++)
        {
            sum += (1/i);
        }
        
        Console.WriteLine(sum.ToString("F2"));
    }       
}
