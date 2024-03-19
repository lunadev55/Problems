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

        while (value != 0)
        {
            int sum = 0; int consecutiveEvens = 0;

            while (consecutiveEvens < 5)
            {
                if (value % 2 == 0)
                {
                    sum += value;
                    consecutiveEvens++;
                }
                value++;                    
            }            
            Console.WriteLine(sum);
            value = Convert.ToInt32(Console.ReadLine());
        }
    }       
}
