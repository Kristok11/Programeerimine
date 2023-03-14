namespace Last_LastOrDefault
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dates = new List<DateTime>
        {
            new DateTime(2023, 2, 3),
            new DateTime(2023, 4, 1),
            new DateTime(2022, 2, 1)
        };
            var algus = dates.Last();
            var lõpp = dates.LastOrDefault(date => date.Year == 2023);
            Console.WriteLine($"Algus kuupäev: {algus}");
            Console.WriteLine($"Lõpp kuupäev: {lõpp}");

        }
    }
}