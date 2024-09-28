using System; 

class URI {
    static void Main(string[] args) { 

        string operation = Console.ReadLine();
        double[,] arr = new double[12, 12];

        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                arr[i, j] = Convert.ToDouble(Console.ReadLine());
            }
        }

        double sum = 0;
        int row = 5;
        int column = 7;

        for (int i = row; i > 0; i--)
        {
            for (int j = column; j < 12; j++)
            {
                sum += arr[i, j];
            }
            row--;
            column++;
        }
       
        row = 6;
        column = 7;

        for (int i = row; i < 11; i++)
        {
            for (int j = column; j < 12; j++)
            {
                sum += arr[i, j];
            }
            row++;
            column++;
        }

        if (operation == "S")
            Console.WriteLine(Math.Round(sum, 1));
        else    
            Console.WriteLine(Math.Round((sum/30), 1));        
    }
}