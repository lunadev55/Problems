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
            string input = Console.ReadLine();
            string[] inputList = input.Split(' ');

            int populationCityA = Convert.ToInt32(inputList[0]);
            int populationCityB = Convert.ToInt32(inputList[1]);
            double growthRateA = Convert.ToDouble(inputList[2]);
            double growthRateB = Convert.ToDouble(inputList[3]);

            int years = 0;            

            while (true)
            {
                populationCityA += Convert.ToInt32(Math.Floor(populationCityA * (growthRateA/100.0)));
                populationCityB += Convert.ToInt32(Math.Floor(populationCityB * (growthRateB/100.0)));;

                years++;
                if (years > 100)
                {
                    Console.WriteLine("Mais de 1 seculo.");
                    break;
                } 

                if (populationCityA > populationCityB)
                {
                    Console.WriteLine($"{years} anos.");
                    break;
                }                                         
            }            
            testCases--;
        }
        
    }     
}
