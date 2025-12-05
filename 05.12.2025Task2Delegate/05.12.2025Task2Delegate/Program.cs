class Program
{
    static void Main(string[] args)
    {
        Action<string, int> updateStock = (productName, count) =>
        {
            Console.WriteLine($"Anbarda {productName} qalığı yenilendi. Yeni say: {count}");

        };
        updateStock("Book", 50);
    }
}
