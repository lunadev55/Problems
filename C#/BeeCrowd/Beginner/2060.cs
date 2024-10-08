using System; 
class URI {
    public static bool isMultipleOf(int value, int num)
    {
        if (value % num == 0)
            return true;
        return false;
    }
    static void Main(string[] args) {
         int value = Convert.ToInt32(Console.ReadLine());
         
         string inputAsStr = Console.ReadLine();
         string[] input = inputAsStr.Split(' ');

         int two = 0; int three = 0; int four = 0; int five = 0;

         for (int i = 0; i < input.Length; i++)
         {
            int v = Convert.ToInt32(input[i]);

            if (isMultipleOf(v, 2))
                two++;
            if (isMultipleOf(v, 3))
                three++;
            if (isMultipleOf(v, 4))
                four++;
            if (isMultipleOf(v, 5))
                five++;
         }         

         Console.WriteLine($"{two} Multiplo(s) de 2");
         Console.WriteLine($"{three} Multiplo(s) de 3");
         Console.WriteLine($"{four} Multiplo(s) de 4");
         Console.WriteLine($"{five} Multiplo(s) de 5");
    }
}