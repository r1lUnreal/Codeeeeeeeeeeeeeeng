namespace Codeeeeeeeeeeeeeeng;

class Person 
{
    // свойства людей
    public string Name;
    public int Age;
    public int classNumber;

    // Lego для умных (конструктор для инициализации)
    public Person(string name, int age, int classnumber)
    {
        Name = name; 
        Age = age; 
        classNumber = classnumber; 
    }

    // Методы 
    public void helo()
    {
        Console.WriteLine($"Салам! Я мутный тип {Name}. Мне {Age}.");
        Console.WriteLine("Buy tototototottotot");
    }
    public void last(int maxclass)
    {
        int ifyear = maxclass - classNumber;

        //Проверка сколоко осталось учится
        if (ifyear == 0)
        {
            Console.WriteLine("Я закончил школу.");
            Console.WriteLine($"Я учился до {maxclass}");
        }
        else
        {
            Console.WriteLine($"Мне осталось учиться {ifyear} лет.");
            Console.WriteLine($"я буду учиться до {maxclass}");
        }

    }
}

class Program
{
    static void Main(string[] args)
    {
        Person chel = new Person("Викторыч", 12, 6);
        chel.helo();
        chel.last(11);

        Person chel2 = new Person("Саныч", 44, 11);
        chel2.helo();
        chel2.last(11);
    }  
}

//-Как вы относитесь к американцам?
//-Плохо...
//-Почему?
//-Не ну а чё они!?
//-По факту