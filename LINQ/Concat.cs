namespace Concat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<string> collection1 = new List<string>() { "eesel", "koer" };
            IList<string> collection2 = new List<string>() { "3", "elevant" }; 
            // järjestikus vasakult paremale ülevalt alla

            var collection3 = collection1.Concat(collection2);

            foreach (string str in collection3)
                Console.WriteLine(str);
        }
    }
}