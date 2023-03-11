using System; 
using System.Globalization;

class URI {      
    private static string AddsMissingZeros(string amount) {
        int lastIndexOfDot = amount.LastIndexOf('.');

        if (lastIndexOfDot == -1) {
            amount += ".00";
        }
        else {
            if (amount.Length - lastIndexOfDot == 2) {
                amount += '0';
            }
        }
        return amount;
    }

    static void Main(string[] args) {

        double totalAmountToBePaid = 0.0;

        for (int i=0;i<2;i++) {
            string input = Console.ReadLine();
            string[] inputSplit = input.Split(' ');

            string productCode = inputSplit[0];
            int numberOfProducts = int.Parse(inputSplit[1]);
            double pricePerUnit = Convert.ToDouble(inputSplit[2], CultureInfo.InvariantCulture);

            double amountToBePaid = numberOfProducts * pricePerUnit;

            totalAmountToBePaid += amountToBePaid;
        }    

        string finalTotalAmountToBePaidAsString = AddsMissingZeros(Math.Round(totalAmountToBePaid, 2)
                                                        .ToString(CultureInfo.CreateSpecificCulture("en-GB")));

        Console.WriteLine($"VALOR A PAGAR: R$ {finalTotalAmountToBePaidAsString}");
    }    
}   