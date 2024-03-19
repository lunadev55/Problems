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
        bool flag = true;
        short interWins = 0; short gremioWins = 0; short empate = 0; short numberOfGames = 0;
        
        while (flag)
        {
            // input
            string score = Console.ReadLine();
            string[] scores = score.Split(' ');

            int inter = Convert.ToInt16(scores[0]);
            int gremio = Convert.ToInt16(scores[1]);

            if (inter > gremio)
                interWins++;
            else if (inter < gremio)
                gremioWins++;
            else
                empate++;

            numberOfGames++;

            Console.WriteLine("Novo grenal (1-sim 2-nao)");
            int newGrenau = Convert.ToInt16(Console.ReadLine());         

            if (newGrenau == 2)
                flag = false;   
        }

        Console.WriteLine($"{numberOfGames} grenais");
        Console.WriteLine($"Inter:{interWins}");
        Console.WriteLine($"Gremio:{gremioWins}");
        Console.WriteLine($"Empates:{empate}");

        if (interWins > gremioWins)
            Console.WriteLine("Inter venceu mais");
        else if (interWins < gremioWins)
            Console.WriteLine("Gremio venceu mais");
        else
            Console.WriteLine("Não houve vencedor");
    }       
}
