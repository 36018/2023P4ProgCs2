namespace SplitOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string content = File.ReadAllText("stringsplit.txt");

            string[] keyvalue = content.Split(":");

            Console.WriteLine(keyvalue[0]);

            string[] cijfersPerVak = keyvalue[1].Split(",");

            for (int i = 0; i < cijfersPerVak.Length; i++)
            {
                Console.WriteLine(cijfersPerVak[i]);
            }


            Console.WriteLine(keyvalue[1]);

            Console.WriteLine("Hello, World!");
        }
    }
}
