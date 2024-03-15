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
        int testCases = Convert.ToInt16(Console.ReadLine());

        while (testCases > 0)
        {
            int a = 0, b = 0;

            string sentence = Console.ReadLine();

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == 'A')
                    a++;
                else
                    b++;
            }

            if (a > b)
                Console.WriteLine('A');
            else
                Console.WriteLine('B');            
            
            testCases--;
        }
    }   

}
