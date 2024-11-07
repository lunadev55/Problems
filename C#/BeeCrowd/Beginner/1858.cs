using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.ExceptionServices;
class URI {   
    static void Main(string[] args)
    {
        short persons = Convert.ToInt16(Console.ReadLine());
        short[] input = Array.ConvertAll(Console.ReadLine().Split(' '), short.Parse);
        short smallest = input[0]; short index = 0;

        for (short i = 0; i < input.Length; i++)
        {
            if (smallest > input[i])
            {
                smallest = input[i];
                index = i;
            }
        }        

        Console.WriteLine(index + 1);
    }
}

// 1858 - theon's answer