namespace Repeat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var intCollection = Enumerable.Repeat<int>(20, 21);
            Console.WriteLine("Total Count: {0} ", intCollection.Count());
            //inf esimeen arv kuni 2 arvu lõppuni
            for (int i = 0; i < intCollection.Count(); i++)
                Console.WriteLine("Value at index {0} : {1}", i, intCollection.ElementAt(i));
        }
    }
}