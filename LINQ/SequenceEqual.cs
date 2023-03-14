namespace SequenceEqual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<string> strList1 = new List<string>() { "red", "green", "blue" }; // kas on sama järjestus

            IList<string> strList2 = new List<string>() { "red", "blue", "green" };

            bool isEqual = strList1.SequenceEqual(strList2); 
            Console.WriteLine(isEqual);
        }
    }
}