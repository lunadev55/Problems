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
        string operation = Console.ReadLine();

        double[,] matrix = new double[12, 12];

        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                matrix[i, j] = Convert.ToDouble(Console.ReadLine());
            }
        }

        double sum = 0; double count = 0;

        for (int i = 0; i < 11; i++)
        {
            for (int j = i + 1; j < 12; j++)
            {                
                sum += matrix[j, i];
                count++;
            }
        }

        if (operation == "S")
            Console.WriteLine($"{sum:F1}");
        else
            Console.WriteLine($"{sum/count:F1}");
    }     
}
