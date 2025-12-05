using System;

public record Student(string Name, string Surname, int Score);

class Program
{
    static void Main()
    {
        var student1 = new Student("Leyla", "Muradova", 95);

        var (name, surname, score) = student1;

        Console.WriteLine($"Ad:{name} Soyad:{surname} Bal:{score}");
    }
}
