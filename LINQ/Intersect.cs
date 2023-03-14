namespace Intersect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<string> letterList1 = new List<string>() { "a", "b", "c", "d", "e" };
            IList<string> letterList2 = new List<string>() { "c", "d", "e", "f", "g" };
            // 1 listist võttab 2 samad tähed
            var result = letterList1.Intersect(letterList2);

            foreach (string letter in result)
                Console.WriteLine(letter);

        }
    }
}