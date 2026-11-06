namespace ConsoleApp4
{
    public class CounterFactory
    {
        public Func<int> CreateCounter(int startValue, int step)
        {
            int counter = startValue;
            return () =>
            {
                counter += step;
                return counter;
            };
        }
    }
    class Program
    {
        static void Main()
        {
            var factory = new CounterFactory();
            var counterA = factory.CreateCounter(0, 5);
            var counterB = factory.CreateCounter(100, 10);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"A: {counterA()}");
                Console.WriteLine($"B: {counterB()}");
            }
        }
    }
}
