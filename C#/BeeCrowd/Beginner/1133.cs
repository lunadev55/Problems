using System;

class Program
{
    public static void Main()
    {             
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        if (x > y)
            Swap(ref x, ref y);

        for (int i = (x + 1); i < y; i++) {
            if (i % 5 == 2 || i % 5 == 3)
                Console.WriteLine(i);
        }

    }

    public static void Swap(ref int x, ref int y) {
        int temp = y;
        y = x;
        x = temp;
    }
}
