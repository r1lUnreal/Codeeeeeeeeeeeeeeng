using System;
using System.Collections.Generic;

// Практика A
class Item
{
    public string Title { get; set; }
    public string Author { get; set; }

    public Item(string title, string author)
    {
        Title = title;
        Author = author;
    }

    // Практика B
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Item: {Title}, Author: {Author}");
    }

    // Практика D
    private bool _isAvailable = true;
    private string _status = "New";

    public bool IsAvailable
    {
        get { return _isAvailable; }
        private set { _isAvailable = value; }
    }

    public string Status
    {
        get { return _status; }
        set
        {
            if (value == "New" || value == "Used" || value == "Damaged")
            {
                _status = value;
            }
            else
            {
                Console.WriteLine("Invalid status. Status can only be 'New', 'Used', or 'Damaged'.");
            }
        }
    }

    // Практика E
    public void Borrow()
    {
        if (IsAvailable)
        {
            IsAvailable = false;
            Console.WriteLine($"{Title} has been borrowed.");
        }
        else
        {
            Console.WriteLine($"{Title} is not available.");
        }
    }

    public void Return()
    {
        IsAvailable = true;
        Console.WriteLine($"{Title} has been returned.");
    }
}

class Book : Item
{
    public Book(string title, string author) : base(title, author) { }

    public void Read()
    {
        Console.WriteLine($"Reading {Title} by {Author}.");
    }

    // Практика B
    public override void DisplayInfo()
    {
        Console.WriteLine($"Book: {Title}, Author: {Author}");
    }
}

class Magazine : Item
{
    public Magazine(string title, string author) : base(title, author) { }

    public void FlipThrough()
    {
        Console.WriteLine($"Flipping through {Title} by {Author}.");
    }

    // Практика B
    public override void DisplayInfo()
    {
        Console.WriteLine($"Magazine: {Title}, Author: {Author}");
    }
}

class DVD : Item
{
    public DVD(string title, string author) : base(title, author) { }

    public void Play()
    {
        Console.WriteLine($"Playing {Title} by {Author}.");
    }

    // Практика B
    public override void DisplayInfo()
    {
        Console.WriteLine($"DVD: {Title}, Author: {Author}");
    }
}

// Практика F
class Library
{
    private List<Item> _items = new List<Item>();

    public void AddItem(Item item)
    {
        _items.Add(item);
        Console.WriteLine($"{item.Title} has been added to the library.");
    }

    public void RemoveItem(Item item)
    {
        if (_items.Remove(item))
        {
            Console.WriteLine($"{item.Title} has been removed from the library.");
        }
        else
        {
            Console.WriteLine($"{item.Title} was not found in the library.");
        }
    }

    public Item FindItemByTitle(string title)
    {
        return _items.Find(item => item.Title == title);
    }

    public void DisplayAllItems()
    {
        Console.WriteLine("Library Items:");
        foreach (var item in _items)
        {
            item.DisplayInfo();
        }
    }
}

class Program
{
    static void Main()
    {
        // Практика A
        Book book = new Book("1984", "George Orwell");
        Magazine magazine = new Magazine("National Geographic", "Various Authors");
        DVD dvd = new DVD("Inception", "Christopher Nolan");

        book.Read();
        magazine.FlipThrough();
        dvd.Play();

        // Практика B
        book.DisplayInfo();
        magazine.DisplayInfo();
        dvd.DisplayInfo();

        // Практика C
        List<Item> items = new List<Item> { book, magazine, dvd };
        DisplayAllItemsInfo(items);

        // Практика D
        book.Status = "Used";
        Console.WriteLine($"Book status: {book.Status}");

        // Практика E
        book.Borrow();
        book.Return();

        // Практика F
        Library library = new Library();
        library.AddItem(book);
        library.AddItem(magazine);
        library.AddItem(dvd);

        library.DisplayAllItems();

        Item foundItem = library.FindItemByTitle("1984");
        if (foundItem != null)
        {
            foundItem.DisplayInfo();
        }

        library.RemoveItem(magazine);
        library.DisplayAllItems();
    }

    // Практика C
    static void DisplayAllItemsInfo(List<Item> items)
    {
        Console.WriteLine("Displaying all items:");
        foreach (var item in items)
        {
            item.DisplayInfo();
        }
    }
}