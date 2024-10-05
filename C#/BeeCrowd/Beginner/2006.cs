using System; 
class URI {
    static void Main(string[] args) {   
        int teaType = Convert.ToInt32(Console.ReadLine());
        int correctAnswers = 0;

        string input = Console.ReadLine();
        string[] inputAsArray = input.Split(' ');

        for (int i = 0; i < 5; i++)
        {
            if (Convert.ToInt32(inputAsArray[i]) == teaType)
                correctAnswers++;
        }

        Console.WriteLine(correctAnswers);
    }
}