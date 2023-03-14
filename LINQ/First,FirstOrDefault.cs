namespace First_FirstOrDefault
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Anne", "Bob", "Kivirähk", "Toomas" };
            var firstPerson = names.First();
            var missingPerson = names.FirstOrDefault(name => name.StartsWith("T")); 
            Console.WriteLine($"First person: {firstPerson}"); 
            Console.WriteLine($"Missing person: {missingPerson}"); 
            
        }
    }
}