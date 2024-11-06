using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
class URI {   
    static void Main(string[] args) {
        var itemAndPrice = new Dictionary<short, float>
        {
            {1001, 1.50f},
            {1002, 2.50f},
            {1003, 3.50f},
            {1004, 4.50f},
            {1005, 5.50f}         
        };

        short numberOfPurchases = Convert.ToInt16(Console.ReadLine());
        float total = 0;

        while (numberOfPurchases > 0)
        {
            string input = Console.ReadLine();            
            short product = Convert.ToInt16(input.Split(' ')[0]);
            short quantity = Convert.ToInt16(input.Split(' ')[1]);

            total += (itemAndPrice[product] * quantity);     
            numberOfPurchases--;
        }

        Console.WriteLine($"{total:F2}");
    }
}
