using System;

class Product
{
    public string name { get; set; }
    public double price { get; set; }
    public int qty { get; set; }

    public Product(string n, double p, int quantity)
    {
        name = n;
        price = p;
        qty = quantity;
    }

    public double CalculateTotalCost()
    {
        return price * qty;
    }
}

class Program3
{
    static void Main(string[] args)
    {
        Product myproduct = new Product("Chips", 15, 50);

        double totalCost = myproduct.CalculateTotalCost();

        Console.WriteLine($"Product: {myproduct.name}");
        Console.WriteLine($"Price: BDT{myproduct.price}");
        Console.WriteLine($"Quantity: {myproduct.qty}");
        Console.WriteLine($"Total Cost: BDT{totalCost}");
    }
}
