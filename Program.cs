using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //LINQ-запросы
            int [] numbers = {1,2,3,4,5,6,7,8,9};
            var even_numbers = numbers.Where(n => n%2==0); //Where (отбор отдельных элементов)
            Console.WriteLine(string.Join(", ", even_numbers));                       
            /* foreach(int i in even_numbers)
            {
                Console.WriteLine(i);
            } */

            Console.WriteLine("-----------------------------------------");
            string[] strings = {"afafas", "aa", "aaaa", "a", "b", "aaaaaaa"};
            var even_strings = strings.Where(n => n.Length>=2);
            Console.WriteLine(string.Join(", ", even_strings));

            //SELECT (проекцию - изминение каждого элемента)
            Console.WriteLine("-----------------------------------------");
            int [] num = {1,2,3,4,5,6,7,8,9};
            var squared_num = num.Select(n => n*n);
            Console.WriteLine(string.Join(" ", squared_num));

            Console.WriteLine("-----------------------------------------");
            string[] str = {"afafas", "aa", "aaaa", "a", "b", "aaaaaaa"};
            var select_str = str.Select(n => "!"+n+"!");
            Console.WriteLine(string.Join(" ", select_str));
            Console.WriteLine("-----------------------------------------");

            // ORDERBY (сортировка)
            List<int> number = new List<int> {1,4,5,6,7,1,2,4,7,8,3,2,6};
            //number.Sort();
            var orderby_number = number.OrderBy(n => n); //OrderByDescending - в обратном порядке
            Console.WriteLine(string.Join(" ", orderby_number));
            Console.WriteLine("-----------------------------------------");

            //GroupBy (группировка по определённому принципу)
            var names = new List<string> {"Анна", "Андрея", "Борис", "Богдана", "Владимир"};
            var grouped_names = names.GroupBy(n => n[0]);
            foreach (var group in grouped_names)
            {
                Console.WriteLine(group.Key + ": " +  string.Join(" ", group));
            }

            Console.WriteLine("-----------------------------------------");
            int [] nam = {1,2,3,4,5,6,7,8,9};
            var grouped_nam = nam.GroupBy(n => n%2==0 ? "Пацаны" : "Чушпаны");
            foreach (var group in grouped_nam)
            {
                Console.WriteLine(group.Key + ": " +  string.Join(" ", group));
            }
        }
    }
}