using System; 
using System.Globalization;

class URI {

    public static string AddsMissingLastZero(string average) {
        if (average.LastIndexOf('.') == -1) {
            average += ".0";
        }
        return average;
    }
 
    static void Main(string[] args) {  
        
        double firstGrade = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
        double secondGrade = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
        double thirdGrade = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

        double average = ((firstGrade * 2) + (secondGrade * 3) + (thirdGrade * 5)) /
                            (2 + 3 + 5);

        Console.WriteLine($"MEDIA = {AddsMissingLastZero(Math.Round(average, 1).ToString(
                                            CultureInfo.CreateSpecificCulture("en-GB")))}");
    }
}   