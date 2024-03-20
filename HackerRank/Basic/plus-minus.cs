using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        double positive = 0; double negative = 0; double zero = 0;
        foreach (var element in arr)
        {
            if (element > 0)            
                positive++;
            else if (element == 0)
                zero++;
            else if (element < 0)
                negative++;            
        }
        
        int n = arr.Count;        
                
        Console.WriteLine((positive/n).ToString("F6"));
        Console.WriteLine((negative/n).ToString("F6"));
        Console.WriteLine((zero/n).ToString("F6"));
    }   

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
