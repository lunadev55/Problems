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
        int value = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= value; i++)
        {
            if (value % i == 0)
                Console.WriteLine(i);
        }
    }   

}
