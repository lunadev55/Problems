using System;
using System.Collections.Specialized;
using System.Runtime.Serialization;

class URI
{
    // Array Fill 3 (Wrong answer 5%, locally the failing test cases gives
    // the correct output but on the beecrowd server it does not)
    public static void Main(string[] args)
    {
        double value = Convert.ToDouble(Console.ReadLine());

        double[] numbers = new double[100];

        numbers[0] = value;
        Console.WriteLine($"N[{0}] = {numbers[0]:F4}");

        for (int i = 1; i < 100; i++) 
        {
            numbers[i] = numbers[i - 1] / 2;
            Console.WriteLine($"N[{i}] = {numbers[i]:F4}");
        }        
             
    }   

}
