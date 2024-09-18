using System; 

class URI {
    static void Main(string[] args) { 

        string operation = Console.ReadLine();
        double[,] m = new double[12, 12];              

        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                m[i, j] = Convert.ToDouble(Console.ReadLine());
            }
        } 

        int helper = 1;     
        double sum = 0;

        for (int i = (12 - helper); i >= 0; i--)
        {
            for (int j = helper; j < 12; j++)
            {
                sum += m[i, j];
            }
            helper++;
        }

        if (operation.Equals("S"))
            Console.WriteLine(Math.Round(sum, 1));
        else
            Console.WriteLine(Math.Round((sum/66), 1));
    }
}