using System;
using System.Text;
using System.Linq;

class URI
{
    static void Main(string[] args)
    {
        var testCases = short.Parse(Console.ReadLine());

        while (testCases > 0)
        {
            var input = Console.ReadLine();
            var numberOfRightShifts = short.Parse(Console.ReadLine());

            Console.WriteLine(CaesarCipher(input, numberOfRightShifts));

            testCases--;
        }
    }

    static string CaesarCipher(string input, short numberOfRightShifts)
    {
        string newValue = string.Empty;
        for (int index = 0; index < input.Length; index++)
        {
            int newCharValue = input[index] - numberOfRightShifts;            

            if (newCharValue < 65)
            {                
                newValue += (char)((input[index] % 65) + (91 - numberOfRightShifts));
            }
            else
            {
                newValue += (char)(input[index] - numberOfRightShifts);
            }
        }

        return newValue;
    }
}