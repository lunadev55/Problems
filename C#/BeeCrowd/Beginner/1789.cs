using System; 
class URI {
    static void Main(string[] args) {
        string numberOfSlugs = Console.ReadLine();

        while (numberOfSlugs != null)
        {
            string speedsOfEachSlug = Console.ReadLine();
            string[] speedsOfEachSlugAsArray = speedsOfEachSlug.Split(' ');
            int fastestSlug = 0;

            for (int i = 0; i < speedsOfEachSlugAsArray.Length; i++)
            {
                int speedAsInt = int.Parse(speedsOfEachSlugAsArray[i]);

                if (speedAsInt > fastestSlug)
                    fastestSlug = speedAsInt;
            }

            if (fastestSlug < 10)
                Console.WriteLine(1);
            else if (fastestSlug >= 10 && fastestSlug < 20)
                Console.WriteLine(2);
            else
                Console.WriteLine(3);

            numberOfSlugs = Console.ReadLine();
        }
    }
}
