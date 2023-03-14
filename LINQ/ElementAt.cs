namespace ElementAt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3, 4 ,5 };
            var firstNumber = numbers.ElementAt(4);
            Console.WriteLine($"First number: {firstNumber}"); 
        }
    }
}