namespace ConsoleApp5
{
    public class BankClosureService
    {
        public (Action<double> Deposit, Func<double> GetBalance) CreateAccount(double initialBalance)
        {
            double balance = initialBalance;

            Action<double> deposit = amount =>
            {
                balance += amount;
                Console.WriteLine($"Счет успешно пополнен на {amount}");
            };

            Func<double> getBalance = () => balance;

            return (deposit, getBalance);
        }
    }
    class Program
    {
        static void Main()
        {
            var bank = new BankClosureService();
            var (deposit, getBalance) = bank.CreateAccount(1000.0);
            deposit(250.5);
            deposit(100);
            deposit(49.5);
            Console.WriteLine($"Баланс: {getBalance()}");
        }
    }
}

