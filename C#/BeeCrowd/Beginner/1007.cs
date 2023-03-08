using System; 
using System.Globalization;

class URI {
 
    static void Main(string[] args) {  
        
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());
        int fouthNumber = int.Parse(Console.ReadLine());

        int finalResult = (firstNumber * secondNumber) - (thirdNumber * fouthNumber);

        Console.WriteLine($"DIFERENCA = {finalResult}");
    }
}   