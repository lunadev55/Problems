using System;
using System.Runtime.ExceptionServices;
class URI {   
    static void Main(string[] args) {
        string pair = Console.ReadLine();
        string[] pairAsArray = pair.Split(' ');

        if (Convert.ToInt16(pairAsArray[0]) > Convert.ToInt16(pairAsArray[1]))        
            Console.WriteLine(pairAsArray[0]);        
        else        
            Console.WriteLine(pairAsArray[1]);        
    }
}
