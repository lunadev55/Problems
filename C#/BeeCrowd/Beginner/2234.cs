using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.Contracts;
using System.Runtime.ExceptionServices;
class URI {
    static void Main(string[] args)
    {
        string input = Console.ReadLine();        

        decimal numberOfConsumedHotDogs = Convert.ToDecimal(input.Split(' ')[0]);
        decimal numberOfParticipants = Convert.ToDecimal(input.Split(' ')[1]);

        decimal result = (decimal)(numberOfConsumedHotDogs / numberOfParticipants);

        Console.WriteLine($"{result:F2}");        
    }          
}
