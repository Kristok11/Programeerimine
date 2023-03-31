using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Muutujad Muutujad = new Muutujad();
        Data data = new Data();

        Console.WriteLine("Valige meetod:");
        Console.WriteLine("1. Range");
        Console.WriteLine("2. Contains");
        Console.WriteLine("3. ThenBy");
        Console.WriteLine("4. LastOrDefault");
        Console.WriteLine("5. Faili salvestamine");
        Console.WriteLine("6. Püramiid");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("---------------------------------------------------------------");
                Muutujad.Range(data.Start, data.End);
                break;
            case 2:
                Console.WriteLine("---------------------------------------------------------------");
                bool result = Muutujad.ContainsValue(data.Array, data.Value);
                Console.WriteLine(result);
                break;
            case 3:
                Console.WriteLine("---------------------------------------------------------------");
                var sortedPersons = Muutujad.SortByAgeThenByName(data.Persons);
                foreach (var person in sortedPersons)
                {
                    Console.WriteLine(person.Name + " " + person.Age);
                }
                break;
            case 4:
                Console.WriteLine("---------------------------------------------------------------");
                int lastNumber = Muutujad.GetLastOrDefault(data.Numbers);
                Console.WriteLine(lastNumber);
                break;

            case 5:
                tekst();
                break;

            case 6:
                püramid();
                break;

        }
    }
    public static void tekst()
    {
        try
        {
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Sisesta faili nimi:");
            string fileName = Console.ReadLine();
            Console.WriteLine("Sisesta kausta asukoha teekond:");
            string folderPath = Console.ReadLine();
            string filePath = Path.Combine(folderPath, fileName);
            Console.WriteLine("Sisesta tekst:");
            string text = Console.ReadLine();
            File.WriteAllText(filePath, text);
            Console.WriteLine("Tekst edukalt faili salvestatud: " + filePath);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error faili salvestamisel: " + ex.Message);
        }
    }

    public static void püramid()
    {
        int numRows, spaces, num = 1;

        Console.WriteLine("---------------------------------------------------------------");
        Console.Write("Sisesta reade arv: ");

        if (!int.TryParse(Console.ReadLine(), out numRows) || numRows < 1)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");

        }

        spaces = numRows + 4 - 1;
        for (int row = 1; row <= numRows; row++)
        {
            for (int spaceCount = spaces; spaceCount >= 1; spaceCount--)
            {
                Console.Write(" ");
            }


            for (int numCount = 1; numCount <= row; numCount++)
            {
                Console.Write("{0} ", num++);
            }

            Console.WriteLine();
            spaces--;
        }

    }


    public class Muutujad
    {
        public void Range(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i);
            }
        }

        public bool ContainsValue(int[] array, int value)
        {
            return array.Contains(value);
        }

        public List<Person> SortByAgeThenByName(List<Person> persons)
        {
            return persons.OrderBy(p => p.Age).ThenBy(p => p.Name).ToList();
        }

        public int GetLastOrDefault(int[] array)
        {
            return array.LastOrDefault();
        }
    }

    public class Data
    {
        public int Start { get; set; } = 1;
        public int End { get; set; } = 10;
        public int[] Array { get; set; } = { 1, 2, 3, 4, 5 };
        public int Value { get; set; } = 3;
        public List<Person> Persons { get; set; } = new List<Person>()
    {
        new Person { Name = "John", Age = 25 },
        new Person { Name = "Jane", Age = 30 },
        new Person { Name = "Bob", Age = 20 }
    };
        public int[] Numbers { get; set; } = { 1, 2, 3, 4, 5 };
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}





