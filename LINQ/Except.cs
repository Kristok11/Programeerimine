namespace Except
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<string> animalList1 = new List<string>() { "Cat", "Dog", "Elephant", "Lion", "Monkey" };
            IList<string> animalList2 = new List<string>() { "Lion", "Monkey", "Giraffe", "Tiger", "Zebra" };

            var result = animalList1.Except(animalList2);

            foreach (string animal in result)
                Console.WriteLine(animal);

        }
    }
}