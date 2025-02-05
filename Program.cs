using System;

public class Item 
{
    public string Title;
    public string Author;

    public Item (string title, string author) 
    {
        Title = title;
        Author = author;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Делает");
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
        Console.WriteLine($"книгу: {Author}, под названием {Title}");
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
        Console.WriteLine($"кино автора: {Author}, под названием: {Title}");
    }
}

public class Program
{
    public static void Main()
    {
        Book book1 = new Book("METRO 2033", "Дмитрий Глуховский");
        Magazine magazine1 = new Magazine("Очередной последний писк", "Конечно я");
        DVD dVD1 = new DVD("Сваты", "Квартал 95");
        book1.Read();
        book1.DisplayInfo();
        magazine1.FlipThrough();
        magazine1.DisplayInfo();
        dVD1.Play();
        dVD1.DisplayInfo();
    }
}