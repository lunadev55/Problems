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
        int pointerA = 5; int pointerB = 6;
        
        for (int i = 7; i < 12; i++)
        {           
            for (int j = pointerA; j <= pointerB; j++)
            {
                sum += arr[i, j];
            }
            pointerA--; pointerB++;
        }

        if (operation == "S")
            Console.WriteLine($"{Math.Round(sum, 1):F1}");
        else
            Console.WriteLine($"{Math.Round(sum/30, 1):F1}");
    }
}