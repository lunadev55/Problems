using System; 
class URI {
    static void Main(string[] args) {
         int testCases = Convert.ToInt32(Console.ReadLine());

         while (testCases > 0)
         {
            int value = Convert.ToInt32(Console.ReadLine());

            if (value % 2 == 0)
                Console.WriteLine(0);
            else
                Console.WriteLine(1);

            testCases--;
         }
    }
}