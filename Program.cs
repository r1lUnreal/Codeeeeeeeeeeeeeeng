using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Задание 1
        Dictionary<string, int> dataDict = new Dictionary<string, int>()
        {
            { "a", 10 },
            { "b", 20 },
            { "фуфелшмерц", 42 }
        };

        Console.Write("Введите ключ: ");
        string key = Console.ReadLine() ?? "";

        try
        {
            Console.WriteLine($"Значение ключа '{key}': {dataDict[key]}");
        }
        catch (KeyNotFoundException)
        {
            Console.WriteLine($"Ошибка: ключ '{key}' не найден!");
        }

        // Задание 2
        try
        {
            Console.Write("Введите чсло: ");
            int one = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Введите чсло: ");
            int two = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Ответ: {one / two}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Ошибка: делить на ноль нельзя!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: это ты! Вводишь всё неправльно.");
        }

        // Задание 3
        Console.WriteLine("Прога пашет. Нажми что-то чтобы она пошла в жопу...");
        Console.ReadKey();
    }
}