using System;

class URI
{
    public static void Main(string[] args)
    {
        int testCases = Convert.ToInt32(Console.ReadLine());

        while (testCases > 0) {
            int value = Convert.ToInt32(Console.ReadLine());

            if (isPrime(value))
                Console.WriteLine($"{value} eh primo");
            else
                Console.WriteLine($"{value} nao eh primo");

            testCases--;
        }             
    }    
    public static bool isPrime(int number) {
        int counter = 0;

        // to check whether a number is prime or not, instead of checking if 
        // the value is only divisible by 1 and the value itself, we can check
        // whether the value is only disisible by 1 in the range 1 .. sqrt(value).
        for (int i=1;i<=Math.Sqrt(number);i++) {
            if (number % i == 0)
                counter++;
        }

        if (counter == 1)
            return true;
        return false;
    }
}
