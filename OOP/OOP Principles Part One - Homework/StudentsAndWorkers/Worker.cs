namespace StudentsAndWorkers
{
    public class Worker : Human
    {
        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursByDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursByDay = workHoursByDay;
        }

        public decimal WeekSalary { get; set; }

        public int WorkHoursByDay { get; set; }

        public decimal MoneyPerHours()
        {
            return ((this.WeekSalary / 5) / this.WorkHoursByDay);
        }
    }
}
