using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.Contracts;
using System.Runtime.ExceptionServices;
class URI {   
    static void Main(string[] args)
    {
        short score = Convert.ToInt16(Console.ReadLine());

        if (score == 0)
            Console.WriteLine("E");
        else if (score >= 1 && score <= 35)
            Console.WriteLine("D");
        else if (score >= 36 && score <= 60)
            Console.WriteLine("C");
        else if (score >= 61 && score <= 85)
            Console.WriteLine("B");
        else
            Console.WriteLine("A");
    }          
}
