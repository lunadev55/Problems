using System; 
class URI {
    static void Main(string[] args) {   
        string numberOfComplaints;
        while ((numberOfComplaints = Console.ReadLine()) != null)
        {
            int numberOfComplaintsAsInt = Convert.ToInt32(numberOfComplaints);
            string response = numberOfComplaintsAsInt == 0 
                ? "vai ter copa!"
                : "vai ter duas!";            
            Console.WriteLine(response);
        }
    }
}