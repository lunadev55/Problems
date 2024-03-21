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
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        int hours = Convert.ToInt16(s.Substring(0, 2));
        string zero = "00";
               
        if (s.Contains("PM"))
        {   
            if (hours != 12)
            {
                hours += 12;
                StringBuilder str = new StringBuilder();
                str.Append(hours);
                str.Append(s.Substring(2, 6));                
                return str.ToString();
            }                                             
            return s.Substring(0, s.Length - 2);
        }
        else
        {                       
            if (hours == 12)
            {
                hours -= 12;
                StringBuilder str = new StringBuilder();
                str.Append(zero);
                str.Append(s.Substring(2, 6));            
                return str.ToString();
            }          
            return s.Substring(0, s.Length - 2);            
        }              
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
