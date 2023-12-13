namespace OpenClose
{
    public class EmployeePartTime : IEmployee
    {
        public string Fullname { get; set; }
        public int HoursWorked { get; set; }
        private const decimal hourValue = 20000M;
        private const decimal effortCompensation = 5000M;
                
        public EmployeePartTime(string fullname, int hoursWorked) => (Fullname, HoursWorked) = (fullname, hoursWorked);


        public decimal CalculateSalaryMonthly()
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