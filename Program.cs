using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string heh = "gg.txt";
            string data = File.ReadAllText(heh);

            Console.WriteLine(data);
        }
    }
}