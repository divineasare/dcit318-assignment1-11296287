using System;

class TicketPriceCalculator
{
    static void Main(string[] args)
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        int price = (age <= 12 || age >= 65) ? 7 : 10;
        Console.WriteLine("Ticket price: GHC" + price);
    }
}
