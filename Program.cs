namespace ConsoleApp9
{
    public class BankAccount
    {
        private decimal balance;
        public event Action<string> Notify;
        public BankAccount(decimal initialBalance = 0)
        {
            balance = initialBalance;
        }
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Notify?.Invoke("Ошибка: сумма пополнения должна быть положительной.");
                return;
            }
            balance += amount;
            Notify?.Invoke($"Счет пополнен на {amount}. Баланс: {balance}");
        }
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Notify?.Invoke("Ошибка: сумма снятия должна быть положительной.");
                return;
            }
            if (amount > balance)
            {
                Notify?.Invoke($"Ошибка: недостаточно средств. Запрошено {amount}, доступно {balance}");
                return;
            }
            balance -= amount;
            Notify?.Invoke($"Со счета снято {amount}. Баланс: {balance}");
        }
    }
    public class Program
    {
        static void ConsoleLogger(string message)
        {
            Console.WriteLine($"[Метод] {message}");
        }
        static void Main(string[] args)
        {
            var acc = new BankAccount(10000);

            acc.Notify += ConsoleLogger;
            acc.Notify += delegate (string msg)
            {
                Console.WriteLine($"[Delegate] {msg}");
            };
            acc.Notify += msg => Console.WriteLine($"[Лямбда] {msg}");
            acc.Withdraw(2500);
            Console.WriteLine("\nПосле отписки от ConsoleLogger");
            acc.Notify -= ConsoleLogger;
            acc.Withdraw(1000);
            Console.WriteLine("\nОтписка лямбды без переменной (не работает)");
            acc.Notify -= msg => Console.WriteLine($"[Лямбда] {msg}");
            acc.Withdraw(500);
            Console.WriteLine("\nОтписка через переменную");
            Action<string> lambdaHandler = msg => Console.WriteLine($"[Лямбда-2] {msg}");
            acc.Notify += lambdaHandler;
            acc.Withdraw(100);
            acc.Notify -= lambdaHandler;
            acc.Withdraw(100);

            Console.ReadKey();
        }
    }
}
