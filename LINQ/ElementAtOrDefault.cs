namespace ElementAtOrDefault
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3 };
            var thirdNumber = numbers.ElementAtOrDefault(2); 
            Console.WriteLine($"Third number: {thirdNumber}"); 
        }
    }
}