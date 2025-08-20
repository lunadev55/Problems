using System;
using System.Text;
using System.Linq;

class URI
{
    static void Main(string[] args)
    {        
        int testCaseNumber = int.Parse(Console.ReadLine());

        while (testCaseNumber > 0)
        {
            var message = Console.ReadLine();

            var messageStringBuilder = new StringBuilder(message);

            for (int i = 0; i < messageStringBuilder.Length; i++)
            {
                if (char.IsLetter(messageStringBuilder[i]))                
                    messageStringBuilder[i] = (char)(messageStringBuilder[i] + 3);                
            }
                        
            var reversedString = new StringBuilder(
                new string(messageStringBuilder.ToString().ToCharArray().Reverse().ToArray())
            );    

            for (int i = reversedString.Length / 2; i < reversedString.Length; i++)
            {
                reversedString[i] = (char)(reversedString[i] - 1);
            }      

            Console.WriteLine(reversedString);

            testCaseNumber--;
        } 
    }          
}