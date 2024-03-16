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
        int[] par = new int[5];
        int[] impar = new int[5];

        int parCount = 0; int imparCount = 0;

        for (int i = 0; i < 15; i++)
        {
            int value = Convert.ToInt32(Console.ReadLine());            

            if (value % 2 == 0)
            {                
                par[parCount] = value;
                parCount++;
            }                
            else
            {                
                impar[imparCount] = value;
                imparCount++;
            }                
            
            if (parCount == 5)
            {                
                for (int n = 0; n < 5; n++)
                {                    
                    Console.WriteLine($"par[{n}] = {par[n]}");
                }
                parCount = 0;                
            }
                
            if (imparCount == 5)
            {
                for (int n = 0; n < 5; n++)
                {                    
                    Console.WriteLine($"impar[{n}] = {impar[n]}");
                }
                imparCount = 0;                
            }                            
        }   

        for (int n = 0; n < imparCount; n++)
            Console.WriteLine($"impar[{n}] = {impar[n]}");

        for (int n = 0; n < parCount; n++)
            Console.WriteLine($"par[{n}] = {par[n]}");        
    }   

}
