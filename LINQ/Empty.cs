namespace Empty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emptyCollection1 = Enumerable.Empty<string>();
            var emptyCollection2 = Enumerable.Empty<string>();

            Console.WriteLine("Count: {0} ", emptyCollection1.Count());
            Console.WriteLine("Type: {0} ", emptyCollection1.GetType().Name);

            Console.WriteLine("Count: {0} ", emptyCollection2.Count());
            Console.WriteLine("Type: {0} ", emptyCollection2.GetType().Name);
        }
    }
}