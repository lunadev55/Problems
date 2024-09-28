using System; 

class URI {
    static void Main(string[] args) {        
        while (true)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 0) break;
            
            int innerMostValue = (n + 1) / 2;
            int a = 0; int b = (n - 1);
            int[,] matrix = new int[n, n];

            for (int v = 1; v <= innerMostValue; v++)
            {
                for (int i = a; i <= b; i++)
                {
                    for (int j = a; j <= b; j++)
                    {
                        matrix[i, j] = v;
                    }
                }
                a++; b--;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == 0)
                        Console.Write($"{matrix[i, j], 3}");
                    else
                        Console.Write($" {matrix[i, j], 3}");
                }
                Console.WriteLine();
            }

            Console.WriteLine();            
        }
    }
}