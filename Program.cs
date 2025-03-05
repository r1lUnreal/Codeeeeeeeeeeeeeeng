using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Агрегатные функции
            int[] numbers = {1,2,3,4,5,6,7,8,9,8,7,6,5,4,3,2,1};

            //Console.WriteLine(numbers.Sum()); Суммирует
            //Console.WriteLine(numbers.Average()); Среднее арифмитическое
            //Console.WriteLine(numbers.Min()); Максимальное значение
            //Console.WriteLine(numbers.Max()); Минимальное значение
            //Console.WriteLine(numbers.Length);
            //Console.WriteLine(numbers.Count()); Сколько всего чисел в массиве
            //Console.WriteLine(numbers.Count(n => n>5)); Выводить колличество чисел которые больше 5


            //Объединение, пересичение и исключение
            List<int> list1 = new List<int> {1,2,3,4,5};
            List<int> list2 = new List<int> {4,5,6,7,8};

            //var union = list1.Union(list2); Объединение
            //var intersection = list1.Intersect(list2); Пересичение
            //var except = list1.Except(list2); Исключение

            //Console.WriteLine(string.Join(", ", union));
            //Console.WriteLine(string.Join(", ", intersection));
            //Console.WriteLine(string.Join(", ", except));
        }
    }
}