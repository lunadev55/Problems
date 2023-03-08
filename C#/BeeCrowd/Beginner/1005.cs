using System; 
using System.Globalization;

class URI {
    public static string AddsMissingZeros(string medium) {
        if (medium.LastIndexOf('.') == -1) {
            medium += ".00000";
        }
        return medium;
    }

    static void Main(string[] args) {  
        double gradeOne = Convert.ToDouble(
            Console.ReadLine(), CultureInfo.InvariantCulture);

        double gradeTwo = Convert.ToDouble(
            Console.ReadLine(), CultureInfo.InvariantCulture);

        double medium = 
            ((3.5 * gradeOne) + (7.5 * gradeTwo)) / ((3.5)  + (7.5));

        Console.WriteLine($"MEDIA = {AddsMissingZeros(Math.Round(medium, 5)
                                .ToString(CultureInfo.CreateSpecificCulture("en-GB")))}");

    }
}   