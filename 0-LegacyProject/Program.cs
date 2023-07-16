using System;

namespace _0_LegacyProject
{
    public class Person
    {
        public string Name { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person()
            {
                Name = "name",
            };

            Console.WriteLine(person.Name);
        }
    }
}
