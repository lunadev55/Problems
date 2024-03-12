using System;

class URI
{
    public static void Main(string[] args)
    {             
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++) {            
            Console.WriteLine($"{i} {i*i} {i*i*i}");
        }
    }    
}
