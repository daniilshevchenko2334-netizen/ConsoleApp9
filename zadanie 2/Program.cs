class Program
{
    static void Main()
    {
        Func<int, int, int> sum = (a, b) =>
        {
            Console.WriteLine($"Складываем {a} + {b}");
            return a + b;
        };

        int result = sum(6, 8);

        Console.WriteLine($"Результат: {result}");

        Func<string, int> getLength = text => text.Length;

        Console.WriteLine($"Длина строки 'Hello': {getLength("Hello")}");
        Console.WriteLine($"Длина строки 'C#': {getLength("C#")}");
        Console.WriteLine($"Длина строки 'Привет': {getLength("Привет")}");
    }
}