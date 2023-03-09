using System; 
using System.Globalization;

class URI {   
    private static string AddsLastMissingZeros(string salaryAsString) {
        if (salaryAsString.LastIndexOf('.') == -1) {
            salaryAsString += ".00";
        }
        else {
            if ((salaryAsString.Length - salaryAsString.LastIndexOf('.')) == 2) {
                salaryAsString += "0";
            }            
        }
        return salaryAsString;
    }

    static void Main(string[] args) {        

        int employeeNumber = int.Parse(Console.ReadLine());
        int workedHoursInAMonth = int.Parse(Console.ReadLine());
        double amountPerHour = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

        double salary = workedHoursInAMonth * amountPerHour;

        Console.WriteLine($"NUMBER = {employeeNumber}");
        Console.WriteLine($"SALARY = U$ {AddsLastMissingZeros(Math.Round(salary, 2).ToString(CultureInfo.
            CreateSpecificCulture("en-GB")))}");
    }
}   