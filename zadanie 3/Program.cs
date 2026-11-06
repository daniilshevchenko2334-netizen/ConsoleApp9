class Program
{
    static void Main()
    {

        List<int> numbers = new List<int>
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10
        };


        Predicate<int> isEven = x => x % 2 == 0;


        List<int> evenNumbers = numbers
            .Where(x => isEven(x))
            .ToList();

        Console.WriteLine("Четные числа:");

        Action<int> printNumber = x =>
        {
            Console.WriteLine(x);
        };

        foreach (int number in evenNumbers)
        {
            printNumber(number);
        }
    }
}