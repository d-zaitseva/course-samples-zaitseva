using System;
using System.ComponentModel;
using Models;
using Services;

namespace PracticeWithTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var queueControl = new QueueControl(5);

            queueControl.Notify += PrintMessage;
            queueControl.Enqueue("Tom");
            queueControl.Enqueue("Bob");
            queueControl.Enqueue("Sam");
            queueControl.Enqueue("Bill");
            queueControl.Enqueue("John");

            queueControl.Enqueue("Shon");
            queueControl.Enqueue("Ketty");
            try
            {
                queueControl.Dequeue();
                queueControl.Dequeue();
                queueControl.Dequeue();
                queueControl.Dequeue();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            queueControl.Clear();

            void PrintMessage(string message)
            {
                Console.WriteLine(message);
            }

            //INotifyPropertyChanged
            PropertyChangedEventHandler printOnPropertyChanged = delegate
            {
                Console.WriteLine("Position was changed");
            };

            BindingList<Employee> employeeList = new BindingList<Employee>();
            employeeList.Add(new Employee("Petr", "Ivanov"));
            employeeList.Add(new Employee("Ivan", "Sidorov"));
            employeeList.Add(new Employee("Vasiliy", "Pupkin"));

            employeeList[0].PropertyChanged += printOnPropertyChanged;

            employeeList[0].Position = "C# Developer";
            employeeList[1].Position = "Java Developer";

            NumberAnaliser na = new NumberAnaliser(20, 10);
            na.Notify += PrintMessage;
            int[] arr = new int[10];
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                arr[i] = random.Next(1, 50);
            }

            foreach (int i in arr)
            {
                na.AnalizeNumber(i);
            }
            Console.ReadLine();
        }

        /// <summary>
        /// Updates employee's contract.
        /// </summary>
        /// <param name="employee">Employee.</param>
        static void UpdateEmployeeContract(Employee employee, string contract)
        {
            employee.Contract = contract;
        }

        /// <summary>
        /// Updates Currency
        /// </summary>
        /// <param name="currency">
        /// Currency as reference (ref) in order to update the instance.
        /// Currency is a structure and structure is a Value type that pass copy to the method by default.
        /// To update the instance should be passed not a copy but reference.
        /// </param>
        /// <param name="name"></param>
        static void UpdateCurrencyCountry(ref Currency currency, string name)
        {
            currency.Name = name;
            Console.WriteLine($"Currency name updated by ref");
        }
    }
}
