using System;
using System.Linq;

namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();

            int index = path.LastIndexOf('\\');
            path = path.Remove(0, index + 1);

            string[] fileComponents = path.Split('.');

            Console.WriteLine($"File name: {fileComponents[0]}\nFile extension: {fileComponents[1]}");
        }
    }
}
