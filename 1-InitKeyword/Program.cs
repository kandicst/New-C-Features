namespace InitKeyword;

public static class C
{
    public class Person
    {
        public string Name { get; set; }
    }

    public static void Main()
    {
        var person = new Person()
        {
            Name = "John Doe",
        };

        Console.WriteLine(person.Name);

        person.Name = "some other name";
    }
}