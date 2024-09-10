using System; 

class URI {
    static void Main(string[] args) { 

        string operation = Console.ReadLine();
        double[,] arr = new double[12, 12];

        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                arr[i, j] = double.Parse(Console.ReadLine());            
            }
        }

        int subtractor = 1;
        double sum = 0;

        for (int i = 0; i < 11; i++)
        {
            for (int j = 0; j < (12 - subtractor); j++)
            {               
                sum += arr[i, j];
            }
            subtractor++;            
        } 

        if (operation == "S")
        {
            Console.WriteLine(Math.Round(sum, 1));
        }
        else
        {
            Console.WriteLine(Math.Round(sum/66, 1));
        }
    }
}