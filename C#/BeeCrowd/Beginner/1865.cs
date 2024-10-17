using System;
using System.Runtime.ExceptionServices;
class URI {   
    static void Main(string[] args) {
        int testCases = int.Parse(Console.ReadLine());

        while (testCases > 0)
        {
            string input = Console.ReadLine().Split(' ')[0];

            if (input == "Thor")
                Console.WriteLine("Y");
            else
                Console.WriteLine("N");

            testCases--;
        }
    }
}
