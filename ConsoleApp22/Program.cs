namespace ConsoleApp22;

public abstract class Entity
{
    public int Id { get; set; }

    public abstract void GetEntityDetails();
}

public class User : Entity
{
    public string Name { get; set; }

    public User(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public override void GetEntityDetails()
    {
        Console.WriteLine($"User: Id = {Id}, Name = {Name}");
    }
}

public class Product : Entity
{
    public string Name { get; set; }

    public Product(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public override void GetEntityDetails()
    {
        Console.WriteLine($"Product: Id = {Id}, Name = {Name}");
    }
}

public class Repository<T> where T : Entity
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

    public T FindById(int id)
    {
        foreach (T item in items)
        {
            if (item.Id == id)
            {
                return item;
            }
        }

        return null;
    }

    public void PrintAllDetails()
    {
        foreach (T item in items)
        {
            item.GetEntityDetails();
        }
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
        Repository<User> users = new Repository<User>();

        users.Add(new User(1, "Вовик"));
        users.Add(new User(2, "Даунил"));
        users.Add(new User(3, "Олинко"));

        Console.WriteLine("Количество пользователей: " + users.Count);

        Console.WriteLine("\nВсе пользователи:");
        users.PrintAllDetails();

        Console.WriteLine("\nПоиск пользователя с Id = 2:");

        User user = users.FindById(2);

        if (user != null)
        {
            user.GetEntityDetails();
        }
        else
        {
            Console.WriteLine("Пользователь не найден");
        }

        Console.WriteLine("\nПоиск пользователя с Id = 10:");

        User notFound = users.FindById(10);

        if (notFound != null)
        {
            notFound.GetEntityDetails();
        }
        else
        {
            Console.WriteLine("Пользователь не найден");
        }
    }
}