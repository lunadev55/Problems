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
     * Complete the 'flippingBits' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts LONG_INTEGER n as parameter.
     */

    public static long flippingBits(long n)
    {
        string longValueAsString = Convert.ToString(n, 2);       

        char[] bits = new char[32];
        int count = 0; int helper = longValueAsString.Length - 1;

        for (int i = 31; i >= 0; i--)
        {
            if (count < longValueAsString.Length)
            {
                bits[i] = longValueAsString[helper--];
                count++;
            }
            else
            {
                bits[i] = '0';
            }
        }

        char[] flippedBitsArray = bits.Select(c => c == '0' ? '1' : '0').ToArray();
        string flippedBinaryValueAsString = new string(flippedBitsArray);

        long flipperValueAsLongBase10 = Convert.ToInt64(flippedBinaryValueAsString, 2); 
        return flipperValueAsLongBase10;      
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            long n = Convert.ToInt64(Console.ReadLine().Trim());

            long result = Result.flippingBits(n);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
