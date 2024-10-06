using System; 
class URI {
    static void Main(string[] args) {   
        string powerStrips = Console.ReadLine();
        string[] strips = powerStrips.Split(' ');
        int maxDeviceNum = 0; 

        for (int i = 0; i < strips.Length; i++)
        {
            maxDeviceNum += Convert.ToInt32(strips[i]);
        }

        Console.WriteLine(maxDeviceNum - 3);
    }
}