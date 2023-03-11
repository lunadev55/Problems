using System; 
using System.Globalization;

class URI {      
    private static string AddsMissingZeros(string salary) {
        int lastIndexOfDot = salary.LastIndexOf('.');
        if (lastIndexOfDot == -1) {
            salary += ".00";
        }
        else {
            if (salary.Length - lastIndexOfDot == 2) {
                salary += '0';
            }
        }
        return salary;
    }

    static void Main(string[] args) {     
        
        string sellerName = Console.ReadLine();
        double sellerSalary = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
        double totalSalesBySeller = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

        double sellerFinalSalary = sellerSalary + (totalSalesBySeller * 0.15);

        string sellerFinalSalaryAsString = Math.Round(sellerFinalSalary, 2)
                            .ToString(CultureInfo.CreateSpecificCulture("en-GB"));

        Console.WriteLine($"TOTAL = R$ {AddsMissingZeros(sellerFinalSalaryAsString)}");        
        
    }
}   