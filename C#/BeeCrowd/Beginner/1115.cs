// 1115 - QUADRANT
using System; 

class URI {

    static void Main(string[] args) { 

        int coordinateX, coordinateY;

        while (true)    {

            // Getting user input on a single line and processing it
            string[] input = Console.ReadLine().Split(' ');

            coordinateX = Convert.ToInt32(input[0]);
            coordinateY = Convert.ToInt32(input[1]);          

            if (coordinateX > 0 && coordinateY > 0) {
                Console.WriteLine("primeiro");
            }
            else if (coordinateX < 0 && coordinateY > 0) {
                Console.WriteLine("segundo");
            }
            else if (coordinateX > 0 && coordinateY < 0) {
                Console.WriteLine("quarto");
            }
            else if (coordinateX < 0 && coordinateY < 0) {
                Console.WriteLine("terceiro");
            } 
            else {
                Environment.Exit(0);
            }
            
        }

    }

}