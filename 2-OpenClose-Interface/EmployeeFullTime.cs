
namespace OpenClose
{
    public class EmployeeFullTime : IEmployee
    {
        public string Fullname { get; set; }
        public int HoursWorked { get; set; }
        private const decimal hourValue = 30000M;
        public EmployeeFullTime(string fullname, int hoursWorked) => (Fullname, HoursWorked) = (fullname, hoursWorked);


        public decimal CalculateSalaryMonthly()
        {   
            return hourValue * HoursWorked;
        }
    }
}