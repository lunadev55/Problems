using System;
using System.Net.NetworkInformation;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        string operation = Console.ReadLine();

        double[,] arr = new double[12, 12];

        for (int i = 0; i < 12; i++)
            for (int j = 0; j < 12; j++)
                arr[i, j] = Convert.ToDouble(Console.ReadLine());

        double sum = 0; int count = 0;

        for (int i = 0; i < 5; i++)        
        {
            int left = 1 + count; int right = 10 - count;

            while (left < right)
            {
                sum += arr[i, left];
                sum += arr[i, right];

                left++;
                right--;
            }
            count++;
        }

        if (operation == "S")
            Console.WriteLine($"{sum:F1}");
        else
            Console.WriteLine($"{sum/30:F1}");
    }
}
