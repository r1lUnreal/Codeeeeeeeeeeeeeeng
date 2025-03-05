using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> words = new List<string> { "cat", "dog", "elephant", "tiger", "bear" };
            var spisok = words.Where(n => n.Length>3).Select(n => n.ToUpper());
            
            Console.WriteLine(string.Join(" ", spisok));
        }
    }
}