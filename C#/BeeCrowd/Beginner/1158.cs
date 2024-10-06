using System; 
class URI {
    static void Main(string[] args) {   
        int testCases = Convert.ToInt32(Console.ReadLine());

        while (testCases > 0)
        {
            string input = Console.ReadLine();
            string[] values = input.Split(' ');

            int x = Convert.ToInt32(values[0]);
            int y = Convert.ToInt32(values[1]);

            int yOdds = 0; int sum = 0;

            while (true)
            {
                if (yOdds == y)
                    break;
                if (x % 2 != 0)
                {
                    yOdds++;
                    sum += x;
                }                
                x++;
            }
            Console.WriteLine(sum);            
            testCases--;
        }
    }
}