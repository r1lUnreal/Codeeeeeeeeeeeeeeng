using System;

public class Item 
{
    public string Title;
    public string Author;
    private string Status;
    private bool Nalik;

    public Item (string title, string author) // конструктор
    {
        Title = title;
        Author = author;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Делает");
    }

    public void status_displey() // доступ к приватной строке
    {
        Console.WriteLine(Status);
    }

    public void nalik_displey()
    {
        Console.WriteLine(Nalik);
    }

    public void status_set(string new_status)
    {
        Status = new_status;
    }

    public void nalik_set(bool new_nalik)
    {
        Nalik = new_nalik;
    }
}

class Book : Item
{
    public void Read()
    {
        Console.WriteLine("Читаю");
    }

    public Book(string title, string author) : base(title, author)
    {

    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"книгу: {Title}, автора {Author}");
    }
}

class Magazine : Item
{
    public void FlipThrough()
    {
        Console.WriteLine("Листаю");
    }

    public Magazine(string title, string author) : base(title, author)
    {
        
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"журнал автора: {Author}, под названием: {Title}");
    }
}

class DVD : Item
{
    public void Play()
    {
        Console.WriteLine("Смотрю");
    }

    public DVD(string title, string author) : base(title, author)
    {
        
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"кино: {Title}, автора: {Author}");
    }
}

public class Program
{
    public static void Main()
    {
        Book book1 = new Book("METRO 2033", "Дмитрий Глуховский");
        Magazine magazine1 = new Magazine("Очередной последний писк", "Конечно я");
        DVD dVD1 = new DVD("Сваты", "Квартал 95");

        List<Item> list_item = new List<Item> {book1, magazine1, dVD1};
        list_item.Add(book1);
        list_item.Add(magazine1);
        list_item.Add(dVD1);

        foreach(Item b in list_item)
        {
            b.DisplayInfo();
        }

        book1.status_set("Open");
        book1.status_displey();
    }
}

// если что-то в скобках то надо писать (int, string)
// навход принял в скобках пиши