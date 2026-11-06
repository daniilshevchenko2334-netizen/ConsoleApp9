class Program
{
    delegate int MathOperation(int x, int y);

    static void CalculateAndPrint(int a, int b, MathOperation op)
    {
        int result = op(a, b);
        Console.WriteLine("Результат: " + result);
    }

    static void Main()
    {
        int bonus = 7;

        CalculateAndPrint(8, 2, delegate (int x, int y)
        {
            return x * y;
        });

        CalculateAndPrint(8, 2, delegate (int x, int y)
        {
            return x + y + bonus;
        });
    }
}