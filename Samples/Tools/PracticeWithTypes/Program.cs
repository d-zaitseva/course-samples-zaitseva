using System;
using Models;
using Services;

namespace PracticeWithTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Petr", "Ivanov", "C# developer");
            Currency ruRub = new Currency("Ruble", "RUB");
            string contract = $"Contract of {employee.FirstName} {employee.LastName} should be signed by the December, 1st";

            UpdateEmployeeContract(employee, contract);
            
            Console.WriteLine();
            //print employee name
            employee.PrintPersonData();
            Console.WriteLine(employee.Contract);

            Console.WriteLine();

            Console.WriteLine($"Currency name before update - {ruRub.Name}");
            //update currency name
            UpdateCurrencyCountry(ref ruRub, "Russian Ruble");

            Console.WriteLine($"Currency name after update - {ruRub.Name}");

            Console.WriteLine();

            Employee newEmployee = BankService.RecruitClient(new Client("S", "S"), "QA");
            newEmployee.PrintPersonData();
            Console.WriteLine(newEmployee.Position);
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
