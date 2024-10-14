using System; 
class URI {
    static bool IsValidScore(float score)
    {
        if (score < 0 || score > 10)
            return false;
        return true;
    }
    static void Main(string[] args) {
        while (true)
        {
            float scoreA = float.Parse(Console.ReadLine());
            while (!IsValidScore(scoreA))
            {
                Console.WriteLine("nota invalida");
                scoreA = float.Parse(Console.ReadLine());
            }

            float scoreB = float.Parse(Console.ReadLine());        
            while (!IsValidScore(scoreB))
            {
                Console.WriteLine("nota invalida");
                scoreB = float.Parse(Console.ReadLine());
            }

            float average = (scoreA + scoreB) / 2;            
            Console.WriteLine($"media = {average:F2}");
            
            int input = 0;
            while (input != 1 && input != 2)
            {
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                input = int.Parse(Console.ReadLine());                
            }

            if (input == 2)
                break;
        }        
    }
}
