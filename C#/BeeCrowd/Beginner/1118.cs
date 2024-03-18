using System;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net.NetworkInformation;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Reflection.Metadata.Ecma335;

class URI
{
    // returning incorrect output (i guess it might be related to float precision)
    public static void Main(string[] args) 
    {
        Console.WriteLine("novo calculo (1-sim 2-nao)");
        int option = Convert.ToInt32(Console.ReadLine());

        while (option is not 2)
        {
            double scoreA; double scoreB;

            scoreA = GetScoreAsDouble(Console.ReadLine());
            while (!IsValidScore(scoreA))
            {
                Console.WriteLine("nota invalida");
                scoreA = GetScoreAsDouble(Console.ReadLine());
            }

            scoreB = GetScoreAsDouble(Console.ReadLine());  
            while (!IsValidScore(scoreB))
            {
                Console.WriteLine("nota invalida");
                scoreB = GetScoreAsDouble(Console.ReadLine());
            }

            Console.WriteLine($"media = {Media(scoreA, scoreB):F2}");       
        }    
    }   

    public static double Media(double scoreA, double scoreB)
    {
        return (scoreA + scoreB) / 2;
    }

    public static bool IsValidScore(double score)
    {
        if (score < 0 || score > 10)
            return false;
        return true;
    }

    public static double GetScoreAsDouble(string score)
    {
        return Convert.ToDouble(score);
    }
}
