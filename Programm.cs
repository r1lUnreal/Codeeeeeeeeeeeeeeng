using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            // словари
            Dictionary<string, List<int>> dict = new Dictionary<string, List<int>> 
            {
                {"Петя Даун:", new List<int> {3, 2, 5, 1}}, 
                {"Николай Васильевич Даунов:", new List<int> {3, 2, 2, 1}}, 
                {"Зубенко Михаил Петрович:", new List<int> {5, 5, 5, 4}},
                {"Наталья Морская Пехота:", new List<int> {3, 5, 5, 1}},
                {"Фуфелшмерц:", new List<int> {3, 5, 5, 5}}
            };
            
            foreach (string i in dict.Keys)
            {
                string grad = " ";
                foreach (int j in dict[i])
                {
                    grad += " " + Convert.ToString(j);
                }
                Console.WriteLine(i + " " + grad);
            }
        }
    }
}