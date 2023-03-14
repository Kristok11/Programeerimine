namespace DefaultIfEmpty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<string> emptyList = new List<string>();

            var newList1 = emptyList.DefaultIfEmpty();
            var newList2 = emptyList.DefaultIfEmpty("3");

            Console.WriteLine("Count: {0}", newList1.Count());
            Console.WriteLine("Value: {0}", newList1.ElementAt(0));

            Console.WriteLine("Count: {0}", newList2.Count());
            Console.WriteLine("Value: {0}", newList2.ElementAt(0));
        }
    }
}