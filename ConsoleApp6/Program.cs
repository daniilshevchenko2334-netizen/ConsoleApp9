namespace ConsoleApp6
{
    public class HistoryLoggerService
    {
        public Action<string> CreateLogger()
        {
            var history = new List<string>();

            return message =>
            {
                if (message == "PRINT_HISTORY")
                {
                    for (int i = 0; i < history.Count; i++)
                        Console.WriteLine($"{i + 1}. {history[i]}");
                }
                else
                {
                    history.Add(message);
                }
            };
        }
    }
    class Program
    {
        static void Main()
        {
            var logger = new HistoryLoggerService().CreateLogger();
            logger("Сообщение 1");
            logger("Сообщение 2");
            logger("Сообщение 3");
            logger("Сообщение 4");
            logger("PRINT_HISTORY");
        }
    }
}