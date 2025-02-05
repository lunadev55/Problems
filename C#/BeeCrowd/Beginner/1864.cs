using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.Contracts;
using System.Runtime.ExceptionServices;
class URI {   
    static void Main(string[] args)
    {
        string sentence = "LIFE IS NOT A PROBLEM TO BE SOLVED";

        short numberOfChars = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine(sentence.Substring(0, numberOfChars));
    }          
}
