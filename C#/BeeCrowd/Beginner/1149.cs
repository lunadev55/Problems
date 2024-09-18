using System; 

class URI {
    static void Main(string[] args) { 

        string input = Console.ReadLine();
        string[] values = input.Split(' ');

        int startFrom = 0;
        int numberOfIntegers = 0;

        if (values.Length == 2)
        {
            startFrom = Convert.ToInt32(values[0]);
            numberOfIntegers = Convert.ToInt32(values[1]);
        }
        else
        {
            startFrom = Convert.ToInt32(values[0]);
            numberOfIntegers = Convert.ToInt32(values[values.Length - 1]);
        }

        int sum = 0;
        while (numberOfIntegers > 0)
        {
            sum += (startFrom++);
            numberOfIntegers--;
        }
        
        Console.WriteLine(sum);
    }
}