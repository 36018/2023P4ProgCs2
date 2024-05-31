using System.Reflection.PortableExecutable;
using System;
using System.IO;

namespace FileDirOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Celin\Documents\mediacollege\bewijzenmap\periode 4\prog\2023P4ProgCs2");

            FileInfo[] files = dir.GetFiles();
            DirectoryInfo[] directories = dir.GetDirectories();

            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine(files[i]);
            }
            for (int i = 0; i < directories.Length; i++)
            {
                Console.WriteLine(directories[i]);
            }

        }
    }
}
