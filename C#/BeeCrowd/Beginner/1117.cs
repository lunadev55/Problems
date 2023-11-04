using System;
using System.ComponentModel.DataAnnotations;

class URI {
    static void Main(string[] args) {

        double scoreA = Convert.ToDouble(Console.ReadLine());
        while (scoreA < 0 || scoreA > 10) {
            Console.WriteLine("nota invalida");
            scoreA = Convert.ToDouble(Console.ReadLine());
        }      

        double scoreB = Convert.ToDouble(Console.ReadLine());
        while (scoreB < 0 || scoreB > 10) {
            Console.WriteLine("nota invalida");
            scoreB = Convert.ToDouble(Console.ReadLine());
        }
        
        double average = (scoreA + scoreB)  / 2;
        Console.WriteLine($"media = { average }");    
        return;      
    }
}