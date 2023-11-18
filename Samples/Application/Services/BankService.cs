using Models;

namespace Services
{
    public static class BankService
    {
        /// <summary>
        /// Counts owner salary. Explicit conversions to int.
        /// (profit - expenses) / owners number.
        /// </summary>
        /// <param name="employee">Owner (an Employee instance).</param>
        /// <param name="accountingData">Accounting data.</param>
        public static void CountOwnerSalary(Employee employee, AccountingData accountingData)
        {
            employee.Salary = (int)((accountingData.Income - accountingData.Outcome) / accountingData.OwnerAmount);
        }

        /// <summary>
        /// Converts client into employee.
        /// </summary>
        /// <param name="client">Client instance for recruiting.</param>
        /// <param name="position">Position for a new employee.</param>
        /// <returns>New employee instance.</returns>
        public static Employee RecruitClient(Client client, string position)
        {
            Employee employee = client;
            employee.Position = position;
            return employee;
        }
    }
}
