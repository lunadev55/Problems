using System; 
class URI {
    static void Main(string[] args) {   
        int value = Convert.ToInt32(Console.ReadLine());
        while (value > 0)
        {
            if (value == 1)
            {
                Console.WriteLine("  1");
                Console.WriteLine();
            }                
            else
            {
                int[,] matrix = new int[value, value];
                Array.Clear(matrix, 0, matrix.Length);

                int aux = 1;

                for (int i = 0; i < value; i++)
                {
                    for (int j = i; j < value; j++)
                    {
                        matrix[i, j] = aux;
                        matrix[j, i] = aux;
                        aux++;
                    }
                    aux = 1;
                }

                for (int i = 0; i < value; i++)
                {
                    for (int j = 0; j < value; j++)
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
            value = Convert.ToInt32(Console.ReadLine());
        }
    }
}