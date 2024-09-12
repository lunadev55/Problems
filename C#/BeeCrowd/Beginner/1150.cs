using System; 

class URI {

    static void Main(string[] args) { 

        int x = Convert.ToInt32(Console.ReadLine());
        int z = Convert.ToInt32(Console.ReadLine());

        while (z <= x)
        {
            z = Convert.ToInt32(Console.ReadLine());
        }

        int numberOfIntegers = 1;
        int index = x;

        while (x <= z)
        {
            x += (index++);            
            numberOfIntegers++;
        }

        Console.WriteLine(numberOfIntegers);
    }
}