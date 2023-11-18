namespace Models
{
    public class Client : Person
    {
        public string Phone { get; set; }
        public int Age { get; set; }

        public Client() : base() { }
        public Client(string firstName, string lastName) : base(firstName, lastName) { }

        public Client(string firstName, string lastName, string phone, int age) : base(firstName, lastName)
        {
            Phone = phone;
            Age = age;
        }
    }
}
