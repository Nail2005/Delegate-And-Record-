class Program
{
    static void Main(string[] args)
    {
        Func<int, int> calculateAge = birhtyear => DateTime.Now.Year - birhtyear;

        int age = calculateAge(2003);

        Console.WriteLine($"Age: {age}");
    }
}