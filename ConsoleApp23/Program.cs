public class UserEntity
{
    public int Id { get; set; }
    public string Role { get; set; }
    public string Name { get; set; }

    public UserEntity(int id, string role, string name)
    {
        Id = id;
        Role = role;
        Name = name;
    }

    public override string ToString()
    {
        return $"Id: {Id}, Роль: {Role}, Имя: {Name}";
    }
}


public class ProductEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }

    public ProductEntity(int id, string name, double price)
    {
        Id = id;
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return $"Id: {Id}, Товар: {Name}, Цена: {Price} тг.";
    }
}


public class Repository<T>
{
    private List<T> items = new List<T>();


    public void Add(T item)
    {
        items.Add(item);
    }


    public void PrintAllDetails()
    {
        foreach (T item in items)
        {
            Console.WriteLine(item);
        }
    }

    public T FindById(int id)
    {
        foreach (T item in items)
        {

            var property = typeof(T).GetProperty("Id");

            if (property != null)
            {
                int itemId = (int)property.GetValue(item);

                if (itemId == id)
                {
                    return item;
                }
            }
        }

        return default(T);
    }
    public static void Swap<TValue>(ref TValue first, ref TValue second)
    {
        TValue temp = first;
        first = second;
        second = temp;
    }
}


class Program
{
    static void Main()
    {


        Repository<UserEntity> userRepository =
            new Repository<UserEntity>();


        UserEntity user1 =
            new UserEntity(
                1,
                "Администратор",
                "Зарина"
            );

        UserEntity user2 =
            new UserEntity(
                2,
                "Менеджер",
                "Даунил"
            );
        userRepository.Add(user1);
        userRepository.Add(user2);
        Repository<ProductEntity> productRepository =
            new Repository<ProductEntity>();


        ProductEntity product1 =
            new ProductEntity(
                1,
                "Ноутбук",
                250000
            );

        ProductEntity product2 =
            new ProductEntity(
                2,
                "Мышь",
                5000
            );

        ProductEntity product3 =
            new ProductEntity(
                3,
                "Клавиатура",
                15000
            );
        productRepository.Add(product1);
        productRepository.Add(product2);
        productRepository.Add(product3);
        userRepository.PrintAllDetails();
        productRepository.PrintAllDetails();

        int searchId = 2;

        ProductEntity foundProduct =
            productRepository.FindById(searchId);

        if (foundProduct != null)
        {
            Console.WriteLine(
                $"Товар с Id = {searchId} найден:"
            );

            Console.WriteLine(foundProduct);
        }
        else
        {
            Console.WriteLine(
                $"Товар с Id = {searchId} не найден."
            );
        }

        Console.WriteLine("До обмена:");

        Console.WriteLine(
            $"product1: {product1}"
        );

        Console.WriteLine(
            $"product2: {product2}"
        );


        Repository<ProductEntity>.Swap(
            ref product1,
            ref product2
        );


        Console.WriteLine();

        Console.WriteLine("После обмена:");

        Console.WriteLine(
            $"product1: {product1}"
        );

        Console.WriteLine(
            $"product2: {product2}"
        );
        Console.WriteLine("До обмена:");

        Console.WriteLine(
            $"user1: {user1}"
        );

        Console.WriteLine(
            $"user2: {user2}"
        );


        Repository<UserEntity>.Swap(
            ref user1,
            ref user2
        );


        Console.WriteLine();

        Console.WriteLine("После обмена:");

        Console.WriteLine(
            $"user1: {user1}"
        );

        Console.WriteLine(
            $"user2: {user2}"
        );

        Console.ReadKey();
    }
}
