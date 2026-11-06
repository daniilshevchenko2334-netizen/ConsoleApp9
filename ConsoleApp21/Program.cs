public class Repository<T>
{
    private List<T> items = new List<T>();

    public void Add(T item)
    {
        items.Add(item);
    }

    public T GetAt(int index)
    {
        return items[index];
    }

    public List<T> GetAll()
    {
        return items;
    }

    public int Count
    {
        get { return items.Count; }
    }
}

public static class Helper
{
    public static void Swap<TValue>(ref TValue a, ref TValue b)
    {
        TValue temp = a;
        a = b;
        b = temp;
    }
}

class Program
{
    static void Main()
    {
        Repository<int> numbers = new Repository<int>();

        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);

        Console.WriteLine("Элемент с индексом 1: " + numbers.GetAt(1));
        Console.WriteLine("Количество: " + numbers.Count);

        Console.WriteLine("Все элементы:");
        foreach (int number in numbers.GetAll())
        {
            Console.WriteLine(number);
        }

        int x = 5;
        int y = 15;

        Console.WriteLine($"\nДо Swap: x = {x}, y = {y}");

        Helper.Swap(ref x, ref y);

        Console.WriteLine($"После Swap: x = {x}, y = {y}");
    }
}