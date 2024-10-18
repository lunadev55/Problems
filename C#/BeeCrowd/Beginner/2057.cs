using System;
using System.Runtime.ExceptionServices;
class URI {   
    static void Main(string[] args) {
        string input = Console.ReadLine();

        int departureTime = Convert.ToInt16(input.Split(' ')[0]);
        int travelTime = Convert.ToInt16(input.Split(' ')[1]);
        int destinationTimeZone = Convert.ToInt16(input.Split(' ')[2]);

        int timeOfArrival = departureTime + travelTime + destinationTimeZone;

        if (timeOfArrival == 24)
            Console.WriteLine(0);
        else if (timeOfArrival > 24)
            Console.WriteLine(timeOfArrival - 24);
        else if (timeOfArrival < 0)
            Console.WriteLine(timeOfArrival + 24);
        else
            Console.WriteLine(timeOfArrival);
        
    }
}
