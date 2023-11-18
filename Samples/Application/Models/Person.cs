using System;

namespace Models
{
    public class Person
    {
        public Guid Id { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person()
        {
            Id = Guid.NewGuid();
        }
        public Person(string firstName, string lastName)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
        }

        public void PrintPersonData()
        {
            Console.WriteLine($"Firstname: {this.FirstName}");
            Console.WriteLine($"Lastname: {this.LastName}");
        }
    }
}
