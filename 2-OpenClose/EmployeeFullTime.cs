
namespace OpenClose
{
    public class EmployeeFullTime : Employee
    {
        private const decimal hourValue = 30000M;
        public EmployeeFullTime(string fullname, int hoursWorked) : base(fullname, hoursWorked)
        {
        }

        public override decimal CalculateSalaryMonthly()
        {   
            return hourValue * HoursWorked;
        }
    }
}