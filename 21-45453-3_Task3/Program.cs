using System;

class Book
{
    public string title { get; set; }
    public string author { get; set; }
    public int price { get; set; }

    public Book(string Title, string Author, int Price)
    {
        title = Title;
        author = Author;
        price = Price;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Book Details:");
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: BDT" + price);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Book mybook = new Book("Rich Muslim", "Mohammad Ali", 190);
        mybook.DisplayDetails();
    }
}