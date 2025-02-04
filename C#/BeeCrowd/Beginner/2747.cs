using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.Contracts;
using System.Runtime.ExceptionServices;
class URI {   
    static void Main(string[] args)
    {
        for (int i = 0; i < 39; i++)
            Console.Write("-");
        Console.WriteLine();

        for (int j = 0; j < 5; j++)
        {
            for (int i = 0; i < 39; i++)
            {
                if (i == 0 || i == 38)
                    Console.Write("|");
                else
                    Console.Write(" ");                
            }
            Console.WriteLine();
        }      

        for (int i = 0; i < 39; i++)
            Console.Write("-");
        Console.WriteLine();
    }          
}
