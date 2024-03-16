using System;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net.NetworkInformation;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;

class URI
{
    // Wrong answer (90%) - cannot identify the error yet
    public static void Main(string[] args)
    {
        string operation = Console.ReadLine();

        double[,] matrix = new double[12, 12];

        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                double val = Convert.ToDouble(Console.ReadLine());  
                matrix[i, j] = val;  
                // matrix[i, j] = 1;              
            }
        }

        double sum = 0;

        for (int i = 0; i < 11; i++)
        {
            for (int j = i + 1; j < 12; j++)
            {
                sum += matrix[i, j];

                // Console.WriteLine($"[{i}, {j}]");
            }

            // Console.WriteLine("\n");
        }

        if (operation == "S")
            Console.WriteLine($"{sum:F1}");
        else
            Console.WriteLine($"{sum/12:F1}");
        
    }   

}
