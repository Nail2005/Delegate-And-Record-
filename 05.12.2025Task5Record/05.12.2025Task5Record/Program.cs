class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order(1, "Ali", 99.99m);
        Order order2 = new Order(1, "Ali", 99.99m);

        if (order1 == order2)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}

public record Order(int orderId, string customerName, decimal totalAmount);