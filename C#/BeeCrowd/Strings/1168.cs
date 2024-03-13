using System;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net.NetworkInformation;
using System.Runtime.Serialization;

class URI
{
    public static void Main(string[] args)
    {
        Dictionary<char, int> dictionary = new Dictionary<char, int>
        {
            { '1', 2 },
            { '2', 5 },
            { '3', 5 },
            { '4', 4 },
            { '5', 5 },
            { '6', 6 },
            { '7', 3 },
            { '8', 7 },
            { '9', 6 },
            { '0', 6 },
        };

        int testCases = Convert.ToInt32(Console.ReadLine());

        while (testCases > 0)
        {
            string value = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < value.Length; i++)
            {
                sum += dictionary[value[i]];
            }

            Console.WriteLine($"{sum} leds");

            testCases--;
        }

    }   

}
