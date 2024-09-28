using System; 

class URI {
    static void Main(string[] args) { 
        int numberOfHos = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < numberOfHos; i++)
        {
            if (i == numberOfHos - 1)
            {
                Console.WriteLine("Ho!");
                return;
            }                
            Console.Write("Ho ");
        }
    }
}