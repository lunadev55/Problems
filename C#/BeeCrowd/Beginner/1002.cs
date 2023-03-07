using System; 
using System.Globalization;

class URI {
    public static string AddsLastZeroToMissingResults(string areaOfCircle) {
       
        var numberOfDigitsAfterDecimalPoint = 
            (areaOfCircle.Length) -
            (areaOfCircle.Substring(0, areaOfCircle.LastIndexOf('.') + 1).Length);

        if (numberOfDigitsAfterDecimalPoint == 3) {
            areaOfCircle += '0';
        }

        return areaOfCircle;        
    }

    // trick problem because you have to deal with different float precision separators (',', '.')
    static void Main(string[] args) {  

        const double pi = 3.14159;

        var radius = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

        var areaOfCircle = Math.Round(pi * Math.Pow(radius, 2), 4);

        var areaOfCircleWithDotSeparator = areaOfCircle.ToString(
            CultureInfo.CreateSpecificCulture("en-GB"));        

        Console.WriteLine($"A={AddsLastZeroToMissingResult(areaOfCircleWithDotSeparator)}");
    }

}