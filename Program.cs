using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 3, 5, 7, 9, 2, 4, 6, 8 };
            var sortnumbers = numbers.OrderByDescending(n => n); // сортировка
            var otvet = sortnumbers.Where(n => n > numbers.Average());

            Console.WriteLine(string.Join(" ", otvet));

        }
    }
}