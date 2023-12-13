namespace OpenClose
{
    public class EmployeeContractor : IEmployee
    {
        public string Fullname { get; set; }
        public int HoursWorked { get; set; }
        public EmployeeContractor(string fullname, int hoursWorked) => (Fullname, HoursWorked) = (fullname, hoursWorked);


        public decimal CalculateSalaryMonthly()
        {
            throw new NotImplementedException();
        }
    }
}