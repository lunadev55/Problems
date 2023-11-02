using System.ComponentModel;
using System.Reflection;

class BinarySearch {

    static bool BinarySearchImplementation(int[] arr, int value) {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right) {
           int half = (left + right) / 2;

            if (arr[half] == value) {                
                return true;
            }
            else {
                if (arr[half] > value) {
                    right = half - 1;                  
                }
                else if (arr[half] < value) {
                    left = half + 1;                 
                }              
            }           
        }
        return false;
    }
    static void Main(string[] args) {
        int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine("Type number to be searched on the array: ");
        
        var value = Convert.ToInt32(Console.ReadLine());

        bool result = BinarySearchImplementation(arr, value);

        Console.WriteLine(result);
    }
}