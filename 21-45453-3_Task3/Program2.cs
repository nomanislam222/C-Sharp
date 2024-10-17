using System;

class bank_account
{
    public string acc_number { get; set; }
    public string holder_name { get; set; }
    public double balance { get; set; }

    public bank_account(string Acc_number, string Holder_name, double balance)
    {
        acc_number = Acc_number;
        holder_name = Holder_name;
        balance = balance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited BDT{amount} New balance: BDT{balance}");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount. Please deposit a positive amount.");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn BDT{amount} New balance: BDT{balance}");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
        }
    }

    public void ShowBalance()
    {
        Console.WriteLine($"Account Number: {acc_number}");
        Console.WriteLine($"Holder Name: {holder_name}");
        Console.WriteLine($"Current Balance: BDT{balance}");
    }
}

class Program2
{
    static void Main(string[] args)
    {
        bank_account myAccount = new bank_account("225960032650", "Noman Islam", 0000);

        myAccount.Deposit(500.00);
        myAccount.Withdraw(300.00);
        myAccount.ShowBalance();
    }
}
