namespace NullableReferenceTypes;

public static class C
{
    public class Person
    {
        public string Name { get; init; }

        public override string ToString()
        {
            return $"My name is: {Name}";
        }
    } 

    public static class PersonRepository
    {
        public static Dictionary<string, Person> database = new();

        public static Person GetPersonByName(string name)
        {
            if (database.ContainsKey(name))
            {
                return database[name];
            }

            return null;
        }
    }

    public static void Main()
    {
        var person = PersonRepository.GetPersonByName("name");

        Console.WriteLine($"My name is {person.Name}");
    }
}