using System;
using System.Linq;

namespace file
{
    class Program
    {
        static void Main(string[] args)
        {
             string[] filePath = Console.ReadLine().Split("\\");
            string[] file = filePath[filePath.Length - 1].Split(".");
            string ext = file[file.Length - 1];
            
            string[] name = file.Take(file.Length - 1).ToArray() ;
            string str=string.Join(".", name, 0, name.Length);
            
            Console.WriteLine($"File name: {str}");
            Console.WriteLine($"File extension: {ext}");
        }
    }
}
