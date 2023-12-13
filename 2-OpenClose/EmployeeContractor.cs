namespace OpenClose
{
    public class EmployeeContractor : Employee
    {
        public EmployeeContractor(string fullname, int hoursWorked) : base(fullname, hoursWorked)
        {
        }

        public override decimal CalculateSalaryMonthly()
        {
            throw new NotImplementedException();
        }
    }
}