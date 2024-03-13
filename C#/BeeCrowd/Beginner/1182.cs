using System;
using System.Collections.Specialized;
using System.Net.NetworkInformation;
using System.Runtime.Serialization;

class URI
{
    public static void Main(string[] args)
    {
        int column = Convert.ToInt32(Console.ReadLine());

        string key = Console.ReadLine();
        
        double[,] matrix = new double[12, 12];

        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                double value = Convert.ToDouble(Console.ReadLine());
                matrix[i, j] = value;
            }
        }

        double sum = 0;

        for (int col = 0; col < 12; col++) 
        {            
            sum += matrix[col, column];
        }

        if (key == "S")
            Console.WriteLine($"{sum:F1}");
        else
            Console.WriteLine($"{sum/12:F1}");
        
    }   

}
