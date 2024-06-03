namespace FileIOOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] content = File.ReadAllLines("leesdezefile.txt");
            
            for (int i = 0; i < content.Length; i++)
            {
                Console.WriteLine(content[i]);
            }

            File.Create("mijnnieuwefile.txt").Dispose();
            File.AppendText("Append");

            Directory.CreateDirectory("output");

            File.Move("mijnnieuwefile.txt","output/mijnnieuwefile.txt");

            Console.WriteLine("Hello, World!");
        }
    }
}
