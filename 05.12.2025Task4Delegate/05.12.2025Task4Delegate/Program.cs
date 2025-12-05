class Program
{
    static void Main(string[] args)
    {
        List<double> salaries = new List<double> { 500, 600, 700, 1100, 1200 };

        Predicate<double> predicate = num => num > 1000;

        List<double> filteredSalary = salaries.FindAll(predicate);

        foreach (var salary in filteredSalary)
        {
            Console.WriteLine(salary);
        }
    }
}