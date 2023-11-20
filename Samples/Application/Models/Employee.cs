using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Models
{
    public class Employee : Person, INotifyPropertyChanged
    {
        private string _position;

        public event PropertyChangedEventHandler PropertyChanged;
        public string Contract { get; set; }
        public int Salary { get; set; }
        public string Position
        {
            get
            {
                return _position;
            }
            set
            {
                if (value != _position)
                {
                    this._position = value;
                    NotifyPropertyChanged();
                }
            }
        }

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

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
