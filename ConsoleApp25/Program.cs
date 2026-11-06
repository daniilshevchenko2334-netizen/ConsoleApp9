public delegate void TaskNotification(string message);

public class TaskProcessor
{
    private TaskNotification onStatusChanged;

    public void RegisterHandler(TaskNotification handler)
    {
        onStatusChanged += handler;
    }

    public void UnregisterHandler(TaskNotification handler)
    {
        onStatusChanged -= handler;
    }

    public void ExecuteTask(string taskName)
    {
        onStatusChanged?.Invoke($"Задача '{taskName}' начата.");

        Console.WriteLine($"Выполняется задача: {taskName}...");

        onStatusChanged?.Invoke($"Задача '{taskName}' завершена.");
    }
}

public class Program
{
    public static void LogToConsole(string message)
    {
        Console.WriteLine("[КОНСОЛЬ]: " + message);
    }

    public static void Main()
    {
        TaskProcessor processor = new TaskProcessor();

        processor.RegisterHandler(LogToConsole);

        processor.RegisterHandler(
            delegate (string msg)
            {
                Console.WriteLine("[ЛОГ ФАЙЛА]: " + msg);
            }
        );

        Console.WriteLine("Первая задача");
        processor.ExecuteTask("Обработка данных");

        processor.UnregisterHandler(LogToConsole);

        Console.WriteLine("\nВторая задача");
        processor.ExecuteTask("Сохранение результатов");

        Console.WriteLine("\nПрограмма завершена.");
    }
}