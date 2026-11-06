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
    public static void ShowNotification(string message)
    {
        Console.WriteLine($"[Уведомление] {message}");
    }

    public static void Main()
    {
        TaskProcessor processor = new TaskProcessor();

        processor.RegisterHandler(ShowNotification);

        processor.ExecuteTask("Обработка данных");

        processor.UnregisterHandler(ShowNotification);

        Console.WriteLine("\nОбработчик удален.");

        processor.ExecuteTask("Вторая задача");
    }
}