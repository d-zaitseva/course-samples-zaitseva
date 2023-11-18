namespace Models
{
    public class Employee : Person
    {
        public string Position { get; set; }
        public string Contract { get; set; }
        public int Salary { get; set; }

        public Employee() : base() { }
        public Employee(string firstName, string lastName) : base(firstName, lastName) { }

        public Employee(string firstName, string lastName, string position) : base(firstName, lastName)
        {
            Position = position;
        }

        public Employee(string firstName, string lastName, int salary) : base(firstName, lastName)
        {
            Salary = salary;
        }

        public static implicit operator Employee(Client client) => new Employee(client.FirstName, client.LastName);
    }
}
