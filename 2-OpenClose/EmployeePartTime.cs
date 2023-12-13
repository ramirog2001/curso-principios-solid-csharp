namespace OpenClose
{
    public class EmployeePartTime : Employee
    {
        private const decimal hourValue = 20000M;
        private const decimal effortCompensation = 5000M;
                
        public EmployeePartTime(string fullname, int hoursWorked) : base(fullname, hoursWorked)
        {
        }

        public override decimal CalculateSalaryMonthly()
        {
            decimal salary = hourValue * HoursWorked;
            if (HoursWorked > 160) {
                int extraDays = HoursWorked - 160;
                salary += effortCompensation * extraDays;
            }
            return salary;
        }
    }
}