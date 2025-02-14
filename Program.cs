using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public string Name { get; set; }
    public int Salary { get; set; }

    public Employee(string name, int salary)
    {
        Name = name;
        Salary = salary;
    }
}

class Program
{
    static void Main()
    {
        // Практика A
        Console.WriteLine("Практика A");
        Console.WriteLine(" ");

        List<int> numbers = new List<int> { 10, 20, 30, 40, 500 };
        int totalSum = numbers.Sum();
        Console.WriteLine("Цифарки: " + string.Join(", ", numbers));
        Console.WriteLine("Сумма цифорок: " + totalSum);

        Dictionary<string, int> grades = new Dictionary<string, int>
        {
            { "Алексеич", 85 },
            { "Падла", 90 },
            { "Иваныч", 78 }
        };
        double averageGrade = grades.Values.Average();
        Console.WriteLine("Средняя цифорка: " + averageGrade);

        // Практика B
        Console.WriteLine("\nПрактика B");
        Console.WriteLine(" ");

        List<string> strings = new List<string> { "яблоко", "банан", "вишня", "дата", "арбуз" };
        strings.Sort();
        Console.WriteLine("Строки отсартированы: " + string.Join(", ", strings));

        Dictionary<string, int> products = new Dictionary<string, int>
        {
            { "Багет", 5 },
            { "Пельмени", 3 },
            { "Чай", 10 }
        };
        foreach (var key in products.Keys.ToList())
        {
            products[key]++;
        }
        Console.WriteLine("Из этого всего можно жрать:");
        foreach (var product in products)
        {
            Console.WriteLine($"{product.Key}: {product.Value}");
        }

        // Практика C
        Console.WriteLine("\nПрактика C");
        Console.WriteLine(" ");

        List<Employee> employees = new List<Employee>
        {
            new Employee("Иваныч", 50000),
            new Employee("Падла", 60000),
            new Employee("Алексеич", 55000)
        };
        var sortedEmployees = employees.OrderByDescending(e => e.Salary).ToList();
        Console.WriteLine("Причина для обсирания друг друга в колективе найдена:");
        foreach (var employee in sortedEmployees)
        {
            Console.WriteLine($"{employee.Name}: {employee.Salary}");
        }
    }
}