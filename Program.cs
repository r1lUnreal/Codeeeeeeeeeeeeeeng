using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class Program
{
    static void Main()
    {
        List<Person> people = new List<Person>
        {
            new Person("Фуфелшмерц", 000),
            new Person("Чубака", 000),
            new Person("Алёша", 24),
            new Person("Ольга", 60),
            new Person("Илья", 15)
        };

        var groupePeople = people.GroupBy(p => p.Age);

        foreach (var group in groupePeople)
        {
            Console.WriteLine($"Возраст: {group.Key}");
            foreach (var person in group)
            {
                Console.WriteLine($" - {person.Name}");
            }
        }
    }
}

// У тоби е эбупрофен? Голова болить...