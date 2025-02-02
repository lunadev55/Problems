
    // scissors cuts paper;
    // paper covers rock;
    // rock crushes lizard;
    // lizard poisons Spock;
    // Spock smashes scissors;
    // scissors decapitates lizard;
    // lizard eats paper;
    // paper disproves Spock;
    // Spock vaporizes rock;
    // rock crushes scissors.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.Contracts;
using System.Runtime.ExceptionServices;
class URI {   
    static void Main(string[] args)
    {
        var whoBeatswhom = new Dictionary<string, HashSet<string>>
        {
            {"tesoura", new HashSet<string> {"papel", "lagarto"}},
            {"papel", new HashSet<string> {"pedra", "Spock"}},
            {"pedra", new HashSet<string> {"lagarto", "tesoura"}},
            {"lagarto", new HashSet<string> {"Spock", "papel"}},
            {"Spock", new HashSet<string> {"tesoura", "pedra"}},                      
        };

        short testCases = Convert.ToInt16(Console.ReadLine());   

        for (int index = 0; index < testCases; index++)
        {
            string input = Console.ReadLine();

            string sheldon = input.Split(' ')[0];
            string raj = input.Split(' ')[1];

            if (sheldon.Equals(raj))
                Console.WriteLine($"Caso #{index + 1}: De novo!");        
            else
            {
                if (whoBeatswhom[sheldon].Contains(raj))
                    Console.WriteLine($"Caso #{index + 1}: Bazinga!");
                else
                    Console.WriteLine($"Caso #{index + 1}: Raj trapaceou!");
            }    
        }
    }       
}
