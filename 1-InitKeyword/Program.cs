namespace InitKeyword;

public static class C
{
    public class Person
    {
        public string Name { get; init; }
    }

    public static void Main()
    {
        var person = new Person()
        {
            Name = "John Doe",
            LastName = "",
        };

        Console.WriteLine(person.Name);

        person.Name = "some other name";
    }
}