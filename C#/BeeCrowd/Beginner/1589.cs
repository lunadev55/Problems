using System; 
class URI {
    static void Main(string[] args) {   
        int testCases = Convert.ToInt32(Console.ReadLine());

        while (testCases > 0)
        {
            string input = Console.ReadLine();

            int r1 = Convert.ToInt32(input.Split(' ')[0]);
            int r2 = Convert.ToInt32(input.Split(' ')[1]);

            Console.WriteLine(r1 + r2);
            testCases--;
        }        
    }
}