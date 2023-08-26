
/*
    Code returning Wrong Answer (0%) on BeeCrowd Online Judge.
    I guess it might be something related to the precision given that the math seems to be ok.
*/

using System; 

class URI {
    static void Main(string[] args) { 

        double value = Double.Parse(Console.ReadLine());

        // Banknotes
        Console.WriteLine("NOTAS:");
        Console.WriteLine("{0} nota(s) de R$ 100.00", (int)(value/100));       
        Console.WriteLine("{0} nota(s) de R$ 50.00", (int)((value%100) /50));  
        Console.WriteLine("{0} nota(s) de R$ 20.00", (int)(((value%100)%50) /20));
        Console.WriteLine("{0} nota(s) de R$ 10.00", (int)((((value%100)%50)%20) /10));
        Console.WriteLine("{0} nota(s) de R$ 5.00", (int)(((((value%100)%50)%20)%10) /5));
        Console.WriteLine("{0} nota(s) de R$ 2.00", (int)((((((value%100)%50)%20)%10)%5) /2));

        // Coins
        Console.WriteLine("MOEDAS:");
        Console.WriteLine("{0} moeda(s) de R$ 1.00", (int)(((((((value%100)%50)%20)%10)%5)%2) /1));
        Console.WriteLine("{0} moeda(s) de R$ 0.50", (int)((((((((value%100)%50)%20)%10)%5)%2)%1) /0.50));
        Console.WriteLine("{0} moeda(s) de R$ 0.25", (int)(((((((((value%100)%50)%20)%10)%5)%2)%1)%0.50) /0.25));
        Console.WriteLine("{0} moeda(s) de R$ 0.10", (int)((((((((((value%100)%50)%20)%10)%5)%2)%1)%0.50)%0.25) /0.10));
        Console.WriteLine("{0} moeda(s) de R$ 0.05", (int)(((((((((((value%100)%50)%20)%10)%5)%2)%1)%0.50)%0.25)%0.10) /0.05));
        Console.WriteLine("{0} moeda(s) de R$ 0.01", (int)((((((((((((value%100)%50)%20)%10)%5)%2)%1)%0.50)%0.25)%0.10)%0.05) /0.01));
        
    }
}