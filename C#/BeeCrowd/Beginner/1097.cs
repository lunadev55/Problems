using System; 

class URI {

    static void Main(string[] args) { 

        int i = 1;
        int j = 7;
        int counter = 0;

        while (i < 10) {
            Console.WriteLine($"I={i} J={j - counter}");
            counter++;

            if (counter == 3) {   
                i += 2;      
                j += 2;
                counter = 0;
            }
        }
    }

}
