class Program
{
    static void Main()
    {
        Action<string> greeting = name =>
        {
            Console.WriteLine($"Привет, {name}!");
        };

        greeting("Алинко");

        Predicate<int> isEven = x => x % 2 == 0;

        Console.WriteLine(isEven(4));
        Console.WriteLine(isEven(7));
        Console.WriteLine(isEven(10));
        Console.WriteLine(isEven(15));
    }
}