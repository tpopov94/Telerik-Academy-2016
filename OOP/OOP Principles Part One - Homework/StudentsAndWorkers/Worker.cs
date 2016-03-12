namespace StudentsAndWorkers
{

    public class Worker : Human
    {
        //Constructors

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursByDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursByDay = workHoursByDay;
        }
        // Properties

        public decimal WeekSalary { get; set; }

        public int WorkHoursByDay { get; set; }

        // Methods

        public decimal MoneyPerHours()
        {
            return ((this.WeekSalary / 5) / this.WorkHoursByDay);
        }
    }
}
