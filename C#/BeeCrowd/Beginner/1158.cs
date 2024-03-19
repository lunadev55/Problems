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
        // wrong answer (5%)
        int testCases = Convert.ToInt32(Console.ReadLine());        

        while (testCases > 0)
        {
            string input = Console.ReadLine();
            int value = Convert.ToInt32(input.Split(' ')[0]);
            int odds = Convert.ToInt32(input.Split(' ')[1]);

            int sum = 0; int numberOfConsecutiveOdds = 0;
        
            while (numberOfConsecutiveOdds < odds)
            {
                if (value % 2 == 1)
                {
                    sum += value;
                    numberOfConsecutiveOdds++;
                }
                value++;                    
            }            
            Console.WriteLine(sum);           

            testCases--;
        }
    }       
}
