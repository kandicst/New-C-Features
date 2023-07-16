using System;

namespace _0_LegacyProject
{
    public class Person
    {
        public string Name { get; set; }
        private readonly string _lastName;

        public string LastName { get => _lastName; init => _lastName = value; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person()
            {
                Name = "name",
                LastName = "",
            };

            person.LastName = "";

            Console.WriteLine(person.Name);
        }
    }
}
